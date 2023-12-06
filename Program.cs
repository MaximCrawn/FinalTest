// Урок 1. Контрольная работа
// Данная работа необходима для проверки ваших знаний и навыков по итогу прохождения первого блока обучения на программе Разработчик. 
// Мы должны убедится, что базовое знакомство с IT прошло успешно.
// Задача алгоритмически не самая сложная, однако для полноценного выполнения проверочной работы необходимо:
// 1. Создать репозиторий на GitHub
// 2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
// 3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
// 4. Написать программу, решающую поставленную задачу
// 5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум 
// этапы 2, 3, и 4 должны быть расположены в разных коммитах)
//  Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []






string [] DataInput (int size, string [] array)
{
    for (int i = 0; i < size; i++)
    {
    System.Console.Write("Введите строку: ");
    array[i] = Console.ReadLine();
    }
    return array; 
}

string [] SortingArray (string [] array)
{ 
    int ResultSize = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            ResultSize++;
        }
    }
    string [] ResultArray = new string [ResultSize];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            ResultArray[j] = array[i];
            j++;
        }
    }
    
    return ResultArray;
}

void PrintArray (string[] array, string [] ResultArray)
{
    if(ResultArray.Length != 0)
    {
        for (int i = 0; i < array.Length-1; i++)
        {
            System.Console.Write(array[i] + "," + " ");
        }
        System.Console.Write($"{array[array.Length-1]} -> ");
        
        for (int i = 0; i < ResultArray.Length-1; i++)
        {
            System.Console.Write(ResultArray[i]);
        }
        System.Console.Write(ResultArray[ResultArray.Length-1]);
        System.Console.WriteLine();
    }
    else
    {
        for (int i = 0; i < array.Length-1; i++)
        {
            System.Console.Write( array[i] + "," + " ");
        }
        System.Console.Write($"{array[array.Length-1]} -> ");
        System.Console.Write("[" + "]");

    }
}

System.Console.Write("Сколько строк хотите ввести?: ");
int size = Convert.ToInt32(Console.ReadLine());
string [] array = new string [size];

PrintArray(DataInput(size, array), SortingArray(array)); 
