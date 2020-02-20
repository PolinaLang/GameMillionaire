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
    public partial class Form2 : MetroForm
    {
        int result;
        public Form2(string str)
        {
            InitializeComponent();
            this.ControlBox = false;
            textBox.Text = str;
        }

        public int GetResult()
        {
            return result;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void newGame_Click(object sender, EventArgs e)
        {
            result = 1;
        }

        private void finGame_Click(object sender, EventArgs e)
        {
            result = -1;
        }

       
    }
}
