using System;
using System.Collections.Generic;
using System.Text;

namespace FirstTimeExperience_C_Sharp.tutorial
{
    enum WeekDays
    {
        MONDAY,TUESDAY,WENSDAY,THURSDAY,FRIDAY,SATURDAY,SUNDAY  
    }

    static class WeekDaysMethods
    {

        public static String WhatDayIsIt(this WeekDays day)
        {
            switch (day)
            {
                case WeekDays.MONDAY:
                    return "MONDAY!";
                case WeekDays.TUESDAY:
                    return "TUESDAY!";
                default:
                    return "other day ! " + day;
            }
        }
    }



}
