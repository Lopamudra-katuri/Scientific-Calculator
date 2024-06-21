namespace calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnBS = new Button();
            txtResult = new TextBox();
            btnClearEntry = new Button();
            btnClear = new Button();
            btnPM = new Button();
            btnAdd = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btnSub = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btnMul = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btnDiv = new Button();
            btnEql = new Button();
            btnDot = new Button();
            btn0 = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            standardToolStripMenuItem = new ToolStripMenuItem();
            scientificToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            btnPer = new Button();
            btnOct = new Button();
            btnMod = new Button();
            btnExp = new Button();
            btnLn = new Button();
            btnHex = new Button();
            btnTan = new Button();
            btnTanh = new Button();
            btnInv = new Button();
            btnBin = new Button();
            btnCos = new Button();
            btnCosh = new Button();
            btnCube = new Button();
            btnDec = new Button();
            btnSin = new Button();
            btnSinh = new Button();
            btnSqr = new Button();
            btnSqrt = new Button();
            btnLog = new Button();
            btnPi = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnBS
            // 
            btnBS.Font = new Font("Wingdings", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnBS.Location = new Point(41, 165);
            btnBS.Margin = new Padding(4);
            btnBS.Name = "btnBS";
            btnBS.Size = new Size(112, 111);
            btnBS.TabIndex = 0;
            btnBS.Text = "";
            btnBS.UseVisualStyleBackColor = true;
            btnBS.Click += btnBS_Click;
            // 
            // txtResult
            // 
            txtResult.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtResult.Location = new Point(41, 78);
            txtResult.Margin = new Padding(4);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(462, 50);
            txtResult.TabIndex = 1;
            txtResult.Text = "0";
            txtResult.TextAlign = HorizontalAlignment.Right;
            // 
            // btnClearEntry
            // 
            btnClearEntry.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnClearEntry.Location = new Point(161, 169);
            btnClearEntry.Margin = new Padding(4);
            btnClearEntry.Name = "btnClearEntry";
            btnClearEntry.Size = new Size(112, 111);
            btnClearEntry.TabIndex = 2;
            btnClearEntry.Text = "CE";
            btnClearEntry.UseVisualStyleBackColor = true;
            btnClearEntry.Click += btnClearEntry_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.Location = new Point(277, 165);
            btnClear.Margin = new Padding(4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 111);
            btnClear.TabIndex = 3;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnPM
            // 
            btnPM.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnPM.Location = new Point(402, 165);
            btnPM.Margin = new Padding(4);
            btnPM.Name = "btnPM";
            btnPM.Size = new Size(111, 111);
            btnPM.TabIndex = 4;
            btnPM.Text = "±";
            btnPM.UseVisualStyleBackColor = true;
            btnPM.Click += btnPM_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(398, 284);
            btnAdd.Margin = new Padding(4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(111, 111);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += numberOp;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btn9.Location = new Point(277, 284);
            btn9.Margin = new Padding(4);
            btn9.Name = "btn9";
            btn9.Size = new Size(112, 111);
            btn9.TabIndex = 7;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += EnterNumbers;
            // 
            // btn8
            // 
            btn8.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btn8.Location = new Point(157, 284);
            btn8.Margin = new Padding(4);
            btn8.Name = "btn8";
            btn8.Size = new Size(112, 111);
            btn8.TabIndex = 6;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += EnterNumbers;
            // 
            // btn7
            // 
            btn7.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btn7.Location = new Point(36, 284);
            btn7.Margin = new Padding(4);
            btn7.Name = "btn7";
            btn7.Size = new Size(112, 111);
            btn7.TabIndex = 5;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += EnterNumbers;
            // 
            // btnSub
            // 
            btnSub.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnSub.Location = new Point(402, 403);
            btnSub.Margin = new Padding(4);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(111, 111);
            btnSub.TabIndex = 12;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += numberOp;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btn6.Location = new Point(277, 403);
            btn6.Margin = new Padding(4);
            btn6.Name = "btn6";
            btn6.Size = new Size(112, 111);
            btn6.TabIndex = 11;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += EnterNumbers;
            // 
            // btn5
            // 
            btn5.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btn5.Location = new Point(161, 403);
            btn5.Margin = new Padding(4);
            btn5.Name = "btn5";
            btn5.Size = new Size(112, 111);
            btn5.TabIndex = 10;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += EnterNumbers;
            // 
            // btn4
            // 
            btn4.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btn4.Location = new Point(36, 403);
            btn4.Margin = new Padding(4);
            btn4.Name = "btn4";
            btn4.Size = new Size(112, 111);
            btn4.TabIndex = 9;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += EnterNumbers;
            // 
            // btnMul
            // 
            btnMul.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnMul.Location = new Point(406, 522);
            btnMul.Margin = new Padding(4);
            btnMul.Name = "btnMul";
            btnMul.Size = new Size(111, 111);
            btnMul.TabIndex = 16;
            btnMul.Text = "*";
            btnMul.UseVisualStyleBackColor = true;
            btnMul.Click += numberOp;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btn3.Location = new Point(281, 522);
            btn3.Margin = new Padding(4);
            btn3.Name = "btn3";
            btn3.Size = new Size(112, 111);
            btn3.TabIndex = 15;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += EnterNumbers;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btn2.Location = new Point(165, 522);
            btn2.Margin = new Padding(4);
            btn2.Name = "btn2";
            btn2.Size = new Size(112, 111);
            btn2.TabIndex = 14;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += EnterNumbers;
            // 
            // btn1
            // 
            btn1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btn1.Location = new Point(45, 522);
            btn1.Margin = new Padding(4);
            btn1.Name = "btn1";
            btn1.Size = new Size(112, 111);
            btn1.TabIndex = 13;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += EnterNumbers;
            // 
            // btnDiv
            // 
            btnDiv.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnDiv.Location = new Point(402, 641);
            btnDiv.Margin = new Padding(4);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(111, 111);
            btnDiv.TabIndex = 20;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += numberOp;
            // 
            // btnEql
            // 
            btnEql.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnEql.Location = new Point(277, 641);
            btnEql.Margin = new Padding(4);
            btnEql.Name = "btnEql";
            btnEql.Size = new Size(112, 111);
            btnEql.TabIndex = 19;
            btnEql.Text = "=";
            btnEql.UseVisualStyleBackColor = true;
            btnEql.Click += btnEql_Click;
            // 
            // btnDot
            // 
            btnDot.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnDot.Location = new Point(161, 641);
            btnDot.Margin = new Padding(4);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(112, 111);
            btnDot.TabIndex = 18;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += EnterNumbers;
            // 
            // btn0
            // 
            btn0.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btn0.Location = new Point(41, 641);
            btn0.Margin = new Padding(4);
            btn0.Name = "btn0";
            btn0.Size = new Size(112, 111);
            btn0.TabIndex = 17;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += EnterNumbers;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 3, 0, 3);
            menuStrip1.Size = new Size(1694, 35);
            menuStrip1.TabIndex = 21;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { standardToolStripMenuItem, scientificToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // standardToolStripMenuItem
            // 
            standardToolStripMenuItem.Name = "standardToolStripMenuItem";
            standardToolStripMenuItem.Size = new Size(185, 34);
            standardToolStripMenuItem.Text = "Standard";
            standardToolStripMenuItem.Click += standardToolStripMenuItem_Click;
            // 
            // scientificToolStripMenuItem
            // 
            scientificToolStripMenuItem.Name = "scientificToolStripMenuItem";
            scientificToolStripMenuItem.Size = new Size(185, 34);
            scientificToolStripMenuItem.Text = "Scientific";
            scientificToolStripMenuItem.Click += scientificToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(185, 34);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // btnPer
            // 
            btnPer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPer.Location = new Point(886, 641);
            btnPer.Margin = new Padding(4);
            btnPer.Name = "btnPer";
            btnPer.Size = new Size(111, 111);
            btnPer.TabIndex = 41;
            btnPer.Text = "%";
            btnPer.UseVisualStyleBackColor = true;
            btnPer.Click += btnPer_Click;
            // 
            // btnOct
            // 
            btnOct.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnOct.Location = new Point(762, 641);
            btnOct.Margin = new Padding(4);
            btnOct.Name = "btnOct";
            btnOct.Size = new Size(112, 111);
            btnOct.TabIndex = 40;
            btnOct.Text = "Oct";
            btnOct.UseVisualStyleBackColor = true;
            btnOct.Click += btnOct_Click;
            // 
            // btnMod
            // 
            btnMod.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnMod.Location = new Point(645, 641);
            btnMod.Margin = new Padding(4);
            btnMod.Name = "btnMod";
            btnMod.Size = new Size(112, 111);
            btnMod.TabIndex = 39;
            btnMod.Text = "Mod";
            btnMod.UseVisualStyleBackColor = true;
            btnMod.Click += numberOp;
            // 
            // btnExp
            // 
            btnExp.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnExp.Location = new Point(525, 641);
            btnExp.Margin = new Padding(4);
            btnExp.Name = "btnExp";
            btnExp.Size = new Size(112, 111);
            btnExp.TabIndex = 38;
            btnExp.Text = "Exp";
            btnExp.UseVisualStyleBackColor = true;
            btnExp.Click += numberOp;
            // 
            // btnLn
            // 
            btnLn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLn.Location = new Point(890, 522);
            btnLn.Margin = new Padding(4);
            btnLn.Name = "btnLn";
            btnLn.Size = new Size(111, 111);
            btnLn.TabIndex = 37;
            btnLn.Text = "ln x";
            btnLn.UseVisualStyleBackColor = true;
            btnLn.Click += btnLn_Click;
            // 
            // btnHex
            // 
            btnHex.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnHex.Location = new Point(766, 522);
            btnHex.Margin = new Padding(4);
            btnHex.Name = "btnHex";
            btnHex.Size = new Size(112, 111);
            btnHex.TabIndex = 36;
            btnHex.Text = "Hex";
            btnHex.UseVisualStyleBackColor = true;
            btnHex.Click += btnHex_Click;
            // 
            // btnTan
            // 
            btnTan.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnTan.Location = new Point(650, 522);
            btnTan.Margin = new Padding(4);
            btnTan.Name = "btnTan";
            btnTan.Size = new Size(112, 111);
            btnTan.TabIndex = 35;
            btnTan.Text = "Tan";
            btnTan.UseVisualStyleBackColor = true;
            btnTan.Click += btnTan_Click;
            // 
            // btnTanh
            // 
            btnTanh.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnTanh.Location = new Point(529, 522);
            btnTanh.Margin = new Padding(4);
            btnTanh.Name = "btnTanh";
            btnTanh.Size = new Size(112, 111);
            btnTanh.TabIndex = 34;
            btnTanh.Text = "Tanh";
            btnTanh.UseVisualStyleBackColor = true;
            btnTanh.Click += btnTanh_Click;
            // 
            // btnInv
            // 
            btnInv.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnInv.Location = new Point(886, 403);
            btnInv.Margin = new Padding(4);
            btnInv.Name = "btnInv";
            btnInv.Size = new Size(111, 111);
            btnInv.TabIndex = 33;
            btnInv.Text = "1/x";
            btnInv.UseVisualStyleBackColor = true;
            btnInv.Click += btnInv_Click;
            // 
            // btnBin
            // 
            btnBin.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBin.Location = new Point(762, 403);
            btnBin.Margin = new Padding(4);
            btnBin.Name = "btnBin";
            btnBin.Size = new Size(112, 111);
            btnBin.TabIndex = 32;
            btnBin.Text = "Bin";
            btnBin.UseVisualStyleBackColor = true;
            btnBin.Click += btnBin_Click;
            // 
            // btnCos
            // 
            btnCos.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCos.Location = new Point(645, 403);
            btnCos.Margin = new Padding(4);
            btnCos.Name = "btnCos";
            btnCos.Size = new Size(112, 111);
            btnCos.TabIndex = 31;
            btnCos.Text = "Cos";
            btnCos.UseVisualStyleBackColor = true;
            btnCos.Click += btnCos_Click;
            // 
            // btnCosh
            // 
            btnCosh.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCosh.Location = new Point(521, 403);
            btnCosh.Margin = new Padding(4);
            btnCosh.Name = "btnCosh";
            btnCosh.Size = new Size(112, 111);
            btnCosh.TabIndex = 30;
            btnCosh.Text = "Cosh";
            btnCosh.UseVisualStyleBackColor = true;
            btnCosh.Click += btnCosh_Click;
            // 
            // btnCube
            // 
            btnCube.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCube.Location = new Point(882, 284);
            btnCube.Margin = new Padding(4);
            btnCube.Name = "btnCube";
            btnCube.Size = new Size(111, 111);
            btnCube.TabIndex = 29;
            btnCube.Text = "x³";
            btnCube.UseVisualStyleBackColor = true;
            btnCube.Click += btnCube_Click;
            // 
            // btnDec
            // 
            btnDec.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDec.Location = new Point(762, 284);
            btnDec.Margin = new Padding(4);
            btnDec.Name = "btnDec";
            btnDec.Size = new Size(112, 111);
            btnDec.TabIndex = 28;
            btnDec.Text = "Dec";
            btnDec.UseVisualStyleBackColor = true;
            btnDec.Click += btnDec_Click;
            // 
            // btnSin
            // 
            btnSin.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSin.Location = new Point(641, 284);
            btnSin.Margin = new Padding(4);
            btnSin.Name = "btnSin";
            btnSin.Size = new Size(112, 111);
            btnSin.TabIndex = 27;
            btnSin.Text = "Sin";
            btnSin.UseVisualStyleBackColor = true;
            btnSin.Click += btnSin_Click;
            // 
            // btnSinh
            // 
            btnSinh.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSinh.Location = new Point(525, 287);
            btnSinh.Margin = new Padding(4);
            btnSinh.Name = "btnSinh";
            btnSinh.Size = new Size(112, 111);
            btnSinh.TabIndex = 26;
            btnSinh.Text = "Sinh";
            btnSinh.UseVisualStyleBackColor = true;
            btnSinh.Click += btnSinh_Click;
            // 
            // btnSqr
            // 
            btnSqr.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSqr.Location = new Point(886, 165);
            btnSqr.Margin = new Padding(4);
            btnSqr.Name = "btnSqr";
            btnSqr.Size = new Size(111, 111);
            btnSqr.TabIndex = 25;
            btnSqr.Text = "x²";
            btnSqr.UseVisualStyleBackColor = true;
            btnSqr.Click += btnSqr_Click;
            // 
            // btnSqrt
            // 
            btnSqrt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSqrt.Location = new Point(762, 165);
            btnSqrt.Margin = new Padding(4);
            btnSqrt.Name = "btnSqrt";
            btnSqrt.Size = new Size(112, 111);
            btnSqrt.TabIndex = 24;
            btnSqrt.Text = "Sqrt";
            btnSqrt.UseVisualStyleBackColor = true;
            btnSqrt.Click += btnSqrt_Click;
            // 
            // btnLog
            // 
            btnLog.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLog.Location = new Point(645, 169);
            btnLog.Margin = new Padding(4);
            btnLog.Name = "btnLog";
            btnLog.Size = new Size(112, 111);
            btnLog.TabIndex = 23;
            btnLog.Text = "Log";
            btnLog.UseVisualStyleBackColor = true;
            btnLog.Click += btnLog_Click;
            // 
            // btnPi
            // 
            btnPi.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnPi.Location = new Point(525, 165);
            btnPi.Margin = new Padding(4);
            btnPi.Name = "btnPi";
            btnPi.Size = new Size(112, 111);
            btnPi.TabIndex = 22;
            btnPi.Text = "π";
            btnPi.UseVisualStyleBackColor = true;
            btnPi.Click += btnPi_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 35F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1694, 846);
            Controls.Add(btnPer);
            Controls.Add(btnOct);
            Controls.Add(btnMod);
            Controls.Add(btnExp);
            Controls.Add(btnLn);
            Controls.Add(btnHex);
            Controls.Add(btnTan);
            Controls.Add(btnTanh);
            Controls.Add(btnInv);
            Controls.Add(btnBin);
            Controls.Add(btnCos);
            Controls.Add(btnCosh);
            Controls.Add(btnCube);
            Controls.Add(btnDec);
            Controls.Add(btnSin);
            Controls.Add(btnSinh);
            Controls.Add(btnSqr);
            Controls.Add(btnSqrt);
            Controls.Add(btnLog);
            Controls.Add(btnPi);
            Controls.Add(btnDiv);
            Controls.Add(btnEql);
            Controls.Add(btnDot);
            Controls.Add(btn0);
            Controls.Add(btnMul);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnSub);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btnAdd);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btnPM);
            Controls.Add(btnClear);
            Controls.Add(btnClearEntry);
            Controls.Add(txtResult);
            Controls.Add(btnBS);
            Controls.Add(menuStrip1);
            Font = new Font("Calibri", 14F, FontStyle.Regular, GraphicsUnit.Point);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBS;
        private TextBox txtResult;
        private Button btnClearEntry;
        private Button btnClear;
        private Button btnPM;
        private Button btnAdd;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btnSub;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btnMul;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btnDiv;
        private Button btnEql;
        private Button btnDot;
        private Button btn0;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem standardToolStripMenuItem;
        private ToolStripMenuItem scientificToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Button btnPer;
        private Button btnOct;
        private Button btnMod;
        private Button btnExp;
        private Button btnLn;
        private Button btnHex;
        private Button btnTan;
        private Button btnTanh;
        private Button btnInv;
        private Button btnBin;
        private Button btnCos;
        private Button btnCosh;
        private Button btnCube;
        private Button btnDec;
        private Button btnSin;
        private Button btnSinh;
        private Button btnSqr;
        private Button btnSqrt;
        private Button btnLog;
        private Button btnPi;
    }
}