namespace PicassosInventorySystem.Views
{
    partial class VolumeItemDetailsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxUnitOfMeasure = new System.Windows.Forms.ComboBox();
            this.txtMinimum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minimum:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Unit of Measure:";
            // 
            // cbxUnitOfMeasure
            // 
            this.cbxUnitOfMeasure.FormattingEnabled = true;
            this.cbxUnitOfMeasure.Location = new System.Drawing.Point(94, 30);
            this.cbxUnitOfMeasure.Name = "cbxUnitOfMeasure";
            this.cbxUnitOfMeasure.Size = new System.Drawing.Size(63, 21);
            this.cbxUnitOfMeasure.TabIndex = 3;
            // 
            // txtMinimum
            // 
            this.txtMinimum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMinimum.Location = new System.Drawing.Point(94, 4);
            this.txtMinimum.Name = "txtMinimum";
            this.txtMinimum.Size = new System.Drawing.Size(63, 20);
            this.txtMinimum.TabIndex = 1;
            this.txtMinimum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMinimum.TextChanged += new System.EventHandler(this.txtMinimum_TextChanged);
            // 
            // VolumeItemDetailsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtMinimum);
            this.Controls.Add(this.cbxUnitOfMeasure);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VolumeItemDetailsControl";
            this.Size = new System.Drawing.Size(167, 58);
            this.Load += new System.EventHandler(this.VolumeItemDetailsControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxUnitOfMeasure;
        private System.Windows.Forms.TextBox txtMinimum;
    }
}
