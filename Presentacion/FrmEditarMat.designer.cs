﻿namespace Presentacion
{
    partial class FrmEditarMat
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lblElegir = new System.Windows.Forms.Label();
            this.txtMatriculas = new System.Windows.Forms.TextBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.dgvMatriculas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriculas)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(379, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 46);
            this.label2.TabIndex = 9;
            this.label2.Text = "CEAT N°1";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(421, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "San Vicente";
            // 
            // lineShape1
            // 
            this.lineShape1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lineShape1.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape1.BorderWidth = 2;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 88;
            this.lineShape1.X2 = 639;
            this.lineShape1.Y1 = 86;
            this.lineShape1.Y2 = 86;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(955, 575);
            this.shapeContainer1.TabIndex = 10;
            this.shapeContainer1.TabStop = false;
            // 
            // lblElegir
            // 
            this.lblElegir.AllowDrop = true;
            this.lblElegir.AutoSize = true;
            this.lblElegir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElegir.Location = new System.Drawing.Point(55, 140);
            this.lblElegir.Name = "lblElegir";
            this.lblElegir.Size = new System.Drawing.Size(117, 18);
            this.lblElegir.TabIndex = 11;
            this.lblElegir.Text = "Elegir Matricula :";
            // 
            // txtMatriculas
            // 
            this.txtMatriculas.AllowDrop = true;
            this.txtMatriculas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtMatriculas.Location = new System.Drawing.Point(178, 140);
            this.txtMatriculas.Name = "txtMatriculas";
            this.txtMatriculas.Size = new System.Drawing.Size(638, 20);
            this.txtMatriculas.TabIndex = 12;
            this.txtMatriculas.TextChanged += new System.EventHandler(this.txtMatriculas_TextChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(694, 183);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(122, 17);
            this.radioButton3.TabIndex = 23;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Todas las Matriculas";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(424, 183);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(118, 17);
            this.radioButton2.TabIndex = 22;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Matriculas inactivas";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(178, 183);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(110, 17);
            this.radioButton1.TabIndex = 21;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Matriculas activas";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // dgvMatriculas
            // 
            this.dgvMatriculas.AllowDrop = true;
            this.dgvMatriculas.AllowUserToAddRows = false;
            this.dgvMatriculas.AllowUserToDeleteRows = false;
            this.dgvMatriculas.BackgroundColor = System.Drawing.Color.White;
            this.dgvMatriculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatriculas.Location = new System.Drawing.Point(12, 206);
            this.dgvMatriculas.Name = "dgvMatriculas";
            this.dgvMatriculas.ReadOnly = true;
            this.dgvMatriculas.RowHeadersVisible = false;
            this.dgvMatriculas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMatriculas.Size = new System.Drawing.Size(915, 357);
            this.dgvMatriculas.TabIndex = 24;
            this.dgvMatriculas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatriculas_CellContentClick);
            // 
            // FrmEditarMat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(955, 575);
            this.Controls.Add(this.dgvMatriculas);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.txtMatriculas);
            this.Controls.Add(this.lblElegir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.shapeContainer1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEditarMat";
            this.Text = "FrmUsuario";
            this.Load += new System.EventHandler(this.FrmEditarMat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriculas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Label lblElegir;
        private System.Windows.Forms.TextBox txtMatriculas;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DataGridView dgvMatriculas;
    }
}