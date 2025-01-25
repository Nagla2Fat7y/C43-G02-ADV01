using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assiement01C_Advanced.Question02
{
    internal class Revarse <T> where T : IComparable<T>
    {
        public static void RevarseArray(ref T[] Array)
        {
            if (Array is not null)
            {
                for (int i = 0; i < Array.Length; i++)
                    for (int j = 0; j < Array.Length - 1 - i; j++)
                        if (Array[j].CompareTo(Array[j + 1]) < 0)
                             SWAP(ref Array[j], ref Array[j + 1]);
            }
        }


        public static void SWAP(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
    }
} 

    
