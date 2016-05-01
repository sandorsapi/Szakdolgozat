namespace HQ40d_Diagnosztika
{
    partial class FormTipus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTipus));
            this.dataGridViewTipus = new System.Windows.Forms.DataGridView();
            this.btnBezar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTipus)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTipus
            // 
            this.dataGridViewTipus.AllowUserToAddRows = false;
            this.dataGridViewTipus.AllowUserToDeleteRows = false;
            this.dataGridViewTipus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTipus.Location = new System.Drawing.Point(27, 31);
            this.dataGridViewTipus.Name = "dataGridViewTipus";
            this.dataGridViewTipus.ReadOnly = true;
            this.dataGridViewTipus.Size = new System.Drawing.Size(281, 84);
            this.dataGridViewTipus.TabIndex = 0;
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
            this.btnBezar.Location = new System.Drawing.Point(253, 164);
            this.btnBezar.Name = "btnBezar";
            this.btnBezar.Size = new System.Drawing.Size(74, 26);
            this.btnBezar.TabIndex = 2;
            this.btnBezar.Text = "Bezár";
            this.btnBezar.UseVisualStyleBackColor = false;
            this.btnBezar.Click += new System.EventHandler(this.btnBezar_Click);
            // 
            // FormTipus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(339, 202);
            this.Controls.Add(this.btnBezar);
            this.Controls.Add(this.dataGridViewTipus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormTipus";
            this.Text = "Mérés típusok";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTipus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTipus;
        private System.Windows.Forms.Button btnBezar;
    }
}