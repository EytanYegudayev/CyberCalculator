namespace CyberCalculator.GUI
{
    partial class InputKeyForm
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
            this.keyLbl = new System.Windows.Forms.Label();
            this.KeyInputTextBox = new System.Windows.Forms.TextBox();
            this.EnterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // keyLbl
            // 
            this.keyLbl.AutoSize = true;
            this.keyLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyLbl.Location = new System.Drawing.Point(21, 28);
            this.keyLbl.Name = "keyLbl";
            this.keyLbl.Size = new System.Drawing.Size(552, 41);
            this.keyLbl.TabIndex = 0;
            this.keyLbl.Text = "Please enter your key(Hex Format):";
            // 
            // KeyInputTextBox
            // 
            this.KeyInputTextBox.BackColor = System.Drawing.Color.White;
            this.KeyInputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KeyInputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.KeyInputTextBox.Location = new System.Drawing.Point(26, 82);
            this.KeyInputTextBox.Name = "KeyInputTextBox";
            this.KeyInputTextBox.Size = new System.Drawing.Size(351, 30);
            this.KeyInputTextBox.TabIndex = 1;
            // 
            // EnterButton
            // 
            this.EnterButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.EnterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.EnterButton.Location = new System.Drawing.Point(63, 130);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(275, 46);
            this.EnterButton.TabIndex = 2;
            this.EnterButton.Text = "Enter";
            this.EnterButton.UseVisualStyleBackColor = false;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // InputKeyForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(437, 188);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.KeyInputTextBox);
            this.Controls.Add(this.keyLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InputKeyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InputKeyForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label keyLbl;
        private System.Windows.Forms.TextBox KeyInputTextBox;
        private System.Windows.Forms.Button EnterButton;
    }
}