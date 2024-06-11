namespace PracticaForm
{
    partial class Form3
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            cbExpJavaScript = new CheckBox();
            cbExpCPlus = new CheckBox();
            cbCExp = new CheckBox();
            groupBox2 = new GroupBox();
            rbJSON = new RadioButton();
            rbXML = new RadioButton();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(252, 38);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(242, 38);
            label1.TabIndex = 0;
            label1.Text = "Exportaciones";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbExpJavaScript);
            groupBox1.Controls.Add(cbExpCPlus);
            groupBox1.Controls.Add(cbCExp);
            groupBox1.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(523, 116);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(190, 141);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cursos";
            // 
            // cbExpJavaScript
            // 
            cbExpJavaScript.AutoSize = true;
            cbExpJavaScript.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbExpJavaScript.Location = new Point(6, 88);
            cbExpJavaScript.Name = "cbExpJavaScript";
            cbExpJavaScript.Size = new Size(103, 22);
            cbExpJavaScript.TabIndex = 16;
            cbExpJavaScript.Text = "JavaScript";
            cbExpJavaScript.UseVisualStyleBackColor = true;
            // 
            // cbExpCPlus
            // 
            cbExpCPlus.AutoSize = true;
            cbExpCPlus.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbExpCPlus.Location = new Point(6, 59);
            cbExpCPlus.Name = "cbExpCPlus";
            cbExpCPlus.Size = new Size(62, 22);
            cbExpCPlus.TabIndex = 15;
            cbExpCPlus.Text = "C++";
            cbExpCPlus.UseVisualStyleBackColor = true;
            // 
            // cbCExp
            // 
            cbCExp.Cursor = Cursors.No;
            cbCExp.FlatStyle = FlatStyle.Flat;
            cbCExp.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbCExp.Location = new Point(6, 30);
            cbCExp.Name = "cbCExp";
            cbCExp.Size = new Size(52, 23);
            cbCExp.TabIndex = 14;
            cbCExp.Text = "C#";
            cbCExp.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbJSON);
            groupBox2.Controls.Add(rbXML);
            groupBox2.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(83, 126);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(190, 118);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Formato";
            // 
            // rbJSON
            // 
            rbJSON.AutoSize = true;
            rbJSON.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            rbJSON.Location = new Point(6, 68);
            rbJSON.Name = "rbJSON";
            rbJSON.Size = new Size(60, 22);
            rbJSON.TabIndex = 10;
            rbJSON.TabStop = true;
            rbJSON.Text = "Json";
            rbJSON.UseVisualStyleBackColor = true;
            // 
            // rbXML
            // 
            rbXML.AutoSize = true;
            rbXML.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            rbXML.Location = new Point(6, 40);
            rbXML.Name = "rbXML";
            rbXML.Size = new Size(57, 22);
            rbXML.TabIndex = 9;
            rbXML.TabStop = true;
            rbXML.Text = "XML";
            rbXML.UseVisualStyleBackColor = true;
            rbXML.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(290, 317);
            button1.Name = "button1";
            button1.Size = new Size(165, 53);
            button1.TabIndex = 9;
            button1.Text = "Exportar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Exportaciones";
            Load += Form3_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton rbXML;
        private RadioButton rbJSON;
        private Button button1;
        private CheckBox cbExpJavaScript;
        private CheckBox cbExpCPlus;
        private CheckBox cbCExp;
    }
}