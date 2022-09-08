namespace StringInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            var date = DateTime.Now;
            var pi = Math.PI;
            
            // 1)
            Console.WriteLine($"1.{date.ToString("MMMM dd, yyyy")}");
            // 2)
            Console.WriteLine($"2.{date.ToString("yyyy.MM.dd")}");
            // 3)
            Console.WriteLine($"3.Day {date.ToString("dd")} of {date.ToString("MMMM, yyyy")}");
            // 4)
            Console.WriteLine($"4.Year: {date.ToString("yyyy")}, Month:{date.ToString("MM")}, Day: {date.ToString("dd")}");
            // 5)
            Console.WriteLine($"5.{date.ToString("dddd"),10}");
            // 6)
            Console.WriteLine($"6.{date.ToString("hh:mm tt"),10} {date.ToString("dddd"),10}");
            // 7)
            Console.WriteLine($"7.h:{date.ToString("hh")}, m:{date.ToString("mm")}, s:{date.ToString("ss")}");
            // 8)
            Console.WriteLine($"8.{date.ToString("yyyy.MM.dd.hh.mm.ss")}");
            // Pi 1)
            Console.WriteLine($"1.{pi.ToString("C")}");
            // Pi 2)
            Console.WriteLine($"2.{pi.ToString("F3"),10}");
        }
    }
}
