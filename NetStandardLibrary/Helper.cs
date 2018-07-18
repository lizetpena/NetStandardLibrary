using System;

namespace NetStandardLibrary
{
    public class Helper
    {
        public static DateTime GetDate() => DateTime.Now;
        private int? number;

        public int? Number { get => number; set => number = value; }
    }
}
