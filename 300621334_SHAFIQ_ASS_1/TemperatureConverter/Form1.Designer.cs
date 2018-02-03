namespace TemperatureConverter
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
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblF = new System.Windows.Forms.Label();
            this.convertToF = new System.Windows.Forms.Button();
            this.convertToC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(117, 24);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(100, 22);
            this.txtC.TabIndex = 0;
            // 
            // txtF
            // 
            this.txtF.Location = new System.Drawing.Point(117, 137);
            this.txtF.Name = "txtF";
            this.txtF.Size = new System.Drawing.Size(100, 22);
            this.txtF.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Celcius";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fahrenheit";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(402, 142);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(46, 17);
            this.lblC.TabIndex = 4;
            this.lblC.Text = "label3";
            // 
            // lblF
            // 
            this.lblF.AutoSize = true;
            this.lblF.Location = new System.Drawing.Point(402, 29);
            this.lblF.Name = "lblF";
            this.lblF.Size = new System.Drawing.Size(46, 17);
            this.lblF.TabIndex = 5;
            this.lblF.Text = "label4";
            // 
            // convertToF
            // 
            this.convertToF.Location = new System.Drawing.Point(235, 15);
            this.convertToF.Name = "convertToF";
            this.convertToF.Size = new System.Drawing.Size(122, 43);
            this.convertToF.TabIndex = 6;
            this.convertToF.Text = "Convert to F";
            this.convertToF.UseVisualStyleBackColor = true;
            this.convertToF.Click += new System.EventHandler(this.convertToF_Click);
            // 
            // convertToC
            // 
            this.convertToC.Location = new System.Drawing.Point(235, 125);
            this.convertToC.Name = "convertToC";
            this.convertToC.Size = new System.Drawing.Size(122, 46);
            this.convertToC.TabIndex = 7;
            this.convertToC.Text = "Convert to C";
            this.convertToC.UseVisualStyleBackColor = true;
            this.convertToC.Click += new System.EventHandler(this.convertToC_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 253);
            this.Controls.Add(this.convertToC);
            this.Controls.Add(this.convertToF);
            this.Controls.Add(this.lblF);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtF);
            this.Controls.Add(this.txtC);
            this.Name = "Form1";
            this.Text = "TemperatureConverter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblF;
        private System.Windows.Forms.Button convertToF;
        private System.Windows.Forms.Button convertToC;
    }
}

