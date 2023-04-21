using System;
namespace project {
    class Program {

        static void Main() {

            int summa = 0;
            int col_nechet = 0;

            System.Console.WriteLine("Введите количество элементов списка");
            int colv = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Введите подряд {0} символов!", colv);
            int[] sp = new int[colv];

            for(int i = 0; i < colv; i++)
                sp[i] = Convert.ToInt32(Console.ReadLine());
            
            for(int x = 0; x < sp.Length; x++)
                if(sp[x] % 2 != 0){
                    summa += sp[x];
                    col_nechet ++;
                    if(col_nechet == colv && colv != 1)
                        summa -= (sp[0] + sp[colv-1]);
                        }
                else{
                    break;
                }           
            System.Console.WriteLine(summa);
            
        }

    }
}