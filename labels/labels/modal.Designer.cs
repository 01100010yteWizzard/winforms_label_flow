namespace labels
{
    partial class Modal
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.bnCancel = new System.Windows.Forms.Button();
            this.lbl_length = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(12, 12);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInput.Size = new System.Drawing.Size(507, 158);
            this.txtInput.TabIndex = 3;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Lime;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSubmit.Location = new System.Drawing.Point(163, 203);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(90, 41);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // bnCancel
            // 
            this.bnCancel.BackColor = System.Drawing.Color.Red;
            this.bnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnCancel.Location = new System.Drawing.Point(259, 203);
            this.bnCancel.Name = "bnCancel";
            this.bnCancel.Size = new System.Drawing.Size(83, 41);
            this.bnCancel.TabIndex = 5;
            this.bnCancel.Text = "Cancel";
            this.bnCancel.UseVisualStyleBackColor = false;
            this.bnCancel.Click += new System.EventHandler(this.bnCancel_Click);
            // 
            // lbl_length
            // 
            this.lbl_length.AutoSize = true;
            this.lbl_length.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_length.Location = new System.Drawing.Point(12, 173);
            this.lbl_length.Name = "lbl_length";
            this.lbl_length.Size = new System.Drawing.Size(39, 16);
            this.lbl_length.TabIndex = 6;
            this.lbl_length.Text = "count";
            // 
            // Modal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 256);
            this.Controls.Add(this.lbl_length);
            this.Controls.Add(this.bnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Modal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Modal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button bnCancel;
        private System.Windows.Forms.Label lbl_length;
    }
}