using System;

namespace Date
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            DateTime threeDaysLater = today.AddDays(3);
            DateTime threeHoursLater = today.AddHours(3);
            DateTime threeMonthsLater = today.AddMonths(3);
            DateTime threeYearsLater = today.AddYears(3);
            DateTime twoDayAndThreeMonthsLater = today.AddDays(2)
                                                      .AddMonths(3);

            Console.WriteLine(today);
            Console.WriteLine(threeDaysLater);
            Console.WriteLine(threeHoursLater);
            Console.WriteLine(threeMonthsLater);
            Console.WriteLine(threeYearsLater);
        }
    }
}
