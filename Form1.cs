using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Controls;

namespace WhoWantsToBeAMillionaire
{
    public partial class Form1 : MetroForm
    {
        List<Question> questions = new List<Question>();
        List<MetroButton> buttonsM = new List<MetroButton>();
        private Random rnd = new Random();
        int level = 0;
        bool ok = true;
        Question currentQuestion;

        public Form1()
        {
            InitializeComponent();
            this.ControlBox = false;
            ReadFile();
            startGame();
        }

        private void ReadFile()
        {
            string path = @"Вопросы.txt";
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while((line = sr.ReadLine()) != null) {
                    questions.Add(new Question(line.Split('\t')));
                }
            }

        }

        private void ShowQuestion(Question q)
        {
            IblQuestion.Text = q.Text;
            btnAnswer1.Text = q.Answers[0];
            btnAnswer2.Text = q.Answers[1];
            btnAnswer3.Text = q.Answers[2];
            btnAnswer4.Text = q.Answers[3];
        }

        private Question GetQuestion(int level)
        {
            var questionsWithLevel = questions.Where(q => q.Level == level).ToList();
            return questionsWithLevel[rnd.Next(questionsWithLevel.Count)];
        }

        private void NextStep()
        {
            Button[] btns = new Button[] { btnAnswer1, btnAnswer2, btnAnswer3, btnAnswer4 };
            foreach (Button btn in btns)
            {
                btn.Enabled = true;
            }
            level++;
            currentQuestion = GetQuestion(level);
            ShowQuestion(currentQuestion);
            IstLevel.SelectedIndex = IstLevel.Items.Count - level;
            ShowLevel();
        }

        private void ShowLevel()
        {
            currentLevel.Text = $"Текущий уровень: {level}";
        }

        private void startGame()
        {
            resetParameters();
            NextStep();
        }

        private void finishGame()
        {
            string str;
            if (level == 15)
            {
                str = "Поздравляем, Вы выиграли 3 миллиона рублей!\nИгра Окончена!\nХотите попробовать еще раз?";
            } else
            {
                str = "Неверный ответ!\nИгра окончена!\nХотите попробовать еще раз?";
            }
            Form2 testDialog = new Form2(str);
            testDialog.ShowDialog();
            if (testDialog.GetResult() == 1)
            {
                testDialog.Close();
                startGame();
            } else if (testDialog.GetResult() == -1)
            {
                Application.Exit();
            }
           
        }

        private void resetParameters()
        {
            level = 0;
            ok = true;
            MissStep.Enabled = true;
            MissStep.Text = "Пропустить ход";
            btnFiftyFifty.Enabled = true;
            btnFiftyFifty.Text = "50/50";
            callFriend.Enabled = true;
            callFriend.Text = "Звонок другу";
            hallHelp.Enabled = true;
            hallHelp.Text = "Помощь зала";
            tryAnswer.Enabled = true;
            tryAnswer.Text = "Право на ошибку";

        }

        private void IstLevel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonsM.Add(this.btnAnswer1);
            buttonsM.Add(this.btnAnswer2);
            buttonsM.Add(this.btnAnswer3);
            buttonsM.Add(this.btnAnswer4);
        }

        private async void btnAnswer1_Click(object sender, EventArgs e)
        {
            MetroButton button = (MetroButton)sender;
            foreach (var item in buttonsM)
            {
                if (item.Name != button.Name)
                    item.Enabled = false;
            }
            button.Style = MetroColorStyle.White;
            await Task.Delay(1200);
            if (currentQuestion.RightAnswer == int.Parse(button.Tag.ToString()))
            {
                button.Style = MetroColorStyle.Green;
                await Task.Delay(1000);
                button.Style = MetroColorStyle.Purple;
                NextStep();
            } else
            {
                button.Style = MetroColorStyle.Red;
                await Task.Delay(1000);
                if (tryAnswer.Enabled == false && ok == true)
                {
                    level--;
                    NextStep();
                    ok = false;

                } else
                {
                    finishGame();
                }
                
                button.Style = MetroColorStyle.Purple;
            }
        }


        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFiftyFifty_Click(object sender, EventArgs e)
        {
            Button[] btns = new Button[] { btnAnswer1, btnAnswer2, btnAnswer3, btnAnswer4 };
            int count = 0;
            while (count < 2)
            {
                int n = rnd.Next(4);
                int answer = int.Parse(btns[n].Tag.ToString());
                if (answer != currentQuestion.RightAnswer && btns[n].Enabled)
                {
                    btns[n].Enabled = false;
                    count++;
                }
            }
            btnFiftyFifty.Text = "Использовано";
            btnFiftyFifty.Enabled = false;
        }
        

        private void MissStep_Click(object sender, EventArgs e)
        {
            currentQuestion = GetQuestion(level);
            ShowQuestion(currentQuestion);
            MissStep.Text = "Использовано";
            MissStep.Enabled = false;
        }

        private void callFriend_Click(object sender, EventArgs e)
        {
            int result = rnd.Next(4);
            switch (result)
            {
                case 1:
                    MessageBox.Show($"Звоним другу...\nЯ в этом не силен, ты же знаешь...Возможно правильный ответ \"{btnAnswer1.Text}\".");
                    break;
                case 2:
                    MessageBox.Show($"Звоним другу...\nТы позвонил куда надо! Я уверен что правильный ответ \"{currentQuestion.RightAnswer}\".");
                    break;
                case 3:
                    MessageBox.Show($"Звоним другу...\nИзвини, я сейчас не могу говорить, созвонимся позже.");
                    break;
                case 4:
                    MessageBox.Show($"Звоним другу...\nХмм, дай подумать...Наверное правильный ответ \"{btnAnswer2.Text}\" или \"{btnAnswer3.Text}\". Хотя и \"{btnAnswer4.Text}\" тоже подходит...Мой ответ \"{btnAnswer4.Text}\".");
                    break;
            }
            callFriend.Text = "Использовано";
            callFriend.Enabled = false;
        }

        private void hallHelp_Click(object sender, EventArgs e)
        {
            Form voiting = new Voiting(btnAnswer1.Text, btnAnswer2.Text, btnAnswer3.Text, btnAnswer4.Text, currentQuestion.RightAnswer);
            voiting.ShowDialog();

            hallHelp.Text = "Использовано";
            hallHelp.Enabled = false;
        }

        private void tryAnswer_Click(object sender, EventArgs e)
        {
            tryAnswer.Text = "Использовано";
            tryAnswer.Enabled = false;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
