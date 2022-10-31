namespace Calculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoa = new System.Windows.Forms.TextBox();
            this.txtSob = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(137, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số a:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(137, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số b:";
            // 
            // txtSoa
            // 
            this.txtSoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSoa.Location = new System.Drawing.Point(263, 71);
            this.txtSoa.Name = "txtSoa";
            this.txtSoa.Size = new System.Drawing.Size(273, 34);
            this.txtSoa.TabIndex = 1;
            // 
            // txtSob
            // 
            this.txtSob.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSob.Location = new System.Drawing.Point(263, 142);
            this.txtSob.Name = "txtSob";
            this.txtSob.Size = new System.Drawing.Size(273, 34);
            this.txtSob.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSob);
            this.Controls.Add(this.txtSoa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtSoa;
        private TextBox txtSob;
    }
}