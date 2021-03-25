
namespace cashUpCalculator
{
    partial class entryForm
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
            this.cashUp = new System.Windows.Forms.Button();
            this.History = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cashUp
            // 
            this.cashUp.Location = new System.Drawing.Point(40, 34);
            this.cashUp.Name = "cashUp";
            this.cashUp.Size = new System.Drawing.Size(199, 78);
            this.cashUp.TabIndex = 0;
            this.cashUp.Text = "Cash Up";
            this.cashUp.UseVisualStyleBackColor = true;
            this.cashUp.Click += new System.EventHandler(this.button1_Click);
            // 
            // History
            // 
            this.History.Location = new System.Drawing.Point(40, 118);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(199, 78);
            this.History.TabIndex = 1;
            this.History.Text = "View History";
            this.History.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(40, 202);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(199, 78);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // entryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 312);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.History);
            this.Controls.Add(this.cashUp);
            this.Name = "entryForm";
            this.Text = "Easy Cash Up";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cashUp;
        private System.Windows.Forms.Button History;
        private System.Windows.Forms.Button exitButton;
    }
}

