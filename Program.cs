using System;
namespace IteratorDesignPattern
{
    public class Program
    {
        static void Main()
        {
            // Build a collection
            ConcreteCollection collection = new ConcreteCollection();

            collection.AddStudent(new Student(100,"Rafik"));
            collection.AddStudent(new Student(101,"Youcef"));
            collection.AddStudent(new Student(102,"Abdelillah"));
            collection.AddStudent(new Student(103,"Mohammed"));
            collection.AddStudent(new Student(104,"Ali"));
            collection.AddStudent(new Student(105,"Farid"));

            // Create iterator
            Iterator iterator = collection.CreateIterator();

            //looping iterator      
            Console.WriteLine("Iterating over collection:");

            for (Student emp = iterator.First(); !iterator.IsCompleted(); emp = iterator.Next())
            {
                Console.WriteLine($"ID : {emp.Id} & Name : {emp.Name}");
            }
            Console.Read();
        }
    }
}