namespace PicassosInventorySystem.Views
{
    partial class BoxedItemDetailsControl
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
            this.txtBoxCost = new System.Windows.Forms.TextBox();
            this.txtUnitsInBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Box Cost:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Units in Box:";
            // 
            // txtBoxCost
            // 
            this.txtBoxCost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxCost.Location = new System.Drawing.Point(79, 6);
            this.txtBoxCost.Name = "txtBoxCost";
            this.txtBoxCost.Size = new System.Drawing.Size(107, 20);
            this.txtBoxCost.TabIndex = 1;
            this.txtBoxCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBoxCost.TextChanged += new System.EventHandler(this.txtBoxCost_TextChanged);
            // 
            // txtUnitsInBox
            // 
            this.txtUnitsInBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUnitsInBox.Location = new System.Drawing.Point(79, 37);
            this.txtUnitsInBox.Name = "txtUnitsInBox";
            this.txtUnitsInBox.Size = new System.Drawing.Size(107, 20);
            this.txtUnitsInBox.TabIndex = 3;
            this.txtUnitsInBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUnitsInBox.TextChanged += new System.EventHandler(this.txtUnitsInBox_TextChanged);
            // 
            // BoxedItemDetailsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtUnitsInBox);
            this.Controls.Add(this.txtBoxCost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BoxedItemDetailsControl";
            this.Size = new System.Drawing.Size(194, 66);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxCost;
        private System.Windows.Forms.TextBox txtUnitsInBox;
    }
}
