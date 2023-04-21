using System;

namespace project {

    class Program {
        
        static void Main() {

        int n = Convert.ToInt32(Console.ReadLine());
        int k = Convert.ToInt32(Console.ReadLine());

        Random rnd = new Random();
        int val = rnd.Next(1, n);

        for(int i = k; k>-1; i--){
            
            int q = Convert.ToInt32(Console.ReadLine());
            if(q==val){
                System.Console.WriteLine("Вы угадали");
                break;
            } else {
                if(q>val){
                    if((i-1)==0){
                        System.Console.WriteLine("Попытки закончились");
                        break;
            }
                    System.Console.WriteLine("Загаданное число меньше");
                } else {
                    if((i-1)==0){
                        System.Console.WriteLine("Попытки закончились");
                        break;
            }
                    System.Console.WriteLine("Загаданное число больше");
                }
            }
            
        }

        

        }

    }

}