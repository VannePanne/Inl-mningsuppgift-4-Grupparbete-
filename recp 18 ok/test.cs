using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace recp_18_ok
{
    public class test
    {
        public static string FilePath { get; set; } = @"recipe.txt"; // skapa sökväg här
        public string Titel { get; set; }
        public string Katagory { get; set; }
        public string Portion { get; set; }
        public string Ingredienser { get; set;}
        public string  Hur { get; set; }

        public void Add(string Titel,string Katagory, string Portion, string  Ingredienser , string Hur)
        {
            using (StreamWriter writer = new StreamWriter(FilePath, true))
            {
                writer.WriteLine($"{Titel}#{Katagory}#{Portion}#{Ingredienser}#{Hur}");
            }
        }
        public List<test> showData()
        {
            if (!File.Exists(FilePath))
            { 
                File.Create(FilePath).Close();
            }

            List<test> receptbok = new List<test>();
            using (StreamReader reader = new StreamReader(FilePath))
            {
                string fileContent = reader.ReadToEnd();
                string[] records = fileContent.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

                foreach ( string record in records)
                {
                    string[] receptinfo = record.Split('#');

                    if (receptinfo.Length >= 5)
                    {
                        test nyreceptbook = new test
                        {
                            Titel = receptinfo[0],
                            Katagory = receptinfo[1],
                            Portion = receptinfo[2],
                            Ingredienser = receptinfo[3],
                            Hur = receptinfo[4],
                            
                        };

                        receptbok.Add(nyreceptbook);
                    }
                }
               
            }
            return receptbok;

        }
        public void Delete(string receptToDelete)
        {
            List<test> receptbook = showData();
            var deleterecept = receptbook.Where(recept => recept.Titel == receptToDelete).ToList();

            if (deleterecept != null)
            {
                // Remove all entries with the specified name
                receptbook.RemoveAll(recept => recept.Titel == receptToDelete);

                // Update the text file with the new list
                using (StreamWriter writer = new StreamWriter(FilePath))
                {
                    foreach (var recept in receptbook)
                    {
                        writer.WriteLine($"{recept.Titel}#{recept.Katagory}#{recept.Portion}#{recept.Ingredienser}#{recept.Hur}");
                    }
                }
            }
        }



    }
}
