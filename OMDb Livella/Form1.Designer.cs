namespace OMDb_Livella
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.headerLayout = new System.Windows.Forms.TableLayoutPanel();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.omdbLabel = new System.Windows.Forms.Label();
            this.leftLayout = new System.Windows.Forms.TableLayoutPanel();
            this.movieList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.movieImageList = new System.Windows.Forms.ImageList(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.detailsViewBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.resultsToGet = new System.Windows.Forms.ComboBox();
            this.tileViewBtn = new System.Windows.Forms.Button();
            this.rightLayout = new System.Windows.Forms.TableLayoutPanel();
            this.statoContentLabel = new System.Windows.Forms.Label();
            this.regiaContentLabel = new System.Windows.Forms.Label();
            this.produzioneContentLabel = new System.Windows.Forms.Label();
            this.titoloContentLabel = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.titoloLabel = new System.Windows.Forms.Label();
            this.produzioneLabel = new System.Windows.Forms.Label();
            this.regiaLabel = new System.Windows.Forms.Label();
            this.statoLabel = new System.Windows.Forms.Label();
            this.tramaLabel = new System.Windows.Forms.Label();
            this.durataLabel = new System.Windows.Forms.Label();
            this.tipoLabel = new System.Windows.Forms.Label();
            this.dvdLabel = new System.Windows.Forms.Label();
            this.annoLabel = new System.Windows.Forms.Label();
            this.annoContentLabel = new System.Windows.Forms.Label();
            this.dvdContentLabel = new System.Windows.Forms.Label();
            this.tipoContentLabel = new System.Windows.Forms.Label();
            this.durataContentLabel = new System.Windows.Forms.Label();
            this.tramaContentLabel = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainLayout.SuspendLayout();
            this.headerLayout.SuspendLayout();
            this.leftLayout.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.rightLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayout
            // 
            this.mainLayout.BackColor = System.Drawing.Color.AliceBlue;
            this.mainLayout.ColumnCount = 2;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.mainLayout.Controls.Add(this.headerLayout, 0, 0);
            this.mainLayout.Controls.Add(this.leftLayout, 0, 1);
            this.mainLayout.Controls.Add(this.rightLayout, 1, 1);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 0);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 2;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainLayout.Size = new System.Drawing.Size(1234, 662);
            this.mainLayout.TabIndex = 1;
            // 
            // headerLayout
            // 
            this.headerLayout.BackColor = System.Drawing.Color.DarkBlue;
            this.headerLayout.ColumnCount = 3;
            this.mainLayout.SetColumnSpan(this.headerLayout, 2);
            this.headerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.headerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.headerLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.headerLayout.Controls.Add(this.searchTxt, 0, 0);
            this.headerLayout.Controls.Add(this.searchBtn, 1, 0);
            this.headerLayout.Controls.Add(this.omdbLabel, 2, 0);
            this.headerLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerLayout.Location = new System.Drawing.Point(3, 3);
            this.headerLayout.Name = "headerLayout";
            this.headerLayout.RowCount = 1;
            this.headerLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.headerLayout.Size = new System.Drawing.Size(1228, 54);
            this.headerLayout.TabIndex = 1;
            // 
            // searchTxt
            // 
            this.searchTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchTxt.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTxt.Location = new System.Drawing.Point(8, 12);
            this.searchTxt.Margin = new System.Windows.Forms.Padding(8, 12, 6, 12);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(286, 28);
            this.searchTxt.TabIndex = 0;
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.DarkBlue;
            this.searchBtn.BackgroundImage = global::OMDb_Livella.Properties.Resources.search;
            this.searchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.ForeColor = System.Drawing.Color.DarkBlue;
            this.searchBtn.Location = new System.Drawing.Point(302, 2);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(2);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(56, 50);
            this.searchBtn.TabIndex = 1;
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // omdbLabel
            // 
            this.omdbLabel.AutoSize = true;
            this.omdbLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.omdbLabel.Font = new System.Drawing.Font("Open Sans", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.omdbLabel.ForeColor = System.Drawing.Color.White;
            this.omdbLabel.Location = new System.Drawing.Point(363, 0);
            this.omdbLabel.Name = "omdbLabel";
            this.omdbLabel.Size = new System.Drawing.Size(862, 54);
            this.omdbLabel.TabIndex = 2;
            this.omdbLabel.Text = "OMDb";
            this.omdbLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // leftLayout
            // 
            this.leftLayout.ColumnCount = 1;
            this.leftLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.leftLayout.Controls.Add(this.movieList, 0, 0);
            this.leftLayout.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.leftLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftLayout.Location = new System.Drawing.Point(3, 63);
            this.leftLayout.Name = "leftLayout";
            this.leftLayout.RowCount = 2;
            this.leftLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.leftLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.leftLayout.Size = new System.Drawing.Size(549, 596);
            this.leftLayout.TabIndex = 3;
            // 
            // movieList
            // 
            this.movieList.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.movieList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.movieList.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.movieList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.movieList.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieList.FullRowSelect = true;
            this.movieList.GridLines = true;
            this.movieList.HideSelection = false;
            this.movieList.LargeImageList = this.movieImageList;
            this.movieList.Location = new System.Drawing.Point(3, 3);
            this.movieList.MultiSelect = false;
            this.movieList.Name = "movieList";
            this.movieList.Size = new System.Drawing.Size(543, 530);
            this.movieList.TabIndex = 2;
            this.movieList.TileSize = new System.Drawing.Size(100, 200);
            this.movieList.UseCompatibleStateImageBehavior = false;
            this.movieList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.movieList_ItemSelectionChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Titolo";
            this.columnHeader1.Width = 230;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Anno";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tipo";
            this.columnHeader3.Width = 80;
            // 
            // movieImageList
            // 
            this.movieImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("movieImageList.ImageStream")));
            this.movieImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.movieImageList.Images.SetKeyName(0, "match.jpg");
            this.movieImageList.Images.SetKeyName(1, "match2.png");
            this.movieImageList.Images.SetKeyName(2, "match3.png");
            this.movieImageList.Images.SetKeyName(3, "match4.png");
            this.movieImageList.Images.SetKeyName(4, "MV5BMTg5NzY0MzA2MV5BMl5BanBnXkFtZTYwNDc3NTc2._V1_SX300.jpg");
            this.movieImageList.Images.SetKeyName(5, "search.png");
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.5F));
            this.tableLayoutPanel1.Controls.Add(this.detailsViewBtn, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.resultsToGet, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tileViewBtn, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 539);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(543, 35);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // detailsViewBtn
            // 
            this.detailsViewBtn.BackColor = System.Drawing.SystemColors.Control;
            this.detailsViewBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailsViewBtn.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailsViewBtn.Location = new System.Drawing.Point(423, 3);
            this.detailsViewBtn.Name = "detailsViewBtn";
            this.detailsViewBtn.Size = new System.Drawing.Size(117, 29);
            this.detailsViewBtn.TabIndex = 3;
            this.detailsViewBtn.Text = "Elenco";
            this.detailsViewBtn.UseVisualStyleBackColor = false;
            this.detailsViewBtn.Click += new System.EventHandler(this.detailsViewBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero risultati";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultsToGet
            // 
            this.resultsToGet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultsToGet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.resultsToGet.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsToGet.FormattingEnabled = true;
            this.resultsToGet.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "100"});
            this.resultsToGet.Location = new System.Drawing.Point(193, 3);
            this.resultsToGet.Name = "resultsToGet";
            this.resultsToGet.Size = new System.Drawing.Size(102, 26);
            this.resultsToGet.TabIndex = 1;
            // 
            // tileViewBtn
            // 
            this.tileViewBtn.BackColor = System.Drawing.SystemColors.Control;
            this.tileViewBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileViewBtn.Enabled = false;
            this.tileViewBtn.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileViewBtn.Location = new System.Drawing.Point(301, 3);
            this.tileViewBtn.Name = "tileViewBtn";
            this.tileViewBtn.Size = new System.Drawing.Size(116, 29);
            this.tileViewBtn.TabIndex = 2;
            this.tileViewBtn.Text = "Griglia";
            this.tileViewBtn.UseVisualStyleBackColor = false;
            this.tileViewBtn.Click += new System.EventHandler(this.tileViewBtn_Click);
            // 
            // rightLayout
            // 
            this.rightLayout.ColumnCount = 3;
            this.rightLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.61905F));
            this.rightLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.19048F));
            this.rightLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.19048F));
            this.rightLayout.Controls.Add(this.statoContentLabel, 2, 3);
            this.rightLayout.Controls.Add(this.regiaContentLabel, 2, 2);
            this.rightLayout.Controls.Add(this.produzioneContentLabel, 2, 1);
            this.rightLayout.Controls.Add(this.titoloContentLabel, 2, 0);
            this.rightLayout.Controls.Add(this.pictureBox, 0, 0);
            this.rightLayout.Controls.Add(this.titoloLabel, 1, 0);
            this.rightLayout.Controls.Add(this.produzioneLabel, 1, 1);
            this.rightLayout.Controls.Add(this.regiaLabel, 1, 2);
            this.rightLayout.Controls.Add(this.statoLabel, 1, 3);
            this.rightLayout.Controls.Add(this.tramaLabel, 1, 10);
            this.rightLayout.Controls.Add(this.durataLabel, 1, 9);
            this.rightLayout.Controls.Add(this.tipoLabel, 1, 8);
            this.rightLayout.Controls.Add(this.dvdLabel, 1, 6);
            this.rightLayout.Controls.Add(this.annoLabel, 1, 5);
            this.rightLayout.Controls.Add(this.annoContentLabel, 2, 5);
            this.rightLayout.Controls.Add(this.dvdContentLabel, 2, 6);
            this.rightLayout.Controls.Add(this.tipoContentLabel, 2, 8);
            this.rightLayout.Controls.Add(this.durataContentLabel, 2, 9);
            this.rightLayout.Controls.Add(this.tramaContentLabel, 1, 11);
            this.rightLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightLayout.Location = new System.Drawing.Point(558, 68);
            this.rightLayout.Margin = new System.Windows.Forms.Padding(3, 8, 3, 12);
            this.rightLayout.Name = "rightLayout";
            this.rightLayout.RowCount = 12;
            this.rightLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rightLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rightLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rightLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rightLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.rightLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rightLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rightLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.rightLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rightLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rightLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rightLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.rightLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.rightLayout.Size = new System.Drawing.Size(673, 582);
            this.rightLayout.TabIndex = 4;
            // 
            // statoContentLabel
            // 
            this.statoContentLabel.AutoSize = true;
            this.statoContentLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statoContentLabel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statoContentLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.statoContentLabel.Location = new System.Drawing.Point(499, 122);
            this.statoContentLabel.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.statoContentLabel.Name = "statoContentLabel";
            this.statoContentLabel.Size = new System.Drawing.Size(171, 22);
            this.statoContentLabel.TabIndex = 13;
            // 
            // regiaContentLabel
            // 
            this.regiaContentLabel.AutoSize = true;
            this.regiaContentLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.regiaContentLabel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regiaContentLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.regiaContentLabel.Location = new System.Drawing.Point(499, 84);
            this.regiaContentLabel.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.regiaContentLabel.Name = "regiaContentLabel";
            this.regiaContentLabel.Size = new System.Drawing.Size(171, 22);
            this.regiaContentLabel.TabIndex = 12;
            // 
            // produzioneContentLabel
            // 
            this.produzioneContentLabel.AutoSize = true;
            this.produzioneContentLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.produzioneContentLabel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produzioneContentLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.produzioneContentLabel.Location = new System.Drawing.Point(499, 46);
            this.produzioneContentLabel.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.produzioneContentLabel.Name = "produzioneContentLabel";
            this.produzioneContentLabel.Size = new System.Drawing.Size(171, 22);
            this.produzioneContentLabel.TabIndex = 11;
            // 
            // titoloContentLabel
            // 
            this.titoloContentLabel.AutoSize = true;
            this.titoloContentLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titoloContentLabel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titoloContentLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.titoloContentLabel.Location = new System.Drawing.Point(499, 8);
            this.titoloContentLabel.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.titoloContentLabel.Name = "titoloContentLabel";
            this.titoloContentLabel.Size = new System.Drawing.Size(171, 22);
            this.titoloContentLabel.TabIndex = 10;
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.ErrorImage = global::OMDb_Livella.Properties.Resources.no_image;
            this.pictureBox.InitialImage = global::OMDb_Livella.Properties.Resources.no_image;
            this.pictureBox.Location = new System.Drawing.Point(3, 3);
            this.pictureBox.Name = "pictureBox";
            this.rightLayout.SetRowSpan(this.pictureBox, 12);
            this.pictureBox.Size = new System.Drawing.Size(314, 576);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // titoloLabel
            // 
            this.titoloLabel.AutoSize = true;
            this.titoloLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titoloLabel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titoloLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.titoloLabel.Location = new System.Drawing.Point(323, 8);
            this.titoloLabel.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.titoloLabel.Name = "titoloLabel";
            this.titoloLabel.Size = new System.Drawing.Size(170, 22);
            this.titoloLabel.TabIndex = 1;
            this.titoloLabel.Text = "Titolo:";
            this.titoloLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // produzioneLabel
            // 
            this.produzioneLabel.AutoSize = true;
            this.produzioneLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.produzioneLabel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produzioneLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.produzioneLabel.Location = new System.Drawing.Point(323, 46);
            this.produzioneLabel.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.produzioneLabel.Name = "produzioneLabel";
            this.produzioneLabel.Size = new System.Drawing.Size(170, 22);
            this.produzioneLabel.TabIndex = 2;
            this.produzioneLabel.Text = "Produzione:";
            this.produzioneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // regiaLabel
            // 
            this.regiaLabel.AutoSize = true;
            this.regiaLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.regiaLabel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regiaLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.regiaLabel.Location = new System.Drawing.Point(323, 84);
            this.regiaLabel.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.regiaLabel.Name = "regiaLabel";
            this.regiaLabel.Size = new System.Drawing.Size(170, 22);
            this.regiaLabel.TabIndex = 3;
            this.regiaLabel.Text = "Regia:";
            this.regiaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statoLabel
            // 
            this.statoLabel.AutoSize = true;
            this.statoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statoLabel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statoLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.statoLabel.Location = new System.Drawing.Point(323, 122);
            this.statoLabel.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.statoLabel.Name = "statoLabel";
            this.statoLabel.Size = new System.Drawing.Size(170, 22);
            this.statoLabel.TabIndex = 4;
            this.statoLabel.Text = "Stato:";
            this.statoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tramaLabel
            // 
            this.tramaLabel.AutoSize = true;
            this.tramaLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tramaLabel.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tramaLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tramaLabel.Location = new System.Drawing.Point(323, 324);
            this.tramaLabel.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.tramaLabel.Name = "tramaLabel";
            this.tramaLabel.Size = new System.Drawing.Size(170, 20);
            this.tramaLabel.TabIndex = 9;
            this.tramaLabel.Text = "Trama:";
            this.tramaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // durataLabel
            // 
            this.durataLabel.AutoSize = true;
            this.durataLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.durataLabel.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durataLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.durataLabel.Location = new System.Drawing.Point(323, 288);
            this.durataLabel.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.durataLabel.Name = "durataLabel";
            this.durataLabel.Size = new System.Drawing.Size(170, 20);
            this.durataLabel.TabIndex = 8;
            this.durataLabel.Text = "Durata:";
            this.durataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tipoLabel
            // 
            this.tipoLabel.AutoSize = true;
            this.tipoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tipoLabel.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tipoLabel.Location = new System.Drawing.Point(323, 252);
            this.tipoLabel.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.tipoLabel.Name = "tipoLabel";
            this.tipoLabel.Size = new System.Drawing.Size(170, 20);
            this.tipoLabel.TabIndex = 7;
            this.tipoLabel.Text = "Tipo:";
            this.tipoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dvdLabel
            // 
            this.dvdLabel.AutoSize = true;
            this.dvdLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvdLabel.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dvdLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dvdLabel.Location = new System.Drawing.Point(323, 206);
            this.dvdLabel.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.dvdLabel.Name = "dvdLabel";
            this.dvdLabel.Size = new System.Drawing.Size(170, 20);
            this.dvdLabel.TabIndex = 6;
            this.dvdLabel.Text = "DVD:";
            this.dvdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // annoLabel
            // 
            this.annoLabel.AutoSize = true;
            this.annoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.annoLabel.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annoLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.annoLabel.Location = new System.Drawing.Point(323, 170);
            this.annoLabel.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.annoLabel.Name = "annoLabel";
            this.annoLabel.Size = new System.Drawing.Size(170, 20);
            this.annoLabel.TabIndex = 5;
            this.annoLabel.Text = "Anno:";
            this.annoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // annoContentLabel
            // 
            this.annoContentLabel.AutoSize = true;
            this.annoContentLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.annoContentLabel.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annoContentLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.annoContentLabel.Location = new System.Drawing.Point(499, 170);
            this.annoContentLabel.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.annoContentLabel.Name = "annoContentLabel";
            this.annoContentLabel.Size = new System.Drawing.Size(171, 20);
            this.annoContentLabel.TabIndex = 14;
            // 
            // dvdContentLabel
            // 
            this.dvdContentLabel.AutoSize = true;
            this.dvdContentLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvdContentLabel.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dvdContentLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.dvdContentLabel.Location = new System.Drawing.Point(499, 206);
            this.dvdContentLabel.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.dvdContentLabel.Name = "dvdContentLabel";
            this.dvdContentLabel.Size = new System.Drawing.Size(171, 20);
            this.dvdContentLabel.TabIndex = 15;
            // 
            // tipoContentLabel
            // 
            this.tipoContentLabel.AutoSize = true;
            this.tipoContentLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tipoContentLabel.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoContentLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.tipoContentLabel.Location = new System.Drawing.Point(499, 252);
            this.tipoContentLabel.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.tipoContentLabel.Name = "tipoContentLabel";
            this.tipoContentLabel.Size = new System.Drawing.Size(171, 20);
            this.tipoContentLabel.TabIndex = 16;
            // 
            // durataContentLabel
            // 
            this.durataContentLabel.AutoSize = true;
            this.durataContentLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.durataContentLabel.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durataContentLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.durataContentLabel.Location = new System.Drawing.Point(499, 288);
            this.durataContentLabel.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.durataContentLabel.Name = "durataContentLabel";
            this.durataContentLabel.Size = new System.Drawing.Size(171, 20);
            this.durataContentLabel.TabIndex = 17;
            // 
            // tramaContentLabel
            // 
            this.tramaContentLabel.AutoSize = true;
            this.rightLayout.SetColumnSpan(this.tramaContentLabel, 2);
            this.tramaContentLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tramaContentLabel.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tramaContentLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.tramaContentLabel.Location = new System.Drawing.Point(323, 352);
            this.tramaContentLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 8);
            this.tramaContentLabel.Name = "tramaContentLabel";
            this.tramaContentLabel.Size = new System.Drawing.Size(347, 222);
            this.tramaContentLabel.TabIndex = 18;
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.DarkBlue;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 640);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1234, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 2;
            // 
            // statusLabel
            // 
            this.statusLabel.Font = new System.Drawing.Font("Open Sans", 9F);
            this.statusLabel.ForeColor = System.Drawing.Color.White;
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(1219, 17);
            this.statusLabel.Spring = true;
            this.statusLabel.Text = "Cristian Livella | 5ID 2019/2020 | ITIS Paleocapa";
            // 
            // Form1
            // 
            this.AcceptButton = this.searchBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 662);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.mainLayout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(850, 600);
            this.Name = "Form1";
            this.Text = "OMDb client";
            this.mainLayout.ResumeLayout(false);
            this.headerLayout.ResumeLayout(false);
            this.headerLayout.PerformLayout();
            this.leftLayout.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.rightLayout.ResumeLayout(false);
            this.rightLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.TableLayoutPanel headerLayout;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label omdbLabel;
        private System.Windows.Forms.ListView movieList;
        private System.Windows.Forms.ImageList movieImageList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.TableLayoutPanel leftLayout;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox resultsToGet;
        private System.Windows.Forms.Button detailsViewBtn;
        private System.Windows.Forms.Button tileViewBtn;
        private System.Windows.Forms.TableLayoutPanel rightLayout;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label titoloLabel;
        private System.Windows.Forms.Label produzioneLabel;
        private System.Windows.Forms.Label regiaLabel;
        private System.Windows.Forms.Label statoLabel;
        private System.Windows.Forms.Label tramaLabel;
        private System.Windows.Forms.Label durataLabel;
        private System.Windows.Forms.Label tipoLabel;
        private System.Windows.Forms.Label dvdLabel;
        private System.Windows.Forms.Label annoLabel;
        private System.Windows.Forms.Label titoloContentLabel;
        private System.Windows.Forms.Label statoContentLabel;
        private System.Windows.Forms.Label regiaContentLabel;
        private System.Windows.Forms.Label produzioneContentLabel;
        private System.Windows.Forms.Label annoContentLabel;
        private System.Windows.Forms.Label dvdContentLabel;
        private System.Windows.Forms.Label tipoContentLabel;
        private System.Windows.Forms.Label durataContentLabel;
        private System.Windows.Forms.Label tramaContentLabel;
    }
}

