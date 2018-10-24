namespace Buscar_con_Lucene
{
    partial class frmBuscar
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnIndexar = new System.Windows.Forms.Button();
            this.lblTituloColeccion = new System.Windows.Forms.Label();
            this.lblbusqueda = new System.Windows.Forms.Label();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnlimpiassalida = new System.Windows.Forms.Button();
            this.btnInicializarIndice = new System.Windows.Forms.Button();
            this.btncerrar = new System.Windows.Forms.Button();
            this.dtgColeccion = new System.Windows.Forms.DataGridView();
            this.dtgSalida = new System.Windows.Forms.DataGridView();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblNuevosRegistros = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgColeccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSalida)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIndexar
            // 
            this.btnIndexar.Location = new System.Drawing.Point(26, 172);
            this.btnIndexar.Name = "btnIndexar";
            this.btnIndexar.Size = new System.Drawing.Size(75, 23);
            this.btnIndexar.TabIndex = 0;
            this.btnIndexar.Text = "Indexar";
            this.btnIndexar.UseVisualStyleBackColor = true;
            this.btnIndexar.Click += new System.EventHandler(this.btnIndexar_Click);
            // 
            // lblTituloColeccion
            // 
            this.lblTituloColeccion.AutoSize = true;
            this.lblTituloColeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloColeccion.Location = new System.Drawing.Point(23, 17);
            this.lblTituloColeccion.Name = "lblTituloColeccion";
            this.lblTituloColeccion.Size = new System.Drawing.Size(134, 13);
            this.lblTituloColeccion.TabIndex = 2;
            this.lblTituloColeccion.Text = "Datos a ser Indexados";
            // 
            // lblbusqueda
            // 
            this.lblbusqueda.AutoSize = true;
            this.lblbusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbusqueda.Location = new System.Drawing.Point(23, 215);
            this.lblbusqueda.Name = "lblbusqueda";
            this.lblbusqueda.Size = new System.Drawing.Size(151, 13);
            this.lblbusqueda.TabIndex = 3;
            this.lblbusqueda.Text = "Búsqueda de Información";
            // 
            // txtConsulta
            // 
            this.txtConsulta.Location = new System.Drawing.Point(26, 239);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(378, 20);
            this.txtConsulta.TabIndex = 4;
            this.txtConsulta.Text = "Russia India";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(410, 236);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(92, 23);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnlimpiassalida
            // 
            this.btnlimpiassalida.Location = new System.Drawing.Point(26, 432);
            this.btnlimpiassalida.Name = "btnlimpiassalida";
            this.btnlimpiassalida.Size = new System.Drawing.Size(90, 26);
            this.btnlimpiassalida.TabIndex = 7;
            this.btnlimpiassalida.Text = "Limpiar salida";
            this.btnlimpiassalida.UseVisualStyleBackColor = true;
            // 
            // btnInicializarIndice
            // 
            this.btnInicializarIndice.Location = new System.Drawing.Point(427, 172);
            this.btnInicializarIndice.Name = "btnInicializarIndice";
            this.btnInicializarIndice.Size = new System.Drawing.Size(75, 23);
            this.btnInicializarIndice.TabIndex = 8;
            this.btnInicializarIndice.Text = "Inicializar";
            this.btnInicializarIndice.UseVisualStyleBackColor = true;
            this.btnInicializarIndice.Click += new System.EventHandler(this.btnInicializarIndice_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.Location = new System.Drawing.Point(209, 536);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(90, 26);
            this.btncerrar.TabIndex = 9;
            this.btncerrar.Text = "Cerrar";
            this.btncerrar.UseVisualStyleBackColor = true;
            // 
            // dtgColeccion
            // 
            this.dtgColeccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgColeccion.Location = new System.Drawing.Point(26, 33);
            this.dtgColeccion.Name = "dtgColeccion";
            this.dtgColeccion.Size = new System.Drawing.Size(476, 133);
            this.dtgColeccion.TabIndex = 10;
            // 
            // dtgSalida
            // 
            this.dtgSalida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSalida.Location = new System.Drawing.Point(26, 281);
            this.dtgSalida.Name = "dtgSalida";
            this.dtgSalida.Size = new System.Drawing.Size(476, 145);
            this.dtgSalida.TabIndex = 11;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(107, 177);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(110, 13);
            this.lblEstado.TabIndex = 12;
            this.lblEstado.Text = "Indice Aun no Creado";
            // 
            // lblNuevosRegistros
            // 
            this.lblNuevosRegistros.AutoSize = true;
            this.lblNuevosRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevosRegistros.Location = new System.Drawing.Point(23, 473);
            this.lblNuevosRegistros.Name = "lblNuevosRegistros";
            this.lblNuevosRegistros.Size = new System.Drawing.Size(194, 13);
            this.lblNuevosRegistros.TabIndex = 13;
            this.lblNuevosRegistros.Text = "Crear Nuevos Registros al Indice";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 502);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Id:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(56, 499);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(31, 20);
            this.txtId.TabIndex = 15;
            this.txtId.Text = "8";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 503);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(146, 499);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 17;
            this.txtNombre.Text = "Popayán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 502);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(324, 499);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 19;
            this.txtDescripcion.Text = "Ciudad en Cauca";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(431, 497);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(70, 23);
            this.btnAgregar.TabIndex = 20;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // frmBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 570);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNuevosRegistros);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.dtgSalida);
            this.Controls.Add(this.dtgColeccion);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.btnInicializarIndice);
            this.Controls.Add(this.btnlimpiassalida);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtConsulta);
            this.Controls.Add(this.lblbusqueda);
            this.Controls.Add(this.lblTituloColeccion);
            this.Controls.Add(this.btnIndexar);
            this.Name = "frmBuscar";
            this.Text = "Ejemplo de Indice con Lucene.NET";
            this.Load += new System.EventHandler(this.frmBuscar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgColeccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSalida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIndexar;
        private System.Windows.Forms.Label lblTituloColeccion;
        private System.Windows.Forms.Label lblbusqueda;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnlimpiassalida;
        private System.Windows.Forms.Button btnInicializarIndice;
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.DataGridView dtgColeccion;
        private System.Windows.Forms.DataGridView dtgSalida;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblNuevosRegistros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnAgregar;
    }
}

