using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace uusmang
{
    public class Points
    {
        public Dictionary<string, int> Usersdict;
        public int PointsCounter(int Variable)
        {
            Variable++;
            return Variable;
        }
        public Points()
        {
            
            
        }

        public void AddToDictionary(Dictionary<string, int> esimine,string key, int value)
        {
            esimine[key] = value;
        }

        public Dictionary<string, int> ReadToFile(Dictionary<string, int> esimine)
        {
            using (StreamReader sr = new StreamReader(@"..\..\..\Userslist.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split('-');
                    string key = parts[0];
                    int value = int.Parse(parts[1]); 

                    esimine.Add(key, value);
                }

                return esimine;
            }
        }
        public void WriteToFile(Dictionary<string, int> esimine)
        {
            {
                using (StreamWriter file = new StreamWriter(@"..\..\..\Userslist.txt"))
                {
                    foreach (KeyValuePair<string, int> element in esimine)
                    {
                        file.WriteLine("{0}-{1}", element.Key, element.Value);
                    }
                }

                Console.WriteLine("Data saved to file.");
                Console.ReadLine();
            }
        }

        public void ShowLeaderboard(Dictionary<string, int> esimine)
        {
            var sesimine = from entry in esimine orderby entry.Value ascending select entry;
            for (int i = 0; i < 5; i++)
            {
                int max = 0;
                foreach (KeyValuePair<string, int> element in sesimine)
                {
                    int zizha = element.Value;
                    if (zizha > max)
                    {
                        max = element.Value;
                    }
                }
            }
            
            
        }
    }
}

    

    
