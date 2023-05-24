using System;
using System.Collections;
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

        public void AddToDictionary(Dictionary<string, int> esimine, string key, int value)
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


            }
        }

        public void ShowLeaderboard10(Dictionary<string, int> esimine)
        {
            int i = 0;
            var sortedDictionary = esimine.OrderByDescending(x => x.Value);
            Console.SetCursorPosition(17, 19);
            Console.WriteLine("LEADERBORAD :");
            foreach (var item in sortedDictionary)
            {

                int length = item.Key.Length;
                string tochki = "";
                int howmuchtochki = 20 - length;
                for (int jj = 0; jj < howmuchtochki; jj++)
                {
                    tochki += ".";
                }
                i += 1;
                if (i < 11)
                {
                    Console.SetCursorPosition(10, 19+i);
                    Console.WriteLine(i + "." + item.Key + tochki + item.Value);
                }
                else
                {
                    Console.WriteLine("");
                    break;
                }
            }
        }
        public void ShowLeaderboard(Dictionary<string, int> esimine)
        {
            int i = 0;
            var sortedDictionary = esimine.OrderByDescending(x => x.Value);
            Console.SetCursorPosition(15, 3);
            Console.WriteLine("FULL LEADERBORAD :");
            foreach (var item in sortedDictionary)
            {
                i++;
                int length = item.Key.Length;
                string tochki = "";
                int howmuchtochki = 20 - length;
                for (int jj = 0; jj < howmuchtochki; jj++)
                {
                    tochki += ".";
                }
                Console.SetCursorPosition(10, 3+i);
                Console.WriteLine(i + "." + item.Key + tochki + item.Value);
            }
        }

        public void ShowPointsOnDisplay(int key, int value)
        {
            Console.SetCursorPosition(0, 0);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Points = {0}   Speed={1} ", key, value);
        }

        public string NicknameCreation()
        {
            try
            {
                Console.WriteLine("Write Nickname");
                string nickname = Console.ReadLine();

                if (nickname.Length < 20)
                {
                    return nickname;
                }
                else
                {
                    throw new Exception("More than 20 letters");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("You ncikname is Anonim");
                string nickname;
                nickname = "anonioim";
                return nickname; 
            }
        }
    } }

    

    
