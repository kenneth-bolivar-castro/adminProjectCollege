namespace Capa.UI
{
    partial class FrmCreadorProy
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NumCostoEst = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupbox2 = new System.Windows.Forms.GroupBox();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.lstUsuariosCont = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboUsuarios = new System.Windows.Forms.ComboBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumCostoEst)).BeginInit();
            this.groupbox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NumCostoEst);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(73, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 264);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles";
            // 
            // NumCostoEst
            // 
            this.NumCostoEst.Location = new System.Drawing.Point(249, 147);
            this.NumCostoEst.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumCostoEst.Name = "NumCostoEst";
            this.NumCostoEst.Size = new System.Drawing.Size(120, 31);
            this.NumCostoEst.TabIndex = 5;
            this.NumCostoEst.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Costo Hora";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(207, 56);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(205, 31);
            this.txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // groupbox2
            // 
            this.groupbox2.Controls.Add(this.btnQuitar);
            this.groupbox2.Controls.Add(this.btnIncluir);
            this.groupbox2.Controls.Add(this.lstUsuariosCont);
            this.groupbox2.Controls.Add(this.label3);
            this.groupbox2.Controls.Add(this.cboUsuarios);
            this.groupbox2.Location = new System.Drawing.Point(73, 487);
            this.groupbox2.Name = "groupbox2";
            this.groupbox2.Size = new System.Drawing.Size(977, 404);
            this.groupbox2.TabIndex = 1;
            this.groupbox2.TabStop = false;
            this.groupbox2.Text = "Usuarios";
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(552, 241);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(121, 36);
            this.btnQuitar.TabIndex = 4;
            this.btnQuitar.Text = "<===";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(552, 148);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(121, 36);
            this.btnIncluir.TabIndex = 3;
            this.btnIncluir.Text = "===>";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // lstUsuariosCont
            // 
            this.lstUsuariosCont.FormattingEnabled = true;
            this.lstUsuariosCont.ItemHeight = 25;
            this.lstUsuariosCont.Location = new System.Drawing.Point(711, 55);
            this.lstUsuariosCont.Name = "lstUsuariosCont";
            this.lstUsuariosCont.Size = new System.Drawing.Size(246, 329);
            this.lstUsuariosCont.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Usuarios";
            // 
            // cboUsuarios
            // 
            this.cboUsuarios.FormattingEnabled = true;
            this.cboUsuarios.Location = new System.Drawing.Point(207, 194);
            this.cboUsuarios.Name = "cboUsuarios";
            this.cboUsuarios.Size = new System.Drawing.Size(285, 33);
            this.cboUsuarios.TabIndex = 0;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(673, 191);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(329, 88);
            this.btnCrear.TabIndex = 2;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // FrmCreadorProy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Capa.UI.Properties.Resources.abstract_wavy;
            this.ClientSize = new System.Drawing.Size(1153, 962);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.groupbox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmCreadorProy";
            this.Text = "FrmCreadorProy";
            this.Load += new System.EventHandler(this.FrmCreadorProy_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumCostoEst)).EndInit();
            this.groupbox2.ResumeLayout(false);
            this.groupbox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupbox2;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.ListBox lstUsuariosCont;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboUsuarios;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.NumericUpDown NumCostoEst;
        private System.Windows.Forms.Label label4;
    }
}