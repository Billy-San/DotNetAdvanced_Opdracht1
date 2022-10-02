namespace Oefening5
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
            this.Celsius = new System.Windows.Forms.Label();
            this.Fahrenheit = new System.Windows.Forms.Label();
            this.CelsiusBox = new System.Windows.Forms.TextBox();
            this.FahrenheitBox = new System.Windows.Forms.TextBox();
            this.CelsiusBtn = new System.Windows.Forms.Button();
            this.FahrenheitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Celsius
            // 
            this.Celsius.AutoSize = true;
            this.Celsius.Location = new System.Drawing.Point(166, 76);
            this.Celsius.Name = "Celsius";
            this.Celsius.Size = new System.Drawing.Size(66, 25);
            this.Celsius.TabIndex = 0;
            this.Celsius.Text = "Celsius";
            // 
            // Fahrenheit
            // 
            this.Fahrenheit.AutoSize = true;
            this.Fahrenheit.Location = new System.Drawing.Point(429, 76);
            this.Fahrenheit.Name = "Fahrenheit";
            this.Fahrenheit.Size = new System.Drawing.Size(93, 25);
            this.Fahrenheit.TabIndex = 1;
            this.Fahrenheit.Text = "Fahrenheit";
            this.Fahrenheit.Click += new System.EventHandler(this.Fahrenheit_Click);
            // 
            // CelsiusBox
            // 
            this.CelsiusBox.Location = new System.Drawing.Point(126, 104);
            this.CelsiusBox.Name = "CelsiusBox";
            this.CelsiusBox.Size = new System.Drawing.Size(150, 31);
            this.CelsiusBox.TabIndex = 2;
            // 
            // FahrenheitBox
            // 
            this.FahrenheitBox.Location = new System.Drawing.Point(405, 104);
            this.FahrenheitBox.Name = "FahrenheitBox";
            this.FahrenheitBox.Size = new System.Drawing.Size(150, 31);
            this.FahrenheitBox.TabIndex = 3;
            this.FahrenheitBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // CelsiusBtn
            // 
            this.CelsiusBtn.Location = new System.Drawing.Point(153, 165);
            this.CelsiusBtn.Name = "CelsiusBtn";
            this.CelsiusBtn.Size = new System.Drawing.Size(112, 34);
            this.CelsiusBtn.TabIndex = 4;
            this.CelsiusBtn.Text = "C to F";
            this.CelsiusBtn.UseVisualStyleBackColor = true;
            this.CelsiusBtn.Click += new System.EventHandler(this.CelsiusBtn_Click);
            // 
            // FahrenheitBtn
            // 
            this.FahrenheitBtn.Location = new System.Drawing.Point(420, 165);
            this.FahrenheitBtn.Name = "FahrenheitBtn";
            this.FahrenheitBtn.Size = new System.Drawing.Size(112, 34);
            this.FahrenheitBtn.TabIndex = 5;
            this.FahrenheitBtn.Text = "F to C";
            this.FahrenheitBtn.UseVisualStyleBackColor = true;
            this.FahrenheitBtn.Click += new System.EventHandler(this.FahrenheitBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 358);
            this.Controls.Add(this.FahrenheitBtn);
            this.Controls.Add(this.CelsiusBtn);
            this.Controls.Add(this.FahrenheitBox);
            this.Controls.Add(this.CelsiusBox);
            this.Controls.Add(this.Fahrenheit);
            this.Controls.Add(this.Celsius);
            this.Name = "Form1";
            this.Text = "CelsiusToFahrenheit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Celsius;
        private Label Fahrenheit;
        private TextBox CelsiusBox;
        private TextBox FahrenheitBox;
        private Button CelsiusBtn;
        private Button FahrenheitBtn;
    }
}