using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lesson_12
{
    internal class Character
    {
        public string Name { get; set; }
        public int Energy { get; set; }

        public void _Init_(string name)
        {
            Name = name;
            Energy = 100;
        }

        public void Perform_action(string nameAction, int energy_cost)
        {
            Console.WriteLine(nameAction);
            Energy -= energy_cost;
            
        }

        public int Get_energy()
        {
            return Energy;
        }

        public override string ToString()
        {
            return Name + " " + Energy;
        }
    }
}
