using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Rock_Paper_Scissors
{
    public partial class Form1 : Form
    {
        int numberOfRounds;
        int round = 0;
        int botScore = 0;
        int playerScore = 0;
        string[] gestures = { "������", "�������", "������" };


        public Form1()
        {
            InitializeComponent();
            listGesture.Items.AddRange(gestures);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                return;

            if (textBox1.Text == "0")
            {
                MessageBox.Show("������� ���������� ������� �� 1 �� 9!");
                textBox1.Text = "";
                return;
            }
            try
            {
                numberOfRounds = int.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("������� ���������� ������� �� 1 �� 9!");
                textBox1.Text = "";
                return;
            }
            textBox1.Enabled = false;
            buttonPlay.Visible = true;
            labelRound.Visible = true;
        }
        private void listGesture_SelectedIndexChanged(object sender, EventArgs e)
        {
            playerImg.Image = imageList1.Images[GetIndex(listGesture.Text)];
            buttonPlay.Enabled = true;
            label3.Visible = true;
        }
        private static int GetIndex(string gesture)
        {
            switch (gesture)
            {
                case "�������":
                    return 2;
                case "������":
                    return 1;
                case "������":
                    return 0;
            }
            return -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblBotScore.Visible = true;
            lblPlayerScore.Visible = true;
            labelMessage.Visible = true;
            if (round < numberOfRounds)
            {
                round++;
                labelRound.Text = $"����� � {round}";
                Random random = new Random();
                int indexGesture = random.Next(0, 3);
                string playerGesture = listGesture.Text;
                string botGesture = gestures[indexGesture];
                botImg.Image = imageList1.Images[GetIndex(botGesture)];

                switch (playerGesture)
                {
                    case "������":
                        if (botGesture == "������")
                        {
                            labelMessage.Text = "�����, ����� �� ���������";
                            round--;
                        }
                        if (botGesture == "������")
                        {
                            labelMessage.Text = "���� ���������� :(";
                            botScore++;
                        }
                        if (botGesture == "�������")
                        {
                            labelMessage.Text = "���� ��� :)";
                            playerScore++;
                        }
                        break;

                    case "�������":
                        if (botGesture == "�������")
                        {
                            labelMessage.Text = "�����, ����� �� ���������";
                            round--;
                        }
                        if (botGesture == "������")
                        {
                            labelMessage.Text = "���� ���������� :(";
                            botScore++;
                        }
                        if (botGesture == "������")
                        {
                            labelMessage.Text = "���� ��� :)";
                            playerScore++;
                        }
                        break;
                    case "������":
                        if (botGesture == "������")
                        {
                            labelMessage.Text = "�����, ����� �� ���������";
                            round--;
                        }
                        if (botGesture == "�������")
                        {
                            labelMessage.Text = "���� ���������� :(";
                            botScore++;
                        }
                        if (botGesture == "������")
                        {
                            labelMessage.Text = "���� ��� :)";
                            playerScore++;
                        }
                        break;
                }
                lblPlayerScore.Text = playerScore.ToString();
                lblBotScore.Text = botScore.ToString();
            }
            else
            {
                labelMessage.Text = $"���� ���������, ���� {playerScore} : {botScore}";
                buttonPlay.Visible = false;
                listGesture.Enabled = false;
                if (playerScore > botScore)
                    MessageBox.Show("����������! �� ��������!!!");
                else if (playerScore < botScore)
                    MessageBox.Show("� ��������� �� ���������. ������ � ������ ���!");
                else
                    MessageBox.Show("�������� ������!");
            }
        }
    }
}


