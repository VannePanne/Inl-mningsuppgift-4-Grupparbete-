using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RECEPT4DUMMIES
{
    public class Recept

    {
        public static string file { get; set; } = @"Recept.txt";
        public string titel {  get; set; }
        public string categori { get; set; }
        public string ingredienser { get; set; } 
        public string description { get; set; }

        public void Save(string titel, string categori, string ingredients, string description)
           
        {
            using (StreamWriter writer= new StreamWriter(file,true)) 
            {
                writer.WriteLine ($"{titel}/ {categori}/ {ingredients}/ {description}");
            }
        }
        
    }

}
