using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace APkiller.Controls.UIprocces
{
    /// <summary>
    /// Логика взаимодействия для UIline.xaml
    /// </summary>
    public partial class UIline : UserControl
    {
        public UIline()
        {
            InitializeComponent();
        }
        public string Text
        {
            get;set;
        }
        public bool Mode
        {
            get; set;
        } = false;


        public int Id
        {
            get;set;
        }
        public string Fullpath
        {
            get;set;
        }
        private void Main(object sender, RoutedEventArgs e)
        {
            TextLabel.Content = Text;
            TextLabel_id.Content = Id.ToString() ?? "NULL";
            TextLabel_path.Content = Fullpath ?? "NULL";
            if (Mode)
            {
                TextLabel_id.Height = 0;
                TextLabel_id.Visibility = Visibility.Collapsed;
            }
        }

        private void Border_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (TextLabel_path.Content.ToString() == "NULL")
                return;
            string path = System.IO.Path.GetDirectoryName(TextLabel_path.Content.ToString());
            Process.Start(path);
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (Mode)
            {
                ListPorcceses.Remoove(TextLabel.Content.ToString());
                ControlsLib.ClosingProcPanel.Update();
            }
            else
            {
                ListPorcceses.Add(TextLabel.Content.ToString() , TextLabel_path.Content.ToString());
                ControlsLib.ClosingProcPanel.Update();


            }
            
        }
    }
}
