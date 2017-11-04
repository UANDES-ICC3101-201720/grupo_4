using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Media;
using System.Windows.Controls;
using System.Threading;
using System.Data;

namespace ProyectoPOO3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<int> pisos = new List<int>();
        List<TextBox> textboxes = new List<TextBox>();
        int cantidadpisos = 0;
        int pisoactual = 1;
        int cantidadtiendaspiso = 0;
        int cantidadtiendasusadas = 0;
        Simular simulacion = new Simular();


        public int Pisoactual { get => pisoactual; set => pisoactual = value; }
        public int Cantidadpisos { get => cantidadpisos; set => cantidadpisos = value; }
        public int Cantidadtiendaspiso { get => cantidadtiendaspiso; set => cantidadtiendaspiso = value; }

        public MainWindow()
        {
            InitializeComponent();
        }
        private void HideBottons()
        {
            Panel.Visibility = Visibility.Hidden;
            Datos.Visibility = Visibility.Hidden;
            Boton.Visibility = Visibility.Hidden;
            Reportes.Visibility = Visibility.Hidden;
            Plano.Visibility = Visibility.Hidden;
            PisosLabel.Visibility = Visibility.Hidden;
            PisosText.Visibility = Visibility.Hidden;
            EnterPisos.Visibility = Visibility.Hidden;
            EnterAreas.Visibility = Visibility.Hidden;
            EnterTiendas.Visibility = Visibility.Hidden;
            EnterTiendasArea.Visibility = Visibility.Hidden;
            EnterMall.Visibility = Visibility.Hidden;


        }
        private void Datos_Click(object sender, RoutedEventArgs e)
        {
            HideBottons();
            PisosLabel.Visibility = Visibility.Visible;
            PisosText.Visibility = Visibility.Visible;
            EnterPisos.Visibility = Visibility.Visible;

        }

        private void TextBox_TextChanged(object sender, RoutedEventArgs e)
        {
            TextBox text = sender as TextBox;
            text.Clear();
        }

        private void EnterPisos_Click(object sender, RoutedEventArgs e)
        {
            if (Int32.TryParse(PisosText.Text, out int size))
            {
                EnterPisos.Visibility = Visibility.Hidden;
                EnterAreas.Visibility = Visibility.Visible;
                PisosText.Visibility = Visibility.Hidden;
                FillListBox(size, "Piso", 0);
                Panel.Visibility = Visibility.Visible;
                Cantidadpisos = size;
                PisosLabel.Content = "Areas";
                PisosText.Clear();
            }
            else
            {
                MessageBox.Show("No ingreso un valor valido");
            }
        }
        private void VerificarPisos()
        {
            foreach (TextBox text in textboxes)
            {
                if (Int32.TryParse(text.Text, out int size))
                {
                    if (pisos.Count() == 0)
                    {
                        pisos.Add(size);
                    }
                    if (pisos.Count() != 0)
                    {
                        if (pisos[pisos.Count() - 1] >= size)
                        {
                            pisos.Add(size);
                            PisosText.Clear();
                        }
                        else
                        {

                            MessageBox.Show("Este piso no puede ser mas grande que el anterior");
                        }
                    }

                }
                else
                {
                    MessageBox.Show("No ingreso un numero");
                }
            }

        }

        private void EnterArea_Click(object sender, RoutedEventArgs e)
        {
            VerificarPisos();
            if (pisos.Count() > Cantidadpisos)
            {
                HideBottons();
                PisosLabel.Content = "Cantidad de Tiendas";
                PisosText.Clear();
                PisosLabel.Visibility = Visibility.Visible;
                PisosText.Visibility = Visibility.Visible;
                EnterTiendas.Visibility = Visibility.Visible;
                simulacion.CrearPisos(Cantidadpisos, pisos);

            }

        }

        private void EnterTiendas_Click(object sender, RoutedEventArgs e)
        {
            if (Int32.TryParse(PisosText.Text, out int j))
            {
                PisosText.Clear();
                if (Pisoactual <= Cantidadpisos)
                {
                    cantidadtiendaspiso = j;
                    EnterTiendas.Visibility = Visibility.Hidden;
                    EnterTiendasArea.Visibility = Visibility.Visible;
                    PisosText.Visibility = Visibility.Hidden;
                    FillListBox(j, "Tienda", 0);
                    Panel.Visibility = Visibility.Visible;
                    PisosLabel.Content = "Area por tienda";
                }
            }
            else
            {
                MessageBox.Show("No ingreso un valor valido");
            }
        }

        private void EnterTiendasArea_Click(object sender, RoutedEventArgs e)
        {
            IngresarTiendas();
            if (cantidadtiendasusadas >= cantidadtiendaspiso)
            {
                HideBottons();
                PisosLabel.Content = "Cantidad de tiendas\n siguiente piso";
                PisosLabel.Visibility = Visibility.Visible;
                PisosText.Visibility = Visibility.Visible;
                EnterTiendas.Visibility = Visibility.Visible;
                cantidadtiendasusadas = 0;
                pisoactual += 1;
                if (pisoactual > cantidadpisos)
                {
                    HideBottons();
                    EnterMall.Visibility = Visibility.Visible;
                    PisosLabel.Content = "Ingrese las horas que funcionara el mall\ny el dinero inicial que tiene.";
                    FillListBox(0, "", 1);
                    Panel.Visibility = Visibility.Visible;
                    PisosLabel.Visibility = Visibility.Visible;

                }
            }
        }
        private void IngresarTiendas()
        {

            bool continuar = true;
            int areaocupadapiso = 0;
            foreach (TextBox text in textboxes)
            {
                if (Int32.TryParse(text.Text, out int j))
                {
                    areaocupadapiso += j;
                    if (areaocupadapiso <= simulacion.AllFloors[pisoactual - 1].Area)
                    {

                    }
                    else
                    {
                        MessageBox.Show("Supera el area maxima del piso");
                        continuar = false;
                    }
                }
                else
                {
                    MessageBox.Show("No ingreso un numero");
                    continuar = false;
                }
            }
            if (areaocupadapiso <= simulacion.AllFloors[pisoactual - 1].Area && continuar)
            {
                foreach (TextBox text in textboxes)
                {
                    simulacion.CrearLocalesPorPiso(Convert.ToInt32(text.Text), simulacion.AllFloors[pisoactual - 1]);
                    cantidadtiendasusadas += 1;
                }
            }
        }
        public void FillListBox(int cantidad, string tipo, int proceso)
        {
            if (proceso == 0)
            {
                int top_pos_panel_text = -20;
                int bottom_pos_panel_text = 0;
                int right_pos_panel_text = 0;
                int left_pos_panel_text = -300;
                textboxes.Clear();
                Panel.Children.Clear();
                int contador = 0;
                for (int i = 1; i <= cantidad; i++)
                {
                    TextBox textBox = new TextBox
                    {
                        Width = 70,
                        Text = tipo + " " + i,
                        Background = null,
                        BorderBrush = null,
                        Foreground = Brushes.White,
                        Margin = new Thickness(left_pos_panel_text, top_pos_panel_text, right_pos_panel_text, bottom_pos_panel_text),
                        HorizontalContentAlignment = HorizontalAlignment.Center,

                    };
                    textBox.GotFocus += TextBox_TextChanged;
                    textBox.Background = null;
                    textBox.BorderBrush = null;
                    textBox.Foreground = Brushes.White;
                    textboxes.Add(textBox);
                    Panel.Children.Add(textBox);
                    left_pos_panel_text += 150;
                    contador += 1;
                    if (top_pos_panel_text != -20)
                    {
                        top_pos_panel_text = -20;
                    }
                    if (contador == 5)
                    {
                        contador = 0;
                        left_pos_panel_text = -300;
                        top_pos_panel_text += 25;
                    }
                }
                left_pos_panel_text = -300;
            }
            if (proceso == 1)
            {
                int top_pos_panel_text = -20;
                int bottom_pos_panel_text = 0;
                int right_pos_panel_text = 0;
                int left_pos_panel_text = -200;
                textboxes.Clear();
                Panel.Children.Clear();
                string[] palabras = { "Dinero", "Mall" };
                for (int i = 0; i < 2; i++)
                {
                    TextBox textBox = new TextBox
                    {
                        Width = 70,
                        Text = palabras[i],
                        Background = null,
                        BorderBrush = null,
                        Foreground = Brushes.White,
                        Margin = new Thickness(left_pos_panel_text, top_pos_panel_text, right_pos_panel_text, bottom_pos_panel_text),
                        HorizontalContentAlignment = HorizontalAlignment.Center,

                    };
                    textBox.GotFocus += TextBox_TextChanged;
                    textBox.Background = null;
                    textBox.BorderBrush = null;
                    textBox.Foreground = Brushes.White;
                    textboxes.Add(textBox);
                    Panel.Children.Add(textBox);
                    left_pos_panel_text += 150;
                }
            }

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void EnterMall_Click(object sender, RoutedEventArgs e)
        {
            HideBottons();
            DiaLabel.Visibility = Visibility.Visible;
            IniciarMall();
        }

        public void IniciarMall()
        {
            int dinero = 0;
            int horas = 0;
            int contador = 0;
            bool valido = true;
            foreach (TextBox textBox in textboxes)
            {
                if (Int32.TryParse(textBox.Text, out int j))
                {
                    if (contador == 0)
                    {
                        dinero = j;
                        contador += 1;
                    }
                    else
                    {
                        horas = j;
                        contador -= 1;
                    }
                }
                else
                {
                    MessageBox.Show("No ingreso datos validos");
                    valido = false;
                }
            }
            if (valido)
            {
                simulacion.Mall = new Mall(simulacion.AllFloors.Count(), horas, dinero);
                Program(horas);
            }

        }
        public void Program(int horas)
        {
            HideBottons();
            for (int i = 1; i <= 10; i++)
            {
                simulacion.mall.AbrirMall(simulacion.AllStores);
                simulacion.Clientes.Clear();
                simulacion.CrearClientes(simulacion.PeopleNames, simulacion.AllStores, simulacion.AllFloors);
                simulacion.CrearTrabajadores(simulacion.PeopleNames, simulacion.AllStores);
                int minutos = horas * 60;
                int tiempogente = 0;
                for (int j = 0; j < minutos; j++)
                {
                    if (tiempogente == 4)
                    {
                        for (int k = 0; k < 9; k++)
                        {
                            Random random = new Random();
                            int cliente1 = random.Next(simulacion.Clientes.Count());
                            try
                            {
                                simulacion.Clientes[cliente1].EntrarMall(simulacion.Clientes[cliente1].Plan.Tiendas[0].Piso, simulacion.mall);
                                simulacion.Clientes[cliente1].RecorrerPlan(simulacion.Clientes[cliente1].Plan);
                                simulacion.Clientes.Remove(simulacion.Clientes[cliente1]);
                            }
                            catch (Exception)
                            {


                            }


                        }

                        tiempogente = 0;
                    }
                    tiempogente += 1;

                }
                simulacion.mall.CerrarMall(simulacion.AllStores);
                simulacion.DiaActual += 1;
                if (simulacion.DiaActual <= 10)
                {
                    DiaLabel.Content = "Dia " + simulacion.DiaActual;
                }
                simulacion.Reporte1(simulacion.Mall, i);
                simulacion.Reporte2(simulacion.Mall, i);
                simulacion.Reporte3(simulacion.AllStores, i);
                simulacion.Reporte4(simulacion.AllStores, i);
                simulacion.Reporte5(simulacion.AllStores);
                simulacion.Reporte6(simulacion.AllStores);
                simulacion.Reporte7(simulacion.AllStores, i);
                simulacion.Reporte8(simulacion.AllStores);
                simulacion.Mall.CerrarMall(simulacion.AllStores);
                simulacion.Reportes.Add(simulacion.reporte);
                MessageBox.Show(simulacion.reporte);
                simulacion.reporte = "";



            }
            Reportes.Visibility = Visibility.Visible;
            Datos.Visibility = Visibility.Visible;
            Plano.Visibility = Visibility.Visible;


        }

        private void Plano_Click(object sender, RoutedEventArgs e)
        {
            HideBottons();
            TiendasGrid.Visibility = Visibility.Visible;
            FillStoresGrid();
        }
        public void FillStoresGrid()
        {
            foreach (Tienda tienda in simulacion.AllStores)
            {
                TiendasGrid.Items.Add(tienda.Nombre + " " + tienda.GananciaEfectiva + " " + tienda.CantidadTrabajadores + " " + simulacion.AllStores.Count());

            }
        }

    }
}
