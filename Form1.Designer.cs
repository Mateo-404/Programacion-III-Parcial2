namespace PracticaForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbDetalleUsuario = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mtbCUIT = new System.Windows.Forms.MaskedTextBox();
            this.nupEdad = new System.Windows.Forms.NumericUpDown();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbGenero = new System.Windows.Forms.GroupBox();
            this.rbNoBinario = new System.Windows.Forms.RadioButton();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.gbCurso = new System.Windows.Forms.GroupBox();
            this.chkJavaScript = new System.Windows.Forms.CheckBox();
            this.chkCplus = new System.Windows.Forms.CheckBox();
            this.chkc = new System.Windows.Forms.CheckBox();
            this.lbPais = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btoIngresar = new System.Windows.Forms.Button();
            this.gbDetalleUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupEdad)).BeginInit();
            this.gbGenero.SuspendLayout();
            this.gbCurso.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDetalleUsuario
            // 
            this.gbDetalleUsuario.Controls.Add(this.label5);
            this.gbDetalleUsuario.Controls.Add(this.mtbCUIT);
            this.gbDetalleUsuario.Controls.Add(this.nupEdad);
            this.gbDetalleUsuario.Controls.Add(this.txtDireccion);
            this.gbDetalleUsuario.Controls.Add(this.txtNombre);
            this.gbDetalleUsuario.Controls.Add(this.label3);
            this.gbDetalleUsuario.Controls.Add(this.label2);
            this.gbDetalleUsuario.Controls.Add(this.label1);
            this.gbDetalleUsuario.Location = new System.Drawing.Point(34, 23);
            this.gbDetalleUsuario.Name = "gbDetalleUsuario";
            this.gbDetalleUsuario.Size = new System.Drawing.Size(303, 162);
            this.gbDetalleUsuario.TabIndex = 15;
            this.gbDetalleUsuario.TabStop = false;
            this.gbDetalleUsuario.Text = "Detalle del Usuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "CUIT/L";
            // 
            // mtbCUIT
            // 
            this.mtbCUIT.Location = new System.Drawing.Point(83, 124);
            this.mtbCUIT.Mask = "00-00000000-0";
            this.mtbCUIT.Name = "mtbCUIT";
            this.mtbCUIT.Size = new System.Drawing.Size(177, 25);
            this.mtbCUIT.TabIndex = 6;
            // 
            // nupEdad
            // 
            this.nupEdad.Location = new System.Drawing.Point(83, 93);
            this.nupEdad.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nupEdad.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.nupEdad.Name = "nupEdad";
            this.nupEdad.Size = new System.Drawing.Size(177, 25);
            this.nupEdad.TabIndex = 5;
            this.nupEdad.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(81, 62);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(177, 25);
            this.txtDireccion.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(83, 30);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(177, 25);
            this.txtNombre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Edad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dirección";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // gbGenero
            // 
            this.gbGenero.Controls.Add(this.rbNoBinario);
            this.gbGenero.Controls.Add(this.rbFemenino);
            this.gbGenero.Controls.Add(this.rbMasculino);
            this.gbGenero.Location = new System.Drawing.Point(343, 23);
            this.gbGenero.Name = "gbGenero";
            this.gbGenero.Size = new System.Drawing.Size(137, 132);
            this.gbGenero.TabIndex = 16;
            this.gbGenero.TabStop = false;
            this.gbGenero.Text = "Genero";
            // 
            // rbNoBinario
            // 
            this.rbNoBinario.AutoSize = true;
            this.rbNoBinario.Location = new System.Drawing.Point(19, 97);
            this.rbNoBinario.Name = "rbNoBinario";
            this.rbNoBinario.Size = new System.Drawing.Size(91, 23);
            this.rbNoBinario.TabIndex = 10;
            this.rbNoBinario.TabStop = true;
            this.rbNoBinario.Text = "No Binario";
            this.rbNoBinario.UseVisualStyleBackColor = true;
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Location = new System.Drawing.Point(19, 68);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(87, 23);
            this.rbFemenino.TabIndex = 9;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(19, 39);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(89, 23);
            this.rbMasculino.TabIndex = 8;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // gbCurso
            // 
            this.gbCurso.Controls.Add(this.chkJavaScript);
            this.gbCurso.Controls.Add(this.chkCplus);
            this.gbCurso.Controls.Add(this.chkc);
            this.gbCurso.Location = new System.Drawing.Point(343, 192);
            this.gbCurso.Name = "gbCurso";
            this.gbCurso.Size = new System.Drawing.Size(125, 124);
            this.gbCurso.TabIndex = 17;
            this.gbCurso.TabStop = false;
            this.gbCurso.Text = "Curso";
            // 
            // chkJavaScript
            // 
            this.chkJavaScript.AutoSize = true;
            this.chkJavaScript.Location = new System.Drawing.Point(18, 87);
            this.chkJavaScript.Name = "chkJavaScript";
            this.chkJavaScript.Size = new System.Drawing.Size(88, 23);
            this.chkJavaScript.TabIndex = 13;
            this.chkJavaScript.Text = "JavaScript";
            this.chkJavaScript.UseVisualStyleBackColor = true;
            // 
            // chkCplus
            // 
            this.chkCplus.AutoSize = true;
            this.chkCplus.Location = new System.Drawing.Point(18, 58);
            this.chkCplus.Name = "chkCplus";
            this.chkCplus.Size = new System.Drawing.Size(57, 23);
            this.chkCplus.TabIndex = 12;
            this.chkCplus.Text = "C++";
            this.chkCplus.UseVisualStyleBackColor = true;
            // 
            // chkc
            // 
            this.chkc.AutoSize = true;
            this.chkc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkc.Location = new System.Drawing.Point(18, 29);
            this.chkc.Name = "chkc";
            this.chkc.Size = new System.Drawing.Size(42, 23);
            this.chkc.TabIndex = 11;
            this.chkc.Text = "C#";
            this.chkc.UseVisualStyleBackColor = true;
            // 
            // lbPais
            // 
            this.lbPais.FormattingEnabled = true;
            this.lbPais.ItemHeight = 17;
            this.lbPais.Items.AddRange(new object[] {
            "Argentina",
            "Brazil",
            "Chile ",
            "Peru"});
            this.lbPais.Location = new System.Drawing.Point(114, 227);
            this.lbPais.Name = "lbPais";
            this.lbPais.Size = new System.Drawing.Size(177, 89);
            this.lbPais.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "País";
            // 
            // btoIngresar
            // 
            this.btoIngresar.Location = new System.Drawing.Point(325, 341);
            this.btoIngresar.Name = "btoIngresar";
            this.btoIngresar.Size = new System.Drawing.Size(124, 27);
            this.btoIngresar.TabIndex = 14;
            this.btoIngresar.Text = "Ingresar";
            this.btoIngresar.UseVisualStyleBackColor = true;
            this.btoIngresar.Click += new System.EventHandler(this.btoIngresar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(504, 387);
            this.Controls.Add(this.btoIngresar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbPais);
            this.Controls.Add(this.gbGenero);
            this.Controls.Add(this.gbCurso);
            this.Controls.Add(this.gbDetalleUsuario);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Registro";
            this.gbDetalleUsuario.ResumeLayout(false);
            this.gbDetalleUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupEdad)).EndInit();
            this.gbGenero.ResumeLayout(false);
            this.gbGenero.PerformLayout();
            this.gbCurso.ResumeLayout(false);
            this.gbCurso.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox gbDetalleUsuario;
        private GroupBox gbGenero;
        private RadioButton rbNoBinario;
        private RadioButton rbFemenino;
        private RadioButton rbMasculino;
        private GroupBox gbCurso;
        private TextBox txtDireccion;
        private TextBox txtNombre;
        private Label label3;
        private Label label2;
        private Label label1;
        private CheckBox chkJavaScript;
        private CheckBox chkCplus;
        private CheckBox chkc;
        private NumericUpDown nupEdad;
        private ListBox lbPais;
        private Label label4;
        private Button btoIngresar;
        private Label label5;
        private MaskedTextBox mtbCUIT;
    }
}