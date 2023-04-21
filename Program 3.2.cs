using System;

namespace project {

    class Program {
        
        static void Main() {

        int year = Convert.ToInt32(Console.ReadLine());

        for(int i = 1; i<13; i++){
            int days = DateTime.DaysInMonth(year, i);
            for(int x = days; x > 0; x--){
                DateTime theDate1 = new DateTime(year, i, x);
                DayOfWeek day = theDate1.DayOfWeek; 
                int day1 = (int)day;
                if(day1 == 4){
                    System.Console.WriteLine(x);
                    break;
                }
                
                }
            }
            
        }

    }

}