using System;
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
            Console.WriteLine(MaxQ(qu));
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
            return 
        }
    }
}
