
namespace Crime_Management_System
{
    partial class Open_Complaint
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnOpenComplaint = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 66);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(838, 394);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label15.Location = new System.Drawing.Point(286, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(275, 41);
            this.label15.TabIndex = 45;
            this.label15.Text = "VIEW COMPLAINT";
            // 
            // btnOpenComplaint
            // 
            this.btnOpenComplaint.BorderRadius = 15;
            this.btnOpenComplaint.CheckedState.Parent = this.btnOpenComplaint;
            this.btnOpenComplaint.CustomImages.Parent = this.btnOpenComplaint;
            this.btnOpenComplaint.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOpenComplaint.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnOpenComplaint.ForeColor = System.Drawing.Color.White;
            this.btnOpenComplaint.HoverState.Parent = this.btnOpenComplaint;
            this.btnOpenComplaint.Location = new System.Drawing.Point(665, 466);
            this.btnOpenComplaint.Name = "btnOpenComplaint";
            this.btnOpenComplaint.ShadowDecoration.Parent = this.btnOpenComplaint;
            this.btnOpenComplaint.Size = new System.Drawing.Size(185, 45);
            this.btnOpenComplaint.TabIndex = 60;
            this.btnOpenComplaint.Text = "Open Complaint";
            this.btnOpenComplaint.Click += new System.EventHandler(this.btnOpenComplaint_Click);
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 15;
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.Location = new System.Drawing.Point(461, 466);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(185, 45);
            this.btnSave.TabIndex = 61;
            this.btnSave.Text = "Save Complaint";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Open_Complaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(862, 514);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpenComplaint);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Open_Complaint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Open_Complaint";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label15;
        private Guna.UI2.WinForms.Guna2Button btnOpenComplaint;
        private Guna.UI2.WinForms.Guna2Button btnSave;
    }
}