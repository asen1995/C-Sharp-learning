using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FirstTimeExperience_C_Sharp.tutorial
{
    class Collections
    {

        public static Hashtable CreateHashTable(string [] names)
        {
            Hashtable ht = new Hashtable();

            sbyte counter = 1; 
            foreach (string name in names)
            {
                ht.Add(name, counter);
                counter++;               
            }

            return ht;

        }
    }
}
