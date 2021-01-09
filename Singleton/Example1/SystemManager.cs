using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.First_Example
{
    public class SystemManager
    {
        private static SystemManager _systemManager; // Define a Field.

        private SystemManager()
        {
            // The reason of using 'private' is blocking external access. 
        }

        // Creating a Singleton object. 
        public static SystemManager CreateSingletonObject()
        {
            //In this method, we will check that if the SystemManager object has already been created, the created object will rotate, if it has not been created, it will be created and returned.
            if (_systemManager == null)
            {
                _systemManager = new SystemManager();
            }
            return _systemManager;
        }

        public void Add()
        {
            Console.WriteLine("An object was added..!");
            Console.ReadKey();
        }
    }
}
