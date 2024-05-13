namespace fishing
{
    public partial class Form1 : Form
    {
        private string[] rockLevel = new string[25]
            {
            "����� ��",
            "�ܴ��� ��",
            "��û�� ��",
            "�ణ ��ī�ο� ��",
            "���� ��",
            "������ ��",
            "¯��",
            "�ѹ� ��",
            "�� ��",
            "������ ��",
            "Ȳ�� ��",
            "�ſ� ��ī�ο� ��",
            "������ ��",
            "���� ȭ��",
            "������ ��",
            "���ִ� ��",
            "�� ��ġ",
            "�븮��",
            "���� ����",
            "�¾缮",
            "���ϼ��� ����",
            "���� ����",
            "�ȵ�θ޴��� �༺",
            "������ ����",
            "���� ��"
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
                    rock.Text = upgradeIndex + "�� " + rockLevel[upgradeIndex];
                }
                else
                {
                    upgradeIndex = 0;
                    defaultWeight = 98;
                    weight.Text = defaultWeight + "%";
                    rock.Text = upgradeIndex + "�� " + rockLevel[upgradeIndex];
                    MessageBox.Show("��ȭ�� �����߽��ϴ�!");
                }
            }
            else
            {
                MessageBox.Show("�ְ��� �Դϴ�.");
            }

        }

        private void weight_Click(object sender, EventArgs e)
        {

        }
    }
}
