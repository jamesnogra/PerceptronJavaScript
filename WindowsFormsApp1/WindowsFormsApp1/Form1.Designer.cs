namespace WindowsFormsApp1
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
            this.trainButton = new System.Windows.Forms.Button();
            this.errorText = new System.Windows.Forms.Label();
            this.epochsText = new System.Windows.Forms.Label();
            this.testButton = new System.Windows.Forms.Button();
            this.outputText = new System.Windows.Forms.Label();
            this.testInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // trainButton
            // 
            this.trainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainButton.Location = new System.Drawing.Point(13, 13);
            this.trainButton.Name = "trainButton";
            this.trainButton.Size = new System.Drawing.Size(314, 62);
            this.trainButton.TabIndex = 0;
            this.trainButton.Text = "Train";
            this.trainButton.UseVisualStyleBackColor = true;
            this.trainButton.Click += new System.EventHandler(this.trainButton_Click);
            // 
            // errorText
            // 
            this.errorText.AutoSize = true;
            this.errorText.Location = new System.Drawing.Point(13, 82);
            this.errorText.Name = "errorText";
            this.errorText.Size = new System.Drawing.Size(46, 13);
            this.errorText.TabIndex = 1;
            this.errorText.Text = "Errors: 0";
            // 
            // epochsText
            // 
            this.epochsText.AutoSize = true;
            this.epochsText.Location = new System.Drawing.Point(13, 106);
            this.epochsText.Name = "epochsText";
            this.epochsText.Size = new System.Drawing.Size(55, 13);
            this.epochsText.TabIndex = 2;
            this.epochsText.Text = "Epochs: 0";
            this.epochsText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // testButton
            // 
            this.testButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.testButton.Location = new System.Drawing.Point(13, 133);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(314, 47);
            this.testButton.TabIndex = 3;
            this.testButton.Text = "TEST";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // outputText
            // 
            this.outputText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputText.AutoSize = true;
            this.outputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputText.Location = new System.Drawing.Point(12, 221);
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(24, 25);
            this.outputText.TabIndex = 4;
            this.outputText.Text = "[]";
            this.outputText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // testInput
            // 
            this.testInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testInput.Location = new System.Drawing.Point(13, 187);
            this.testInput.Name = "testInput";
            this.testInput.Size = new System.Drawing.Size(314, 31);
            this.testInput.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 259);
            this.Controls.Add(this.testInput);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.epochsText);
            this.Controls.Add(this.errorText);
            this.Controls.Add(this.trainButton);
            this.Name = "Form1";
            this.Text = "Perceptron Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button trainButton;
        private System.Windows.Forms.Label errorText;
        private System.Windows.Forms.Label epochsText;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.Label outputText;
        private System.Windows.Forms.TextBox testInput;
    }
}

