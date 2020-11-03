using System;
using System.Collections.Generic;

namespace TP1Axel_San_Maela_Le_Gall
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "hello world";
            char c = 'l';
            List<string> list = Split(c, str);
            foreach (string s in list)
            {
                Console.WriteLine(s);
            }
            string str2 = "palindrome";
            Console.WriteLine(Alenvers(str2));
            string str3 = "hello world";
            Console.WriteLine(Bonordre(str3));
            string str4 = "hello world";
            Console.WriteLine(Question4(str4));

            List<int> A = new List<int>();
            List<int> B = new List<int>();
            int n = 0;
            Console.WriteLine(Fusion(A, B));

            List<int> T = new List<int>();
            Console.WriteLine(triFusion(T, n));

            //Question5
            const int MaxTableau1 = 10;
            int[] Question5 = new int[] { 3, 10, 7, 2, 8, 9, 1, 6, 4, 5 };

            for (int i = 0; i <; i++))
            {
                if (i == )
                {

                }
                else
                {

                }
            }





            //Question6
            const int MaxTableau2 = 10;
            int K, L, I, J;
            int[] Question6 = { 3, 10, 7, 2, 8, 9, 1, 6, 4, 5 };
            for (K = 0; K < MaxTableau2; K++) Console.Write(Question6[K] + ", ");

            for (I = MaxTableau2 - 2; I >= 0; I--)
            {
                for (J = 0; J <= I; J++)
                {
                    if (Question6[J + 1] < Question6[J])
                    {
                        int t = Question6[J + 1];
                        Question6[J + 1] = Question6[J];
                        Question6[J] = t;
                    }
                }
            }
            Console.WriteLine();
            for (L = 0; L < MaxTableau2; L++)
            {
                Console.Write(", " + Question6[L]);
            }
            Console.WriteLine();

        }

        static List<String> Split(char c, string str)
        {
            List<string> list = new List<string>();
            string temp = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == c)
                {
                    list.Add(temp);
                    temp = "";
                }
                else
                {
                    temp = temp + str[i];
                }
            }
            list.Add(temp);
            return list;
        }

        static String Alenvers(string str)
        {
            string result = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                result = result + str[i];
            }

            return result;
        }

        static String Bonordre(string str)
        {
            string result = "";
            List<string> mots = Split(' ', str);
            for (int i = 0; i < mots.Count; i++)
            {
                result = result + Alenvers(mots[i] + (i < mots.Count - 1 ? "" : " "));
            }

            return result;
        }

        static String Question4(string str)
        {
            string result = "";
            List<string> mots = Split(' ', str);
            for (int i = mots.Count - 1; i >= 0; i--)
            {
                result = result + (mots[i] + (i < mots.Count - 1 ? "" : " "));
            }

            return result;

        }

        static List<int> Fusion(List<int> A, List<int> B)
        {

            if (A == null)
            {
                return B;
            }

            if (B == null)
            {
                return A;
            }

            if (A[1] <= (B[1]))
            {
                return A[1] + Fusion(List<int> A[2, , a], B);
            }

            else
            {
                return B[1] + Fusion(List<int> B[2, , b], A);
            }
        }

        static List<int> triFusion(List<int> T, int n)
        {
            if (n <= 1)
            {
                return T;
            }
            else
            {
                return Fusion(triFusion(T[1, , n / 2]), triFusion(T[n / 2 + 1, , n]));
            }
        }
    }
}
}

    

