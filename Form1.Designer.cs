namespace OrdenamientoApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.tabControlPrincipal = new System.Windows.Forms.TabControl();
            this.tabPageConfiguracion = new System.Windows.Forms.TabPage();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelHeaderTitle = new System.Windows.Forms.Label();
            this.groupBoxResultados = new System.Windows.Forms.GroupBox();
            this.textBoxConclusiones = new System.Windows.Forms.TextBox();
            this.labelConclusiones = new System.Windows.Forms.Label();
            this.groupBoxProgreso = new System.Windows.Forms.GroupBox();
            this.labelProgreso = new System.Windows.Forms.Label();
            this.progressBarEjecucion = new System.Windows.Forms.ProgressBar();
            this.groupBoxEjecucion = new System.Windows.Forms.GroupBox();
            this.buttonExportarPDF = new System.Windows.Forms.Button();
            this.buttonGenerarEstadisticas = new System.Windows.Forms.Button();
            this.buttonGenerarGraficos = new System.Windows.Forms.Button();
            this.buttonVerDatos = new System.Windows.Forms.Button();
            this.buttonEjecutar = new System.Windows.Forms.Button();
            this.groupBoxParametros = new System.Windows.Forms.GroupBox();
            this.labelInfoRangos = new System.Windows.Forms.Label();
            this.numericUpDownMax = new System.Windows.Forms.NumericUpDown();
            this.labelMax = new System.Windows.Forms.Label();
            this.numericUpDownMin = new System.Windows.Forms.NumericUpDown();
            this.labelMin = new System.Windows.Forms.Label();
            this.tabPageDatos = new System.Windows.Forms.TabPage();
            this.panelHeaderDatos = new System.Windows.Forms.Panel();
            this.labelHeaderDatosTitle = new System.Windows.Forms.Label();
            this.groupBoxFiltrosDatos = new System.Windows.Forms.GroupBox();
            this.comboBoxTipoDatos = new System.Windows.Forms.ComboBox();
            this.labelTipoDatos = new System.Windows.Forms.Label();
            this.comboBoxIteracion = new System.Windows.Forms.ComboBox();
            this.labelIteracion = new System.Windows.Forms.Label();
            this.comboBoxTamano = new System.Windows.Forms.ComboBox();
            this.labelTamano = new System.Windows.Forms.Label();
            this.dataGridViewDatos = new System.Windows.Forms.DataGridView();
            this.tabPageMetricas = new System.Windows.Forms.TabPage();
            this.panelHeaderMetricas = new System.Windows.Forms.Panel();
            this.labelHeaderMetricasTitle = new System.Windows.Forms.Label();
            this.groupBoxFiltrosMetricas = new System.Windows.Forms.GroupBox();
            this.comboBoxFiltroIteracion = new System.Windows.Forms.ComboBox();
            this.labelFiltroIteracion = new System.Windows.Forms.Label();
            this.comboBoxFiltroTamano = new System.Windows.Forms.ComboBox();
            this.labelFiltroTamano = new System.Windows.Forms.Label();
            this.comboBoxFiltroTipoDatos = new System.Windows.Forms.ComboBox();
            this.labelFiltroTipoDatos = new System.Windows.Forms.Label();
            this.comboBoxFiltroAlgoritmo = new System.Windows.Forms.ComboBox();
            this.labelFiltroAlgoritmo = new System.Windows.Forms.Label();
            this.dataGridViewMetricasRendimiento = new System.Windows.Forms.DataGridView();
            this.labelMetricasRendimientoTitle = new System.Windows.Forms.Label();
            this.dataGridViewMetricasOperaciones = new System.Windows.Forms.DataGridView();
            this.labelMetricasOperacionesTitle = new System.Windows.Forms.Label();
            this.tabPageEstadisticas = new System.Windows.Forms.TabPage();
            this.panelHeaderEstadisticas = new System.Windows.Forms.Panel();
            this.labelHeaderEstadisticasTitle = new System.Windows.Forms.Label();
            this.groupBoxFiltrosEstadisticas = new System.Windows.Forms.GroupBox();
            this.comboBoxEstFiltroTamano = new System.Windows.Forms.ComboBox();
            this.labelEstFiltroTamano = new System.Windows.Forms.Label();
            this.comboBoxEstFiltroTipoDatos = new System.Windows.Forms.ComboBox();
            this.labelEstFiltroTipoDatos = new System.Windows.Forms.Label();
            this.comboBoxEstFiltroAlgoritmo = new System.Windows.Forms.ComboBox();
            this.labelEstFiltroAlgoritmo = new System.Windows.Forms.Label();
            this.dataGridViewEstadisticas = new System.Windows.Forms.DataGridView();
            this.tabPageGraficos = new System.Windows.Forms.TabPage();
            this.groupBoxFiltrosGraficos = new System.Windows.Forms.GroupBox();
            this.panelLeyendaColores = new System.Windows.Forms.Panel();
            this.panelSwatch1 = new System.Windows.Forms.Panel();
            this.labelSwatch1 = new System.Windows.Forms.Label();
            this.panelSwatch2 = new System.Windows.Forms.Panel();
            this.labelSwatch2 = new System.Windows.Forms.Label();
            this.panelSwatch3 = new System.Windows.Forms.Panel();
            this.labelSwatch3 = new System.Windows.Forms.Label();
            this.panelSwatch4 = new System.Windows.Forms.Panel();
            this.labelSwatch4 = new System.Windows.Forms.Label();
            this.comboBoxGrafTipoGrafico = new System.Windows.Forms.ComboBox();
            this.labelGrafTipoGrafico = new System.Windows.Forms.Label();
            this.comboBoxGrafTipo = new System.Windows.Forms.ComboBox();
            this.labelGrafTipo = new System.Windows.Forms.Label();
            this.comboBoxGrafTamano = new System.Windows.Forms.ComboBox();
            this.labelGrafTamano = new System.Windows.Forms.Label();
            this.chartComparativo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartDatoAleatorio = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartDatoAscendente = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartDatoDescendente = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartDatoRepeticion = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewComparativo = new System.Windows.Forms.DataGridView();
            this.panelHeaderGraficos = new System.Windows.Forms.Panel();
            this.labelHeaderGraficosTitle = new System.Windows.Forms.Label();
            this.labelComparativoGridTitle = new System.Windows.Forms.Label();
            this.comboBoxGrafAlgoritmo = new System.Windows.Forms.ComboBox();
            this.labelGrafAlgoritmo = new System.Windows.Forms.Label();
            this.tabPageComparacionTipos = new System.Windows.Forms.TabPage();
            this.panelHeaderComparacion = new System.Windows.Forms.Panel();
            this.labelHeaderComparacionTitle = new System.Windows.Forms.Label();
            this.chartCompAleatorio = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartCompAscendente = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartCompDescendente = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartCompRepeticion = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelDescComparacion = new System.Windows.Forms.Label();
            this.groupBoxFiltroComparacion = new System.Windows.Forms.GroupBox();
            this.comboBoxFiltroCompTipo = new System.Windows.Forms.ComboBox();
            this.labelFiltroCompTipo = new System.Windows.Forms.Label();
            this.comboBoxFiltroCompAlgoritmo = new System.Windows.Forms.ComboBox();
            this.labelFiltroCompAlgoritmo = new System.Windows.Forms.Label();
            this.buttonFiltroCompAplicar = new System.Windows.Forms.Button();
            this.dataGridViewComparacion = new System.Windows.Forms.DataGridView();
            this.tabControlPrincipal.SuspendLayout();
            this.tabPageConfiguracion.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.groupBoxResultados.SuspendLayout();
            this.groupBoxProgreso.SuspendLayout();
            this.groupBoxEjecucion.SuspendLayout();
            this.groupBoxParametros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).BeginInit();
            this.tabPageDatos.SuspendLayout();
            this.panelHeaderDatos.SuspendLayout();
            this.groupBoxFiltrosDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDatoAleatorio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDatoAscendente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDatoDescendente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDatoRepeticion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatos)).BeginInit();
            this.tabPageMetricas.SuspendLayout();
            this.panelHeaderMetricas.SuspendLayout();
            this.groupBoxFiltrosMetricas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMetricasRendimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMetricasOperaciones)).BeginInit();
            this.tabPageEstadisticas.SuspendLayout();
            this.panelHeaderEstadisticas.SuspendLayout();
            this.groupBoxFiltrosEstadisticas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstadisticas)).BeginInit();
            this.tabPageGraficos.SuspendLayout();
            this.panelHeaderGraficos.SuspendLayout();
            this.groupBoxFiltrosGraficos.SuspendLayout();
            this.panelLeyendaColores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartComparativo)).BeginInit();
            this.tabPageComparacionTipos.SuspendLayout();
            this.panelHeaderComparacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCompAleatorio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCompAscendente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCompDescendente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCompRepeticion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComparacion)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlPrincipal
            // 
            this.tabControlPrincipal.Controls.Add(this.tabPageConfiguracion);
            this.tabControlPrincipal.Controls.Add(this.tabPageDatos);
            this.tabControlPrincipal.Controls.Add(this.tabPageMetricas);
            this.tabControlPrincipal.Controls.Add(this.tabPageEstadisticas);
            this.tabControlPrincipal.Controls.Add(this.tabPageGraficos);
            this.tabControlPrincipal.Controls.Add(this.tabPageComparacionTipos);
            this.tabControlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPrincipal.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControlPrincipal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tabControlPrincipal.Name = "tabControlPrincipal";
            this.tabControlPrincipal.SelectedIndex = 0;
            this.tabControlPrincipal.Size = new System.Drawing.Size(1264, 761);
            this.tabControlPrincipal.TabIndex = 0;
            this.tabControlPrincipal.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControlPrincipal_DrawItem);
            // 
            // tabPageConfiguracion
            // 
            this.tabPageConfiguracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tabPageConfiguracion.Controls.Add(this.panelHeader);
            this.tabPageConfiguracion.Controls.Add(this.groupBoxResultados);
            this.tabPageConfiguracion.Controls.Add(this.groupBoxProgreso);
            this.tabPageConfiguracion.Controls.Add(this.groupBoxEjecucion);
            this.tabPageConfiguracion.Controls.Add(this.groupBoxParametros);
            this.tabPageConfiguracion.Location = new System.Drawing.Point(4, 26);
            this.tabPageConfiguracion.Name = "tabPageConfiguracion";
            this.tabPageConfiguracion.Padding = new System.Windows.Forms.Padding(10);
            this.tabPageConfiguracion.Size = new System.Drawing.Size(1256, 731);
            this.tabPageConfiguracion.TabIndex = 0;
            this.tabPageConfiguracion.Text = "Configuración y Ejecución";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panelHeader.Controls.Add(this.labelHeaderTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1256, 55);
            this.panelHeader.TabIndex = 4;
            // 
            // labelHeaderTitle
            // 
            this.labelHeaderTitle.AutoSize = true;
            this.labelHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeaderTitle.ForeColor = System.Drawing.Color.White;
            this.labelHeaderTitle.Location = new System.Drawing.Point(20, 12);
            this.labelHeaderTitle.Name = "labelHeaderTitle";
            this.labelHeaderTitle.Size = new System.Drawing.Size(365, 30);
            this.labelHeaderTitle.TabIndex = 0;
            this.labelHeaderTitle.Text = "Configuración y Ejecución";
            // 
            // groupBoxResultados
            // 
            this.groupBoxResultados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxResultados.Controls.Add(this.textBoxConclusiones);
            this.groupBoxResultados.Controls.Add(this.labelConclusiones);
            this.groupBoxResultados.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxResultados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.groupBoxResultados.Location = new System.Drawing.Point(640, 65);
            this.groupBoxResultados.Name = "groupBoxResultados";
            this.groupBoxResultados.Size = new System.Drawing.Size(603, 653);
            this.groupBoxResultados.TabIndex = 3;
            this.groupBoxResultados.TabStop = false;
            this.groupBoxResultados.Text = "Conclusiones Automáticas";
            // 
            // textBoxConclusiones
            // 
            this.textBoxConclusiones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxConclusiones.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConclusiones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.textBoxConclusiones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConclusiones.Location = new System.Drawing.Point(9, 50);
            this.textBoxConclusiones.Multiline = true;
            this.textBoxConclusiones.Name = "textBoxConclusiones";
            this.textBoxConclusiones.ReadOnly = true;
            this.textBoxConclusiones.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxConclusiones.Size = new System.Drawing.Size(585, 590);
            this.textBoxConclusiones.TabIndex = 1;
            // 
            // labelConclusiones
            // 
            this.labelConclusiones.AutoSize = true;
            this.labelConclusiones.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConclusiones.Location = new System.Drawing.Point(6, 28);
            this.labelConclusiones.Name = "labelConclusiones";
            this.labelConclusiones.Size = new System.Drawing.Size(361, 15);
            this.labelConclusiones.TabIndex = 0;
            this.labelConclusiones.Text = "Las conclusiones se generarán automáticamente tras las estadísticas.";
            // 
            // groupBoxProgreso
            // 
            this.groupBoxProgreso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxProgreso.Controls.Add(this.labelProgreso);
            this.groupBoxProgreso.Controls.Add(this.progressBarEjecucion);
            this.groupBoxProgreso.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxProgreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.groupBoxProgreso.Location = new System.Drawing.Point(13, 235);
            this.groupBoxProgreso.Name = "groupBoxProgreso";
            this.groupBoxProgreso.Size = new System.Drawing.Size(620, 90);
            this.groupBoxProgreso.TabIndex = 2;
            this.groupBoxProgreso.TabStop = false;
            this.groupBoxProgreso.Text = "Progreso de Ejecución";
            // 
            // labelProgreso
            // 
            this.labelProgreso.AutoSize = true;
            this.labelProgreso.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProgreso.Location = new System.Drawing.Point(9, 28);
            this.labelProgreso.Size = new System.Drawing.Size(602, 17);
            this.labelProgreso.Text = "Estado: Esperando ejecución...";
            // 
            // progressBarEjecucion
            // 
            this.progressBarEjecucion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarEjecucion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.progressBarEjecucion.Location = new System.Drawing.Point(9, 52);
            this.progressBarEjecucion.Name = "progressBarEjecucion";
            this.progressBarEjecucion.Size = new System.Drawing.Size(602, 28);
            this.progressBarEjecucion.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarEjecucion.TabIndex = 0;
            // 
            // groupBoxEjecucion
            // 
            this.groupBoxEjecucion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxEjecucion.Controls.Add(this.buttonExportarPDF);
            this.groupBoxEjecucion.Controls.Add(this.buttonGenerarEstadisticas);
            this.groupBoxEjecucion.Controls.Add(this.buttonGenerarGraficos);
            this.groupBoxEjecucion.Controls.Add(this.buttonVerDatos);
            this.groupBoxEjecucion.Controls.Add(this.buttonEjecutar);
            this.groupBoxEjecucion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxEjecucion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.groupBoxEjecucion.Location = new System.Drawing.Point(13, 345);
            this.groupBoxEjecucion.Name = "groupBoxEjecucion";
            this.groupBoxEjecucion.Size = new System.Drawing.Size(620, 356);
            this.groupBoxEjecucion.TabIndex = 1;
            this.groupBoxEjecucion.TabStop = false;
            this.groupBoxEjecucion.Text = "Acciones";
            // 
            // buttonExportarPDF
            // 
            this.buttonExportarPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(193)))));
            this.buttonExportarPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExportarPDF.FlatAppearance.BorderSize = 0;
            this.buttonExportarPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExportarPDF.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExportarPDF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.buttonExportarPDF.Location = new System.Drawing.Point(170, 251);
            this.buttonExportarPDF.Name = "buttonExportarPDF";
            this.buttonExportarPDF.Size = new System.Drawing.Size(280, 48);
            this.buttonExportarPDF.TabIndex = 4;
            this.buttonExportarPDF.Text = "Exportar Resultados";
            this.buttonExportarPDF.UseVisualStyleBackColor = false;
            this.buttonExportarPDF.Click += new System.EventHandler(this.buttonExportarPDF_Click);
            // 
            // buttonGenerarEstadisticas
            // 
            this.buttonGenerarEstadisticas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(209)))), ((int)(((byte)(163)))));
            this.buttonGenerarEstadisticas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGenerarEstadisticas.FlatAppearance.BorderSize = 0;
            this.buttonGenerarEstadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGenerarEstadisticas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerarEstadisticas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.buttonGenerarEstadisticas.Location = new System.Drawing.Point(310, 168);
            this.buttonGenerarEstadisticas.Name = "buttonGenerarEstadisticas";
            this.buttonGenerarEstadisticas.Size = new System.Drawing.Size(280, 48);
            this.buttonGenerarEstadisticas.TabIndex = 3;
            this.buttonGenerarEstadisticas.Text = "Generar Estadísticas";
            this.buttonGenerarEstadisticas.UseVisualStyleBackColor = false;
            this.buttonGenerarEstadisticas.Click += new System.EventHandler(this.buttonGenerarEstadisticas_Click);
            // 
            // buttonGenerarGraficos
            // 
            this.buttonGenerarGraficos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(228)))), ((int)(((byte)(163)))));
            this.buttonGenerarGraficos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGenerarGraficos.FlatAppearance.BorderSize = 0;
            this.buttonGenerarGraficos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGenerarGraficos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerarGraficos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.buttonGenerarGraficos.Location = new System.Drawing.Point(20, 168);
            this.buttonGenerarGraficos.Name = "buttonGenerarGraficos";
            this.buttonGenerarGraficos.Size = new System.Drawing.Size(280, 48);
            this.buttonGenerarGraficos.TabIndex = 2;
            this.buttonGenerarGraficos.Text = "Generar Gráficos";
            this.buttonGenerarGraficos.UseVisualStyleBackColor = false;
            this.buttonGenerarGraficos.Click += new System.EventHandler(this.buttonGenerarGraficos_Click);
            // 
            // buttonVerDatos
            // 
            this.buttonVerDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.buttonVerDatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVerDatos.FlatAppearance.BorderSize = 0;
            this.buttonVerDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVerDatos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVerDatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.buttonVerDatos.Location = new System.Drawing.Point(310, 85);
            this.buttonVerDatos.Name = "buttonVerDatos";
            this.buttonVerDatos.Size = new System.Drawing.Size(280, 48);
            this.buttonVerDatos.TabIndex = 1;
            this.buttonVerDatos.Text = "Ver Datos Generados";
            this.buttonVerDatos.UseVisualStyleBackColor = false;
            this.buttonVerDatos.Click += new System.EventHandler(this.buttonVerDatos_Click);
            // 
            // buttonEjecutar
            // 
            this.buttonEjecutar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(214)))), ((int)(((byte)(241)))));
            this.buttonEjecutar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEjecutar.FlatAppearance.BorderSize = 0;
            this.buttonEjecutar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEjecutar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEjecutar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.buttonEjecutar.Location = new System.Drawing.Point(20, 85);
            this.buttonEjecutar.Name = "buttonEjecutar";
            this.buttonEjecutar.Size = new System.Drawing.Size(280, 48);
            this.buttonEjecutar.TabIndex = 0;
            this.buttonEjecutar.Text = "Ejecutar Pruebas Completas";
            this.buttonEjecutar.UseVisualStyleBackColor = false;
            this.buttonEjecutar.Click += new System.EventHandler(this.buttonEjecutar_Click);
            // 
            // groupBoxParametros
            // 
            this.groupBoxParametros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxParametros.Controls.Add(this.labelInfoRangos);
            this.groupBoxParametros.Controls.Add(this.numericUpDownMax);
            this.groupBoxParametros.Controls.Add(this.labelMax);
            this.groupBoxParametros.Controls.Add(this.numericUpDownMin);
            this.groupBoxParametros.Controls.Add(this.labelMin);
            this.groupBoxParametros.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxParametros.Location = new System.Drawing.Point(13, 70);
            this.groupBoxParametros.Name = "groupBoxParametros";
            this.groupBoxParametros.Size = new System.Drawing.Size(620, 145);
            this.groupBoxParametros.TabIndex = 0;
            this.groupBoxParametros.TabStop = false;
            this.groupBoxParametros.Text = "Parámetros de Entrada";
            // 
            // labelInfoRangos
            // 
            this.labelInfoRangos.AutoSize = true;
            this.labelInfoRangos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoRangos.ForeColor = System.Drawing.Color.DimGray;
            this.labelInfoRangos.Location = new System.Drawing.Point(17, 100);
            this.labelInfoRangos.Name = "labelInfoRangos";
            this.labelInfoRangos.Size = new System.Drawing.Size(543, 15);
            this.labelInfoRangos.TabIndex = 4;
            this.labelInfoRangos.Text = "Tamaños automáticos: 100, 1.000, 5.000, 10.000 elementos. Se permiten valores negativos. 5 iteraciones por tamaño.";
            // 
            // numericUpDownMax
            // 
            this.numericUpDownMax.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownMax.Location = new System.Drawing.Point(320, 48);
            this.numericUpDownMax.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownMax.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.numericUpDownMax.Name = "numericUpDownMax";
            this.numericUpDownMax.Size = new System.Drawing.Size(140, 27);
            this.numericUpDownMax.TabIndex = 3;
            this.numericUpDownMax.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMax.Location = new System.Drawing.Point(240, 52);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(74, 17);
            this.labelMax.TabIndex = 2;
            this.labelMax.Text = "Valor máx.:";
            // 
            // numericUpDownMin
            // 
            this.numericUpDownMin.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownMin.Location = new System.Drawing.Point(90, 48);
            this.numericUpDownMin.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownMin.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.numericUpDownMin.Name = "numericUpDownMin";
            this.numericUpDownMin.Size = new System.Drawing.Size(140, 27);
            this.numericUpDownMin.TabIndex = 1;
            this.numericUpDownMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMin.Location = new System.Drawing.Point(17, 52);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(71, 17);
            this.labelMin.TabIndex = 0;
            this.labelMin.Text = "Valor mín.:";
            // 
            // tabPageDatos
            // 
            this.tabPageDatos.AutoScroll = true;
            this.tabPageDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.tabPageDatos.Controls.Add(this.panelHeaderDatos);
            this.tabPageDatos.Controls.Add(this.groupBoxFiltrosDatos);
            this.tabPageDatos.Controls.Add(this.dataGridViewDatos);
            this.tabPageDatos.Controls.Add(this.chartDatoAleatorio);
            this.tabPageDatos.Controls.Add(this.chartDatoAscendente);
            this.tabPageDatos.Controls.Add(this.chartDatoDescendente);
            this.tabPageDatos.Controls.Add(this.chartDatoRepeticion);
            this.tabPageDatos.Location = new System.Drawing.Point(4, 26);
            this.tabPageDatos.Name = "tabPageDatos";
            this.tabPageDatos.Padding = new System.Windows.Forms.Padding(10);
            this.tabPageDatos.Size = new System.Drawing.Size(1256, 731);
            this.tabPageDatos.TabIndex = 1;
            this.tabPageDatos.Text = "Datos Generados";
            // 
            // panelHeaderDatos
            // 
            this.panelHeaderDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panelHeaderDatos.Controls.Add(this.labelHeaderDatosTitle);
            this.panelHeaderDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeaderDatos.Location = new System.Drawing.Point(0, 0);
            this.panelHeaderDatos.Name = "panelHeaderDatos";
            this.panelHeaderDatos.Size = new System.Drawing.Size(1256, 50);
            this.panelHeaderDatos.TabIndex = 3;
            // 
            // labelHeaderDatosTitle
            // 
            this.labelHeaderDatosTitle.AutoSize = true;
            this.labelHeaderDatosTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeaderDatosTitle.ForeColor = System.Drawing.Color.White;
            this.labelHeaderDatosTitle.Location = new System.Drawing.Point(20, 10);
            this.labelHeaderDatosTitle.Name = "labelHeaderDatosTitle";
            this.labelHeaderDatosTitle.Size = new System.Drawing.Size(279, 30);
            this.labelHeaderDatosTitle.TabIndex = 0;
            this.labelHeaderDatosTitle.Text = "Datos Generados";
            // 
            // groupBoxFiltrosDatos
            // 
            this.groupBoxFiltrosDatos.Controls.Add(this.comboBoxTipoDatos);
            this.groupBoxFiltrosDatos.Controls.Add(this.labelTipoDatos);
            this.groupBoxFiltrosDatos.Controls.Add(this.comboBoxIteracion);
            this.groupBoxFiltrosDatos.Controls.Add(this.labelIteracion);
            this.groupBoxFiltrosDatos.Controls.Add(this.comboBoxTamano);
            this.groupBoxFiltrosDatos.Controls.Add(this.labelTamano);
            this.groupBoxFiltrosDatos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFiltrosDatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.groupBoxFiltrosDatos.Location = new System.Drawing.Point(13, 60);
            this.groupBoxFiltrosDatos.Name = "groupBoxFiltrosDatos";
            this.groupBoxFiltrosDatos.Size = new System.Drawing.Size(1230, 70);
            this.groupBoxFiltrosDatos.TabIndex = 2;
            this.groupBoxFiltrosDatos.TabStop = false;
            this.groupBoxFiltrosDatos.Text = "Filtros de Visualización";
            // 
            // comboBoxTipoDatos
            // 
            this.comboBoxTipoDatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoDatos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTipoDatos.FormattingEnabled = true;
            this.comboBoxTipoDatos.Location = new System.Drawing.Point(750, 28);
            this.comboBoxTipoDatos.Name = "comboBoxTipoDatos";
            this.comboBoxTipoDatos.Size = new System.Drawing.Size(200, 25);
            this.comboBoxTipoDatos.TabIndex = 5;
            this.comboBoxTipoDatos.SelectedIndexChanged += new System.EventHandler(this.FiltrosDatos_Changed);
            // 
            // labelTipoDatos
            // 
            this.labelTipoDatos.AutoSize = true;
            this.labelTipoDatos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipoDatos.Location = new System.Drawing.Point(660, 31);
            this.labelTipoDatos.Name = "labelTipoDatos";
            this.labelTipoDatos.Size = new System.Drawing.Size(84, 17);
            this.labelTipoDatos.TabIndex = 4;
            this.labelTipoDatos.Text = "Tipo de datos:";
            // 
            // comboBoxIteracion
            // 
            this.comboBoxIteracion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIteracion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxIteracion.FormattingEnabled = true;
            this.comboBoxIteracion.Location = new System.Drawing.Point(440, 28);
            this.comboBoxIteracion.Name = "comboBoxIteracion";
            this.comboBoxIteracion.Size = new System.Drawing.Size(120, 25);
            this.comboBoxIteracion.TabIndex = 3;
            this.comboBoxIteracion.SelectedIndexChanged += new System.EventHandler(this.FiltrosDatos_Changed);
            // 
            // labelIteracion
            // 
            this.labelIteracion.AutoSize = true;
            this.labelIteracion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIteracion.Location = new System.Drawing.Point(360, 31);
            this.labelIteracion.Name = "labelIteracion";
            this.labelIteracion.Size = new System.Drawing.Size(63, 17);
            this.labelIteracion.TabIndex = 2;
            this.labelIteracion.Text = "Iteración:";
            // 
            // comboBoxTamano
            // 
            this.comboBoxTamano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTamano.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTamano.FormattingEnabled = true;
            this.comboBoxTamano.Location = new System.Drawing.Point(150, 28);
            this.comboBoxTamano.Name = "comboBoxTamano";
            this.comboBoxTamano.Size = new System.Drawing.Size(120, 25);
            this.comboBoxTamano.TabIndex = 1;
            this.comboBoxTamano.SelectedIndexChanged += new System.EventHandler(this.FiltrosDatos_Changed);
            // 
            // labelTamano
            // 
            this.labelTamano.AutoSize = true;
            this.labelTamano.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTamano.Location = new System.Drawing.Point(17, 31);
            this.labelTamano.Name = "labelTamano";
            this.labelTamano.Size = new System.Drawing.Size(119, 17);
            this.labelTamano.TabIndex = 0;
            this.labelTamano.Text = "Tamaño del arreglo:";
            // 
            // chartDatoAleatorio
            // 
            this.chartDatoAleatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.chartDatoAleatorio.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.None;
            this.chartDatoAleatorio.Location = new System.Drawing.Point(13, 495);
            this.chartDatoAleatorio.Name = "chartDatoAleatorio";
            this.chartDatoAleatorio.Size = new System.Drawing.Size(605, 165);
            this.chartDatoAleatorio.TabIndex = 4;
            // 
            // chartDatoAscendente
            // 
            this.chartDatoAscendente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.chartDatoAscendente.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.None;
            this.chartDatoAscendente.Location = new System.Drawing.Point(638, 495);
            this.chartDatoAscendente.Name = "chartDatoAscendente";
            this.chartDatoAscendente.Size = new System.Drawing.Size(605, 165);
            this.chartDatoAscendente.TabIndex = 5;
            // 
            // chartDatoDescendente
            // 
            this.chartDatoDescendente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.chartDatoDescendente.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.None;
            this.chartDatoDescendente.Location = new System.Drawing.Point(13, 685);
            this.chartDatoDescendente.Name = "chartDatoDescendente";
            this.chartDatoDescendente.Size = new System.Drawing.Size(605, 165);
            this.chartDatoDescendente.TabIndex = 6;
            // 
            // chartDatoRepeticion
            // 
            this.chartDatoRepeticion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.chartDatoRepeticion.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.None;
            this.chartDatoRepeticion.Location = new System.Drawing.Point(638, 685);
            this.chartDatoRepeticion.Name = "chartDatoRepeticion";
            this.chartDatoRepeticion.Size = new System.Drawing.Size(605, 165);
            this.chartDatoRepeticion.TabIndex = 7;
            // 
            // dataGridViewDatos
            // 
            this.dataGridViewDatos.AllowUserToAddRows = false;
            this.dataGridViewDatos.AllowUserToDeleteRows = false;
            this.dataGridViewDatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDatos.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewDatos.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.dataGridViewDatos.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewDatos.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewDatos.ColumnHeadersDefaultCellStyle.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dataGridViewDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDatos.EnableHeadersVisualStyles = false;
            this.dataGridViewDatos.Location = new System.Drawing.Point(13, 140);
            this.dataGridViewDatos.Name = "dataGridViewDatos";
            this.dataGridViewDatos.ReadOnly = true;
            this.dataGridViewDatos.RowHeadersVisible = false;
            this.dataGridViewDatos.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.dataGridViewDatos.RowTemplate.Height = 32;
            this.dataGridViewDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDatos.Size = new System.Drawing.Size(1230, 345);
            this.dataGridViewDatos.TabIndex = 0;
            this.dataGridViewDatos.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.dataGridViewDatos.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewDatos.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            // 
            // tabPageMetricas
            // 
            this.tabPageMetricas.AutoScroll = true;
            this.tabPageMetricas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.tabPageMetricas.Controls.Add(this.panelHeaderMetricas);
            this.tabPageMetricas.Controls.Add(this.groupBoxFiltrosMetricas);
            this.tabPageMetricas.Controls.Add(this.labelMetricasRendimientoTitle);
            this.tabPageMetricas.Controls.Add(this.dataGridViewMetricasRendimiento);
            this.tabPageMetricas.Controls.Add(this.labelMetricasOperacionesTitle);
            this.tabPageMetricas.Controls.Add(this.dataGridViewMetricasOperaciones);
            this.tabPageMetricas.Location = new System.Drawing.Point(4, 26);
            this.tabPageMetricas.Name = "tabPageMetricas";
            this.tabPageMetricas.Padding = new System.Windows.Forms.Padding(10);
            this.tabPageMetricas.Size = new System.Drawing.Size(1256, 731);
            this.tabPageMetricas.TabIndex = 2;
            this.tabPageMetricas.Text = "Métricas Detalladas";
            // 
            // panelHeaderMetricas
            // 
            this.panelHeaderMetricas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panelHeaderMetricas.Controls.Add(this.labelHeaderMetricasTitle);
            this.panelHeaderMetricas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeaderMetricas.Location = new System.Drawing.Point(0, 0);
            this.panelHeaderMetricas.Name = "panelHeaderMetricas";
            this.panelHeaderMetricas.Size = new System.Drawing.Size(1256, 50);
            this.panelHeaderMetricas.TabIndex = 4;
            // 
            // labelHeaderMetricasTitle
            // 
            this.labelHeaderMetricasTitle.AutoSize = true;
            this.labelHeaderMetricasTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeaderMetricasTitle.ForeColor = System.Drawing.Color.White;
            this.labelHeaderMetricasTitle.Location = new System.Drawing.Point(20, 10);
            this.labelHeaderMetricasTitle.Name = "labelHeaderMetricasTitle";
            this.labelHeaderMetricasTitle.Size = new System.Drawing.Size(318, 30);
            this.labelHeaderMetricasTitle.TabIndex = 0;
            this.labelHeaderMetricasTitle.Text = "Métricas Detalladas";
            // 
            // groupBoxFiltrosMetricas
            // 
            this.groupBoxFiltrosMetricas.Controls.Add(this.comboBoxFiltroAlgoritmo);
            this.groupBoxFiltrosMetricas.Controls.Add(this.labelFiltroAlgoritmo);
            this.groupBoxFiltrosMetricas.Controls.Add(this.comboBoxFiltroTipoDatos);
            this.groupBoxFiltrosMetricas.Controls.Add(this.labelFiltroTipoDatos);
            this.groupBoxFiltrosMetricas.Controls.Add(this.comboBoxFiltroTamano);
            this.groupBoxFiltrosMetricas.Controls.Add(this.labelFiltroTamano);
            this.groupBoxFiltrosMetricas.Controls.Add(this.comboBoxFiltroIteracion);
            this.groupBoxFiltrosMetricas.Controls.Add(this.labelFiltroIteracion);
            this.groupBoxFiltrosMetricas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFiltrosMetricas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.groupBoxFiltrosMetricas.Location = new System.Drawing.Point(13, 60);
            this.groupBoxFiltrosMetricas.Name = "groupBoxFiltrosMetricas";
            this.groupBoxFiltrosMetricas.Size = new System.Drawing.Size(1230, 70);
            this.groupBoxFiltrosMetricas.TabIndex = 3;
            this.groupBoxFiltrosMetricas.TabStop = false;
            this.groupBoxFiltrosMetricas.Text = "Filtros";
            // 
            // comboBoxFiltroAlgoritmo
            // 
            this.comboBoxFiltroAlgoritmo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFiltroAlgoritmo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFiltroAlgoritmo.FormattingEnabled = true;
            this.comboBoxFiltroAlgoritmo.Location = new System.Drawing.Point(90, 28);
            this.comboBoxFiltroAlgoritmo.Name = "comboBoxFiltroAlgoritmo";
            this.comboBoxFiltroAlgoritmo.Size = new System.Drawing.Size(140, 25);
            this.comboBoxFiltroAlgoritmo.TabIndex = 1;
            this.comboBoxFiltroAlgoritmo.SelectedIndexChanged += new System.EventHandler(this.FiltrosMetricas_Changed);
            // 
            // labelFiltroAlgoritmo
            // 
            this.labelFiltroAlgoritmo.AutoSize = true;
            this.labelFiltroAlgoritmo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFiltroAlgoritmo.Location = new System.Drawing.Point(17, 31);
            this.labelFiltroAlgoritmo.Name = "labelFiltroAlgoritmo";
            this.labelFiltroAlgoritmo.Size = new System.Drawing.Size(67, 17);
            this.labelFiltroAlgoritmo.TabIndex = 0;
            this.labelFiltroAlgoritmo.Text = "Algoritmo:";
            // 
            // comboBoxFiltroTipoDatos
            // 
            this.comboBoxFiltroTipoDatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFiltroTipoDatos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFiltroTipoDatos.FormattingEnabled = true;
            this.comboBoxFiltroTipoDatos.Location = new System.Drawing.Point(350, 28);
            this.comboBoxFiltroTipoDatos.Name = "comboBoxFiltroTipoDatos";
            this.comboBoxFiltroTipoDatos.Size = new System.Drawing.Size(170, 25);
            this.comboBoxFiltroTipoDatos.TabIndex = 3;
            this.comboBoxFiltroTipoDatos.SelectedIndexChanged += new System.EventHandler(this.FiltrosMetricas_Changed);
            // 
            // labelFiltroTipoDatos
            // 
            this.labelFiltroTipoDatos.AutoSize = true;
            this.labelFiltroTipoDatos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFiltroTipoDatos.Location = new System.Drawing.Point(250, 31);
            this.labelFiltroTipoDatos.Name = "labelFiltroTipoDatos";
            this.labelFiltroTipoDatos.Size = new System.Drawing.Size(94, 17);
            this.labelFiltroTipoDatos.TabIndex = 2;
            this.labelFiltroTipoDatos.Text = "Tipo de datos:";
            // 
            // comboBoxFiltroTamano
            // 
            this.comboBoxFiltroTamano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFiltroTamano.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFiltroTamano.FormattingEnabled = true;
            this.comboBoxFiltroTamano.Location = new System.Drawing.Point(660, 28);
            this.comboBoxFiltroTamano.Name = "comboBoxFiltroTamano";
            this.comboBoxFiltroTamano.Size = new System.Drawing.Size(120, 25);
            this.comboBoxFiltroTamano.TabIndex = 5;
            this.comboBoxFiltroTamano.SelectedIndexChanged += new System.EventHandler(this.FiltrosMetricas_Changed);
            // 
            // labelFiltroTamano
            // 
            this.labelFiltroTamano.AutoSize = true;
            this.labelFiltroTamano.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFiltroTamano.Location = new System.Drawing.Point(540, 31);
            this.labelFiltroTamano.Name = "labelFiltroTamano";
            this.labelFiltroTamano.Size = new System.Drawing.Size(119, 17);
            this.labelFiltroTamano.TabIndex = 4;
            this.labelFiltroTamano.Text = "Tamaño del arreglo:";
            // 
            // comboBoxFiltroIteracion
            // 
            this.comboBoxFiltroIteracion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFiltroIteracion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFiltroIteracion.FormattingEnabled = true;
            this.comboBoxFiltroIteracion.Location = new System.Drawing.Point(920, 28);
            this.comboBoxFiltroIteracion.Name = "comboBoxFiltroIteracion";
            this.comboBoxFiltroIteracion.Size = new System.Drawing.Size(100, 25);
            this.comboBoxFiltroIteracion.TabIndex = 7;
            this.comboBoxFiltroIteracion.SelectedIndexChanged += new System.EventHandler(this.FiltrosMetricas_Changed);
            // 
            // labelFiltroIteracion
            // 
            this.labelFiltroIteracion.AutoSize = true;
            this.labelFiltroIteracion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFiltroIteracion.Location = new System.Drawing.Point(850, 31);
            this.labelFiltroIteracion.Name = "labelFiltroIteracion";
            this.labelFiltroIteracion.Size = new System.Drawing.Size(63, 17);
            this.labelFiltroIteracion.TabIndex = 6;
            this.labelFiltroIteracion.Text = "Iteración:";
            // 
            // labelMetricasRendimientoTitle
            // 
            this.labelMetricasRendimientoTitle.AutoSize = true;
            this.labelMetricasRendimientoTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMetricasRendimientoTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.labelMetricasRendimientoTitle.Location = new System.Drawing.Point(13, 140);
            this.labelMetricasRendimientoTitle.Name = "labelMetricasRendimientoTitle";
            this.labelMetricasRendimientoTitle.Size = new System.Drawing.Size(270, 17);
            this.labelMetricasRendimientoTitle.TabIndex = 4;
            this.labelMetricasRendimientoTitle.Text = "Rendimiento (Tiempo y Correctitud)";
            // 
            // dataGridViewMetricasRendimiento
            // 
            this.dataGridViewMetricasRendimiento.AllowUserToAddRows = false;
            this.dataGridViewMetricasRendimiento.AllowUserToDeleteRows = false;
            this.dataGridViewMetricasRendimiento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMetricasRendimiento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMetricasRendimiento.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewMetricasRendimiento.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewMetricasRendimiento.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.dataGridViewMetricasRendimiento.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewMetricasRendimiento.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewMetricasRendimiento.ColumnHeadersDefaultCellStyle.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dataGridViewMetricasRendimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMetricasRendimiento.EnableHeadersVisualStyles = false;
            this.dataGridViewMetricasRendimiento.Location = new System.Drawing.Point(13, 165);
            this.dataGridViewMetricasRendimiento.Name = "dataGridViewMetricasRendimiento";
            this.dataGridViewMetricasRendimiento.ReadOnly = true;
            this.dataGridViewMetricasRendimiento.RowHeadersVisible = false;
            this.dataGridViewMetricasRendimiento.RowTemplate.Height = 32;
            this.dataGridViewMetricasRendimiento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMetricasRendimiento.Size = new System.Drawing.Size(1230, 290);
            this.dataGridViewMetricasRendimiento.TabIndex = 1;
            this.dataGridViewMetricasRendimiento.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.dataGridViewMetricasRendimiento.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewMetricasRendimiento.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            // 
            // labelMetricasOperacionesTitle
            // 
            this.labelMetricasOperacionesTitle.AutoSize = true;
            this.labelMetricasOperacionesTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMetricasOperacionesTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.labelMetricasOperacionesTitle.Location = new System.Drawing.Point(13, 470);
            this.labelMetricasOperacionesTitle.Name = "labelMetricasOperacionesTitle";
            this.labelMetricasOperacionesTitle.Size = new System.Drawing.Size(179, 17);
            this.labelMetricasOperacionesTitle.TabIndex = 5;
            this.labelMetricasOperacionesTitle.Text = "Operaciones (Conteos)";
            // 
            // dataGridViewMetricasOperaciones
            // 
            this.dataGridViewMetricasOperaciones.AllowUserToAddRows = false;
            this.dataGridViewMetricasOperaciones.AllowUserToDeleteRows = false;
            this.dataGridViewMetricasOperaciones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMetricasOperaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMetricasOperaciones.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewMetricasOperaciones.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewMetricasOperaciones.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.dataGridViewMetricasOperaciones.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewMetricasOperaciones.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewMetricasOperaciones.ColumnHeadersDefaultCellStyle.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dataGridViewMetricasOperaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMetricasOperaciones.EnableHeadersVisualStyles = false;
            this.dataGridViewMetricasOperaciones.Location = new System.Drawing.Point(13, 495);
            this.dataGridViewMetricasOperaciones.Name = "dataGridViewMetricasOperaciones";
            this.dataGridViewMetricasOperaciones.ReadOnly = true;
            this.dataGridViewMetricasOperaciones.RowHeadersVisible = false;
            this.dataGridViewMetricasOperaciones.RowTemplate.Height = 32;
            this.dataGridViewMetricasOperaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMetricasOperaciones.Size = new System.Drawing.Size(1230, 280);
            this.dataGridViewMetricasOperaciones.TabIndex = 2;
            this.dataGridViewMetricasOperaciones.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.dataGridViewMetricasOperaciones.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewMetricasOperaciones.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            // 
            // tabPageEstadisticas
            // 
            this.tabPageEstadisticas.AutoScroll = true;
            this.tabPageEstadisticas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.tabPageEstadisticas.Controls.Add(this.panelHeaderEstadisticas);
            this.tabPageEstadisticas.Controls.Add(this.groupBoxFiltrosEstadisticas);
            this.tabPageEstadisticas.Controls.Add(this.dataGridViewEstadisticas);
            this.tabPageEstadisticas.Location = new System.Drawing.Point(4, 26);
            this.tabPageEstadisticas.Name = "tabPageEstadisticas";
            this.tabPageEstadisticas.Padding = new System.Windows.Forms.Padding(10);
            this.tabPageEstadisticas.Size = new System.Drawing.Size(1256, 731);
            this.tabPageEstadisticas.TabIndex = 3;
            this.tabPageEstadisticas.Text = "Estadísticas Consolidadas";
            // 
            // panelHeaderEstadisticas
            // 
            this.panelHeaderEstadisticas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panelHeaderEstadisticas.Controls.Add(this.labelHeaderEstadisticasTitle);
            this.panelHeaderEstadisticas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeaderEstadisticas.Location = new System.Drawing.Point(0, 0);
            this.panelHeaderEstadisticas.Name = "panelHeaderEstadisticas";
            this.panelHeaderEstadisticas.Size = new System.Drawing.Size(1256, 50);
            this.panelHeaderEstadisticas.TabIndex = 4;
            // 
            // labelHeaderEstadisticasTitle
            // 
            this.labelHeaderEstadisticasTitle.AutoSize = true;
            this.labelHeaderEstadisticasTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeaderEstadisticasTitle.ForeColor = System.Drawing.Color.White;
            this.labelHeaderEstadisticasTitle.Location = new System.Drawing.Point(20, 10);
            this.labelHeaderEstadisticasTitle.Name = "labelHeaderEstadisticasTitle";
            this.labelHeaderEstadisticasTitle.Size = new System.Drawing.Size(344, 30);
            this.labelHeaderEstadisticasTitle.TabIndex = 0;
            this.labelHeaderEstadisticasTitle.Text = "Estadísticas Consolidadas";
            // 
            // groupBoxFiltrosEstadisticas
            // 
            this.groupBoxFiltrosEstadisticas.Controls.Add(this.comboBoxEstFiltroAlgoritmo);
            this.groupBoxFiltrosEstadisticas.Controls.Add(this.labelEstFiltroAlgoritmo);
            this.groupBoxFiltrosEstadisticas.Controls.Add(this.comboBoxEstFiltroTipoDatos);
            this.groupBoxFiltrosEstadisticas.Controls.Add(this.labelEstFiltroTipoDatos);
            this.groupBoxFiltrosEstadisticas.Controls.Add(this.comboBoxEstFiltroTamano);
            this.groupBoxFiltrosEstadisticas.Controls.Add(this.labelEstFiltroTamano);
            this.groupBoxFiltrosEstadisticas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFiltrosEstadisticas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.groupBoxFiltrosEstadisticas.Location = new System.Drawing.Point(13, 60);
            this.groupBoxFiltrosEstadisticas.Name = "groupBoxFiltrosEstadisticas";
            this.groupBoxFiltrosEstadisticas.Size = new System.Drawing.Size(1230, 70);
            this.groupBoxFiltrosEstadisticas.TabIndex = 3;
            this.groupBoxFiltrosEstadisticas.TabStop = false;
            this.groupBoxFiltrosEstadisticas.Text = "Filtros";
            // 
            // comboBoxEstFiltroAlgoritmo
            // 
            this.comboBoxEstFiltroAlgoritmo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEstFiltroAlgoritmo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEstFiltroAlgoritmo.FormattingEnabled = true;
            this.comboBoxEstFiltroAlgoritmo.Location = new System.Drawing.Point(90, 28);
            this.comboBoxEstFiltroAlgoritmo.Name = "comboBoxEstFiltroAlgoritmo";
            this.comboBoxEstFiltroAlgoritmo.Size = new System.Drawing.Size(140, 25);
            this.comboBoxEstFiltroAlgoritmo.TabIndex = 1;
            this.comboBoxEstFiltroAlgoritmo.SelectedIndexChanged += new System.EventHandler(this.FiltrosEstadisticas_Changed);
            // 
            // labelEstFiltroAlgoritmo
            // 
            this.labelEstFiltroAlgoritmo.AutoSize = true;
            this.labelEstFiltroAlgoritmo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstFiltroAlgoritmo.Location = new System.Drawing.Point(17, 31);
            this.labelEstFiltroAlgoritmo.Name = "labelEstFiltroAlgoritmo";
            this.labelEstFiltroAlgoritmo.Size = new System.Drawing.Size(67, 17);
            this.labelEstFiltroAlgoritmo.TabIndex = 0;
            this.labelEstFiltroAlgoritmo.Text = "Algoritmo:";
            // 
            // comboBoxEstFiltroTipoDatos
            // 
            this.comboBoxEstFiltroTipoDatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEstFiltroTipoDatos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEstFiltroTipoDatos.FormattingEnabled = true;
            this.comboBoxEstFiltroTipoDatos.Location = new System.Drawing.Point(350, 28);
            this.comboBoxEstFiltroTipoDatos.Name = "comboBoxEstFiltroTipoDatos";
            this.comboBoxEstFiltroTipoDatos.Size = new System.Drawing.Size(170, 25);
            this.comboBoxEstFiltroTipoDatos.TabIndex = 3;
            this.comboBoxEstFiltroTipoDatos.SelectedIndexChanged += new System.EventHandler(this.FiltrosEstadisticas_Changed);
            // 
            // labelEstFiltroTipoDatos
            // 
            this.labelEstFiltroTipoDatos.AutoSize = true;
            this.labelEstFiltroTipoDatos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstFiltroTipoDatos.Location = new System.Drawing.Point(250, 31);
            this.labelEstFiltroTipoDatos.Name = "labelEstFiltroTipoDatos";
            this.labelEstFiltroTipoDatos.Size = new System.Drawing.Size(94, 17);
            this.labelEstFiltroTipoDatos.TabIndex = 2;
            this.labelEstFiltroTipoDatos.Text = "Tipo de datos:";
            // 
            // comboBoxEstFiltroTamano
            // 
            this.comboBoxEstFiltroTamano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEstFiltroTamano.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEstFiltroTamano.FormattingEnabled = true;
            this.comboBoxEstFiltroTamano.Location = new System.Drawing.Point(660, 28);
            this.comboBoxEstFiltroTamano.Name = "comboBoxEstFiltroTamano";
            this.comboBoxEstFiltroTamano.Size = new System.Drawing.Size(120, 25);
            this.comboBoxEstFiltroTamano.TabIndex = 5;
            this.comboBoxEstFiltroTamano.SelectedIndexChanged += new System.EventHandler(this.FiltrosEstadisticas_Changed);
            // 
            // labelEstFiltroTamano
            // 
            this.labelEstFiltroTamano.AutoSize = true;
            this.labelEstFiltroTamano.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstFiltroTamano.Location = new System.Drawing.Point(540, 31);
            this.labelEstFiltroTamano.Name = "labelEstFiltroTamano";
            this.labelEstFiltroTamano.Size = new System.Drawing.Size(119, 17);
            this.labelEstFiltroTamano.TabIndex = 4;
            this.labelEstFiltroTamano.Text = "Tamaño del arreglo:";
            // 
            // dataGridViewEstadisticas
            // 
            this.dataGridViewEstadisticas.AllowUserToAddRows = false;
            this.dataGridViewEstadisticas.AllowUserToDeleteRows = false;
            this.dataGridViewEstadisticas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewEstadisticas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEstadisticas.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewEstadisticas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewEstadisticas.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.dataGridViewEstadisticas.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewEstadisticas.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewEstadisticas.ColumnHeadersDefaultCellStyle.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dataGridViewEstadisticas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEstadisticas.EnableHeadersVisualStyles = false;
            this.dataGridViewEstadisticas.Location = new System.Drawing.Point(13, 140);
            this.dataGridViewEstadisticas.Name = "dataGridViewEstadisticas";
            this.dataGridViewEstadisticas.ReadOnly = true;
            this.dataGridViewEstadisticas.RowHeadersVisible = false;
            this.dataGridViewEstadisticas.RowTemplate.Height = 32;
            this.dataGridViewEstadisticas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEstadisticas.Size = new System.Drawing.Size(1230, 575);
            this.dataGridViewEstadisticas.TabIndex = 0;
            this.dataGridViewEstadisticas.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.dataGridViewEstadisticas.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewEstadisticas.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            // 
            // tabPageGraficos
            // 
            this.tabPageGraficos.AutoScroll = true;
            this.tabPageGraficos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.tabPageGraficos.Controls.Add(this.panelHeaderGraficos);
            this.tabPageGraficos.Controls.Add(this.groupBoxFiltrosGraficos);
            this.tabPageGraficos.Controls.Add(this.panelLeyendaColores);
            this.tabPageGraficos.Controls.Add(this.chartComparativo);
            this.tabPageGraficos.Controls.Add(this.labelComparativoGridTitle);
            this.tabPageGraficos.Controls.Add(this.dataGridViewComparativo);
            this.tabPageGraficos.Location = new System.Drawing.Point(4, 26);
            this.tabPageGraficos.Name = "tabPageGraficos";
            this.tabPageGraficos.Padding = new System.Windows.Forms.Padding(10);
            this.tabPageGraficos.Size = new System.Drawing.Size(1256, 731);
            this.tabPageGraficos.TabIndex = 4;
            this.tabPageGraficos.Text = "Gráficos Comparativos";
            // 
            // panelHeaderGraficos
            // 
            this.panelHeaderGraficos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panelHeaderGraficos.Controls.Add(this.labelHeaderGraficosTitle);
            this.panelHeaderGraficos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeaderGraficos.Location = new System.Drawing.Point(0, 0);
            this.panelHeaderGraficos.Name = "panelHeaderGraficos";
            this.panelHeaderGraficos.Size = new System.Drawing.Size(1256, 50);
            this.panelHeaderGraficos.TabIndex = 4;
            // 
            // labelHeaderGraficosTitle
            // 
            this.labelHeaderGraficosTitle.AutoSize = true;
            this.labelHeaderGraficosTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeaderGraficosTitle.ForeColor = System.Drawing.Color.White;
            this.labelHeaderGraficosTitle.Location = new System.Drawing.Point(20, 10);
            this.labelHeaderGraficosTitle.Name = "labelHeaderGraficosTitle";
            this.labelHeaderGraficosTitle.Size = new System.Drawing.Size(279, 30);
            this.labelHeaderGraficosTitle.TabIndex = 0;
            this.labelHeaderGraficosTitle.Text = "Gráficos Comparativos";
            // 
            // groupBoxFiltrosGraficos
            // 
            this.groupBoxFiltrosGraficos.Controls.Add(this.labelGrafTipoGrafico);
            this.groupBoxFiltrosGraficos.Controls.Add(this.comboBoxGrafTipoGrafico);
            this.groupBoxFiltrosGraficos.Controls.Add(this.labelGrafAlgoritmo);
            this.groupBoxFiltrosGraficos.Controls.Add(this.comboBoxGrafAlgoritmo);
            this.groupBoxFiltrosGraficos.Controls.Add(this.comboBoxGrafTipo);
            this.groupBoxFiltrosGraficos.Controls.Add(this.labelGrafTipo);
            this.groupBoxFiltrosGraficos.Controls.Add(this.comboBoxGrafTamano);
            this.groupBoxFiltrosGraficos.Controls.Add(this.labelGrafTamano);
            this.groupBoxFiltrosGraficos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFiltrosGraficos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.groupBoxFiltrosGraficos.Location = new System.Drawing.Point(13, 63);
            this.groupBoxFiltrosGraficos.Name = "groupBoxFiltrosGraficos";
            this.groupBoxFiltrosGraficos.Size = new System.Drawing.Size(1230, 70);
            this.groupBoxFiltrosGraficos.TabIndex = 1;
            this.groupBoxFiltrosGraficos.TabStop = false;
            this.groupBoxFiltrosGraficos.Text = "Filtros de Gráficos";
            // 
            // comboBoxGrafTipo
            // 
            this.comboBoxGrafTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGrafTipo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGrafTipo.FormattingEnabled = true;
            this.comboBoxGrafTipo.Location = new System.Drawing.Point(480, 28);
            this.comboBoxGrafTipo.Name = "comboBoxGrafTipo";
            this.comboBoxGrafTipo.Size = new System.Drawing.Size(200, 25);
            this.comboBoxGrafTipo.TabIndex = 3;
            this.comboBoxGrafTipo.SelectedIndexChanged += new System.EventHandler(this.FiltrosGraficos_Changed);
            // 
            // labelGrafTipo
            // 
            this.labelGrafTipo.AutoSize = true;
            this.labelGrafTipo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGrafTipo.Location = new System.Drawing.Point(390, 31);
            this.labelGrafTipo.Name = "labelGrafTipo";
            this.labelGrafTipo.Size = new System.Drawing.Size(84, 17);
            this.labelGrafTipo.TabIndex = 2;
            this.labelGrafTipo.Text = "Tipo de datos:";
            // 
            // comboBoxGrafTamano
            // 
            this.comboBoxGrafTamano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGrafTamano.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGrafTamano.FormattingEnabled = true;
            this.comboBoxGrafTamano.Location = new System.Drawing.Point(150, 28);
            this.comboBoxGrafTamano.Name = "comboBoxGrafTamano";
            this.comboBoxGrafTamano.Size = new System.Drawing.Size(120, 25);
            this.comboBoxGrafTamano.TabIndex = 1;
            this.comboBoxGrafTamano.SelectedIndexChanged += new System.EventHandler(this.FiltrosGraficos_Changed);
            // 
            // labelGrafTamano
            // 
            this.labelGrafTamano.AutoSize = true;
            this.labelGrafTamano.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGrafTamano.Location = new System.Drawing.Point(17, 31);
            this.labelGrafTamano.Name = "labelGrafTamano";
            this.labelGrafTamano.Size = new System.Drawing.Size(119, 17);
            this.labelGrafTamano.TabIndex = 0;
            this.labelGrafTamano.Text = "Tamaño del arreglo:";
            // 
            // labelGrafAlgoritmo
            // 
            this.labelGrafAlgoritmo.AutoSize = true;
            this.labelGrafAlgoritmo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGrafAlgoritmo.Location = new System.Drawing.Point(1020, 31);
            this.labelGrafAlgoritmo.Name = "labelGrafAlgoritmo";
            this.labelGrafAlgoritmo.Size = new System.Drawing.Size(67, 17);
            this.labelGrafAlgoritmo.TabIndex = 7;
            this.labelGrafAlgoritmo.Text = "Algoritmo:";
            // 
            // comboBoxGrafAlgoritmo
            // 
            this.comboBoxGrafAlgoritmo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGrafAlgoritmo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGrafAlgoritmo.FormattingEnabled = true;
            this.comboBoxGrafAlgoritmo.Location = new System.Drawing.Point(1095, 28);
            this.comboBoxGrafAlgoritmo.Name = "comboBoxGrafAlgoritmo";
            this.comboBoxGrafAlgoritmo.Size = new System.Drawing.Size(130, 25);
            this.comboBoxGrafAlgoritmo.TabIndex = 6;
            this.comboBoxGrafAlgoritmo.SelectedIndexChanged += new System.EventHandler(this.FiltrosGraficos_Changed);
            // 
            // comboBoxGrafTipoGrafico
            // 
            this.comboBoxGrafTipoGrafico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGrafTipoGrafico.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGrafTipoGrafico.FormattingEnabled = true;
            this.comboBoxGrafTipoGrafico.Items.AddRange(new object[] { "Columnas", "Lineas", "Puntos" });
            this.comboBoxGrafTipoGrafico.Location = new System.Drawing.Point(820, 28);
            this.comboBoxGrafTipoGrafico.Name = "comboBoxGrafTipoGrafico";
            this.comboBoxGrafTipoGrafico.Size = new System.Drawing.Size(120, 25);
            this.comboBoxGrafTipoGrafico.TabIndex = 4;
            this.comboBoxGrafTipoGrafico.SelectedIndexChanged += new System.EventHandler(this.FiltrosGraficos_Changed);
            // 
            // labelGrafTipoGrafico
            // 
            this.labelGrafTipoGrafico.AutoSize = true;
            this.labelGrafTipoGrafico.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGrafTipoGrafico.Location = new System.Drawing.Point(720, 31);
            this.labelGrafTipoGrafico.Name = "labelGrafTipoGrafico";
            this.labelGrafTipoGrafico.Size = new System.Drawing.Size(93, 17);
            this.labelGrafTipoGrafico.TabIndex = 5;
            this.labelGrafTipoGrafico.Text = "Tipo de gráfico:";
            // 
            // panelLeyendaColores
            // 
            this.panelLeyendaColores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLeyendaColores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panelLeyendaColores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLeyendaColores.Controls.Add(this.panelSwatch1);
            this.panelLeyendaColores.Controls.Add(this.labelSwatch1);
            this.panelLeyendaColores.Controls.Add(this.panelSwatch2);
            this.panelLeyendaColores.Controls.Add(this.labelSwatch2);
            this.panelLeyendaColores.Controls.Add(this.panelSwatch3);
            this.panelLeyendaColores.Controls.Add(this.labelSwatch3);
            this.panelLeyendaColores.Controls.Add(this.panelSwatch4);
            this.panelLeyendaColores.Controls.Add(this.labelSwatch4);
            this.panelLeyendaColores.Location = new System.Drawing.Point(13, 138);
            this.panelLeyendaColores.Name = "panelLeyendaColores";
            this.panelLeyendaColores.Size = new System.Drawing.Size(1230, 30);
            this.panelLeyendaColores.TabIndex = 2;
            // 
            // panelSwatch1
            // 
            this.panelSwatch1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(132)))));
            this.panelSwatch1.Location = new System.Drawing.Point(15, 6);
            this.panelSwatch1.Name = "panelSwatch1";
            this.panelSwatch1.Size = new System.Drawing.Size(16, 16);
            this.panelSwatch1.TabIndex = 0;
            // 
            // labelSwatch1
            // 
            this.labelSwatch1.AutoSize = true;
            this.labelSwatch1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSwatch1.Location = new System.Drawing.Point(35, 5);
            this.labelSwatch1.Name = "labelSwatch1";
            this.labelSwatch1.Size = new System.Drawing.Size(44, 17);
            this.labelSwatch1.TabIndex = 1;
            this.labelSwatch1.Text = "n=100";
            // 
            // panelSwatch2
            // 
            this.panelSwatch2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(162)))), ((int)(((byte)(235)))));
            this.panelSwatch2.Location = new System.Drawing.Point(155, 6);
            this.panelSwatch2.Name = "panelSwatch2";
            this.panelSwatch2.Size = new System.Drawing.Size(16, 16);
            this.panelSwatch2.TabIndex = 2;
            // 
            // labelSwatch2
            // 
            this.labelSwatch2.AutoSize = true;
            this.labelSwatch2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSwatch2.Location = new System.Drawing.Point(175, 5);
            this.labelSwatch2.Name = "labelSwatch2";
            this.labelSwatch2.Size = new System.Drawing.Size(55, 17);
            this.labelSwatch2.TabIndex = 3;
            this.labelSwatch2.Text = "n=1,000";
            // 
            // panelSwatch3
            // 
            this.panelSwatch3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(206)))), ((int)(((byte)(86)))));
            this.panelSwatch3.Location = new System.Drawing.Point(315, 6);
            this.panelSwatch3.Name = "panelSwatch3";
            this.panelSwatch3.Size = new System.Drawing.Size(16, 16);
            this.panelSwatch3.TabIndex = 4;
            // 
            // labelSwatch3
            // 
            this.labelSwatch3.AutoSize = true;
            this.labelSwatch3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSwatch3.Location = new System.Drawing.Point(335, 5);
            this.labelSwatch3.Name = "labelSwatch3";
            this.labelSwatch3.Size = new System.Drawing.Size(55, 17);
            this.labelSwatch3.TabIndex = 5;
            this.labelSwatch3.Text = "n=5,000";
            // 
            // panelSwatch4
            // 
            this.panelSwatch4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelSwatch4.Location = new System.Drawing.Point(475, 6);
            this.panelSwatch4.Name = "panelSwatch4";
            this.panelSwatch4.Size = new System.Drawing.Size(16, 16);
            this.panelSwatch4.TabIndex = 6;
            // 
            // labelSwatch4
            // 
            this.labelSwatch4.AutoSize = true;
            this.labelSwatch4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSwatch4.Location = new System.Drawing.Point(495, 5);
            this.labelSwatch4.Name = "labelSwatch4";
            this.labelSwatch4.Size = new System.Drawing.Size(61, 17);
            this.labelSwatch4.TabIndex = 7;
            this.labelSwatch4.Text = "n=10,000";
            // 
            // chartComparativo
            // 
            this.chartComparativo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.chartComparativo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.chartComparativo.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.None;
            this.chartComparativo.Location = new System.Drawing.Point(13, 173);
            this.chartComparativo.Name = "chartComparativo";
            this.chartComparativo.Size = new System.Drawing.Size(1230, 370);
            this.chartComparativo.TabIndex = 0;
            this.chartComparativo.Text = "chartComparativo";
            // 
            // labelComparativoGridTitle
            // 
            this.labelComparativoGridTitle.AutoSize = true;
            this.labelComparativoGridTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComparativoGridTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.labelComparativoGridTitle.Location = new System.Drawing.Point(13, 548);
            this.labelComparativoGridTitle.Name = "labelComparativoGridTitle";
            this.labelComparativoGridTitle.Size = new System.Drawing.Size(379, 17);
            this.labelComparativoGridTitle.TabIndex = 4;
            this.labelComparativoGridTitle.Text = "Tiempo promedio (ms) por tipo de datos y tamaño";
            // 
            // dataGridViewComparativo
            // 
            this.dataGridViewComparativo.AllowUserToAddRows = false;
            this.dataGridViewComparativo.AllowUserToDeleteRows = false;
            this.dataGridViewComparativo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewComparativo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewComparativo.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewComparativo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewComparativo.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.dataGridViewComparativo.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewComparativo.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewComparativo.ColumnHeadersDefaultCellStyle.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dataGridViewComparativo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewComparativo.EnableHeadersVisualStyles = false;
            this.dataGridViewComparativo.Location = new System.Drawing.Point(13, 573);
            this.dataGridViewComparativo.Name = "dataGridViewComparativo";
            this.dataGridViewComparativo.ReadOnly = true;
            this.dataGridViewComparativo.RowHeadersVisible = false;
            this.dataGridViewComparativo.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.dataGridViewComparativo.RowTemplate.Height = 32;
            this.dataGridViewComparativo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewComparativo.Size = new System.Drawing.Size(1230, 150);
            this.dataGridViewComparativo.TabIndex = 3;
            this.dataGridViewComparativo.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.dataGridViewComparativo.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewComparativo.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            // 
            // tabPageComparacionTipos
            // 
            this.tabPageComparacionTipos.AutoScroll = true;
            this.tabPageComparacionTipos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.tabPageComparacionTipos.Controls.Add(this.panelHeaderComparacion);
            this.tabPageComparacionTipos.Controls.Add(this.labelDescComparacion);
            this.tabPageComparacionTipos.Controls.Add(this.chartCompAleatorio);
            this.tabPageComparacionTipos.Controls.Add(this.chartCompAscendente);
            this.tabPageComparacionTipos.Controls.Add(this.chartCompDescendente);
            this.tabPageComparacionTipos.Controls.Add(this.chartCompRepeticion);
            this.tabPageComparacionTipos.Controls.Add(this.groupBoxFiltroComparacion);
            this.tabPageComparacionTipos.Controls.Add(this.dataGridViewComparacion);
            this.tabPageComparacionTipos.Location = new System.Drawing.Point(4, 26);
            this.tabPageComparacionTipos.Name = "tabPageComparacionTipos";
            this.tabPageComparacionTipos.Padding = new System.Windows.Forms.Padding(10);
            this.tabPageComparacionTipos.Size = new System.Drawing.Size(1256, 731);
            this.tabPageComparacionTipos.TabIndex = 5;
            this.tabPageComparacionTipos.Text = "Comparación por Tipo de Dato";
            // 
            // panelHeaderComparacion
            // 
            this.panelHeaderComparacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panelHeaderComparacion.Controls.Add(this.labelHeaderComparacionTitle);
            this.panelHeaderComparacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeaderComparacion.Location = new System.Drawing.Point(0, 0);
            this.panelHeaderComparacion.Name = "panelHeaderComparacion";
            this.panelHeaderComparacion.Size = new System.Drawing.Size(1256, 50);
            this.panelHeaderComparacion.TabIndex = 0;
            // 
            // labelHeaderComparacionTitle
            // 
            this.labelHeaderComparacionTitle.AutoSize = true;
            this.labelHeaderComparacionTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeaderComparacionTitle.ForeColor = System.Drawing.Color.White;
            this.labelHeaderComparacionTitle.Location = new System.Drawing.Point(20, 10);
            this.labelHeaderComparacionTitle.Name = "labelHeaderComparacionTitle";
            this.labelHeaderComparacionTitle.Size = new System.Drawing.Size(380, 30);
            this.labelHeaderComparacionTitle.TabIndex = 0;
            this.labelHeaderComparacionTitle.Text = "Comparación por Tipo de Dato";
            // 
            // labelDescComparacion
            // 
            this.labelDescComparacion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescComparacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.labelDescComparacion.Location = new System.Drawing.Point(13, 53);
            this.labelDescComparacion.Name = "labelDescComparacion";
            this.labelDescComparacion.Size = new System.Drawing.Size(1230, 25);
            this.labelDescComparacion.TabIndex = 5;
            this.labelDescComparacion.Text = "Al final de la ventana se muestra una tabla organizada con los valores promedio de cada algoritmo según el tipo de dato. Use los filtros para visualizar combinaciones específicas.";
            this.labelDescComparacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chartCompAleatorio
            // 
            this.chartCompAleatorio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartCompAleatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.chartCompAleatorio.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.None;
            this.chartCompAleatorio.Location = new System.Drawing.Point(13, 90);
            this.chartCompAleatorio.Name = "chartCompAleatorio";
            this.chartCompAleatorio.Size = new System.Drawing.Size(1230, 300);
            this.chartCompAleatorio.TabIndex = 1;
            // 
            // chartCompAscendente
            // 
            this.chartCompAscendente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartCompAscendente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.chartCompAscendente.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.None;
            this.chartCompAscendente.Location = new System.Drawing.Point(13, 410);
            this.chartCompAscendente.Name = "chartCompAscendente";
            this.chartCompAscendente.Size = new System.Drawing.Size(1230, 300);
            this.chartCompAscendente.TabIndex = 2;
            // 
            // chartCompDescendente
            // 
            this.chartCompDescendente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartCompDescendente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.chartCompDescendente.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.None;
            this.chartCompDescendente.Location = new System.Drawing.Point(13, 730);
            this.chartCompDescendente.Name = "chartCompDescendente";
            this.chartCompDescendente.Size = new System.Drawing.Size(1230, 300);
            this.chartCompDescendente.TabIndex = 3;
            // 
            // chartCompRepeticion
            // 
            this.chartCompRepeticion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartCompRepeticion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.chartCompRepeticion.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.None;
            this.chartCompRepeticion.Location = new System.Drawing.Point(13, 1050);
            this.chartCompRepeticion.Name = "chartCompRepeticion";
            this.chartCompRepeticion.Size = new System.Drawing.Size(1230, 300);
            this.chartCompRepeticion.TabIndex = 4;
            // 
            // groupBoxFiltroComparacion
            // 
            this.groupBoxFiltroComparacion.Controls.Add(this.labelFiltroCompTipo);
            this.groupBoxFiltroComparacion.Controls.Add(this.comboBoxFiltroCompTipo);
            this.groupBoxFiltroComparacion.Controls.Add(this.labelFiltroCompAlgoritmo);
            this.groupBoxFiltroComparacion.Controls.Add(this.comboBoxFiltroCompAlgoritmo);
            this.groupBoxFiltroComparacion.Controls.Add(this.buttonFiltroCompAplicar);
            this.groupBoxFiltroComparacion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFiltroComparacion.Location = new System.Drawing.Point(13, 1370);
            this.groupBoxFiltroComparacion.Name = "groupBoxFiltroComparacion";
            this.groupBoxFiltroComparacion.Size = new System.Drawing.Size(1230, 55);
            this.groupBoxFiltroComparacion.TabIndex = 6;
            this.groupBoxFiltroComparacion.TabStop = false;
            this.groupBoxFiltroComparacion.Text = "Filtros";
            // 
            // labelFiltroCompTipo
            // 
            this.labelFiltroCompTipo.AutoSize = true;
            this.labelFiltroCompTipo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFiltroCompTipo.Location = new System.Drawing.Point(15, 18);
            this.labelFiltroCompTipo.Name = "labelFiltroCompTipo";
            this.labelFiltroCompTipo.Size = new System.Drawing.Size(93, 15);
            this.labelFiltroCompTipo.TabIndex = 0;
            this.labelFiltroCompTipo.Text = "Tipo de datos:";
            // 
            // comboBoxFiltroCompTipo
            // 
            this.comboBoxFiltroCompTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFiltroCompTipo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFiltroCompTipo.Location = new System.Drawing.Point(112, 15);
            this.comboBoxFiltroCompTipo.Name = "comboBoxFiltroCompTipo";
            this.comboBoxFiltroCompTipo.Size = new System.Drawing.Size(180, 23);
            this.comboBoxFiltroCompTipo.TabIndex = 1;
            // 
            // labelFiltroCompAlgoritmo
            // 
            this.labelFiltroCompAlgoritmo.AutoSize = true;
            this.labelFiltroCompAlgoritmo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFiltroCompAlgoritmo.Location = new System.Drawing.Point(310, 18);
            this.labelFiltroCompAlgoritmo.Name = "labelFiltroCompAlgoritmo";
            this.labelFiltroCompAlgoritmo.Size = new System.Drawing.Size(64, 15);
            this.labelFiltroCompAlgoritmo.TabIndex = 2;
            this.labelFiltroCompAlgoritmo.Text = "Algoritmo:";
            // 
            // comboBoxFiltroCompAlgoritmo
            // 
            this.comboBoxFiltroCompAlgoritmo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFiltroCompAlgoritmo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFiltroCompAlgoritmo.Location = new System.Drawing.Point(380, 15);
            this.comboBoxFiltroCompAlgoritmo.Name = "comboBoxFiltroCompAlgoritmo";
            this.comboBoxFiltroCompAlgoritmo.Size = new System.Drawing.Size(180, 23);
            this.comboBoxFiltroCompAlgoritmo.TabIndex = 3;
            // 
            // buttonFiltroCompAplicar
            // 
            this.buttonFiltroCompAplicar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.buttonFiltroCompAplicar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.buttonFiltroCompAplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFiltroCompAplicar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFiltroCompAplicar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.buttonFiltroCompAplicar.Location = new System.Drawing.Point(580, 15);
            this.buttonFiltroCompAplicar.Name = "buttonFiltroCompAplicar";
            this.buttonFiltroCompAplicar.Size = new System.Drawing.Size(90, 25);
            this.buttonFiltroCompAplicar.TabIndex = 4;
            this.buttonFiltroCompAplicar.Text = "Aplicar";
            this.buttonFiltroCompAplicar.UseVisualStyleBackColor = true;
            this.buttonFiltroCompAplicar.Click += new System.EventHandler(this.buttonFiltroCompAplicar_Click);
            // 
            // dataGridViewComparacion
            // 
            this.dataGridViewComparacion.AllowUserToAddRows = false;
            this.dataGridViewComparacion.AllowUserToDeleteRows = false;
            this.dataGridViewComparacion.AllowUserToResizeRows = false;
            this.dataGridViewComparacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewComparacion.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewComparacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewComparacion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewComparacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewComparacion.EnableHeadersVisualStyles = false;
            this.dataGridViewComparacion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewComparacion.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dataGridViewComparacion.Location = new System.Drawing.Point(13, 1440);
            this.dataGridViewComparacion.Name = "dataGridViewComparacion";
            this.dataGridViewComparacion.ReadOnly = true;
            this.dataGridViewComparacion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewComparacion.RowHeadersVisible = false;
            this.dataGridViewComparacion.RowTemplate.Height = 25;
            this.dataGridViewComparacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewComparacion.Size = new System.Drawing.Size(1230, 250);
            this.dataGridViewComparacion.TabIndex = 7;
            this.dataGridViewComparacion.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewComparacion.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dataGridViewComparacion.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.dataGridViewComparacion.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewComparacion.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.dataGridViewComparacion.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.dataGridViewComparacion.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewComparacion.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewComparacion.ColumnHeadersDefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1264, 761);
            this.Controls.Add(this.tabControlPrincipal);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(1280, 800);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Análisis Experimental de Algoritmos de Ordenamiento";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControlPrincipal.ResumeLayout(false);
            this.tabPageConfiguracion.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.groupBoxResultados.ResumeLayout(false);
            this.groupBoxResultados.PerformLayout();
            this.groupBoxProgreso.ResumeLayout(false);
            this.groupBoxProgreso.PerformLayout();
            this.groupBoxEjecucion.ResumeLayout(false);
            this.groupBoxParametros.ResumeLayout(false);
            this.groupBoxParametros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).EndInit();
            this.tabPageDatos.ResumeLayout(false);
            this.panelHeaderDatos.ResumeLayout(false);
            this.panelHeaderDatos.PerformLayout();
            this.groupBoxFiltrosDatos.ResumeLayout(false);
            this.groupBoxFiltrosDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDatoAleatorio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDatoAscendente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDatoDescendente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDatoRepeticion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatos)).EndInit();
            this.tabPageMetricas.ResumeLayout(false);
            this.panelHeaderMetricas.ResumeLayout(false);
            this.panelHeaderMetricas.PerformLayout();
            this.groupBoxFiltrosMetricas.ResumeLayout(false);
            this.groupBoxFiltrosMetricas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMetricasRendimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMetricasOperaciones)).EndInit();
            this.tabPageEstadisticas.ResumeLayout(false);
            this.panelHeaderEstadisticas.ResumeLayout(false);
            this.panelHeaderEstadisticas.PerformLayout();
            this.groupBoxFiltrosEstadisticas.ResumeLayout(false);
            this.groupBoxFiltrosEstadisticas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstadisticas)).EndInit();
            this.tabPageGraficos.ResumeLayout(false);
            this.panelHeaderGraficos.ResumeLayout(false);
            this.panelHeaderGraficos.PerformLayout();
            this.groupBoxFiltrosGraficos.ResumeLayout(false);
            this.groupBoxFiltrosGraficos.PerformLayout();
            this.panelLeyendaColores.ResumeLayout(false);
            this.panelLeyendaColores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartComparativo)).EndInit();
            this.tabPageComparacionTipos.ResumeLayout(false);
            this.panelHeaderComparacion.ResumeLayout(false);
            this.panelHeaderComparacion.PerformLayout();
            this.groupBoxFiltroComparacion.ResumeLayout(false);
            this.groupBoxFiltroComparacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCompAleatorio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCompAscendente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCompDescendente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCompRepeticion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComparacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlPrincipal;
        private System.Windows.Forms.TabPage tabPageConfiguracion;
        private System.Windows.Forms.TabPage tabPageDatos;
        private System.Windows.Forms.TabPage tabPageMetricas;
        private System.Windows.Forms.TabPage tabPageEstadisticas;
        private System.Windows.Forms.TabPage tabPageGraficos;
        private System.Windows.Forms.GroupBox groupBoxParametros;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelHeaderTitle;
        private System.Windows.Forms.NumericUpDown numericUpDownMin;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.NumericUpDown numericUpDownMax;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label labelInfoRangos;
        private System.Windows.Forms.GroupBox groupBoxEjecucion;
        private System.Windows.Forms.Button buttonEjecutar;
        private System.Windows.Forms.Button buttonVerDatos;
        private System.Windows.Forms.Button buttonGenerarGraficos;
        private System.Windows.Forms.Button buttonGenerarEstadisticas;
        private System.Windows.Forms.Button buttonExportarPDF;
        private System.Windows.Forms.GroupBox groupBoxProgreso;
        private System.Windows.Forms.ProgressBar progressBarEjecucion;
        private System.Windows.Forms.Label labelProgreso;
        private System.Windows.Forms.GroupBox groupBoxResultados;
        private System.Windows.Forms.TextBox textBoxConclusiones;
        private System.Windows.Forms.Label labelConclusiones;
        private System.Windows.Forms.DataGridView dataGridViewDatos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDatoAleatorio;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDatoAscendente;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDatoDescendente;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDatoRepeticion;
        private System.Windows.Forms.Panel panelHeaderDatos;
        private System.Windows.Forms.Label labelHeaderDatosTitle;
        private System.Windows.Forms.GroupBox groupBoxFiltrosDatos;
        private System.Windows.Forms.ComboBox comboBoxTipoDatos;
        private System.Windows.Forms.Label labelTipoDatos;
        private System.Windows.Forms.ComboBox comboBoxIteracion;
        private System.Windows.Forms.Label labelIteracion;
        private System.Windows.Forms.ComboBox comboBoxTamano;
        private System.Windows.Forms.Label labelTamano;
        private System.Windows.Forms.Panel panelHeaderMetricas;
        private System.Windows.Forms.Label labelHeaderMetricasTitle;
        private System.Windows.Forms.GroupBox groupBoxFiltrosMetricas;
        private System.Windows.Forms.ComboBox comboBoxFiltroAlgoritmo;
        private System.Windows.Forms.Label labelFiltroAlgoritmo;
        private System.Windows.Forms.ComboBox comboBoxFiltroTipoDatos;
        private System.Windows.Forms.Label labelFiltroTipoDatos;
        private System.Windows.Forms.ComboBox comboBoxFiltroTamano;
        private System.Windows.Forms.Label labelFiltroTamano;
        private System.Windows.Forms.ComboBox comboBoxFiltroIteracion;
        private System.Windows.Forms.Label labelFiltroIteracion;
        private System.Windows.Forms.DataGridView dataGridViewMetricasRendimiento;
        private System.Windows.Forms.Label labelMetricasRendimientoTitle;
        private System.Windows.Forms.DataGridView dataGridViewMetricasOperaciones;
        private System.Windows.Forms.Label labelMetricasOperacionesTitle;
        private System.Windows.Forms.Panel panelHeaderEstadisticas;
        private System.Windows.Forms.Label labelHeaderEstadisticasTitle;
        private System.Windows.Forms.GroupBox groupBoxFiltrosEstadisticas;
        private System.Windows.Forms.ComboBox comboBoxEstFiltroAlgoritmo;
        private System.Windows.Forms.Label labelEstFiltroAlgoritmo;
        private System.Windows.Forms.ComboBox comboBoxEstFiltroTipoDatos;
        private System.Windows.Forms.Label labelEstFiltroTipoDatos;
        private System.Windows.Forms.ComboBox comboBoxEstFiltroTamano;
        private System.Windows.Forms.Label labelEstFiltroTamano;
        private System.Windows.Forms.DataGridView dataGridViewEstadisticas;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartComparativo;
        private System.Windows.Forms.DataGridView dataGridViewComparativo;
        private System.Windows.Forms.ComboBox comboBoxGrafAlgoritmo;
        private System.Windows.Forms.Label labelGrafAlgoritmo;
        private System.Windows.Forms.GroupBox groupBoxFiltrosGraficos;
        private System.Windows.Forms.ComboBox comboBoxGrafTamano;
        private System.Windows.Forms.Label labelGrafTamano;
        private System.Windows.Forms.ComboBox comboBoxGrafTipo;
        private System.Windows.Forms.Label labelGrafTipo;
        private System.Windows.Forms.ComboBox comboBoxGrafTipoGrafico;
        private System.Windows.Forms.Label labelGrafTipoGrafico;
        private System.Windows.Forms.Panel panelLeyendaColores;
        private System.Windows.Forms.Panel panelSwatch1;
        private System.Windows.Forms.Label labelSwatch1;
        private System.Windows.Forms.Panel panelSwatch2;
        private System.Windows.Forms.Label labelSwatch2;
        private System.Windows.Forms.Panel panelSwatch3;
        private System.Windows.Forms.Label labelSwatch3;
        private System.Windows.Forms.Panel panelSwatch4;
        private System.Windows.Forms.Label labelSwatch4;
        private System.Windows.Forms.Panel panelHeaderGraficos;
        private System.Windows.Forms.Label labelHeaderGraficosTitle;
        private System.Windows.Forms.Label labelComparativoGridTitle;
        private System.Windows.Forms.TabPage tabPageComparacionTipos;
        private System.Windows.Forms.Panel panelHeaderComparacion;
        private System.Windows.Forms.Label labelHeaderComparacionTitle;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCompAleatorio;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCompAscendente;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCompDescendente;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCompRepeticion;
        private System.Windows.Forms.Label labelDescComparacion;
        private System.Windows.Forms.GroupBox groupBoxFiltroComparacion;
        private System.Windows.Forms.ComboBox comboBoxFiltroCompTipo;
        private System.Windows.Forms.Label labelFiltroCompTipo;
        private System.Windows.Forms.ComboBox comboBoxFiltroCompAlgoritmo;
        private System.Windows.Forms.Label labelFiltroCompAlgoritmo;
        private System.Windows.Forms.Button buttonFiltroCompAplicar;
        private System.Windows.Forms.DataGridView dataGridViewComparacion;
    }
}