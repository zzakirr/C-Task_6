using System;

namespace Practise_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task-1
            /*string str = Console.ReadLine();
            NewString(str);*/
            #endregion
            #region Task-2
            /*string str = "zakidd1";
            Console.WriteLine($"1-ci check:{IsDigit(str)}\n2-ci check:{IsUpper(str)}\n3-cu check:{IsLower(str)}");*/
            #endregion
            #region Task-3
            /*string str = "Hello World";
            var check = str.Substring(0, str.IndexOf(" "));
            Console.WriteLine(check);*/
            #endregion
            #region Task-4
            /*string str = "Hello World ";
            str = str.Trim();
            string[] strArr = str.Split(' ');
            string char1 = strArr[0];
            string char2 = strArr[1];

            if (strArr.Length == 2 && char.IsUpper(char1[0]) == true && char.IsUpper(char2[0]))
            {
                Console.WriteLine("True");
            }
            else
                Console.WriteLine("False");*/
            #endregion
            #region Task-5
            /*int[] arr = {1,2,3, 4, 5};
            int newValue = Convert.ToInt32(Console.ReadLine());
            int[] result = AddValue(arr,newValue);
            foreach (var item in result)
            {
                Console.Write($" {item}");
            }*/
            #endregion


        }
        #region Task-1
        /*static void NewString(string str)
        {
            string[] strArr = str.Split(' ');
            int count = 0;
            for (int i = 0; i < strArr.Length; i++)
            {
                if (strArr[i] != "")
                    count++;
            }
            string[] NewstrArr = new string[count];
            int j = 0;
            for (int i = 0; i < strArr.Length; i++)
            {
                if (strArr[i] != "")
                {
                    NewstrArr[j] = strArr[i];
                    j++;
                }

            }
            Console.WriteLine(string.Join(" ", NewstrArr));
        }*/
        #endregion
        #region Task-2
        static bool IsDigit(string str)
        {
            char[] strChar = str.ToCharArray();
            bool check = false;
            for (int i = 0; i < strChar.Length; i++)
            {
                if (Char.IsDigit(strChar[i]))
                {
                    check = true;
                    break;
                }
            }
            return check;

        }
        static bool IsUpper(string str)
        {
            char[] strChar = str.ToCharArray();
            bool check = false;
            for (int i = 0; i < strChar.Length; i++)
            {
                if (Char.IsUpper(strChar[i]))
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        static bool IsLower(string str)
        {
            char[] strChar = str.ToCharArray();
            bool check = false;
            for (int i = 0; i < strChar.Length; i++)
            {
                if (Char.IsLower(strChar[i]))
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        #endregion
        #region Task-5
        /*static int[] AddValue(int[] arr,int newValue)
        {
            int[] NewArr = new int[arr.Length+1];
            for (int i = 0; i < arr.Length; i++)
            {
                NewArr[i] = arr[i];
            }
            NewArr.SetValue(newValue,arr.Length);
            return NewArr;
        }*/
        #endregion

    }
}
