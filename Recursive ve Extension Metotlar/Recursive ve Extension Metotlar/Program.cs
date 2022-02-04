using System;

namespace Recursive_ve_Extension_Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Recursive Fonksiyon (Öz Yinelemeli Fonksiyon)
            // 3^4
            int result = 1;
            for (int i = 1; i < 5; i++)
                result = result * 3;
            Console.WriteLine(result);

            İslemler instance = new();
            Console.WriteLine(instance.Expo(3, 4));

            // EXTENSION FONKSİYONLAR
            string ifade = "Veysel Emre Yemlik";
            bool sonuc = ifade.CheckSpace();
            Console.WriteLine(sonuc);
            if (sonuc)
            {
                Console.WriteLine(ifade.RemoveWhiteSpaces());
                Console.WriteLine(ifade.MakeUpperCase());
                Console.WriteLine(ifade.MakeLowerCase());

                int[] dizi = {9, 5, 7, 11, 15, 3, 562, 200};
                dizi.SortArray();
                dizi.EkranaYazdir();

                int number = 125; 
                Console.WriteLine(number.IsEvenNummber());

                Console.WriteLine(ifade.GetFristCharacter());

            }

        }
    }
    public class İslemler
    {

        public int Expo(int sayi, int üs)
        {
            if (üs < 2)
                return sayi;
            return Expo(sayi, üs - 1) * sayi;
        }
        // Expo(3,4)
        // Expo(3,3)*3
        // Expo(3,2)*3*3
        // Expo(3,1)*3*3*3
        // 3*3*3*3 = 81

    }

    public static class Extension
    {

        public static bool CheckSpace(this string param)
        {
            return param.Contains(" ");
        }

        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("", dizi);
        }

        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }

        public static string MakeLowerCase(this string param)
        {
            return param.ToLower();
        }

        public static int[] SortArray(this int[] param)
        {
           Array.Sort(param);
            return param;
        }

        public static void EkranaYazdir(this int[] param)
        {
            foreach (int item in param)
              Console.WriteLine(item);
        }

        public static  bool IsEvenNummber(this int param)
        {
            return param % 2 == 0;

        }

        public static string GetFristCharacter(this string param)
        {
            return param.Substring(0,2);
        }
    }
}


