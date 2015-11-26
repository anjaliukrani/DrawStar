namespace DrawStar
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
            this.drawButton = new System.Windows.Forms.Button();
            this.xLabel = new System.Windows.Forms.Label();
            this.yLabel = new System.Windows.Forms.Label();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.xInput = new System.Windows.Forms.TextBox();
            this.sizeInput = new System.Windows.Forms.TextBox();
            this.yInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // drawButton
            // 
            this.drawButton.Location = new System.Drawing.Point(590, 83);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(82, 23);
            this.drawButton.TabIndex = 0;
            this.drawButton.Text = "Draw";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.ForeColor = System.Drawing.Color.Yellow;
            this.xLabel.Location = new System.Drawing.Point(556, 5);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(14, 13);
            this.xLabel.TabIndex = 1;
            this.xLabel.Text = "X";
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.ForeColor = System.Drawing.Color.Yellow;
            this.yLabel.Location = new System.Drawing.Point(556, 34);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(14, 13);
            this.yLabel.TabIndex = 2;
            this.yLabel.Text = "Y";
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.ForeColor = System.Drawing.Color.Yellow;
            this.sizeLabel.Location = new System.Drawing.Point(522, 60);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(62, 13);
            this.sizeLabel.TabIndex = 3;
            this.sizeLabel.Text = "Size (pixels)";
            // 
            // xInput
            // 
            this.xInput.Location = new System.Drawing.Point(590, 2);
            this.xInput.Name = "xInput";
            this.xInput.Size = new System.Drawing.Size(82, 20);
            this.xInput.TabIndex = 0;
            // 
            // sizeInput
            // 
            this.sizeInput.Location = new System.Drawing.Point(590, 57);
            this.sizeInput.Name = "sizeInput";
            this.sizeInput.Size = new System.Drawing.Size(82, 20);
            this.sizeInput.TabIndex = 4;
            // 
            // yInput
            // 
            this.yInput.Location = new System.Drawing.Point(590, 27);
            this.yInput.Name = "yInput";
            this.yInput.Size = new System.Drawing.Size(82, 20);
            this.yInput.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.yInput);
            this.Controls.Add(this.sizeInput);
            this.Controls.Add(this.xInput);
            this.Controls.Add(this.sizeLabel);
            this.Controls.Add(this.yLabel);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.drawButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.TextBox xInput;
        private System.Windows.Forms.TextBox sizeInput;
        private System.Windows.Forms.TextBox yInput;
    }
}

