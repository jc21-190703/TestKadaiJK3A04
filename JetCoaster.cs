using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class JetCoaster
    {
        //k:定員、g:配列、ｒ:回す回数
        static int i = 0;

        public static int ride(int k, int[] g, int r)//メイン
        {
            int saisyukekka = 0;
           
            for (int j = 0; j < r; j++)//回す回数
            {
                saisyukekka += ride2(k, g);
            }
            return saisyukekka;


        }


        public static int ride2(int k, int[] g)//定員、配列
        {
            int kekka = 0;

            Boolean flg = true;
            while (flg)
            {
                if (kekka + g[i] > k)
                {
                    flg = false;
                }
                else
                {
                    kekka += g[i];
                    i = (i + 1) % g.Length;
                } 
               
            }
            return kekka;

        }
    }
}


/*for (int i = 1; i <= r; i++)
            {
                kekka +=ride2(k, g);
            }
            return kekka;
*/


/*for (int j = 0; j<= r; j++)
{
    saisyukekka += ride2(k, g);
}
return saisyukekka;
  */





/* int kekka = 0;
int saisyukekka = 0;


for (int i = 1; i <= r; i++)
{

    //kekka = ride2(k, g);

    kekka +=ride2(k, g);
}
return kekka;

}

public static int ride2(int k, int[] g)//定員以内に乗れる
{
int noruKazu = 0;

while (j<g.Length)
{
    if (noruKazu + g[j] < k)
    {
        noruKazu = noruKazu + g[j];
    }


}
if (j == (g.Length- 1)){
    j = 0;
}

return noruKazu;
}



public static int ride3(int[] g)//配列の組みなおし
{
for (int m = 0; m < g.Length; m++)
{


    int j = g[0];
    g[i] = g[i + 1];
    g[g.Length - 1] = j;
    kekka = kekka + j;
}
}
*/
//   }
//}

/*
            for (int j = 0; j < g.Length; j++)
            {
                //int noruKazu;

                if (noruKazu + g[j] < k)
                {
                    noruKazu = noruKazu + g[j];
                    //count = count + 1;
                }

            } 
            */








/*
            for (i = 0; i < g.Length; i++)
            {

                if (i == g.Length - 1)
                {
                    //result = result + kekka;
                    i = 0;
                }

                if (kekka + g[i] <= k)
                {
                    kekka = kekka + g[i];
                }
                else
                {
                    result = result + kekka;
                    count++;//発車した回数


                    if (count == r)
                    {
                        break;
                    }
                    kekka = 0;
                }

            }
            return result;
        }
    }
}
*/






































/*int kekka;
int i = 0;
//int j;


if (r == 1)
{ //動かす回数の判定
    int kekka = 0;
    if (g[i] <= k)//4<6
    {
        for (i = 0; i < g.Length; i++)
        {
            // int[] RideNumResult = new int[r];
            if (kekka + g[i] > k)
            {

                break;
            }

            kekka = kekka + g[i];
            //return kekka;
        }

        //kekka = g[i] + g[i+1];
        return kekka;
    }
    kekka = 100; //g[0]の時点で定員オーバー
    return kekka;


}
else
{
    int kekka = 0;
    if (g[i] <= k)//4<6
    {
        for (i = 0; i < g.Length; i++)
        {
            // int[] RideNumResult = new int[r];
            if (kekka + g[i] > k)
            {
                break;
            }

            int j = g[0];
            g[i] = g[i + 1];
            g[g.Length - 1] = j;
            kekka = kekka + j;

            /*for (i = 1; i < g.Length; i++)
            {

            }


            //return kekka;
        }
        return kekka;
    }
    kekka = 100; //g[0]の時点で定員オーバー
return kekka;

}
}
}
}
*/














