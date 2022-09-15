using System;

namespace GarbageCollDemo
{
    class TestClass
    {
        static int numOfInstances = 0;
        public TestClass()
        {
            numOfInstances++;
        }
        ~TestClass()
        {
            numOfInstances--;
        }
        public int getNumOfInstances()
        {
            return numOfInstances;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0;
            while (true)
            {
                TestClass tc = new TestClass();
                if (max < tc.getNumOfInstances())
                    max = tc.getNumOfInstances();
                else
                    break;
                Console.WriteLine(tc.getNumOfInstances());
            }
            Console.WriteLine("Max példányszám: "+max);
            Console.ReadLine();
        }
    }
}
