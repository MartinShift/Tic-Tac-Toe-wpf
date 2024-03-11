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

namespace Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int Times = 0;
        public int X = 0;
        public int Draw = 0;
        public int O = 0;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void CheckCombo()
        {
            if (b1.Content == b2.Content && b2.Content == b3.Content && b1.Content.ToString() != "" && b2.Content.ToString() != "" && b3.Content.ToString() != "")
            {
                _ = b1.Content.ToString() == "x" ? ++X : ++O;
                MessageBox.Show(b1.Content.ToString() == "x" ? "X won!" : "O won!", "Round Ended!", MessageBoxButton.OK, MessageBoxImage.Information);
                Room();
            }
            else if (b4.Content == b5.Content && b5.Content == b6.Content && b4.Content.ToString() != "" && b5.Content.ToString() != "" && b6.Content.ToString() != "")
            {
                _ = b4.Content.ToString() == "x" ? ++X : ++O;
                MessageBox.Show(b4.Content.ToString() == "x" ? "X won!" : "O won!", "Round Ended!", MessageBoxButton.OK, MessageBoxImage.Information);
                Room();
            }
            else if (b7.Content == b8.Content && b8.Content == b9.Content && b7.Content.ToString() != "" && b8.Content.ToString() != "" && b9.Content.ToString() != "")
            {
                _ = b7.Content.ToString() == "x" ? ++X : ++O;
                MessageBox.Show(b7.Content.ToString() == "x" ? "X won!" : "O won!", "Round Ended!", MessageBoxButton.OK, MessageBoxImage.Information);
                Room();
            }
            else if (b1.Content == b4.Content && b4.Content == b7.Content && b1.Content.ToString() != "" && b4.Content.ToString() != "" && b7.Content.ToString() != "")
            {
                _ = b1.Content.ToString() == "x" ? ++X : ++O;
                MessageBox.Show(b1.Content.ToString() == "x" ? "X won!" : "O won!", "Round Ended!", MessageBoxButton.OK, MessageBoxImage.Information);
                Room();
            }
            else if (b2.Content == b5.Content && b5.Content == b8.Content && b2.Content.ToString() != "" && b5.Content.ToString() != "" && b8.Content.ToString() != "")
            {
                _ = b2.Content.ToString() == "x" ? ++X : ++O;
                MessageBox.Show(b2.Content.ToString() == "x" ? "X won!" : "O won!", "Round Ended!", MessageBoxButton.OK, MessageBoxImage.Information);
                Room();
            }
            else if (b3.Content == b6.Content && b6.Content == b9.Content && b3.Content.ToString() != "" && b6.Content.ToString() != "" && b9.Content.ToString() != "")
            {
                _ = b3.Content.ToString() == "x" ? ++X : ++O;
                MessageBox.Show(b3.Content.ToString() == "x" ? "X won!" : "O won!", "Round Ended!", MessageBoxButton.OK, MessageBoxImage.Information);
                Room();
            }
            else if (b1.Content == b5.Content && b5.Content == b9.Content && b1.Content.ToString() != "" && b5.Content.ToString() != "" && b9.Content.ToString() != "")
            {
                _ = b1.Content.ToString() == "x" ? ++X : ++O;
                MessageBox.Show(b1.Content.ToString() == "x" ? "X won!" : "O won!", "Round Ended!", MessageBoxButton.OK, MessageBoxImage.Information);
                Room();
            }
            else if (b3.Content == b5.Content && b5.Content == b7.Content && b3.Content.ToString() != "" && b5.Content.ToString() != "" && b7.Content.ToString() != "")
            {
                _ = b3.Content.ToString() == "x" ? ++X : ++O;
                MessageBox.Show(b3.Content.ToString() == "x" ? "X won!" : "O won!", "Round Ended!", MessageBoxButton.OK, MessageBoxImage.Information);
                Room();
            }         
            else if (b1.Content.ToString() != "" && b2.Content.ToString() != "" && b3.Content.ToString() != "" && b4.Content.ToString() != "" && b5.Content.ToString() != "" && b6.Content.ToString() != "" && b7.Content.ToString() != "" && b8.Content.ToString() != "" && b9.Content.ToString() != "")
            {
                Draw++;
                MessageBox.Show("Draw", "Round Ended!", MessageBoxButton.OK, MessageBoxImage.Information);
                Room();
            }
        }
        private void Point(object sender, RoutedEventArgs e)
        {
            
            Button bt = sender as Button;
            if (bt.Content.ToString() == "")
            {
                Times++;            
                if (Times % 2 == 0)
                {
                    bt.Foreground = Brushes.Green;
                    bt.Content = "o";
                    bt.Foreground = Brushes.Green;
                }
                else
                {
                    bt.Foreground = Brushes.Red;
                    bt.Content = "x";
                    bt.Foreground = Brushes.Red;
                }
                CheckCombo();
                bt.IsEnabled= false;
                TurnLabel.Content = Times % 2 == 0 ? "X" : "O";
                TurnLabel.Foreground = Times % 2 == 0 ? Brushes.Red : Brushes.LightGreen;
            }
        }
        private void Room()
        {
            XLabel.Content = X.ToString();
            OLabel.Content = O.ToString();
            DrawLabel.Content = Draw.ToString();
            b1.Content = "";
            b2.Content = "";
            b3.Content = "";
            b4.Content = "";
            b5.Content = "";
            b6.Content = "";
            b7.Content = "";
            b8.Content = "";
            b9.Content = "";
            b1.Background = Brushes.LightGray;
            b2.Background = Brushes.LightGray;
            b3.Background = Brushes.LightGray;
            b4.Background = Brushes.LightGray;
            b5.Background = Brushes.LightGray;
            b6.Background = Brushes.LightGray;
            b7.Background = Brushes.LightGray;
            b8.Background = Brushes.LightGray;
            b9.Background = Brushes.LightGray;
            b1.IsEnabled = true;
            b2.IsEnabled = true;
            b3.IsEnabled = true;
            b4.IsEnabled = true;
            b5.IsEnabled = true;
            b6.IsEnabled = true;
            b7.IsEnabled = true;
            b8.IsEnabled = true;
            b9.IsEnabled = true;
        }
        private void Reset(object sender, RoutedEventArgs e)
        {
            var a = MessageBox.Show("Reset?", "Select", MessageBoxButton.YesNo, MessageBoxImage.Exclamation);
            if (a == MessageBoxResult.Yes)
            {
                X = 0;
                Draw = 0;
                O = 0;
                Times = 0;
                TurnLabel.Foreground = Brushes.Red;
                TurnLabel.Content = "X";
                Room();
            }
        }
    }
}
