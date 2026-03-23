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
        /**
         * 
         */
        public frmMain()
        {
            InitializeComponent();
            CalcularTamaño();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;

        }
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
         * Este método se encarga de manejar el evento de clic en el menú "Salir". Muestra un cuadro de diálogo de confirmación para asegurarse de que el usuario desea cerrar la aplicación. Si el usuario confirma, la aplicación se cierra; de lo contrario, se muestra un mensaje de continuación.
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
    }
}
