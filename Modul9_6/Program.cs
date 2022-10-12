namespace Modul9_6
{
    class Program
    {
        static void Main(string [] args)
        {
            string[] Surnames = WriteSurnames();
            MetodReader metodReader = new MetodReader(Surnames);
            metodReader.MetodEnteredEvent += SortSurname;
            try
            {
                metodReader.Read();
            }
            // надеюсь правильно понял задание
            catch (FormatException)
            {
                Console.WriteLine("Введено некорректное значение");
            }
            catch (Exception ex) when (ex.Message == "Некорректное число")
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex) when (ex is ArgumentNullException)
            {
                Console.WriteLine("Аргумент, передаваемый в метод — null");
            }
            catch (Exception ex) when (ex is ArgumentOutOfRangeException)
            {
                Console.WriteLine("Аргумент находится за пределами диапазона допустимых значений.");
            }
            catch (Exception ex) when (ex.Message == "Плохо с фантазией")
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Сортировка завершена");
            foreach (string s in Surnames)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }

        static void SortSurname(int metod, string[] array)
        {
            switch (metod)
            {
                case 1:
                    Array.Sort(array);
                    break;
                case 2:
                    Array.Sort(array);
                    Array.Reverse(array);
                    break;
            }
        }

        public static string[] WriteSurnames()
        {
            string[]surn = new string[5];
            for (int i = 0; i < surn.Length; i++)
            {
                Console.WriteLine($"Введите {i + 1} фамилию");
                surn[i] = Console.ReadLine();
            }
            return surn;
        }
    }
}