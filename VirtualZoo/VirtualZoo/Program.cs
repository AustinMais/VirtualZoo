using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualZoo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            
            Animal Mammal1 = new Animal("Mammal1", Animal.Classification.Mammal);
            Animal[] animals = new Animal[] { Mammal1 };
            Exhibit Exhibit1 = new Exhibit("Exhibit1", animals);
            Exhibit[] exhibits = new Exhibit[] { Exhibit1 };
            VirtualZoo Zoo1 = new VirtualZoo("Zoo1", exhibits);

            MessageBox.Show(Zoo1.ZooName);
            MessageBox.Show(Exhibit1.ExhibitName);
            MessageBox.Show(Mammal1.AnimalName);
            Mammal1.AnimalNoise = "Growl";
            Mammal1.speak();
        }
    }
}
