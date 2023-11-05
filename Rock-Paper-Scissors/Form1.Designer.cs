namespace Rock_Paper_Scissors
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            listGesture = new ListBox();
            buttonPlay = new Button();
            playerImg = new PictureBox();
            botImg = new PictureBox();
            label3 = new Label();
            labelMessage = new Label();
            imageList1 = new ImageList(components);
            labelRound = new Label();
            lblPlayerScore = new Label();
            lblBotScore = new Label();
            ((System.ComponentModel.ISupportInitialize)playerImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)botImg).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 11);
            label1.Name = "label1";
            label1.Size = new Size(151, 15);
            label1.TabIndex = 0;
            label1.Text = "Количество раундов (1-9):";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(166, 8);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(32, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 48);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 2;
            label2.Text = "Выберите жест:";
            // 
            // listGesture
            // 
            listGesture.FormattingEnabled = true;
            listGesture.ItemHeight = 15;
            listGesture.Location = new Point(115, 48);
            listGesture.Name = "listGesture";
            listGesture.Size = new Size(133, 49);
            listGesture.TabIndex = 3;
            listGesture.SelectedIndexChanged += listGesture_SelectedIndexChanged;
            // 
            // buttonPlay
            // 
            buttonPlay.BackColor = SystemColors.ActiveCaption;
            buttonPlay.Enabled = false;
            buttonPlay.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPlay.Location = new Point(115, 300);
            buttonPlay.Name = "buttonPlay";
            buttonPlay.Size = new Size(133, 36);
            buttonPlay.TabIndex = 4;
            buttonPlay.Text = "Сыграть";
            buttonPlay.UseVisualStyleBackColor = false;
            buttonPlay.Visible = false;
            buttonPlay.Click += button1_Click;
            // 
            // playerImg
            // 
            playerImg.Location = new Point(16, 131);
            playerImg.Name = "playerImg";
            playerImg.Size = new Size(123, 94);
            playerImg.SizeMode = PictureBoxSizeMode.StretchImage;
            playerImg.TabIndex = 5;
            playerImg.TabStop = false;
            // 
            // botImg
            // 
            botImg.Location = new Point(233, 131);
            botImg.Name = "botImg";
            botImg.Size = new Size(123, 94);
            botImg.SizeMode = PictureBoxSizeMode.StretchImage;
            botImg.TabIndex = 6;
            botImg.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(166, 161);
            label3.Name = "label3";
            label3.Size = new Size(43, 32);
            label3.TabIndex = 7;
            label3.Text = "VS";
            label3.Visible = false;
            // 
            // labelMessage
            // 
            labelMessage.AutoSize = true;
            labelMessage.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelMessage.ForeColor = Color.Red;
            labelMessage.Location = new Point(16, 270);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(75, 15);
            labelMessage.TabIndex = 8;
            labelMessage.Text = "Сообщение";
            labelMessage.Visible = false;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "paper.png");
            imageList1.Images.SetKeyName(1, "rock.png");
            imageList1.Images.SetKeyName(2, "Scissors.png");
            // 
            // labelRound
            // 
            labelRound.AutoSize = true;
            labelRound.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelRound.ForeColor = Color.Red;
            labelRound.Location = new Point(135, 103);
            labelRound.Name = "labelRound";
            labelRound.Size = new Size(94, 25);
            labelRound.TabIndex = 9;
            labelRound.Text = "Раунд № ";
            labelRound.Visible = false;
            // 
            // lblPlayerScore
            // 
            lblPlayerScore.AutoSize = true;
            lblPlayerScore.Location = new Point(60, 237);
            lblPlayerScore.Name = "lblPlayerScore";
            lblPlayerScore.Size = new Size(13, 15);
            lblPlayerScore.TabIndex = 10;
            lblPlayerScore.Text = "0";
            lblPlayerScore.Visible = false;
            // 
            // lblBotScore
            // 
            lblBotScore.AutoSize = true;
            lblBotScore.Location = new Point(285, 237);
            lblBotScore.Name = "lblBotScore";
            lblBotScore.Size = new Size(13, 15);
            lblBotScore.TabIndex = 11;
            lblBotScore.Text = "0";
            lblBotScore.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblBotScore);
            Controls.Add(lblPlayerScore);
            Controls.Add(labelRound);
            Controls.Add(labelMessage);
            Controls.Add(label3);
            Controls.Add(botImg);
            Controls.Add(playerImg);
            Controls.Add(buttonPlay);
            Controls.Add(listGesture);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)playerImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)botImg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private ListBox listGesture;
        private Button buttonPlay;
        private PictureBox playerImg;
        private PictureBox botImg;
        private Label label3;
        private Label labelMessage;
        private ImageList imageList1;
        private Label labelRound;
        private Label lblPlayerScore;
        private Label lblBotScore;
    }
}