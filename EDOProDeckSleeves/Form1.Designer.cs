namespace EDOProDeckSleeves
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
            this.listBox_playerSleeve = new System.Windows.Forms.ListBox();
            this.listBox_opponentSleeve = new System.Windows.Forms.ListBox();
            this.pictureBox_player = new System.Windows.Forms.PictureBox();
            this.label_playerSleeve = new System.Windows.Forms.Label();
            this.label_opponentSleeve = new System.Windows.Forms.Label();
            this.pictureBox_opponent = new System.Windows.Forms.PictureBox();
            this.button_AddSleeve = new System.Windows.Forms.Button();
            this.button_resetToDefaultSleeve = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_opponent)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_playerSleeve
            // 
            this.listBox_playerSleeve.FormattingEnabled = true;
            this.listBox_playerSleeve.ItemHeight = 25;
            this.listBox_playerSleeve.Location = new System.Drawing.Point(12, 55);
            this.listBox_playerSleeve.Name = "listBox_playerSleeve";
            this.listBox_playerSleeve.Size = new System.Drawing.Size(623, 479);
            this.listBox_playerSleeve.TabIndex = 0;
            this.listBox_playerSleeve.SelectedIndexChanged += new System.EventHandler(this.listBox_playerSleeve_SelectedIndexChanged);
            // 
            // listBox_opponentSleeve
            // 
            this.listBox_opponentSleeve.FormattingEnabled = true;
            this.listBox_opponentSleeve.ItemHeight = 25;
            this.listBox_opponentSleeve.Location = new System.Drawing.Point(12, 580);
            this.listBox_opponentSleeve.Name = "listBox_opponentSleeve";
            this.listBox_opponentSleeve.Size = new System.Drawing.Size(623, 479);
            this.listBox_opponentSleeve.TabIndex = 1;
            this.listBox_opponentSleeve.SelectedIndexChanged += new System.EventHandler(this.listBox_opponentSleeve_SelectedIndexChanged);
            // 
            // pictureBox_player
            // 
            this.pictureBox_player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_player.Location = new System.Drawing.Point(646, 55);
            this.pictureBox_player.Name = "pictureBox_player";
            this.pictureBox_player.Size = new System.Drawing.Size(320, 467);
            this.pictureBox_player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_player.TabIndex = 2;
            this.pictureBox_player.TabStop = false;
            // 
            // label_playerSleeve
            // 
            this.label_playerSleeve.AutoSize = true;
            this.label_playerSleeve.Location = new System.Drawing.Point(13, 27);
            this.label_playerSleeve.Name = "label_playerSleeve";
            this.label_playerSleeve.Size = new System.Drawing.Size(145, 25);
            this.label_playerSleeve.TabIndex = 3;
            this.label_playerSleeve.Text = "Player Sleeve";
            // 
            // label_opponentSleeve
            // 
            this.label_opponentSleeve.AutoSize = true;
            this.label_opponentSleeve.Location = new System.Drawing.Point(13, 552);
            this.label_opponentSleeve.Name = "label_opponentSleeve";
            this.label_opponentSleeve.Size = new System.Drawing.Size(178, 25);
            this.label_opponentSleeve.TabIndex = 4;
            this.label_opponentSleeve.Text = "Opponent Sleeve";
            // 
            // pictureBox_opponent
            // 
            this.pictureBox_opponent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_opponent.Location = new System.Drawing.Point(646, 580);
            this.pictureBox_opponent.Name = "pictureBox_opponent";
            this.pictureBox_opponent.Size = new System.Drawing.Size(320, 467);
            this.pictureBox_opponent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_opponent.TabIndex = 5;
            this.pictureBox_opponent.TabStop = false;
            // 
            // button_AddSleeve
            // 
            this.button_AddSleeve.Location = new System.Drawing.Point(12, 1065);
            this.button_AddSleeve.Name = "button_AddSleeve";
            this.button_AddSleeve.Size = new System.Drawing.Size(266, 67);
            this.button_AddSleeve.TabIndex = 6;
            this.button_AddSleeve.Text = "Add Sleeve";
            this.button_AddSleeve.UseVisualStyleBackColor = true;
            this.button_AddSleeve.Click += new System.EventHandler(this.button_AddSleeve_Click);
            // 
            // button_resetToDefaultSleeve
            // 
            this.button_resetToDefaultSleeve.Location = new System.Drawing.Point(284, 1065);
            this.button_resetToDefaultSleeve.Name = "button_resetToDefaultSleeve";
            this.button_resetToDefaultSleeve.Size = new System.Drawing.Size(266, 67);
            this.button_resetToDefaultSleeve.TabIndex = 7;
            this.button_resetToDefaultSleeve.Text = "Reset to Default";
            this.button_resetToDefaultSleeve.UseVisualStyleBackColor = true;
            this.button_resetToDefaultSleeve.Click += new System.EventHandler(this.button_resetToDefaultSleeve_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(989, 1166);
            this.Controls.Add(this.button_resetToDefaultSleeve);
            this.Controls.Add(this.button_AddSleeve);
            this.Controls.Add(this.pictureBox_opponent);
            this.Controls.Add(this.label_opponentSleeve);
            this.Controls.Add(this.label_playerSleeve);
            this.Controls.Add(this.pictureBox_player);
            this.Controls.Add(this.listBox_opponentSleeve);
            this.Controls.Add(this.listBox_playerSleeve);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "EDOPro Sleeve Picker";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_opponent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_playerSleeve;
        private System.Windows.Forms.ListBox listBox_opponentSleeve;
        private System.Windows.Forms.PictureBox pictureBox_player;
        private System.Windows.Forms.Label label_playerSleeve;
        private System.Windows.Forms.Label label_opponentSleeve;
        private System.Windows.Forms.PictureBox pictureBox_opponent;
        private System.Windows.Forms.Button button_AddSleeve;
        private System.Windows.Forms.Button button_resetToDefaultSleeve;
    }
}

