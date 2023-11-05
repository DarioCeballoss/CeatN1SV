namespace Presentacion
{
    partial class FrmAlumnoBorrar
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblGrado = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.btnGuardarBaja = new System.Windows.Forms.Button();
            this.txtBajaCausa = new System.Windows.Forms.TextBox();
            this.FBAJA = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "Alumno";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(311, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 23);
            this.button1.TabIndex = 49;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Causa de la Baja :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDNI);
            this.groupBox1.Controls.Add(this.lblGrado);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.lblApellido);
            this.groupBox1.Location = new System.Drawing.Point(33, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 82);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alumno a dar de baja";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(153, 23);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(32, 13);
            this.lblDNI.TabIndex = 20;
            this.lblDNI.Text = "DNI :";
            // 
            // lblGrado
            // 
            this.lblGrado.AutoSize = true;
            this.lblGrado.Location = new System.Drawing.Point(153, 48);
            this.lblGrado.Name = "lblGrado";
            this.lblGrado.Size = new System.Drawing.Size(42, 13);
            this.lblGrado.TabIndex = 21;
            this.lblGrado.Text = "Grado :";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 23);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 13);
            this.lblNombre.TabIndex = 18;
            this.lblNombre.Text = "Nombre :";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(6, 48);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(50, 13);
            this.lblApellido.TabIndex = 19;
            this.lblApellido.Text = "Apellido :";
            // 
            // btnGuardarBaja
            // 
            this.btnGuardarBaja.BackColor = System.Drawing.Color.Crimson;
            this.btnGuardarBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarBaja.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarBaja.Location = new System.Drawing.Point(121, 362);
            this.btnGuardarBaja.Name = "btnGuardarBaja";
            this.btnGuardarBaja.Size = new System.Drawing.Size(112, 31);
            this.btnGuardarBaja.TabIndex = 52;
            this.btnGuardarBaja.Text = "Dar de Baja";
            this.btnGuardarBaja.UseVisualStyleBackColor = false;
            this.btnGuardarBaja.Click += new System.EventHandler(this.btnGuardarBaja_Click);
            // 
            // txtBajaCausa
            // 
            this.txtBajaCausa.Location = new System.Drawing.Point(33, 245);
            this.txtBajaCausa.Multiline = true;
            this.txtBajaCausa.Name = "txtBajaCausa";
            this.txtBajaCausa.Size = new System.Drawing.Size(297, 99);
            this.txtBajaCausa.TabIndex = 51;
            // 
            // FBAJA
            // 
            this.FBAJA.Location = new System.Drawing.Point(33, 190);
            this.FBAJA.Name = "FBAJA";
            this.FBAJA.Size = new System.Drawing.Size(200, 20);
            this.FBAJA.TabIndex = 50;
            // 
            // FrmAlumnoBorrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 485);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGuardarBaja);
            this.Controls.Add(this.txtBajaCausa);
            this.Controls.Add(this.FBAJA);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAlumnoBorrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAlumnoBorrar";
            this.Load += new System.EventHandler(this.FrmAlumnoBorrar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblGrado;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Button btnGuardarBaja;
        private System.Windows.Forms.TextBox txtBajaCausa;
        private System.Windows.Forms.DateTimePicker FBAJA;
    }
}