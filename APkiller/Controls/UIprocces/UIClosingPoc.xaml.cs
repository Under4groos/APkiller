using Microsoft.Win32;
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
    /// Логика взаимодействия для UIClosingPoc.xaml
    /// </summary>
    public partial class UIClosingPoc : UserControl
    {
        readonly TimerTick timerTick = new TimerTick();
        bool IsSuspend
        {
            get; set;
        } = false;
        public UIClosingPoc()
        {
            InitializeComponent();
            timerTick.Tick += TimerTick_Tick;
            
        }

        private void TimerTick_Tick(object sender, EventArgs e)
        {
            foreach (Process item in Process.GetProcesses())
            {
                foreach (string item2 in ListPorcceses.list_P.porc)
                {
                    if (item.ProcessName == item2)
                    {
                        item.Suspend();
                        Kernel32Lib.Suspend(item);
                    }
                }

            }
        }

        public void Update()
        {
            ListPBox.Items.Clear();

            for (int i = 0; i < ListPorcceses.list_P.porc.Count; i++)
            {
                string item_1 = ListPorcceses.list_P.porc[i];
                string item_2 = ListPorcceses.list_P.porc_path[i];
                UIline l = new UIline()
                {

                    Text = item_1,
                    Id = -1,
                    Fullpath = item_2,
                    Mode = true

                };
                ListPBox.Items.Add(l);
                ListPBox.Items.Add(new Border() { Height = 5, Visibility = Visibility.Hidden });
            }
        }

        private void Label_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Update();
        }

        private void LabelClosing_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            IsSuspend = !IsSuspend;
            LabelClosing.Content = $"Suspend {IsSuspend}";
            if (IsSuspend)
            {
                LabelClosing.Foreground = Brushes.Green;
                timerTick.Start();
            }
            else
            {
                LabelClosing.Foreground = Brushes.White;
                timerTick.Stop();
            }
            
        }

        private void Grid_Drop(object sender, DragEventArgs e)
        {
           
            
        }

        private void LabelSaving_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog(); 
            saveFileDialog1.Title = "Save"; 
            DateTime dateTime = DateTime.Today; 
            
            saveFileDialog1.FileName = $"Data_{dateTime.Day}_{dateTime.Hour}_{dateTime.Minute}_{dateTime.Second}.xml"; 

            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "Data (*.xml)|*.xml";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == true)
            {
                
                XMLObject xMLObject = new XMLObject();
                xMLObject.Pith = saveFileDialog1.FileName;
                xMLObject.SerializeToXml(ListPorcceses.list_P);
            }


            
        }

        private void LabelOpen_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Data (*.xml)|*.xml";
            if (openFileDialog1.ShowDialog() == true)
            {
           
                XMLObject xMLObject = new XMLObject();
                ListPorcceses.list_P = xMLObject.DeserializeToObject(openFileDialog1.FileName);
                Update();

            }



        }
    }
}
