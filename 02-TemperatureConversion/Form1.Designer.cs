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
            groupBox1 = new System.Windows.Forms.GroupBox();
            rbtnCtoF = new System.Windows.Forms.RadioButton();
            rbtnFtoC = new System.Windows.Forms.RadioButton();
            txtInput = new System.Windows.Forms.MaskedTextBox();
            lblResult = new System.Windows.Forms.Label();
            btnConvert = new System.Windows.Forms.Button();
            btnClear = new System.Windows.Forms.Button();
            btn1 = new System.Windows.Forms.Button();
            btn2 = new System.Windows.Forms.Button();
            btn3 = new System.Windows.Forms.Button();
            btn4 = new System.Windows.Forms.Button();
            btn5 = new System.Windows.Forms.Button();
            btn6 = new System.Windows.Forms.Button();
            btn7 = new System.Windows.Forms.Button();
            btn8 = new System.Windows.Forms.Button();
            btn9 = new System.Windows.Forms.Button();
            btn0 = new System.Windows.Forms.Button();
            btnDot = new System.Windows.Forms.Button();
            groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtnFtoC);
            groupBox1.Controls.Add(rbtnCtoF);
            groupBox1.Location = new System.Drawing.Point(12, 142);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(236, 158);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // rbtnCtoF
            // 
            rbtnCtoF.AutoSize = true;
            rbtnCtoF.Location = new System.Drawing.Point(64, 40);
            rbtnCtoF.Name = "rbtnCtoF";
            rbtnCtoF.Size = new System.Drawing.Size(85, 19);
            rbtnCtoF.TabIndex = 0;
            rbtnCtoF.TabStop = true;
            rbtnCtoF.Text = "攝氏轉華氏";
            rbtnCtoF.UseVisualStyleBackColor = true;
            rbtnCtoF.CheckedChanged += this.radioButton1_CheckedChanged;
            // 
            // rbtnFtoC
            // 
            rbtnFtoC.AutoSize = true;
            rbtnFtoC.Location = new System.Drawing.Point(64, 100);
            rbtnFtoC.Name = "rbtnFtoC";
            rbtnFtoC.Size = new System.Drawing.Size(85, 19);
            rbtnFtoC.TabIndex = 1;
            rbtnFtoC.TabStop = true;
            rbtnFtoC.Text = "華氏轉攝氏";
            rbtnFtoC.UseVisualStyleBackColor = true;
            // 
            // txtInput
            // 
            txtInput.Location = new System.Drawing.Point(513, 142);
            txtInput.Name = "txtInput";
            txtInput.Size = new System.Drawing.Size(235, 23);
            txtInput.TabIndex = 1;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new System.Drawing.Point(513, 249);
            lblResult.Name = "lblResult";
            lblResult.Size = new System.Drawing.Size(34, 15);
            lblResult.TabIndex = 2;
            lblResult.Text = "結果:";
            // 
            // btnConvert
            // 
            btnConvert.BackColor = System.Drawing.SystemColors.AppWorkspace;
            btnConvert.Location = new System.Drawing.Point(513, 187);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new System.Drawing.Size(72, 38);
            btnConvert.TabIndex = 3;
            btnConvert.Text = "轉換";
            btnConvert.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = System.Drawing.SystemColors.AppWorkspace;
            btnClear.Location = new System.Drawing.Point(603, 187);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(72, 38);
            btnClear.TabIndex = 4;
            btnClear.Text = "清除";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btn1
            // 
            btn1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            btn1.Location = new System.Drawing.Point(309, 143);
            btn1.Name = "btn1";
            btn1.Size = new System.Drawing.Size(38, 38);
            btn1.TabIndex = 5;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            // 
            // btn2
            // 
            btn2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            btn2.Location = new System.Drawing.Point(353, 143);
            btn2.Name = "btn2";
            btn2.Size = new System.Drawing.Size(38, 38);
            btn2.TabIndex = 6;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            // 
            // btn3
            // 
            btn3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            btn3.Location = new System.Drawing.Point(397, 143);
            btn3.Name = "btn3";
            btn3.Size = new System.Drawing.Size(38, 38);
            btn3.TabIndex = 7;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            // 
            // btn4
            // 
            btn4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            btn4.Location = new System.Drawing.Point(309, 187);
            btn4.Name = "btn4";
            btn4.Size = new System.Drawing.Size(38, 38);
            btn4.TabIndex = 8;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            // 
            // btn5
            // 
            btn5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            btn5.Location = new System.Drawing.Point(353, 187);
            btn5.Name = "btn5";
            btn5.Size = new System.Drawing.Size(38, 38);
            btn5.TabIndex = 9;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            // 
            // btn6
            // 
            btn6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            btn6.Location = new System.Drawing.Point(397, 187);
            btn6.Name = "btn6";
            btn6.Size = new System.Drawing.Size(38, 38);
            btn6.TabIndex = 10;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            // 
            // btn7
            // 
            btn7.BackColor = System.Drawing.SystemColors.AppWorkspace;
            btn7.Location = new System.Drawing.Point(309, 231);
            btn7.Name = "btn7";
            btn7.Size = new System.Drawing.Size(38, 38);
            btn7.TabIndex = 11;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            // 
            // btn8
            // 
            btn8.BackColor = System.Drawing.SystemColors.AppWorkspace;
            btn8.Location = new System.Drawing.Point(353, 231);
            btn8.Name = "btn8";
            btn8.Size = new System.Drawing.Size(38, 38);
            btn8.TabIndex = 12;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            // 
            // btn9
            // 
            btn9.BackColor = System.Drawing.SystemColors.AppWorkspace;
            btn9.Location = new System.Drawing.Point(397, 231);
            btn9.Name = "btn9";
            btn9.Size = new System.Drawing.Size(38, 38);
            btn9.TabIndex = 13;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            // 
            // btn0
            // 
            btn0.BackColor = System.Drawing.SystemColors.AppWorkspace;
            btn0.Location = new System.Drawing.Point(309, 275);
            btn0.Name = "btn0";
            btn0.Size = new System.Drawing.Size(38, 38);
            btn0.TabIndex = 14;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            // 
            // btnDot
            // 
            btnDot.BackColor = System.Drawing.SystemColors.AppWorkspace;
            btnDot.Location = new System.Drawing.Point(353, 275);
            btnDot.Name = "btnDot";
            btnDot.Size = new System.Drawing.Size(38, 38);
            btnDot.TabIndex = 15;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(btnDot);
            this.Controls.Add(btn0);
            this.Controls.Add(btn9);
            this.Controls.Add(btn8);
            this.Controls.Add(btn7);
            this.Controls.Add(btn6);
            this.Controls.Add(btn5);
            this.Controls.Add(btn4);
            this.Controls.Add(btn3);
            this.Controls.Add(btn2);
            this.Controls.Add(btn1);
            this.Controls.Add(btnClear);
            this.Controls.Add(btnConvert);
            this.Controls.Add(lblResult);
            this.Controls.Add(txtInput);
            this.Controls.Add(groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton rbtnFtoC;
        private RadioButton rbtnCtoF;
        private MaskedTextBox txtInput;
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
