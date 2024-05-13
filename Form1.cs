namespace fishing
{
    public partial class Form1 : Form
    {
        private string[] rockLevel = new string[25]
            {
            "평범한 돌",
            "단단한 돌",
            "엄청난 돌",
            "약간 날카로운 돌",
            "강한 돌",
            "가공된 돌",
            "짱돌",
            "한방 돌",
            "돌 검",
            "빛나는 돌",
            "황금 돌",
            "매우 날카로운 돌",
            "무지개 돌",
            "공룡 화석",
            "근육질 돌",
            "맛있는 돌",
            "돌 망치",
            "대리석",
            "달의 조각",
            "태양석",
            "은하수의 조각",
            "혜성 조각",
            "안드로메다의 행성",
            "우주의 파편",
            "신의 돌"
        };

        private int defaultWeight = 98;
        private int upgradeIndex = 0;
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void upgradeButtonClicked(object sender, EventArgs e)
        {
            int ranNum = random.Next(0, 100);
            if (upgradeIndex <= 23)
            {
                upgradeIndex++;
                if (ranNum <= defaultWeight)
                {
                    if (upgradeIndex <= 10)
                    {
                        defaultWeight -= 5;
                    }
                    else if (upgradeIndex >= 11 && upgradeIndex <= 18)
                    {
                        defaultWeight -= 4;
                    }
                    else if (upgradeIndex >= 19 && upgradeIndex <= 23)
                    {
                        defaultWeight -= 3;
                    }
                    weight.Text = defaultWeight + "%";
                    rock.Text = upgradeIndex + "강 " + rockLevel[upgradeIndex];
                }
                else
                {
                    upgradeIndex = 0;
                    defaultWeight = 98;
                    weight.Text = defaultWeight + "%";
                    rock.Text = upgradeIndex + "강 " + rockLevel[upgradeIndex];
                    MessageBox.Show("강화에 실패했습니다!");
                }
            }
            else
            {
                MessageBox.Show("최고레벨 입니다.");
            }

        }

        private void weight_Click(object sender, EventArgs e)
        {

        }
    }
}
