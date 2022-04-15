namespace _8_PuzzleSolver
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.algoTypesMenu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tile3 = new System.Windows.Forms.Label();
            this.tile4 = new System.Windows.Forms.Label();
            this.tile2 = new System.Windows.Forms.Label();
            this.tile1 = new System.Windows.Forms.Label();
            this.tile6 = new System.Windows.Forms.Label();
            this.tile0 = new System.Windows.Forms.Label();
            this.tile7 = new System.Windows.Forms.Label();
            this.tile5 = new System.Windows.Forms.Label();
            this.tile8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.generateButton = new System.Windows.Forms.Button();
            this.typeLabel = new System.Windows.Forms.Label();
            this.solveButton = new System.Windows.Forms.Button();
            this.backMainScreen = new System.Windows.Forms.Button();
            this.nextActionButton = new System.Windows.Forms.Button();
            this.nextActionLabel = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.stepsCount = new System.Windows.Forms.Label();
            this.stepsLabel = new System.Windows.Forms.Label();
            this.enterManulButton = new System.Windows.Forms.Button();
            this.manualValueText = new System.Windows.Forms.TextBox();
            this.exLabel = new System.Windows.Forms.Label();
            this.warningLabel = new System.Windows.Forms.Label();
            this.stopButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.expNodesInfo = new System.Windows.Forms.Label();
            this.currentFringeInfo = new System.Windows.Forms.Label();
            this.solvingInfo = new System.Windows.Forms.Label();
            this.maxSizeFringeLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.resultWarnLabel = new System.Windows.Forms.Label();
            this.depthLimVal = new System.Windows.Forms.TextBox();
            this.deptlimitlabel = new System.Windows.Forms.Label();
            this.depthlimitinfo = new System.Windows.Forms.Label();
            this.mainPanel1 = new System.Windows.Forms.Panel();
            this.mainPanel2 = new System.Windows.Forms.Panel();
            this.calcPanel = new System.Windows.Forms.Panel();
            this.expNodesResult = new System.Windows.Forms.Label();
            this.resultsPanel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.mainPanel1.SuspendLayout();
            this.mainPanel2.SuspendLayout();
            this.calcPanel.SuspendLayout();
            this.resultsPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // algoTypesMenu
            // 
            this.algoTypesMenu.CausesValidation = false;
            this.algoTypesMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.algoTypesMenu.FormattingEnabled = true;
            this.algoTypesMenu.Items.AddRange(new object[] {
            "Breadth-First",
            "Depth-First",
            "Depth Limited",
            "Iterative deepening search"});
            this.algoTypesMenu.Location = new System.Drawing.Point(60, 74);
            this.algoTypesMenu.Name = "algoTypesMenu";
            this.algoTypesMenu.Size = new System.Drawing.Size(134, 21);
            this.algoTypesMenu.TabIndex = 7;
            this.algoTypesMenu.SelectedIndexChanged += new System.EventHandler(this.algoTypesMenu_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(73, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Generated Puzzle";
            // 
            // tile3
            // 
            this.tile3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tile3.BackColor = System.Drawing.Color.White;
            this.tile3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tile3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tile3.Location = new System.Drawing.Point(15, 67);
            this.tile3.Margin = new System.Windows.Forms.Padding(0);
            this.tile3.Name = "tile3";
            this.tile3.Size = new System.Drawing.Size(38, 40);
            this.tile3.TabIndex = 22;
            this.tile3.Text = "1";
            // 
            // tile4
            // 
            this.tile4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tile4.BackColor = System.Drawing.Color.White;
            this.tile4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tile4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tile4.Location = new System.Drawing.Point(61, 67);
            this.tile4.Margin = new System.Windows.Forms.Padding(0);
            this.tile4.Name = "tile4";
            this.tile4.Size = new System.Drawing.Size(38, 40);
            this.tile4.TabIndex = 23;
            this.tile4.Text = "1";
            // 
            // tile2
            // 
            this.tile2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tile2.BackColor = System.Drawing.Color.White;
            this.tile2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tile2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tile2.Location = new System.Drawing.Point(106, 18);
            this.tile2.Margin = new System.Windows.Forms.Padding(0);
            this.tile2.Name = "tile2";
            this.tile2.Size = new System.Drawing.Size(38, 40);
            this.tile2.TabIndex = 21;
            this.tile2.Text = "1";
            // 
            // tile1
            // 
            this.tile1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tile1.BackColor = System.Drawing.Color.White;
            this.tile1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tile1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tile1.Location = new System.Drawing.Point(61, 18);
            this.tile1.Margin = new System.Windows.Forms.Padding(0);
            this.tile1.Name = "tile1";
            this.tile1.Size = new System.Drawing.Size(38, 40);
            this.tile1.TabIndex = 20;
            this.tile1.Text = "1";
            // 
            // tile6
            // 
            this.tile6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tile6.BackColor = System.Drawing.Color.White;
            this.tile6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tile6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tile6.Location = new System.Drawing.Point(15, 114);
            this.tile6.Margin = new System.Windows.Forms.Padding(0);
            this.tile6.Name = "tile6";
            this.tile6.Size = new System.Drawing.Size(38, 40);
            this.tile6.TabIndex = 25;
            this.tile6.Text = "1";
            // 
            // tile0
            // 
            this.tile0.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tile0.BackColor = System.Drawing.Color.White;
            this.tile0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tile0.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tile0.Location = new System.Drawing.Point(15, 18);
            this.tile0.Margin = new System.Windows.Forms.Padding(0);
            this.tile0.Name = "tile0";
            this.tile0.Size = new System.Drawing.Size(38, 40);
            this.tile0.TabIndex = 10;
            this.tile0.Text = "1";
            // 
            // tile7
            // 
            this.tile7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tile7.BackColor = System.Drawing.Color.White;
            this.tile7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tile7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tile7.Location = new System.Drawing.Point(61, 114);
            this.tile7.Margin = new System.Windows.Forms.Padding(0);
            this.tile7.Name = "tile7";
            this.tile7.Size = new System.Drawing.Size(38, 40);
            this.tile7.TabIndex = 26;
            this.tile7.Text = "1";
            // 
            // tile5
            // 
            this.tile5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tile5.BackColor = System.Drawing.Color.White;
            this.tile5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tile5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tile5.Location = new System.Drawing.Point(106, 67);
            this.tile5.Margin = new System.Windows.Forms.Padding(0);
            this.tile5.Name = "tile5";
            this.tile5.Size = new System.Drawing.Size(38, 40);
            this.tile5.TabIndex = 24;
            this.tile5.Text = "1";
            // 
            // tile8
            // 
            this.tile8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tile8.BackColor = System.Drawing.Color.White;
            this.tile8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tile8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tile8.Location = new System.Drawing.Point(106, 114);
            this.tile8.Margin = new System.Windows.Forms.Padding(0);
            this.tile8.Name = "tile8";
            this.tile8.Size = new System.Drawing.Size(38, 40);
            this.tile8.TabIndex = 27;
            this.tile8.Text = "1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tile8);
            this.panel1.Controls.Add(this.tile5);
            this.panel1.Controls.Add(this.tile6);
            this.panel1.Controls.Add(this.tile0);
            this.panel1.Controls.Add(this.tile3);
            this.panel1.Controls.Add(this.tile1);
            this.panel1.Controls.Add(this.tile7);
            this.panel1.Controls.Add(this.tile2);
            this.panel1.Controls.Add(this.tile4);
            this.panel1.Location = new System.Drawing.Point(89, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(161, 172);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(73, 30);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(161, 43);
            this.generateButton.TabIndex = 9;
            this.generateButton.Text = "Generate Random Puzzle";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.typeLabel.Location = new System.Drawing.Point(58, 37);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(138, 24);
            this.typeLabel.TabIndex = 10;
            this.typeLabel.Text = "Algortihm Type";
            // 
            // solveButton
            // 
            this.solveButton.Location = new System.Drawing.Point(48, 127);
            this.solveButton.Name = "solveButton";
            this.solveButton.Size = new System.Drawing.Size(161, 43);
            this.solveButton.TabIndex = 11;
            this.solveButton.Text = "Solve";
            this.solveButton.UseVisualStyleBackColor = true;
            this.solveButton.Click += new System.EventHandler(this.solveButton_Click);
            // 
            // backMainScreen
            // 
            this.backMainScreen.Location = new System.Drawing.Point(89, 360);
            this.backMainScreen.Name = "backMainScreen";
            this.backMainScreen.Size = new System.Drawing.Size(161, 43);
            this.backMainScreen.TabIndex = 12;
            this.backMainScreen.Text = "Back To Main Screen";
            this.backMainScreen.UseVisualStyleBackColor = true;
            this.backMainScreen.Click += new System.EventHandler(this.backMainScreen_Click);
            // 
            // nextActionButton
            // 
            this.nextActionButton.Location = new System.Drawing.Point(73, 152);
            this.nextActionButton.Name = "nextActionButton";
            this.nextActionButton.Size = new System.Drawing.Size(161, 28);
            this.nextActionButton.TabIndex = 13;
            this.nextActionButton.Text = "Next Action";
            this.nextActionButton.UseVisualStyleBackColor = true;
            this.nextActionButton.Click += new System.EventHandler(this.nextActionButton_Click);
            // 
            // nextActionLabel
            // 
            this.nextActionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nextActionLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.nextActionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nextActionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nextActionLabel.Location = new System.Drawing.Point(51, 203);
            this.nextActionLabel.Name = "nextActionLabel";
            this.nextActionLabel.Size = new System.Drawing.Size(204, 27);
            this.nextActionLabel.TabIndex = 14;
            this.nextActionLabel.Text = "action";
            this.nextActionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nextActionLabel.Click += new System.EventHandler(this.nextActionLabel_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.infoLabel.Location = new System.Drawing.Point(70, 46);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(168, 24);
            this.infoLabel.TabIndex = 16;
            this.infoLabel.Text = "Results Information";
            // 
            // stepsCount
            // 
            this.stepsCount.AutoSize = true;
            this.stepsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stepsCount.Location = new System.Drawing.Point(160, 245);
            this.stepsCount.Name = "stepsCount";
            this.stepsCount.Size = new System.Drawing.Size(37, 16);
            this.stepsCount.TabIndex = 17;
            this.stepsCount.Text = "0/10";
            this.stepsCount.Click += new System.EventHandler(this.stepsCount_Click);
            // 
            // stepsLabel
            // 
            this.stepsLabel.AutoSize = true;
            this.stepsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stepsLabel.Location = new System.Drawing.Point(105, 245);
            this.stepsLabel.Name = "stepsLabel";
            this.stepsLabel.Size = new System.Drawing.Size(48, 16);
            this.stepsLabel.TabIndex = 18;
            this.stepsLabel.Text = "Steps";
            this.stepsLabel.Click += new System.EventHandler(this.stepsLabel_Click);
            // 
            // enterManulButton
            // 
            this.enterManulButton.Location = new System.Drawing.Point(73, 79);
            this.enterManulButton.Name = "enterManulButton";
            this.enterManulButton.Size = new System.Drawing.Size(161, 43);
            this.enterManulButton.TabIndex = 19;
            this.enterManulButton.Text = "Enter Values Manually";
            this.enterManulButton.UseVisualStyleBackColor = true;
            this.enterManulButton.Click += new System.EventHandler(this.enterManulButton_Click);
            // 
            // manualValueText
            // 
            this.manualValueText.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.manualValueText.Location = new System.Drawing.Point(73, 128);
            this.manualValueText.MaxLength = 9;
            this.manualValueText.Name = "manualValueText";
            this.manualValueText.Size = new System.Drawing.Size(161, 20);
            this.manualValueText.TabIndex = 20;
            this.manualValueText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // exLabel
            // 
            this.exLabel.AutoSize = true;
            this.exLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.exLabel.Location = new System.Drawing.Point(109, 151);
            this.exLabel.Name = "exLabel";
            this.exLabel.Size = new System.Drawing.Size(85, 13);
            this.exLabel.TabIndex = 21;
            this.exLabel.Text = "(Ex: 142375608)";
            this.exLabel.Click += new System.EventHandler(this.exLabel_Click);
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.warningLabel.ForeColor = System.Drawing.Color.Red;
            this.warningLabel.Location = new System.Drawing.Point(53, 174);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(204, 13);
            this.warningLabel.TabIndex = 22;
            this.warningLabel.Text = "Values are not solvable enter another one";
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(37, 109);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(161, 43);
            this.stopButton.TabIndex = 23;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // expNodesInfo
            // 
            this.expNodesInfo.AutoSize = true;
            this.expNodesInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.expNodesInfo.Location = new System.Drawing.Point(55, 58);
            this.expNodesInfo.Name = "expNodesInfo";
            this.expNodesInfo.Size = new System.Drawing.Size(107, 13);
            this.expNodesInfo.TabIndex = 24;
            this.expNodesInfo.Text = "Expanded Nodes = 0";
            this.expNodesInfo.Click += new System.EventHandler(this.expNodesInfo_Click);
            // 
            // currentFringeInfo
            // 
            this.currentFringeInfo.AutoSize = true;
            this.currentFringeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.currentFringeInfo.Location = new System.Drawing.Point(54, 80);
            this.currentFringeInfo.Name = "currentFringeInfo";
            this.currentFringeInfo.Size = new System.Drawing.Size(122, 13);
            this.currentFringeInfo.TabIndex = 25;
            this.currentFringeInfo.Text = "Current Fringe Count = 0";
            // 
            // solvingInfo
            // 
            this.solvingInfo.AutoSize = true;
            this.solvingInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.solvingInfo.Location = new System.Drawing.Point(54, 23);
            this.solvingInfo.Name = "solvingInfo";
            this.solvingInfo.Size = new System.Drawing.Size(102, 24);
            this.solvingInfo.TabIndex = 26;
            this.solvingInfo.Text = "Information";
            // 
            // maxSizeFringeLabel
            // 
            this.maxSizeFringeLabel.AutoSize = true;
            this.maxSizeFringeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maxSizeFringeLabel.Location = new System.Drawing.Point(86, 93);
            this.maxSizeFringeLabel.Name = "maxSizeFringeLabel";
            this.maxSizeFringeLabel.Size = new System.Drawing.Size(136, 13);
            this.maxSizeFringeLabel.TabIndex = 28;
            this.maxSizeFringeLabel.Text = "Maximum Size of Fringe = 0";
            this.maxSizeFringeLabel.Click += new System.EventHandler(this.maxSizeFringeLabel_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.timeLabel.Location = new System.Drawing.Point(86, 106);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(68, 13);
            this.timeLabel.TabIndex = 29;
            this.timeLabel.Text = "Time = 0 sec";
            // 
            // resultWarnLabel
            // 
            this.resultWarnLabel.AutoSize = true;
            this.resultWarnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.resultWarnLabel.ForeColor = System.Drawing.Color.Red;
            this.resultWarnLabel.Location = new System.Drawing.Point(100, 136);
            this.resultWarnLabel.Name = "resultWarnLabel";
            this.resultWarnLabel.Size = new System.Drawing.Size(100, 13);
            this.resultWarnLabel.TabIndex = 30;
            this.resultWarnLabel.Text = "Could not find result";
            // 
            // depthLimVal
            // 
            this.depthLimVal.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.depthLimVal.Location = new System.Drawing.Point(118, 101);
            this.depthLimVal.MaxLength = 9;
            this.depthLimVal.Name = "depthLimVal";
            this.depthLimVal.Size = new System.Drawing.Size(32, 20);
            this.depthLimVal.TabIndex = 31;
            // 
            // deptlimitlabel
            // 
            this.deptlimitlabel.AutoSize = true;
            this.deptlimitlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deptlimitlabel.Location = new System.Drawing.Point(49, 104);
            this.deptlimitlabel.Name = "deptlimitlabel";
            this.deptlimitlabel.Size = new System.Drawing.Size(63, 13);
            this.deptlimitlabel.TabIndex = 32;
            this.deptlimitlabel.Text = "Depth Limit ";
            // 
            // depthlimitinfo
            // 
            this.depthlimitinfo.AutoSize = true;
            this.depthlimitinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.depthlimitinfo.Location = new System.Drawing.Point(156, 104);
            this.depthlimitinfo.Name = "depthlimitinfo";
            this.depthlimitinfo.Size = new System.Drawing.Size(60, 12);
            this.depthlimitinfo.TabIndex = 33;
            this.depthlimitinfo.Text = "(Default = 10)";
            this.depthlimitinfo.Click += new System.EventHandler(this.depthlimitinfo_Click);
            // 
            // mainPanel1
            // 
            this.mainPanel1.Controls.Add(this.generateButton);
            this.mainPanel1.Controls.Add(this.enterManulButton);
            this.mainPanel1.Controls.Add(this.manualValueText);
            this.mainPanel1.Controls.Add(this.exLabel);
            this.mainPanel1.Controls.Add(this.warningLabel);
            this.mainPanel1.Location = new System.Drawing.Point(13, 286);
            this.mainPanel1.Name = "mainPanel1";
            this.mainPanel1.Size = new System.Drawing.Size(296, 248);
            this.mainPanel1.TabIndex = 18;
            this.mainPanel1.Visible = false;
            // 
            // mainPanel2
            // 
            this.mainPanel2.Controls.Add(this.deptlimitlabel);
            this.mainPanel2.Controls.Add(this.solveButton);
            this.mainPanel2.Controls.Add(this.algoTypesMenu);
            this.mainPanel2.Controls.Add(this.typeLabel);
            this.mainPanel2.Controls.Add(this.depthLimVal);
            this.mainPanel2.Controls.Add(this.depthlimitinfo);
            this.mainPanel2.Location = new System.Drawing.Point(390, 100);
            this.mainPanel2.Name = "mainPanel2";
            this.mainPanel2.Size = new System.Drawing.Size(247, 228);
            this.mainPanel2.TabIndex = 34;
            // 
            // calcPanel
            // 
            this.calcPanel.Controls.Add(this.stopButton);
            this.calcPanel.Controls.Add(this.solvingInfo);
            this.calcPanel.Controls.Add(this.expNodesInfo);
            this.calcPanel.Controls.Add(this.currentFringeInfo);
            this.calcPanel.Location = new System.Drawing.Point(400, 86);
            this.calcPanel.Name = "calcPanel";
            this.calcPanel.Size = new System.Drawing.Size(229, 173);
            this.calcPanel.TabIndex = 35;
            // 
            // expNodesResult
            // 
            this.expNodesResult.AutoSize = true;
            this.expNodesResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.expNodesResult.Location = new System.Drawing.Point(86, 81);
            this.expNodesResult.Name = "expNodesResult";
            this.expNodesResult.Size = new System.Drawing.Size(107, 13);
            this.expNodesResult.TabIndex = 27;
            this.expNodesResult.Text = "Expanded Nodes = 0";
            // 
            // resultsPanel2
            // 
            this.resultsPanel2.Controls.Add(this.stepsLabel);
            this.resultsPanel2.Controls.Add(this.stepsCount);
            this.resultsPanel2.Controls.Add(this.nextActionLabel);
            this.resultsPanel2.Controls.Add(this.resultWarnLabel);
            this.resultsPanel2.Controls.Add(this.nextActionButton);
            this.resultsPanel2.Controls.Add(this.expNodesResult);
            this.resultsPanel2.Controls.Add(this.maxSizeFringeLabel);
            this.resultsPanel2.Controls.Add(this.infoLabel);
            this.resultsPanel2.Controls.Add(this.timeLabel);
            this.resultsPanel2.Location = new System.Drawing.Point(364, 86);
            this.resultsPanel2.Name = "resultsPanel2";
            this.resultsPanel2.Size = new System.Drawing.Size(301, 317);
            this.resultsPanel2.TabIndex = 36;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 478);
            this.Controls.Add(this.mainPanel1);
            this.Controls.Add(this.backMainScreen);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainPanel2);
            this.Controls.Add(this.resultsPanel2);
            this.Controls.Add(this.calcPanel);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "8-PuzzleSolver";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.mainPanel1.ResumeLayout(false);
            this.mainPanel1.PerformLayout();
            this.mainPanel2.ResumeLayout(false);
            this.mainPanel2.PerformLayout();
            this.calcPanel.ResumeLayout(false);
            this.calcPanel.PerformLayout();
            this.resultsPanel2.ResumeLayout(false);
            this.resultsPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tile3;
        private System.Windows.Forms.Label tile4;
        private System.Windows.Forms.Label tile2;
        private System.Windows.Forms.Label tile1;
        private System.Windows.Forms.Label tile6;
        private System.Windows.Forms.Label tile0;
        private System.Windows.Forms.Label tile7;
        private System.Windows.Forms.Label tile5;
        private System.Windows.Forms.Label tile8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Button solveButton;
        private System.Windows.Forms.Button backMainScreen;
        private System.Windows.Forms.Button nextActionButton;
        private System.Windows.Forms.Label nextActionLabel;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.ComboBox algoTypesMenu;
        private System.Windows.Forms.Label stepsCount;
        private System.Windows.Forms.Label stepsLabel;
        private System.Windows.Forms.Button enterManulButton;
        private System.Windows.Forms.TextBox manualValueText;
        private System.Windows.Forms.Label exLabel;
        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.Button stopButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label expNodesInfo;
        private System.Windows.Forms.Label currentFringeInfo;
        private System.Windows.Forms.Label solvingInfo;
        private System.Windows.Forms.Label maxSizeFringeLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label resultWarnLabel;
        private System.Windows.Forms.TextBox depthLimVal;
        private System.Windows.Forms.Label deptlimitlabel;
        private System.Windows.Forms.Label depthlimitinfo;
        private System.Windows.Forms.Panel mainPanel1;
        private System.Windows.Forms.Panel mainPanel2;
        private System.Windows.Forms.Panel calcPanel;
        private System.Windows.Forms.Label expNodesResult;
        private System.Windows.Forms.Panel resultsPanel2;
    }
}

