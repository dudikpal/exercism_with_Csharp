using System;

namespace GigasecondSpace
{


    public static class Gigasecond
    {
        public static DateTime Add(DateTime moment)
        {
            return moment.AddSeconds(1000_000_000);
        }
    }
}