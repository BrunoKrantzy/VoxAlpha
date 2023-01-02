namespace VoxAlpha
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
            this.toolStripTop = new System.Windows.Forms.ToolStrip();
            this.DropButtonDiff = new System.Windows.Forms.ToolStripDropDownButton();
            this.n1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.n2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.majusculesAccentuéesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minusculesAccentuéesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolButtonAide = new System.Windows.Forms.ToolStripButton();
            this.tablePanelAlphaMaj = new System.Windows.Forms.TableLayoutPanel();
            this.tablePanelRep = new System.Windows.Forms.TableLayoutPanel();
            this.listBoxE = new System.Windows.Forms.ListBox();
            this.listBoxA = new System.Windows.Forms.ListBox();
            this.listBoxI = new System.Windows.Forms.ListBox();
            this.listBoxO = new System.Windows.Forms.ListBox();
            this.listBoxU = new System.Windows.Forms.ListBox();
            this.listBoxC = new System.Windows.Forms.ListBox();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.tablePanelMinAcc = new System.Windows.Forms.TableLayoutPanel();
            this.tablePanelMajAcc = new System.Windows.Forms.TableLayoutPanel();
            this.listBoxAcap = new System.Windows.Forms.ListBox();
            this.listBoxCcap = new System.Windows.Forms.ListBox();
            this.listBoxUcap = new System.Windows.Forms.ListBox();
            this.listBoxEcap = new System.Windows.Forms.ListBox();
            this.listBoxOcap = new System.Windows.Forms.ListBox();
            this.listBoxIcap = new System.Windows.Forms.ListBox();
            this.tablePanelAlphaMin = new System.Windows.Forms.TableLayoutPanel();
            this.labelMot = new System.Windows.Forms.Label();
            this.picBoxImage = new System.Windows.Forms.PictureBox();
            this.buttonExact = new System.Windows.Forms.Button();
            this.toolStripTop.SuspendLayout();
            this.tablePanelMinAcc.SuspendLayout();
            this.tablePanelMajAcc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripTop
            // 
            this.toolStripTop.BackColor = System.Drawing.Color.LightSteelBlue;
            this.toolStripTop.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DropButtonDiff,
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.toolButtonAide});
            this.toolStripTop.Location = new System.Drawing.Point(0, 0);
            this.toolStripTop.Name = "toolStripTop";
            this.toolStripTop.Size = new System.Drawing.Size(1008, 25);
            this.toolStripTop.TabIndex = 0;
            this.toolStripTop.Text = "toolStrip1";
            // 
            // DropButtonDiff
            // 
            this.DropButtonDiff.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DropButtonDiff.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.n1ToolStripMenuItem,
            this.n2ToolStripMenuItem,
            this.majusculesAccentuéesToolStripMenuItem,
            this.minusculesAccentuéesToolStripMenuItem});
            this.DropButtonDiff.Image = ((System.Drawing.Image)(resources.GetObject("DropButtonDiff.Image")));
            this.DropButtonDiff.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DropButtonDiff.Name = "DropButtonDiff";
            this.DropButtonDiff.Size = new System.Drawing.Size(123, 22);
            this.DropButtonDiff.Text = "Niveau de difficulté";
            // 
            // n1ToolStripMenuItem
            // 
            this.n1ToolStripMenuItem.Name = "n1ToolStripMenuItem";
            this.n1ToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.n1ToolStripMenuItem.Text = "Majuscules";
            this.n1ToolStripMenuItem.Click += new System.EventHandler(this.MajToolStripMenuItem_Click);
            // 
            // n2ToolStripMenuItem
            // 
            this.n2ToolStripMenuItem.Name = "n2ToolStripMenuItem";
            this.n2ToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.n2ToolStripMenuItem.Text = "Minuscules";
            this.n2ToolStripMenuItem.Click += new System.EventHandler(this.MinToolStripMenuItem_Click);
            // 
            // majusculesAccentuéesToolStripMenuItem
            // 
            this.majusculesAccentuéesToolStripMenuItem.Name = "majusculesAccentuéesToolStripMenuItem";
            this.majusculesAccentuéesToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.majusculesAccentuéesToolStripMenuItem.Text = "Majuscules accentuées";
            this.majusculesAccentuéesToolStripMenuItem.Click += new System.EventHandler(this.majusculesAccentuéesToolStripMenuItem_Click);
            // 
            // minusculesAccentuéesToolStripMenuItem
            // 
            this.minusculesAccentuéesToolStripMenuItem.Name = "minusculesAccentuéesToolStripMenuItem";
            this.minusculesAccentuéesToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.minusculesAccentuéesToolStripMenuItem.Text = "Minuscules accentuées";
            this.minusculesAccentuéesToolStripMenuItem.Click += new System.EventHandler(this.minusculesAccentuéesToolStripMenuItem_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.BackColor = System.Drawing.Color.Lavender;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolButtonAide
            // 
            this.toolButtonAide.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolButtonAide.Image = ((System.Drawing.Image)(resources.GetObject("toolButtonAide.Image")));
            this.toolButtonAide.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolButtonAide.Name = "toolButtonAide";
            this.toolButtonAide.Size = new System.Drawing.Size(35, 22);
            this.toolButtonAide.Text = "Aide";
            this.toolButtonAide.Click += new System.EventHandler(this.toolButtonAide_Click);
            // 
            // tablePanelAlphaMaj
            // 
            this.tablePanelAlphaMaj.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablePanelAlphaMaj.AutoSize = true;
            this.tablePanelAlphaMaj.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.tablePanelAlphaMaj.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tablePanelAlphaMaj.ColumnCount = 13;
            this.tablePanelAlphaMaj.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tablePanelAlphaMaj.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.tablePanelAlphaMaj.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.tablePanelAlphaMaj.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.tablePanelAlphaMaj.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.tablePanelAlphaMaj.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.tablePanelAlphaMaj.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.tablePanelAlphaMaj.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.tablePanelAlphaMaj.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.tablePanelAlphaMaj.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.tablePanelAlphaMaj.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.tablePanelAlphaMaj.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.tablePanelAlphaMaj.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.tablePanelAlphaMaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tablePanelAlphaMaj.Location = new System.Drawing.Point(214, 130);
            this.tablePanelAlphaMaj.Margin = new System.Windows.Forms.Padding(0);
            this.tablePanelAlphaMaj.Name = "tablePanelAlphaMaj";
            this.tablePanelAlphaMaj.RowCount = 2;
            this.tablePanelAlphaMaj.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePanelAlphaMaj.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePanelAlphaMaj.Size = new System.Drawing.Size(660, 60);
            this.tablePanelAlphaMaj.TabIndex = 1;
            // 
            // tablePanelRep
            // 
            this.tablePanelRep.AutoSize = true;
            this.tablePanelRep.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tablePanelRep.ColumnCount = 1;
            this.tablePanelRep.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tablePanelRep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tablePanelRep.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tablePanelRep.Location = new System.Drawing.Point(33, 438);
            this.tablePanelRep.MinimumSize = new System.Drawing.Size(20, 20);
            this.tablePanelRep.Name = "tablePanelRep";
            this.tablePanelRep.Padding = new System.Windows.Forms.Padding(1);
            this.tablePanelRep.RowCount = 1;
            this.tablePanelRep.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablePanelRep.Size = new System.Drawing.Size(20, 20);
            this.tablePanelRep.TabIndex = 2;
            // 
            // listBoxE
            // 
            this.listBoxE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxE.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.listBoxE.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxE.FormattingEnabled = true;
            this.listBoxE.ItemHeight = 29;
            this.listBoxE.Items.AddRange(new object[] {
            "é",
            "è",
            "ê",
            "ë"});
            this.listBoxE.Location = new System.Drawing.Point(175, 3);
            this.listBoxE.Name = "listBoxE";
            this.listBoxE.Size = new System.Drawing.Size(80, 33);
            this.listBoxE.TabIndex = 3;
            this.listBoxE.Click += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // listBoxA
            // 
            this.listBoxA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxA.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.listBoxA.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxA.FormattingEnabled = true;
            this.listBoxA.ItemHeight = 29;
            this.listBoxA.Items.AddRange(new object[] {
            "à",
            "â",
            "æ"});
            this.listBoxA.Location = new System.Drawing.Point(3, 3);
            this.listBoxA.Name = "listBoxA";
            this.listBoxA.Size = new System.Drawing.Size(80, 33);
            this.listBoxA.TabIndex = 4;
            this.listBoxA.Click += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // listBoxI
            // 
            this.listBoxI.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxI.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.listBoxI.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxI.FormattingEnabled = true;
            this.listBoxI.ItemHeight = 29;
            this.listBoxI.Items.AddRange(new object[] {
            "î",
            "ï"});
            this.listBoxI.Location = new System.Drawing.Point(261, 3);
            this.listBoxI.Name = "listBoxI";
            this.listBoxI.Size = new System.Drawing.Size(80, 33);
            this.listBoxI.TabIndex = 5;
            this.listBoxI.Click += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // listBoxO
            // 
            this.listBoxO.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxO.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.listBoxO.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxO.FormattingEnabled = true;
            this.listBoxO.ItemHeight = 29;
            this.listBoxO.Items.AddRange(new object[] {
            "ô",
            "ö",
            "œ"});
            this.listBoxO.Location = new System.Drawing.Point(347, 3);
            this.listBoxO.Name = "listBoxO";
            this.listBoxO.Size = new System.Drawing.Size(80, 33);
            this.listBoxO.TabIndex = 6;
            this.listBoxO.Click += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // listBoxU
            // 
            this.listBoxU.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxU.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.listBoxU.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxU.FormattingEnabled = true;
            this.listBoxU.ItemHeight = 29;
            this.listBoxU.Items.AddRange(new object[] {
            "ù",
            "û",
            "ü"});
            this.listBoxU.Location = new System.Drawing.Point(433, 3);
            this.listBoxU.Name = "listBoxU";
            this.listBoxU.Size = new System.Drawing.Size(84, 33);
            this.listBoxU.TabIndex = 7;
            this.listBoxU.Click += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // listBoxC
            // 
            this.listBoxC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxC.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.listBoxC.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxC.FormattingEnabled = true;
            this.listBoxC.ItemHeight = 29;
            this.listBoxC.Items.AddRange(new object[] {
            "ç"});
            this.listBoxC.Location = new System.Drawing.Point(89, 3);
            this.listBoxC.Name = "listBoxC";
            this.listBoxC.Size = new System.Drawing.Size(80, 33);
            this.listBoxC.TabIndex = 8;
            this.listBoxC.Click += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Font = new System.Drawing.Font("Lucida Handwriting", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrenom.ForeColor = System.Drawing.Color.Maroon;
            this.labelPrenom.Location = new System.Drawing.Point(12, 53);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(461, 41);
            this.labelPrenom.TabIndex = 9;
            this.labelPrenom.Text = "L\'alphabet de Timothée";
            this.labelPrenom.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tablePanelMinAcc
            // 
            this.tablePanelMinAcc.ColumnCount = 6;
            this.tablePanelMinAcc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tablePanelMinAcc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tablePanelMinAcc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tablePanelMinAcc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tablePanelMinAcc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tablePanelMinAcc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tablePanelMinAcc.Controls.Add(this.listBoxC, 1, 0);
            this.tablePanelMinAcc.Controls.Add(this.listBoxU, 5, 0);
            this.tablePanelMinAcc.Controls.Add(this.listBoxE, 2, 0);
            this.tablePanelMinAcc.Controls.Add(this.listBoxO, 4, 0);
            this.tablePanelMinAcc.Controls.Add(this.listBoxI, 3, 0);
            this.tablePanelMinAcc.Controls.Add(this.listBoxA, 0, 0);
            this.tablePanelMinAcc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tablePanelMinAcc.Location = new System.Drawing.Point(12, 302);
            this.tablePanelMinAcc.Name = "tablePanelMinAcc";
            this.tablePanelMinAcc.RowCount = 1;
            this.tablePanelMinAcc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablePanelMinAcc.Size = new System.Drawing.Size(520, 47);
            this.tablePanelMinAcc.TabIndex = 10;
            this.tablePanelMinAcc.Visible = false;
            // 
            // tablePanelMajAcc
            // 
            this.tablePanelMajAcc.ColumnCount = 6;
            this.tablePanelMajAcc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tablePanelMajAcc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tablePanelMajAcc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tablePanelMajAcc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tablePanelMajAcc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tablePanelMajAcc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tablePanelMajAcc.Controls.Add(this.listBoxAcap, 0, 0);
            this.tablePanelMajAcc.Controls.Add(this.listBoxCcap, 1, 0);
            this.tablePanelMajAcc.Controls.Add(this.listBoxUcap, 5, 0);
            this.tablePanelMajAcc.Controls.Add(this.listBoxEcap, 2, 0);
            this.tablePanelMajAcc.Controls.Add(this.listBoxOcap, 4, 0);
            this.tablePanelMajAcc.Controls.Add(this.listBoxIcap, 3, 0);
            this.tablePanelMajAcc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tablePanelMajAcc.Location = new System.Drawing.Point(473, 363);
            this.tablePanelMajAcc.Name = "tablePanelMajAcc";
            this.tablePanelMajAcc.RowCount = 1;
            this.tablePanelMajAcc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablePanelMajAcc.Size = new System.Drawing.Size(520, 44);
            this.tablePanelMajAcc.TabIndex = 11;
            this.tablePanelMajAcc.Visible = false;
            // 
            // listBoxAcap
            // 
            this.listBoxAcap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxAcap.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.listBoxAcap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxAcap.FormattingEnabled = true;
            this.listBoxAcap.ItemHeight = 25;
            this.listBoxAcap.Items.AddRange(new object[] {
            "À",
            "Â",
            "Ä",
            "Æ"});
            this.listBoxAcap.Location = new System.Drawing.Point(3, 3);
            this.listBoxAcap.Name = "listBoxAcap";
            this.listBoxAcap.Size = new System.Drawing.Size(80, 29);
            this.listBoxAcap.TabIndex = 4;
            this.listBoxAcap.Click += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // listBoxCcap
            // 
            this.listBoxCcap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxCcap.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.listBoxCcap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCcap.FormattingEnabled = true;
            this.listBoxCcap.ItemHeight = 25;
            this.listBoxCcap.Items.AddRange(new object[] {
            "Ç"});
            this.listBoxCcap.Location = new System.Drawing.Point(89, 3);
            this.listBoxCcap.Name = "listBoxCcap";
            this.listBoxCcap.Size = new System.Drawing.Size(80, 29);
            this.listBoxCcap.TabIndex = 8;
            this.listBoxCcap.Click += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // listBoxUcap
            // 
            this.listBoxUcap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxUcap.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.listBoxUcap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxUcap.FormattingEnabled = true;
            this.listBoxUcap.ItemHeight = 25;
            this.listBoxUcap.Items.AddRange(new object[] {
            "Ù",
            "Û",
            "Ü"});
            this.listBoxUcap.Location = new System.Drawing.Point(433, 3);
            this.listBoxUcap.Name = "listBoxUcap";
            this.listBoxUcap.Size = new System.Drawing.Size(84, 29);
            this.listBoxUcap.TabIndex = 7;
            this.listBoxUcap.Click += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // listBoxEcap
            // 
            this.listBoxEcap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxEcap.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.listBoxEcap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxEcap.FormattingEnabled = true;
            this.listBoxEcap.ItemHeight = 25;
            this.listBoxEcap.Items.AddRange(new object[] {
            "É",
            "È",
            "Ê",
            "Ë"});
            this.listBoxEcap.Location = new System.Drawing.Point(175, 3);
            this.listBoxEcap.Name = "listBoxEcap";
            this.listBoxEcap.Size = new System.Drawing.Size(80, 29);
            this.listBoxEcap.TabIndex = 3;
            this.listBoxEcap.Click += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // listBoxOcap
            // 
            this.listBoxOcap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxOcap.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.listBoxOcap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxOcap.FormattingEnabled = true;
            this.listBoxOcap.ItemHeight = 25;
            this.listBoxOcap.Items.AddRange(new object[] {
            "Ô",
            "Ö",
            "Œ"});
            this.listBoxOcap.Location = new System.Drawing.Point(347, 3);
            this.listBoxOcap.Name = "listBoxOcap";
            this.listBoxOcap.Size = new System.Drawing.Size(80, 29);
            this.listBoxOcap.TabIndex = 6;
            this.listBoxOcap.Click += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // listBoxIcap
            // 
            this.listBoxIcap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxIcap.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.listBoxIcap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxIcap.FormattingEnabled = true;
            this.listBoxIcap.ItemHeight = 25;
            this.listBoxIcap.Items.AddRange(new object[] {
            "Î",
            "Ï"});
            this.listBoxIcap.Location = new System.Drawing.Point(261, 3);
            this.listBoxIcap.Name = "listBoxIcap";
            this.listBoxIcap.Size = new System.Drawing.Size(80, 29);
            this.listBoxIcap.TabIndex = 5;
            this.listBoxIcap.Click += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // tablePanelAlphaMin
            // 
            this.tablePanelAlphaMin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablePanelAlphaMin.AutoSize = true;
            this.tablePanelAlphaMin.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.tablePanelAlphaMin.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tablePanelAlphaMin.ColumnCount = 13;
            this.tablePanelAlphaMin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
            this.tablePanelAlphaMin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.tablePanelAlphaMin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.tablePanelAlphaMin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.tablePanelAlphaMin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.tablePanelAlphaMin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.tablePanelAlphaMin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.tablePanelAlphaMin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.tablePanelAlphaMin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.tablePanelAlphaMin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.tablePanelAlphaMin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.tablePanelAlphaMin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.tablePanelAlphaMin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.tablePanelAlphaMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tablePanelAlphaMin.Location = new System.Drawing.Point(214, 194);
            this.tablePanelAlphaMin.Margin = new System.Windows.Forms.Padding(0);
            this.tablePanelAlphaMin.Name = "tablePanelAlphaMin";
            this.tablePanelAlphaMin.RowCount = 2;
            this.tablePanelAlphaMin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePanelAlphaMin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePanelAlphaMin.Size = new System.Drawing.Size(660, 60);
            this.tablePanelAlphaMin.TabIndex = 12;
            this.tablePanelAlphaMin.Visible = false;
            // 
            // labelMot
            // 
            this.labelMot.AutoSize = true;
            this.labelMot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelMot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelMot.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMot.ForeColor = System.Drawing.Color.Maroon;
            this.labelMot.Location = new System.Drawing.Point(33, 358);
            this.labelMot.Margin = new System.Windows.Forms.Padding(3);
            this.labelMot.Name = "labelMot";
            this.labelMot.Padding = new System.Windows.Forms.Padding(5);
            this.labelMot.Size = new System.Drawing.Size(242, 51);
            this.labelMot.TabIndex = 13;
            this.labelMot.Text = "Mot aléatoire";
            this.labelMot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMot.Visible = false;
            this.labelMot.Click += new System.EventHandler(this.labelMot_Click);
            // 
            // picBoxImage
            // 
            this.picBoxImage.Location = new System.Drawing.Point(254, 420);
            this.picBoxImage.Name = "picBoxImage";
            this.picBoxImage.Size = new System.Drawing.Size(520, 300);
            this.picBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxImage.TabIndex = 14;
            this.picBoxImage.TabStop = false;
            // 
            // buttonExact
            // 
            this.buttonExact.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonExact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExact.Location = new System.Drawing.Point(799, 420);
            this.buttonExact.Name = "buttonExact";
            this.buttonExact.Size = new System.Drawing.Size(75, 38);
            this.buttonExact.TabIndex = 15;
            this.buttonExact.Text = "Rejouer";
            this.buttonExact.UseVisualStyleBackColor = false;
            this.buttonExact.Visible = false;
            this.buttonExact.Click += new System.EventHandler(this.buttonExact_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.buttonExact);
            this.Controls.Add(this.picBoxImage);
            this.Controls.Add(this.labelMot);
            this.Controls.Add(this.tablePanelAlphaMin);
            this.Controls.Add(this.tablePanelMajAcc);
            this.Controls.Add(this.tablePanelMinAcc);
            this.Controls.Add(this.labelPrenom);
            this.Controls.Add(this.tablePanelRep);
            this.Controls.Add(this.tablePanelAlphaMaj);
            this.Controls.Add(this.toolStripTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VoxAlpha";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.toolStripTop.ResumeLayout(false);
            this.toolStripTop.PerformLayout();
            this.tablePanelMinAcc.ResumeLayout(false);
            this.tablePanelMajAcc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripTop;
        private System.Windows.Forms.ToolStripDropDownButton DropButtonDiff;
        private System.Windows.Forms.ToolStripMenuItem n1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem n2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.TableLayoutPanel tablePanelAlphaMaj;
        private System.Windows.Forms.TableLayoutPanel tablePanelRep;
        private System.Windows.Forms.ListBox listBoxE;
        private System.Windows.Forms.ToolStripMenuItem majusculesAccentuéesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minusculesAccentuéesToolStripMenuItem;
        private System.Windows.Forms.ListBox listBoxA;
        private System.Windows.Forms.ListBox listBoxI;
        private System.Windows.Forms.ListBox listBoxO;
        private System.Windows.Forms.ListBox listBoxU;
        private System.Windows.Forms.ListBox listBoxC;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.TableLayoutPanel tablePanelMinAcc;
        private System.Windows.Forms.TableLayoutPanel tablePanelMajAcc;
        private System.Windows.Forms.ListBox listBoxAcap;
        private System.Windows.Forms.ListBox listBoxCcap;
        private System.Windows.Forms.ListBox listBoxUcap;
        private System.Windows.Forms.ListBox listBoxEcap;
        private System.Windows.Forms.ListBox listBoxOcap;
        private System.Windows.Forms.ListBox listBoxIcap;
        private System.Windows.Forms.TableLayoutPanel tablePanelAlphaMin;
        private System.Windows.Forms.Label labelMot;
        private System.Windows.Forms.PictureBox picBoxImage;
        private System.Windows.Forms.Button buttonExact;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolButtonAide;
    }
}

