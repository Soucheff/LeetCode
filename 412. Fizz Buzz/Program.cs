using System;
using System.Collections.Generic;

namespace App {

    public class Solution {

        public IList<string> FizzBuzz(int n) {
            List<string> l = new List<string>();

            for(int i = 1 ; i <= n ; i++ ){
                string result = "";
            
                if( i % 3 == 0){
                    result = "Fizz";
                }
            
                if( i % 5 == 0){
                    result += "Buzz";
                }
            
                l.Add( (result == "") ? i.ToString() : result );  
            }   
            return l;
        }
    }
    internal class Program{
        static void Main(){
            Solution s = new Solution();
            Console.WriteLine("[{0}]",string.Join(",",s.FizzBuzz(15)));

        }
    }
}


