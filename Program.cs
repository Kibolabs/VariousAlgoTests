using System;
using System.Collections.Generic;

namespace VariousAlgoTests
{
    class Program
    {public static int n =125;

        static void Main(string[] args)
        {
            Program fib =new Program();
            Dictionary<int, double> dict = new Dictionary<int,double>();
            for(int i=1; i<=n; i++){
                //Console.WriteLine("Fibonnaci for "+ i + " is: " + fib.Fib(i));
                Console.WriteLine("Fibonnaci for "+ i + " is: " + fib.FastFib(i, memo:dict));
                
            }
            
        }
        public double Fib(int num){
            if (num==0||num==1){
                return 1;
            }else{
                return Fib(num-1) + Fib(num-2);
            }
        }
        public double FastFib(int num , Dictionary<int, double> memo){
             if (num==0||num==1){
                return 1;
            }
            try{
                return memo[key:num];
            }catch{
                double result = FastFib(num-1,memo) + FastFib(num-2, memo);
                memo[num] =result;
                return result;
            }
        }

    }
}
