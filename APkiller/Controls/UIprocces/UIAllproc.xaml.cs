using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Security.Principal;
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
    /// Логика взаимодействия для UIAllproc.xaml
    /// </summary>
    public partial class UIAllproc : UserControl
    {
        

        public UIAllproc()
        {
            InitializeComponent();

            

        }
        public static bool IsAdm()
        {
            bool isElevated;
            using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
            {
                WindowsPrincipal principal = new WindowsPrincipal(identity);
                isElevated = principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
            return isElevated;
        }

        private void Label_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ListPBox.Items.Clear();
            foreach (Process item in Process.GetProcesses())
            {

                string fui_path = Extensions.GetMainModuleFileName(item);
                string name_ = item.ProcessName;

                if (fui_path == "NULL")
                    continue;
                string[] ignoring = 
                    { "svchost", "system" , "Taskmgr" , 
                    "NVDisplay.Container" , "audiodg" , "csrss"


                };
                bool b = false;
                foreach (var n in ignoring)
                {
                    if (name_.ToLower() == n.ToLower())
                    {
                        b = true;
                        break;
                    }
                        
                }
                if(b)
                    continue;              
               
                UIline l = new UIline()
                {

                    Text = name_,
                    Id = item.Id,
                    Fullpath = fui_path
                };
                ListPBox.Items.Add(l);

                ListPBox.Items.Add(new Border() { Height = 5, Visibility = Visibility.Hidden });
            }
        }
    }
}
