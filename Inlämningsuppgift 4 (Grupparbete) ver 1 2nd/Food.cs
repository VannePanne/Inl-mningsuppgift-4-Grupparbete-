using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Inlämningsuppgift_4__Grupparbete_
{
    public class Food
    {
        public string Name { get; set; }
        public string Recipe { get; set; }
        public string FoodType { get; set; }


        // Method that reads the textfile, stores all foods in a list and returns
        public static List<Food> LoadFoodsFromFile(string filePath) //Could change name from filePath to fileName // Could also change LoadFoodsFromFile to LoadFood
        {
            // Make a list that stores all foods. Since all sub classes has in common that they inherit from the "Food" class, it makes most sense that the list should be of the type Food.
            List<Food> foods = new List<Food>();  //could also change foods to foodList  

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] foodInfo = line.Split(',');
                    if (foodInfo.Length >= 3) // probably also could write (foodInfo.Lenght = 3)
                    {
                        string name = foodInfo[0];
                        string recipe = foodInfo[1];
                        string foodType = foodInfo[2];

                        // Create food type based on the foodType information we now got from the row in the textfile.
                        Food foodItem;
                        switch(foodType.ToLower())
                        {
                            case "meat":
                                foodItem = new Meat();
                                break;
                            case "fish":
                                foodItem = new Fish();
                                break;
                            case "salad":
                                foodItem = new Salad();
                                break;
                            case "dessert":
                                foodItem = new Dessert();
                                break;
                            default:
                                foodItem = new Food();
                                break;
                        }

                        foodItem.Name = name;
                        foodItem.Recipe = recipe;

                        foods.Add(foodItem);
                    }
                }
            }

            return foods;
        } 
    }
    public class Meat : Food
    {
        
    }
    public class Fish : Food
    {
        
    }
    public class Salad : Food
    {

    }
    public class Soup : Food
    {

    }
    public class Dessert : Food
    {

    }
}
