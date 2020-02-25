using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace WhoWantsToBeAMillionaire
{
    public partial class Voiting : MetroForm
    {
        private Random rnd = new Random();
        int right;
        public Voiting(string str1, string str2, string str3, string str4, int rightAnswer)
        {
            InitializeComponent();
            this.ControlBox = false;
            label1.Text = str1;
            label2.Text = str2;
            label3.Text = str3;
            label4.Text = str4;
            right = rightAnswer;
        }

        private void voiting_Load(object sender, EventArgs e)
        {
            int a = rnd.Next(35, 60);
            int b = rnd.Next(1, 100 - a);
            int c = rnd.Next(1, 100 - a - b);
            int d = 100 - a - b - c;
                
            answer1.Value = a;
            textBox1.Text = $"{a}%";
            answer2.Value = b;
            textBox2.Text = $"{b}%";
            answer3.Value = c;
            textBox3.Text = $"{c}%";
            answer4.Value = d;
            textBox4.Text = $"{d}%";

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
