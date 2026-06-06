using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace OrdenamientoApp
{
    public partial class Form1 : Form
    {
      
        // ESTRUCTURAS DE DATOS
      

        public struct Metrica
        {
            public int Tamano;
            public int Iteracion;
            public string Algoritmo;
            public string TipoDatos;
            public long Ticks;
            public double Milisegundos;
            public bool OrdenCorrecto;
            public long Comparaciones;
            public long Intercambios;
            public long Asignaciones;
            public long LlamadasRecursivas;
        }

        public struct Estadistica
        {
            public int Tamano;
            public string Algoritmo;
            public string TipoDatos;
            public double Minimo;
            public double Maximo;
            public double Promedio;
        }

        // ============================================================
        // VARIABLES GLOBALES
        // ============================================================

        private List<Metrica> listaMetricas = new List<Metrica>();
        private List<Estadistica> listaEstadisticas = new List<Estadistica>();
        private Dictionary<string, int[][]> datosGenerados = new Dictionary<string, int[][]>();
        private readonly string[] nombresAlgoritmos = {
            "Insercion", "Seleccion", "Burbuja", "Shell Sort",
            "Merge Sort", "Heap Sort", "Quick Sort", "Quick Sort 3 Vias",
            "Counting Sort", "Radix Sort"
        };
        private readonly string[] tiposDatos = {
            "Aleatorio", "Tendencia ascendente", "Descendente", "Alta repeticion"
        };
        private readonly int[] tamanos = { 100, 1000, 5000, 10000 };
        private int pruebaActual = 0;
        private int totalPruebas = 800;

        // Contadores operacionales (usados durante ejecucion de algoritmos)
        private long contComparaciones;
        private long contIntercambios;
        private long contAsignaciones;
        private long contLlamadasRecursivas;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

     
        // EVENTOS DE FORMULARIO
      

        private void Form1_Load(object sender, EventArgs e)
        {
            // Estilo de headers con gradiente
            foreach (Panel p in new[] { panelHeader, panelHeaderDatos, panelHeaderMetricas, panelHeaderEstadisticas, panelHeaderGraficos, panelHeaderComparacion })
            {
                p.Paint += (s, pe) =>
                {
                    Panel panel = (Panel)s;
                    using (System.Drawing.Drawing2D.LinearGradientBrush brush = new System.Drawing.Drawing2D.LinearGradientBrush(
                        panel.ClientRectangle,
                        System.Drawing.Color.FromArgb(44, 62, 80),
                        System.Drawing.Color.FromArgb(52, 73, 94),
                        System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
                    {
                        pe.Graphics.FillRectangle(brush, panel.ClientRectangle);
                    }
                    using (System.Drawing.Pen accentPen = new System.Drawing.Pen(System.Drawing.Color.FromArgb(52, 152, 219), 3))
                    {
                        pe.Graphics.DrawLine(accentPen, 0, panel.Height - 3, panel.Width, panel.Height - 3);
                    }
                };
            }

            // Hover en botones
            SetButtonHover(buttonEjecutar, System.Drawing.Color.FromArgb(133, 193, 233));
            SetButtonHover(buttonVerDatos, System.Drawing.Color.FromArgb(178, 178, 178));
            SetButtonHover(buttonGenerarGraficos, System.Drawing.Color.FromArgb(111, 198, 111));
            SetButtonHover(buttonGenerarEstadisticas, System.Drawing.Color.FromArgb(251, 178, 114));
            SetButtonHover(buttonExportarPDF, System.Drawing.Color.FromArgb(255, 140, 160));

            // Configurar ComboBox de filtros
            comboBoxTamano.Items.AddRange(new object[] { "100", "1000", "5000", "10000" });
            comboBoxIteracion.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            comboBoxTipoDatos.Items.AddRange(new object[] { "Todos", "Aleatorio", "Tendencia ascendente", "Descendente", "Alta repeticion" });

            comboBoxTamano.SelectedIndex = 0;
            comboBoxIteracion.SelectedIndex = 0;
            comboBoxTipoDatos.SelectedIndex = 0;

            // Configurar ComboBox de graficos
            comboBoxGrafTamano.Items.AddRange(new object[] { "Todos", "100", "1000", "5000", "10000" });
            comboBoxGrafTamano.SelectedIndex = 0;

            comboBoxGrafTipo.Items.AddRange(new object[] { "Todos", "Aleatorio", "Tendencia ascendente", "Descendente", "Alta repeticion" });
            comboBoxGrafTipo.SelectedIndex = 0;

            comboBoxGrafTipoGrafico.SelectedIndex = 0;

            comboBoxGrafAlgoritmo.Items.AddRange(nombresAlgoritmos);
            comboBoxGrafAlgoritmo.SelectedIndex = 0;

            // Configurar DataGridView de metricas
            ConfigurarDataGridViewMetricas();

            // Configurar filtros de metricas
            string[] filtroAlgoritmos = new string[nombresAlgoritmos.Length + 1];
            filtroAlgoritmos[0] = "Todos";
            Array.Copy(nombresAlgoritmos, 0, filtroAlgoritmos, 1, nombresAlgoritmos.Length);
            comboBoxFiltroAlgoritmo.Items.AddRange(filtroAlgoritmos);

            string[] filtroTipos = new string[tiposDatos.Length + 1];
            filtroTipos[0] = "Todos";
            Array.Copy(tiposDatos, 0, filtroTipos, 1, tiposDatos.Length);
            comboBoxFiltroTipoDatos.Items.AddRange(filtroTipos);

            comboBoxFiltroTamano.Items.AddRange(new object[] { "Todos", "100", "1000", "5000", "10000" });
            comboBoxFiltroIteracion.Items.AddRange(new object[] { "Todos", "1", "2", "3", "4", "5" });

            comboBoxFiltroAlgoritmo.SelectedIndex = 0;
            comboBoxFiltroTipoDatos.SelectedIndex = 0;
            comboBoxFiltroTamano.SelectedIndex = 0;
            comboBoxFiltroIteracion.SelectedIndex = 0;

            // Configurar filtros de estadisticas
            comboBoxEstFiltroAlgoritmo.Items.AddRange(filtroAlgoritmos);
            comboBoxEstFiltroTipoDatos.Items.AddRange(filtroTipos);
            comboBoxEstFiltroTamano.Items.AddRange(new object[] { "Todos", "100", "1000", "5000", "10000" });

            comboBoxEstFiltroAlgoritmo.SelectedIndex = 0;
            comboBoxEstFiltroTipoDatos.SelectedIndex = 0;
            comboBoxEstFiltroTamano.SelectedIndex = 0;

            // Configurar DataGridView de estadisticas
            ConfigurarDataGridViewEstadisticas();

            // Configurar DataGridView de datos generados
            ConfigurarDataGridViewDatos();

            // Configurar filtros de comparacion por tipo de dato
            comboBoxFiltroCompTipo.Items.AddRange(new object[] { "Todos", "Aleatorio", "Tendencia ascendente", "Descendente", "Alta repeticion" });
            comboBoxFiltroCompTipo.SelectedIndex = 0;

            string[] filtroCompAlgoritmos = new string[nombresAlgoritmos.Length + 1];
            filtroCompAlgoritmos[0] = "Todos";
            Array.Copy(nombresAlgoritmos, 0, filtroCompAlgoritmos, 1, nombresAlgoritmos.Length);
            comboBoxFiltroCompAlgoritmo.Items.AddRange(filtroCompAlgoritmos);
            comboBoxFiltroCompAlgoritmo.SelectedIndex = 0;

            ConfigurarDataGridViewComparacion();

            // Deshabilitar botones hasta tener resultados
            buttonVerDatos.Enabled = false;
            buttonGenerarGraficos.Enabled = false;
            buttonGenerarEstadisticas.Enabled = false;
            buttonExportarPDF.Enabled = false;
        }

       
        // CONFIGURACION DE DATAGRIDVIEWS
       

        private void ConfigurarDataGridViewMetricas()
        {
            // Grid de Rendimiento
            dataGridViewMetricasRendimiento.Columns.Clear();
            dataGridViewMetricasRendimiento.Columns.Add("Tamano", "Tamaño");
            dataGridViewMetricasRendimiento.Columns.Add("Iteracion", "Iteración");
            dataGridViewMetricasRendimiento.Columns.Add("Algoritmo", "Algoritmo");
            dataGridViewMetricasRendimiento.Columns.Add("TipoDatos", "Tipo de datos");
            dataGridViewMetricasRendimiento.Columns.Add("Ticks", "Ticks");
            dataGridViewMetricasRendimiento.Columns.Add("Milisegundos", "Milisegundos");
            dataGridViewMetricasRendimiento.Columns.Add("OrdenCorrecto", "¿Orden correcto?");

            // Grid de Operaciones
            dataGridViewMetricasOperaciones.Columns.Clear();
            dataGridViewMetricasOperaciones.Columns.Add("Tamano", "Tamaño");
            dataGridViewMetricasOperaciones.Columns.Add("Iteracion", "Iteración");
            dataGridViewMetricasOperaciones.Columns.Add("Algoritmo", "Algoritmo");
            dataGridViewMetricasOperaciones.Columns.Add("TipoDatos", "Tipo de datos");
            dataGridViewMetricasOperaciones.Columns.Add("Comparaciones", "Comparaciones");
            dataGridViewMetricasOperaciones.Columns.Add("Intercambios", "Intercambios");
            dataGridViewMetricasOperaciones.Columns.Add("Asignaciones", "Asignaciones");
            dataGridViewMetricasOperaciones.Columns.Add("Recursivas", "Llamadas recursivas");
        }

        private void ConfigurarDataGridViewEstadisticas()
        {
            dataGridViewEstadisticas.Columns.Clear();
            dataGridViewEstadisticas.Columns.Add("Tamano", "Tamaño");
            dataGridViewEstadisticas.Columns.Add("Algoritmo", "Algoritmo");
            dataGridViewEstadisticas.Columns.Add("TipoDatos", "Tipo de datos");
            dataGridViewEstadisticas.Columns.Add("Minimo", "Tiempo mínimo (ms)");
            dataGridViewEstadisticas.Columns.Add("Maximo", "Tiempo máximo (ms)");
            dataGridViewEstadisticas.Columns.Add("Promedio", "Tiempo promedio (ms)");
        }

        private void ConfigurarDataGridViewDatos()
        {
            dataGridViewDatos.Columns.Clear();
            dataGridViewDatos.Columns.Add("ID", "ID");
            dataGridViewDatos.Columns.Add("Aleatorio", "Aleatorio");
            dataGridViewDatos.Columns.Add("TendenciaAsc", "Tendencia ascendente");
            dataGridViewDatos.Columns.Add("Descendente", "Descendente");
            dataGridViewDatos.Columns.Add("AltaRepeticion", "Alta repeticion");

            foreach (DataGridViewColumn col in dataGridViewDatos.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        
        // BOTON: EJECUTAR PRUEBAS COMPLETAS
     

        private void buttonEjecutar_Click(object sender, EventArgs e)
        {
            // Validar entradas
            if (!ValidarEntradas()) return;

            int min = (int)numericUpDownMin.Value;
            int max = (int)numericUpDownMax.Value;

            // Limpiar datos anteriores
            listaMetricas.Clear();
            listaEstadisticas.Clear();
            datosGenerados.Clear();
            dataGridViewMetricasRendimiento.Rows.Clear();
            dataGridViewMetricasOperaciones.Rows.Clear();
            dataGridViewEstadisticas.Rows.Clear();
            dataGridViewDatos.Rows.Clear();
            // Limpiar gráficos anteriores
            chartComparativo.Series.Clear();
            chartComparativo.Titles.Clear();
            chartComparativo.ChartAreas.Clear();
            chartComparativo.Legends.Clear();
            textBoxConclusiones.Clear();

            pruebaActual = 0;
            totalPruebas = tamanos.Length * 5 * tiposDatos.Length * nombresAlgoritmos.Length;

            buttonEjecutar.Enabled = false;
            buttonVerDatos.Enabled = false;
            buttonGenerarGraficos.Enabled = false;
            buttonGenerarEstadisticas.Enabled = false;
            buttonExportarPDF.Enabled = false;

            // Ejecutar pruebas
            EjecutarPruebasCompletas(min, max);

            buttonEjecutar.Enabled = true;
            buttonVerDatos.Enabled = true;
            buttonGenerarGraficos.Enabled = true;
            buttonGenerarEstadisticas.Enabled = true;
            buttonExportarPDF.Enabled = true;

            MessageBox.Show("Pruebas completadas exitosamente.\nTotal de ejecuciones: " + totalPruebas, 
                "Proceso finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ============================================================
        // VALIDACION DE ENTRADAS
        // ============================================================

        private bool ValidarEntradas()
        {
            int min = (int)numericUpDownMin.Value;
            int max = (int)numericUpDownMax.Value;

            if (min >= max)
            {
                MessageBox.Show("El valor mínimo debe ser menor que el valor máximo.", 
                    "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Advertencia para Counting Sort con rangos muy grandes
            long rango = (long)max - (long)min;
            if (rango > 1000000)
            {
                DialogResult result = MessageBox.Show(
                    "El rango de valores es muy grande (" + rango + "). " +
                    "Counting Sort y Radix Sort pueden fallar o consumir mucha memoria. " +
                    "¿Desea continuar de todos modos?",
                    "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No) return false;
            }

            return true;
        }

       
        // EJECUCION DE PRUEBAS
       

        private void EjecutarPruebasCompletas(int min, int max)
        {
            Random rnd = new Random();

            foreach (int tam in tamanos)
            {
                for (int iter = 1; iter <= 5; iter++)
                {
                    // Generar los 4 tipos de datos para esta iteracion
                    int[][] arreglos = new int[4][];
                    arreglos[0] = GenerarAleatorio(tam, min, max, rnd);
                    arreglos[1] = GenerarTendenciaAscendente(tam, min, max, rnd);
                    arreglos[2] = GenerarDescendente(tam, min, max);
                    arreglos[3] = GenerarAltaRepeticion(tam, min, max, rnd);

                    // Guardar datos generados para visualizacion
                    string clave = tam + "_" + iter;
                    datosGenerados[clave] = arreglos;

                    // Ejecutar cada algoritmo sobre cada tipo de datos
                    for (int t = 0; t < tiposDatos.Length; t++)
                    {
                        for (int a = 0; a < nombresAlgoritmos.Length; a++)
                        {
                            pruebaActual++;
                            int progreso = (int)((double)pruebaActual / totalPruebas * 100);
                            progressBarEjecucion.Value = progreso;
                            labelProgreso.Text = "Progreso: " + pruebaActual + " / " + totalPruebas;
                            Application.DoEvents();

                            // Copia independiente del arreglo
                            int[] copia = (int[])arreglos[t].Clone();

                            // Reiniciar contadores
                            contComparaciones = 0;
                            contIntercambios = 0;
                            contAsignaciones = 0;
                            contLlamadasRecursivas = 0;

                            // Medir tiempo
                            Stopwatch sw = new Stopwatch();
                            sw.Start();

                            // Ejecutar algoritmo
                            EjecutarAlgoritmo(copia, a, min, max);

                            sw.Stop();

                            // Validar ordenamiento
                            bool ordenCorrecto = ValidarOrdenamiento(copia);

                            // Registrar metrica
                            Metrica m = new Metrica
                            {
                                Tamano = tam,
                                Iteracion = iter,
                                Algoritmo = nombresAlgoritmos[a],
                                TipoDatos = tiposDatos[t],
                                Ticks = sw.ElapsedTicks,
                                Milisegundos = sw.Elapsed.TotalMilliseconds,
                                OrdenCorrecto = ordenCorrecto,
                                Comparaciones = contComparaciones,
                                Intercambios = contIntercambios,
                                Asignaciones = contAsignaciones,
                                LlamadasRecursivas = contLlamadasRecursivas
                            };
                            listaMetricas.Add(m);

                            // Agregar a DataGridViews
                            dataGridViewMetricasRendimiento.Rows.Add(
                                m.Tamano, m.Iteracion, m.Algoritmo, m.TipoDatos,
                                m.Ticks, m.Milisegundos.ToString("F4"),
                                m.OrdenCorrecto ? "Sí" : "No"
                            );
                            dataGridViewMetricasOperaciones.Rows.Add(
                                m.Tamano, m.Iteracion, m.Algoritmo, m.TipoDatos,
                                m.Comparaciones, m.Intercambios, m.Asignaciones, m.LlamadasRecursivas
                            );

                            // Colorear fila si hay error
                            if (!ordenCorrecto)
                            {
                                dataGridViewMetricasRendimiento.Rows[dataGridViewMetricasRendimiento.Rows.Count - 1].DefaultCellStyle.BackColor = Color.LightCoral;
                                dataGridViewMetricasOperaciones.Rows[dataGridViewMetricasOperaciones.Rows.Count - 1].DefaultCellStyle.BackColor = Color.LightCoral;
                            }
                        }
                    }
                }
            }

            progressBarEjecucion.Value = 100;
            labelProgreso.Text = "Completado: " + totalPruebas + " / " + totalPruebas;
        }


        // GENERACION DE DATOS
        

        private int[] GenerarAleatorio(int n, int min, int max, Random rnd)
        {
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
                arr[i] = rnd.Next(min, max + 1);
            return arr;
        }

        private int[] GenerarTendenciaAscendente(int n, int min, int max, Random rnd)
        {
            int[] arr = new int[n];
            double step = (double)(max - min) / n;
            for (int i = 0; i < n; i++)
            {
                int baseVal = min + (int)(i * step);
                int variacion = rnd.Next(-Math.Max(1, (max - min) / (n * 2)), Math.Max(1, (max - min) / (n * 2)) + 1);
                arr[i] = Math.Max(min, Math.Min(max, baseVal + variacion));
            }
            return arr;
        }

        private int[] GenerarDescendente(int n, int min, int max)
        {
            int[] arr = new int[n];
            double step = (double)(max - min) / n;
            for (int i = 0; i < n; i++)
                arr[i] = max - (int)(i * step);
            return arr;
        }

        private int[] GenerarAltaRepeticion(int n, int min, int max, Random rnd)
        {
            int[] arr = new int[n];
            // Usar solo 5 valores distintos dentro del rango
            int[] valores = new int[5];
            for (int i = 0; i < 5; i++)
                valores[i] = min + (i * (max - min) / 4);

            for (int i = 0; i < n; i++)
                arr[i] = valores[rnd.Next(5)];
            return arr;
        }

        // ============================================================
        // VALIDACION DE ORDENAMIENTO
        // ============================================================

        private bool ValidarOrdenamiento(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
                if (arr[i - 1] > arr[i])
                    return false;
            return true;
        }

     
        // EJECUCION DE ALGORITMOS
 

        private void EjecutarAlgoritmo(int[] arr, int algoritmoIndex, int min, int max)
        {
            switch (algoritmoIndex)
            {
                case 0: Insercion(arr); break;
                case 1: Seleccion(arr); break;
                case 2: Burbuja(arr); break;
                case 3: ShellSort(arr); break;
                case 4: MergeSort(arr, 0, arr.Length - 1); break;
                case 5: HeapSort(arr); break;
                case 6: QuickSort(arr, 0, arr.Length - 1); break;
                case 7: QuickSort3Vias(arr, 0, arr.Length - 1); break;
                case 8: CountingSort(arr, min, max); break;
                case 9: RadixSort(arr, min); break;
            }
        }

        // ============================================================
        // ALGORITMO 1: INSERCION
        // ============================================================

        private void Insercion(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                int key = arr[i];
                contAsignaciones++;
                int j = i - 1;
                while (j >= 0)
                {
                    contComparaciones++;
                    if (arr[j] > key)
                    {
                        arr[j + 1] = arr[j];
                        contIntercambios++;
                        contAsignaciones++;
                        j--;
                    }
                    else break;
                }
                if (j >= 0) contComparaciones++;
                arr[j + 1] = key;
                contAsignaciones++;
            }
        }

        
        // ALGORITMO 2: SELECCION
        

        private void Seleccion(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIdx = i;
                for (int j = i + 1; j < n; j++)
                {
                    contComparaciones++;
                    if (arr[j] < arr[minIdx])
                        minIdx = j;
                }
                if (minIdx != i)
                {
                    int temp = arr[i];
                    arr[i] = arr[minIdx];
                    arr[minIdx] = temp;
                    contIntercambios++;
                    contAsignaciones += 3;
                }
            }
        }

       
        // ALGORITMO 3: BURBUJA


        private void Burbuja(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    contComparaciones++;
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        contIntercambios++;
                        contAsignaciones += 3;
                    }
                }
            }
        }

        
        // ALGORITMO 4: SHELL SORT
   

        private void ShellSort(int[] arr)
        {
            int n = arr.Length;
            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < n; i++)
                {
                    int temp = arr[i];
                    contAsignaciones++;
                    int j = i;
                    while (j >= gap)
                    {
                        contComparaciones++;
                        if (arr[j - gap] > temp)
                        {
                            arr[j] = arr[j - gap];
                            contIntercambios++;
                            contAsignaciones++;
                            j -= gap;
                        }
                        else break;
                    }
                    if (j >= gap) contComparaciones++;
                    arr[j] = temp;
                    contAsignaciones++;
                }
            }
        }

        
        // ALGORITMO 5: MERGE SORT
     

        private void MergeSort(int[] arr, int left, int right)
        {
            contLlamadasRecursivas++;
            if (left < right)
            {
                int mid = left + (right - left) / 2;
                MergeSort(arr, left, mid);
                MergeSort(arr, mid + 1, right);
                Merge(arr, left, mid, right);
            }
        }

        private void Merge(int[] arr, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;
            int[] L = new int[n1];
            int[] R = new int[n2];
            contAsignaciones += 2;

            for (int i = 0; i < n1; i++)
            {
                L[i] = arr[left + i];
                contAsignaciones++;
            }
            for (int j = 0; j < n2; j++)
            {
                R[j] = arr[mid + 1 + j];
                contAsignaciones++;
            }

            int iL = 0, iR = 0, k = left;
            while (iL < n1 && iR < n2)
            {
                contComparaciones++;
                if (L[iL] <= R[iR])
                {
                    arr[k] = L[iL];
                    iL++;
                }
                else
                {
                    arr[k] = R[iR];
                    iR++;
                }
                contAsignaciones++;
                k++;
            }

            while (iL < n1)
            {
                arr[k] = L[iL];
                iL++;
                k++;
                contAsignaciones++;
            }
            while (iR < n2)
            {
                arr[k] = R[iR];
                iR++;
                k++;
                contAsignaciones++;
            }
        }

        // ALGORITMO 6: HEAP SORT
      

        private void HeapSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = n / 2 - 1; i >= 0; i--)
                Heapify(arr, n, i);

            for (int i = n - 1; i > 0; i--)
            {
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;
                contIntercambios++;
                contAsignaciones += 3;
                Heapify(arr, i, 0);
            }
        }

        private void Heapify(int[] arr, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < n)
            {
                contComparaciones++;
                if (arr[left] > arr[largest])
                    largest = left;
            }
            if (right < n)
            {
                contComparaciones++;
                if (arr[right] > arr[largest])
                    largest = right;
            }

            if (largest != i)
            {
                int temp = arr[i];
                arr[i] = arr[largest];
                arr[largest] = temp;
                contIntercambios++;
                contAsignaciones += 3;
                Heapify(arr, n, largest);
            }
        }

      
        // ALGORITMO 7: QUICK SORT
       

        private void QuickSort(int[] arr, int low, int high)
        {
            contLlamadasRecursivas++;
            if (low < high)
            {
                int pi = Partition(arr, low, high);
                QuickSort(arr, low, pi - 1);
                QuickSort(arr, pi + 1, high);
            }
        }

        private int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            contAsignaciones++;
            int i = low - 1;
            for (int j = low; j < high; j++)
            {
                contComparaciones++;
                if (arr[j] < pivot)
                {
                    i++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    contIntercambios++;
                    contAsignaciones += 3;
                }
            }
            int temp2 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp2;
            contIntercambios++;
            contAsignaciones += 3;
            return i + 1;
        }

        
        // ALGORITMO 8: QUICK SORT DE TRES VIAS
       

        private void QuickSort3Vias(int[] arr, int low, int high)
        {
            contLlamadasRecursivas++;
            if (low < high)
            {
                int lt = low, gt = high;
                int pivot = arr[low];
                contAsignaciones++;
                int i = low + 1;
                while (i <= gt)
                {
                    contComparaciones++;
                    if (arr[i] < pivot)
                    {
                        int temp = arr[lt];
                        arr[lt] = arr[i];
                        arr[i] = temp;
                        lt++;
                        i++;
                        contIntercambios++;
                        contAsignaciones += 3;
                    }
                    else if (arr[i] > pivot)
                    {
                        contComparaciones++;
                        int temp = arr[i];
                        arr[i] = arr[gt];
                        arr[gt] = temp;
                        gt--;
                        contIntercambios++;
                        contAsignaciones += 3;
                    }
                    else
                    {
                        contComparaciones++;
                        i++;
                    }
                }
                QuickSort3Vias(arr, low, lt - 1);
                QuickSort3Vias(arr, gt + 1, high);
            }
        }

        
        // ALGORITMO 9: COUNTING SORT (adaptado para negativos)
        

        private void CountingSort(int[] arr, int min, int max)
        {
            long rango = (long)max - (long)min + 1;
            if (rango > int.MaxValue)
            {
                // Si el rango es muy grande, usar un metodo alternativo
                Array.Sort(arr);
                return;
            }

            int[] count = new int[rango];
            contAsignaciones++;
            int[] output = new int[arr.Length];
            contAsignaciones++;

            for (int i = 0; i < arr.Length; i++)
            {
                count[arr[i] - min]++;
                contComparaciones++;
                contAsignaciones++;
            }

            for (int i = 1; i < count.Length; i++)
            {
                count[i] += count[i - 1];
                contComparaciones++;
                contAsignaciones++;
            }

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                output[count[arr[i] - min] - 1] = arr[i];
                count[arr[i] - min]--;
                contComparaciones++;
                contAsignaciones += 2;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = output[i];
                contComparaciones++;
                contAsignaciones++;
            }
        }

        // ALGORITMO 10: RADIX SORT (adaptado para negativos)
       

        private void RadixSort(int[] arr, int min)
        {
            // Separar negativos y no negativos
            List<int> negativos = new List<int>();
            List<int> noNegativos = new List<int>();
            foreach (int val in arr)
            {
                if (val < 0) negativos.Add(-val);
                else noNegativos.Add(val);
            }

            if (noNegativos.Count > 1)
                RadixSortPositivos(noNegativos.ToArray());
            if (negativos.Count > 1)
                RadixSortPositivos(negativos.ToArray());

            // Reconstruir arreglo
            negativos.Sort((a, b) => b.CompareTo(a));
            int idx = 0;
            foreach (int val in negativos)
                arr[idx++] = -val;
            foreach (int val in noNegativos)
                arr[idx++] = val;
        }

        private void RadixSortPositivos(int[] arr)
        {
            if (arr.Length <= 1) return;
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                contComparaciones++;
                if (arr[i] > max) max = arr[i];
            }

            for (int exp = 1; max / exp > 0; exp *= 10)
                CountingSortPorDigito(arr, exp);
        }

        private void CountingSortPorDigito(int[] arr, int exp)
        {
            int[] output = new int[arr.Length];
            int[] count = new int[10];
            contAsignaciones += 2;

            for (int i = 0; i < arr.Length; i++)
            {
                count[(arr[i] / exp) % 10]++;
                contComparaciones++;
                contAsignaciones++;
            }

            for (int i = 1; i < 10; i++)
            {
                count[i] += count[i - 1];
                contComparaciones++;
                contAsignaciones++;
            }

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                output[count[(arr[i] / exp) % 10] - 1] = arr[i];
                count[(arr[i] / exp) % 10]--;
                contComparaciones++;
                contAsignaciones += 2;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = output[i];
                contComparaciones++;
                contAsignaciones++;
            }
        }

        // BOTON: VER DATOS GENERADOS
   

        private void buttonVerDatos_Click(object sender, EventArgs e)
        {
            if (datosGenerados.Count == 0)
            {
                MessageBox.Show("No hay datos generados. Ejecute las pruebas primero.",
                    "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int tam = int.Parse(comboBoxTamano.SelectedItem.ToString());
            int iter = int.Parse(comboBoxIteracion.SelectedItem.ToString());
            string clave = tam + "_" + iter;

            if (!datosGenerados.ContainsKey(clave))
            {
                MessageBox.Show("No se encontraron datos para esta combinacion.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int[][] arreglos = datosGenerados[clave];
            dataGridViewDatos.Rows.Clear();

            int maxFilas = Math.Min(100, tam); // Mostrar maximo 100 filas para no saturar
            for (int i = 0; i < maxFilas; i++)
            {
                dataGridViewDatos.Rows.Add(
                    i,
                    arreglos[0][i],
                    arreglos[1][i],
                    arreglos[2][i],
                    arreglos[3][i]
                );
            }

            // Actualizar graficos individuales
            string[] nombres = { "Aleatorio", "Tendencia ascendente", "Descendente", "Alta repeticion" };
            System.Windows.Forms.DataVisualization.Charting.Chart[] charts = { chartDatoAleatorio, chartDatoAscendente, chartDatoDescendente, chartDatoRepeticion };
            System.Drawing.Color[] colores = {
                System.Drawing.Color.FromArgb(255, 99, 132),
                System.Drawing.Color.FromArgb(54, 162, 235),
                System.Drawing.Color.FromArgb(255, 206, 86),
                System.Drawing.Color.FromArgb(75, 192, 192)
            };

            for (int t = 0; t < 4; t++)
            {
                Chart ch = charts[t];
                ch.Series.Clear();
                ch.Titles.Clear();
                ch.ChartAreas.Clear();
                ch.Legends.Clear();

                ChartArea ca = new ChartArea("Area" + t);
                ca.AxisX.Title = "Posición";
                ca.AxisY.Title = "Valor";
                ca.BackColor = System.Drawing.Color.FromArgb(250, 250, 252);
                ca.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(235, 235, 240);
                ca.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(235, 235, 240);
                ch.ChartAreas.Add(ca);

                ch.Titles.Add(new System.Windows.Forms.DataVisualization.Charting.Title(nombres[t], Docking.Top,
                    new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold), System.Drawing.Color.FromArgb(44, 62, 80)));

                Series serie = new Series();
                serie.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                serie.BorderWidth = 2;
                serie.Color = colores[t];
                for (int i = 0; i < maxFilas; i++)
                    serie.Points.AddXY(i, arreglos[t][i]);
                ch.Series.Add(serie);

                ch.ChartAreas[0].RecalculateAxesScale();
            }

            tabControlPrincipal.SelectedTab = tabPageDatos;
        }

        
        // BOTON: GENERAR ESTADISTICAS

        private void buttonGenerarEstadisticas_Click(object sender, EventArgs e)
        {
            if (listaMetricas.Count == 0)
            {
                MessageBox.Show("No hay metricas registradas. Ejecute las pruebas primero.",
                    "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            listaEstadisticas.Clear();
            dataGridViewEstadisticas.Rows.Clear();

            var grupos = listaMetricas.GroupBy(m => new { m.Tamano, m.Algoritmo, m.TipoDatos });

            foreach (var grupo in grupos)
            {
                var tiempos = grupo.Select(m => m.Milisegundos).ToList();
                Estadistica est = new Estadistica
                {
                    Tamano = grupo.Key.Tamano,
                    Algoritmo = grupo.Key.Algoritmo,
                    TipoDatos = grupo.Key.TipoDatos,
                    Minimo = tiempos.Min(),
                    Maximo = tiempos.Max(),
                    Promedio = tiempos.Average()
                };
                listaEstadisticas.Add(est);
            }

            // Aplicar filtros actuales
            FiltrosEstadisticas_Changed(null, null);

            GenerarConclusiones();
            GenerarGraficosComparacionTipos();
            if (comboBoxFiltroCompTipo.Items.Count > 0)
                buttonFiltroCompAplicar_Click(null, null);
            tabControlPrincipal.SelectedTab = tabPageEstadisticas;
        }

        
        // GENERAR CONCLUSIONES AUTOMATICAS
        

        private void GenerarConclusiones()
        {
            if (listaEstadisticas.Count == 0) return;

            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.AppendLine("=== CONCLUSIONES EXPERIMENTALES ===");
            sb.AppendLine();

            // Mejor algoritmo por tamaño (datos aleatorios)
            sb.AppendLine("1. MEJOR ALGORITMO POR TAMAÑO (datos aleatorios):");
            foreach (int tam in tamanos)
            {
                var mejores = listaEstadisticas
                    .Where(e => e.Tamano == tam && e.TipoDatos == "Aleatorio")
                    .OrderBy(e => e.Promedio)
                    .FirstOrDefault();
                if (mejores.Algoritmo != null)
                    sb.AppendLine("   Tamaño " + tam + ": " + mejores.Algoritmo + " (" + mejores.Promedio.ToString("F4") + " ms)");
            }
            sb.AppendLine();

            // Algoritmos que mantienen buen desempeño al crecer
            sb.AppendLine("2. ALGORITMOS CON BUEN DESEMPEÑO AL CRECER:");
            var algoritmos = listaEstadisticas.Select(e => e.Algoritmo).Distinct().ToList();
            foreach (string alg in algoritmos)
            {
                var datos = listaEstadisticas
                    .Where(e => e.Algoritmo == alg && e.TipoDatos == "Aleatorio")
                    .OrderBy(e => e.Tamano)
                    .ToList();
                if (datos.Count == 4)
                {
                    double ratio = datos[3].Promedio / Math.Max(datos[0].Promedio, 0.001);
                    if (ratio < 500) // Criterio arbitrario para "buen desempeño"
                        sb.AppendLine("   " + alg + " - Ratio 10K/100: " + ratio.ToString("F2") + "x");
                }
            }
            sb.AppendLine();

            // Peor algoritmo con datos descendentes
            sb.AppendLine("3. PEOR DESEMPEÑO CON DATOS DESCENDENTES:");
            var peorDesc = listaEstadisticas
                .Where(e => e.TipoDatos == "Descendente" && e.Tamano == 10000)
                .OrderByDescending(e => e.Promedio)
                .FirstOrDefault();
            if (peorDesc.Algoritmo != null)
                sb.AppendLine("   " + peorDesc.Algoritmo + " (" + peorDesc.Promedio.ToString("F4") + " ms)");
            sb.AppendLine();

            // Quick Sort vs Quick Sort 3 vías con datos repetidos
            sb.AppendLine("4. QUICK SORT vs QUICK SORT 3 VÍAS (datos con alta repeticion, n=10000):");
            var qs = listaEstadisticas.FirstOrDefault(e => e.Algoritmo == "Quick Sort" && e.TipoDatos == "Alta repeticion" && e.Tamano == 10000);
            var qs3 = listaEstadisticas.FirstOrDefault(e => e.Algoritmo == "Quick Sort 3 Vias" && e.TipoDatos == "Alta repeticion" && e.Tamano == 10000);
            if (qs.Algoritmo != null && qs3.Algoritmo != null)
            {
                sb.AppendLine("   Quick Sort: " + qs.Promedio.ToString("F4") + " ms");
                sb.AppendLine("   Quick Sort 3 Vías: " + qs3.Promedio.ToString("F4") + " ms");
                sb.AppendLine("   Diferencia: " + Math.Abs(qs.Promedio - qs3.Promedio).ToString("F4") + " ms");
            }
            sb.AppendLine();

            // Counting Sort y Radix Sort
            sb.AppendLine("5. COUNTING SORT Y RADIX SORT:");
            var cs = listaEstadisticas.FirstOrDefault(e => e.Algoritmo == "Counting Sort" && e.TipoDatos == "Aleatorio" && e.Tamano == 10000);
            var rs = listaEstadisticas.FirstOrDefault(e => e.Algoritmo == "Radix Sort" && e.TipoDatos == "Aleatorio" && e.Tamano == 10000);
            if (cs.Algoritmo != null)
                sb.AppendLine("   Counting Sort (10K aleatorio): " + cs.Promedio.ToString("F4") + " ms");
            if (rs.Algoritmo != null)
                sb.AppendLine("   Radix Sort (10K aleatorio): " + rs.Promedio.ToString("F4") + " ms");
            sb.AppendLine("   Ventaja: O(n) para rangos acotados.");
            sb.AppendLine("   Limitación: Dependen del rango de valores.");
            sb.AppendLine();

            // Variacion entre iteraciones
            sb.AppendLine("6. VARIACIÓN ENTRE ITERACIONES:");
            var variacion = listaMetricas
                .Where(m => m.Tamano == 10000 && m.TipoDatos == "Aleatorio")
                .GroupBy(m => m.Algoritmo)
                .Select(g => new { Algoritmo = g.Key, StdDev = CalcularDesviacion(g.Select(x => x.Milisegundos).ToList()) })
                .OrderBy(x => x.StdDev)
                .ToList();
            foreach (var v in variacion.Take(5))
                sb.AppendLine("   " + v.Algoritmo + " - Desv. std: " + v.StdDev.ToString("F4"));
            sb.AppendLine();

            // Mejor para datos parcialmente ordenados
            sb.AppendLine("7. MEJOR CON DATOS PARCIALMENTE ORDENADOS (tendencia ascendente):");
            var mejorParcial = listaEstadisticas
                .Where(e => e.TipoDatos == "Tendencia ascendente" && e.Tamano == 10000)
                .OrderBy(e => e.Promedio)
                .FirstOrDefault();
            if (mejorParcial.Algoritmo != null)
                sb.AppendLine("   " + mejorParcial.Algoritmo + " (" + mejorParcial.Promedio.ToString("F4") + " ms)");

            textBoxConclusiones.Text = sb.ToString();
        }

        private double CalcularDesviacion(List<double> valores)
        {
            if (valores.Count <= 1) return 0;
            double promedio = valores.Average();
            double suma = valores.Sum(v => Math.Pow(v - promedio, 2));
            return Math.Sqrt(suma / (valores.Count - 1));
        }

        // GRAFICOS DE COMPARACION POR TIPO DE DATO
      

        private void GenerarGraficosComparacionTipos()
        {
            if (listaEstadisticas.Count == 0) return;

            System.Windows.Forms.DataVisualization.Charting.Chart[] charts = {
                chartCompAleatorio, chartCompAscendente, chartCompDescendente, chartCompRepeticion
            };
            string[] titulos = { "Aleatorio", "Tendencia ascendente", "Descendente", "Alta repeticion" };
            System.Drawing.Color[] colores = {
                System.Drawing.Color.FromArgb(255, 99, 132),
                System.Drawing.Color.FromArgb(54, 162, 235),
                System.Drawing.Color.FromArgb(255, 206, 86),
                System.Drawing.Color.FromArgb(75, 192, 192)
            };
            int[] tamanos = { 100, 1000, 5000, 10000 };
            string[] nomTam = { "n=100", "n=1.000", "n=5.000", "n=10.000" };

            for (int t = 0; t < 4; t++)
            {
                Chart ch = charts[t];
                ch.Series.Clear();
                ch.Titles.Clear();
                ch.ChartAreas.Clear();
                ch.Legends.Clear();

                ChartArea ca = new ChartArea("AreaAlgo" + t);
                ca.AxisX.Title = "Algoritmo";
                ca.AxisY.Title = "Tiempo promedio (ms)";
                ca.AxisX.Interval = 1;
                ca.BackColor = System.Drawing.Color.FromArgb(250, 250, 252);
                ca.BorderColor = System.Drawing.Color.FromArgb(230, 230, 235);
                ca.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(235, 235, 240);
                ca.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(235, 235, 240);
                ca.AxisX.LineColor = System.Drawing.Color.FromArgb(200, 200, 210);
                ca.AxisY.LineColor = System.Drawing.Color.FromArgb(200, 200, 210);
                ca.AxisX.TitleFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
                ca.AxisY.TitleFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
                ca.AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 7.5F);
                ch.ChartAreas.Add(ca);

                ch.Titles.Add(new System.Windows.Forms.DataVisualization.Charting.Title(titulos[t], Docking.Top,
                    new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold), System.Drawing.Color.FromArgb(44, 62, 80)));

                Legend legend = new Legend("Legend");
                legend.BackColor = System.Drawing.Color.Transparent;
                legend.Docking = Docking.Bottom;
                legend.Alignment = System.Drawing.StringAlignment.Center;
                legend.Font = new System.Drawing.Font("Segoe UI", 8F);
                ch.Legends.Add(legend);

                for (int s = 0; s < tamanos.Length; s++)
                {
                    Series serie = new Series(nomTam[s]);
                    serie.ChartType = SeriesChartType.Column;
                    serie.Color = colores[s];
                    serie.IsValueShownAsLabel = true;
                    serie.LabelFormat = "{0:F1}";
                    serie.LabelForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
                    serie.Font = new System.Drawing.Font("Segoe UI", 6.5F);

                    for (int a = 0; a < nombresAlgoritmos.Length; a++)
                    {
                        var datos = listaEstadisticas
                            .Where(item => item.Algoritmo == nombresAlgoritmos[a]
                                        && item.TipoDatos == tiposDatos[t]
                                        && item.Tamano == tamanos[s])
                            .ToList();
                        double promedio = datos.Count > 0 ? datos.Average(d => d.Promedio) : 0;
                        DataPoint punto = new DataPoint(a, promedio);
                        if (promedio > 0)
                            punto.Label = promedio.ToString("F1");
                        serie.Points.Add(punto);
                    }

                    ch.Series.Add(serie);
                }

                // Custom labels for X axis (algorithm names)
                ca.AxisX.CustomLabels.Clear();
                for (int a = 0; a < nombresAlgoritmos.Length; a++)
                {
                    CustomLabel cl = new CustomLabel();
                    cl.FromPosition = a - 0.4;
                    cl.ToPosition = a + 0.4;
                    cl.Text = nombresAlgoritmos[a];
                    cl.LabelMark = LabelMarkStyle.None;
                    ca.AxisX.CustomLabels.Add(cl);
                }
                ca.AxisX.LabelStyle.Enabled = false;

                ch.ChartAreas[0].RecalculateAxesScale();
            }
        }

   
        // FILTROS DE GRAFICOS (actualizan automaticamente)
        

        private void FiltrosGraficos_Changed(object sender, EventArgs e)
        {
            if (listaEstadisticas.Count > 0)
                buttonGenerarGraficos_Click(sender, e);
        }

       
        // FILTROS: DATOS GENERADOS (auto-actualización)
        private void FiltrosDatos_Changed(object sender, EventArgs e)
        {
            if (datosGenerados.Count == 0) return;

            int tam = int.Parse(comboBoxTamano.SelectedItem.ToString());
            int iter = int.Parse(comboBoxIteracion.SelectedItem.ToString());
            string clave = tam + "_" + iter;

            if (!datosGenerados.ContainsKey(clave)) return;

            int[][] arreglos = datosGenerados[clave];
            string tipoSeleccionado = comboBoxTipoDatos.SelectedItem.ToString();

            // Filtrar columnas del DataGridView según tipo de datos seleccionado
            dataGridViewDatos.Columns.Clear();
            dataGridViewDatos.Columns.Add("ID", "ID");
            dataGridViewDatos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            string[] nombresColumnas;
            string[] nombresSeries;
            if (tipoSeleccionado == "Todos")
            {
                nombresColumnas = new[] { "Aleatorio", "Tendencia ascendente", "Descendente", "Alta repeticion" };
                nombresSeries = new[] { "Aleatorio", "Tendencia ascendente", "Descendente", "Alta repeticion" };
            }
            else
            {
                string columnaKey = tipoSeleccionado.Replace(" ascendente", "Asc").Replace(" repeticion", "Repeticion");
                nombresColumnas = new[] { tipoSeleccionado };
                nombresSeries = new[] { tipoSeleccionado };
            }

            foreach (string col in nombresColumnas)
            {
                dataGridViewDatos.Columns.Add(col, col);
                dataGridViewDatos.Columns[dataGridViewDatos.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            dataGridViewDatos.Rows.Clear();

            int maxFilas = Math.Min(100, tam);
            for (int i = 0; i < maxFilas; i++)
            {
                if (tipoSeleccionado == "Todos")
                {
                    dataGridViewDatos.Rows.Add(i,
                        arreglos[0][i], arreglos[1][i], arreglos[2][i], arreglos[3][i]);
                }
                else
                {
                    int idx = tipoSeleccionado == "Aleatorio" ? 0 :
                              tipoSeleccionado == "Tendencia ascendente" ? 1 :
                              tipoSeleccionado == "Descendente" ? 2 : 3;
                    dataGridViewDatos.Rows.Add(i, arreglos[idx][i]);
                }
            }

            // Actualizar gráficos individuales
            System.Windows.Forms.DataVisualization.Charting.Chart[] charts = { chartDatoAleatorio, chartDatoAscendente, chartDatoDescendente, chartDatoRepeticion };
            string[] nombres = { "Aleatorio", "Tendencia ascendente", "Descendente", "Alta repeticion" };
            System.Drawing.Color[] colores = {
                System.Drawing.Color.FromArgb(255, 99, 132),
                System.Drawing.Color.FromArgb(54, 162, 235),
                System.Drawing.Color.FromArgb(255, 206, 86),
                System.Drawing.Color.FromArgb(75, 192, 192)
            };
            int[] indicesMostrar = tipoSeleccionado == "Todos"
                ? new[] { 0, 1, 2, 3 }
                : new[] { Array.IndexOf(new[] { "Aleatorio", "Tendencia ascendente", "Descendente", "Alta repeticion" }, tipoSeleccionado) };

            foreach (Chart ch in charts)
            {
                ch.Series.Clear();
                ch.Titles.Clear();
                ch.ChartAreas.Clear();
                ch.Legends.Clear();
            }

            for (int t = 0; t < indicesMostrar.Length; t++)
            {
                int idx = indicesMostrar[t];
                Chart ch = charts[idx];
                ChartArea ca = new ChartArea("Area" + idx);
                ca.AxisX.Title = "Posición";
                ca.AxisY.Title = "Valor";
                ca.BackColor = System.Drawing.Color.FromArgb(250, 250, 252);
                ca.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(235, 235, 240);
                ca.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(235, 235, 240);
                ch.ChartAreas.Add(ca);

                ch.Titles.Add(new System.Windows.Forms.DataVisualization.Charting.Title(nombres[idx], Docking.Top,
                    new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold), System.Drawing.Color.FromArgb(44, 62, 80)));

                var serie = new System.Windows.Forms.DataVisualization.Charting.Series();
                serie.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                serie.BorderWidth = 2;
                serie.Color = colores[idx];
                for (int i = 0; i < maxFilas; i++)
                    serie.Points.AddXY(i, arreglos[idx][i]);
                ch.Series.Add(serie);
                ch.ChartAreas[0].RecalculateAxesScale();
            }
        }

        
        // FILTROS: METRICAS DETALLADAS (auto-actualización)
       

        private void FiltrosMetricas_Changed(object sender, EventArgs e)
        {
            if (listaMetricas.Count == 0) return;

            string algo = comboBoxFiltroAlgoritmo.SelectedItem.ToString();
            string tipo = comboBoxFiltroTipoDatos.SelectedItem.ToString();
            string tam = comboBoxFiltroTamano.SelectedItem.ToString();
            string iter = comboBoxFiltroIteracion.SelectedItem.ToString();

            var query = listaMetricas.AsEnumerable();

            if (algo != "Todos")
                query = query.Where(m => m.Algoritmo == algo);
            if (tipo != "Todos")
                query = query.Where(m => m.TipoDatos == tipo);
            if (tam != "Todos")
            {
                int tamVal = int.Parse(tam);
                query = query.Where(m => m.Tamano == tamVal);
            }
            if (iter != "Todos")
            {
                int iterVal = int.Parse(iter);
                query = query.Where(m => m.Iteracion == iterVal);
            }

            var filtrados = query.ToList();

            dataGridViewMetricasRendimiento.Rows.Clear();
            dataGridViewMetricasOperaciones.Rows.Clear();

            foreach (var m in filtrados)
            {
                dataGridViewMetricasRendimiento.Rows.Add(
                    m.Tamano, m.Iteracion, m.Algoritmo, m.TipoDatos,
                    m.Ticks, m.Milisegundos.ToString("F4"),
                    m.OrdenCorrecto ? "Sí" : "No"
                );

                dataGridViewMetricasOperaciones.Rows.Add(
                    m.Tamano, m.Iteracion, m.Algoritmo, m.TipoDatos,
                    m.Comparaciones, m.Intercambios, m.Asignaciones, m.LlamadasRecursivas
                );
            }
        }

        // ============================================================
        // FILTROS: ESTADISTICAS CONSOLIDADAS (auto-actualización)
        // ============================================================

        private void FiltrosEstadisticas_Changed(object sender, EventArgs e)
        {
            if (listaEstadisticas.Count == 0) return;

            string algo = comboBoxEstFiltroAlgoritmo.SelectedItem.ToString();
            string tipo = comboBoxEstFiltroTipoDatos.SelectedItem.ToString();
            string tam = comboBoxEstFiltroTamano.SelectedItem.ToString();

            var query = listaEstadisticas.AsEnumerable();

            if (algo != "Todos")
                query = query.Where(est => est.Algoritmo == algo);
            if (tipo != "Todos")
                query = query.Where(est => est.TipoDatos == tipo);
            if (tam != "Todos")
            {
                int tamVal = int.Parse(tam);
                query = query.Where(est => est.Tamano == tamVal);
            }

            var filtrados = query.ToList();
            dataGridViewEstadisticas.Rows.Clear();

            foreach (var est in filtrados)
            {
                dataGridViewEstadisticas.Rows.Add(
                    est.Tamano, est.Algoritmo, est.TipoDatos,
                    est.Minimo.ToString("F4"), est.Maximo.ToString("F4"), est.Promedio.ToString("F4")
                );
            }
        }

        // ============================================================
        // GRAFICOS COMPARATIVOS POR TIPO DE DATOS
        // ============================================================

        private void buttonGenerarGraficos_Click(object sender, EventArgs e)
        {
            if (listaEstadisticas.Count == 0)
            {
                MessageBox.Show("Genere las estadísticas primero.",
                    "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tipoSeleccionado = comboBoxGrafTipo.SelectedItem.ToString();
            string tipoGraficoSeleccionado = comboBoxGrafTipoGrafico.SelectedItem.ToString();
            string tamanoSeleccionado = comboBoxGrafTamano.SelectedItem.ToString();
            string algoritmoSeleccionado = comboBoxGrafAlgoritmo.SelectedItem.ToString();

            SeriesChartType chartType;
            bool mostrarEtiquetas;
            switch (tipoGraficoSeleccionado)
            {
                case "Lineas":
                    chartType = SeriesChartType.Line;
                    mostrarEtiquetas = false;
                    break;
                case "Puntos":
                    chartType = SeriesChartType.Point;
                    mostrarEtiquetas = true;
                    break;
                default:
                    chartType = SeriesChartType.Column;
                    mostrarEtiquetas = true;
                    break;
            }

            System.Drawing.Color[] colores = {
                System.Drawing.Color.FromArgb(255, 99, 132),
                System.Drawing.Color.FromArgb(54, 162, 235),
                System.Drawing.Color.FromArgb(255, 206, 86),
                System.Drawing.Color.FromArgb(75, 192, 192)
            };
            string[] nombresTiposCortos = {
                "Aleatorio", "Tend. asc.", "Descendente", "Alta rep."
            };

            // Configurar chart
            Chart chart = chartComparativo;
            chart.Series.Clear();
            chart.Titles.Clear();
            chart.ChartAreas.Clear();
            chart.Legends.Clear();
            chart.BackColor = System.Drawing.Color.FromArgb(250, 250, 252);
            chart.BorderSkin.SkinStyle = BorderSkinStyle.None;

            ChartArea area = new ChartArea("AreaPrincipal");
            area.AxisX.Title = "Tipo de datos";
            area.AxisY.Title = "Tiempo promedio (ms)";
            area.AxisX.Interval = 1;
            area.BackColor = System.Drawing.Color.FromArgb(250, 250, 252);
            area.BorderColor = System.Drawing.Color.FromArgb(230, 230, 235);
            area.BorderDashStyle = ChartDashStyle.Solid;
            area.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(235, 235, 240);
            area.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(235, 235, 240);
            area.AxisX.LineColor = System.Drawing.Color.FromArgb(200, 200, 210);
            area.AxisY.LineColor = System.Drawing.Color.FromArgb(200, 200, 210);
            area.AxisX.TitleFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            area.AxisY.TitleFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            area.AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            area.AxisY.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            chart.ChartAreas.Add(area);

            Title titulo = new Title("Algoritmo: " + algoritmoSeleccionado + " - Tiempo promedio por tipo de datos", Docking.Top,
                new System.Drawing.Font("Segoe UI", 11, System.Drawing.FontStyle.Bold), System.Drawing.Color.FromArgb(44, 62, 80));
            chart.Titles.Add(titulo);

            Legend legend = new Legend("Legend");
            legend.BackColor = System.Drawing.Color.Transparent;
            legend.Docking = Docking.Bottom;
            legend.Alignment = System.Drawing.StringAlignment.Center;
            legend.Font = new System.Drawing.Font("Segoe UI", 8F);
            chart.Legends.Add(legend);

            // Series por tamaño
            int[] tamanosFiltro = { 100, 1000, 5000, 10000 };
            int serieIndex = 0;
            for (int s = 0; s < tamanosFiltro.Length; s++)
            {
                int tam = tamanosFiltro[s];
                if (tamanoSeleccionado != "Todos")
                {
                    if (tam != int.Parse(tamanoSeleccionado)) continue;
                }

                string nombreSerie = "n=" + tam;
                Series serie = new Series(nombreSerie);
                serie.ChartType = chartType;
                serie.Color = colores[s % colores.Length];
                serie.IsValueShownAsLabel = mostrarEtiquetas;
                serie.LabelFormat = "{0:F2}";

                if (chartType == SeriesChartType.Line || chartType == SeriesChartType.Point)
                {
                    serie.MarkerStyle = MarkerStyle.Circle;
                    serie.MarkerSize = 8;
                    serie.BorderWidth = 2;
                }

                for (int t = 0; t < tiposDatos.Length; t++)
                {
                    if (tipoSeleccionado != "Todos" && tipoSeleccionado != tiposDatos[t])
                        continue;

                    var datos = listaEstadisticas
                        .Where(item => item.Algoritmo == algoritmoSeleccionado
                                    && item.TipoDatos == tiposDatos[t]
                                    && item.Tamano == tam)
                        .ToList();

                    double promedio = datos.Count > 0 ? datos.Average(d => d.Promedio) : 0;
                    DataPoint punto = new DataPoint(t, promedio);
                    if (mostrarEtiquetas)
                        punto.Label = promedio.ToString("F3");
                    serie.Points.Add(punto);
                }

                if (serie.Points.Count > 0)
                    chart.Series.Add(serie);
                serieIndex++;
            }

            // Etiquetas del eje X
            area.AxisX.CustomLabels.Clear();
            for (int t = 0; t < tiposDatos.Length; t++)
            {
                if (tipoSeleccionado != "Todos" && tipoSeleccionado != tiposDatos[t])
                    continue;
                int idx = t;
                CustomLabel cl = new CustomLabel();
                cl.FromPosition = idx - 0.4;
                cl.ToPosition = idx + 0.4;
                cl.Text = nombresTiposCortos[t];
                cl.LabelMark = LabelMarkStyle.None;
                area.AxisX.CustomLabels.Add(cl);
            }
            area.AxisX.LabelStyle.Enabled = false;

            chart.ChartAreas[0].RecalculateAxesScale();

            // Llenar tabla comparativa
            LlenarDataGridViewComparativo(algoritmoSeleccionado, tipoSeleccionado, tamanoSeleccionado);

            tabControlPrincipal.SelectedTab = tabPageGraficos;
        }

        private void LlenarDataGridViewComparativo(string algoritmo, string tipoSeleccionado, string tamanoSeleccionado)
        {
            dataGridViewComparativo.Columns.Clear();
            dataGridViewComparativo.Columns.Add("Tamano", "Tamaño");
            dataGridViewComparativo.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewComparativo.Columns[0].DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            string[] tiposAMostrar;
            if (tipoSeleccionado == "Todos")
                tiposAMostrar = tiposDatos;
            else
                tiposAMostrar = new[] { tipoSeleccionado };

            string[] nombresCortos = { "Aleatorio", "Tend. asc.", "Descendente", "Alta rep." };
            foreach (string t in tiposAMostrar)
            {
                string corto = t == "Tendencia ascendente" ? "Tend. asc." :
                               t == "Alta repeticion" ? "Alta rep." : t;
                dataGridViewComparativo.Columns.Add(t, corto + " (ms)");
                dataGridViewComparativo.Columns[dataGridViewComparativo.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            int[] tamanos = { 100, 1000, 5000, 10000 };
            foreach (int tam in tamanos)
            {
                if (tamanoSeleccionado != "Todos" && tam != int.Parse(tamanoSeleccionado))
                    continue;

                DataGridViewRow row = new DataGridViewRow();
                row.Cells.Add(new DataGridViewTextBoxCell() { Value = tam.ToString("N0") });
                foreach (string t in tiposAMostrar)
                {
                    var datos = listaEstadisticas
                        .Where(item => item.Algoritmo == algoritmo
                                    && item.TipoDatos == t
                                    && item.Tamano == tam)
                        .ToList();
                    double promedio = datos.Count > 0 ? datos.Average(d => d.Promedio) : 0;
                    row.Cells.Add(new DataGridViewTextBoxCell() { Value = promedio.ToString("F4") });
                }
                dataGridViewComparativo.Rows.Add(row);
            }
        }

        // ============================================================
        // BOTON: EXPORTAR A PDF (simulado - guarda como texto)
        // ============================================================

        // ============================================================
        // DIBUJO PERSONALIZADO DE PESTAÑAS
        // ============================================================

        private void SetButtonHover(Button btn, System.Drawing.Color hoverColor)
        {
            btn.FlatAppearance.MouseOverBackColor = hoverColor;
            btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(30, 30, 30);
        }

        private void tabControlPrincipal_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabControl tab = (TabControl)sender;
            TabPage page = tab.TabPages[e.Index];
            Rectangle r = e.Bounds;

            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddRectangle(r);
            System.Drawing.Drawing2D.PathGradientBrush brush = new System.Drawing.Drawing2D.PathGradientBrush(path);

            if (e.State == DrawItemState.Selected)
            {
                brush.CenterColor = System.Drawing.Color.FromArgb(44, 62, 80);
                brush.SurroundColors = new System.Drawing.Color[] { System.Drawing.Color.FromArgb(52, 73, 94) };
                e.Graphics.FillRectangle(brush, r);

                using (System.Drawing.Pen borderPen = new System.Drawing.Pen(System.Drawing.Color.FromArgb(52, 152, 219), 2))
                {
                    e.Graphics.DrawLine(borderPen, r.Left, r.Bottom - 2, r.Right, r.Bottom - 2);
                }

                TextRenderer.DrawText(e.Graphics, page.Text, new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold),
                    r, System.Drawing.Color.White, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            }
            else
            {
                brush.CenterColor = System.Drawing.Color.FromArgb(220, 222, 225);
                brush.SurroundColors = new System.Drawing.Color[] { System.Drawing.Color.FromArgb(200, 202, 205) };
                e.Graphics.FillRectangle(brush, r);

                TextRenderer.DrawText(e.Graphics, page.Text, new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular),
                    r, System.Drawing.Color.FromArgb(80, 80, 80), TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            }

            brush.Dispose();
            path.Dispose();
        }

        private void buttonExportarPDF_Click(object sender, EventArgs e)
        {
            if (listaMetricas.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.",
                    "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Archivo de texto (*.txt)|*.txt";
            sfd.FileName = "Resultados_Ordenamiento.txt";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    System.Text.StringBuilder sb = new System.Text.StringBuilder();
                    sb.AppendLine("============================================================");
                    sb.AppendLine("  TALLER FINAL - MATEMATICAS DISCRETAS - UPTC");
                    sb.AppendLine("  Verificacion, Validacion y Analisis Experimental");
                    sb.AppendLine("  de Algoritmos de Ordenamiento en C#");
                    sb.AppendLine("============================================================");
                    sb.AppendLine();
                    sb.AppendLine("Rango de valores: [" + numericUpDownMin.Value + ", " + numericUpDownMax.Value + "]");
                    sb.AppendLine("Total de ejecuciones: " + totalPruebas);
                    sb.AppendLine();
                    sb.AppendLine("--- METRICAS DETALLADAS ---");
                    sb.AppendLine();
                    sb.AppendLine(string.Format("{0,-8} {1,-10} {2,-20} {3,-20} {4,-12} {5,-12} {6,-15} {7,-15} {8,-15} {9,-15}",
                        "Tamano", "Iter", "Algoritmo", "TipoDatos", "Ticks", "Ms", "Comparaciones", "Intercambios", "Asignaciones", "Recursivas"));
                    sb.AppendLine(new string('-', 150));

                    foreach (var m in listaMetricas)
                    {
                        sb.AppendLine(string.Format("{0,-8} {1,-10} {2,-20} {3,-20} {4,-12} {5,-12:F4} {6,-15} {7,-15} {8,-15} {9,-15}",
                            m.Tamano, m.Iteracion, m.Algoritmo, m.TipoDatos, m.Ticks, m.Milisegundos,
                            m.Comparaciones, m.Intercambios, m.Asignaciones, m.LlamadasRecursivas));
                    }

                    sb.AppendLine();
                    sb.AppendLine("--- ESTADISTICAS CONSOLIDADAS ---");
                    sb.AppendLine();
                    sb.AppendLine(string.Format("{0,-8} {1,-20} {2,-20} {3,-15} {4,-15} {5,-15}",
                        "Tamano", "Algoritmo", "TipoDatos", "Min (ms)", "Max (ms)", "Promedio (ms)"));
                    sb.AppendLine(new string('-', 100));

                    foreach (var est in listaEstadisticas)
                    {
                        sb.AppendLine(string.Format("{0,-8} {1,-20} {2,-20} {3,-15:F4} {4,-15:F4} {5,-15:F4}",
                            est.Tamano, est.Algoritmo, est.TipoDatos, est.Minimo, est.Maximo, est.Promedio));
                    }

                    sb.AppendLine();
                    sb.AppendLine("--- CONCLUSIONES ---");
                    sb.AppendLine(textBoxConclusiones.Text);

                    System.IO.File.WriteAllText(sfd.FileName, sb.ToString());
                    MessageBox.Show("Archivo exportado exitosamente.", "Exportación completa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al exportar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ============================================================
        // FILTROS Y TABLA DE COMPARACION POR TIPO DE DATO
        // ============================================================

        private void ConfigurarDataGridViewComparacion()
        {
            dataGridViewComparacion.Columns.Clear();
            dataGridViewComparacion.Columns.Add("Algoritmo", "Algoritmo");

            foreach (int tam in tamanos)
            {
                dataGridViewComparacion.Columns.Add("n" + tam, "n=" + tam);
            }

            dataGridViewComparacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewComparacion.Rows.Clear();
        }

        private void buttonFiltroCompAplicar_Click(object sender, EventArgs e)
        {
            if (listaEstadisticas.Count == 0)
            {
                MessageBox.Show("No hay datos estadisticos. Genere las estadisticas primero.",
                    "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tipoFiltro = comboBoxFiltroCompTipo.SelectedItem?.ToString();
            string algoFiltro = comboBoxFiltroCompAlgoritmo.SelectedItem?.ToString();

            var query = listaEstadisticas.AsEnumerable();

            if (tipoFiltro != null && tipoFiltro != "Todos")
                query = query.Where(x => x.TipoDatos == tipoFiltro);

            if (algoFiltro != null && algoFiltro != "Todos")
                query = query.Where(x => x.Algoritmo == algoFiltro);

            var agrupado = query.GroupBy(x => x.Algoritmo).ToList();

            dataGridViewComparacion.Rows.Clear();

            var ordenAlgoritmos = algoFiltro == "Todos" ? nombresAlgoritmos : new[] { algoFiltro };

            foreach (string algo in ordenAlgoritmos)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridViewComparacion);
                row.Cells[0].Value = algo;

                for (int i = 0; i < tamanos.Length; i++)
                {
                    int tam = tamanos[i];
                    var est = agrupado.FirstOrDefault(g => g.Key == algo)?
                        .FirstOrDefault(x => x.Tamano == tam);
                    row.Cells[i + 1].Value = est.HasValue ? est.Value.Promedio.ToString("F4") : "-";
                }

                dataGridViewComparacion.Rows.Add(row);
            }

            // Controlar visibilidad de los 4 charts segun el filtro de tipo de datos
            string tipo = comboBoxFiltroCompTipo.SelectedItem?.ToString() ?? "Todos";
            chartCompAleatorio.Visible = (tipo == "Todos" || tipo == "Aleatorio");
            chartCompAscendente.Visible = (tipo == "Todos" || tipo == "Tendencia ascendente");
            chartCompDescendente.Visible = (tipo == "Todos" || tipo == "Descendente");
            chartCompRepeticion.Visible = (tipo == "Todos" || tipo == "Alta repeticion");
        }
    }
}