using ScoolEF;
using System;

namespace SchoolEF
{
    class Program
    {
        static void Main()
        {
            // Database accessor. This opens the database automatically
            var school = new SchoolEntities();

            // This accesses the ClassMaster table
            foreach (var classMaster in school.ClassMasters)
            {
                Console.WriteLine("ClassId: {0}\nClassName: {1}\nClassDescription: {2}\nClassPrice: {3}\n",
                    classMaster.ClassId, classMaster.ClassName, classMaster.ClassDescription, classMaster.ClassPrice);
            }

            Console.Write("Done.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            // Exercise
            foreach (var user in school.Users)
            {
                Console.WriteLine("{0}", user.UserName);

                // Display classes for the current student
                foreach (var classMaster in user.ClassMasters)
                {
                    Console.WriteLine("\tClassId: {0} ClassName: {1}",
                        classMaster.ClassId, classMaster.ClassName);
                }

                Console.WriteLine();
            }

            Console.Write("Done.");
            Console.ReadLine();
        }
    }
}
