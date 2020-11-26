namespace Tp5
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelHome = new MetroFramework.Controls.MetroPanel();
            this.DevisPanel = new MetroFramework.Controls.MetroPanel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.DevisStatus = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.DevisCode = new MetroFramework.Controls.MetroTextBox();
            this.DevisDate = new MetroFramework.Controls.MetroDateTime();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelInfo1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tvacombobox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel20 = new MetroFramework.Controls.MetroLabel();
            this.FactureCode = new MetroFramework.Controls.MetroTextBox();
            this.Reference = new MetroFramework.Controls.MetroTextBox();
            this.Designation = new MetroFramework.Controls.MetroTextBox();
            this.QTE = new MetroFramework.Controls.MetroTextBox();
            this.Date = new MetroFramework.Controls.MetroDateTime();
            this.Prix = new MetroFramework.Controls.MetroTextBox();
            this.PanelInfo2 = new MetroFramework.Controls.MetroPanel();
            this.DevisGrid = new MetroFramework.Controls.MetroGrid();
            this.button4 = new System.Windows.Forms.Button();
            this.GenererDevisButt = new System.Windows.Forms.Button();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.butt = new System.Windows.Forms.Button();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.IfClient = new MetroFramework.Controls.MetroTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.metroLabel23 = new MetroFramework.Controls.MetroLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.metroLabel22 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel21 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.NomClient = new MetroFramework.Controls.MetroComboBox();
            this.IceClient = new MetroFramework.Controls.MetroTextBox();
            this.RS = new MetroFramework.Controls.MetroComboBox();
            this.IDClient = new MetroFramework.Controls.MetroTextBox();
            this.FactureGrid = new MetroFramework.Controls.MetroGrid();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.MontantTotal = new MetroFramework.Controls.MetroTextBox();
            this.TotalAPayer = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.ValeurTva = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.PanelHome.SuspendLayout();
            this.DevisPanel.SuspendLayout();
            this.PanelInfo1.SuspendLayout();
            this.PanelInfo2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DevisGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FactureGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelHome
            // 
            this.PanelHome.BackColor = System.Drawing.Color.White;
            this.PanelHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelHome.BackgroundImage")));
            this.PanelHome.Controls.Add(this.DevisPanel);
            this.PanelHome.Controls.Add(this.label1);
            this.PanelHome.Controls.Add(this.PanelInfo1);
            this.PanelHome.Controls.Add(this.PanelInfo2);
            this.PanelHome.Controls.Add(this.metroLabel10);
            this.PanelHome.Controls.Add(this.MontantTotal);
            this.PanelHome.Controls.Add(this.TotalAPayer);
            this.PanelHome.Controls.Add(this.metroLabel13);
            this.PanelHome.Controls.Add(this.ValeurTva);
            this.PanelHome.Controls.Add(this.metroLabel12);
            this.PanelHome.HorizontalScrollbarBarColor = false;
            this.PanelHome.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelHome.HorizontalScrollbarSize = 10;
            this.PanelHome.Location = new System.Drawing.Point(0, 0);
            this.PanelHome.Name = "PanelHome";
            this.PanelHome.Size = new System.Drawing.Size(932, 502);
            this.PanelHome.TabIndex = 44;
            this.PanelHome.UseCustomBackColor = true;
            this.PanelHome.UseCustomForeColor = true;
            this.PanelHome.VerticalScrollbarBarColor = false;
            this.PanelHome.VerticalScrollbarHighlightOnWheel = true;
            this.PanelHome.VerticalScrollbarSize = 10;
            this.PanelHome.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelHome_Paint);
            this.PanelHome.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelHome_MouseDown);
            this.PanelHome.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelHome_MouseMove);
            this.PanelHome.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelHome_MouseUp);
            // 
            // DevisPanel
            // 
            this.DevisPanel.BackColor = System.Drawing.Color.Transparent;
            this.DevisPanel.Controls.Add(this.metroLabel3);
            this.DevisPanel.Controls.Add(this.metroLabel16);
            this.DevisPanel.Controls.Add(this.DevisStatus);
            this.DevisPanel.Controls.Add(this.metroLabel17);
            this.DevisPanel.Controls.Add(this.DevisCode);
            this.DevisPanel.Controls.Add(this.DevisDate);
            this.DevisPanel.HorizontalScrollbarBarColor = true;
            this.DevisPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.DevisPanel.HorizontalScrollbarSize = 10;
            this.DevisPanel.Location = new System.Drawing.Point(14, 286);
            this.DevisPanel.Name = "DevisPanel";
            this.DevisPanel.Size = new System.Drawing.Size(329, 126);
            this.DevisPanel.TabIndex = 49;
            this.DevisPanel.UseCustomBackColor = true;
            this.DevisPanel.UseCustomForeColor = true;
            this.DevisPanel.UseStyleColors = true;
            this.DevisPanel.VerticalScrollbarBarColor = true;
            this.DevisPanel.VerticalScrollbarHighlightOnWheel = false;
            this.DevisPanel.VerticalScrollbarSize = 10;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroLabel3.Location = new System.Drawing.Point(12, 100);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(88, 19);
            this.metroLabel3.TabIndex = 47;
            this.metroLabel3.Text = "Devis Date :";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel16.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroLabel16.Location = new System.Drawing.Point(11, 57);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(101, 19);
            this.metroLabel16.TabIndex = 42;
            this.metroLabel16.Text = "Devis Status : ";
            this.metroLabel16.UseCustomBackColor = true;
            this.metroLabel16.UseCustomForeColor = true;
            // 
            // DevisStatus
            // 
            this.DevisStatus.FormattingEnabled = true;
            this.DevisStatus.ItemHeight = 23;
            this.DevisStatus.Items.AddRange(new object[] {
            "En attente",
            "Validé"});
            this.DevisStatus.Location = new System.Drawing.Point(136, 47);
            this.DevisStatus.Name = "DevisStatus";
            this.DevisStatus.Size = new System.Drawing.Size(154, 29);
            this.DevisStatus.TabIndex = 41;
            this.DevisStatus.UseSelectable = true;
            this.DevisStatus.SelectedIndexChanged += new System.EventHandler(this.DevisStatus_SelectedIndexChanged);
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel17.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel17.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroLabel17.Location = new System.Drawing.Point(11, 17);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(92, 19);
            this.metroLabel17.TabIndex = 33;
            this.metroLabel17.Text = "Devis Code :";
            this.metroLabel17.UseCustomBackColor = true;
            this.metroLabel17.UseCustomForeColor = true;
            // 
            // DevisCode
            // 
            // 
            // 
            // 
            this.DevisCode.CustomButton.Image = null;
            this.DevisCode.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.DevisCode.CustomButton.Name = "";
            this.DevisCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.DevisCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.DevisCode.CustomButton.TabIndex = 1;
            this.DevisCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.DevisCode.CustomButton.UseSelectable = true;
            this.DevisCode.CustomButton.Visible = false;
            this.DevisCode.Lines = new string[0];
            this.DevisCode.Location = new System.Drawing.Point(136, 13);
            this.DevisCode.MaxLength = 32767;
            this.DevisCode.Name = "DevisCode";
            this.DevisCode.PasswordChar = '\0';
            this.DevisCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DevisCode.SelectedText = "";
            this.DevisCode.SelectionLength = 0;
            this.DevisCode.SelectionStart = 0;
            this.DevisCode.ShortcutsEnabled = true;
            this.DevisCode.Size = new System.Drawing.Size(154, 23);
            this.DevisCode.TabIndex = 15;
            this.DevisCode.UseSelectable = true;
            this.DevisCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DevisCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // DevisDate
            // 
            this.DevisDate.Location = new System.Drawing.Point(136, 90);
            this.DevisDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.DevisDate.Name = "DevisDate";
            this.DevisDate.Size = new System.Drawing.Size(154, 29);
            this.DevisDate.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 44;
            this.label1.Text = "Facture";
            // 
            // PanelInfo1
            // 
            this.PanelInfo1.BackColor = System.Drawing.Color.Transparent;
            this.PanelInfo1.Controls.Add(this.metroLabel2);
            this.PanelInfo1.Controls.Add(this.metroLabel15);
            this.PanelInfo1.Controls.Add(this.metroLabel11);
            this.PanelInfo1.Controls.Add(this.metroLabel9);
            this.PanelInfo1.Controls.Add(this.metroLabel8);
            this.PanelInfo1.Controls.Add(this.metroLabel1);
            this.PanelInfo1.Controls.Add(this.tvacombobox);
            this.PanelInfo1.Controls.Add(this.metroLabel20);
            this.PanelInfo1.Controls.Add(this.FactureCode);
            this.PanelInfo1.Controls.Add(this.Reference);
            this.PanelInfo1.Controls.Add(this.Designation);
            this.PanelInfo1.Controls.Add(this.QTE);
            this.PanelInfo1.Controls.Add(this.Date);
            this.PanelInfo1.Controls.Add(this.Prix);
            this.PanelInfo1.HorizontalScrollbarBarColor = true;
            this.PanelInfo1.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelInfo1.HorizontalScrollbarSize = 10;
            this.PanelInfo1.Location = new System.Drawing.Point(14, 37);
            this.PanelInfo1.Name = "PanelInfo1";
            this.PanelInfo1.Size = new System.Drawing.Size(329, 239);
            this.PanelInfo1.TabIndex = 42;
            this.PanelInfo1.UseCustomBackColor = true;
            this.PanelInfo1.UseCustomForeColor = true;
            this.PanelInfo1.UseStyleColors = true;
            this.PanelInfo1.VerticalScrollbarBarColor = true;
            this.PanelInfo1.VerticalScrollbarHighlightOnWheel = false;
            this.PanelInfo1.VerticalScrollbarSize = 10;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroLabel2.Location = new System.Drawing.Point(11, 210);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(48, 19);
            this.metroLabel2.TabIndex = 47;
            this.metroLabel2.Text = "Date :";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel15.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroLabel15.Location = new System.Drawing.Point(11, 46);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(84, 19);
            this.metroLabel15.TabIndex = 46;
            this.metroLabel15.Text = "Reference :";
            this.metroLabel15.UseCustomBackColor = true;
            this.metroLabel15.UseCustomForeColor = true;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroLabel11.Location = new System.Drawing.Point(11, 75);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(96, 19);
            this.metroLabel11.TabIndex = 45;
            this.metroLabel11.Text = "Designation :";
            this.metroLabel11.UseCustomBackColor = true;
            this.metroLabel11.UseCustomForeColor = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroLabel9.Location = new System.Drawing.Point(11, 104);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(74, 19);
            this.metroLabel9.TabIndex = 44;
            this.metroLabel9.Text = "Qunatite :";
            this.metroLabel9.UseCustomBackColor = true;
            this.metroLabel9.UseCustomForeColor = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroLabel8.Location = new System.Drawing.Point(11, 133);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(91, 19);
            this.metroLabel8.TabIndex = 43;
            this.metroLabel8.Text = "Prix / unite :";
            this.metroLabel8.UseCustomBackColor = true;
            this.metroLabel8.UseCustomForeColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroLabel1.Location = new System.Drawing.Point(11, 172);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(51, 19);
            this.metroLabel1.TabIndex = 42;
            this.metroLabel1.Text = "TVA %";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // tvacombobox
            // 
            this.tvacombobox.FormattingEnabled = true;
            this.tvacombobox.ItemHeight = 23;
            this.tvacombobox.Items.AddRange(new object[] {
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.tvacombobox.Location = new System.Drawing.Point(136, 162);
            this.tvacombobox.Name = "tvacombobox";
            this.tvacombobox.Size = new System.Drawing.Size(154, 29);
            this.tvacombobox.TabIndex = 41;
            this.tvacombobox.UseSelectable = true;
            // 
            // metroLabel20
            // 
            this.metroLabel20.AutoSize = true;
            this.metroLabel20.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel20.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel20.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroLabel20.Location = new System.Drawing.Point(11, 13);
            this.metroLabel20.Name = "metroLabel20";
            this.metroLabel20.Size = new System.Drawing.Size(105, 19);
            this.metroLabel20.TabIndex = 33;
            this.metroLabel20.Text = "Facture Code :";
            this.metroLabel20.UseCustomBackColor = true;
            this.metroLabel20.UseCustomForeColor = true;
            // 
            // FactureCode
            // 
            // 
            // 
            // 
            this.FactureCode.CustomButton.Image = null;
            this.FactureCode.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.FactureCode.CustomButton.Name = "";
            this.FactureCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.FactureCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.FactureCode.CustomButton.TabIndex = 1;
            this.FactureCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.FactureCode.CustomButton.UseSelectable = true;
            this.FactureCode.CustomButton.Visible = false;
            this.FactureCode.Lines = new string[0];
            this.FactureCode.Location = new System.Drawing.Point(136, 13);
            this.FactureCode.MaxLength = 32767;
            this.FactureCode.Name = "FactureCode";
            this.FactureCode.PasswordChar = '\0';
            this.FactureCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.FactureCode.SelectedText = "";
            this.FactureCode.SelectionLength = 0;
            this.FactureCode.SelectionStart = 0;
            this.FactureCode.ShortcutsEnabled = true;
            this.FactureCode.Size = new System.Drawing.Size(154, 23);
            this.FactureCode.TabIndex = 15;
            this.FactureCode.UseSelectable = true;
            this.FactureCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.FactureCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Reference
            // 
            // 
            // 
            // 
            this.Reference.CustomButton.Image = null;
            this.Reference.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.Reference.CustomButton.Name = "";
            this.Reference.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Reference.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Reference.CustomButton.TabIndex = 1;
            this.Reference.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Reference.CustomButton.UseSelectable = true;
            this.Reference.CustomButton.Visible = false;
            this.Reference.Lines = new string[0];
            this.Reference.Location = new System.Drawing.Point(136, 42);
            this.Reference.MaxLength = 32767;
            this.Reference.Name = "Reference";
            this.Reference.PasswordChar = '\0';
            this.Reference.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Reference.SelectedText = "";
            this.Reference.SelectionLength = 0;
            this.Reference.SelectionStart = 0;
            this.Reference.ShortcutsEnabled = true;
            this.Reference.Size = new System.Drawing.Size(154, 23);
            this.Reference.TabIndex = 9;
            this.Reference.UseSelectable = true;
            this.Reference.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Reference.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Designation
            // 
            // 
            // 
            // 
            this.Designation.CustomButton.Image = null;
            this.Designation.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.Designation.CustomButton.Name = "";
            this.Designation.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Designation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Designation.CustomButton.TabIndex = 1;
            this.Designation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Designation.CustomButton.UseSelectable = true;
            this.Designation.CustomButton.Visible = false;
            this.Designation.Lines = new string[0];
            this.Designation.Location = new System.Drawing.Point(136, 71);
            this.Designation.MaxLength = 32767;
            this.Designation.Name = "Designation";
            this.Designation.PasswordChar = '\0';
            this.Designation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Designation.SelectedText = "";
            this.Designation.SelectionLength = 0;
            this.Designation.SelectionStart = 0;
            this.Designation.ShortcutsEnabled = true;
            this.Designation.Size = new System.Drawing.Size(154, 23);
            this.Designation.TabIndex = 16;
            this.Designation.UseSelectable = true;
            this.Designation.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Designation.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // QTE
            // 
            // 
            // 
            // 
            this.QTE.CustomButton.Image = null;
            this.QTE.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.QTE.CustomButton.Name = "";
            this.QTE.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.QTE.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.QTE.CustomButton.TabIndex = 1;
            this.QTE.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.QTE.CustomButton.UseSelectable = true;
            this.QTE.CustomButton.Visible = false;
            this.QTE.Lines = new string[0];
            this.QTE.Location = new System.Drawing.Point(136, 100);
            this.QTE.MaxLength = 32767;
            this.QTE.Name = "QTE";
            this.QTE.PasswordChar = '\0';
            this.QTE.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.QTE.SelectedText = "";
            this.QTE.SelectionLength = 0;
            this.QTE.SelectionStart = 0;
            this.QTE.ShortcutsEnabled = true;
            this.QTE.Size = new System.Drawing.Size(154, 23);
            this.QTE.TabIndex = 17;
            this.QTE.UseSelectable = true;
            this.QTE.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.QTE.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(136, 200);
            this.Date.MinimumSize = new System.Drawing.Size(0, 29);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(154, 29);
            this.Date.TabIndex = 28;
            // 
            // Prix
            // 
            // 
            // 
            // 
            this.Prix.CustomButton.Image = null;
            this.Prix.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.Prix.CustomButton.Name = "";
            this.Prix.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Prix.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Prix.CustomButton.TabIndex = 1;
            this.Prix.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Prix.CustomButton.UseSelectable = true;
            this.Prix.CustomButton.Visible = false;
            this.Prix.Lines = new string[0];
            this.Prix.Location = new System.Drawing.Point(136, 133);
            this.Prix.MaxLength = 32767;
            this.Prix.Name = "Prix";
            this.Prix.PasswordChar = '\0';
            this.Prix.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Prix.SelectedText = "";
            this.Prix.SelectionLength = 0;
            this.Prix.SelectionStart = 0;
            this.Prix.ShortcutsEnabled = true;
            this.Prix.Size = new System.Drawing.Size(154, 23);
            this.Prix.TabIndex = 18;
            this.Prix.UseSelectable = true;
            this.Prix.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Prix.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PanelInfo2
            // 
            this.PanelInfo2.BackColor = System.Drawing.Color.Transparent;
            this.PanelInfo2.Controls.Add(this.DevisGrid);
            this.PanelInfo2.Controls.Add(this.button4);
            this.PanelInfo2.Controls.Add(this.GenererDevisButt);
            this.PanelInfo2.Controls.Add(this.metroLabel6);
            this.PanelInfo2.Controls.Add(this.butt);
            this.PanelInfo2.Controls.Add(this.metroLabel5);
            this.PanelInfo2.Controls.Add(this.metroLabel4);
            this.PanelInfo2.Controls.Add(this.IfClient);
            this.PanelInfo2.Controls.Add(this.button2);
            this.PanelInfo2.Controls.Add(this.button3);
            this.PanelInfo2.Controls.Add(this.button5);
            this.PanelInfo2.Controls.Add(this.metroLabel23);
            this.PanelInfo2.Controls.Add(this.button1);
            this.PanelInfo2.Controls.Add(this.metroLabel22);
            this.PanelInfo2.Controls.Add(this.metroLabel21);
            this.PanelInfo2.Controls.Add(this.metroLabel7);
            this.PanelInfo2.Controls.Add(this.NomClient);
            this.PanelInfo2.Controls.Add(this.IceClient);
            this.PanelInfo2.Controls.Add(this.RS);
            this.PanelInfo2.Controls.Add(this.IDClient);
            this.PanelInfo2.Controls.Add(this.FactureGrid);
            this.PanelInfo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelInfo2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PanelInfo2.HorizontalScrollbarBarColor = true;
            this.PanelInfo2.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelInfo2.HorizontalScrollbarSize = 10;
            this.PanelInfo2.Location = new System.Drawing.Point(355, 15);
            this.PanelInfo2.Name = "PanelInfo2";
            this.PanelInfo2.Size = new System.Drawing.Size(574, 484);
            this.PanelInfo2.TabIndex = 43;
            this.PanelInfo2.UseCustomBackColor = true;
            this.PanelInfo2.UseCustomForeColor = true;
            this.PanelInfo2.UseStyleColors = true;
            this.PanelInfo2.VerticalScrollbarBarColor = true;
            this.PanelInfo2.VerticalScrollbarHighlightOnWheel = false;
            this.PanelInfo2.VerticalScrollbarSize = 10;
            // 
            // DevisGrid
            // 
            this.DevisGrid.AllowUserToOrderColumns = true;
            this.DevisGrid.AllowUserToResizeRows = false;
            this.DevisGrid.BackgroundColor = System.Drawing.Color.Silver;
            this.DevisGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DevisGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DevisGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DevisGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DevisGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DevisGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.DevisGrid.EnableHeadersVisualStyles = false;
            this.DevisGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DevisGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DevisGrid.Location = new System.Drawing.Point(20, 306);
            this.DevisGrid.Name = "DevisGrid";
            this.DevisGrid.ReadOnly = true;
            this.DevisGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DevisGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DevisGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DevisGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DevisGrid.Size = new System.Drawing.Size(538, 113);
            this.DevisGrid.TabIndex = 54;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightGray;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(312, 448);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(72, 33);
            this.button4.TabIndex = 48;
            this.button4.Text = "Quitter";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.QuitterButton);
            // 
            // GenererDevisButt
            // 
            this.GenererDevisButt.BackColor = System.Drawing.Color.LightGray;
            this.GenererDevisButt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GenererDevisButt.BackgroundImage")));
            this.GenererDevisButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GenererDevisButt.FlatAppearance.BorderSize = 0;
            this.GenererDevisButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenererDevisButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenererDevisButt.Location = new System.Drawing.Point(155, 425);
            this.GenererDevisButt.Name = "GenererDevisButt";
            this.GenererDevisButt.Size = new System.Drawing.Size(99, 55);
            this.GenererDevisButt.TabIndex = 51;
            this.GenererDevisButt.Text = "Devis=>Facture";
            this.GenererDevisButt.UseVisualStyleBackColor = false;
            this.GenererDevisButt.Click += new System.EventHandler(this.GenererDevis);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroLabel6.Location = new System.Drawing.Point(20, 288);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(114, 19);
            this.metroLabel6.TabIndex = 53;
            this.metroLabel6.Text = "Liste des Devis :";
            this.metroLabel6.UseCustomBackColor = true;
            this.metroLabel6.UseCustomForeColor = true;
            // 
            // butt
            // 
            this.butt.BackColor = System.Drawing.Color.LightGray;
            this.butt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butt.BackgroundImage")));
            this.butt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butt.FlatAppearance.BorderSize = 0;
            this.butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butt.Location = new System.Drawing.Point(20, 426);
            this.butt.Name = "butt";
            this.butt.Size = new System.Drawing.Size(99, 55);
            this.butt.TabIndex = 50;
            this.butt.Text = "Nouveau Devis";
            this.butt.UseVisualStyleBackColor = false;
            this.butt.Click += new System.EventHandler(this.NewDevis);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroLabel5.Location = new System.Drawing.Point(20, 84);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(134, 19);
            this.metroLabel5.TabIndex = 52;
            this.metroLabel5.Text = "Liste des Produits :";
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroLabel4.Location = new System.Drawing.Point(316, 43);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(68, 19);
            this.metroLabel4.TabIndex = 51;
            this.metroLabel4.Text = "If Client :";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // IfClient
            // 
            this.IfClient.BackColor = System.Drawing.Color.Silver;
            // 
            // 
            // 
            this.IfClient.CustomButton.Image = null;
            this.IfClient.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.IfClient.CustomButton.Name = "";
            this.IfClient.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.IfClient.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.IfClient.CustomButton.TabIndex = 1;
            this.IfClient.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.IfClient.CustomButton.UseSelectable = true;
            this.IfClient.CustomButton.Visible = false;
            this.IfClient.Enabled = false;
            this.IfClient.Lines = new string[0];
            this.IfClient.Location = new System.Drawing.Point(407, 39);
            this.IfClient.MaxLength = 32767;
            this.IfClient.Name = "IfClient";
            this.IfClient.PasswordChar = '\0';
            this.IfClient.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.IfClient.SelectedText = "";
            this.IfClient.SelectionLength = 0;
            this.IfClient.SelectionStart = 0;
            this.IfClient.ShortcutsEnabled = true;
            this.IfClient.Size = new System.Drawing.Size(154, 23);
            this.IfClient.TabIndex = 50;
            this.IfClient.UseCustomBackColor = true;
            this.IfClient.UseSelectable = true;
            this.IfClient.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.IfClient.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGray;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(245, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 52);
            this.button2.TabIndex = 46;
            this.button2.Text = "Modifier Facture";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.ModifierFactureButton);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightGray;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(462, 222);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 55);
            this.button3.TabIndex = 47;
            this.button3.Text = "Supprimer Facture";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.SupprimerButton);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(407, 448);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(151, 32);
            this.button5.TabIndex = 49;
            this.button5.Text = "vider les champs";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // metroLabel23
            // 
            this.metroLabel23.AutoSize = true;
            this.metroLabel23.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel23.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel23.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroLabel23.Location = new System.Drawing.Point(316, 72);
            this.metroLabel23.Name = "metroLabel23";
            this.metroLabel23.Size = new System.Drawing.Size(78, 19);
            this.metroLabel23.TabIndex = 36;
            this.metroLabel23.Text = "Ice Client :";
            this.metroLabel23.UseCustomBackColor = true;
            this.metroLabel23.UseCustomForeColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(20, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 52);
            this.button1.TabIndex = 45;
            this.button1.Text = "Ajouter Facture";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.AjouterFactureButton);
            // 
            // metroLabel22
            // 
            this.metroLabel22.AutoSize = true;
            this.metroLabel22.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel22.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel22.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroLabel22.Location = new System.Drawing.Point(20, 55);
            this.metroLabel22.Name = "metroLabel22";
            this.metroLabel22.Size = new System.Drawing.Size(30, 19);
            this.metroLabel22.TabIndex = 35;
            this.metroLabel22.Text = "RS:";
            this.metroLabel22.UseCustomBackColor = true;
            this.metroLabel22.UseCustomForeColor = true;
            // 
            // metroLabel21
            // 
            this.metroLabel21.AutoSize = true;
            this.metroLabel21.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel21.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel21.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroLabel21.Location = new System.Drawing.Point(316, 14);
            this.metroLabel21.Name = "metroLabel21";
            this.metroLabel21.Size = new System.Drawing.Size(73, 19);
            this.metroLabel21.TabIndex = 34;
            this.metroLabel21.Text = "Client ID :";
            this.metroLabel21.UseCustomBackColor = true;
            this.metroLabel21.UseCustomForeColor = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroLabel7.Location = new System.Drawing.Point(20, 10);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(113, 19);
            this.metroLabel7.TabIndex = 6;
            this.metroLabel7.Text = "Nom de Client :";
            this.metroLabel7.UseCustomBackColor = true;
            this.metroLabel7.UseCustomForeColor = true;
            // 
            // NomClient
            // 
            this.NomClient.FormattingEnabled = true;
            this.NomClient.ItemHeight = 23;
            this.NomClient.Location = new System.Drawing.Point(141, 3);
            this.NomClient.Name = "NomClient";
            this.NomClient.Size = new System.Drawing.Size(151, 29);
            this.NomClient.TabIndex = 13;
            this.NomClient.UseSelectable = true;
            this.NomClient.SelectedIndexChanged += new System.EventHandler(this.NomClient_IndexChanged);
            // 
            // IceClient
            // 
            this.IceClient.BackColor = System.Drawing.Color.Silver;
            // 
            // 
            // 
            this.IceClient.CustomButton.Image = null;
            this.IceClient.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.IceClient.CustomButton.Name = "";
            this.IceClient.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.IceClient.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.IceClient.CustomButton.TabIndex = 1;
            this.IceClient.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.IceClient.CustomButton.UseSelectable = true;
            this.IceClient.CustomButton.Visible = false;
            this.IceClient.Enabled = false;
            this.IceClient.Lines = new string[0];
            this.IceClient.Location = new System.Drawing.Point(407, 68);
            this.IceClient.MaxLength = 32767;
            this.IceClient.Name = "IceClient";
            this.IceClient.PasswordChar = '\0';
            this.IceClient.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.IceClient.SelectedText = "";
            this.IceClient.SelectionLength = 0;
            this.IceClient.SelectionStart = 0;
            this.IceClient.ShortcutsEnabled = true;
            this.IceClient.Size = new System.Drawing.Size(154, 23);
            this.IceClient.TabIndex = 24;
            this.IceClient.UseCustomBackColor = true;
            this.IceClient.UseSelectable = true;
            this.IceClient.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.IceClient.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // RS
            // 
            this.RS.FormattingEnabled = true;
            this.RS.ItemHeight = 23;
            this.RS.Items.AddRange(new object[] {
            " ",
            "RS1",
            "RS2",
            "RS3",
            "RS4"});
            this.RS.Location = new System.Drawing.Point(141, 45);
            this.RS.Name = "RS";
            this.RS.Size = new System.Drawing.Size(151, 29);
            this.RS.TabIndex = 14;
            this.RS.UseSelectable = true;
            // 
            // IDClient
            // 
            this.IDClient.BackColor = System.Drawing.Color.Silver;
            // 
            // 
            // 
            this.IDClient.CustomButton.Image = null;
            this.IDClient.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.IDClient.CustomButton.Name = "";
            this.IDClient.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.IDClient.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.IDClient.CustomButton.TabIndex = 1;
            this.IDClient.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.IDClient.CustomButton.UseSelectable = true;
            this.IDClient.CustomButton.Visible = false;
            this.IDClient.Enabled = false;
            this.IDClient.Lines = new string[0];
            this.IDClient.Location = new System.Drawing.Point(407, 10);
            this.IDClient.MaxLength = 32767;
            this.IDClient.Name = "IDClient";
            this.IDClient.PasswordChar = '\0';
            this.IDClient.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.IDClient.SelectedText = "";
            this.IDClient.SelectionLength = 0;
            this.IDClient.SelectionStart = 0;
            this.IDClient.ShortcutsEnabled = true;
            this.IDClient.Size = new System.Drawing.Size(154, 23);
            this.IDClient.TabIndex = 26;
            this.IDClient.UseCustomBackColor = true;
            this.IDClient.UseSelectable = true;
            this.IDClient.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.IDClient.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FactureGrid
            // 
            this.FactureGrid.AllowUserToOrderColumns = true;
            this.FactureGrid.AllowUserToResizeRows = false;
            this.FactureGrid.BackgroundColor = System.Drawing.Color.Silver;
            this.FactureGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FactureGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.FactureGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FactureGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.FactureGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FactureGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.FactureGrid.EnableHeadersVisualStyles = false;
            this.FactureGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FactureGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FactureGrid.Location = new System.Drawing.Point(20, 106);
            this.FactureGrid.Name = "FactureGrid";
            this.FactureGrid.ReadOnly = true;
            this.FactureGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FactureGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.FactureGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.FactureGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FactureGrid.Size = new System.Drawing.Size(538, 113);
            this.FactureGrid.TabIndex = 20;
            this.FactureGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FactureGrid_CellContentClick);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel10.Location = new System.Drawing.Point(14, 421);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(133, 19);
            this.metroLabel10.TabIndex = 32;
            this.metroLabel10.Text = "Montant Total (dh)";
            this.metroLabel10.UseCustomBackColor = true;
            this.metroLabel10.UseCustomForeColor = true;
            // 
            // MontantTotal
            // 
            this.MontantTotal.BackColor = System.Drawing.Color.Silver;
            // 
            // 
            // 
            this.MontantTotal.CustomButton.Image = null;
            this.MontantTotal.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.MontantTotal.CustomButton.Name = "";
            this.MontantTotal.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.MontantTotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MontantTotal.CustomButton.TabIndex = 1;
            this.MontantTotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MontantTotal.CustomButton.UseSelectable = true;
            this.MontantTotal.CustomButton.Visible = false;
            this.MontantTotal.Enabled = false;
            this.MontantTotal.Lines = new string[0];
            this.MontantTotal.Location = new System.Drawing.Point(150, 421);
            this.MontantTotal.MaxLength = 32767;
            this.MontantTotal.Name = "MontantTotal";
            this.MontantTotal.PasswordChar = '\0';
            this.MontantTotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MontantTotal.SelectedText = "";
            this.MontantTotal.SelectionLength = 0;
            this.MontantTotal.SelectionStart = 0;
            this.MontantTotal.ShortcutsEnabled = true;
            this.MontantTotal.Size = new System.Drawing.Size(154, 23);
            this.MontantTotal.TabIndex = 35;
            this.MontantTotal.UseCustomBackColor = true;
            this.MontantTotal.UseSelectable = true;
            this.MontantTotal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MontantTotal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TotalAPayer
            // 
            this.TotalAPayer.BackColor = System.Drawing.Color.Silver;
            // 
            // 
            // 
            this.TotalAPayer.CustomButton.Image = null;
            this.TotalAPayer.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.TotalAPayer.CustomButton.Name = "";
            this.TotalAPayer.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TotalAPayer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TotalAPayer.CustomButton.TabIndex = 1;
            this.TotalAPayer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TotalAPayer.CustomButton.UseSelectable = true;
            this.TotalAPayer.CustomButton.Visible = false;
            this.TotalAPayer.Enabled = false;
            this.TotalAPayer.Lines = new string[0];
            this.TotalAPayer.Location = new System.Drawing.Point(150, 476);
            this.TotalAPayer.MaxLength = 32767;
            this.TotalAPayer.Name = "TotalAPayer";
            this.TotalAPayer.PasswordChar = '\0';
            this.TotalAPayer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TotalAPayer.SelectedText = "";
            this.TotalAPayer.SelectionLength = 0;
            this.TotalAPayer.SelectionStart = 0;
            this.TotalAPayer.ShortcutsEnabled = true;
            this.TotalAPayer.Size = new System.Drawing.Size(154, 23);
            this.TotalAPayer.TabIndex = 37;
            this.TotalAPayer.UseCustomBackColor = true;
            this.TotalAPayer.UseSelectable = true;
            this.TotalAPayer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TotalAPayer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel13.Location = new System.Drawing.Point(14, 476);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(128, 19);
            this.metroLabel13.TabIndex = 34;
            this.metroLabel13.Text = "Total à payer (dh)";
            this.metroLabel13.UseCustomBackColor = true;
            this.metroLabel13.UseCustomForeColor = true;
            // 
            // ValeurTva
            // 
            this.ValeurTva.BackColor = System.Drawing.Color.Silver;
            // 
            // 
            // 
            this.ValeurTva.CustomButton.Image = null;
            this.ValeurTva.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.ValeurTva.CustomButton.Name = "";
            this.ValeurTva.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ValeurTva.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ValeurTva.CustomButton.TabIndex = 1;
            this.ValeurTva.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ValeurTva.CustomButton.UseSelectable = true;
            this.ValeurTva.CustomButton.Visible = false;
            this.ValeurTva.Enabled = false;
            this.ValeurTva.Lines = new string[0];
            this.ValeurTva.Location = new System.Drawing.Point(150, 450);
            this.ValeurTva.MaxLength = 32767;
            this.ValeurTva.Name = "ValeurTva";
            this.ValeurTva.PasswordChar = '\0';
            this.ValeurTva.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ValeurTva.SelectedText = "";
            this.ValeurTva.SelectionLength = 0;
            this.ValeurTva.SelectionStart = 0;
            this.ValeurTva.ShortcutsEnabled = true;
            this.ValeurTva.Size = new System.Drawing.Size(154, 23);
            this.ValeurTva.TabIndex = 36;
            this.ValeurTva.UseCustomBackColor = true;
            this.ValeurTva.UseSelectable = true;
            this.ValeurTva.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ValeurTva.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel12.Location = new System.Drawing.Point(16, 450);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(58, 19);
            this.metroLabel12.TabIndex = 33;
            this.metroLabel12.Text = "Tva (%)";
            this.metroLabel12.UseCustomBackColor = true;
            this.metroLabel12.UseCustomForeColor = true;
            // 
            // Form1
            // 
            this.ApplyImageInvert = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 525);
            this.Controls.Add(this.PanelHome);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Facture";
            this.TransparencyKey = System.Drawing.Color.RoyalBlue;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanelHome.ResumeLayout(false);
            this.PanelHome.PerformLayout();
            this.DevisPanel.ResumeLayout(false);
            this.DevisPanel.PerformLayout();
            this.PanelInfo1.ResumeLayout(false);
            this.PanelInfo1.PerformLayout();
            this.PanelInfo2.ResumeLayout(false);
            this.PanelInfo2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DevisGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FactureGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox Reference;
        private MetroFramework.Controls.MetroComboBox NomClient;
        private MetroFramework.Controls.MetroComboBox RS;
        private MetroFramework.Controls.MetroTextBox FactureCode;
        private MetroFramework.Controls.MetroTextBox Designation;
        private MetroFramework.Controls.MetroTextBox QTE;
        private MetroFramework.Controls.MetroTextBox Prix;
        private MetroFramework.Controls.MetroGrid FactureGrid;
        private MetroFramework.Controls.MetroTextBox IceClient;
        private MetroFramework.Controls.MetroTextBox IDClient;
        private MetroFramework.Controls.MetroDateTime Date;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroTextBox MontantTotal;
        private MetroFramework.Controls.MetroTextBox ValeurTva;
        private MetroFramework.Controls.MetroTextBox TotalAPayer;
        private MetroFramework.Controls.MetroComboBox tvacombobox;
        private MetroFramework.Controls.MetroPanel PanelInfo1;
        private MetroFramework.Controls.MetroPanel PanelInfo2;
        private MetroFramework.Controls.MetroPanel PanelHome;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel20;
        private MetroFramework.Controls.MetroLabel metroLabel23;
        private MetroFramework.Controls.MetroLabel metroLabel22;
        private MetroFramework.Controls.MetroLabel metroLabel21;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private MetroFramework.Controls.MetroPanel DevisPanel;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroComboBox DevisStatus;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroTextBox DevisCode;
        private MetroFramework.Controls.MetroDateTime DevisDate;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox IfClient;
        private MetroFramework.Controls.MetroGrid DevisGrid;
        private System.Windows.Forms.Button GenererDevisButt;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.Button butt;
        private MetroFramework.Controls.MetroLabel metroLabel5;
    }
}

