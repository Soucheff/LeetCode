using System;

namespace App{


    public class Solution {
        public int NumberOfSteps(int num) {
            //Break point to avoid loop
            int steps=0;
            while(num>0){
                steps++;
                if(num % 2 == 0){
                    Console.WriteLine("Step {0}) {1} is even; divide by 2 and obtain {2}.",steps,num,num/2);
                    num = num/2;
                    continue;
                    
                }else{
                    Console.WriteLine("Step {0}) {1} is odd; subtract 1 and obtain {2}.",steps,num,num-1);
                    num -= 1;
                    continue;
                }
                
            }
            return steps;
        }
    }

    internal class Program{

        static void Main(){
            Solution s = new Solution();
            Console.WriteLine(s.NumberOfSteps(123));
        }

    }

}