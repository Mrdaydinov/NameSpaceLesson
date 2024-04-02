using System.ComponentModel.Design;

namespace NameSpaceLesson
{
    internal class Program
    {

        static bool IsArrayContains(int[] array1, int[] array2)
        {
            int[] newAr1 = new int[array2.Length];

            int index = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array1[i] == array2[j])
                    {
                        newAr1[index] = array1[i];
                        index++;
                    }
                }
            }

            bool res = true;
            for (int i = 0; i < array2.Length; i++)
            {
                if (newAr1[i] != array2[i])
                    res = false;
            }

            return res;
        }

        static void Main(string[] args)
        {
            //Task 1


            //int[] arr1 = { 2, 3, 4, 7 };
            //int[] arr2 = { 2,3 };
            //Console.WriteLine(IsArrayContains(arr1, arr2));





            //Task 2

            //User[] users = {new("Ad1", "Soyad1", "Username1", "password1"), new ("Ad2", "Soyad2", "Username2", "password2"),
            //                new("Ad3", "Soyad3", "Username3", "password3")};

            //Student[] students = { new("Ad3", "Soyad3", "Username3", "password3", 1), new("Ad4", "Soyad4", "Username4", "password4", 3) };


            //Console.WriteLine("Username:");
            //string username = Console.ReadLine();

            //Console.WriteLine("\nPassword");
            //string password = Console.ReadLine();

            //foreach (var us in users)
            //{
            //    foreach (var st in students)
            //    {
            //        if (us.Username == username && us.Password == password && st.Username == username && st.Password == password)
            //            Console.WriteLine($"\nGrade = {st.Grade}");
            //    }
            //}
        }
    }
}