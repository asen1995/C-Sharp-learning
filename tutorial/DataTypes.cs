using System;
using System.Collections.Generic;
using System.Text;

namespace FirstTimeExperience_C_Sharp.tutorial
{
    class DataTypes
    {
        public int playWithDataTypes()
        {
            /* local variable declaration */

            //difference between Java and C# 

            //byte here can be represent as signed byte =
            //sbyte	8-bit signed integer type -128 to 127

            sbyte signedByte = -120;
            Console.WriteLine("signedByte : " + signedByte);

            uint unsigned32BitInt = 4294967295;
            ulong unsigned64BitLong = 18446744073709551615;
            ushort unsignedShort = 65535;

            Console.WriteLine("signedByte : " + signedByte + " \n ," +
                "unsigned32BitInt : " + unsigned32BitInt + " \n ," +
                "unsigned64BitLong : " + unsigned64BitLong + " \n ," +
                "unsignedShort : " + unsignedShort
                );

            return 0;

        }
    }
}
