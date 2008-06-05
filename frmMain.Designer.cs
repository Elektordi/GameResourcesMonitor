namespace GameResourcesMonitor
{
    partial class frmMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.datagrid_res = new System.Windows.Forms.DataGridView();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delayDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.data = new System.Data.DataSet();
            this.TableResources = new System.Data.DataTable();
            this.TabResCol_id = new System.Data.DataColumn();
            this.TabResCol_type = new System.Data.DataColumn();
            this.TabResCol_qte = new System.Data.DataColumn();
            this.TabResCol_prod = new System.Data.DataColumn();
            this.TabResCol_delay = new System.Data.DataColumn();
            this.sync = new System.Data.DataColumn();
            this.TabResCol_baseqte = new System.Data.DataColumn();
            this.TableDelais = new System.Data.DataTable();
            this.TabDelayCol_ticks = new System.Data.DataColumn();
            this.TabDelayCol_text = new System.Data.DataColumn();
            this.TableAlertes = new System.Data.DataTable();
            this.TabAlertCol_id = new System.Data.DataColumn();
            this.TabAlertCol_text = new System.Data.DataColumn();
            this.TabAlertCol_alerte = new System.Data.DataColumn();
            this.TableResAlerte = new System.Data.DataTable();
            this.TabRACol_alerte = new System.Data.DataColumn();
            this.TabRACol_res = new System.Data.DataColumn();
            this.TabRACol_qte = new System.Data.DataColumn();
            this.syncDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baseqteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_ressource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tray = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.afficherLinterfaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ressourcesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alertesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerRes = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageRes = new System.Windows.Forms.TabPage();
            this.tabPageAlert = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.datagrid_alertes = new System.Windows.Forms.DataGridView();
            this.datagrid_resalerte = new System.Windows.Forms.DataGridView();
            this.typeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qteDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblResAlerte = new System.Windows.Forms.Label();
            this.textDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alerteDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tempsrestant_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_heurefin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idalerteDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditResAlerte = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_res)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableResources)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableDelais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableAlertes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableResAlerte)).BeginInit();
            this.trayContextMenu.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageRes.SuspendLayout();
            this.tabPageAlert.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_alertes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_resalerte)).BeginInit();
            this.SuspendLayout();
            // 
            // datagrid_res
            // 
            this.datagrid_res.AutoGenerateColumns = false;
            this.datagrid_res.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_res.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeDataGridViewTextBoxColumn,
            this.qteDataGridViewTextBoxColumn,
            this.prodDataGridViewTextBoxColumn,
            this.delayDataGridViewComboBoxColumn,
            this.syncDataGridViewTextBoxColumn,
            this.baseqteDataGridViewTextBoxColumn,
            this.id_ressource});
            this.datagrid_res.DataMember = "Resources";
            this.datagrid_res.DataSource = this.data;
            this.datagrid_res.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagrid_res.Location = new System.Drawing.Point(3, 3);
            this.datagrid_res.Name = "datagrid_res";
            this.datagrid_res.Size = new System.Drawing.Size(926, 429);
            this.datagrid_res.TabIndex = 0;
            this.datagrid_res.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_res_CellEndEdit);
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            dataGridViewCellStyle1.NullValue = "[Nouvelle ressource...]";
            this.typeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type ressource";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.Width = 150;
            // 
            // qteDataGridViewTextBoxColumn
            // 
            this.qteDataGridViewTextBoxColumn.DataPropertyName = "qte";
            this.qteDataGridViewTextBoxColumn.HeaderText = "Quantité";
            this.qteDataGridViewTextBoxColumn.Name = "qteDataGridViewTextBoxColumn";
            // 
            // prodDataGridViewTextBoxColumn
            // 
            this.prodDataGridViewTextBoxColumn.DataPropertyName = "prod";
            this.prodDataGridViewTextBoxColumn.HeaderText = "Production";
            this.prodDataGridViewTextBoxColumn.Name = "prodDataGridViewTextBoxColumn";
            // 
            // delayDataGridViewComboBoxColumn
            // 
            this.delayDataGridViewComboBoxColumn.DataPropertyName = "delay";
            this.delayDataGridViewComboBoxColumn.DataSource = this.data;
            this.delayDataGridViewComboBoxColumn.DisplayMember = "Delais.text";
            this.delayDataGridViewComboBoxColumn.HeaderText = "Tout(e)s les:";
            this.delayDataGridViewComboBoxColumn.Name = "delayDataGridViewComboBoxColumn";
            this.delayDataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.delayDataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.delayDataGridViewComboBoxColumn.ValueMember = "Delais.ticks";
            // 
            // data
            // 
            this.data.DataSetName = "GRM";
            this.data.Namespace = "GameResourcesMonitor";
            this.data.Relations.AddRange(new System.Data.DataRelation[] {
            new System.Data.DataRelation("RelRes", "Resources", "GameResourcesMonitor", "ResAlerte", "GameResourcesMonitor", new string[] {
                        "id"}, new string[] {
                        "res"}, false),
            new System.Data.DataRelation("RelAlert", "Alertes", "GameResourcesMonitor", "ResAlerte", "GameResourcesMonitor", new string[] {
                        "id"}, new string[] {
                        "alerte"}, false)});
            this.data.Tables.AddRange(new System.Data.DataTable[] {
            this.TableResources,
            this.TableDelais,
            this.TableAlertes,
            this.TableResAlerte});
            // 
            // TableResources
            // 
            this.TableResources.Columns.AddRange(new System.Data.DataColumn[] {
            this.TabResCol_id,
            this.TabResCol_type,
            this.TabResCol_qte,
            this.TabResCol_prod,
            this.TabResCol_delay,
            this.sync,
            this.TabResCol_baseqte});
            this.TableResources.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "id"}, true),
            new System.Data.UniqueConstraint("Constraint2", new string[] {
                        "type"}, false)});
            this.TableResources.PrimaryKey = new System.Data.DataColumn[] {
        this.TabResCol_id};
            this.TableResources.TableName = "Resources";
            // 
            // TabResCol_id
            // 
            this.TabResCol_id.AllowDBNull = false;
            this.TabResCol_id.AutoIncrement = true;
            this.TabResCol_id.ColumnMapping = System.Data.MappingType.Attribute;
            this.TabResCol_id.ColumnName = "id";
            this.TabResCol_id.DataType = typeof(int);
            // 
            // TabResCol_type
            // 
            this.TabResCol_type.AllowDBNull = false;
            this.TabResCol_type.ColumnName = "type";
            // 
            // TabResCol_qte
            // 
            this.TabResCol_qte.ColumnMapping = System.Data.MappingType.Hidden;
            this.TabResCol_qte.ColumnName = "qte";
            this.TabResCol_qte.DataType = typeof(int);
            this.TabResCol_qte.DefaultValue = 0;
            // 
            // TabResCol_prod
            // 
            this.TabResCol_prod.ColumnName = "prod";
            this.TabResCol_prod.DataType = typeof(int);
            this.TabResCol_prod.DefaultValue = 0;
            // 
            // TabResCol_delay
            // 
            this.TabResCol_delay.ColumnName = "delay";
            this.TabResCol_delay.DataType = typeof(uint);
            this.TabResCol_delay.DefaultValue = ((uint)(60u));
            // 
            // sync
            // 
            this.sync.ColumnName = "sync";
            this.sync.DataType = typeof(System.DateTime);
            this.sync.DefaultValue = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            // 
            // TabResCol_baseqte
            // 
            this.TabResCol_baseqte.ColumnName = "baseqte";
            this.TabResCol_baseqte.DataType = typeof(int);
            this.TabResCol_baseqte.DefaultValue = 0;
            // 
            // TableDelais
            // 
            this.TableDelais.Columns.AddRange(new System.Data.DataColumn[] {
            this.TabDelayCol_ticks,
            this.TabDelayCol_text});
            this.TableDelais.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "ticks"}, true)});
            this.TableDelais.PrimaryKey = new System.Data.DataColumn[] {
        this.TabDelayCol_ticks};
            this.TableDelais.TableName = "Delais";
            // 
            // TabDelayCol_ticks
            // 
            this.TabDelayCol_ticks.AllowDBNull = false;
            this.TabDelayCol_ticks.ColumnMapping = System.Data.MappingType.Attribute;
            this.TabDelayCol_ticks.ColumnName = "ticks";
            this.TabDelayCol_ticks.DataType = typeof(uint);
            // 
            // TabDelayCol_text
            // 
            this.TabDelayCol_text.ColumnName = "text";
            // 
            // TableAlertes
            // 
            this.TableAlertes.Columns.AddRange(new System.Data.DataColumn[] {
            this.TabAlertCol_id,
            this.TabAlertCol_text,
            this.TabAlertCol_alerte});
            this.TableAlertes.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "id"}, true),
            new System.Data.UniqueConstraint("Constraint2", new string[] {
                        "text"}, false)});
            this.TableAlertes.PrimaryKey = new System.Data.DataColumn[] {
        this.TabAlertCol_id};
            this.TableAlertes.TableName = "Alertes";
            // 
            // TabAlertCol_id
            // 
            this.TabAlertCol_id.AllowDBNull = false;
            this.TabAlertCol_id.AutoIncrement = true;
            this.TabAlertCol_id.ColumnMapping = System.Data.MappingType.Attribute;
            this.TabAlertCol_id.ColumnName = "id";
            this.TabAlertCol_id.DataType = typeof(int);
            // 
            // TabAlertCol_text
            // 
            this.TabAlertCol_text.AllowDBNull = false;
            this.TabAlertCol_text.ColumnName = "text";
            // 
            // TabAlertCol_alerte
            // 
            this.TabAlertCol_alerte.AllowDBNull = false;
            this.TabAlertCol_alerte.ColumnName = "warn";
            this.TabAlertCol_alerte.DataType = typeof(byte);
            this.TabAlertCol_alerte.DefaultValue = ((byte)(0));
            // 
            // TableResAlerte
            // 
            this.TableResAlerte.Columns.AddRange(new System.Data.DataColumn[] {
            this.TabRACol_alerte,
            this.TabRACol_res,
            this.TabRACol_qte});
            this.TableResAlerte.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "alerte",
                        "res"}, true),
            new System.Data.ForeignKeyConstraint("RelRes", "Resources", new string[] {
                        "id"}, new string[] {
                        "res"}, System.Data.AcceptRejectRule.None, System.Data.Rule.Cascade, System.Data.Rule.Cascade),
            new System.Data.ForeignKeyConstraint("RelAlert", "Alertes", new string[] {
                        "id"}, new string[] {
                        "alerte"}, System.Data.AcceptRejectRule.None, System.Data.Rule.Cascade, System.Data.Rule.Cascade)});
            this.TableResAlerte.PrimaryKey = new System.Data.DataColumn[] {
        this.TabRACol_alerte,
        this.TabRACol_res};
            this.TableResAlerte.TableName = "ResAlerte";
            // 
            // TabRACol_alerte
            // 
            this.TabRACol_alerte.AllowDBNull = false;
            this.TabRACol_alerte.ColumnMapping = System.Data.MappingType.Attribute;
            this.TabRACol_alerte.ColumnName = "alerte";
            this.TabRACol_alerte.DataType = typeof(int);
            // 
            // TabRACol_res
            // 
            this.TabRACol_res.AllowDBNull = false;
            this.TabRACol_res.ColumnMapping = System.Data.MappingType.Attribute;
            this.TabRACol_res.ColumnName = "res";
            this.TabRACol_res.DataType = typeof(int);
            // 
            // TabRACol_qte
            // 
            this.TabRACol_qte.ColumnName = "qte";
            this.TabRACol_qte.DataType = typeof(int);
            // 
            // syncDataGridViewTextBoxColumn
            // 
            this.syncDataGridViewTextBoxColumn.DataPropertyName = "sync";
            this.syncDataGridViewTextBoxColumn.HeaderText = "Dernière Syncro.";
            this.syncDataGridViewTextBoxColumn.Name = "syncDataGridViewTextBoxColumn";
            this.syncDataGridViewTextBoxColumn.Width = 150;
            // 
            // baseqteDataGridViewTextBoxColumn
            // 
            this.baseqteDataGridViewTextBoxColumn.DataPropertyName = "baseqte";
            this.baseqteDataGridViewTextBoxColumn.HeaderText = "(Qté. syncro)";
            this.baseqteDataGridViewTextBoxColumn.Name = "baseqteDataGridViewTextBoxColumn";
            this.baseqteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // id_ressource
            // 
            this.id_ressource.DataPropertyName = "id";
            this.id_ressource.HeaderText = "id";
            this.id_ressource.Name = "id_ressource";
            this.id_ressource.Visible = false;
            // 
            // tray
            // 
            this.tray.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tray.BalloonTipTitle = "Game Resources Monitor";
            this.tray.ContextMenuStrip = this.trayContextMenu;
            this.tray.Icon = ((System.Drawing.Icon)(resources.GetObject("tray.Icon")));
            this.tray.Text = "Game Resources Monitor";
            this.tray.Visible = true;
            this.tray.DoubleClick += new System.EventHandler(this.tray_DoubleClick);
            this.tray.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tray_MouseClick);
            // 
            // trayContextMenu
            // 
            this.trayContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afficherLinterfaceToolStripMenuItem,
            this.afficherToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.trayContextMenu.Name = "trayContextMenu";
            this.trayContextMenu.Size = new System.Drawing.Size(186, 70);
            // 
            // afficherLinterfaceToolStripMenuItem
            // 
            this.afficherLinterfaceToolStripMenuItem.Name = "afficherLinterfaceToolStripMenuItem";
            this.afficherLinterfaceToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.afficherLinterfaceToolStripMenuItem.Text = "Afficher l\'interface...";
            this.afficherLinterfaceToolStripMenuItem.Click += new System.EventHandler(this.afficherLinterfaceToolStripMenuItem_Click);
            // 
            // afficherToolStripMenuItem
            // 
            this.afficherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ressourcesToolStripMenuItem,
            this.alertesToolStripMenuItem});
            this.afficherToolStripMenuItem.Name = "afficherToolStripMenuItem";
            this.afficherToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.afficherToolStripMenuItem.Text = "Aller à:";
            // 
            // ressourcesToolStripMenuItem
            // 
            this.ressourcesToolStripMenuItem.Name = "ressourcesToolStripMenuItem";
            this.ressourcesToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.ressourcesToolStripMenuItem.Text = "Ressources";
            this.ressourcesToolStripMenuItem.Click += new System.EventHandler(this.ressourcesToolStripMenuItem_Click);
            // 
            // alertesToolStripMenuItem
            // 
            this.alertesToolStripMenuItem.Name = "alertesToolStripMenuItem";
            this.alertesToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.alertesToolStripMenuItem.Text = "Alertes";
            this.alertesToolStripMenuItem.Click += new System.EventHandler(this.alertesToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // timerRes
            // 
            this.timerRes.Enabled = true;
            this.timerRes.Interval = 1000;
            this.timerRes.Tick += new System.EventHandler(this.timerRes_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageRes);
            this.tabControl1.Controls.Add(this.tabPageAlert);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(940, 461);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPageRes
            // 
            this.tabPageRes.Controls.Add(this.datagrid_res);
            this.tabPageRes.Location = new System.Drawing.Point(4, 22);
            this.tabPageRes.Name = "tabPageRes";
            this.tabPageRes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRes.Size = new System.Drawing.Size(932, 435);
            this.tabPageRes.TabIndex = 0;
            this.tabPageRes.Text = "Ressources";
            this.tabPageRes.UseVisualStyleBackColor = true;
            // 
            // tabPageAlert
            // 
            this.tabPageAlert.Controls.Add(this.tableLayoutPanel1);
            this.tabPageAlert.Location = new System.Drawing.Point(4, 22);
            this.tabPageAlert.Name = "tabPageAlert";
            this.tabPageAlert.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAlert.Size = new System.Drawing.Size(932, 435);
            this.tabPageAlert.TabIndex = 1;
            this.tabPageAlert.Text = "Alertes";
            this.tabPageAlert.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.datagrid_alertes, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.datagrid_resalerte, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblResAlerte, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(926, 429);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // datagrid_alertes
            // 
            this.datagrid_alertes.AutoGenerateColumns = false;
            this.datagrid_alertes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_alertes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.textDataGridViewTextBoxColumn,
            this.alerteDataGridViewCheckBoxColumn,
            this.tempsrestant_col,
            this.col_heurefin,
            this.idalerteDataGridViewTextBoxColumn1,
            this.btnEditResAlerte});
            this.datagrid_alertes.DataMember = "Alertes";
            this.datagrid_alertes.DataSource = this.data;
            this.datagrid_alertes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagrid_alertes.Location = new System.Drawing.Point(3, 3);
            this.datagrid_alertes.Name = "datagrid_alertes";
            this.tableLayoutPanel1.SetRowSpan(this.datagrid_alertes, 2);
            this.datagrid_alertes.Size = new System.Drawing.Size(642, 423);
            this.datagrid_alertes.TabIndex = 0;
            this.datagrid_alertes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_alertes_CellContentClick);
            // 
            // datagrid_resalerte
            // 
            this.datagrid_resalerte.AllowUserToAddRows = false;
            this.datagrid_resalerte.AllowUserToDeleteRows = false;
            this.datagrid_resalerte.AutoGenerateColumns = false;
            this.datagrid_resalerte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_resalerte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeDataGridViewTextBoxColumn1,
            this.qteDataGridViewTextBoxColumn1,
            this.idDataGridViewTextBoxColumn1});
            this.datagrid_resalerte.DataMember = "Resources";
            this.datagrid_resalerte.DataSource = this.data;
            this.datagrid_resalerte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagrid_resalerte.Location = new System.Drawing.Point(651, 33);
            this.datagrid_resalerte.Name = "datagrid_resalerte";
            this.datagrid_resalerte.RowHeadersVisible = false;
            this.datagrid_resalerte.Size = new System.Drawing.Size(272, 393);
            this.datagrid_resalerte.TabIndex = 1;
            this.datagrid_resalerte.Visible = false;
            this.datagrid_resalerte.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_resalerte_CellEndEdit);
            // 
            // typeDataGridViewTextBoxColumn1
            // 
            this.typeDataGridViewTextBoxColumn1.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn1.HeaderText = "Ressource:";
            this.typeDataGridViewTextBoxColumn1.Name = "typeDataGridViewTextBoxColumn1";
            // 
            // qteDataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle5.NullValue = "[Ignoré]";
            this.qteDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle5;
            this.qteDataGridViewTextBoxColumn1.HeaderText = "Quantité:";
            this.qteDataGridViewTextBoxColumn1.Name = "qteDataGridViewTextBoxColumn1";
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Visible = false;
            // 
            // lblResAlerte
            // 
            this.lblResAlerte.AutoSize = true;
            this.lblResAlerte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblResAlerte.Location = new System.Drawing.Point(651, 0);
            this.lblResAlerte.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.lblResAlerte.Name = "lblResAlerte";
            this.lblResAlerte.Size = new System.Drawing.Size(272, 27);
            this.lblResAlerte.TabIndex = 2;
            this.lblResAlerte.Text = "Veuillez sélectionner une alerte...";
            this.lblResAlerte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textDataGridViewTextBoxColumn
            // 
            this.textDataGridViewTextBoxColumn.DataPropertyName = "text";
            this.textDataGridViewTextBoxColumn.HeaderText = "Nom de l\'alerte";
            this.textDataGridViewTextBoxColumn.Name = "textDataGridViewTextBoxColumn";
            this.textDataGridViewTextBoxColumn.Width = 150;
            // 
            // alerteDataGridViewCheckBoxColumn
            // 
            this.alerteDataGridViewCheckBoxColumn.DataPropertyName = "warn";
            this.alerteDataGridViewCheckBoxColumn.FalseValue = "0";
            this.alerteDataGridViewCheckBoxColumn.HeaderText = "Activée";
            this.alerteDataGridViewCheckBoxColumn.IndeterminateValue = "0";
            this.alerteDataGridViewCheckBoxColumn.Name = "alerteDataGridViewCheckBoxColumn";
            this.alerteDataGridViewCheckBoxColumn.TrueValue = "1";
            // 
            // tempsrestant_col
            // 
            dataGridViewCellStyle2.NullValue = "[En attente...]";
            this.tempsrestant_col.DefaultCellStyle = dataGridViewCellStyle2;
            this.tempsrestant_col.HeaderText = "Temps restant:";
            this.tempsrestant_col.Name = "tempsrestant_col";
            this.tempsrestant_col.ReadOnly = true;
            // 
            // col_heurefin
            // 
            dataGridViewCellStyle3.NullValue = "[En attente...]";
            this.col_heurefin.DefaultCellStyle = dataGridViewCellStyle3;
            this.col_heurefin.HeaderText = "Terminé:";
            this.col_heurefin.Name = "col_heurefin";
            this.col_heurefin.ReadOnly = true;
            this.col_heurefin.Width = 150;
            // 
            // idalerteDataGridViewTextBoxColumn1
            // 
            this.idalerteDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idalerteDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idalerteDataGridViewTextBoxColumn1.Name = "idalerteDataGridViewTextBoxColumn1";
            this.idalerteDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idalerteDataGridViewTextBoxColumn1.Visible = false;
            // 
            // btnEditResAlerte
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = "-->";
            this.btnEditResAlerte.DefaultCellStyle = dataGridViewCellStyle4;
            this.btnEditResAlerte.HeaderText = "Modifier";
            this.btnEditResAlerte.Name = "btnEditResAlerte";
            this.btnEditResAlerte.Text = "";
            this.btnEditResAlerte.Width = 50;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 461);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Game Resources Monitor (By Elektordi)";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_res)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableResources)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableDelais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableAlertes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableResAlerte)).EndInit();
            this.trayContextMenu.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageRes.ResumeLayout(false);
            this.tabPageAlert.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_alertes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_resalerte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagrid_res;
        private System.Windows.Forms.NotifyIcon tray;
        private System.Windows.Forms.ContextMenuStrip trayContextMenu;
        private System.Windows.Forms.Timer timerRes;
        private System.Data.DataSet data;
        private System.Data.DataTable TableResources;
        private System.Data.DataColumn TabResCol_id;
        private System.Data.DataColumn TabResCol_type;
        private System.Data.DataColumn TabResCol_qte;
        private System.Data.DataColumn TabResCol_prod;
        private System.Data.DataColumn TabResCol_delay;
        private System.Data.DataColumn sync;
        private System.Data.DataTable TableDelais;
        private System.Data.DataColumn TabDelayCol_ticks;
        private System.Data.DataColumn TabDelayCol_text;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageRes;
        private System.Windows.Forms.TabPage tabPageAlert;
        private System.Windows.Forms.DataGridView datagrid_alertes;
        private System.Data.DataTable TableAlertes;
        private System.Data.DataColumn TabAlertCol_id;
        private System.Data.DataColumn TabAlertCol_text;
        private System.Data.DataColumn TabAlertCol_alerte;
        private System.Data.DataColumn TabResCol_baseqte;
        private System.Windows.Forms.ToolStripMenuItem afficherLinterfaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ressourcesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alertesToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Data.DataTable TableResAlerte;
        private System.Data.DataColumn TabRACol_alerte;
        private System.Data.DataColumn TabRACol_res;
        private System.Data.DataColumn TabRACol_qte;
        private System.Windows.Forms.DataGridView datagrid_resalerte;
        private System.Windows.Forms.Label lblResAlerte;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn qteDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn delayDataGridViewComboBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn syncDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn baseqteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_ressource;
        private System.Windows.Forms.DataGridViewTextBoxColumn textDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn alerteDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempsrestant_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_heurefin;
        private System.Windows.Forms.DataGridViewTextBoxColumn idalerteDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditResAlerte;

    }
}

