namespace hangman
{
    partial class MainMenu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.quit_button = new System.Windows.Forms.Button();
            this.settings_button = new System.Windows.Forms.Button();
            this.char_button = new System.Windows.Forms.Button();
            this.play_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.leftLegImage = new System.Windows.Forms.PictureBox();
            this.rightLegImage = new System.Windows.Forms.PictureBox();
            this.leftArmImage = new System.Windows.Forms.PictureBox();
            this.rightArmImage = new System.Windows.Forms.PictureBox();
            this.torsoImage = new System.Windows.Forms.PictureBox();
            this.headImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftLegImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightLegImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftArmImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightArmImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.torsoImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headImage)).BeginInit();
            this.SuspendLayout();
            // 
            // quit_button
            // 
            this.quit_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(203)))), ((int)(((byte)(213)))));
            this.quit_button.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quit_button.Location = new System.Drawing.Point(3, 293);
            this.quit_button.Name = "quit_button";
            this.quit_button.Size = new System.Drawing.Size(150, 50);
            this.quit_button.TabIndex = 7;
            this.quit_button.Text = "Quit";
            this.quit_button.UseVisualStyleBackColor = false;
            this.quit_button.Click += new System.EventHandler(this.quit_button_Click);
            // 
            // settings_button
            // 
            this.settings_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(203)))), ((int)(((byte)(213)))));
            this.settings_button.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settings_button.Location = new System.Drawing.Point(3, 204);
            this.settings_button.Name = "settings_button";
            this.settings_button.Size = new System.Drawing.Size(150, 50);
            this.settings_button.TabIndex = 6;
            this.settings_button.Text = "Settings";
            this.settings_button.UseVisualStyleBackColor = false;
            this.settings_button.Click += new System.EventHandler(this.settings_button_Click);
            // 
            // char_button
            // 
            this.char_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(203)))), ((int)(((byte)(213)))));
            this.char_button.Font = new System.Drawing.Font("Ravie", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.char_button.Location = new System.Drawing.Point(3, 114);
            this.char_button.Name = "char_button";
            this.char_button.Size = new System.Drawing.Size(150, 50);
            this.char_button.TabIndex = 5;
            this.char_button.Text = "Select character";
            this.char_button.UseVisualStyleBackColor = false;
            this.char_button.Click += new System.EventHandler(this.char_button_Click);
            // 
            // play_button
            // 
            this.play_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.play_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(203)))), ((int)(((byte)(213)))));
            this.play_button.Font = new System.Drawing.Font("Ravie", 10F);
            this.play_button.Location = new System.Drawing.Point(3, 26);
            this.play_button.Name = "play_button";
            this.play_button.Size = new System.Drawing.Size(150, 50);
            this.play_button.TabIndex = 4;
            this.play_button.Text = "Play!";
            this.play_button.UseVisualStyleBackColor = false;
            this.play_button.Click += new System.EventHandler(this.play_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(524, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 30);
            this.label1.TabIndex = 57;
            this.label1.Text = "SaveMe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(483, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 22);
            this.label2.TabIndex = 58;
            this.label2.Text = "Are you ready to";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::hangman.Properties.Resources._53082594_368619943867074_5772997767416774656_n;
            this.pictureBox1.Location = new System.Drawing.Point(470, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // leftLegImage
            // 
            this.leftLegImage.Image = global::hangman.Properties.Resources.leftleg1;
            this.leftLegImage.Location = new System.Drawing.Point(255, 243);
            this.leftLegImage.Name = "leftLegImage";
            this.leftLegImage.Size = new System.Drawing.Size(100, 100);
            this.leftLegImage.TabIndex = 56;
            this.leftLegImage.TabStop = false;
            // 
            // rightLegImage
            // 
            this.rightLegImage.Image = global::hangman.Properties.Resources.rightleg1;
            this.rightLegImage.Location = new System.Drawing.Point(355, 243);
            this.rightLegImage.Name = "rightLegImage";
            this.rightLegImage.Size = new System.Drawing.Size(100, 100);
            this.rightLegImage.TabIndex = 55;
            this.rightLegImage.TabStop = false;
            // 
            // leftArmImage
            // 
            this.leftArmImage.Image = global::hangman.Properties.Resources.leftarm1;
            this.leftArmImage.Location = new System.Drawing.Point(268, 143);
            this.leftArmImage.Name = "leftArmImage";
            this.leftArmImage.Size = new System.Drawing.Size(60, 100);
            this.leftArmImage.TabIndex = 54;
            this.leftArmImage.TabStop = false;
            // 
            // rightArmImage
            // 
            this.rightArmImage.Image = global::hangman.Properties.Resources.rightarm1;
            this.rightArmImage.Location = new System.Drawing.Point(382, 143);
            this.rightArmImage.Name = "rightArmImage";
            this.rightArmImage.Size = new System.Drawing.Size(60, 100);
            this.rightArmImage.TabIndex = 53;
            this.rightArmImage.TabStop = false;
            // 
            // torsoImage
            // 
            this.torsoImage.Image = global::hangman.Properties.Resources.torso1;
            this.torsoImage.Location = new System.Drawing.Point(325, 143);
            this.torsoImage.Name = "torsoImage";
            this.torsoImage.Size = new System.Drawing.Size(60, 100);
            this.torsoImage.TabIndex = 52;
            this.torsoImage.TabStop = false;
            // 
            // headImage
            // 
            this.headImage.Image = global::hangman.Properties.Resources.head1;
            this.headImage.Location = new System.Drawing.Point(302, 43);
            this.headImage.Name = "headImage";
            this.headImage.Size = new System.Drawing.Size(100, 100);
            this.headImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.headImage.TabIndex = 51;
            this.headImage.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.leftLegImage);
            this.Controls.Add(this.rightLegImage);
            this.Controls.Add(this.leftArmImage);
            this.Controls.Add(this.rightArmImage);
            this.Controls.Add(this.torsoImage);
            this.Controls.Add(this.headImage);
            this.Controls.Add(this.quit_button);
            this.Controls.Add(this.settings_button);
            this.Controls.Add(this.char_button);
            this.Controls.Add(this.play_button);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainMenu";
            this.Size = new System.Drawing.Size(710, 387);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftLegImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightLegImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftArmImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightArmImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.torsoImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button quit_button;
        private System.Windows.Forms.Button settings_button;
        private System.Windows.Forms.Button char_button;
        private System.Windows.Forms.Button play_button;
        private System.Windows.Forms.PictureBox leftLegImage;
        private System.Windows.Forms.PictureBox rightLegImage;
        private System.Windows.Forms.PictureBox leftArmImage;
        private System.Windows.Forms.PictureBox rightArmImage;
        private System.Windows.Forms.PictureBox torsoImage;
        private System.Windows.Forms.PictureBox headImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
