namespace archive_all_images
{
    partial class Main
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
            this.textbox_filepath = new System.Windows.Forms.TextBox();
            this.button_start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_reset = new System.Windows.Forms.Button();
            this.progress_ = new System.Windows.Forms.ProgressBar();
            this.label_status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textbox_filepath
            // 
            this.textbox_filepath.Location = new System.Drawing.Point(12, 12);
            this.textbox_filepath.Name = "textbox_filepath";
            this.textbox_filepath.ReadOnly = true;
            this.textbox_filepath.ShortcutsEnabled = false;
            this.textbox_filepath.Size = new System.Drawing.Size(262, 22);
            this.textbox_filepath.TabIndex = 0;
            this.textbox_filepath.TabStop = false;
            this.textbox_filepath.Click += new System.EventHandler(this.textbox_filepath_Click);
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(179, 44);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(94, 28);
            this.button_start.TabIndex = 1;
            this.button_start.Text = "let\'s start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 2;
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(12, 44);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(94, 28);
            this.button_reset.TabIndex = 1;
            this.button_reset.Text = "reset folder";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // progress_
            // 
            this.progress_.Location = new System.Drawing.Point(12, 108);
            this.progress_.Name = "progress_";
            this.progress_.Size = new System.Drawing.Size(261, 23);
            this.progress_.TabIndex = 4;
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(12, 88);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(131, 17);
            this.label_status.TabIndex = 5;
            this.label_status.Text = "please select folder";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 143);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.progress_);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.textbox_filepath);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Archive Images";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textbox_filepath;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.ProgressBar progress_;
        private System.Windows.Forms.Label label_status;
    }
}

