using System;
using System.Collections.Generic;

static class AssemblyLine
{

    private static int productPerHour = 221;

    public static double ProductionRatePerHour(int speed)
    {
        return productPerHour * speed * successRate(speed);    
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        return (int)ProductionRatePerHour(speed) / 60;        
    }


    private static double successRate(int speed)
    {        
        return (speed switch
        {
            var s when 1 <= s && s <= 4 => 1,
            var s when 5 <= s && s <= 8 => 0.9,
            9 => 0.8,
            10 => 0.77,
            _ => 0
            
        });
    }
}
