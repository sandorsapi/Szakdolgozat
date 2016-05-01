namespace HQ40d_Diagnosztika
{
    partial class FormSzemelyek
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSzemelyek));
            this.dataGridViewSzemelyek = new System.Windows.Forms.DataGridView();
            this.btnBezar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSzemelyek)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSzemelyek
            // 
            this.dataGridViewSzemelyek.AllowUserToAddRows = false;
            this.dataGridViewSzemelyek.AllowUserToDeleteRows = false;
            this.dataGridViewSzemelyek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSzemelyek.Location = new System.Drawing.Point(45, 35);
            this.dataGridViewSzemelyek.Name = "dataGridViewSzemelyek";
            this.dataGridViewSzemelyek.ReadOnly = true;
            this.dataGridViewSzemelyek.Size = new System.Drawing.Size(307, 162);
            this.dataGridViewSzemelyek.TabIndex = 0;
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
            this.btnBezar.Location = new System.Drawing.Point(308, 256);
            this.btnBezar.Name = "btnBezar";
            this.btnBezar.Size = new System.Drawing.Size(74, 26);
            this.btnBezar.TabIndex = 2;
            this.btnBezar.Text = "Bezár";
            this.btnBezar.UseVisualStyleBackColor = false;
            this.btnBezar.Click += new System.EventHandler(this.btnBezar_Click);
            // 
            // FormSzemelyek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(394, 294);
            this.Controls.Add(this.btnBezar);
            this.Controls.Add(this.dataGridViewSzemelyek);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormSzemelyek";
            this.Text = "Személyek";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSzemelyek)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSzemelyek;
        private System.Windows.Forms.Button btnBezar;
    }
}