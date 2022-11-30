namespace WinFormsApp1
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
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pixel3 = new System.Windows.Forms.RadioButton();
            this.pixel2 = new System.Windows.Forms.RadioButton();
            this.pixel1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cargar imagen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(133, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(655, 370);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pixel3);
            this.groupBox1.Controls.Add(this.pixel2);
            this.groupBox1.Controls.Add(this.pixel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(115, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pixeles";
            // 
            // pixel3
            // 
            this.pixel3.AutoSize = true;
            this.pixel3.Location = new System.Drawing.Point(6, 72);
            this.pixel3.Name = "pixel3";
            this.pixel3.Size = new System.Drawing.Size(59, 19);
            this.pixel3.TabIndex = 2;
            this.pixel3.Text = "Pixel 3";
            this.pixel3.UseVisualStyleBackColor = true;
            this.pixel3.CheckedChanged += new System.EventHandler(this.pixel3_CheckedChanged);
            // 
            // pixel2
            // 
            this.pixel2.AutoSize = true;
            this.pixel2.Location = new System.Drawing.Point(6, 47);
            this.pixel2.Name = "pixel2";
            this.pixel2.Size = new System.Drawing.Size(59, 19);
            this.pixel2.TabIndex = 1;
            this.pixel2.Text = "Pixel 2";
            this.pixel2.UseVisualStyleBackColor = true;
            this.pixel2.CheckedChanged += new System.EventHandler(this.pixel2_CheckedChanged);
            // 
            // pixel1
            // 
            this.pixel1.AutoSize = true;
            this.pixel1.Checked = true;
            this.pixel1.Location = new System.Drawing.Point(6, 22);
            this.pixel1.Name = "pixel1";
            this.pixel1.Size = new System.Drawing.Size(59, 19);
            this.pixel1.TabIndex = 0;
            this.pixel1.TabStop = true;
            this.pixel1.Text = "Pixel 1";
            this.pixel1.UseVisualStyleBackColor = true;
            this.pixel1.CheckedChanged += new System.EventHandler(this.pixel1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(115, 115);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RGB";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 80);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 51);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 268);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Pintar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private RadioButton pixel3;
        private RadioButton pixel2;
        private RadioButton pixel1;
        private GroupBox groupBox2;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button2;
    }
}