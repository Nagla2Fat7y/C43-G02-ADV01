using System.Collections;
using Assiement01C_Advanced.Question01;
using Assiement01C_Advanced.Question02;
using Assiement01C_Advanced.Question03;

namespace Assiement01C_Advanced
{
    internal class Program 
    {


        #region  Question05

        static int NonRepeatedCharacter(string str)
        {
            Dictionary<char, int> CharFreq = new Dictionary<char, int>();

            // Fill Dictionary 
            for (int i = 0; i < str.Length; i++)
                if (CharFreq.ContainsKey(str[i])) CharFreq[str[i]]++;
                else CharFreq.Add(str[i], 1);

            // Search for non-repeated character 
            for (int i = 0; i < str.Length; i++)
                if (CharFreq[str[i]] == 1)
                    return i;

            return -1;
        }
        #endregion
        static void Main(string[] args)
        {

            #region Question01

            //Range<int> range = new Range<int> (1, 2);

            //if (range.IsInRange(10))
            //    Console.WriteLine("Number is in Range");
            //else
            //    Console.WriteLine("Number is not in Range");
            //Console.WriteLine($"Rang Length: {range.Length()}");


            //Range<double> range02 = new Range<double>(1.23, 5.23);

            //if (range02.IsInRange(2.15))
            //    Console.WriteLine("Number is in Range");
            //else
            //    Console.WriteLine("Number is not in Range");
            //Console.WriteLine($"Rang Length: {range02.Length()}");
            #endregion


            #region Question02
            //int[] arr = { 4, 5, 6, 10, 8, 1, 2 };
            //Revarse<int>.RevarseArray(ref arr);
            //foreach (var item in arr)
            //{
            //    Console.Write(item + "  ,  \n");
            //}
            #endregion

            #region Question03
            //List<int> L01 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            //List<int> L02 = new List<int>();

            //for (int i = 0; i < L01.Count; i++)
            //{
            //    if (L01[i] % 2 == 0)
            //        L02.Add(L01[i]);
            //}

            //if (L02.Count == 0)
            //    Console.WriteLine("There is No Even Numbers");
            //else
            //    for (int i = 0; i < L02.Count; i++)
            //        Console.Write($"{L02[i]} ");
            #endregion


            #region Question04
            //FixedSizeList<int> list = new FixedSizeList<int>(5);

            //list.Add(1);
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);
            //list.Add(5);

            //Console.WriteLine(list.Get(2));
            //Console.WriteLine(list.Get(6));
            #endregion

            #region Question05

            string st = "ABCDAB";

            Console.WriteLine($"Index: {NonRepeatedCharacter(st)}");

            #endregion



        }
    }
}
