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
            groupBox1 = new GroupBox();
            rbtnCtoF = new RadioButton();
            rbtnFtoC = new RadioButton();
            txtInput = new MaskedTextBox();
            lblResult = new Label();
            btnConvert = new Button();
            btnClear = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtnFtoC);
            groupBox1.Controls.Add(rbtnCtoF);
            groupBox1.Location = new Point(12, 142);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(236, 158);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // rbtnCtoF
            // 
            rbtnCtoF.AutoSize = true;
            rbtnCtoF.Location = new Point(64, 40);
            rbtnCtoF.Name = "rbtnCtoF";
            rbtnCtoF.Size = new Size(85, 19);
            rbtnCtoF.TabIndex = 0;
            rbtnCtoF.TabStop = true;
            rbtnCtoF.Text = "攝氏轉華氏";
            rbtnCtoF.UseVisualStyleBackColor = true;
            rbtnCtoF.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // rbtnFtoC
            // 
            rbtnFtoC.AutoSize = true;
            rbtnFtoC.Location = new Point(64, 100);
            rbtnFtoC.Name = "rbtnFtoC";
            rbtnFtoC.Size = new Size(85, 19);
            rbtnFtoC.TabIndex = 1;
            rbtnFtoC.TabStop = true;
            rbtnFtoC.Text = "華氏轉攝氏";
            rbtnFtoC.UseVisualStyleBackColor = true;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(513, 142);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(235, 23);
            txtInput.TabIndex = 1;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(513, 249);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(34, 15);
            lblResult.TabIndex = 2;
            lblResult.Text = "結果:";
            // 
            // btnConvert
            // 
            btnConvert.BackColor = SystemColors.AppWorkspace;
            btnConvert.Location = new Point(513, 187);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(72, 38);
            btnConvert.TabIndex = 3;
            btnConvert.Text = "轉換";
            btnConvert.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.AppWorkspace;
            btnClear.Location = new Point(603, 187);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(72, 38);
            btnClear.TabIndex = 4;
            btnClear.Text = "清除";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.AppWorkspace;
            button1.Location = new Point(309, 143);
            button1.Name = "button1";
            button1.Size = new Size(38, 38);
            button1.TabIndex = 5;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.AppWorkspace;
            button2.Location = new Point(353, 143);
            button2.Name = "button2";
            button2.Size = new Size(38, 38);
            button2.TabIndex = 6;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.AppWorkspace;
            button3.Location = new Point(397, 143);
            button3.Name = "button3";
            button3.Size = new Size(38, 38);
            button3.TabIndex = 7;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.AppWorkspace;
            button4.Location = new Point(309, 187);
            button4.Name = "button4";
            button4.Size = new Size(38, 38);
            button4.TabIndex = 8;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.AppWorkspace;
            button5.Location = new Point(353, 187);
            button5.Name = "button5";
            button5.Size = new Size(38, 38);
            button5.TabIndex = 9;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.AppWorkspace;
            button6.Location = new Point(397, 187);
            button6.Name = "button6";
            button6.Size = new Size(38, 38);
            button6.TabIndex = 10;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.AppWorkspace;
            button7.Location = new Point(309, 231);
            button7.Name = "button7";
            button7.Size = new Size(38, 38);
            button7.TabIndex = 11;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.AppWorkspace;
            button8.Location = new Point(353, 231);
            button8.Name = "button8";
            button8.Size = new Size(38, 38);
            button8.TabIndex = 12;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.AppWorkspace;
            button9.Location = new Point(397, 231);
            button9.Name = "button9";
            button9.Size = new Size(38, 38);
            button9.TabIndex = 13;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            button10.BackColor = SystemColors.AppWorkspace;
            button10.Location = new Point(309, 275);
            button10.Name = "button10";
            button10.Size = new Size(38, 38);
            button10.TabIndex = 14;
            button10.Text = "0";
            button10.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            button11.BackColor = SystemColors.AppWorkspace;
            button11.Location = new Point(353, 275);
            button11.Name = "button11";
            button11.Size = new Size(38, 38);
            button11.TabIndex = 15;
            button11.Text = ".";
            button11.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnClear);
            Controls.Add(btnConvert);
            Controls.Add(lblResult);
            Controls.Add(txtInput);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton rbtnFtoC;
        private RadioButton rbtnCtoF;
        private MaskedTextBox txtInput;
        private Label lblResult;
        private Button btnConvert;
        private Button btnClear;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
    }
}
