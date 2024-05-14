namespace Bai6
{
    partial class frmFitness
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFitness));
            this.lblUserName = new System.Windows.Forms.Label();
            this.textInput = new System.Windows.Forms.TextBox();
            this.chkMusic = new System.Windows.Forms.CheckBox();
            this.picNangTa = new System.Windows.Forms.PictureBox();
            this.lblDesigned = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.btnCount = new System.Windows.Forms.Button();
            this.picHaTa = new System.Windows.Forms.PictureBox();
            this.lblResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picNangTa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHaTa)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(56, 23);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(110, 25);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Username";
            this.lblUserName.Click += new System.EventHandler(this.lblUserName_Click);
            // 
            // textInput
            // 
            this.textInput.Location = new System.Drawing.Point(61, 52);
            this.textInput.Margin = new System.Windows.Forms.Padding(4);
            this.textInput.Name = "textInput";
            this.textInput.Size = new System.Drawing.Size(430, 27);
            this.textInput.TabIndex = 1;
            this.textInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // chkMusic
            // 
            this.chkMusic.AutoSize = true;
            this.chkMusic.Location = new System.Drawing.Point(410, 26);
            this.chkMusic.Margin = new System.Windows.Forms.Padding(4);
            this.chkMusic.Name = "chkMusic";
            this.chkMusic.Size = new System.Drawing.Size(81, 24);
            this.chkMusic.TabIndex = 2;
            this.chkMusic.Text = "Music";
            this.chkMusic.UseVisualStyleBackColor = true;
            this.chkMusic.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // picNangTa
            // 
            this.picNangTa.Image = ((System.Drawing.Image)(resources.GetObject("picNangTa.Image")));
            this.picNangTa.Location = new System.Drawing.Point(61, 100);
            this.picNangTa.Margin = new System.Windows.Forms.Padding(4);
            this.picNangTa.Name = "picNangTa";
            this.picNangTa.Size = new System.Drawing.Size(430, 280);
            this.picNangTa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNangTa.TabIndex = 3;
            this.picNangTa.TabStop = false;
            this.picNangTa.Click += new System.EventHandler(this.picNangTa_Click);
            // 
            // lblDesigned
            // 
            this.lblDesigned.AutoSize = true;
            this.lblDesigned.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesigned.Location = new System.Drawing.Point(56, 447);
            this.lblDesigned.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesigned.Name = "lblDesigned";
            this.lblDesigned.Size = new System.Drawing.Size(132, 25);
            this.lblDesigned.TabIndex = 5;
            this.lblDesigned.Text = "Designed by";
            this.lblDesigned.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnExit.Location = new System.Drawing.Point(393, 447);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(98, 50);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(56, 472);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(93, 25);
            this.lblAuthor.TabIndex = 5;
            this.lblAuthor.Text = "AlexDuc";
            this.lblAuthor.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnCount
            // 
            this.btnCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCount.ForeColor = System.Drawing.Color.Red;
            this.btnCount.Location = new System.Drawing.Point(61, 387);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(430, 57);
            this.btnCount.TabIndex = 8;
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.button1_Click);
            // 
            // picHaTa
            // 
            this.picHaTa.Image = ((System.Drawing.Image)(resources.GetObject("picHaTa.Image")));
            this.picHaTa.Location = new System.Drawing.Point(61, 100);
            this.picHaTa.Name = "picHaTa";
            this.picHaTa.Size = new System.Drawing.Size(430, 280);
            this.picHaTa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHaTa.TabIndex = 9;
            this.picHaTa.TabStop = false;
            this.picHaTa.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.Red;
            this.lblResult.Location = new System.Drawing.Point(195, 447);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(150, 50);
            this.lblResult.TabIndex = 10;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblResult.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmFitness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(547, 513);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.picHaTa);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblDesigned);
            this.Controls.Add(this.picNangTa);
            this.Controls.Add(this.chkMusic);
            this.Controls.Add(this.textInput);
            this.Controls.Add(this.lblUserName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmFitness";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fitness";
            this.Load += new System.EventHandler(this.frmFitness_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picNangTa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHaTa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox textInput;
        private System.Windows.Forms.CheckBox chkMusic;
        private System.Windows.Forms.PictureBox picNangTa;
        private System.Windows.Forms.Label lblDesigned;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.PictureBox picHaTa;
        private System.Windows.Forms.Label lblResult;
    }
}

