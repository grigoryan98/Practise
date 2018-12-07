using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            QueryOverString();
        }

        public static void QueryOverString()
        {
            string[] games = { "Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2" };

            // Build a Query expression to find the iteam in the array which contain spase
            IEnumerable<string> subset = from g in games
                                         where g.Contains(" ")
                                         orderby g
                                         select g;
            // second version 
            //IEnumerable<string> subset=games
            //.where(g=>g.Contains(" "))
            // .orderby(g=>g).select(g=>g)

            ReflectOverQueryResults(subset);

            //Print result
            foreach (string s in subset)
            {
                Console.WriteLine(s);
            }
        }

        //helper function which will print out varios details of the LINQ result set
        public static  void ReflectOverQueryResults(object resultSet, string queryType="Query Expressions")
        {
            Console.WriteLine($" * ****Info about your query using { queryType}");
            Console.WriteLine("resultSet is of type: {0}", resultSet.GetType().Name);
            Console.WriteLine("resultSet location: {0}", resultSet.GetType().Assembly.GetName().Name);
        }
    }
}
