﻿namespace HQ40d_Diagnosztika
{
    partial class FormDuo10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDuo10));
            this.btnBezar = new System.Windows.Forms.Button();
            this.dataGridViewKivDuo10KH = new System.Windows.Forms.DataGridView();
            this.rbtnVezetokepesseg = new System.Windows.Forms.RadioButton();
            this.rbtnKemhatas = new System.Windows.Forms.RadioButton();
            this.dataGridViewKivDuo10Vezk = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKivDuo10KH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKivDuo10Vezk)).BeginInit();
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
            // dataGridViewKivDuo10KH
            // 
            this.dataGridViewKivDuo10KH.AllowUserToAddRows = false;
            this.dataGridViewKivDuo10KH.AllowUserToDeleteRows = false;
            this.dataGridViewKivDuo10KH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKivDuo10KH.Location = new System.Drawing.Point(51, 35);
            this.dataGridViewKivDuo10KH.Name = "dataGridViewKivDuo10KH";
            this.dataGridViewKivDuo10KH.ReadOnly = true;
            this.dataGridViewKivDuo10KH.Size = new System.Drawing.Size(620, 262);
            this.dataGridViewKivDuo10KH.TabIndex = 6;
            this.dataGridViewKivDuo10KH.Visible = false;
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
            // dataGridViewKivDuo10Vezk
            // 
            this.dataGridViewKivDuo10Vezk.AllowUserToAddRows = false;
            this.dataGridViewKivDuo10Vezk.AllowUserToDeleteRows = false;
            this.dataGridViewKivDuo10Vezk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKivDuo10Vezk.Location = new System.Drawing.Point(51, 35);
            this.dataGridViewKivDuo10Vezk.Name = "dataGridViewKivDuo10Vezk";
            this.dataGridViewKivDuo10Vezk.ReadOnly = true;
            this.dataGridViewKivDuo10Vezk.Size = new System.Drawing.Size(620, 262);
            this.dataGridViewKivDuo10Vezk.TabIndex = 20;
            this.dataGridViewKivDuo10Vezk.Visible = false;
            // 
            // FormDuo10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(723, 376);
            this.Controls.Add(this.dataGridViewKivDuo10Vezk);
            this.Controls.Add(this.rbtnVezetokepesseg);
            this.Controls.Add(this.rbtnKemhatas);
            this.Controls.Add(this.dataGridViewKivDuo10KH);
            this.Controls.Add(this.btnBezar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormDuo10";
            this.Text = "Duo10 kiválasztott adatok";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKivDuo10KH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKivDuo10Vezk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewKivDuo10KH;
        private System.Windows.Forms.Button btnBezar;
        private System.Windows.Forms.RadioButton rbtnVezetokepesseg;
        private System.Windows.Forms.RadioButton rbtnKemhatas;
        private System.Windows.Forms.DataGridView dataGridViewKivDuo10Vezk;        
    }
}