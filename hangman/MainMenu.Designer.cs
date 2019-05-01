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
            this.SuspendLayout();
            // 
            // quit_button
            // 
            this.quit_button.Location = new System.Drawing.Point(3, 171);
            this.quit_button.Name = "quit_button";
            this.quit_button.Size = new System.Drawing.Size(150, 50);
            this.quit_button.TabIndex = 7;
            this.quit_button.Text = "Quit";
            this.quit_button.UseVisualStyleBackColor = true;
            this.quit_button.Click += new System.EventHandler(this.quit_button_Click);
            // 
            // settings_button
            // 
            this.settings_button.Location = new System.Drawing.Point(3, 115);
            this.settings_button.Name = "settings_button";
            this.settings_button.Size = new System.Drawing.Size(150, 50);
            this.settings_button.TabIndex = 6;
            this.settings_button.Text = "Settings";
            this.settings_button.UseVisualStyleBackColor = true;
            this.settings_button.Click += new System.EventHandler(this.settings_button_Click);
            // 
            // char_button
            // 
            this.char_button.Location = new System.Drawing.Point(3, 59);
            this.char_button.Name = "char_button";
            this.char_button.Size = new System.Drawing.Size(150, 50);
            this.char_button.TabIndex = 5;
            this.char_button.Text = "Select character";
            this.char_button.UseVisualStyleBackColor = true;
            this.char_button.Click += new System.EventHandler(this.char_button_Click);
            // 
            // play_button
            // 
            this.play_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.play_button.Location = new System.Drawing.Point(3, 3);
            this.play_button.Name = "play_button";
            this.play_button.Size = new System.Drawing.Size(150, 50);
            this.play_button.TabIndex = 4;
            this.play_button.Text = "Play!";
            this.play_button.UseVisualStyleBackColor = true;
            this.play_button.Click += new System.EventHandler(this.play_button_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.quit_button);
            this.Controls.Add(this.settings_button);
            this.Controls.Add(this.char_button);
            this.Controls.Add(this.play_button);
            this.Name = "MainMenu";
            this.Size = new System.Drawing.Size(710, 387);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button quit_button;
        private System.Windows.Forms.Button settings_button;
        private System.Windows.Forms.Button char_button;
        private System.Windows.Forms.Button play_button;
    }
}
