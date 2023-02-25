namespace ThreadDZ
{
    partial class Simple
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
            this.SimpleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SimpleLabel
            // 
            this.SimpleLabel.AutoSize = true;
            this.SimpleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SimpleLabel.Location = new System.Drawing.Point(342, 164);
            this.SimpleLabel.Name = "SimpleLabel";
            this.SimpleLabel.Size = new System.Drawing.Size(65, 28);
            this.SimpleLabel.TabIndex = 0;
            this.SimpleLabel.Text = "label1";
            // 
            // Simple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SimpleLabel);
            this.Name = "Simple";
            this.Text = "Simple";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label SimpleLabel;
    }
}