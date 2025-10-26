namespace _05_Numerology
{
    public partial class Form1 : Form
    {
        private string[] zodiacNames = {
            "Capricorn", "Aquarius", "Pisces", "Aries", "Taurus",
            "Gemini", "Cancer", "Leo", "Virgo", "Libra", "Scorpio", "Sagittarius" };

        private int[] zodiacStartDays = { 20, 19, 21, 21, 21, 22, 23, 23, 23, 23, 23, 22 };

        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy年 M月 d日";
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            DateTime birth = dateTimePicker1.Value;

            string zodiac = GetZodiac(birth);

            int lifeNum = GetLifeNumber(birth);

            string comment = GetComment(zodiac, lifeNum);

            txtResult.Text = $"你的星座是：{zodiac}\r\n" +
                             $"你的生命靈數是：{lifeNum}\r\n\r\n" +
                             $"{comment}";
        }

        private int GetLifeNumber(DateTime date)
        {
            string all = $"{date.Year}{date.Month:D2}{date.Day:D2}";
            int sum = all.Sum(c => c - '0');
            return ReduceToOneDigit(sum);
        }

        private int ReduceToOneDigit(int num)
        {
            if (num < 10) return num;
            int sum = num.ToString().Sum(c => c - '0');
            return ReduceToOneDigit(sum);
        }

        private string GetZodiac(DateTime date)
        {
            int m = date.Month;
            int d = date.Day;

            return m switch
            {
                1 => (d < 20) ? "Capricorn 摩羯座" : "Aquarius 水瓶座",
                2 => (d < 19) ? "Aquarius 水瓶座" : "Pisces 雙魚座",
                3 => (d < 21) ? "Pisces 雙魚座" : "Aries 牡羊座",
                4 => (d < 21) ? "Aries 牡羊座" : "Taurus 金牛座",
                5 => (d < 21) ? "Taurus 金牛座" : "Gemini 雙子座",
                6 => (d < 22) ? "Gemini 雙子座" : "Cancer 巨蟹座",
                7 => (d < 23) ? "Cancer 巨蟹座" : "Leo 獅子座",
                8 => (d < 23) ? "Leo 獅子座" : "Virgo 處女座",
                9 => (d < 23) ? "Virgo 處女座" : "Libra 天秤座",
                10 => (d < 24) ? "Libra 天秤座" : "Scorpio 天蠍座",
                11 => (d < 23) ? "Scorpio 天蠍座" : "Sagittarius 射手座",
                12 => (d < 22) ? "Sagittarius 射手座" : "Capricorn 摩羯座",
                _ => "未知"
            };
        }

        private string GetComment(string zodiac, int lifeNum)
        {
            string file = Path.Combine(Application.StartupPath, "生命靈數.txt");

            if (!File.Exists(file))
                return "⚠️ 找不到檔案：請將「生命靈數.txt」放在執行檔資料夾內";

            string text = File.ReadAllText(file);

            
            int start = text.IndexOf($"【{zodiac.Split(' ')[0]}");
            if (start == -1) return "❌ 找不到對應星座。";

            int next = text.IndexOf("【", start + 1);
            string section = (next > 0) ? text.Substring(start, next - start) : text.Substring(start);

            
            string key = $"生命靈數{lifeNum}：";
            int kStart = section.IndexOf(key);
            if (kStart == -1) return "❌ 找不到生命靈數內容。";

            int kEnd = section.IndexOf("生命靈數", kStart + key.Length);
            string content = (kEnd > 0) ? section.Substring(kStart, kEnd - kStart) : section.Substring(kStart);

            return content.Trim();
        }
    }
}
    

