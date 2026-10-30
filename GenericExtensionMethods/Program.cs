namespace GenericExtensionMethods
{
    public static class ListExtensions
    {
        public static void Swap<T>(this List<T> list, int i, int j)
        {
            (list[i], list[j]) = (list[j], list[i]);
        }

        public static bool IsEmpty<T>(this List<T> list)
        {
            return list.Count == 0;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3 };
            List<string> words = new List<string> { "a", "b", "c" };
            List<string> emptyWords = new List<string>();

            while (true)
            {
                Console.WriteLine("1. Swap для List<int>");
                Console.WriteLine("2. IsEmpty для List<int>");
                Console.WriteLine("3. Swap для List<string>");
                Console.WriteLine("4. IsEmpty для List<string>");
                Console.WriteLine("5. IsEmpty для пустого списка");
                Console.WriteLine("0. Выход");
                Console.Write("Выберите действие: ");

                try
                {
                    int choice = int.Parse(Console.ReadLine()!);

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("До Swap: " + string.Join(", ", numbers));
                            numbers.Swap(0, 2);
                            Console.WriteLine("После Swap: " + string.Join(", ", numbers));
                            break;

                        case 2:
                            Console.WriteLine("Список чисел: " + string.Join(", ", numbers));
                            Console.WriteLine("IsEmpty: " + numbers.IsEmpty());
                            break;

                        case 3:
                            Console.WriteLine("До Swap: " + string.Join(", ", words));
                            words.Swap(0, 2);
                            Console.WriteLine("После Swap: " + string.Join(", ", words));
                            break;

                        case 4:
                            Console.WriteLine("Список строк: " + string.Join(", ", words));
                            Console.WriteLine("IsEmpty: " + words.IsEmpty());
                            break;

                        case 5:
                            Console.WriteLine("Пустой список: " + emptyWords.IsEmpty());
                            break;

                        case 0:
                            return;

                        default:
                            Console.WriteLine("Такого пункта нет.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введите номер пункта цифрой.");
                }
            }
        }
    }
}
