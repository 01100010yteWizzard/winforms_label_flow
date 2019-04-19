namespace labels
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_dynamic = new System.Windows.Forms.Label();
            this.lbl_fix = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnOpenModalView = new System.Windows.Forms.Button();
            this.lbl_length = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.flowLayoutPanel1.Controls.Add(this.lbl_dynamic);
            this.flowLayoutPanel1.Controls.Add(this.lbl_fix);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(502, 459);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // lbl_dynamic
            // 
            this.lbl_dynamic.AutoSize = true;
            this.lbl_dynamic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbl_dynamic.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_dynamic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dynamic.Location = new System.Drawing.Point(10, 10);
            this.lbl_dynamic.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.lbl_dynamic.Name = "lbl_dynamic";
            this.lbl_dynamic.Padding = new System.Windows.Forms.Padding(5, 5, 5, 10);
            this.lbl_dynamic.Size = new System.Drawing.Size(148, 39);
            this.lbl_dynamic.TabIndex = 1;
            // 
            // lbl_fix
            // 
            this.lbl_fix.AutoSize = true;
            this.lbl_fix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_fix.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fix.Location = new System.Drawing.Point(10, 59);
            this.lbl_fix.Margin = new System.Windows.Forms.Padding(10, 10, 3, 0);
            this.lbl_fix.Name = "lbl_fix";
            this.lbl_fix.Size = new System.Drawing.Size(148, 24);
            this.lbl_fix.TabIndex = 1;
            this.lbl_fix.Text = "i bims a fixer text";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.13966F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.86034F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(759, 459);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel2);
            this.panel1.Controls.Add(this.btnOpenModalView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(505, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 446);
            this.panel1.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.lbl_length);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 39);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(251, 100);
            this.flowLayoutPanel2.TabIndex = 8;
            // 
            // btnOpenModalView
            // 
            this.btnOpenModalView.BackColor = System.Drawing.Color.Silver;
            this.btnOpenModalView.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOpenModalView.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOpenModalView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenModalView.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenModalView.Location = new System.Drawing.Point(0, 0);
            this.btnOpenModalView.Margin = new System.Windows.Forms.Padding(10);
            this.btnOpenModalView.Name = "btnOpenModalView";
            this.btnOpenModalView.Size = new System.Drawing.Size(251, 39);
            this.btnOpenModalView.TabIndex = 6;
            this.btnOpenModalView.Text = "open modal window";
            this.btnOpenModalView.UseVisualStyleBackColor = false;
            this.btnOpenModalView.Click += new System.EventHandler(this.btnOpenModalView_Click);
            // 
            // lbl_length
            // 
            this.lbl_length.AutoSize = true;
            this.lbl_length.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_length.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_length.Location = new System.Drawing.Point(3, 5);
            this.lbl_length.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lbl_length.Name = "lbl_length";
            this.lbl_length.Size = new System.Drawing.Size(39, 16);
            this.lbl_length.TabIndex = 8;
            this.lbl_length.Text = "count";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 458);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lbl_dynamic;
        private System.Windows.Forms.Label lbl_fix;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label lbl_length;
        private System.Windows.Forms.Button btnOpenModalView;
    }
}

