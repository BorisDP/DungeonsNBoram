using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie
            String strName, strDesc;
            
            
            //Begroet de speler
            Console.Write("Gegroet speler, wie bent u? ");
            strName = Console.ReadLine();
            Console.WriteLine("Welkom " + strName + ", Beschrijf uzelf");
            strDesc = Console.ReadLine();


            //Definieer Personage
            AdventureFramework.Interaction.PlayableCharacter Player = new AdventureFramework.Interaction.PlayableCharacter(strName, strDesc);



            //TEST
            //Console.WriteLine(strName + " " + strDesc);
            //Console.ReadLine();


        }
    }
}
