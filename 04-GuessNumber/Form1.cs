using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace _04_GuessNumber
{
    public partial class Form1 : Form
    {
        private string answer = "";
        private static readonly Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();


            btnCheck.Enabled = false;
            btnReset.Enabled = false;

        }

        private string GenerateNumber()
        {
            List<int> nums = new List<int>();
            while (nums.Count < 4)
            {
                int n = rnd.Next(0, 10);
                if (!nums.Contains(n))
                    nums.Add(n);
            }
            return string.Join("", nums);
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            answer = GenerateNumber();


            listBox1.Items.Clear();
            txtInput.Clear();
            MessageBox.Show("�C���}�l�I");

            btnStart.Enabled = false;
            btnCheck.Enabled = true;
            btnReset.Enabled = true;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string guess = txtInput.Text.Trim();



            if (!int.TryParse(guess, out _) || guess.Length != 4)
            {
                MessageBox.Show("�п�J 4 ��Ʀr�I");
                return;
            }

            string result = CheckGuess(guess, answer);


            listBox1.Items.Add($"{guess} : {result}");

            if (result == "4A0B")
            {
                MessageBox.Show("�L���I");
                btnCheck.Enabled = false;
                btnReset.Enabled = true;
            }

            txtInput.Clear();
        }

        private string CheckGuess(string guess, string ans)
        {
            int A = 0, B = 0;

            for (int i = 0; i < 4; i++)
            {
                if (guess[i] == ans[i])
                    A++;
                else if (ans.Contains(guess[i]))
                    B++;
            }

            return $"{A}A{B}B";
        }

        private void btnShowAns_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"���׬O�G{answer}");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            answer = GenerateNumber();
            listBox1.Items.Clear();
            txtInput.Clear();
            MessageBox.Show("�C�����m�I");

            btnStart.Enabled = true;
            btnCheck.Enabled = false;
            btnReset.Enabled = false;
        }
    }
}
