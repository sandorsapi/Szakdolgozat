namespace HQ40d_Diagnosztika
{
    partial class FormBerendezesek
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBerendezesek));
            this.dataGridViewBerendezesek = new System.Windows.Forms.DataGridView();
            this.btnBezar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbUjBerendezes = new System.Windows.Forms.TextBox();
            this.btnFelvitel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBerendezesek)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBerendezesek
            // 
            this.dataGridViewBerendezesek.AllowUserToAddRows = false;
            this.dataGridViewBerendezesek.AllowUserToDeleteRows = false;
            this.dataGridViewBerendezesek.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewBerendezesek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBerendezesek.Location = new System.Drawing.Point(59, 85);
            this.dataGridViewBerendezesek.Name = "dataGridViewBerendezesek";
            this.dataGridViewBerendezesek.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBerendezesek.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewBerendezesek.Size = new System.Drawing.Size(264, 237);
            this.dataGridViewBerendezesek.TabIndex = 0;
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
            this.btnBezar.Location = new System.Drawing.Point(293, 349);
            this.btnBezar.Name = "btnBezar";
            this.btnBezar.Size = new System.Drawing.Size(74, 26);
            this.btnBezar.TabIndex = 1;
            this.btnBezar.Text = "Bezár";
            this.btnBezar.UseVisualStyleBackColor = false;
            this.btnBezar.Click += new System.EventHandler(this.btnBezar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(24, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Új berendezés";
            // 
            // tbUjBerendezes
            // 
            this.tbUjBerendezes.Location = new System.Drawing.Point(27, 35);
            this.tbUjBerendezes.Name = "tbUjBerendezes";
            this.tbUjBerendezes.Size = new System.Drawing.Size(252, 20);
            this.tbUjBerendezes.TabIndex = 3;
            // 
            // btnFelvitel
            // 
            this.btnFelvitel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFelvitel.Location = new System.Drawing.Point(285, 34);
            this.btnFelvitel.Name = "btnFelvitel";
            this.btnFelvitel.Size = new System.Drawing.Size(63, 23);
            this.btnFelvitel.TabIndex = 4;
            this.btnFelvitel.Text = "Felvitel";
            this.btnFelvitel.UseVisualStyleBackColor = true;
            this.btnFelvitel.Click += new System.EventHandler(this.btnFelvitel_Click);
            // 
            // FormBerendezesek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(379, 387);
            this.Controls.Add(this.btnFelvitel);
            this.Controls.Add(this.tbUjBerendezes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBezar);
            this.Controls.Add(this.dataGridViewBerendezesek);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormBerendezesek";
            this.Text = "Berendezések";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBerendezesek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBerendezesek;
        private System.Windows.Forms.Button btnBezar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUjBerendezes;
        private System.Windows.Forms.Button btnFelvitel;
    }
}