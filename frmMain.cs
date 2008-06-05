using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace GameResourcesMonitor
{
    public partial class frmMain : Form
    {

        int editalert;
        bool starting = true;
        bool donotsave = false;

        public frmMain()
        {
            InitializeComponent();
        }

        private void timerRes_Tick(object sender, EventArgs e)
        {
            recalc_res();
            foreach (DataGridViewRow arow in datagrid_alertes.Rows)
            {
                if (arow.IsNewRow) continue;
                int a = (int)arow.Cells[idalerteDataGridViewTextBoxColumn1.Index].Value;
                bool raise = true;
                string desc = "";
                TimeSpan reste = TimeSpan.Zero;
                TimeSpan restetmp = TimeSpan.Zero;

                foreach (DataGridViewRow rrow in datagrid_res.Rows)
                {
                    if (rrow.IsNewRow) continue;
                    int r = (int)rrow.Cells[id_ressource.Index].Value;
                    int qr = (int)rrow.Cells[qteDataGridViewTextBoxColumn.Index].Value;
                    int prod = (int)rrow.Cells[prodDataGridViewTextBoxColumn.Index].Value;
                    uint delay = (uint)rrow.Cells[delayDataGridViewComboBoxColumn.Index].Value;
                    int qv = 0;

                    DataRow rarow = data.Tables["ResAlerte"].Rows.Find(new object[] { a, r });
                    if (rarow != null) qv = (int)rarow.ItemArray[2];
                    if (qr < qv) raise = false;
                    desc += "\n"+rrow.Cells[typeDataGridViewTextBoxColumn.Index].Value+": "+qr+"/"+qv;

                    int m = 0;
                    if (qr < qv) m = (int)(((float)(qv - qr) / (float)prod) * delay);
                    
                    restetmp = new TimeSpan(0,m,0);
                    if (reste == null || reste < restetmp) reste = restetmp;
                }
                
                arow.Cells[tempsrestant_col.Index].Value = reste.ToString();
                if (reste > TimeSpan.Zero)
                {
                    DateTime datefin = DateTime.Now.Add(reste);
                    datefin = datefin.AddSeconds(-datefin.Second);
                    arow.Cells[col_heurefin.Index].Value = datefin.ToString();
                }
                else arow.Cells[col_heurefin.Index].Value = "OK";

                if (raise && arow.Cells[alerteDataGridViewCheckBoxColumn.Index].Value!=null && arow.Cells[alerteDataGridViewCheckBoxColumn.Index].Value.ToString()=="1")
                {
                    arow.Cells[alerteDataGridViewCheckBoxColumn.Index].Value = false;
                    tray.BalloonTipIcon = ToolTipIcon.Warning;
                    tray.BalloonTipText = "Niveau d'alerte atteint:\n\n" + arow.Cells[textDataGridViewTextBoxColumn.Index].Value + "\n" + desc;
                    tray.ShowBalloonTip(30000);
                }
            }
        }

        private void Minimize()
        {
            this.WindowState = FormWindowState.Minimized;
            Application.DoEvents();
            this.Visible = false;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (File.Exists("grm.xml"))
            {
                try
                {
                    data.ReadXml("grm.xml");
                }
                catch (Exception err)
                {
                    DialogResult r = MessageBox.Show("Erreur lors de la lecture des données:\n\n" + err.Message + "\n\nCliquez sur 'Abandonner' ou 'Abort' pour effacer la base.", "Game Resources Monitor", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                    if (r == DialogResult.Abort) data.Clear();
                    else if (r == DialogResult.Retry)
                    {
                        MessageBox.Show("L'application va se terminer. Fermez toutes les autres applications suceptibles d'utiliser le fichier de données et réessayez !", "Game Resources Monitor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        donotsave = true;
                        Application.Exit();
                    }
                }
            }

            data.Tables["Delais"].Clear();
            data.Tables["Delais"].Rows.Add(new object[] { 1, "Minutes" });
            data.Tables["Delais"].Rows.Add(new object[] { 60, "Heures" });
            data.Tables["Delais"].Rows.Add(new object[] { 24*60, "Jours" });

            Application.DoEvents();
            recalc_res();
            starting = false;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (donotsave) return;

            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult r = MessageBox.Show("Vous êtes sur le point de quitter l'application... Ne voulez-vous pas plutôt juste réduire la fenêtre ?", "Game Resources Monitor", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (r == DialogResult.Cancel)
                {
                    e.Cancel = true;
                    return;
                }
                if (r == DialogResult.Yes)
                {
                    Minimize();
                    e.Cancel = true;
                    return;
                }
            }

            data.Tables["Delais"].Clear();
            data.WriteXml("grm_cache.xml");
            if (File.Exists("grm.xml")) File.Delete("grm.xml");
            File.Move("grm_cache.xml", "grm.xml");
        }

        private void datagrid_res_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == qteDataGridViewTextBoxColumn.Index)
            {
                datagrid_res.Rows[e.RowIndex].Cells[baseqteDataGridViewTextBoxColumn.Index].Value = datagrid_res.Rows[e.RowIndex].Cells[qteDataGridViewTextBoxColumn.Index].Value;
                datagrid_res.Rows[e.RowIndex].Cells[syncDataGridViewTextBoxColumn.Index].Value = DateTime.Now;
            }
        }

        private void recalc_res()
        {
            foreach (DataGridViewRow row in datagrid_res.Rows)
            {
                if (row.IsNewRow) continue;
                int baseqte = (int) row.Cells[baseqteDataGridViewTextBoxColumn.Index].Value;
                int prod = (int) row.Cells[prodDataGridViewTextBoxColumn.Index].Value;
                uint delay = (uint) row.Cells[delayDataGridViewComboBoxColumn.Index].Value;
                DateTime sync = (DateTime)row.Cells[syncDataGridViewTextBoxColumn.Index].Value;
                TimeSpan ts = DateTime.Now.Subtract(sync);
                double news = ts.TotalMinutes/delay;

                row.Cells[qteDataGridViewTextBoxColumn.Index].Value = baseqte + (prod*news);
            }
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized) this.Visible = false;
        }

        private void tray_DoubleClick(object sender, EventArgs e)
        {
            Affiche();
        }

        private void tray_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                trayContextMenu.Show();
            }
            else if (e.Button == MouseButtons.Left)
            {
                tray.BalloonTipText = "\tRessources:\n";
                foreach (DataGridViewRow row in datagrid_res.Rows)
                {
                    if (row.IsNewRow) continue;
                    tray.BalloonTipText += "\n" + row.Cells[typeDataGridViewTextBoxColumn.Index].Value + ": " + row.Cells[qteDataGridViewTextBoxColumn.Index].Value;
                }
                tray.BalloonTipText += "\n\n\tAlertes:\n";
                foreach (DataGridViewRow row in datagrid_alertes.Rows)
                {
                    if (row.IsNewRow) continue;
                    if (row.Cells[alerteDataGridViewCheckBoxColumn.Index].Value == null || row.Cells[alerteDataGridViewCheckBoxColumn.Index].Value.ToString() != "1") continue;
                    string val="Inconnu...";
                    if (row.Cells[tempsrestant_col.Index].Value != null) val = (string)row.Cells[tempsrestant_col.Index].Value;
                    tray.BalloonTipText += "\n" + row.Cells[textDataGridViewTextBoxColumn.Index].Value + ": " + val;
                }
                tray.BalloonTipIcon = ToolTipIcon.Info;
                tray.ShowBalloonTip(5000);
            }
        }

        private void afficherLinterfaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Affiche();
        }

        private void Affiche()
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ressourcesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPageRes);
            Affiche();
        }

        private void alertesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPageAlert);
            Affiche();
        }

        private void datagrid_resalerte_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = datagrid_resalerte.Rows[e.RowIndex];
            DataRow drow = data.Tables["ResAlerte"].Rows.Find(new object[] { editalert, row.Cells[idDataGridViewTextBoxColumn1.Index].Value });
            if (drow != null) drow.Delete();

            if (row.Cells[qteDataGridViewTextBoxColumn1.Index].Value == null) return;
            try
            {
                int qte = int.Parse(row.Cells[qteDataGridViewTextBoxColumn1.Index].Value.ToString());
                data.Tables["ResAlerte"].Rows.Add(new object[] { editalert, row.Cells[idDataGridViewTextBoxColumn1.Index].Value, qte });
            }
            catch (FormatException)
            {
                row.Cells[qteDataGridViewTextBoxColumn1.Index].Value = null;
            }
        }

        private void datagrid_alertes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == btnEditResAlerte.Index)
            {
                if (e.RowIndex < 0) return;
                if (starting) return;
                DataGridViewRow row = datagrid_alertes.Rows[e.RowIndex];
                if (row.IsNewRow)
                {
                    datagrid_resalerte.Visible = false;
                    lblResAlerte.Text = "Veuillez sélectionner une alerte...";
                    return;
                }
                lblResAlerte.Text = "Ressources de l'alerte <" + row.Cells[textDataGridViewTextBoxColumn.Index].Value + ">:";
                editalert = (int)row.Cells[idalerteDataGridViewTextBoxColumn1.Index].Value;
                datagrid_resalerte.Visible = true;

                foreach (DataGridViewRow rrow in datagrid_resalerte.Rows)
                {
                    object value = null;
                    DataRow rarow = data.Tables["ResAlerte"].Rows.Find(new object[] { editalert, rrow.Cells[idDataGridViewTextBoxColumn1.Index].Value });
                    if (rarow != null) value = rarow.ItemArray[2];
                    rrow.Cells[qteDataGridViewTextBoxColumn1.Index].Value = value;
                }
            }
        }


    }
}