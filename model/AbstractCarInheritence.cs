using System;
using System.Collections.Generic;
using System.Text;

namespace FirstTimeExperience_C_Sharp.tutorial
{
    abstract class AbstractCarInheritence
    {
        public abstract string whatCarIsThat();

        public static AbstractCarInheritence createMazda()
        {
            AbstractCarInheritence abstractCarInheritence = new Mazda();
            return abstractCarInheritence;
        }

        public static AbstractCarInheritence createFerrari()
        {
            AbstractCarInheritence abstractCarInheritence = new Ferrari();
            return abstractCarInheritence;
        }
    }

}
