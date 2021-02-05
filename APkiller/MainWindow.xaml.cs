using APkiller.Controls;
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

namespace APkiller
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private void Main(object sender, RoutedEventArgs e)
        {
            ControlsLib.add(ProcPanel);
            ControlsLib.add(ClosingProcPanel);
            ControlsLib.ClosingProcPanel = ClosingProcPanel;
        }
        public MainWindow() => InitializeComponent();




        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void Border_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            switch (this.WindowState)
            {
                case WindowState.Normal:
                    this.WindowState = WindowState.Maximized;
                    break;
                case WindowState.Minimized:
                    this.WindowState = WindowState.Normal;
                    break;
                case WindowState.Maximized:
                    this.WindowState = WindowState.Normal;
                    break;
                default:
                    break;
            }
        }

        private void Border_MouseLeftButtonDown_2(object sender, MouseButtonEventArgs e)
        {
            
            this.WindowState = WindowState.Minimized;
        }

        private void Label_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            
            ControlsLib.VisibilityUc(ProcPanel);
        }

        private void Label_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            
            ControlsLib.VisibilityUc(ClosingProcPanel);
        }

        private void window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
                this.DragMove();
        }

        
    }
}
