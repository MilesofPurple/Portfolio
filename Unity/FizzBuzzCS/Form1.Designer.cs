namespace FizzBuzzCS
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
            this.btnFizzBuzz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFizzBuzz
            // 
            this.btnFizzBuzz.Location = new System.Drawing.Point(408, 219);
            this.btnFizzBuzz.Name = "btnFizzBuzz";
            this.btnFizzBuzz.Size = new System.Drawing.Size(302, 173);
            this.btnFizzBuzz.TabIndex = 0;
            this.btnFizzBuzz.Text = "FizzBuzz";
            this.btnFizzBuzz.UseVisualStyleBackColor = true;
            this.btnFizzBuzz.Click += new System.EventHandler(this.btnFizzBuzz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 591);
            this.Controls.Add(this.btnFizzBuzz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnFizzBuzz;
    }
}