
namespace c_sharp_Tic_Tac_Toe
{
    partial class Setup_form
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
            this.player1settings_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // player1settings_label
            // 
            this.player1settings_label.AutoSize = true;
            this.player1settings_label.Location = new System.Drawing.Point(90, 45);
            this.player1settings_label.Name = "player1settings_label";
            this.player1settings_label.Size = new System.Drawing.Size(86, 13);
            this.player1settings_label.TabIndex = 0;
            this.player1settings_label.Text = "Player 1 Settings";
            this.player1settings_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Setup_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.player1settings_label);
            this.Name = "Setup_form";
            this.Text = "Character Setup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label player1settings_label;
    }
}

