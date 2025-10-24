namespace _02_TemperatureConversion
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
            rbtnCtoF = new RadioButton();
            rbtnFtoC = new RadioButton();
            groupBox1 = new GroupBox();
            txtInput = new TextBox();
            lblResult = new Label();
            btnConvert = new Button();
            btnClear = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn0 = new Button();
            btnDot = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // rbtnCtoF
            // 
            rbtnCtoF.AutoSize = true;
            rbtnCtoF.Location = new Point(35, 22);
            rbtnCtoF.Name = "rbtnCtoF";
            rbtnCtoF.Size = new Size(85, 19);
            rbtnCtoF.TabIndex = 0;
            rbtnCtoF.TabStop = true;
            rbtnCtoF.Text = "攝氏轉華氏";
            rbtnCtoF.UseVisualStyleBackColor = true;
            rbtnCtoF.CheckedChanged += rbtnCtoF_CheckedChanged;
            // 
            // rbtnFtoC
            // 
            rbtnFtoC.AutoSize = true;
            rbtnFtoC.Location = new Point(35, 57);
            rbtnFtoC.Name = "rbtnFtoC";
            rbtnFtoC.Size = new Size(85, 19);
            rbtnFtoC.TabIndex = 1;
            rbtnFtoC.TabStop = true;
            rbtnFtoC.Text = "華氏轉攝氏";
            rbtnFtoC.UseVisualStyleBackColor = true;
            rbtnFtoC.CheckedChanged += rbtnFtoC_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtnCtoF);
            groupBox1.Controls.Add(rbtnFtoC);
            groupBox1.Location = new Point(12, 127);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(216, 100);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(543, 145);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(205, 23);
            txtInput.TabIndex = 3;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(543, 237);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(42, 15);
            lblResult.TabIndex = 4;
            lblResult.Text = "label1";
            // 
            // btnConvert
            // 
            btnConvert.BackColor = SystemColors.AppWorkspace;
            btnConvert.Location = new Point(543, 184);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(62, 32);
            btnConvert.TabIndex = 5;
            btnConvert.Text = "轉換";
            btnConvert.UseVisualStyleBackColor = false;
            btnConvert.Click += btnConvert_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.AppWorkspace;
            btnClear.Location = new Point(611, 184);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(58, 32);
            btnClear.TabIndex = 6;
            btnClear.Text = "清除";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btn1
            // 
            btn1.BackColor = SystemColors.AppWorkspace;
            btn1.Location = new Point(302, 130);
            btn1.Name = "btn1";
            btn1.Size = new Size(47, 32);
            btn1.TabIndex = 7;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += BtnNumber_Click;
            // 
            // btn2
            // 
            btn2.BackColor = SystemColors.AppWorkspace;
            btn2.Location = new Point(355, 130);
            btn2.Name = "btn2";
            btn2.Size = new Size(47, 32);
            btn2.TabIndex = 8;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += BtnNumber_Click;
            // 
            // btn3
            // 
            btn3.BackColor = SystemColors.AppWorkspace;
            btn3.Location = new Point(408, 130);
            btn3.Name = "btn3";
            btn3.Size = new Size(47, 32);
            btn3.TabIndex = 9;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += BtnNumber_Click;
            // 
            // btn4
            // 
            btn4.BackColor = SystemColors.AppWorkspace;
            btn4.Location = new Point(302, 171);
            btn4.Name = "btn4";
            btn4.Size = new Size(47, 32);
            btn4.TabIndex = 10;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += BtnNumber_Click;
            // 
            // btn5
            // 
            btn5.BackColor = SystemColors.AppWorkspace;
            btn5.Location = new Point(355, 171);
            btn5.Name = "btn5";
            btn5.Size = new Size(47, 32);
            btn5.TabIndex = 11;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += BtnNumber_Click;
            // 
            // btn6
            // 
            btn6.BackColor = SystemColors.AppWorkspace;
            btn6.Location = new Point(408, 171);
            btn6.Name = "btn6";
            btn6.Size = new Size(47, 32);
            btn6.TabIndex = 12;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += BtnNumber_Click;
            // 
            // btn7
            // 
            btn7.BackColor = SystemColors.AppWorkspace;
            btn7.Location = new Point(302, 214);
            btn7.Name = "btn7";
            btn7.Size = new Size(47, 32);
            btn7.TabIndex = 13;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += BtnNumber_Click;
            // 
            // btn8
            // 
            btn8.BackColor = SystemColors.AppWorkspace;
            btn8.Location = new Point(355, 214);
            btn8.Name = "btn8";
            btn8.Size = new Size(47, 32);
            btn8.TabIndex = 14;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += BtnNumber_Click;
            // 
            // btn9
            // 
            btn9.BackColor = SystemColors.AppWorkspace;
            btn9.Location = new Point(408, 214);
            btn9.Name = "btn9";
            btn9.Size = new Size(47, 32);
            btn9.TabIndex = 15;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += BtnNumber_Click;
            // 
            // btn0
            // 
            btn0.BackColor = SystemColors.AppWorkspace;
            btn0.Location = new Point(302, 252);
            btn0.Name = "btn0";
            btn0.Size = new Size(47, 32);
            btn0.TabIndex = 16;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += BtnNumber_Click;
            // 
            // btnDot
            // 
            btnDot.BackColor = SystemColors.AppWorkspace;
            btnDot.Location = new Point(355, 252);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(47, 32);
            btnDot.TabIndex = 17;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = false;
            btnDot.Click += BtnNumber_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDot);
            Controls.Add(btn0);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnClear);
            Controls.Add(btnConvert);
            Controls.Add(lblResult);
            Controls.Add(txtInput);
            Controls.Add(groupBox1);
            Name = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rbtnCtoF;
        private RadioButton rbtnFtoC;
        private GroupBox groupBox1;
        private TextBox txtInput;
        private Label lblResult;
        private Button btnConvert;
        private Button btnClear;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn0;
        private Button btnDot;
    }
}
