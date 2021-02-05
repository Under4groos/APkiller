using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APkiller.Controls.UIprocces
{
    public static class ListPorcceses
    {
        public static List_p list_P = new List_p();

        public static void Add(string name , string path)
        {
            if (IsValid(name).Item1 == false)
            {
                list_P.porc.Add(name);
                list_P.porc_path.Add(path);
            }  
        }
        public static void Remoove(string name)
        {
            (bool, int) b = IsValid(name);

            if (b.Item1 == true)
            {
                list_P.porc.RemoveAt(b.Item2);
                list_P.porc_path.RemoveAt(b.Item2);
            }
        }

        public static (bool , int) IsValid(string name)
        {
            (bool , int) b = (false , -1);
            if (name == string.Empty || list_P.porc.Count <= 0)
                return b;

            int id = 0;
            foreach (string item in list_P.porc)
            {
                if (item.ToLower() == name.ToLower())
                {
                    b.Item1 = true;
                    b.Item2 = id;
                    break;
                }
                else
                {
                    b.Item1 = false;
                }

                id++;
            }

            return b;
        }
    }
}
