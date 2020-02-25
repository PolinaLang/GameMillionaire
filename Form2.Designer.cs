namespace WhoWantsToBeAMillionaire
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.newGame = new MetroFramework.Controls.MetroButton();
            this.finGame = new MetroFramework.Controls.MetroButton();
            this.textBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newGame
            // 
            this.newGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newGame.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.newGame.Location = new System.Drawing.Point(23, 170);
            this.newGame.Name = "newGame";
            this.newGame.Size = new System.Drawing.Size(75, 31);
            this.newGame.TabIndex = 0;
            this.newGame.Text = "Новая игра";
            this.newGame.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.newGame.Click += new System.EventHandler(this.newGame_Click);
            // 
            // finGame
            // 
            this.finGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.finGame.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.finGame.Location = new System.Drawing.Point(144, 170);
            this.finGame.Name = "finGame";
            this.finGame.Size = new System.Drawing.Size(75, 31);
            this.finGame.TabIndex = 1;
            this.finGame.Text = "Выход";
            this.finGame.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.finGame.Click += new System.EventHandler(this.finGame_Click);
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox.Location = new System.Drawing.Point(43, 26);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(152, 119);
            this.textBox.TabIndex = 2;
            this.textBox.Text = "textBox";
            this.textBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 224);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.finGame);
            this.Controls.Add(this.newGame);
            this.Name = "Form2";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Tag = "1";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton newGame;
        private MetroFramework.Controls.MetroButton finGame;
        private System.Windows.Forms.Label textBox;
    }
}