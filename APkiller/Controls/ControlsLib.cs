using APkiller.Controls.UIprocces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace APkiller.Controls
{
    static class ControlsLib
    {
        public static UIClosingPoc ClosingProcPanel;

        private static List<UserControl> userControls = new List<UserControl>()
        {};
        public static void add(UserControl uc) => userControls.Add(uc);

        public static void VisibilityUc(UserControl uc)
        {
            if (uc.Visibility == System.Windows.Visibility.Visible)
            {
                uc.Visibility = System.Windows.Visibility.Hidden;
                return;
            }
            foreach (UserControl item in userControls)
            {
                if (item == uc)
                {
                    uc.Visibility = System.Windows.Visibility.Visible;
                }
                else
                {
                    item.Visibility = System.Windows.Visibility.Hidden;
                }
                    
                
                
            }
            
        }

    }
}
