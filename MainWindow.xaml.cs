using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tema2_AdivinarNumero
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int targetNumber;
        public MainWindow()
        {
            InitializeComponent();
            ResetGame();
        }
        private void ResetGame()
        {
            
            Random random = new Random();
            targetNumber = random.Next(101);
            guessTextBox.Text = string.Empty;
        }

        private void CheckButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                
                int userGuess = int.Parse(guessTextBox.Text);

                if (userGuess == targetNumber)
                {
                    MessageBox.Show("¡Has acertado!", "¡Felicidades!", MessageBoxButton.OK, MessageBoxImage.Information);
                    ResetGame();
                }
                else if (userGuess < targetNumber)
                {
                    MessageBox.Show("Te has quedado corto. ¡Inténtalo de nuevo!", "Número Incorrecto", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }
                else
                {
                    MessageBox.Show("Te has pasado. ¡Inténtalo de nuevo!", "Número Incorrecto", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa un número válido.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            ResetGame();
        }
    }
}
