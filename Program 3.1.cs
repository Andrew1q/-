using System;

namespace project {

    class Program {
        
        static void Main() {

            byte a = Convert.ToByte(Console.ReadLine());
            byte b = Convert.ToByte(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            byte year = 0;
            if(c%4==0 & c%100!=0 | c%400==0){
                System.Console.WriteLine("In year 366 days");
                year = 1;      
            } else {
                System.Console.WriteLine("In year 365 days");
            }
            if(b==4 | b==6 | b== 9 | b==11){
                System.Console.WriteLine("In mounth 30 day");
            } else {
                if(b!=2){
                    System.Console.WriteLine("In mounth 31 day");
                } else {
                    if(b==2 & year==1){
                        System.Console.WriteLine("In mounth 29 day");
                    } else {
                        System.Console.WriteLine("In mounth 29 day");
                    }
                }
            }

        }

    }

}