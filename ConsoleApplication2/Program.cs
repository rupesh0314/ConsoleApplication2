using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class views
    {
        static void Main(string[] args)
        {
            bool flag = true;
            bool flag1 = false;

            string input = System.IO.File.ReadAllText(@"C:\Users\rupeshreddyt\Desktop\input.txt");
            string query = "select * from ";
            string[] input1 = input.Split(' ');
            /* foreach (var item in input1)
             {
                 Console.WriteLine(item.ToString());
             }
             */

            using (SqlConnection conn = new SqlConnection())

            {
                conn.ConnectionString = "Server=DESKTOP-701J0KU;Database=AdventureWorks2014;Trusted_Connection=true;MultipleActiveResultSets=true";
                conn.Open();

                for (int i = 0; i <= input1.Length;)
                {


                    if (input1[i] == "FROM")
                    {
                        flag = false;
                        if (i <= input1.Length)
                        {
                            i++;
                        }
                    }
                    else if (!flag)
                    {
                        Console.Write("jshbjhs");

                        if (input1[i] == "LEFT" || input1[i] == "RIGHT" || input1[i] == "OUTER" || input1[i] == "INNER" || input1[i] == "JOIN" || input1[i] == "FULL")
                        {
                            
                            if (flag1 == false)
                            {
                                Console.Write("jshbjhs");
                                 Console.WriteLine(query);

                                // SqlCommand command = new SqlCommand(query);
                                flag1 = true;
                            }

                        }
                        else
                        {
                            flag1 = false;
                        }
                        query += input1[i];

                        query += " ";
                        if (i <= input1.Length)
                        {
                            i++;
                        }


                    }

                }

            }
        }
    }
}






