namespace hangman
{
    partial class Game
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
            this.back_button = new System.Windows.Forms.Button();
            this.leftLegImage = new System.Windows.Forms.PictureBox();
            this.rightLegImage = new System.Windows.Forms.PictureBox();
            this.leftArmImage = new System.Windows.Forms.PictureBox();
            this.rightArmImage = new System.Windows.Forms.PictureBox();
            this.torsoImage = new System.Windows.Forms.PictureBox();
            this.headImage = new System.Windows.Forms.PictureBox();
            this.input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.usedLettersLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.displayWordBox = new System.Windows.Forms.Label();
            this.tryAgainButton = new System.Windows.Forms.Button();
            this.gameOverLabel = new System.Windows.Forms.Label();
            this.langaugeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.leftLegImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightLegImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftArmImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightArmImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.torsoImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headImage)).BeginInit();
            this.SuspendLayout();
            // 
            // back_button
            // 
            this.back_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.back_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(203)))), ((int)(((byte)(213)))));
            this.back_button.Location = new System.Drawing.Point(3, 3);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(150, 50);
            this.back_button.TabIndex = 8;
            this.back_button.Text = "Go back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
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
            // input
            // 
            this.input.Location = new System.Drawing.Point(601, 160);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(24, 20);
            this.input.TabIndex = 57;
            this.input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "Used letters:";
            // 
            // usedLettersLabel
            // 
            this.usedLettersLabel.AutoSize = true;
            this.usedLettersLabel.Location = new System.Drawing.Point(56, 237);
            this.usedLettersLabel.Name = "usedLettersLabel";
            this.usedLettersLabel.Size = new System.Drawing.Size(0, 13);
            this.usedLettersLabel.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(534, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 13);
            this.label3.TabIndex = 60;
            this.label3.Text = "Type in a letter and press enter";
            // 
            // displayWordBox
            // 
            this.displayWordBox.AutoSize = true;
            this.displayWordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayWordBox.Location = new System.Drawing.Point(56, 129);
            this.displayWordBox.Name = "displayWordBox";
            this.displayWordBox.Size = new System.Drawing.Size(0, 26);
            this.displayWordBox.TabIndex = 61;
            // 
            // tryAgainButton
            // 
            this.tryAgainButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(203)))), ((int)(((byte)(213)))));
            this.tryAgainButton.Location = new System.Drawing.Point(283, 203);
            this.tryAgainButton.Name = "tryAgainButton";
            this.tryAgainButton.Size = new System.Drawing.Size(140, 46);
            this.tryAgainButton.TabIndex = 62;
            this.tryAgainButton.Text = "Try again?";
            this.tryAgainButton.UseVisualStyleBackColor = false;
            this.tryAgainButton.Visible = false;
            this.tryAgainButton.Click += new System.EventHandler(this.tryAgainButton_Click);
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.AutoSize = true;
            this.gameOverLabel.Location = new System.Drawing.Point(325, 167);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(51, 13);
            this.gameOverLabel.TabIndex = 63;
            this.gameOverLabel.Text = "You lose!";
            this.gameOverLabel.Visible = false;
            // 
            // langaugeLabel
            // 
            this.langaugeLabel.AutoSize = true;
            this.langaugeLabel.Location = new System.Drawing.Point(537, 43);
            this.langaugeLabel.Name = "langaugeLabel";
            this.langaugeLabel.Size = new System.Drawing.Size(61, 13);
            this.langaugeLabel.TabIndex = 64;
            this.langaugeLabel.Text = "Language: ";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.langaugeLabel);
            this.Controls.Add(this.gameOverLabel);
            this.Controls.Add(this.tryAgainButton);
            this.Controls.Add(this.displayWordBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.usedLettersLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input);
            this.Controls.Add(this.leftLegImage);
            this.Controls.Add(this.rightLegImage);
            this.Controls.Add(this.leftArmImage);
            this.Controls.Add(this.rightArmImage);
            this.Controls.Add(this.torsoImage);
            this.Controls.Add(this.headImage);
            this.Controls.Add(this.back_button);
            this.Name = "Game";
            this.Size = new System.Drawing.Size(710, 387);
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

        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.PictureBox leftLegImage;
        private System.Windows.Forms.PictureBox rightLegImage;
        private System.Windows.Forms.PictureBox leftArmImage;
        private System.Windows.Forms.PictureBox rightArmImage;
        private System.Windows.Forms.PictureBox torsoImage;
        private System.Windows.Forms.PictureBox headImage;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label usedLettersLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label displayWordBox;
        private System.Windows.Forms.Button tryAgainButton;
        private System.Windows.Forms.Label gameOverLabel;
        private System.Windows.Forms.Label langaugeLabel;
    }
}
