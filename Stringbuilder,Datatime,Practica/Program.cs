using System;
using System.Net.Http.Headers;

namespace Stringbuilder_Datatime_Practica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(DomainReturner("elchin@code.edu.az"));

            //Console.WriteLine(FindLetter("dsjfbdsj"));

            //Console.WriteLine(FirstLetterLarge("saLAm nEceSen"));

            //Console.WriteLine(Findage("9.3.2005",DateTime.Now));

            //Practica
            #region practica
            //string ad;
            //string soyadı;


            //ad = "Steven Clark";
            //soyadı = "Steven Clark";


            //Console.WriteLine(ad.CompareTo(soyadı));

            //Console.WriteLine(ad.Contains('n'));

            //Console.WriteLine(ad.EndsWith('k'));

            //Console.WriteLine(ad.Equals(soyadı));

            //Console.WriteLine(ad.GetHashCode());

            //Console.WriteLine(ad.GetType());

            //Console.WriteLine(ad.GetTypeCode());

            //Console.WriteLine(ad.IndexOf("n"));

            //Console.WriteLine(ad.ToLower());

            //Console.WriteLine(ad.ToUpper());

            //Console.WriteLine(ad.Insert(0, "="));

            //Console.WriteLine(ad.IsNormalized());

            //Console.WriteLine(ad.Remove(1));

            //Console.WriteLine(ad.Replace('e', 'i'));

            //Console.WriteLine(ad.Split());

            //for (int i = 0; i < ad.Length; i++)
            //{
            //    Console.WriteLine(ad.Substring(i, 1));
            //}



            //Console.WriteLine(ad.ToCharArray());

            //Console.WriteLine(ad.Trim());


            //Console.WriteLine(string.Concat(ad, soyadı));


            //string name = string.Copy(ad);


            //Console.WriteLine(name);



            //int[] nums = { 143, 20, 35 };
            //int[] newNumsArr = new int[10];


            //Array.Copy(nums, 1, newNumsArr, 4, 2);


            //Array.Clear(newNumsArr, 0, 5);


            //Array.Sort(nums);

            //Array.Reverse(nums);


            //Array.Resize(ref nums, 3);

          



            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}

            #endregion
        }

        //1 Verilmiş email dəyərinin domain hissəni qaytaran metod
        //(elchin@code.edu.az email-i daxil edilsə code.edu.az hiss'sini qaytarmalıdır)
        static string DomainReturner(string email)
        {
            int startIndex = email.IndexOf("@") + 1;
            int endIndex = email.Length;

            var result = email.Substring(startIndex, (endIndex - startIndex));

            return result;
        }


        //2 Verilmiş yazının yalnız hərflərdən ibarət olub olmadığını tapan metod
        static bool FindLetter(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]))
                {
                    return false;
                }
            }
            return true;
        }


        //3 Verilmiş yazının ilk hərfini böyük qalanlarını kiçik edib qaytaran metod
        //(Misaçün "saLAm nEceSen" yazısı daxil edilsə metoddan "Salam necesen" return olmalıdır)
        static string FirstLetterLarge(string text)
        {

            var text2 = text.Trim().ToLower();

            string upperCase = "";
            for (int i = 0; i < text2.Length; i++)
            {

                upperCase = text2[0].ToString().ToUpper() + text2.Substring(1);
            }
            return upperCase;
        }


        //5 doğum tarixinizi daxil etdiyinizdə sizə yaşınızı qaytaran metod
        static double Findage(string age, DateTime year)
        {
            double result = 0;
            DateTime.TryParse(age, out year);
            result = (DateTime.Now.Year - year.Year);
            return result;
        }
    }

}