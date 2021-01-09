using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.Example3
{
    public class SingletonClass_2
    {
        private static SingletonClass_2 _singleObject;

        private static object _lockObject = new object();

        public SingletonClass_2()
        {

        }
        public static SingletonClass_2 Class
        {
            get
            {
                if (_singleObject == null)
                {
                    lock (_lockObject)
                    {
                        if (_singleObject == null)
                        {
                            _singleObject = new SingletonClass_2();
                        }
                    }
                }

                return _singleObject;
            }
        }
    }
}
