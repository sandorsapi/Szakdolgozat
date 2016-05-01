namespace HQ40d_Diagnosztika
{
    partial class FormFajlok
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFajlok));
            this.dataGridViewFajlok = new System.Windows.Forms.DataGridView();
            this.btnBezar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFajlok)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFajlok
            // 
            this.dataGridViewFajlok.AllowUserToAddRows = false;
            this.dataGridViewFajlok.AllowUserToDeleteRows = false;
            this.dataGridViewFajlok.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridViewFajlok.Location = new System.Drawing.Point(35, 49);
            this.dataGridViewFajlok.Name = "dataGridViewFajlok";
            this.dataGridViewFajlok.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFajlok.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewFajlok.Size = new System.Drawing.Size(290, 150);
            this.dataGridViewFajlok.TabIndex = 0;
            // 
            // btnBezar
            // 
            this.btnBezar.BackColor = System.Drawing.Color.Gray;
            this.btnBezar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnBezar.FlatAppearance.BorderSize = 0;
            this.btnBezar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnBezar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnBezar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBezar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBezar.ForeColor = System.Drawing.Color.Silver;
            this.btnBezar.Location = new System.Drawing.Point(274, 260);
            this.btnBezar.Name = "btnBezar";
            this.btnBezar.Size = new System.Drawing.Size(74, 26);
            this.btnBezar.TabIndex = 3;
            this.btnBezar.Text = "Bezár";
            this.btnBezar.UseVisualStyleBackColor = false;
            this.btnBezar.Click += new System.EventHandler(this.btnBezar_Click);
            // 
            // FormFajlok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(360, 298);
            this.Controls.Add(this.btnBezar);
            this.Controls.Add(this.dataGridViewFajlok);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormFajlok";
            this.Text = "Feltöltött fájlok";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFajlok)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFajlok;
        private System.Windows.Forms.Button btnBezar;
    }
}