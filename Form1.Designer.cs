namespace DESTINATION
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
            this.lblFiletype = new System.Windows.Forms.Label();
            this.lblFilename = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtfiletype = new System.Windows.Forms.TextBox();
            this.txtfilename = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnserverrqu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFiletype
            // 
            this.lblFiletype.AutoSize = true;
            this.lblFiletype.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblFiletype.Location = new System.Drawing.Point(37, 264);
            this.lblFiletype.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiletype.Name = "lblFiletype";
            this.lblFiletype.Size = new System.Drawing.Size(98, 20);
            this.lblFiletype.TabIndex = 1;
            this.lblFiletype.Text = "FILE TYPE";
            // 
            // lblFilename
            // 
            this.lblFilename.AutoSize = true;
            this.lblFilename.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblFilename.Location = new System.Drawing.Point(33, 225);
            this.lblFilename.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFilename.Name = "lblFilename";
            this.lblFilename.Size = new System.Drawing.Size(103, 20);
            this.lblFilename.TabIndex = 2;
            this.lblFilename.Text = "FILE NAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "DESTINATION";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(36, 174);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(314, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "REQUIREMENT TO SERVER";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.Blue;
            this.textBox1.Location = new System.Drawing.Point(437, 117);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(265, 165);
            this.textBox1.TabIndex = 14;
            // 
            // txtfiletype
            // 
            this.txtfiletype.Location = new System.Drawing.Point(182, 264);
            this.txtfiletype.Name = "txtfiletype";
            this.txtfiletype.Size = new System.Drawing.Size(100, 26);
            this.txtfiletype.TabIndex = 15;
            // 
            // txtfilename
            // 
            this.txtfilename.Location = new System.Drawing.Point(182, 219);
            this.txtfilename.Name = "txtfilename";
            this.txtfilename.Size = new System.Drawing.Size(100, 26);
            this.txtfilename.TabIndex = 16;
            this.txtfilename.TextChanged += new System.EventHandler(this.txtfilename_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DESTINATION.Properties.Resources.destination;
            this.pictureBox2.Location = new System.Drawing.Point(165, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(432, 62);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Image = global::DESTINATION.Properties.Resources.decrypt;
            this.button1.Location = new System.Drawing.Point(437, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 30);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnserverrqu
            // 
            this.btnserverrqu.BackgroundImage = global::DESTINATION.Properties.Resources.requesttoserver;
            this.btnserverrqu.ForeColor = System.Drawing.Color.Blue;
            this.btnserverrqu.Image = global::DESTINATION.Properties.Resources.requesttoserver;
            this.btnserverrqu.Location = new System.Drawing.Point(69, 339);
            this.btnserverrqu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnserverrqu.Name = "btnserverrqu";
            this.btnserverrqu.Size = new System.Drawing.Size(281, 33);
            this.btnserverrqu.TabIndex = 0;
            this.btnserverrqu.UseVisualStyleBackColor = true;
            this.btnserverrqu.Click += new System.EventHandler(this.btnserverrqu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DESTINATION.Properties.Resources.decryptmesscomputer;
            this.pictureBox1.Location = new System.Drawing.Point(415, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(312, 269);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1073, 700);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtfilename);
            this.Controls.Add(this.txtfiletype);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFilename);
            this.Controls.Add(this.lblFiletype);
            this.Controls.Add(this.btnserverrqu);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "DESTINATION";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnserverrqu;
        private System.Windows.Forms.Label lblFiletype;
        private System.Windows.Forms.Label lblFilename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtfiletype;
        private System.Windows.Forms.TextBox txtfilename;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

