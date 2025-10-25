namespace _04_GuessNumber
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
            txtInput = new TextBox();
            btnStart = new Button();
            btnShowAns = new Button();
            btnCheck = new Button();
            btnReset = new Button();
            label1 = new Label();
            label2 = new Label();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(40, 293);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(196, 23);
            txtInput.TabIndex = 1;
            // 
            // btnStart
            // 
            btnStart.BackColor = SystemColors.ButtonShadow;
            btnStart.Location = new Point(40, 60);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(97, 43);
            btnStart.TabIndex = 3;
            btnStart.Text = "開始遊戲";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // btnShowAns
            // 
            btnShowAns.BackColor = SystemColors.ButtonShadow;
            btnShowAns.Location = new Point(40, 133);
            btnShowAns.Name = "btnShowAns";
            btnShowAns.Size = new Size(97, 43);
            btnShowAns.TabIndex = 4;
            btnShowAns.Text = "看答案";
            btnShowAns.UseVisualStyleBackColor = false;
            btnShowAns.Click += btnShowAns_Click;
            // 
            // btnCheck
            // 
            btnCheck.BackColor = SystemColors.ButtonShadow;
            btnCheck.Location = new Point(40, 333);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(82, 38);
            btnCheck.TabIndex = 5;
            btnCheck.Text = "檢查答案";
            btnCheck.UseVisualStyleBackColor = false;
            btnCheck.Click += btnCheck_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = SystemColors.ButtonShadow;
            btnReset.Location = new Point(152, 333);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(84, 38);
            btnReset.TabIndex = 6;
            btnReset.Text = "放棄重來";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label1.Location = new Point(40, 270);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 7;
            label1.Text = "輸入";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label2.Location = new Point(473, 24);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 8;
            label2.Text = "遊戲歷程";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(473, 60);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(262, 334);
            listBox1.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnReset);
            Controls.Add(btnCheck);
            Controls.Add(btnShowAns);
            Controls.Add(btnStart);
            Controls.Add(txtInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtInput;
        private Button btnStart;
        private Button btnShowAns;
        private Button btnCheck;
        private Button btnReset;
        private Label label1;
        private Label label2;
        private ListBox listBox1;
    }
}
