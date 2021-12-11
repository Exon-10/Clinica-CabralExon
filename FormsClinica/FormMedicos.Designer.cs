namespace FormsClinica
{
    partial class FormMedicos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMedicos));
            this.tituloPacientes = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.textNombreM = new System.Windows.Forms.TextBox();
            this.textApellidoM = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAgregarMedicos = new System.Windows.Forms.Button();
            this.comboEspecialM = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tituloPacientes
            // 
            this.tituloPacientes.AutoSize = true;
            this.tituloPacientes.BackColor = System.Drawing.SystemColors.Control;
            this.tituloPacientes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tituloPacientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(24)))), ((int)(((byte)(46)))));
            this.tituloPacientes.Location = new System.Drawing.Point(110, 34);
            this.tituloPacientes.Name = "tituloPacientes";
            this.tituloPacientes.Size = new System.Drawing.Size(133, 33);
            this.tituloPacientes.TabIndex = 21;
            this.tituloPacientes.Text = "Medicos";
            // 
            // dataGridView2
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(56)))));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(28)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGridView2.Location = new System.Drawing.Point(119, 126);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 50;
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(536, 348);
            this.dataGridView2.TabIndex = 22;
            // 
            // textNombreM
            // 
            this.textNombreM.Location = new System.Drawing.Point(269, 86);
            this.textNombreM.Name = "textNombreM";
            this.textNombreM.PlaceholderText = "Nombre";
            this.textNombreM.Size = new System.Drawing.Size(90, 23);
            this.textNombreM.TabIndex = 24;
            // 
            // textApellidoM
            // 
            this.textApellidoM.Location = new System.Drawing.Point(368, 86);
            this.textApellidoM.Name = "textApellidoM";
            this.textApellidoM.PlaceholderText = "Apellido";
            this.textApellidoM.Size = new System.Drawing.Size(90, 23);
            this.textApellidoM.TabIndex = 25;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(24)))), ((int)(((byte)(46)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(119, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 23);
            this.button2.TabIndex = 28;
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAgregarMedicos
            // 
            this.btnAgregarMedicos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(24)))), ((int)(((byte)(46)))));
            this.btnAgregarMedicos.FlatAppearance.BorderSize = 0;
            this.btnAgregarMedicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarMedicos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregarMedicos.Location = new System.Drawing.Point(586, 86);
            this.btnAgregarMedicos.Name = "btnAgregarMedicos";
            this.btnAgregarMedicos.Size = new System.Drawing.Size(69, 23);
            this.btnAgregarMedicos.TabIndex = 29;
            this.btnAgregarMedicos.Text = "Agregar";
            this.btnAgregarMedicos.UseVisualStyleBackColor = false;
            this.btnAgregarMedicos.Click += new System.EventHandler(this.btnAgregarMedicos_Click);
            // 
            // comboEspecialM
            // 
            this.comboEspecialM.Items.AddRange(new object[] {
            "Cardiología",
            "Dermatologia",
            "Endocrinología",
            "Gastroenterología                 ",
            "Ginecología",
            "Odontologia",
            "Oncología",
            "Pediatria"});
            this.comboEspecialM.Location = new System.Drawing.Point(469, 86);
            this.comboEspecialM.Name = "comboEspecialM";
            this.comboEspecialM.Size = new System.Drawing.Size(102, 23);
            this.comboEspecialM.Sorted = true;
            this.comboEspecialM.TabIndex = 30;
            this.comboEspecialM.Text = "Especialidad";
            this.comboEspecialM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboEspecialM_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(169, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "ID";
            this.textBox1.Size = new System.Drawing.Size(91, 23);
            this.textBox1.TabIndex = 31;
            // 
            // FormMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 497);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboEspecialM);
            this.Controls.Add(this.btnAgregarMedicos);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textApellidoM);
            this.Controls.Add(this.textNombreM);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.tituloPacientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMedicos";
            this.Text = "FormMedicos";
            this.Load += new System.EventHandler(this.FormMedicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloPacientes;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textNombreM;
        private System.Windows.Forms.TextBox textApellidoM;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAgregarMedicos;
        private System.Windows.Forms.ComboBox comboEspecialM;
        private System.Windows.Forms.TextBox textBox1;
    }
}