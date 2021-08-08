using System;
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


            AbstractCarInheritence abstractCarInheritence = AbstractCarInheritence.createMazda();
            AbstractCarInheritence abstractCarInheritence2 = AbstractCarInheritence.createFerrari();

            Console.WriteLine(abstractCarInheritence.whatCarIsThat());
            Console.WriteLine(abstractCarInheritence2.whatCarIsThat());     

            return; 

        }
    }
}
