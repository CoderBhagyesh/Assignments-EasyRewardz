using System.Collections;

namespace Collections_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Generic Collections
            List<int> list = new List<int>();
            // Adding items statically
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);
            //list.Add(5);

            // Adding items dynamically
            Console.WriteLine("Enter any 5 integers");
            for(int i = 0; i < 5; i++)
            {
                // Handling the Invalid input situation
                try 
                {
                    int n = Convert.ToInt32(Console.ReadLine());
                    list.Add(n); 
                } 
                catch(Exception e)
                { 
                    Console.WriteLine(e.ToString());
                }
            }

            // Iterating over the items
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // Removing the item using item name/value
            list.Remove(2); // 2 will be removed

            // Removing the item using item index
            list.RemoveAt(3); // 5 will be removed as index of 5 becomes 3 after execution of 24th line

            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
//////////////////////////////////////////////////////////////////////////////////////////////////////////
            
            // Non-Genric Collections
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add(2);
            arrayList.Add(3);
            arrayList.Add(4);
            arrayList.Add(5);

            foreach (int i in arrayList)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            arrayList.Remove(1); // Removes the given element

            arrayList.RemoveAt(3); // Removes the ele present on the given index

            foreach (int i in arrayList)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
