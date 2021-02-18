using System;

namespace static_field_and_constructor
{

    class Test
    {
        int _testField;
        static int sumCont;

        public Test(int value)
        {
            _testField = value;
        }

        public void sumMethod()
        {
            Console.WriteLine(sumCont = sumCont  + _testField);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Test t1 = new Test(5);
            Test t2 = new Test(5);

            t1.sumMethod();
            t2.sumMethod();
        }
    }
}
