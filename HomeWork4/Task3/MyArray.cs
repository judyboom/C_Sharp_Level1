using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class MyArray
    {
        int[] a;

        public MyArray(int n, int el)
        {
            a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = el;
        }

        public MyArray(int lenght, int startEl, int step) 
        {
            a = new int[lenght];
            a[0] = startEl;
            for (int i = 1; i < lenght; i++)
            {
                a[i] = a[i - 1] + step;
            }
        }

        //public MyArray(int n, int min, int max)
        //{
        //    a = new int[n];
        //    Random rnd = new Random();
        //    for (int i = 0; i < n; i++)
        //        a[i] = rnd.Next(min, max);
        //}

        public int Max
        {
            get
            {
                int max = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] > max) max = a[i];
                return max;
            }
        }

        public int Min
        {
            get
            {
                int min = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] < min) min = a[i];
                return min;
            }
        }
        
        public int CountPositiv
        {
            get
            {
                int count = 0;
                for (int i = 0; i < a.Length; i++)
                    if (a[i] > 0) count++;
                return count;
            }
        }

        public int Sum
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    sum += a[i]; 
                }
                return sum;
            }
        }

        public int[] Inverse()
        {
            var result = new int[a.Length];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = -a[i];
            }
            return result;
        }

        public void Multy(int num)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = a[i] * num;
            }
        }

        public int MaxCount
        {
            get
            {
                int count = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == Max)
                    {
                        count++;
                    }
                }
                return count;
            }
        }

        public override string ToString()
        {
            string s = "";
            foreach (int v in a)
                s = s + v + " ";
            return s;
        }
    }
}
