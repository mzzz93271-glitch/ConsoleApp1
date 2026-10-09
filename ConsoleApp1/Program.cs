using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataTable table = new DataTable("stydent");
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("name", typeof(string));
            table.Columns.Add("age", typeof(int));
            table.Columns.Add("groupName", typeof(string));

            table.Rows.Add(1, "даша", 20, "гений 1");
            table.Rows.Add(2, "маша", 30, "гений 1");
            table.Rows.Add(3, "даун", 15, "гений 1");
            table.Rows.Add(4, "саша", 67, "гений 1");
            table.Rows.Add(5, "леша", 23, "гений 1");
            foreach (DataRow row in table.Rows)

            {
                Console.WriteLine($"{row["id"]}:    {row["name"]},    {row["age"]},  {row["groupName"]}, ");
            }

            int maxAge = 0;

        
            foreach (DataRow row in table.Rows)
            {
                
                int currentAge = (int)row["age"];

               
                if (currentAge > maxAge)
                {
                    maxAge = currentAge;
                }
            }
            Console.WriteLine($"Самый большой возраст в группе: {maxAge}");

            Console.ReadLine();


        }
    }
}
