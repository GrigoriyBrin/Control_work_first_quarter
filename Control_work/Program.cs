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

            Console.WriteLine("Исходный массив: ");
            PrintArray(originalArray);
            Console.WriteLine();
            
            int sizeNewArray = SizeNewArray(originalArray);
            if (sizeNewArray == 0)
            {
                Console.WriteLine();
                Console.WriteLine("В исходном массиве все элементы содержат более 3-х символов");
                Console.WriteLine();
            }
            else
            {
                string[] resultArray = ArrayOfUpToThreeSymbols(originalArray, sizeNewArray);
                Console.WriteLine("Отсортированный массив:" );
                PrintArray(resultArray);
                Console.WriteLine(); 
            }
            
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

        public static int SizeNewArray(string[] arr)
        {
            int count = 0;
            int limitation = 3;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length <= limitation)
                {    
                    count++;
                }
            }
            Console.WriteLine("Количество элементов исходного массива с 3-мя и менее символами: " + count);
            Console.WriteLine();

            return count; 
        }

        public static string[] ArrayOfUpToThreeSymbols(string[] arr, int sizeNewArray)
        {
            string[] array = new string[sizeNewArray];
            int index = 0;
            int limitation = 3;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length <= limitation)
                {    
                    array[index] = arr[i];
                    index++;
                }
            }
            return array; 
        }

        public static void PrintArray(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        } 

    }
}


