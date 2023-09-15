namespace Clase06
{
    partial class FormularioInicial
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
            btnMostrar = new Button();
            lblNombre = new Label();
            lblSalario = new Label();
            lblTareas = new Label();
            rdoMasculino = new RadioButton();
            rdoFemenino = new RadioButton();
            rdoSoltero = new RadioButton();
            rdoCasado = new RadioButton();
            grpGeneros = new GroupBox();
            txtNombre = new TextBox();
            txtSalario = new TextBox();
            cmbTareas = new ComboBox();
            lstEmpleados = new ListBox();
            grpEstadoCivil = new GroupBox();
            btnLimpiar = new Button();
            btnAgregarTarea = new Button();
            dataGridView1 = new DataGridView();
            Tareas = new DataGridViewTextBoxColumn();
            grpGeneros.SuspendLayout();
            grpEstadoCivil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnMostrar
            // 
            btnMostrar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnMostrar.ForeColor = SystemColors.HotTrack;
            btnMostrar.Location = new Point(325, 244);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(107, 32);
            btnMostrar.TabIndex = 0;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(33, 40);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(81, 25);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // lblSalario
            // 
            lblSalario.AutoSize = true;
            lblSalario.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSalario.Location = new Point(33, 87);
            lblSalario.Name = "lblSalario";
            lblSalario.Size = new Size(70, 25);
            lblSalario.TabIndex = 2;
            lblSalario.Text = "Salario";
            // 
            // lblTareas
            // 
            lblTareas.AutoSize = true;
            lblTareas.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTareas.Location = new Point(33, 145);
            lblTareas.Name = "lblTareas";
            lblTareas.Size = new Size(65, 25);
            lblTareas.TabIndex = 3;
            lblTareas.Text = "Tareas";
            // 
            // rdoMasculino
            // 
            rdoMasculino.AutoSize = true;
            rdoMasculino.Location = new Point(6, 30);
            rdoMasculino.Name = "rdoMasculino";
            rdoMasculino.Size = new Size(80, 19);
            rdoMasculino.TabIndex = 4;
            rdoMasculino.TabStop = true;
            rdoMasculino.Text = "Masculino";
            rdoMasculino.UseVisualStyleBackColor = true;
            // 
            // rdoFemenino
            // 
            rdoFemenino.AutoSize = true;
            rdoFemenino.Location = new Point(6, 65);
            rdoFemenino.Name = "rdoFemenino";
            rdoFemenino.Size = new Size(78, 19);
            rdoFemenino.TabIndex = 5;
            rdoFemenino.TabStop = true;
            rdoFemenino.Text = "Femenino";
            rdoFemenino.UseVisualStyleBackColor = true;
            // 
            // rdoSoltero
            // 
            rdoSoltero.AutoSize = true;
            rdoSoltero.Location = new Point(9, 22);
            rdoSoltero.Name = "rdoSoltero";
            rdoSoltero.Size = new Size(73, 19);
            rdoSoltero.TabIndex = 6;
            rdoSoltero.TabStop = true;
            rdoSoltero.Text = "Soltero/a";
            rdoSoltero.UseVisualStyleBackColor = true;
            // 
            // rdoCasado
            // 
            rdoCasado.AutoSize = true;
            rdoCasado.Location = new Point(9, 57);
            rdoCasado.Name = "rdoCasado";
            rdoCasado.Size = new Size(75, 19);
            rdoCasado.TabIndex = 7;
            rdoCasado.TabStop = true;
            rdoCasado.Text = "Casado/a";
            rdoCasado.UseVisualStyleBackColor = true;
            // 
            // grpGeneros
            // 
            grpGeneros.Controls.Add(rdoFemenino);
            grpGeneros.Controls.Add(rdoMasculino);
            grpGeneros.Location = new Point(325, 39);
            grpGeneros.Name = "grpGeneros";
            grpGeneros.Size = new Size(200, 100);
            grpGeneros.TabIndex = 8;
            grpGeneros.TabStop = false;
            grpGeneros.Text = "Generos";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(148, 45);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(143, 23);
            txtNombre.TabIndex = 9;
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(148, 92);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(143, 23);
            txtSalario.TabIndex = 10;
            // 
            // cmbTareas
            // 
            cmbTareas.FormattingEnabled = true;
            cmbTareas.Items.AddRange(new object[] { "Abrir Caja", "Cerrar Caja", "Cocinar", "Limpiar Cocina", "Limpiar Baño", "Atender Clientes" });
            cmbTareas.Location = new Point(148, 150);
            cmbTareas.Name = "cmbTareas";
            cmbTareas.Size = new Size(132, 23);
            cmbTareas.TabIndex = 11;
            // 
            // lstEmpleados
            // 
            lstEmpleados.FormattingEnabled = true;
            lstEmpleados.ItemHeight = 15;
            lstEmpleados.Location = new Point(548, 45);
            lstEmpleados.Name = "lstEmpleados";
            lstEmpleados.Size = new Size(227, 94);
            lstEmpleados.TabIndex = 12;
            lstEmpleados.SelectedIndexChanged += lstEmpleados_SelectedIndexChanged;
            // 
            // grpEstadoCivil
            // 
            grpEstadoCivil.Controls.Add(rdoSoltero);
            grpEstadoCivil.Controls.Add(rdoCasado);
            grpEstadoCivil.Location = new Point(325, 145);
            grpEstadoCivil.Name = "grpEstadoCivil";
            grpEstadoCivil.Size = new Size(200, 93);
            grpEstadoCivil.TabIndex = 13;
            grpEstadoCivil.TabStop = false;
            grpEstadoCivil.Text = "Estado Civil";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(12, 238);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(81, 31);
            btnLimpiar.TabIndex = 14;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnAgregarTarea
            // 
            btnAgregarTarea.Location = new Point(148, 238);
            btnAgregarTarea.Name = "btnAgregarTarea";
            btnAgregarTarea.Size = new Size(109, 31);
            btnAgregarTarea.TabIndex = 15;
            btnAgregarTarea.Text = "Agregar";
            btnAgregarTarea.UseVisualStyleBackColor = true;
            btnAgregarTarea.Click += btnAgregarTarea_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Tareas });
            dataGridView1.Location = new Point(548, 150);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(227, 94);
            dataGridView1.TabIndex = 16;
            // 
            // Tareas
            // 
            Tareas.HeaderText = "Tareas";
            Tareas.Name = "Tareas";
            // 
            // FormularioInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 281);
            Controls.Add(dataGridView1);
            Controls.Add(btnAgregarTarea);
            Controls.Add(btnLimpiar);
            Controls.Add(grpEstadoCivil);
            Controls.Add(lstEmpleados);
            Controls.Add(cmbTareas);
            Controls.Add(txtSalario);
            Controls.Add(txtNombre);
            Controls.Add(grpGeneros);
            Controls.Add(lblTareas);
            Controls.Add(lblSalario);
            Controls.Add(lblNombre);
            Controls.Add(btnMostrar);
            Name = "FormularioInicial";
            Text = "Form1";
            Load += FormularioInicial_Load;
            grpGeneros.ResumeLayout(false);
            grpGeneros.PerformLayout();
            grpEstadoCivil.ResumeLayout(false);
            grpEstadoCivil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMostrar;
        private Label lblNombre;
        private Label lblSalario;
        private Label lblTareas;
        private RadioButton rdoMasculino;
        private RadioButton rdoFemenino;
        private RadioButton rdoSoltero;
        private RadioButton rdoCasado;
        private GroupBox grpGeneros;
        private TextBox txtNombre;
        private TextBox txtSalario;
        private ComboBox cmbTareas;
        private ListBox lstEmpleados;
        private GroupBox grpEstadoCivil;
        private Button btnLimpiar;
        private Button btnAgregarTarea;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Tareas;
    }
}