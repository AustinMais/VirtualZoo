using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualZoo
{
    public class Animal
    {
        private string name;
        private Classification classification;
        private string noise;

        public Animal(string name, Classification classification)
        {
            if (name.Length == 0)
            {
                MessageBox.Show("Blank names not allowed");
            }
            AnimalName = name;
            AnimalClassification = classification;
        }
        public string AnimalName
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
        public enum Classification { Mammal, Reptile, Amphibian, Bird, Fish }
        public Classification AnimalClassification
        {
            get
            {
                return classification;
            }
            set
            {
                classification = value;
            }
        }
        public string AnimalNoise
        {
            get
            {
                return noise;
            }
            set
            {
                noise = value;
            }
        }
        public void speak()
        {
            MessageBox.Show(noise);
        }

    }
}
