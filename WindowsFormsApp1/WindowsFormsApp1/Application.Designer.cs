namespace WindowsFormsApp1
{
    partial class Application
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ButtonAjouterInter = new System.Windows.Forms.Button();
            this.buttonAfficherInter = new System.Windows.Forms.Button();
            this.dgv_inter = new System.Windows.Forms.DataGridView();
            this.ID_Intervention = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Planifiee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Commentaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Mat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonAjouterClient = new System.Windows.Forms.Button();
            this.buttonAfficherClient = new System.Windows.Forms.Button();
            this.dgv_client = new System.Windows.Forms.DataGridView();
            this.ID_Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonAjouterSite = new System.Windows.Forms.Button();
            this.buttonAfficherSite = new System.Windows.Forms.Button();
            this.dgv_site = new System.Windows.Forms.DataGridView();
            this.ID_Site = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom_Site = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresse_Site = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ville = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Clients = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.buttonAjouterMat = new System.Windows.Forms.Button();
            this.buttonAfficherMat = new System.Windows.Forms.Button();
            this.dgv_mat = new System.Windows.Forms.DataGridView();
            this.ID_Mat2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MTBF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Installation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_TypeMat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Site2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Client2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Marque2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.buttonAjouterTM = new System.Windows.Forms.Button();
            this.buttonAfficherTM = new System.Windows.Forms.Button();
            this.dgv_TM = new System.Windows.Forms.DataGridView();
            this.ID_TM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomMat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.buttonAjouterMarque = new System.Windows.Forms.Button();
            this.buttonAfficerMarque = new System.Windows.Forms.Button();
            this.dgv_marque = new System.Windows.Forms.DataGridView();
            this.ID_Marque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom_M = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inter)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_client)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_site)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mat)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TM)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_marque)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(943, 480);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ButtonAjouterInter);
            this.tabPage2.Controls.Add(this.buttonAfficherInter);
            this.tabPage2.Controls.Add(this.dgv_inter);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(935, 451);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Intervention";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ButtonAjouterInter
            // 
            this.ButtonAjouterInter.Location = new System.Drawing.Point(104, 352);
            this.ButtonAjouterInter.Name = "ButtonAjouterInter";
            this.ButtonAjouterInter.Size = new System.Drawing.Size(117, 23);
            this.ButtonAjouterInter.TabIndex = 2;
            this.ButtonAjouterInter.Text = "Ajouter/Modifier";
            this.ButtonAjouterInter.UseVisualStyleBackColor = true;
            this.ButtonAjouterInter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // buttonAfficherInter
            // 
            this.buttonAfficherInter.Location = new System.Drawing.Point(125, 284);
            this.buttonAfficherInter.Name = "buttonAfficherInter";
            this.buttonAfficherInter.Size = new System.Drawing.Size(75, 23);
            this.buttonAfficherInter.TabIndex = 1;
            this.buttonAfficherInter.Text = "Afficher";
            this.buttonAfficherInter.UseVisualStyleBackColor = true;
            this.buttonAfficherInter.Click += new System.EventHandler(this.buttonAfficherInter_Click);
            // 
            // dgv_inter
            // 
            this.dgv_inter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_inter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Intervention,
            this.Date_Planifiee,
            this.Commentaire,
            this.ID_Mat});
            this.dgv_inter.Location = new System.Drawing.Point(331, 91);
            this.dgv_inter.Name = "dgv_inter";
            this.dgv_inter.RowTemplate.Height = 24;
            this.dgv_inter.Size = new System.Drawing.Size(590, 354);
            this.dgv_inter.TabIndex = 0;
            this.dgv_inter.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgv_inter_UserDeletingRow);
            // 
            // ID_Intervention
            // 
            this.ID_Intervention.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ID_Intervention.DataPropertyName = "ID_Intervention";
            this.ID_Intervention.HeaderText = "ID Intervention";
            this.ID_Intervention.Name = "ID_Intervention";
            this.ID_Intervention.Width = 128;
            // 
            // Date_Planifiee
            // 
            this.Date_Planifiee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Date_Planifiee.DataPropertyName = "Date_Planifiee";
            this.Date_Planifiee.HeaderText = "Date Planifiee";
            this.Date_Planifiee.Name = "Date_Planifiee";
            this.Date_Planifiee.Width = 125;
            // 
            // Commentaire
            // 
            this.Commentaire.DataPropertyName = "Commentaire";
            this.Commentaire.HeaderText = "Commentaire";
            this.Commentaire.Name = "Commentaire";
            // 
            // ID_Mat
            // 
            this.ID_Mat.DataPropertyName = "ID_Mat";
            this.ID_Mat.HeaderText = "ID Mat";
            this.ID_Mat.Name = "ID_Mat";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightGray;
            this.tabPage1.Controls.Add(this.buttonAjouterClient);
            this.tabPage1.Controls.Add(this.buttonAfficherClient);
            this.tabPage1.Controls.Add(this.dgv_client);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(935, 451);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Client";
            // 
            // buttonAjouterClient
            // 
            this.buttonAjouterClient.Location = new System.Drawing.Point(6, 230);
            this.buttonAjouterClient.Name = "buttonAjouterClient";
            this.buttonAjouterClient.Size = new System.Drawing.Size(125, 32);
            this.buttonAjouterClient.TabIndex = 11;
            this.buttonAjouterClient.Text = "Ajouter/Modifier";
            this.buttonAjouterClient.UseVisualStyleBackColor = true;
            this.buttonAjouterClient.Click += new System.EventHandler(this.buttonModifier_Click);
            // 
            // buttonAfficherClient
            // 
            this.buttonAfficherClient.Location = new System.Drawing.Point(33, 172);
            this.buttonAfficherClient.Name = "buttonAfficherClient";
            this.buttonAfficherClient.Size = new System.Drawing.Size(75, 23);
            this.buttonAfficherClient.TabIndex = 1;
            this.buttonAfficherClient.Text = "Afficher";
            this.buttonAfficherClient.UseVisualStyleBackColor = true;
            this.buttonAfficherClient.Click += new System.EventHandler(this.buttonAfficher_Click_1);
            // 
            // dgv_client
            // 
            this.dgv_client.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_client.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Client,
            this.Nom,
            this.Adresse,
            this.Telephone,
            this.Email});
            this.dgv_client.Location = new System.Drawing.Point(137, 6);
            this.dgv_client.Name = "dgv_client";
            this.dgv_client.RowTemplate.Height = 24;
            this.dgv_client.Size = new System.Drawing.Size(659, 405);
            this.dgv_client.TabIndex = 0;
            this.dgv_client.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgv_UserDeletingRow);
            // 
            // ID_Client
            // 
            this.ID_Client.DataPropertyName = "ID_Client";
            this.ID_Client.HeaderText = "ID Client ";
            this.ID_Client.Name = "ID_Client";
            // 
            // Nom
            // 
            this.Nom.DataPropertyName = "Nom";
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            // 
            // Adresse
            // 
            this.Adresse.DataPropertyName = "Adresse";
            this.Adresse.HeaderText = "Adresse";
            this.Adresse.Name = "Adresse";
            // 
            // Telephone
            // 
            this.Telephone.DataPropertyName = "Telephone";
            this.Telephone.HeaderText = "Téléphone";
            this.Telephone.Name = "Telephone";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonAjouterSite);
            this.tabPage3.Controls.Add(this.buttonAfficherSite);
            this.tabPage3.Controls.Add(this.dgv_site);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(935, 451);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Site";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonAjouterSite
            // 
            this.buttonAjouterSite.Location = new System.Drawing.Point(255, 30);
            this.buttonAjouterSite.Name = "buttonAjouterSite";
            this.buttonAjouterSite.Size = new System.Drawing.Size(130, 23);
            this.buttonAjouterSite.TabIndex = 2;
            this.buttonAjouterSite.Text = "Ajouter/Modifier";
            this.buttonAjouterSite.UseVisualStyleBackColor = true;
            this.buttonAjouterSite.Click += new System.EventHandler(this.buttonAjouterSite_Click);
            // 
            // buttonAfficherSite
            // 
            this.buttonAfficherSite.Location = new System.Drawing.Point(40, 21);
            this.buttonAfficherSite.Name = "buttonAfficherSite";
            this.buttonAfficherSite.Size = new System.Drawing.Size(75, 23);
            this.buttonAfficherSite.TabIndex = 1;
            this.buttonAfficherSite.Text = "Afficher";
            this.buttonAfficherSite.UseVisualStyleBackColor = true;
            this.buttonAfficherSite.Click += new System.EventHandler(this.buttonAfficherSite_Click);
            // 
            // dgv_site
            // 
            this.dgv_site.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_site.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Site,
            this.Nom_Site,
            this.Adresse_Site,
            this.CP,
            this.Ville,
            this.ID_Clients});
            this.dgv_site.Location = new System.Drawing.Point(127, 96);
            this.dgv_site.Name = "dgv_site";
            this.dgv_site.RowTemplate.Height = 24;
            this.dgv_site.Size = new System.Drawing.Size(658, 302);
            this.dgv_site.TabIndex = 0;
            this.dgv_site.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgv_site_UserDeletingRow);
            // 
            // ID_Site
            // 
            this.ID_Site.DataPropertyName = "ID_Site";
            this.ID_Site.HeaderText = "ID Site";
            this.ID_Site.Name = "ID_Site";
            // 
            // Nom_Site
            // 
            this.Nom_Site.DataPropertyName = "Nom";
            this.Nom_Site.HeaderText = "Nom Site";
            this.Nom_Site.Name = "Nom_Site";
            // 
            // Adresse_Site
            // 
            this.Adresse_Site.DataPropertyName = "Adresse";
            this.Adresse_Site.HeaderText = "Adresse";
            this.Adresse_Site.Name = "Adresse_Site";
            // 
            // CP
            // 
            this.CP.DataPropertyName = "CP";
            this.CP.HeaderText = "CP";
            this.CP.Name = "CP";
            // 
            // Ville
            // 
            this.Ville.DataPropertyName = "Ville";
            this.Ville.HeaderText = "Ville";
            this.Ville.Name = "Ville";
            // 
            // ID_Clients
            // 
            this.ID_Clients.DataPropertyName = "ID_Client";
            this.ID_Clients.HeaderText = "ID Client";
            this.ID_Clients.Name = "ID_Clients";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.buttonAjouterMat);
            this.tabPage4.Controls.Add(this.buttonAfficherMat);
            this.tabPage4.Controls.Add(this.dgv_mat);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(935, 451);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Matériel";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // buttonAjouterMat
            // 
            this.buttonAjouterMat.Location = new System.Drawing.Point(680, 30);
            this.buttonAjouterMat.Name = "buttonAjouterMat";
            this.buttonAjouterMat.Size = new System.Drawing.Size(131, 23);
            this.buttonAjouterMat.TabIndex = 2;
            this.buttonAjouterMat.Text = "Ajouter/Modifier";
            this.buttonAjouterMat.UseVisualStyleBackColor = true;
            this.buttonAjouterMat.Click += new System.EventHandler(this.buttonAjouterMat_Click);
            // 
            // buttonAfficherMat
            // 
            this.buttonAfficherMat.Location = new System.Drawing.Point(530, 30);
            this.buttonAfficherMat.Name = "buttonAfficherMat";
            this.buttonAfficherMat.Size = new System.Drawing.Size(75, 23);
            this.buttonAfficherMat.TabIndex = 1;
            this.buttonAfficherMat.Text = "Afficher";
            this.buttonAfficherMat.UseVisualStyleBackColor = true;
            this.buttonAfficherMat.Click += new System.EventHandler(this.buttonAfficherMat_Click);
            // 
            // dgv_mat
            // 
            this.dgv_mat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Mat2,
            this.Nom2,
            this.NoSerie,
            this.MTBF,
            this.Date_Installation,
            this.ID_TypeMat,
            this.ID_Site2,
            this.ID_Client2,
            this.ID_Marque2});
            this.dgv_mat.Location = new System.Drawing.Point(0, 67);
            this.dgv_mat.Name = "dgv_mat";
            this.dgv_mat.RowTemplate.Height = 24;
            this.dgv_mat.Size = new System.Drawing.Size(939, 384);
            this.dgv_mat.TabIndex = 0;
            this.dgv_mat.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgv_mat_UserDeletingRow);
            // 
            // ID_Mat2
            // 
            this.ID_Mat2.DataPropertyName = "ID_Mat";
            this.ID_Mat2.HeaderText = "ID Mat";
            this.ID_Mat2.Name = "ID_Mat2";
            // 
            // Nom2
            // 
            this.Nom2.DataPropertyName = "Nom";
            this.Nom2.HeaderText = "Nom";
            this.Nom2.Name = "Nom2";
            // 
            // NoSerie
            // 
            this.NoSerie.DataPropertyName = "NoSerie";
            this.NoSerie.HeaderText = "N° Série";
            this.NoSerie.Name = "NoSerie";
            // 
            // MTBF
            // 
            this.MTBF.DataPropertyName = "MTBF";
            this.MTBF.HeaderText = "MTBF";
            this.MTBF.Name = "MTBF";
            // 
            // Date_Installation
            // 
            this.Date_Installation.DataPropertyName = "Date_Installation";
            this.Date_Installation.HeaderText = "Date Installation";
            this.Date_Installation.Name = "Date_Installation";
            // 
            // ID_TypeMat
            // 
            this.ID_TypeMat.DataPropertyName = "ID_TypeMat";
            this.ID_TypeMat.HeaderText = "ID TypeMat";
            this.ID_TypeMat.Name = "ID_TypeMat";
            // 
            // ID_Site2
            // 
            this.ID_Site2.DataPropertyName = "ID_Site";
            this.ID_Site2.HeaderText = "ID Site";
            this.ID_Site2.Name = "ID_Site2";
            // 
            // ID_Client2
            // 
            this.ID_Client2.DataPropertyName = "ID_Client";
            this.ID_Client2.HeaderText = "ID Client";
            this.ID_Client2.Name = "ID_Client2";
            // 
            // ID_Marque2
            // 
            this.ID_Marque2.DataPropertyName = "ID_Marque";
            this.ID_Marque2.HeaderText = "ID Marque";
            this.ID_Marque2.Name = "ID_Marque2";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.buttonAjouterTM);
            this.tabPage5.Controls.Add(this.buttonAfficherTM);
            this.tabPage5.Controls.Add(this.dgv_TM);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(935, 451);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Type Matériel";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // buttonAjouterTM
            // 
            this.buttonAjouterTM.Location = new System.Drawing.Point(501, 45);
            this.buttonAjouterTM.Name = "buttonAjouterTM";
            this.buttonAjouterTM.Size = new System.Drawing.Size(147, 23);
            this.buttonAjouterTM.TabIndex = 2;
            this.buttonAjouterTM.Text = "Ajouter/Modifier";
            this.buttonAjouterTM.UseVisualStyleBackColor = true;
            this.buttonAjouterTM.Click += new System.EventHandler(this.buttonAjouterTM_Click);
            // 
            // buttonAfficherTM
            // 
            this.buttonAfficherTM.Location = new System.Drawing.Point(244, 45);
            this.buttonAfficherTM.Name = "buttonAfficherTM";
            this.buttonAfficherTM.Size = new System.Drawing.Size(75, 23);
            this.buttonAfficherTM.TabIndex = 1;
            this.buttonAfficherTM.Text = "Afficher";
            this.buttonAfficherTM.UseVisualStyleBackColor = true;
            this.buttonAfficherTM.Click += new System.EventHandler(this.buttonAfficherTM_Click);
            // 
            // dgv_TM
            // 
            this.dgv_TM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_TM,
            this.NomMat});
            this.dgv_TM.Location = new System.Drawing.Point(165, 97);
            this.dgv_TM.Name = "dgv_TM";
            this.dgv_TM.RowTemplate.Height = 24;
            this.dgv_TM.Size = new System.Drawing.Size(764, 348);
            this.dgv_TM.TabIndex = 0;
            this.dgv_TM.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgv_TM_UserDeletingRow);
            // 
            // ID_TM
            // 
            this.ID_TM.DataPropertyName = "ID_TypeMat";
            this.ID_TM.HeaderText = "ID";
            this.ID_TM.Name = "ID_TM";
            // 
            // NomMat
            // 
            this.NomMat.DataPropertyName = "Nom";
            this.NomMat.HeaderText = "Type";
            this.NomMat.Name = "NomMat";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.buttonAjouterMarque);
            this.tabPage6.Controls.Add(this.buttonAfficerMarque);
            this.tabPage6.Controls.Add(this.dgv_marque);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(935, 451);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Marque";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // buttonAjouterMarque
            // 
            this.buttonAjouterMarque.Location = new System.Drawing.Point(611, 24);
            this.buttonAjouterMarque.Name = "buttonAjouterMarque";
            this.buttonAjouterMarque.Size = new System.Drawing.Size(75, 23);
            this.buttonAjouterMarque.TabIndex = 2;
            this.buttonAjouterMarque.Text = "Ajouter/Modifier";
            this.buttonAjouterMarque.UseVisualStyleBackColor = true;
            this.buttonAjouterMarque.Click += new System.EventHandler(this.buttonAjouterMarque_Click);
            // 
            // buttonAfficerMarque
            // 
            this.buttonAfficerMarque.Location = new System.Drawing.Point(264, 25);
            this.buttonAfficerMarque.Name = "buttonAfficerMarque";
            this.buttonAfficerMarque.Size = new System.Drawing.Size(75, 23);
            this.buttonAfficerMarque.TabIndex = 1;
            this.buttonAfficerMarque.Text = "Afficher";
            this.buttonAfficerMarque.UseVisualStyleBackColor = true;
            this.buttonAfficerMarque.Click += new System.EventHandler(this.buttonAfficerMarque_Click);
            // 
            // dgv_marque
            // 
            this.dgv_marque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_marque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Marque,
            this.Nom_M});
            this.dgv_marque.Location = new System.Drawing.Point(219, 77);
            this.dgv_marque.Name = "dgv_marque";
            this.dgv_marque.RowTemplate.Height = 24;
            this.dgv_marque.Size = new System.Drawing.Size(710, 368);
            this.dgv_marque.TabIndex = 0;
            this.dgv_marque.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgv_marque_UserDeletingRow);
            // 
            // ID_Marque
            // 
            this.ID_Marque.DataPropertyName = "ID_Marque";
            this.ID_Marque.HeaderText = "ID Marque";
            this.ID_Marque.Name = "ID_Marque";
            // 
            // Nom_M
            // 
            this.Nom_M.DataPropertyName = "Nom";
            this.Nom_M.HeaderText = "Nom";
            this.Nom_M.Name = "Nom_M";
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=DESKTOP-FF26GO5\\SQLEXPRESS;Initial Catalog=GestionMatos;Integrated Se" +
    "curity=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            this.sqlConnection1.InfoMessage += new System.Data.SqlClient.SqlInfoMessageEventHandler(this.sqlConnection1_InfoMessage);
            // 
            // gestionMatosDataSet
            // 
            // 
            // Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 478);
            this.Controls.Add(this.tabControl1);
            this.Name = "Application";
            this.Text = "Gestion";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inter)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_client)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_site)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mat)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TM)).EndInit();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_marque)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgv_client;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Windows.Forms.Button buttonAfficherClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.Button buttonAjouterClient;
        private System.Windows.Forms.Button buttonAfficherInter;
        private System.Windows.Forms.DataGridView dgv_inter;
        private System.Windows.Forms.Button ButtonAjouterInter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Intervention;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Planifiee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Commentaire;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Mat;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button buttonAjouterSite;
        private System.Windows.Forms.Button buttonAfficherSite;
        private System.Windows.Forms.DataGridView dgv_site;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Site;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom_Site;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresse_Site;
        private System.Windows.Forms.DataGridViewTextBoxColumn CP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ville;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Clients;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dgv_mat;
        private System.Windows.Forms.Button buttonAjouterMat;
        private System.Windows.Forms.Button buttonAfficherMat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Mat2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn MTBF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Installation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_TypeMat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Site2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Client2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Marque2;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button buttonAjouterTM;
        private System.Windows.Forms.Button buttonAfficherTM;
        private System.Windows.Forms.DataGridView dgv_TM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_TM;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomMat;
        private System.Windows.Forms.Button buttonAjouterMarque;
        private System.Windows.Forms.Button buttonAfficerMarque;
        private System.Windows.Forms.DataGridView dgv_marque;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Marque;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom_M;
        private WindowsFormsApp1.GestionMatosDataSet gestionMatosDataSet;
    }
}

