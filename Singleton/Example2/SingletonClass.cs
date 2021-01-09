using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.Second_Example
{
    public class SingletonClass
    {
        private SingletonClass()
        {
              // By making constructor private, let's prevent an instance from being taken from outside this class.
        }

        private static SingletonClass _object = new SingletonClass();
        //We have defined property to provide external access to the static object that we have created.

        public static SingletonClass Class
        {
            get { return _object; }
        }

        // Or we can do the same thing with function.
        public static SingletonClass Class_2()
        {
            return _object;
        }

        public int Summation(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
