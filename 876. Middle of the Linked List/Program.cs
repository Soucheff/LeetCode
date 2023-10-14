using System;

namespace App{

    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int val=0, ListNode next=null) {
            this.val = val;
            this.next = next;
        }
    }
    public class Solution {
        public ListNode MiddleNode(ListNode head) {
            int qtd = 0;
            int m = 0;
            ListNode l = head;
            while(l.next != null){
                l = l.next;
                qtd++;
            }

            if(qtd % 2 != 0){
                qtd+=1;
            }
            m = (qtd/2);
            for(int i = ; i < m; i++){
                head = head.next;
            }
            return head;
        }
    }

    internal class Program{
        static void Main(){
            ListNode l = new ListNode();
            ListNode h = l;
            for(int i = 1; i <= 5; i++){
                l.val = i;
                l.next = new ListNode();
                l = l.next;
            }
            Solution s = new Solution();
            l = s.MiddleNode(h);
            while(l.next != null){
                Console.WriteLine("{0}->",l.val);
                l = l.next;
            }
        }
    }

}