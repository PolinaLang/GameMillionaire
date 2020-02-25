using MetroFramework;
using MetroFramework.Forms;

namespace WhoWantsToBeAMillionaire
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAnswer3 = new MetroFramework.Controls.MetroButton();
            this.btnAnswer1 = new MetroFramework.Controls.MetroButton();
            this.btnAnswer2 = new MetroFramework.Controls.MetroButton();
            this.btnAnswer4 = new MetroFramework.Controls.MetroButton();
            this.IstLevel = new System.Windows.Forms.ListBox();
            this.btnFiftyFifty = new MetroFramework.Controls.MetroButton();
            this.MissStep = new MetroFramework.Controls.MetroButton();
            this.callFriend = new MetroFramework.Controls.MetroButton();
            this.hallHelp = new MetroFramework.Controls.MetroButton();
            this.currentLevel = new MetroFramework.Controls.MetroTextBox();
            this.IblQuestion = new System.Windows.Forms.Label();
            this.tryAnswer = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.close = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAnswer3
            // 
            this.btnAnswer3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnswer3.Highlight = true;
            this.btnAnswer3.Location = new System.Drawing.Point(159, 408);
            this.btnAnswer3.Name = "btnAnswer3";
            this.btnAnswer3.Size = new System.Drawing.Size(243, 36);
            this.btnAnswer3.Style = MetroFramework.MetroColorStyle.Purple;
            this.btnAnswer3.TabIndex = 3;
            this.btnAnswer3.Tag = "3";
            this.btnAnswer3.Text = "btnAnswer3";
            this.btnAnswer3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnAnswer3.Click += new System.EventHandler(this.btnAnswer1_Click);
            // 
            // btnAnswer1
            // 
            this.btnAnswer1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnswer1.Highlight = true;
            this.btnAnswer1.Location = new System.Drawing.Point(159, 341);
            this.btnAnswer1.Name = "btnAnswer1";
            this.btnAnswer1.Size = new System.Drawing.Size(243, 36);
            this.btnAnswer1.Style = MetroFramework.MetroColorStyle.Purple;
            this.btnAnswer1.TabIndex = 4;
            this.btnAnswer1.Tag = "1";
            this.btnAnswer1.Text = "btnAnswer1";
            this.btnAnswer1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnAnswer1.Click += new System.EventHandler(this.btnAnswer1_Click);
            // 
            // btnAnswer2
            // 
            this.btnAnswer2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnswer2.Highlight = true;
            this.btnAnswer2.Location = new System.Drawing.Point(444, 341);
            this.btnAnswer2.Name = "btnAnswer2";
            this.btnAnswer2.Size = new System.Drawing.Size(243, 36);
            this.btnAnswer2.Style = MetroFramework.MetroColorStyle.Purple;
            this.btnAnswer2.TabIndex = 2;
            this.btnAnswer2.Tag = "2";
            this.btnAnswer2.Text = "btnAnswer2";
            this.btnAnswer2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnAnswer2.Click += new System.EventHandler(this.btnAnswer1_Click);
            // 
            // btnAnswer4
            // 
            this.btnAnswer4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnswer4.Highlight = true;
            this.btnAnswer4.Location = new System.Drawing.Point(444, 408);
            this.btnAnswer4.Name = "btnAnswer4";
            this.btnAnswer4.Size = new System.Drawing.Size(243, 36);
            this.btnAnswer4.Style = MetroFramework.MetroColorStyle.Purple;
            this.btnAnswer4.TabIndex = 6;
            this.btnAnswer4.Tag = "4";
            this.btnAnswer4.Text = "btnAnswer4";
            this.btnAnswer4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnAnswer4.Click += new System.EventHandler(this.btnAnswer1_Click);
            // 
            // IstLevel
            // 
            this.IstLevel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.IstLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IstLevel.Enabled = false;
            this.IstLevel.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IstLevel.ForeColor = System.Drawing.SystemColors.Window;
            this.IstLevel.FormattingEnabled = true;
            this.IstLevel.ItemHeight = 14;
            this.IstLevel.Items.AddRange(new object[] {
            "    3 000 000",
            "    1 500 000",
            "       800 000",
            "       400 000",
            "       200 000",
            "       100 000",
            "         50 000",
            "         25 000",
            "         15 000",
            "         10 000",
            "           5 000",
            "           3 000",
            "           2 000",
            "           1 000",
            "              500"});
            this.IstLevel.Location = new System.Drawing.Point(708, 70);
            this.IstLevel.Name = "IstLevel";
            this.IstLevel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.IstLevel.Size = new System.Drawing.Size(100, 212);
            this.IstLevel.TabIndex = 8;
            this.IstLevel.SelectedIndexChanged += new System.EventHandler(this.IstLevel_SelectedIndexChanged);
            // 
            // btnFiftyFifty
            // 
            this.btnFiftyFifty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiftyFifty.Location = new System.Drawing.Point(23, 28);
            this.btnFiftyFifty.Name = "btnFiftyFifty";
            this.btnFiftyFifty.Size = new System.Drawing.Size(200, 36);
            this.btnFiftyFifty.Style = MetroFramework.MetroColorStyle.Magenta;
            this.btnFiftyFifty.TabIndex = 9;
            this.btnFiftyFifty.Tag = "";
            this.btnFiftyFifty.Text = "50/50";
            this.btnFiftyFifty.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnFiftyFifty.Click += new System.EventHandler(this.btnFiftyFifty_Click);
            // 
            // MissStep
            // 
            this.MissStep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MissStep.Location = new System.Drawing.Point(23, 83);
            this.MissStep.Name = "MissStep";
            this.MissStep.Size = new System.Drawing.Size(200, 36);
            this.MissStep.Style = MetroFramework.MetroColorStyle.Magenta;
            this.MissStep.TabIndex = 11;
            this.MissStep.Tag = "";
            this.MissStep.Text = "Пропустить ход";
            this.MissStep.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MissStep.Click += new System.EventHandler(this.MissStep_Click);
            // 
            // callFriend
            // 
            this.callFriend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.callFriend.Location = new System.Drawing.Point(23, 139);
            this.callFriend.Name = "callFriend";
            this.callFriend.Size = new System.Drawing.Size(200, 36);
            this.callFriend.Style = MetroFramework.MetroColorStyle.Magenta;
            this.callFriend.TabIndex = 13;
            this.callFriend.Tag = "";
            this.callFriend.Text = "Звонок другу";
            this.callFriend.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.callFriend.Click += new System.EventHandler(this.callFriend_Click);
            // 
            // hallHelp
            // 
            this.hallHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hallHelp.Location = new System.Drawing.Point(23, 195);
            this.hallHelp.Name = "hallHelp";
            this.hallHelp.Size = new System.Drawing.Size(200, 36);
            this.hallHelp.Style = MetroFramework.MetroColorStyle.Magenta;
            this.hallHelp.TabIndex = 14;
            this.hallHelp.Tag = "";
            this.hallHelp.Text = "Помощь зала";
            this.hallHelp.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.hallHelp.Click += new System.EventHandler(this.hallHelp_Click);
            // 
            // currentLevel
            // 
            this.currentLevel.Enabled = false;
            this.currentLevel.Location = new System.Drawing.Point(608, 34);
            this.currentLevel.Name = "currentLevel";
            this.currentLevel.Size = new System.Drawing.Size(200, 30);
            this.currentLevel.Style = MetroFramework.MetroColorStyle.Magenta;
            this.currentLevel.TabIndex = 16;
            this.currentLevel.Text = "currentLevel";
            this.currentLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.currentLevel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // IblQuestion
            // 
            this.IblQuestion.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblQuestion.Location = new System.Drawing.Point(156, 292);
            this.IblQuestion.Name = "IblQuestion";
            this.IblQuestion.Size = new System.Drawing.Size(531, 43);
            this.IblQuestion.TabIndex = 19;
            this.IblQuestion.Text = "IblQuestion";
            this.IblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tryAnswer
            // 
            this.tryAnswer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tryAnswer.Location = new System.Drawing.Point(23, 253);
            this.tryAnswer.Name = "tryAnswer";
            this.tryAnswer.Size = new System.Drawing.Size(200, 36);
            this.tryAnswer.Style = MetroFramework.MetroColorStyle.Magenta;
            this.tryAnswer.TabIndex = 20;
            this.tryAnswer.Tag = "";
            this.tryAnswer.Text = "Право на ошибку";
            this.tryAnswer.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tryAnswer.Click += new System.EventHandler(this.tryAnswer_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WhoWantsToBeAMillionaire.Properties.Resources.pic;
            this.pictureBox1.Location = new System.Drawing.Point(294, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 248);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // close
            // 
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Location = new System.Drawing.Point(830, 10);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(24, 20);
            this.close.Style = MetroFramework.MetroColorStyle.Purple;
            this.close.TabIndex = 21;
            this.close.Text = "X";
            this.close.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(861, 467);
            this.Controls.Add(this.close);
            this.Controls.Add(this.tryAnswer);
            this.Controls.Add(this.IblQuestion);
            this.Controls.Add(this.currentLevel);
            this.Controls.Add(this.hallHelp);
            this.Controls.Add(this.callFriend);
            this.Controls.Add(this.MissStep);
            this.Controls.Add(this.btnFiftyFifty);
            this.Controls.Add(this.IstLevel);
            this.Controls.Add(this.btnAnswer4);
            this.Controls.Add(this.btnAnswer2);
            this.Controls.Add(this.btnAnswer1);
            this.Controls.Add(this.btnAnswer3);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "Form1";
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Form1";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton btnAnswer3;
        private MetroFramework.Controls.MetroButton btnAnswer1;
        private MetroFramework.Controls.MetroButton btnAnswer2;
        private MetroFramework.Controls.MetroButton btnAnswer4;
        private System.Windows.Forms.ListBox IstLevel;
        private MetroFramework.Controls.MetroButton btnFiftyFifty;
        private MetroFramework.Controls.MetroButton MissStep;
        private MetroFramework.Controls.MetroButton callFriend;
        private MetroFramework.Controls.MetroButton hallHelp;
        private MetroFramework.Controls.MetroTextBox currentLevel;
        private System.Windows.Forms.Label IblQuestion;
        private MetroFramework.Controls.MetroButton tryAnswer;
        private MetroFramework.Controls.MetroButton close;
    }
}

