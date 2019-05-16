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
            this.input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.usedLettersLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.displayWordBox = new System.Windows.Forms.Label();
            this.tryAgainButton = new System.Windows.Forms.Button();
            this.gameOverLabel = new System.Windows.Forms.Label();
            this.langaugeLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.leftLegImage = new System.Windows.Forms.PictureBox();
            this.rightLegImage = new System.Windows.Forms.PictureBox();
            this.leftArmImage = new System.Windows.Forms.PictureBox();
            this.rightArmImage = new System.Windows.Forms.PictureBox();
            this.torsoImage = new System.Windows.Forms.PictureBox();
            this.headImage = new System.Windows.Forms.PictureBox();
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
            this.back_button.FlatAppearance.BorderSize = 0;
            this.back_button.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_button.Font = new System.Drawing.Font("Ravie", 10F);
            this.back_button.Location = new System.Drawing.Point(0, 32);
            this.back_button.Margin = new System.Windows.Forms.Padding(4);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(200, 62);
            this.back_button.TabIndex = 8;
            this.back_button.Text = "Go back";
            this.back_button.UseVisualStyleBackColor = false;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // input
            // 
            this.input.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.input.Location = new System.Drawing.Point(26, 280);
            this.input.Margin = new System.Windows.Forms.Padding(4);
            this.input.MaxLength = 1;
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(164, 22);
            this.input.TabIndex = 57;
            this.input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 8F);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(603, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 19);
            this.label1.TabIndex = 58;
            this.label1.Text = "Used letters:";
            // 
            // usedLettersLabel
            // 
            this.usedLettersLabel.AutoSize = true;
            this.usedLettersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.usedLettersLabel.ForeColor = System.Drawing.Color.DimGray;
            this.usedLettersLabel.Location = new System.Drawing.Point(744, 97);
            this.usedLettersLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usedLettersLabel.Name = "usedLettersLabel";
            this.usedLettersLabel.Size = new System.Drawing.Size(0, 17);
            this.usedLettersLabel.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ravie", 7F);
            this.label3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Location = new System.Drawing.Point(35, 185);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 51);
            this.label3.TabIndex = 60;
            this.label3.Text = "Type in a letter \r\n         and \r\n    press enter";
            // 
            // displayWordBox
            // 
            this.displayWordBox.AutoSize = true;
            this.displayWordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayWordBox.Location = new System.Drawing.Point(762, 44);
            this.displayWordBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.displayWordBox.Name = "displayWordBox";
            this.displayWordBox.Size = new System.Drawing.Size(0, 31);
            this.displayWordBox.TabIndex = 61;
            // 
            // tryAgainButton
            // 
            this.tryAgainButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(203)))), ((int)(((byte)(213)))));
            this.tryAgainButton.FlatAppearance.BorderSize = 0;
            this.tryAgainButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tryAgainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tryAgainButton.Font = new System.Drawing.Font("Ravie", 10F);
            this.tryAgainButton.Location = new System.Drawing.Point(378, 217);
            this.tryAgainButton.Margin = new System.Windows.Forms.Padding(4);
            this.tryAgainButton.Name = "tryAgainButton";
            this.tryAgainButton.Size = new System.Drawing.Size(187, 57);
            this.tryAgainButton.TabIndex = 62;
            this.tryAgainButton.Text = "Try again?";
            this.tryAgainButton.UseVisualStyleBackColor = false;
            this.tryAgainButton.Visible = false;
            this.tryAgainButton.Click += new System.EventHandler(this.tryAgainButton_Click);
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.AutoSize = true;
            this.gameOverLabel.Font = new System.Drawing.Font("Ravie", 10F);
            this.gameOverLabel.ForeColor = System.Drawing.Color.Black;
            this.gameOverLabel.Location = new System.Drawing.Point(597, 217);
            this.gameOverLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(109, 22);
            this.gameOverLabel.TabIndex = 63;
            this.gameOverLabel.Text = "You lose!";
            this.gameOverLabel.Visible = false;
            // 
            // langaugeLabel
            // 
            this.langaugeLabel.AutoSize = true;
            this.langaugeLabel.Font = new System.Drawing.Font("Ravie", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.langaugeLabel.Location = new System.Drawing.Point(4, 447);
            this.langaugeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.langaugeLabel.Name = "langaugeLabel";
            this.langaugeLabel.Size = new System.Drawing.Size(78, 15);
            this.langaugeLabel.TabIndex = 64;
            this.langaugeLabel.Text = "Language: ";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.Location = new System.Drawing.Point(387, 426);
            this.errorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 17);
            this.errorLabel.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ravie", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(603, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 19);
            this.label2.TabIndex = 66;
            this.label2.Text = "Guess the word:";
            // 
            // leftLegImage
            // 
            this.leftLegImage.Image = global::hangman.Properties.Resources.leftleg1;
            this.leftLegImage.Location = new System.Drawing.Point(340, 299);
            this.leftLegImage.Margin = new System.Windows.Forms.Padding(4);
            this.leftLegImage.Name = "leftLegImage";
            this.leftLegImage.Size = new System.Drawing.Size(133, 123);
            this.leftLegImage.TabIndex = 56;
            this.leftLegImage.TabStop = false;
            // 
            // rightLegImage
            // 
            this.rightLegImage.Image = global::hangman.Properties.Resources.rightleg1;
            this.rightLegImage.Location = new System.Drawing.Point(473, 299);
            this.rightLegImage.Margin = new System.Windows.Forms.Padding(4);
            this.rightLegImage.Name = "rightLegImage";
            this.rightLegImage.Size = new System.Drawing.Size(133, 123);
            this.rightLegImage.TabIndex = 55;
            this.rightLegImage.TabStop = false;
            // 
            // leftArmImage
            // 
            this.leftArmImage.Image = global::hangman.Properties.Resources.leftarm1;
            this.leftArmImage.Location = new System.Drawing.Point(357, 176);
            this.leftArmImage.Margin = new System.Windows.Forms.Padding(4);
            this.leftArmImage.Name = "leftArmImage";
            this.leftArmImage.Size = new System.Drawing.Size(80, 123);
            this.leftArmImage.TabIndex = 54;
            this.leftArmImage.TabStop = false;
            // 
            // rightArmImage
            // 
            this.rightArmImage.Image = global::hangman.Properties.Resources.rightarm1;
            this.rightArmImage.Location = new System.Drawing.Point(509, 176);
            this.rightArmImage.Margin = new System.Windows.Forms.Padding(4);
            this.rightArmImage.Name = "rightArmImage";
            this.rightArmImage.Size = new System.Drawing.Size(80, 123);
            this.rightArmImage.TabIndex = 53;
            this.rightArmImage.TabStop = false;
            // 
            // torsoImage
            // 
            this.torsoImage.Image = global::hangman.Properties.Resources.torso1;
            this.torsoImage.Location = new System.Drawing.Point(433, 176);
            this.torsoImage.Margin = new System.Windows.Forms.Padding(4);
            this.torsoImage.Name = "torsoImage";
            this.torsoImage.Size = new System.Drawing.Size(80, 123);
            this.torsoImage.TabIndex = 52;
            this.torsoImage.TabStop = false;
            // 
            // headImage
            // 
            this.headImage.Image = global::hangman.Properties.Resources.head1;
            this.headImage.Location = new System.Drawing.Point(403, 53);
            this.headImage.Margin = new System.Windows.Forms.Padding(4);
            this.headImage.Name = "headImage";
            this.headImage.Size = new System.Drawing.Size(133, 123);
            this.headImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.headImage.TabIndex = 51;
            this.headImage.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.errorLabel);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Game";
            this.Size = new System.Drawing.Size(947, 476);
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
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label label2;
    }
}
