using System;

namespace NetStandardLibrary
{
    public class Helper
    {
        public static DateTime GetDate() => DateTime.Now;
        private long? number;

        public long? Number { get => number; set => number = value; }
    }
}
