using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualZoo
{
    public class Exhibit
    {
        private string name;
        private Animal[] animals;

        public Exhibit ()
        {
            ExhibitName = "Generic Exhibit";

        }
        public Exhibit (string name)
        {
            ExhibitName = name;
        }
        public Exhibit (string name, Animal[] Animals)
        {
            ExhibitName = name;

        }
        
        public string ExhibitName
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
        public Animal[] ExhibitAnimals
        {
            get
            {
                return animals;
            }
            set
            {
                animals = value;
            }
        }
    }
}
