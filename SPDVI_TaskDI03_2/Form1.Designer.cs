
namespace SPDVI_TaskDI03_2
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
            this.productImage = new System.Windows.Forms.PictureBox();
            this.confirmChoiceButton = new System.Windows.Forms.Button();
            this.productsTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.productImage)).BeginInit();
            this.SuspendLayout();
            // 
            // productImage
            // 
            this.productImage.Location = new System.Drawing.Point(59, 65);
            this.productImage.Margin = new System.Windows.Forms.Padding(4);
            this.productImage.Name = "productImage";
            this.productImage.Size = new System.Drawing.Size(364, 265);
            this.productImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.productImage.TabIndex = 0;
            this.productImage.TabStop = false;
            // 
            // confirmChoiceButton
            // 
            this.confirmChoiceButton.Location = new System.Drawing.Point(323, 357);
            this.confirmChoiceButton.Margin = new System.Windows.Forms.Padding(4);
            this.confirmChoiceButton.Name = "confirmChoiceButton";
            this.confirmChoiceButton.Size = new System.Drawing.Size(100, 28);
            this.confirmChoiceButton.TabIndex = 1;
            this.confirmChoiceButton.Text = "Confirm";
            this.confirmChoiceButton.UseVisualStyleBackColor = true;
            this.confirmChoiceButton.Click += new System.EventHandler(this.confirmChoiceButton_Click);
            // 
            // productsTB
            // 
            this.productsTB.Location = new System.Drawing.Point(59, 359);
            this.productsTB.Margin = new System.Windows.Forms.Padding(4);
            this.productsTB.Name = "productsTB";
            this.productsTB.Size = new System.Drawing.Size(255, 22);
            this.productsTB.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.productsTB);
            this.Controls.Add(this.confirmChoiceButton);
            this.Controls.Add(this.productImage);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.productImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox productImage;
        private System.Windows.Forms.Button confirmChoiceButton;
        private System.Windows.Forms.TextBox productsTB;
    }
}

