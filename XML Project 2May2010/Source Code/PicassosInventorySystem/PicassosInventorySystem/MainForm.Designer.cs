namespace PicassosInventorySystem
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnOpenExistingFile = new System.Windows.Forms.Button();
            this.btnCreateNewFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Bradley Hand ITC", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(141, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(252, 80);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Picasso\'s";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(141, 122);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(252, 28);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Inventory System";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnOpenExistingFile
            // 
            this.btnOpenExistingFile.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOpenExistingFile.Image = global::PicassosInventorySystem.Properties.Resources.Open02;
            this.btnOpenExistingFile.Location = new System.Drawing.Point(12, 164);
            this.btnOpenExistingFile.Name = "btnOpenExistingFile";
            this.btnOpenExistingFile.Size = new System.Drawing.Size(123, 143);
            this.btnOpenExistingFile.TabIndex = 3;
            this.btnOpenExistingFile.Text = "&Open Existing File";
            this.btnOpenExistingFile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnOpenExistingFile.UseVisualStyleBackColor = false;
            this.btnOpenExistingFile.Click += new System.EventHandler(this.btnOpenExistingFile_Click);
            // 
            // btnCreateNewFile
            // 
            this.btnCreateNewFile.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCreateNewFile.Image = global::PicassosInventorySystem.Properties.Resources.addNew2;
            this.btnCreateNewFile.Location = new System.Drawing.Point(12, 12);
            this.btnCreateNewFile.Name = "btnCreateNewFile";
            this.btnCreateNewFile.Size = new System.Drawing.Size(123, 146);
            this.btnCreateNewFile.TabIndex = 2;
            this.btnCreateNewFile.Text = "&Create New File";
            this.btnCreateNewFile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnCreateNewFile.UseVisualStyleBackColor = false;
            this.btnCreateNewFile.Click += new System.EventHandler(this.btnCreateNewFile_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(392, 310);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnOpenExistingFile);
            this.Controls.Add(this.btnCreateNewFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Picasso\'s Inventory System";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateNewFile;
        private System.Windows.Forms.Button btnOpenExistingFile;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}