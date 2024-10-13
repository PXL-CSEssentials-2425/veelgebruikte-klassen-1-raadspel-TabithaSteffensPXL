using System.Security.Cryptography;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System;
using Microsoft.VisualBasic;

namespace h4_raadspel
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
       Random randomNumber = new Random();
   
        public MainWindow()
        {
            InitializeComponent();
        }
       
        private void closeButton_Click(object sender, RoutedEventArgs e)

        {
            this.Close();
        }
        int goalNumber;
        int numberGuesses = 0;
        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            goalNumber = randomNumber.Next(1, 101);
            int guessedNumber;
            do
            {
                int.TryParse(Interaction.InputBox("Raad een getal tussen 0 en 100!"), out guessedNumber);
                if (guessedNumber < goalNumber)
                {
                    MessageBoxResult showResult = MessageBox.Show("Raad hoger!", "Raad hoger!", MessageBoxButton.OK);
                    numberGuesses++;
                }
                else if (guessedNumber > goalNumber)
                {
                    MessageBoxResult showResult = MessageBox.Show("Raad lager!", "Raad lager!", MessageBoxButton.OK);
                    numberGuesses++;
                }
                else if (guessedNumber == goalNumber)
                {
                    numberGuesses++;
                    MessageBoxResult showResult = MessageBox.Show($"U hebt het getal geraden in {numberGuesses} beurten!", "Proficiat!", MessageBoxButton.OK);

                }
            } while (guessedNumber != goalNumber);
        }
    } 
}
