using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeerOefeningenClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //Oefening Pokemon
            Random random = new Random();
            Pokemon bulbasaur = new Pokemon(50,40,40,55,55,20,1,"Bulbasaur","Grass");
            Pokemon pickachu = new Pokemon(30, 40, 40, 55, 59, 40, 35, "Pickachu", "Electric");
            List<Pokemon> pokedex = new List<Pokemon>();
            pokedex.Add(Maakpokemon(random));
            //bulbasaur.ShowInfo();
            //pickachu.ShowInfo();
            pokedex.Add(Maakpokemon(random));
           
            Pokemon pokemon = null;
            Console.WriteLine(BattleTester(pickachu, bulbasaur));
            
            //Oefening Meetlat
            
            Meetlat meetlat = new Meetlat(2);
            
            meetlat.ShowMeetlat();
            Console.ReadLine();
        }       
        static Pokemon Maakpokemon(Random random) 
        {
            int tempstat1 = random.Next(1, 20);
            int tempstat2 = random.Next(1, 20);
            int tempstat3 = random.Next(1, 20);
            int tempstat4 = random.Next(1, 20);
            int tempstat5 = random.Next(1, 20);
            int tempstat6 = random.Next(1, 20);
            Pokemon pokemon = new Pokemon(tempstat1, tempstat2, tempstat3, tempstat4, tempstat5, tempstat6, 404, "RandomGen", "???");
            return pokemon;
        }
        static int BattleTester(Pokemon pokemon1,Pokemon pokemon2) 
        {
            if (pokemon2 == null && pokemon1 == null)
            {
                return 0;
            }
            else if (pokemon2 == null)
            {
                return 1;
            }
            else if (pokemon1 == null)
            {
                return 2;
            }

            if (pokemon1.Average() > pokemon2.Average())
            {
                return 1;
            }
            else if (pokemon1.Average() == pokemon2.Average())
            {
                return 0;
            }
            else
            {
                return 2;
            }

        }

    }
}
