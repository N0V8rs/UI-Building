using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HUD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float health;
            health = 100;
            float damage;
            damage = 100;
            int monsterdamage;
            monsterdamage = 75;


            Console.WriteLine("------------------------------");
            Console.WriteLine("Health: " + health);
            Console.WriteLine("------------------------------");
            Console.WriteLine("Damage: " + damage);
            Console.WriteLine();
            Console.WriteLine("Monster deals 75 damage");
            Console.WriteLine();
            health = health - monsterdamage;

            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine("Health: " + health);
            Console.WriteLine("------------------------------");
            Console.WriteLine("Damage: " + damage);


            Console.ReadKey();
        }
    }
}
