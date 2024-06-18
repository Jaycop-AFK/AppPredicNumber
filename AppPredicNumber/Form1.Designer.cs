namespace AppPredicNumber
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.laShow = new System.Windows.Forms.Label();
            this.tGetNumber = new System.Windows.Forms.TextBox();
            this.bOk = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppPredicNumber.Properties.Resources.images__1_;
            this.pictureBox1.Location = new System.Drawing.Point(250, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // laShow
            // 
            this.laShow.AutoSize = true;
            this.laShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laShow.Location = new System.Drawing.Point(367, 275);
            this.laShow.Name = "laShow";
            this.laShow.Size = new System.Drawing.Size(86, 31);
            this.laShow.TabIndex = 2;
            this.laShow.Text = "label1";
            this.laShow.Click += new System.EventHandler(this.laShow_Click);
            // 
            // tGetNumber
            // 
            this.tGetNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tGetNumber.Location = new System.Drawing.Point(312, 186);
            this.tGetNumber.Name = "tGetNumber";
            this.tGetNumber.Size = new System.Drawing.Size(83, 38);
            this.tGetNumber.TabIndex = 3;
            this.tGetNumber.TextChanged += new System.EventHandler(this.tGetNumber_TextChanged);
            this.tGetNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tGetNumber_KeyDown);
            this.tGetNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tGetNumber_KeyPress);
            // 
            // bOk
            // 
            this.bOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bOk.Location = new System.Drawing.Point(414, 186);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(69, 40);
            this.bOk.TabIndex = 4;
            this.bOk.Text = "OK";
            this.bOk.UseVisualStyleBackColor = true;
            this.bOk.Click += new System.EventHandler(this.bOk_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(730, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bOk);
            this.Controls.Add(this.tGetNumber);
            this.Controls.Add(this.laShow);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label laShow;
        private System.Windows.Forms.TextBox tGetNumber;
        private System.Windows.Forms.Button bOk;
        private System.Windows.Forms.Button button1;
    }
}

