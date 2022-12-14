using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seterrachooser
{
    public class SeterraChooser
    {
        Random random = new Random();
        string[] categories = { "Pin", "Pin Hard", "Place Labels", "Multiple Choice", "Shownext" };        
        public void ChooseMaps()
        {          
            string[] smallMaps = File.ReadAllLines("../../../csv/smallMaps.csv");
            string[] mediumMaps = File.ReadAllLines("../../../csv/mediumMaps.csv");
            string[] largeMaps = File.ReadAllLines("../../../csv/largeMaps.csv");
            string[] hugeMaps = File.ReadAllLines("../../../csv/hugeMaps.csv");

            Console.WriteLine("----Small maps----");
            MapChooser(smallMaps, 3);
            Console.WriteLine("----Medium maps----");
            MapChooser(mediumMaps, 4);
            Console.WriteLine("----Large maps----");
            MapChooser(largeMaps, 4);
            Console.WriteLine("----Huge maps----");
            MapChooser(hugeMaps, 3);
        }
        public void MapChooser(string[] maps,int numberOfMapsToChoose)
        {
            string mapChoice, categoryChoice;
            List<string> chosenMaps = new List<string>();
            List<string> chosenCategories = new List<string>();
            for (int i = 0; i < numberOfMapsToChoose; i++)
            {
                do
                {
                    mapChoice = maps[random.Next(0, maps.Length)];
                } while (chosenMaps.Contains(mapChoice));

                do
                {
                    categoryChoice = categories[CategoryChooser()];
                } while (chosenCategories.Contains(categoryChoice));

                chosenMaps.Add(mapChoice);
                chosenCategories.Add(categoryChoice);
                Console.WriteLine(mapChoice + " --- " + categoryChoice);
            }                                                                     
        }
        public int CategoryChooser()
        {
            int bigRandomNumber = random.Next(1, 101);
            if (bigRandomNumber <= 25)
            {
                return 0;
            }
            else if (bigRandomNumber <= 40)
            {
                return 1;
            }
            else if (bigRandomNumber <= 65)
            {
                return 2;
            }
            else if (bigRandomNumber <= 85)
            {
                return 3;
            }
            return 4;
        }
    }
}