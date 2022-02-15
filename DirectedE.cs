using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
   public class DirectedE
    {
        public static int[] SEARCH(int[] edgeFirst, int[] edgeNext, int s)//メイン
        {
            int N = 6;
            int M = 8;
            int temp;
            // var current = new List<int>();
            //var searched = new List<int>();
            //var start = new List<int>();
            //var end = new List<int>();
            //var path = new List<int>();
            //a,b,c,d,e,f
            //1,2,3,4,5,6
            int[] start = { 0, 1, 2, 3, 1, 4, 3, 5 };
            int[] end = { 1, 2, 3, 0, 4, 3, 5, 1 };
            int[] current = new int[7];
            int[] searched = new int[9];
            int[] path = new int[8];




            for (int i = 0; i < N; i++)
            {
                current[i] = edgeFirst[i] - 1;
            }



            int top = 0;
            int last = M - 1;
            int x = s - 1;



            while (last >= 0)
            {
                if (current[x] != -1)
                {
                    temp = current[x];
                    searched[top] = temp;
                    current[x] = edgeNext[temp] - 1;
                    x = end[temp];
                    top++;
                }
                else
                {
                    top = top - 1;
                    temp = searched[top];
                    path[last] = temp + 1;
                    x = start[temp];
                    last--;
                }
            }
            return path;
        }
    }
} 


      