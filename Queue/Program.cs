using System;
using System.CodeDom.Compiler;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructure;

namespace Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {  
         Queue<int> qu = new Queue<int>();
            qu.Insert(1);
            qu.Insert(2);
            qu.Insert(3);
            qu.Insert(4);
            Console.WriteLine(Order(qu));
            Queue<string> qu1 = new Queue<string>();
            qu1.Insert("noa");
            qu1.Insert("hadas");
            qu1.Insert("marom");
            qu1.Insert("amit");
            Queue<string> qu2 = new Queue<string>();
            qu2.Insert("noa1");
            qu2.Insert("hadas1");
            qu2.Insert("marom1");
            qu2.Insert("amit1");
            Console.WriteLine(SuperMarket(qu1,qu2));
        }
        public static void PrintQueue(Queue<int> qu)
        {
            Queue<int> temp=new Queue<int>();
            while(!qu.IsEmpty())
            {
                Console.Write( "--> " + qu.Head());
                temp.Insert(qu.Remove());
            }
            while (!temp.IsEmpty())
            {
                qu.Insert(temp.Remove());
            }
        }
        public static int CntQueue(Queue<int> qu)
        {
            int cnt = 0;
            Queue<int> temp = new Queue<int>();
            while (!qu.IsEmpty())
            {
                cnt++;
                temp.Insert(qu.Remove());
            }
            while (!temp.IsEmpty())
            {
                qu.Insert(temp.Remove());
            }
            return cnt;
        }
        public static int CntQueue1(Queue<string> qu)
        {
            int cnt = 0;
            Queue<string> temp = new Queue<string>();
            while (!qu.IsEmpty())
            {
                cnt++;
                temp.Insert(qu.Remove());
            }
            while (!temp.IsEmpty())
            {
                qu.Insert(temp.Remove());
            }
            return cnt;
        }
        public static bool IsExists(Queue<int> qu,int num)
        {
            Queue<int> temp = new Queue<int>();
            while (!qu.IsEmpty())
            {
                if (qu.Head() == num)
                {
                    return true;
                }
                temp.Insert(qu.Remove());
            }
            while (!temp.IsEmpty())
            {
                qu.Insert(temp.Remove());
            }
            return false;
        }
        public static void PrintPos (Queue<int> qu)
        {
            Queue<int> temp = new Queue<int>();
            while (!qu.IsEmpty())
            {
                if(qu.Head()>0)
                {
                    Console.Write("--> " + qu.Head());
                }
              
                temp.Insert(qu.Remove());
            }
            while (!temp.IsEmpty())
            {
                qu.Insert(temp.Remove());
            }
        }
        public static void Add5 (Queue<int> qu)
        {
            Queue<int> temp = new Queue<int>();
            while (!qu.IsEmpty())
            {
                if (qu.Head() < 10)
                {
                    temp.Insert(qu.Remove()+5);
                }
                else
                {
                    temp.Insert(qu.Remove());
                } 
            }
            while (!temp.IsEmpty())
            {
                qu.Insert(temp.Remove());
            }
        }
        public static int MaxQ (Queue<int> qu)
        {
            int max=qu.Head();
            Queue<int> temp = new Queue<int>();
            while (!qu.IsEmpty())
            {
                if (qu.Head() > max)
                {
                   max= qu.Head();
                }

                temp.Insert(qu.Remove());
            }
            while (!temp.IsEmpty())
            {
                qu.Insert(temp.Remove());
            }
            return max;
        }
        public static int GetIndex (Queue<int> qu, int num)
        {
            int cnt = 0;
            int index = -1;
            Queue<int> temp = new Queue<int>();
            while (!qu.IsEmpty())
            {
                cnt++;
                if (qu.Head() == num)
                {
                  cnt=index; 
                }
                temp.Insert(qu.Remove());
                
            }
            while (!temp.IsEmpty())
            {
                qu.Insert(temp.Remove());
            }
            return cnt;
        }
        public static Queue<int> Order(Queue<int> qu)
        {
            Queue<int> Positive = new Queue<int>();
            Queue<int> Negative = new Queue<int>();
            Queue<int> Zero = new Queue<int>();
            while (!qu.IsEmpty())
            {
                if (qu.Head() < 0)
                {
                    Negative.Insert(qu.Remove());
                }
                else if(qu.Head() > 0)
                {
                    Positive.Insert(qu.Remove());
                }
                else
                {
                    Zero.Insert(qu.Remove());
                }
            }
            while (!Negative.IsEmpty())
            {
                qu.Insert(Negative.Remove());
            }
            while (!Zero.IsEmpty())
            {
               qu.Insert(Zero.Remove());
            }
            while (!Positive.IsEmpty())
            {
                qu.Insert(Positive.Remove());
            }
            return qu;
        }
        public static Queue<string> SuperMarket(Queue<string> open,Queue<string> close)
        {
            int length1 = CntQueue1(open);
            int length2=CntQueue1(close);
            int length=Math.Min(length1,length2);
            Queue<string> combaine = new Queue<string>();
            for(int i = 0; i < length; i++)
            {
                if (i % 2 == 1)
                {
                    combaine.Insert(close.Remove());
                }
                else
                {
                    combaine.Insert(open.Remove());
                }
            }
            if (length != length1)
            {
                while(!close.IsEmpty())
                {
                    combaine.Insert(close.Remove());
                }
            }
            else if (length != length2)
            {
                while (!open.IsEmpty())
                {
                    combaine.Insert(open.Remove());
                }
            }
            else 
            {
                while (!close.IsEmpty())
                {
                    combaine.Insert(close.Remove());
                }
                while (!open.IsEmpty())
                {
                    combaine.Insert(open.Remove());
                }
            }
            return combaine;
        }
    }
}
