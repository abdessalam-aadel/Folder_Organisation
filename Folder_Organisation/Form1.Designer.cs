namespace Folder_Organisation
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
            this.btnStart = new System.Windows.Forms.Button();
            this.txtBoxFolder1 = new System.Windows.Forms.TextBox();
            this.txtBoxFolder2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGit = new System.Windows.Forms.Label();
            this.txtBoxLoad = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtDone = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.White;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnStart.Location = new System.Drawing.Point(219, 44);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 47);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtBoxFolder1
            // 
            this.txtBoxFolder1.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtBoxFolder1.Location = new System.Drawing.Point(67, 44);
            this.txtBoxFolder1.Name = "txtBoxFolder1";
            this.txtBoxFolder1.Size = new System.Drawing.Size(100, 20);
            this.txtBoxFolder1.TabIndex = 2;
            this.txtBoxFolder1.Text = "IF68";
            // 
            // txtBoxFolder2
            // 
            this.txtBoxFolder2.ForeColor = System.Drawing.Color.Chocolate;
            this.txtBoxFolder2.Location = new System.Drawing.Point(67, 70);
            this.txtBoxFolder2.Name = "txtBoxFolder2";
            this.txtBoxFolder2.Size = new System.Drawing.Size(100, 20);
            this.txtBoxFolder2.TabIndex = 3;
            this.txtBoxFolder2.Text = "IF85E";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(13, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Folder 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Chocolate;
            this.label2.Location = new System.Drawing.Point(13, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Folder 2:";
            // 
            // txtGit
            // 
            this.txtGit.AutoSize = true;
            this.txtGit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtGit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGit.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtGit.Location = new System.Drawing.Point(138, 102);
            this.txtGit.Name = "txtGit";
            this.txtGit.Size = new System.Drawing.Size(38, 13);
            this.txtGit.TabIndex = 5;
            this.txtGit.Text = "Github";
            this.txtGit.Click += new System.EventHandler(this.txtGit_Click);
            // 
            // txtBoxLoad
            // 
            this.txtBoxLoad.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBoxLoad.Location = new System.Drawing.Point(16, 17);
            this.txtBoxLoad.Name = "txtBoxLoad";
            this.txtBoxLoad.Size = new System.Drawing.Size(201, 20);
            this.txtBoxLoad.TabIndex = 1;
            this.txtBoxLoad.Text = "Chose your folder ...";
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.SystemColors.Control;
            this.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLoad.Location = new System.Drawing.Point(219, 16);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 22);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtDone
            // 
            this.txtDone.AutoSize = true;
            this.txtDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDone.ForeColor = System.Drawing.Color.Maroon;
            this.txtDone.Location = new System.Drawing.Point(235, 92);
            this.txtDone.Name = "txtDone";
            this.txtDone.Size = new System.Drawing.Size(0, 17);
            this.txtDone.TabIndex = 11;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 118);
            this.Controls.Add(this.txtDone);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtBoxLoad);
            this.Controls.Add(this.txtGit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxFolder2);
            this.Controls.Add(this.txtBoxFolder1);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Folder Organisation";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtBoxFolder1;
        private System.Windows.Forms.TextBox txtBoxFolder2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtGit;
        private System.Windows.Forms.TextBox txtBoxLoad;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label txtDone;
    }
}

