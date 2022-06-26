namespace WinFormsApps
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
            this.Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button
            // 
            this.Button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Button.BackgroundImage = global::WinFormsApps.Properties.Resources.vinipuh_vinipuh;
            this.Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button.Location = new System.Drawing.Point(120, 41);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(338, 99);
            this.Button.TabIndex = 0;
            this.Button.Text = "Дата Сегодняшнего Дня";
            this.Button.UseVisualStyleBackColor = false;
            this.Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(583, 194);
            this.Controls.Add(this.Button);
            this.Font = new System.Drawing.Font("Edwardian Script ITC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Окошко";
            this.ResumeLayout(false);

        }

        #endregion

        private Button Button;
    }
}