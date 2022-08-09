// **Задача**: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

namespace GeekBrains
{
    class Control_work
    {
        public static void Main(string[] args)
        {
            string[] originalArray = OriginalArray();
            
        }

        public static string[] OriginalArray()
        {
            string[] elementOriginalArray = new string [] {"hello", "2", "world", ":-)", "1234", "1567", "-2", 
                                                            "computer science", "Russia", "Denmark", "Kazan"};
            int sizeOriginalArray = new Random().Next(1, 12);

            string[] array = new string[sizeOriginalArray];

            Console.WriteLine("Размер исходного массива: " + sizeOriginalArray);
            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = elementOriginalArray[new Random().Next(elementOriginalArray.Length)];
            }
            return array; 
        }

    }
}


