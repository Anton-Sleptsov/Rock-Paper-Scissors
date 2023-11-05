using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Rock_Paper_Scissors
{
    public partial class Form1 : Form
    {
        int numberOfRounds;
        int round = 0;
        int botScore = 0;
        int playerScore = 0;
        string[] gestures = { "Камень", "Ножницы", "Бумага" };


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
                MessageBox.Show("Введите количество раундов от 1 до 9!");
                textBox1.Text = "";
                return;
            }
            try
            {
                numberOfRounds = int.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Введите количество раундов от 1 до 9!");
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
                case "Ножницы":
                    return 2;
                case "Камень":
                    return 1;
                case "Бумага":
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
                labelRound.Text = $"Раунд № {round}";
                Random random = new Random();
                int indexGesture = random.Next(3);
                string playerGesture = listGesture.Text;
                string botGesture = gestures[indexGesture];
                botImg.Image = imageList1.Images[GetIndex(botGesture)];

                switch (playerGesture)
                {
                    case "Камень":
                        if (botGesture == "Камень")
                        {
                            Draw();
                        }
                        if (botGesture == "Бумага")
                        {
                            Lose();
                        }
                        if (botGesture == "Ножницы")
                        {
                            Win();
                        }
                        break;

                    case "Ножницы":
                        if (botGesture == "Ножницы")
                        {
                            Draw();
                        }
                        if (botGesture == "Камень")
                        {
                            Lose();
                        }
                        if (botGesture == "Бумага")
                        {
                            Win();
                        }
                        break;
                    case "Бумага":
                        if (botGesture == "Бумага")
                        {
                            Draw();
                        }
                        if (botGesture == "Ножницы")
                        {
                            Lose();
                        }
                        if (botGesture == "Камень")
                        {
                            Win();
                        }
                        break;
                }
                lblPlayerScore.Text = playerScore.ToString();
                lblBotScore.Text = botScore.ToString();
            }
            else
            {
                labelMessage.Text = $"Игра закончена, счёт {playerScore} : {botScore}";
                buttonPlay.Visible = false;
                listGesture.Enabled = false;
                if (playerScore > botScore)
                    MessageBox.Show("Поздравляю! Вы выиграли!!!");
                else if (playerScore < botScore)
                    MessageBox.Show("К сожалению вы проиграли. Повезёт в другой раз!");
                else
                    MessageBox.Show("Победила дружба!");
            }
            void Draw()
            {
                labelMessage.Text = "Ничья, раунд не считается";
                round--;
            }
            void Win()
            {
                labelMessage.Text = "Балл вам :)";
                playerScore++;
            }
            void Lose()
            {
                labelMessage.Text = "Балл компьютеру :(";
                botScore++;
            }
        }
    }
}


