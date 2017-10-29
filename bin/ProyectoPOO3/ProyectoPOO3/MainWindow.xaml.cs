using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace ProyectoPOO3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<int> pisos = new List<int>();
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


        }
        private void Datos_Click(object sender, RoutedEventArgs e)
        {
            HideBottons();
            PisosLabel.Visibility = Visibility.Visible;
            PisosText.Visibility = Visibility.Visible;
            EnterPisos.Visibility = Visibility.Visible;

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void EnterPisos_Click(object sender, RoutedEventArgs e)
        {
            if (Int32.TryParse(PisosText.Text, out int size))
            {
                EnterPisos.Visibility = Visibility.Hidden;
                EnterAreas.Visibility = Visibility.Visible;
                Cantidadpisos = size;
                PisosLabel.Content = "Area";
                PisosText.Clear();
            }
            else
            {
                MessageBox.Show("No ingreso un valor valido");
            }
        }
        private void VerificarPisos()
        {
            if (Int32.TryParse(PisosText.Text, out int size))
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
            if (cantidadtiendasusadas>= cantidadtiendaspiso)
            {
                HideBottons();
                PisosLabel.Content = "Cantidad de tiendas\n siguiente piso";
                PisosLabel.Visibility = Visibility.Visible;
                PisosText.Visibility = Visibility.Visible;
                EnterTiendas.Visibility = Visibility.Visible;
                cantidadtiendasusadas = 0;
                pisoactual += 1;
                if (pisoactual>cantidadpisos)
                {
                    HideBottons();
                }
            }
        }
        private void IngresarTiendas()
        {
            if (Int32.TryParse(PisosText.Text,out int j))
            {
                PisosText.Clear();
                if (simulacion.AllFloors[pisoactual-1].AreaOcupada + j < simulacion.AllFloors[pisoactual-1].Area)
                {
                    simulacion.CrearLocalesPorPiso(j,simulacion.AllFloors[pisoactual-1]);
                    cantidadtiendasusadas += 1;

                }
                else
                {
                    MessageBox.Show("Supera el area maxima del piso");
                }
            }
            else
            {
                MessageBox.Show("No ingreso un numero");
            }
        }
    }
}
