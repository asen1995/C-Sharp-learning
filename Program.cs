using System;
using System.Collections;
using FirstTimeExperience_C_Sharp.model;
using FirstTimeExperience_C_Sharp.tutorial;

namespace FirstTimeExperience_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {


            // DataTypes dataTypes = new DataTypes();
            // dataTypes.PlayWithDataTypes();

            // Console.WriteLine(WeekDaysMethods.WhatDayIsIt(WeekDays.SUNDAY));


            /*AbstractCarInheritence abstractCarInheritence = AbstractCarInheritence.createMazda();
            AbstractCarInheritence abstractCarInheritence2 = AbstractCarInheritence.createFerrari();

            Console.WriteLine(abstractCarInheritence.whatCarIsThat());
            Console.WriteLine(abstractCarInheritence2.whatCarIsThat());*/


            /*User user = new SystemUser();
            User user2 = new HR();
            Console.WriteLine(user.typeOfUserAsString());
            Console.WriteLine(user2.typeOfUserAsString());*/

            Hashtable hashtable =
                Collections.CreateHashTable(new string[] { "asen", "victor", "petur" });
            Console.WriteLine("map is : " + hashtable);

            if (hashtable.ContainsKey("asen"))
            {
                Console.WriteLine("contains asen");
            }else
            {
                Console.WriteLine("don't contains asen");

            } 

            return; 

        }
    }
}
