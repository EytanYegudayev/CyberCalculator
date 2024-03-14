namespace CyberCalculator
{
    partial class CyberCalculatorForm
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
            this.InputLbl = new System.Windows.Forms.Label();
            this.OutputLbl = new System.Windows.Forms.Label();
            this.RecipeLbl = new System.Windows.Forms.Label();
            this.CleanRecipLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InputLbl
            // 
            this.InputLbl.AutoSize = true;
            this.InputLbl.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputLbl.Location = new System.Drawing.Point(36, 46);
            this.InputLbl.Name = "InputLbl";
            this.InputLbl.Size = new System.Drawing.Size(87, 31);
            this.InputLbl.TabIndex = 0;
            this.InputLbl.Text = "Input:";
            // 
            // OutputLbl
            // 
            this.OutputLbl.AutoSize = true;
            this.OutputLbl.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputLbl.Location = new System.Drawing.Point(615, 46);
            this.OutputLbl.Name = "OutputLbl";
            this.OutputLbl.Size = new System.Drawing.Size(109, 31);
            this.OutputLbl.TabIndex = 1;
            this.OutputLbl.Text = "Output:";
            // 
            // RecipeLbl
            // 
            this.RecipeLbl.AutoSize = true;
            this.RecipeLbl.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecipeLbl.Location = new System.Drawing.Point(615, 258);
            this.RecipeLbl.Name = "RecipeLbl";
            this.RecipeLbl.Size = new System.Drawing.Size(101, 31);
            this.RecipeLbl.TabIndex = 2;
            this.RecipeLbl.Text = "Recipe:";
            // 
            // CleanRecipLbl
            // 
            this.CleanRecipLbl.AutoSize = true;
            this.CleanRecipLbl.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CleanRecipLbl.Location = new System.Drawing.Point(1001, 258);
            this.CleanRecipLbl.Name = "CleanRecipLbl";
            this.CleanRecipLbl.Size = new System.Drawing.Size(31, 31);
            this.CleanRecipLbl.TabIndex = 3;
            this.CleanRecipLbl.Text = "X";
            // 
            // CyberCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1203, 1050);
            this.Controls.Add(this.CleanRecipLbl);
            this.Controls.Add(this.RecipeLbl);
            this.Controls.Add(this.OutputLbl);
            this.Controls.Add(this.InputLbl);
            this.Name = "CyberCalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cyber Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InputLbl;
        private System.Windows.Forms.Label OutputLbl;
        private System.Windows.Forms.Label RecipeLbl;
        private System.Windows.Forms.Label CleanRecipLbl;
    }
}

