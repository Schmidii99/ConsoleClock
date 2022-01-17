using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClock
{
    class Program
    {
        private static int clock_size = 4;
        private static string time_format = "HH:mm:ss";
        private static string spaces = "    "; // Those are the spaces between the digits

        static void Main(string[] args)
        {
            string previous = DateTime.Now.ToString(time_format);

            while (true)
            {
                if (previous != DateTime.Now.ToString(time_format))
                {
                    previous = DateTime.Now.ToString(time_format);

                    Console.Clear();

                    draw(convert_time(DateTime.Now.ToString(time_format)));
                }
            }
        }

        private static void draw(List<List<List<int>>> data_array)
        {
            int counter = 0;
            foreach (List<int> line in data_array[0]) // For line
            {
                for (int y = 0; y < clock_size; y++) // von oben nach unten die Breite
                {
                    string string_to_print = ""; // can be a space or a # sign
                    for (int i = 0; i < data_array.Count; i++)
                    {
                        foreach (int data_byte in data_array[i][counter])
                        {
                            if (data_byte == 0)
                            {
                                string_to_print += new string(' ', clock_size);
                            }
                            else if (data_byte == 1)
                            {
                                string_to_print += new string('#', clock_size);
                            }
                            else
                            {
                                Console.WriteLine("xxxxxxxxxx\nBROKEN DATA or DATA MISSING\nxxxxxxxxxx");
                                return;
                            } 
                        }
                        string_to_print += spaces;
                    }
                    Console.WriteLine(string_to_print); // print whole line
                }
                counter++;
            }
        }

        private static List<List<List<int>>> convert_time(string time)
        {
            List<List<List<int>>> formatted_data = new List<List<List<int>>>();

            foreach (char c in time)
            {
                switch (c)
                {
                    case '0':
                        formatted_data.Add(Components.DIGIT_ZERO);
                        break;
                    case '1':
                        formatted_data.Add(Components.DIGIT_ONE);
                        break;
                    case '2':
                        formatted_data.Add(Components.DIGIT_TWO);
                        break;
                    case '3':
                        formatted_data.Add(Components.DIGIT_THREE);
                        break;
                    case '4':
                        formatted_data.Add(Components.DIGIT_FOUR);
                        break;
                    case '5':
                        formatted_data.Add(Components.DIGIT_FIVE);
                        break;
                    case '6':
                        formatted_data.Add(Components.DIGIT_SIX);
                        break;
                    case '7':
                        formatted_data.Add(Components.DIGIT_SEVEN);
                        break;
                    case '8':
                        formatted_data.Add(Components.DIGIT_EIGHT);
                        break;
                    case '9':
                        formatted_data.Add(Components.DIGIT_NINE);
                        break;
                    case ':':
                        formatted_data.Add(Components.SEMI_COLON);
                        break;
                    default:
                        Console.WriteLine("Something Went Wrong!");
                        return formatted_data;
                }
            }
            return formatted_data;
        }
    }
}
