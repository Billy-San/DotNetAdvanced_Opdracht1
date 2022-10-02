namespace Oefening7
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
            this.lab1 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.box1 = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Location = new System.Drawing.Point(121, 124);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(81, 25);
            this.lab1.TabIndex = 0;
            this.lab1.Text = "Number:";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(201, 179);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(112, 34);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "Calculate";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.button1_Click);
            // 
            // box1
            // 
            this.box1.Location = new System.Drawing.Point(223, 124);
            this.box1.Name = "box1";
            this.box1.Size = new System.Drawing.Size(150, 31);
            this.box1.TabIndex = 2;
            // 
            // Result
            // 
            this.Result.Enabled = false;
            this.Result.Location = new System.Drawing.Point(163, 243);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(150, 31);
            this.Result.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.box1);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.lab1);
            this.Name = "Form1";
            this.Text = "Sum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lab1;
        private Button btn1;
        private TextBox box1;
        private TextBox Result;
    }
}