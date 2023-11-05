namespace Presentacion
{
    partial class FrmBajaMat
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
            this.dgvMatriculas = new System.Windows.Forms.DataGridView();
            this.txtBajaMatricula = new System.Windows.Forms.TextBox();
            this.lblElegir = new System.Windows.Forms.Label();
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
            this.lineShape1.X2 = 922;
            this.lineShape1.Y1 = 87;
            this.lineShape1.Y2 = 87;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(955, 608);
            this.shapeContainer1.TabIndex = 10;
            this.shapeContainer1.TabStop = false;
            // 
            // dgvMatriculas
            // 
            this.dgvMatriculas.AllowDrop = true;
            this.dgvMatriculas.BackgroundColor = System.Drawing.Color.White;
            this.dgvMatriculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatriculas.Location = new System.Drawing.Point(34, 176);
            this.dgvMatriculas.Name = "dgvMatriculas";
            this.dgvMatriculas.ReadOnly = true;
            this.dgvMatriculas.RowHeadersVisible = false;
            this.dgvMatriculas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMatriculas.Size = new System.Drawing.Size(889, 399);
            this.dgvMatriculas.TabIndex = 13;
            this.dgvMatriculas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatriculas_CellContentClick);
            // 
            // txtBajaMatricula
            // 
            this.txtBajaMatricula.AllowDrop = true;
            this.txtBajaMatricula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtBajaMatricula.Location = new System.Drawing.Point(251, 131);
            this.txtBajaMatricula.Name = "txtBajaMatricula";
            this.txtBajaMatricula.Size = new System.Drawing.Size(638, 20);
            this.txtBajaMatricula.TabIndex = 25;
            this.txtBajaMatricula.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblElegir
            // 
            this.lblElegir.AllowDrop = true;
            this.lblElegir.AutoSize = true;
            this.lblElegir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElegir.Location = new System.Drawing.Point(128, 131);
            this.lblElegir.Name = "lblElegir";
            this.lblElegir.Size = new System.Drawing.Size(117, 18);
            this.lblElegir.TabIndex = 24;
            this.lblElegir.Text = "Elegir Matricula :";
            // 
            // FrmBajaMat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(955, 608);
            this.Controls.Add(this.txtBajaMatricula);
            this.Controls.Add(this.lblElegir);
            this.Controls.Add(this.dgvMatriculas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.shapeContainer1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBajaMat";
            this.Text = "FrmUsuario";
            this.Load += new System.EventHandler(this.FrmBajaMat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatriculas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.DataGridView dgvMatriculas;
        private System.Windows.Forms.TextBox txtBajaMatricula;
        private System.Windows.Forms.Label lblElegir;
    }
}