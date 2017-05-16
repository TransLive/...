using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SDKU
{
    class Sdku
    {
        public int[,] num = new int[9, 9];
        public int[,] num2 = new int[9, 9];
        bool[,] EmptyBox = new bool[9,9];
        public Sdku()
        {
            
            generate();
        }
        public void generate()
        {
            for (int i = 0; i <= 8; i++)
            {
                for (int j = 0; j <= 8; j++)
                {
                    num[i, j] = 0;
                    EmptyBox[i,j] = false;
                }
            }
            _1stRow();
            layout(1, 0);
            Random rnd = new Random();
            //num[rnd.Next(0,9), rnd.Next(0,9)] = 0;
            averageDig(rnd.Next(3,7));
            //averageDig(1);
            for (int i = 0; i <= 8; i++)
            {
                for (int j = 0; j <= 8; j++)
                {
                    num2[i, j] = num[i, j];
                    
                }
            }
        }
    
        private void _1stRow()
        {
            Random rnd = new Random();
            for (int i = 0; i < 9; i++)
            {

                //生成第一排
                num[0, i] = rnd.Next(1, 10);
                for (int k = 0; k < i; k++)
                {
                    if (num[0, i] == num[0, k])
                    {
                        num[0, i] = rnd.Next(1, 10);
                        k = -1;
                    }
                }
            }
        }

        private bool averageDig(int number)
        {
            //number is 2~7
            //if (number > 8 || number < 1)
            //{
            //    MessageBox.Show("Error");
            //    return false;
            //}
            int iUp;
            int jUp;
            int i;
            int j;
            int[,] Digged = new int[2, 8];
            Random rnd = new Random();
	//int jDigged[8] = { 0 };
	for (int k = 0; k <= 8;k++)
	{
		iUp = 3 * ((k / 3) + 1) - 1;
		jUp = ((k + 3) % 3) * 3 + 2;
		for (int t = 0; t<number;t++)
		{
            i = rnd.Next(iUp - 2, iUp + 1);
            j = rnd.Next(jUp - 2, jUp + 1);
			Digged[0,t] = i;
			Digged[1,t] = j;
			//jDigged[t] = j;
			num[i,j] = 0;
            EmptyBox[i, j] = true;
			for (int s = 0; s<t;s++)
			{
				if (i == Digged[0,s] && j == Digged[1,s])
				{
					t--;
					break;
				}
            }
		}
	}
	return true;
}

        private bool layout(int i, int j)
        {
            if (i >= 9 || j >= 9)
            {
                return true;
            }

            for (int k = 1; k <= 9; k++)
            {
                bool isRepetitive = false;
                //check colume
                for (int m = 0; m < i; m++)
                {
                    if (num[m, j] == k)
                    {
                        isRepetitive = true;
                        break;
                    }
                }
                //check row
                if (!isRepetitive)
                {
                    for (int n = 0; n < j; n++)
                    {
                        if (num[i, n] == k)
                        {
                            isRepetitive = true;
                            break;
                        }
                    }
                }
                if (!isRepetitive)
                {
                    //caculate limit
                    int iUp = (i / 3) * 3 + 3 - 1;
                    int jUp = (j / 3) * 3 + 3 - 1;
                    /*The lower limits have been checked before*/
                    for (int t = iUp - 2; t <= i; t++)
                    {
                        if (isRepetitive) break;
                        for (int s = jUp - 2; s <= jUp; s++)
                        {
                            if (num[t, s] == k)
                            {
                                isRepetitive = true;
                                break;
                            }
                        }
                    }
                }

                if (!isRepetitive)
                {
                    num[i, j] = k;
                    if (j < 8)
                    {
                        if (layout(i, j + 1))
                            return true;
                    }
                    else if (i < 8) //i是线性变化，j是从0~8循环变化
                    {
                        if (layout(i + 1, 0))
                            return true;
                    }
                    else
                        return true;
                    //如果上面两个递归出来都返回false，说明这个k无效，这一格需要推倒重来
                    //完全推倒原因是因为如果如果本格重選後的k还是不行的话，置零可以不影响上一格的搜索
                    num[i, j] = 0;
                }
            }
            return false;/*1~9都试过不行才会返回false，否在在中途返回true*/
        }

        public bool judgeAll()
        {
            //colum
            for (int i = 0;i <=8;i++)
            {
                for (int j = 0; j <= 8; j++)
                {
                    if(EmptyBox[i,j])
                    {
                        for (int t = 0;t<=8;t++)
                        {
                            if (num[i, j] == num[t, j] && i != t) return false;
                            if (num[i, j] == num[i, t] && j != t) return false;
                        }
                        int iUp = (i / 3) * 3 + 3 - 1;
                        int jUp = (j / 3) * 3 + 3 - 1;
                        for (int t = iUp - 2; t <= iUp; t++)
                        {
                            for (int s = jUp - 2; s <= jUp; s++)
                            {
                                
                                if (num[i,j] == num[t, s] && t!= i && t!= j)
                                {
                                    return false;
                                }
                            }
                        }
                    }
                }
            }
            return true;
         }
    }
}