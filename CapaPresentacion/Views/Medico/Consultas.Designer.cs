namespace CapaPresentacion.Views.Medico
{
    partial class Consultas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consultas));
            this.dgvConsultasEnfermero = new System.Windows.Forms.DataGridView();
            this.dgvConsultas = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTraerDatos = new System.Windows.Forms.Button();
            this.cbMedicamentoUno = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbMedicamentoDos = new System.Windows.Forms.ComboBox();
            this.cbMedicamentoTres = new System.Windows.Forms.ComboBox();
            this.cbMedicamentoCuatro = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDiagnostico = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMedico = new System.Windows.Forms.TextBox();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultasEnfermero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultasEnfermero
            // 
            this.dgvConsultasEnfermero.BackgroundColor = System.Drawing.Color.White;
            this.dgvConsultasEnfermero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultasEnfermero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvConsultasEnfermero.Location = new System.Drawing.Point(6, 406);
            this.dgvConsultasEnfermero.Name = "dgvConsultasEnfermero";
            this.dgvConsultasEnfermero.Size = new System.Drawing.Size(486, 352);
            this.dgvConsultasEnfermero.TabIndex = 101;
            // 
            // dgvConsultas
            // 
            this.dgvConsultas.BackgroundColor = System.Drawing.Color.White;
            this.dgvConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvConsultas.Location = new System.Drawing.Point(6, 406);
            this.dgvConsultas.Name = "dgvConsultas";
            this.dgvConsultas.Size = new System.Drawing.Size(805, 352);
            this.dgvConsultas.TabIndex = 102;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(9, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 33);
            this.label3.TabIndex = 108;
            this.label3.Text = "Descripción:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(71, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 33);
            this.label2.TabIndex = 107;
            this.label2.Text = "Médico:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(205, 104);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(256, 71);
            this.txtDesc.TabIndex = 105;
            this.txtDesc.TextChanged += new System.EventHandler(this.txtDesc_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(50, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 33);
            this.label1.TabIndex = 106;
            this.label1.Text = "Paciente:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnTraerDatos
            // 
            this.btnTraerDatos.BackColor = System.Drawing.Color.Transparent;
            this.btnTraerDatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTraerDatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTraerDatos.FlatAppearance.BorderSize = 5;
            this.btnTraerDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraerDatos.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraerDatos.ForeColor = System.Drawing.Color.White;
            this.btnTraerDatos.Location = new System.Drawing.Point(167, 233);
            this.btnTraerDatos.Name = "btnTraerDatos";
            this.btnTraerDatos.Size = new System.Drawing.Size(157, 73);
            this.btnTraerDatos.TabIndex = 109;
            this.btnTraerDatos.Text = "Traer Datos";
            this.btnTraerDatos.UseVisualStyleBackColor = false;
            this.btnTraerDatos.Click += new System.EventHandler(this.btnTraerDatos_Click);
            // 
            // cbMedicamentoUno
            // 
            this.cbMedicamentoUno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMedicamentoUno.FormattingEnabled = true;
            this.cbMedicamentoUno.Location = new System.Drawing.Point(205, 254);
            this.cbMedicamentoUno.Name = "cbMedicamentoUno";
            this.cbMedicamentoUno.Size = new System.Drawing.Size(256, 32);
            this.cbMedicamentoUno.TabIndex = 110;
            this.cbMedicamentoUno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbMedicamentoUno_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(9, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 33);
            this.label4.TabIndex = 111;
            this.label4.Text = "Medicamento:";
            // 
            // cbMedicamentoDos
            // 
            this.cbMedicamentoDos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMedicamentoDos.FormattingEnabled = true;
            this.cbMedicamentoDos.Location = new System.Drawing.Point(205, 292);
            this.cbMedicamentoDos.Name = "cbMedicamentoDos";
            this.cbMedicamentoDos.Size = new System.Drawing.Size(256, 32);
            this.cbMedicamentoDos.TabIndex = 112;
            this.cbMedicamentoDos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbMedicamentoDos_KeyPress);
            // 
            // cbMedicamentoTres
            // 
            this.cbMedicamentoTres.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMedicamentoTres.FormattingEnabled = true;
            this.cbMedicamentoTres.Location = new System.Drawing.Point(205, 330);
            this.cbMedicamentoTres.Name = "cbMedicamentoTres";
            this.cbMedicamentoTres.Size = new System.Drawing.Size(256, 32);
            this.cbMedicamentoTres.TabIndex = 114;
            this.cbMedicamentoTres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbMedicamentoTres_KeyPress);
            // 
            // cbMedicamentoCuatro
            // 
            this.cbMedicamentoCuatro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMedicamentoCuatro.FormattingEnabled = true;
            this.cbMedicamentoCuatro.Location = new System.Drawing.Point(205, 368);
            this.cbMedicamentoCuatro.Name = "cbMedicamentoCuatro";
            this.cbMedicamentoCuatro.Size = new System.Drawing.Size(256, 32);
            this.cbMedicamentoCuatro.TabIndex = 116;
            this.cbMedicamentoCuatro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbMedicamentoCuatro_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(9, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 33);
            this.label8.TabIndex = 119;
            this.label8.Text = "Diagnóstico:";
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiagnostico.Location = new System.Drawing.Point(205, 181);
            this.txtDiagnostico.Multiline = true;
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.Size = new System.Drawing.Size(256, 67);
            this.txtDiagnostico.TabIndex = 118;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnTraerDatos);
            this.groupBox1.Controls.Add(this.dgvConsultasEnfermero);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 765);
            this.groupBox1.TabIndex = 120;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Traer Datos";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(32, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(435, 24);
            this.label9.TabIndex = 110;
            this.label9.Text = "Traer los datos almacenados de las consultas";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.Controls.Add(this.txtMedico);
            this.groupBox2.Controls.Add(this.txtPaciente);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.picExit);
            this.groupBox2.Controls.Add(this.btnEditar);
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.btnGuardar);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtDiagnostico);
            this.groupBox2.Controls.Add(this.cbMedicamentoCuatro);
            this.groupBox2.Controls.Add(this.cbMedicamentoTres);
            this.groupBox2.Controls.Add(this.cbMedicamentoDos);
            this.groupBox2.Controls.Add(this.cbMedicamentoUno);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtDesc);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dgvConsultas);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(515, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(823, 765);
            this.groupBox2.TabIndex = 121;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Diagnóstico";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtMedico
            // 
            this.txtMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedico.Location = new System.Drawing.Point(205, 67);
            this.txtMedico.Multiline = true;
            this.txtMedico.Name = "txtMedico";
            this.txtMedico.Size = new System.Drawing.Size(256, 32);
            this.txtMedico.TabIndex = 128;
            this.txtMedico.TextChanged += new System.EventHandler(this.txtMedico_TextChanged);
            this.txtMedico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMedico_KeyPress);
            // 
            // txtPaciente
            // 
            this.txtPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaciente.Location = new System.Drawing.Point(205, 28);
            this.txtPaciente.Multiline = true;
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Size = new System.Drawing.Size(256, 33);
            this.txtPaciente.TabIndex = 127;
            this.txtPaciente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPaciente_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(9, 367);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(201, 33);
            this.label7.TabIndex = 126;
            this.label7.Text = "Medicamento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(9, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 33);
            this.label6.TabIndex = 125;
            this.label6.Text = "Medicamento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(9, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 33);
            this.label5.TabIndex = 124;
            this.label5.Text = "Medicamento:";
            // 
            // picExit
            // 
            this.picExit.BackColor = System.Drawing.Color.Transparent;
            this.picExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picExit.Image = ((System.Drawing.Image)(resources.GetObject("picExit.Image")));
            this.picExit.Location = new System.Drawing.Point(783, 12);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(40, 40);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picExit.TabIndex = 123;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderSize = 5;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(560, 175);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(157, 73);
            this.btnEditar.TabIndex = 122;
            this.btnEditar.Text = "Actualizar Consulta";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 5;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(560, 292);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(157, 73);
            this.btnEliminar.TabIndex = 121;
            this.btnEliminar.Text = "Eliminar Consulta";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 5;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(560, 49);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(157, 73);
            this.btnGuardar.TabIndex = 120;
            this.btnGuardar.Text = "Guargar Diagnostico";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1350, 770);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Consultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultas";
            this.Load += new System.EventHandler(this.Consultas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultasEnfermero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultasEnfermero;
        private System.Windows.Forms.DataGridView dgvConsultas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTraerDatos;
        private System.Windows.Forms.ComboBox cbMedicamentoUno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbMedicamentoDos;
        private System.Windows.Forms.ComboBox cbMedicamentoTres;
        private System.Windows.Forms.ComboBox cbMedicamentoCuatro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDiagnostico;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMedico;
        private System.Windows.Forms.TextBox txtPaciente;
    }
}