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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox_playerSleeve = new System.Windows.Forms.ListBox();
            this.listBox_opponentSleeve = new System.Windows.Forms.ListBox();
            this.label_playerSleeve = new System.Windows.Forms.Label();
            this.label_opponentSleeve = new System.Windows.Forms.Label();
            this.button_AddSleeve = new System.Windows.Forms.Button();
            this.button_resetToDefaultSleeve = new System.Windows.Forms.Button();
            this.button_duel = new System.Windows.Forms.Button();
            this.pictureBox_opponent = new System.Windows.Forms.PictureBox();
            this.pictureBox_player = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_opponent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_player)).BeginInit();
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
            this.listBox_playerSleeve.SelectedIndexChanged += new System.EventHandler(this.ListBox_playerSleeve_SelectedIndexChanged);
            // 
            // listBox_opponentSleeve
            // 
            this.listBox_opponentSleeve.FormattingEnabled = true;
            this.listBox_opponentSleeve.ItemHeight = 25;
            this.listBox_opponentSleeve.Location = new System.Drawing.Point(12, 592);
            this.listBox_opponentSleeve.Name = "listBox_opponentSleeve";
            this.listBox_opponentSleeve.Size = new System.Drawing.Size(623, 479);
            this.listBox_opponentSleeve.TabIndex = 1;
            this.listBox_opponentSleeve.SelectedIndexChanged += new System.EventHandler(this.ListBox_opponentSleeve_SelectedIndexChanged);
            // 
            // label_playerSleeve
            // 
            this.label_playerSleeve.AutoSize = true;
            this.label_playerSleeve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_playerSleeve.Location = new System.Drawing.Point(12, 15);
            this.label_playerSleeve.Name = "label_playerSleeve";
            this.label_playerSleeve.Size = new System.Drawing.Size(209, 37);
            this.label_playerSleeve.TabIndex = 3;
            this.label_playerSleeve.Text = "Player Sleeve";
            // 
            // label_opponentSleeve
            // 
            this.label_opponentSleeve.AutoSize = true;
            this.label_opponentSleeve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_opponentSleeve.Location = new System.Drawing.Point(12, 552);
            this.label_opponentSleeve.Name = "label_opponentSleeve";
            this.label_opponentSleeve.Size = new System.Drawing.Size(261, 37);
            this.label_opponentSleeve.TabIndex = 4;
            this.label_opponentSleeve.Text = "Opponent Sleeve";
            // 
            // button_AddSleeve
            // 
            this.button_AddSleeve.Location = new System.Drawing.Point(12, 1087);
            this.button_AddSleeve.Name = "button_AddSleeve";
            this.button_AddSleeve.Size = new System.Drawing.Size(266, 67);
            this.button_AddSleeve.TabIndex = 6;
            this.button_AddSleeve.Text = "Add Sleeve";
            this.button_AddSleeve.UseVisualStyleBackColor = true;
            this.button_AddSleeve.Click += new System.EventHandler(this.Button_AddSleeve_Click);
            // 
            // button_resetToDefaultSleeve
            // 
            this.button_resetToDefaultSleeve.Location = new System.Drawing.Point(284, 1087);
            this.button_resetToDefaultSleeve.Name = "button_resetToDefaultSleeve";
            this.button_resetToDefaultSleeve.Size = new System.Drawing.Size(266, 67);
            this.button_resetToDefaultSleeve.TabIndex = 7;
            this.button_resetToDefaultSleeve.Text = "Reset to Default";
            this.button_resetToDefaultSleeve.UseVisualStyleBackColor = true;
            this.button_resetToDefaultSleeve.Click += new System.EventHandler(this.Button_resetToDefaultSleeve_Click);
            // 
            // button_duel
            // 
            this.button_duel.BackgroundImage = global::EDOProDeckSleeves.Properties.Resources.eye;
            this.button_duel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_duel.Location = new System.Drawing.Point(876, 1065);
            this.button_duel.Name = "button_duel";
            this.button_duel.Size = new System.Drawing.Size(90, 89);
            this.button_duel.TabIndex = 8;
            this.button_duel.UseVisualStyleBackColor = true;
            this.button_duel.Click += new System.EventHandler(this.Button_duel_Click);
            // 
            // pictureBox_opponent
            // 
            this.pictureBox_opponent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_opponent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_opponent.Location = new System.Drawing.Point(646, 592);
            this.pictureBox_opponent.Name = "pictureBox_opponent";
            this.pictureBox_opponent.Size = new System.Drawing.Size(320, 467);
            this.pictureBox_opponent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_opponent.TabIndex = 5;
            this.pictureBox_opponent.TabStop = false;
            // 
            // pictureBox_player
            // 
            this.pictureBox_player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_player.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_player.Location = new System.Drawing.Point(646, 55);
            this.pictureBox_player.Name = "pictureBox_player";
            this.pictureBox_player.Size = new System.Drawing.Size(320, 467);
            this.pictureBox_player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_player.TabIndex = 2;
            this.pictureBox_player.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(989, 1166);
            this.Controls.Add(this.button_duel);
            this.Controls.Add(this.button_resetToDefaultSleeve);
            this.Controls.Add(this.button_AddSleeve);
            this.Controls.Add(this.pictureBox_opponent);
            this.Controls.Add(this.label_opponentSleeve);
            this.Controls.Add(this.label_playerSleeve);
            this.Controls.Add(this.pictureBox_player);
            this.Controls.Add(this.listBox_opponentSleeve);
            this.Controls.Add(this.listBox_playerSleeve);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "EDOPro Sleeve Picker";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_opponent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_player)).EndInit();
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
        private System.Windows.Forms.Button button_duel;
    }
}

