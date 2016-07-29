using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualZoo
{
    public class VirtualZoo
    {
        private string name;
        private Exhibit[] exhibits;

        public VirtualZoo(string name)
        {
            ZooName = name;
        }
        public VirtualZoo(string name, Exhibit[] exhibits)
        {
            ZooName = name;
            ZooExhibits = exhibits;
        }

        public string ZooName
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public Exhibit[] ZooExhibits
        {
            get
            {
                return exhibits;
            }
            set
            {
                exhibits = value;
            }
        }
    }
}
