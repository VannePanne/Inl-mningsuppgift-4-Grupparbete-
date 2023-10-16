using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift_4__Grupparbete_
{
    public class Food
    {
        public string FilePath = @"Matbok.txt";

        public List<Food> foodList;
        public string Name;
        public string Description;

        public Food(string Name, string Description)
        {
            this.Name = Name;
            this.Description = Description;
        }


        // Methods
        public void AddFood()
        {
            using (StreamWriter writer = new StreamWriter(FilePath, true))
            {
                writer.WriteLine($"{txtName.Text},{txtDescription.Text}");
            }
            
            // Create a new Food object and add it to the list
            Food newFood = new Food(txtName.Text, txtDescription.Text);
            foodList.Add(newFood);
            
            
            //foodList.Add(new Food { });
        }
    }
    public class Meat : Food
    {
        // Maybe could make an override method on AddFood()
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
    public class Desert : Food
    {

    }
}
