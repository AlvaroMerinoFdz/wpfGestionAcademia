using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace wpfGestiónAcademia
{
    /// <summary>
    /// Lógica de interacción para frmMain.xaml
    /// </summary>
    public partial class frmMain : Window
    {
        public frmMain()
        {
            InitializeComponent();
            CalcularTamaño();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;

        }

        /**
         * Método que calcular el tamaño de la pantalla y ajusta el tamaño de la ventana principal en consecuencia.
         * Se establece el ancho y alto de la ventana como un porcentaje del tamaño de la pantalla para asegurar que se adapte a diferentes resoluciones y tamaños de pantalla.
         */
        private void CalcularTamaño()
        {
            var screenWidth = SystemParameters.PrimaryScreenWidth;
            var screenHeight = SystemParameters.PrimaryScreenHeight;

            // Calculamos ancho (por ejemplo 80% de la pantalla)
            double ancho = screenWidth * 0.8;
            double alto = screenHeight * 0.8;

            this.Width = ancho;
            this.Height = alto; 
        }

        /**
         * Este método se encarga de manejar el evento de clic en el menú "Salir".
         * Muestra un cuadro de diálogo de confirmación para asegurarse de que el usuario desea cerrar la aplicación. 
         * Si el usuario confirma, la aplicación se cierra.
         */
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var resultado = MessageBox.Show(
                "¿Seguro que quieres salir?",
                "Confirmar",
                MessageBoxButton.YesNo,
                MessageBoxImage.Warning);

            if (resultado == MessageBoxResult.No)
            {
                e.Cancel = true; //No cierra la aplicación
            }
        }

        // Manejador para el evento Click del MenuItem definido en XAML (Click="Salir_Click")
        private void Salir_Click(object sender, RoutedEventArgs e)
        {
            // Interpreto que el menú "Salir" debe cerrar la ventana; esto disparará Window_Closing para confirmar.
            this.Close();
        }
        }
}
