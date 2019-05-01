namespace hangman
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
            this.play_button = new System.Windows.Forms.Button();
            this.char_button = new System.Windows.Forms.Button();
            this.settings_button = new System.Windows.Forms.Button();
            this.quit_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // play_button
            // 
            this.play_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.play_button.Location = new System.Drawing.Point(12, 12);
            this.play_button.Name = "play_button";
            this.play_button.Size = new System.Drawing.Size(150, 50);
            this.play_button.TabIndex = 0;
            this.play_button.Text = "Play!";
            this.play_button.UseVisualStyleBackColor = true;
            this.play_button.Click += new System.EventHandler(this.play_button_Click);
            // 
            // char_button
            // 
            this.char_button.Location = new System.Drawing.Point(12, 68);
            this.char_button.Name = "char_button";
            this.char_button.Size = new System.Drawing.Size(150, 50);
            this.char_button.TabIndex = 1;
            this.char_button.Text = "Select character";
            this.char_button.UseVisualStyleBackColor = true;
            this.char_button.Click += new System.EventHandler(this.char_button_Click);
            // 
            // settings_button
            // 
            this.settings_button.Location = new System.Drawing.Point(12, 124);
            this.settings_button.Name = "settings_button";
            this.settings_button.Size = new System.Drawing.Size(150, 50);
            this.settings_button.TabIndex = 2;
            this.settings_button.Text = "Settings";
            this.settings_button.UseVisualStyleBackColor = true;
            this.settings_button.Click += new System.EventHandler(this.settings_button_Click);
            // 
            // quit_button
            // 
            this.quit_button.Location = new System.Drawing.Point(12, 180);
            this.quit_button.Name = "quit_button";
            this.quit_button.Size = new System.Drawing.Size(150, 50);
            this.quit_button.TabIndex = 3;
            this.quit_button.Text = "Quit";
            this.quit_button.UseVisualStyleBackColor = true;
            this.quit_button.Click += new System.EventHandler(this.quit_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.quit_button);
            this.Controls.Add(this.settings_button);
            this.Controls.Add(this.char_button);
            this.Controls.Add(this.play_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button play_button;
        private System.Windows.Forms.Button char_button;
        private System.Windows.Forms.Button settings_button;
        private System.Windows.Forms.Button quit_button;
    }
}

