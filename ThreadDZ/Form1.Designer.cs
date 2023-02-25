namespace ThreadDZ
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxSimple = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxFibonaci = new System.Windows.Forms.TextBox();
            this.buttonStopFibonaci = new System.Windows.Forms.Button();
            this.buttonPausesimple = new System.Windows.Forms.Button();
            this.buttonPauseFibonaci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxSimple
            // 
            this.textBoxSimple.Location = new System.Drawing.Point(341, 67);
            this.textBoxSimple.Name = "textBoxSimple";
            this.textBoxSimple.Size = new System.Drawing.Size(125, 27);
            this.textBoxSimple.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(191, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(638, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 3;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "первое задание";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "второе задание";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(191, 119);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 29);
            this.button3.TabIndex = 6;
            this.button3.Text = "Start";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBoxFibonaci
            // 
            this.textBoxFibonaci.Location = new System.Drawing.Point(341, 123);
            this.textBoxFibonaci.Name = "textBoxFibonaci";
            this.textBoxFibonaci.Size = new System.Drawing.Size(125, 27);
            this.textBoxFibonaci.TabIndex = 7;
            // 
            // buttonStopFibonaci
            // 
            this.buttonStopFibonaci.Location = new System.Drawing.Point(638, 119);
            this.buttonStopFibonaci.Name = "buttonStopFibonaci";
            this.buttonStopFibonaci.Size = new System.Drawing.Size(94, 29);
            this.buttonStopFibonaci.TabIndex = 8;
            this.buttonStopFibonaci.Text = "Stop";
            this.buttonStopFibonaci.UseVisualStyleBackColor = true;
            this.buttonStopFibonaci.Click += new System.EventHandler(this.buttonStopFibonaci_Click);
            // 
            // buttonPausesimple
            // 
            this.buttonPausesimple.Location = new System.Drawing.Point(784, 67);
            this.buttonPausesimple.Name = "buttonPausesimple";
            this.buttonPausesimple.Size = new System.Drawing.Size(94, 29);
            this.buttonPausesimple.TabIndex = 10;
            this.buttonPausesimple.Text = "Pause";
            this.buttonPausesimple.UseVisualStyleBackColor = true;
            this.buttonPausesimple.Click += new System.EventHandler(this.buttonPausesimple_Click);
            // 
            // buttonPauseFibonaci
            // 
            this.buttonPauseFibonaci.Location = new System.Drawing.Point(784, 119);
            this.buttonPauseFibonaci.Name = "buttonPauseFibonaci";
            this.buttonPauseFibonaci.Size = new System.Drawing.Size(94, 29);
            this.buttonPauseFibonaci.TabIndex = 11;
            this.buttonPauseFibonaci.Text = "Pause";
            this.buttonPauseFibonaci.UseVisualStyleBackColor = true;
            this.buttonPauseFibonaci.Click += new System.EventHandler(this.buttonPauseFibonaci_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 450);
            this.Controls.Add(this.buttonPauseFibonaci);
            this.Controls.Add(this.buttonPausesimple);
            this.Controls.Add(this.buttonStopFibonaci);
            this.Controls.Add(this.textBoxFibonaci);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxSimple);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox textBoxSimple;
        private Button button1;
        private Button button2;
        private Button buttonSimple;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Button button3;
        private TextBox textBoxFibonaci;
        private Button buttonStopFibonaci;
        private Button buttonPausesimple;
        private Button buttonPauseFibonaci;
    }
}