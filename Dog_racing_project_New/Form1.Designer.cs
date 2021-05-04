
namespace Dog_racing_project_New
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.player3 = new System.Windows.Forms.Label();
            this.player2 = new System.Windows.Forms.Label();
            this.player1 = new System.Windows.Forms.Label();
            this.bet_result = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AmountBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PlayerBox = new System.Windows.Forms.ComboBox();
            this.dogBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.race_btn = new System.Windows.Forms.Button();
            this.bet_btn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.Dog_no2 = new System.Windows.Forms.PictureBox();
            this.Dog_no3 = new System.Windows.Forms.PictureBox();
            this.Dog_no4 = new System.Windows.Forms.PictureBox();
            this.Dog_no1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog_no2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog_no3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog_no4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog_no1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // player3
            // 
            this.player3.AutoSize = true;
            this.player3.Location = new System.Drawing.Point(65, 332);
            this.player3.Name = "player3";
            this.player3.Size = new System.Drawing.Size(65, 13);
            this.player3.TabIndex = 31;
            this.player3.Text = "Player 3 has";
            // 
            // player2
            // 
            this.player2.AutoSize = true;
            this.player2.Location = new System.Drawing.Point(65, 304);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(65, 13);
            this.player2.TabIndex = 30;
            this.player2.Text = "Player 2 has";
            // 
            // player1
            // 
            this.player1.AutoSize = true;
            this.player1.Location = new System.Drawing.Point(65, 278);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(65, 13);
            this.player1.TabIndex = 29;
            this.player1.Text = "Player 1 has";
            // 
            // bet_result
            // 
            this.bet_result.AutoSize = true;
            this.bet_result.Location = new System.Drawing.Point(54, 243);
            this.bet_result.Name = "bet_result";
            this.bet_result.Size = new System.Drawing.Size(106, 13);
            this.bet_result.TabIndex = 28;
            this.bet_result.Text = "Player this betted on ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Bet Amount";
            // 
            // AmountBox
            // 
            this.AmountBox.FormattingEnabled = true;
            this.AmountBox.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50"});
            this.AmountBox.Location = new System.Drawing.Point(57, 195);
            this.AmountBox.Name = "AmountBox";
            this.AmountBox.Size = new System.Drawing.Size(121, 21);
            this.AmountBox.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Select Player";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Select Dog";
            // 
            // PlayerBox
            // 
            this.PlayerBox.FormattingEnabled = true;
            this.PlayerBox.Items.AddRange(new object[] {
            "Harry",
            "Henry",
            "Smith"});
            this.PlayerBox.Location = new System.Drawing.Point(57, 130);
            this.PlayerBox.Name = "PlayerBox";
            this.PlayerBox.Size = new System.Drawing.Size(121, 21);
            this.PlayerBox.TabIndex = 23;
            // 
            // dogBox
            // 
            this.dogBox.FormattingEnabled = true;
            this.dogBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.dogBox.Location = new System.Drawing.Point(57, 58);
            this.dogBox.Name = "dogBox";
            this.dogBox.Size = new System.Drawing.Size(121, 21);
            this.dogBox.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.race_btn);
            this.groupBox1.Controls.Add(this.bet_btn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.player3);
            this.groupBox1.Controls.Add(this.dogBox);
            this.groupBox1.Controls.Add(this.player2);
            this.groupBox1.Controls.Add(this.PlayerBox);
            this.groupBox1.Controls.Add(this.player1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.bet_result);
            this.groupBox1.Controls.Add(this.AmountBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(3, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 447);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Set Bet Here";
            // 
            // race_btn
            // 
            this.race_btn.BackColor = System.Drawing.Color.Red;
            this.race_btn.Enabled = false;
            this.race_btn.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.race_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.race_btn.Location = new System.Drawing.Point(50, 404);
            this.race_btn.Name = "race_btn";
            this.race_btn.Size = new System.Drawing.Size(128, 37);
            this.race_btn.TabIndex = 33;
            this.race_btn.Text = "Race";
            this.race_btn.UseVisualStyleBackColor = false;
            this.race_btn.Click += new System.EventHandler(this.race_btn_Click);
            // 
            // bet_btn
            // 
            this.bet_btn.BackColor = System.Drawing.Color.Red;
            this.bet_btn.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bet_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bet_btn.Location = new System.Drawing.Point(49, 352);
            this.bet_btn.Name = "bet_btn";
            this.bet_btn.Size = new System.Drawing.Size(129, 46);
            this.bet_btn.TabIndex = 32;
            this.bet_btn.Text = "Set Bet";
            this.bet_btn.UseVisualStyleBackColor = false;
            this.bet_btn.Click += new System.EventHandler(this.bet_btn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox10);
            this.groupBox2.Controls.Add(this.pictureBox9);
            this.groupBox2.Controls.Add(this.pictureBox8);
            this.groupBox2.Controls.Add(this.pictureBox7);
            this.groupBox2.Controls.Add(this.pictureBox6);
            this.groupBox2.Controls.Add(this.Dog_no2);
            this.groupBox2.Controls.Add(this.Dog_no3);
            this.groupBox2.Controls.Add(this.Dog_no4);
            this.groupBox2.Controls.Add(this.Dog_no1);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(230, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(771, 485);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ground";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Black;
            this.pictureBox10.Location = new System.Drawing.Point(146, 446);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(555, 10);
            this.pictureBox10.TabIndex = 19;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Black;
            this.pictureBox9.Location = new System.Drawing.Point(146, 334);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(555, 10);
            this.pictureBox9.TabIndex = 18;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Black;
            this.pictureBox8.Location = new System.Drawing.Point(146, 208);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(555, 10);
            this.pictureBox8.TabIndex = 17;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Black;
            this.pictureBox7.Location = new System.Drawing.Point(146, 85);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(555, 10);
            this.pictureBox7.TabIndex = 16;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Black;
            this.pictureBox6.Location = new System.Drawing.Point(719, -2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(10, 481);
            this.pictureBox6.TabIndex = 15;
            this.pictureBox6.TabStop = false;
            // 
            // Dog_no2
            // 
            this.Dog_no2.Image = global::Dog_racing_project_New.Properties.Resources.dogno2;
            this.Dog_no2.Location = new System.Drawing.Point(19, 128);
            this.Dog_no2.Name = "Dog_no2";
            this.Dog_no2.Size = new System.Drawing.Size(100, 60);
            this.Dog_no2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dog_no2.TabIndex = 14;
            this.Dog_no2.TabStop = false;
            // 
            // Dog_no3
            // 
            this.Dog_no3.Image = global::Dog_racing_project_New.Properties.Resources.dogno3;
            this.Dog_no3.Location = new System.Drawing.Point(19, 249);
            this.Dog_no3.Name = "Dog_no3";
            this.Dog_no3.Size = new System.Drawing.Size(100, 58);
            this.Dog_no3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dog_no3.TabIndex = 13;
            this.Dog_no3.TabStop = false;
            // 
            // Dog_no4
            // 
            this.Dog_no4.Image = global::Dog_racing_project_New.Properties.Resources.dogno4;
            this.Dog_no4.Location = new System.Drawing.Point(19, 379);
            this.Dog_no4.Name = "Dog_no4";
            this.Dog_no4.Size = new System.Drawing.Size(100, 57);
            this.Dog_no4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dog_no4.TabIndex = 12;
            this.Dog_no4.TabStop = false;
            // 
            // Dog_no1
            // 
            this.Dog_no1.Image = global::Dog_racing_project_New.Properties.Resources.dogno1;
            this.Dog_no1.Location = new System.Drawing.Point(19, 19);
            this.Dog_no1.Name = "Dog_no1";
            this.Dog_no1.Size = new System.Drawing.Size(100, 55);
            this.Dog_no1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dog_no1.TabIndex = 11;
            this.Dog_no1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(146, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 481);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Dog_racing_project_New.Properties.Resources.bgforDogRace;
            this.ClientSize = new System.Drawing.Size(1002, 500);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog_no2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog_no3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog_no4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog_no1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label player3;
        private System.Windows.Forms.Label player2;
        private System.Windows.Forms.Label player1;
        private System.Windows.Forms.Label bet_result;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox AmountBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox PlayerBox;
        private System.Windows.Forms.ComboBox dogBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox Dog_no2;
        private System.Windows.Forms.PictureBox Dog_no3;
        private System.Windows.Forms.PictureBox Dog_no4;
        private System.Windows.Forms.PictureBox Dog_no1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button race_btn;
        private System.Windows.Forms.Button bet_btn;
        private System.Windows.Forms.Timer timer1;
    }
}

