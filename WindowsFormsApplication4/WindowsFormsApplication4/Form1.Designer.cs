namespace WindowsFormsApplication4
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
            this.glControl1 = new OpenTK.GLControl();
            this.BeginX = new System.Windows.Forms.TextBox();
            this.BeginY = new System.Windows.Forms.TextBox();
            this.BeginZ = new System.Windows.Forms.TextBox();
            this.EndX = new System.Windows.Forms.TextBox();
            this.EndZ = new System.Windows.Forms.TextBox();
            this.EndY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // glControl1
            // 
            this.glControl1.BackColor = System.Drawing.Color.Black;
            this.glControl1.Location = new System.Drawing.Point(12, 12);
            this.glControl1.Name = "glControl1";
            this.glControl1.Size = new System.Drawing.Size(917, 394);
            this.glControl1.TabIndex = 0;
            this.glControl1.VSync = false;
            this.glControl1.Load += new System.EventHandler(this.glControl1_Load);
            this.glControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl1_Paint);
            this.glControl1.Resize += new System.EventHandler(this.glControl1_Resize);
            // 
            // BeginX
            // 
            this.BeginX.Location = new System.Drawing.Point(45, 430);
            this.BeginX.Name = "BeginX";
            this.BeginX.Size = new System.Drawing.Size(31, 20);
            this.BeginX.TabIndex = 1;
            this.BeginX.TextChanged += new System.EventHandler(this.EndY_TextChanged);
            // 
            // BeginY
            // 
            this.BeginY.Location = new System.Drawing.Point(79, 430);
            this.BeginY.Name = "BeginY";
            this.BeginY.Size = new System.Drawing.Size(31, 20);
            this.BeginY.TabIndex = 2;
            this.BeginY.TextChanged += new System.EventHandler(this.EndY_TextChanged);
            // 
            // BeginZ
            // 
            this.BeginZ.Location = new System.Drawing.Point(116, 430);
            this.BeginZ.Name = "BeginZ";
            this.BeginZ.Size = new System.Drawing.Size(31, 20);
            this.BeginZ.TabIndex = 3;
            this.BeginZ.TextChanged += new System.EventHandler(this.EndY_TextChanged);
            // 
            // EndX
            // 
            this.EndX.Location = new System.Drawing.Point(45, 459);
            this.EndX.Name = "EndX";
            this.EndX.Size = new System.Drawing.Size(31, 20);
            this.EndX.TabIndex = 4;
            this.EndX.TextChanged += new System.EventHandler(this.EndY_TextChanged);
            // 
            // EndZ
            // 
            this.EndZ.Location = new System.Drawing.Point(116, 459);
            this.EndZ.Name = "EndZ";
            this.EndZ.Size = new System.Drawing.Size(31, 20);
            this.EndZ.TabIndex = 6;
            this.EndZ.TextChanged += new System.EventHandler(this.EndY_TextChanged);
            // 
            // EndY
            // 
            this.EndY.Location = new System.Drawing.Point(79, 459);
            this.EndY.Name = "EndY";
            this.EndY.Size = new System.Drawing.Size(31, 20);
            this.EndY.TabIndex = 7;
            this.EndY.TextChanged += new System.EventHandler(this.EndY_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Garis Rotasi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 433);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 462);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "B";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 485);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Update Garis";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(626, 485);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "-->";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(528, 485);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "<--";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(606, 459);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 520);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EndY);
            this.Controls.Add(this.EndZ);
            this.Controls.Add(this.EndX);
            this.Controls.Add(this.BeginZ);
            this.Controls.Add(this.BeginY);
            this.Controls.Add(this.BeginX);
            this.Controls.Add(this.glControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenTK.GLControl glControl1;
        private System.Windows.Forms.TextBox BeginX;
        private System.Windows.Forms.TextBox BeginY;
        private System.Windows.Forms.TextBox BeginZ;
        private System.Windows.Forms.TextBox EndX;
        private System.Windows.Forms.TextBox EndZ;
        private System.Windows.Forms.TextBox EndY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
    }
}

