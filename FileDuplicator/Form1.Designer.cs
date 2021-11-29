
namespace FileDuplicator
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
            this.lblSource = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.btnBT = new System.Windows.Forms.Button();
            this.btnBB = new System.Windows.Forms.Button();
            this.btnDuplicate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(27, 42);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(44, 13);
            this.lblSource.TabIndex = 0;
            this.lblSource.Text = "Source:";
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(27, 93);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(63, 13);
            this.lblDestination.TabIndex = 1;
            this.lblDestination.Text = "Destination:";
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(105, 35);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(393, 20);
            this.txtSource.TabIndex = 2;
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(105, 86);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(393, 20);
            this.txtDestination.TabIndex = 3;
            // 
            // btnBT
            // 
            this.btnBT.Location = new System.Drawing.Point(536, 35);
            this.btnBT.Name = "btnBT";
            this.btnBT.Size = new System.Drawing.Size(96, 20);
            this.btnBT.TabIndex = 4;
            this.btnBT.Text = "Browse";
            this.btnBT.UseVisualStyleBackColor = true;
            this.btnBT.Click += new System.EventHandler(this.btnBT_Click);
            // 
            // btnBB
            // 
            this.btnBB.Location = new System.Drawing.Point(536, 86);
            this.btnBB.Name = "btnBB";
            this.btnBB.Size = new System.Drawing.Size(96, 20);
            this.btnBB.TabIndex = 5;
            this.btnBB.Text = "Browse";
            this.btnBB.UseVisualStyleBackColor = true;
            this.btnBB.Click += new System.EventHandler(this.btnBB_Click);
            // 
            // btnDuplicate
            // 
            this.btnDuplicate.Location = new System.Drawing.Point(258, 129);
            this.btnDuplicate.Name = "btnDuplicate";
            this.btnDuplicate.Size = new System.Drawing.Size(96, 20);
            this.btnDuplicate.TabIndex = 6;
            this.btnDuplicate.Text = "Duplicate";
            this.btnDuplicate.UseVisualStyleBackColor = true;
            this.btnDuplicate.Click += new System.EventHandler(this.btnDuplicate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 172);
            this.Controls.Add(this.btnDuplicate);
            this.Controls.Add(this.btnBB);
            this.Controls.Add(this.btnBT);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.lblSource);
            this.Name = "Form1";
            this.Text = "File Duplicator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.Button btnBT;
        private System.Windows.Forms.Button btnBB;
        private System.Windows.Forms.Button btnDuplicate;
    }
}

