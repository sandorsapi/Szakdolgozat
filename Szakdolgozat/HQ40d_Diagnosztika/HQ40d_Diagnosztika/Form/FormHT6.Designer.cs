﻿namespace HQ40d_Diagnosztika
{
    partial class FormHT6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHT6));
            this.btnBezar = new System.Windows.Forms.Button();
            this.dataGridViewKivHT6KH = new System.Windows.Forms.DataGridView();
            this.rbtnVezetokepesseg = new System.Windows.Forms.RadioButton();
            this.rbtnKemhatas = new System.Windows.Forms.RadioButton();
            this.dataGridViewKivHT6Vezk = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKivHT6KH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKivHT6Vezk)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBezar
            // 
            this.btnBezar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBezar.BackColor = System.Drawing.Color.Gray;
            this.btnBezar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnBezar.FlatAppearance.BorderSize = 0;
            this.btnBezar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnBezar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnBezar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBezar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBezar.ForeColor = System.Drawing.Color.Silver;
            this.btnBezar.Location = new System.Drawing.Point(637, 338);
            this.btnBezar.Name = "btnBezar";
            this.btnBezar.Size = new System.Drawing.Size(74, 26);
            this.btnBezar.TabIndex = 4;
            this.btnBezar.Text = "Bezár";
            this.btnBezar.UseVisualStyleBackColor = false;
            this.btnBezar.Click += new System.EventHandler(this.btnBezar_Click);
            // 
            // dataGridViewKivHT6KH
            // 
            this.dataGridViewKivHT6KH.AllowUserToAddRows = false;
            this.dataGridViewKivHT6KH.AllowUserToDeleteRows = false;
            this.dataGridViewKivHT6KH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKivHT6KH.Location = new System.Drawing.Point(51, 35);
            this.dataGridViewKivHT6KH.Name = "dataGridViewKivHT6KH";
            this.dataGridViewKivHT6KH.ReadOnly = true;
            this.dataGridViewKivHT6KH.Size = new System.Drawing.Size(620, 262);
            this.dataGridViewKivHT6KH.TabIndex = 6;
            this.dataGridViewKivHT6KH.Visible = false;
            // 
            // rbtnVezetokepesseg
            // 
            this.rbtnVezetokepesseg.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnVezetokepesseg.AutoSize = true;
            this.rbtnVezetokepesseg.BackColor = System.Drawing.Color.Blue;
            this.rbtnVezetokepesseg.Checked = true;
            this.rbtnVezetokepesseg.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.rbtnVezetokepesseg.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkBlue;
            this.rbtnVezetokepesseg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.rbtnVezetokepesseg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.rbtnVezetokepesseg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnVezetokepesseg.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbtnVezetokepesseg.ForeColor = System.Drawing.Color.Yellow;
            this.rbtnVezetokepesseg.Location = new System.Drawing.Point(97, 303);
            this.rbtnVezetokepesseg.Name = "rbtnVezetokepesseg";
            this.rbtnVezetokepesseg.Size = new System.Drawing.Size(59, 29);
            this.rbtnVezetokepesseg.TabIndex = 19;
            this.rbtnVezetokepesseg.TabStop = true;
            this.rbtnVezetokepesseg.Text = "μS/cm";
            this.rbtnVezetokepesseg.UseVisualStyleBackColor = false;
            this.rbtnVezetokepesseg.CheckedChanged += new System.EventHandler(this.rbtnVezetokepesseg_CheckedChanged);
            // 
            // rbtnKemhatas
            // 
            this.rbtnKemhatas.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnKemhatas.AutoSize = true;
            this.rbtnKemhatas.BackColor = System.Drawing.Color.LimeGreen;
            this.rbtnKemhatas.FlatAppearance.BorderColor = System.Drawing.Color.LightGreen;
            this.rbtnKemhatas.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGreen;
            this.rbtnKemhatas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.rbtnKemhatas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.rbtnKemhatas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnKemhatas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbtnKemhatas.ForeColor = System.Drawing.Color.Yellow;
            this.rbtnKemhatas.Location = new System.Drawing.Point(51, 303);
            this.rbtnKemhatas.Name = "rbtnKemhatas";
            this.rbtnKemhatas.Size = new System.Drawing.Size(38, 29);
            this.rbtnKemhatas.TabIndex = 18;
            this.rbtnKemhatas.Text = "pH";
            this.rbtnKemhatas.UseVisualStyleBackColor = false;
            this.rbtnKemhatas.CheckedChanged += new System.EventHandler(this.rbtnKemhatas_CheckedChanged);
            // 
            // dataGridViewKivHT6Vezk
            // 
            this.dataGridViewKivHT6Vezk.AllowUserToAddRows = false;
            this.dataGridViewKivHT6Vezk.AllowUserToDeleteRows = false;
            this.dataGridViewKivHT6Vezk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKivHT6Vezk.Location = new System.Drawing.Point(51, 35);
            this.dataGridViewKivHT6Vezk.Name = "dataGridViewKivHT6Vezk";
            this.dataGridViewKivHT6Vezk.ReadOnly = true;
            this.dataGridViewKivHT6Vezk.Size = new System.Drawing.Size(620, 262);
            this.dataGridViewKivHT6Vezk.TabIndex = 20;
            this.dataGridViewKivHT6Vezk.Visible = false;
            // 
            // FormHT6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(723, 376);
            this.Controls.Add(this.dataGridViewKivHT6Vezk);
            this.Controls.Add(this.rbtnVezetokepesseg);
            this.Controls.Add(this.rbtnKemhatas);
            this.Controls.Add(this.dataGridViewKivHT6KH);
            this.Controls.Add(this.btnBezar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormHT6";
            this.Text = "Hűtőtorony 6 kiválasztott adatok";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKivHT6KH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKivHT6Vezk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.Button btnBezar;
        private System.Windows.Forms.DataGridView dataGridViewKivHT6KH;
        private System.Windows.Forms.RadioButton rbtnVezetokepesseg;
        private System.Windows.Forms.RadioButton rbtnKemhatas;
        private System.Windows.Forms.DataGridView dataGridViewKivHT6Vezk;
    }
}