namespace NumMetLab2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelBar = new System.Windows.Forms.Panel();
            this.labelInfo = new System.Windows.Forms.Label();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.buttonTestSolve = new System.Windows.Forms.Button();
            this.buttonMainSolve = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panelBarUp = new System.Windows.Forms.Panel();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.panelBarUpBack = new System.Windows.Forms.Panel();
            this.buttonBackUpBar = new System.Windows.Forms.Button();
            this.panelHead = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxDiv = new System.Windows.Forms.TextBox();
            this.labelNumDiv = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelHeadName = new System.Windows.Forms.Panel();
            this.labelHeadName = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelTable = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMiddle = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelGraphSolve = new System.Windows.Forms.Panel();
            this.zedGraphControl2 = new ZedGraph.ZedGraphControl();
            this.panelGraphDif = new System.Windows.Forms.Panel();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.panelGraphBetween = new System.Windows.Forms.Panel();
            this.panelBar.SuspendLayout();
            this.panelBarUp.SuspendLayout();
            this.panelBarUpBack.SuspendLayout();
            this.panelHead.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelHeadName.SuspendLayout();
            this.panelTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelGraphSolve.SuspendLayout();
            this.panelGraphDif.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBar
            // 
            this.panelBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(139)))), ((int)(((byte)(81)))));
            this.panelBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBar.Controls.Add(this.labelInfo);
            this.panelBar.Controls.Add(this.buttonInfo);
            this.panelBar.Controls.Add(this.buttonTestSolve);
            this.panelBar.Controls.Add(this.buttonMainSolve);
            this.panelBar.Controls.Add(this.buttonExit);
            this.panelBar.Controls.Add(this.panelBarUp);
            this.panelBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBar.Location = new System.Drawing.Point(0, 0);
            this.panelBar.Name = "panelBar";
            this.panelBar.Size = new System.Drawing.Size(100, 1061);
            this.panelBar.TabIndex = 0;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.labelInfo.Location = new System.Drawing.Point(0, 566);
            this.labelInfo.MaximumSize = new System.Drawing.Size(300, 0);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(231, 21);
            this.labelInfo.TabIndex = 5;
            this.labelInfo.Text = "Для решения тестовой задачи ";
            this.labelInfo.Visible = false;
            // 
            // buttonInfo
            // 
            this.buttonInfo.BackgroundImage = global::NumMetLab2.Properties.Resources.round_info_button_icon_icons_com_72584;
            this.buttonInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonInfo.FlatAppearance.BorderSize = 0;
            this.buttonInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(48)))), ((int)(((byte)(20)))));
            this.buttonInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfo.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.buttonInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonInfo.Location = new System.Drawing.Point(0, 416);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(98, 150);
            this.buttonInfo.TabIndex = 4;
            this.buttonInfo.UseVisualStyleBackColor = true;
            // 
            // buttonTestSolve
            // 
            this.buttonTestSolve.BackgroundImage = global::NumMetLab2.Properties.Resources._3700408_archive_document_education_exam_file_test_108771;
            this.buttonTestSolve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonTestSolve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTestSolve.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTestSolve.FlatAppearance.BorderSize = 0;
            this.buttonTestSolve.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(48)))), ((int)(((byte)(20)))));
            this.buttonTestSolve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTestSolve.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTestSolve.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.buttonTestSolve.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTestSolve.Location = new System.Drawing.Point(0, 266);
            this.buttonTestSolve.Name = "buttonTestSolve";
            this.buttonTestSolve.Size = new System.Drawing.Size(98, 150);
            this.buttonTestSolve.TabIndex = 3;
            this.buttonTestSolve.Text = "\r\n";
            this.buttonTestSolve.UseVisualStyleBackColor = true;
            this.buttonTestSolve.Click += new System.EventHandler(this.buttonTestSolve_Click);
            // 
            // buttonMainSolve
            // 
            this.buttonMainSolve.BackgroundImage = global::NumMetLab2.Properties.Resources.playwithcircularbuttonwithrightarrowofboldroundedfilledtriangle_80162;
            this.buttonMainSolve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMainSolve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMainSolve.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMainSolve.FlatAppearance.BorderSize = 0;
            this.buttonMainSolve.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(48)))), ((int)(((byte)(20)))));
            this.buttonMainSolve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMainSolve.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMainSolve.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.buttonMainSolve.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMainSolve.Location = new System.Drawing.Point(0, 116);
            this.buttonMainSolve.Name = "buttonMainSolve";
            this.buttonMainSolve.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonMainSolve.Size = new System.Drawing.Size(98, 150);
            this.buttonMainSolve.TabIndex = 2;
            this.buttonMainSolve.UseVisualStyleBackColor = true;
            this.buttonMainSolve.Click += new System.EventHandler(this.buttonMainSolve_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackgroundImage = global::NumMetLab2.Properties.Resources.power_button_off_icon_icons_com_73450;
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(48)))), ((int)(((byte)(20)))));
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(48)))), ((int)(((byte)(20)))));
            this.buttonExit.Location = new System.Drawing.Point(0, 918);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(98, 141);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // panelBarUp
            // 
            this.panelBarUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(139)))), ((int)(((byte)(81)))));
            this.panelBarUp.Controls.Add(this.buttonMenu);
            this.panelBarUp.Controls.Add(this.panelBarUpBack);
            this.panelBarUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.panelBarUp.Location = new System.Drawing.Point(0, 0);
            this.panelBarUp.Name = "panelBarUp";
            this.panelBarUp.Size = new System.Drawing.Size(98, 116);
            this.panelBarUp.TabIndex = 1;
            // 
            // buttonMenu
            // 
            this.buttonMenu.BackgroundImage = global::NumMetLab2.Properties.Resources.menu_button_icon_icons_com_72989;
            this.buttonMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMenu.FlatAppearance.BorderSize = 0;
            this.buttonMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(48)))), ((int)(((byte)(20)))));
            this.buttonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.buttonMenu.Location = new System.Drawing.Point(0, 31);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(98, 61);
            this.buttonMenu.TabIndex = 5;
            this.buttonMenu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // panelBarUpBack
            // 
            this.panelBarUpBack.Controls.Add(this.buttonBackUpBar);
            this.panelBarUpBack.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarUpBack.Location = new System.Drawing.Point(0, 0);
            this.panelBarUpBack.Name = "panelBarUpBack";
            this.panelBarUpBack.Size = new System.Drawing.Size(98, 31);
            this.panelBarUpBack.TabIndex = 2;
            // 
            // buttonBackUpBar
            // 
            this.buttonBackUpBar.BackgroundImage = global::NumMetLab2.Properties.Resources.keyboard_left_arrow_button_icon_icons_com_72692;
            this.buttonBackUpBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBackUpBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBackUpBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonBackUpBar.FlatAppearance.BorderSize = 0;
            this.buttonBackUpBar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(48)))), ((int)(((byte)(20)))));
            this.buttonBackUpBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackUpBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.buttonBackUpBar.Location = new System.Drawing.Point(0, 0);
            this.buttonBackUpBar.Name = "buttonBackUpBar";
            this.buttonBackUpBar.Size = new System.Drawing.Size(98, 31);
            this.buttonBackUpBar.TabIndex = 6;
            this.buttonBackUpBar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonBackUpBar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonBackUpBar.UseVisualStyleBackColor = true;
            this.buttonBackUpBar.Click += new System.EventHandler(this.buttonBackUpBar_Click);
            // 
            // panelHead
            // 
            this.panelHead.Controls.Add(this.panel3);
            this.panelHead.Controls.Add(this.labelNumDiv);
            this.panelHead.Controls.Add(this.panel2);
            this.panelHead.Controls.Add(this.panel1);
            this.panelHead.Controls.Add(this.panelHeadName);
            this.panelHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHead.Location = new System.Drawing.Point(100, 0);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(1820, 93);
            this.panelHead.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBoxDiv);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(229, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(131, 32);
            this.panel3.TabIndex = 6;
            // 
            // textBoxDiv
            // 
            this.textBoxDiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.textBoxDiv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDiv.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBoxDiv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(139)))), ((int)(((byte)(81)))));
            this.textBoxDiv.Location = new System.Drawing.Point(6, 0);
            this.textBoxDiv.Name = "textBoxDiv";
            this.textBoxDiv.Size = new System.Drawing.Size(125, 22);
            this.textBoxDiv.TabIndex = 0;
            this.textBoxDiv.Text = "10000";
            // 
            // labelNumDiv
            // 
            this.labelNumDiv.AutoSize = true;
            this.labelNumDiv.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelNumDiv.Location = new System.Drawing.Point(48, 61);
            this.labelNumDiv.Name = "labelNumDiv";
            this.labelNumDiv.Size = new System.Drawing.Size(181, 21);
            this.labelNumDiv.TabIndex = 5;
            this.labelNumDiv.Text = "Количество разбиений: ";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(48, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1772, 29);
            this.panel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(48, 61);
            this.panel1.TabIndex = 3;
            // 
            // panelHeadName
            // 
            this.panelHeadName.Controls.Add(this.labelHeadName);
            this.panelHeadName.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeadName.Location = new System.Drawing.Point(0, 0);
            this.panelHeadName.Name = "panelHeadName";
            this.panelHeadName.Size = new System.Drawing.Size(1820, 32);
            this.panelHeadName.TabIndex = 2;
            // 
            // labelHeadName
            // 
            this.labelHeadName.AutoSize = true;
            this.labelHeadName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelHeadName.Location = new System.Drawing.Point(0, 11);
            this.labelHeadName.Name = "labelHeadName";
            this.labelHeadName.Size = new System.Drawing.Size(725, 21);
            this.labelHeadName.TabIndex = 0;
            this.labelHeadName.Text = "Стационарное уравнение теплопроводности. Первая краевая задача. Применение метода" +
    " баланса.";
            // 
            // panelBottom
            // 
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(100, 1017);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1820, 44);
            this.panelBottom.TabIndex = 3;
            // 
            // panelLeft
            // 
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(100, 93);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(48, 924);
            this.panelLeft.TabIndex = 4;
            // 
            // panelTable
            // 
            this.panelTable.Controls.Add(this.dataGridView1);
            this.panelTable.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTable.Location = new System.Drawing.Point(148, 93);
            this.panelTable.Name = "panelTable";
            this.panelTable.Size = new System.Drawing.Size(548, 924);
            this.panelTable.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(548, 924);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "№узла";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "xi";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "u(xi)";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "v(xi)";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "u(xi) - v(xi)";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // panelMiddle
            // 
            this.panelMiddle.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMiddle.Location = new System.Drawing.Point(696, 93);
            this.panelMiddle.Name = "panelMiddle";
            this.panelMiddle.Size = new System.Drawing.Size(42, 924);
            this.panelMiddle.TabIndex = 6;
            // 
            // panelRight
            // 
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(1820, 93);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(100, 924);
            this.panelRight.TabIndex = 7;
            // 
            // panelGraphSolve
            // 
            this.panelGraphSolve.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelGraphSolve.Controls.Add(this.zedGraphControl2);
            this.panelGraphSolve.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGraphSolve.Location = new System.Drawing.Point(738, 93);
            this.panelGraphSolve.Name = "panelGraphSolve";
            this.panelGraphSolve.Size = new System.Drawing.Size(1082, 415);
            this.panelGraphSolve.TabIndex = 8;
            // 
            // zedGraphControl2
            // 
            this.zedGraphControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphControl2.IsShowPointValues = false;
            this.zedGraphControl2.Location = new System.Drawing.Point(0, 0);
            this.zedGraphControl2.Name = "zedGraphControl2";
            this.zedGraphControl2.PointValueFormat = "G";
            this.zedGraphControl2.Size = new System.Drawing.Size(1082, 415);
            this.zedGraphControl2.TabIndex = 0;
            // 
            // panelGraphDif
            // 
            this.panelGraphDif.Controls.Add(this.zedGraphControl1);
            this.panelGraphDif.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelGraphDif.Location = new System.Drawing.Point(738, 597);
            this.panelGraphDif.Name = "panelGraphDif";
            this.panelGraphDif.Size = new System.Drawing.Size(1082, 420);
            this.panelGraphDif.TabIndex = 9;
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphControl1.IsShowPointValues = false;
            this.zedGraphControl1.Location = new System.Drawing.Point(0, 0);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.PointValueFormat = "G";
            this.zedGraphControl1.Size = new System.Drawing.Size(1082, 420);
            this.zedGraphControl1.TabIndex = 0;
            // 
            // panelGraphBetween
            // 
            this.panelGraphBetween.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGraphBetween.Location = new System.Drawing.Point(738, 508);
            this.panelGraphBetween.Name = "panelGraphBetween";
            this.panelGraphBetween.Size = new System.Drawing.Size(1082, 89);
            this.panelGraphBetween.TabIndex = 10;
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1920, 1061);
            this.Controls.Add(this.panelGraphBetween);
            this.Controls.Add(this.panelGraphDif);
            this.Controls.Add(this.panelGraphSolve);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelMiddle);
            this.Controls.Add(this.panelTable);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelHead);
            this.Controls.Add(this.panelBar);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(139)))), ((int)(((byte)(81)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelBar.ResumeLayout(false);
            this.panelBar.PerformLayout();
            this.panelBarUp.ResumeLayout(false);
            this.panelBarUpBack.ResumeLayout(false);
            this.panelHead.ResumeLayout(false);
            this.panelHead.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelHeadName.ResumeLayout(false);
            this.panelHeadName.PerformLayout();
            this.panelTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelGraphSolve.ResumeLayout(false);
            this.panelGraphDif.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBar;
        private System.Windows.Forms.Panel panelBarUp;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Button buttonTestSolve;
        private System.Windows.Forms.Button buttonMainSolve;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Panel panelBarUpBack;
        private System.Windows.Forms.Button buttonBackUpBar;
        private System.Windows.Forms.Panel panelHead;
        private System.Windows.Forms.Panel panelHeadName;
        private System.Windows.Forms.Label labelHeadName;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelTable;
        private System.Windows.Forms.Panel panelMiddle;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelGraphSolve;
        private ZedGraph.ZedGraphControl zedGraphControl2;
        private System.Windows.Forms.Panel panelGraphDif;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Panel panelGraphBetween;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxDiv;
        private System.Windows.Forms.Label labelNumDiv;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelInfo;
    }
}

