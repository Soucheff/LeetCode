using System;

namespace App{

    public class Solution {
       public bool CanConstruct(string ransomNote, string magazine) {
            if(ransomNote.Length > magazine.Length) return false;
            int indexS = 0;
            foreach(char l in ransomNote){
                indexS = magazine.IndexOf(l);
                if(indexS == -1){
                    return false;
                }else{
                    magazine = magazine.Remove(indexS,1);
                }
            }
            return true;
        }
    }
    internal class Program{
        static void Main(){
            Solution s = new Solution();
            Console.WriteLine(s.CanConstruct("aa","aab"));
        }
    }
}