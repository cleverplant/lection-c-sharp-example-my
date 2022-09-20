/*
Сначала определим новый массив. 
Пусть это будет массив под именем array. 
Далее укажем, что в этом массиве будет по умолчанию 10 элементов. 
Запомним новую конструкцию new int [10], которая означает «создай новый массив, 
где будет 10 элементов». По умолчанию он будет наполнен нулями.
*/
//  int[] array = new int[10]; 

// метод заполнения массива - FillArray/ (заполяем с помощью Random().Next(1, 10);)
void FillArray(int[] collection) //аргумент collection
{
    int length = collection.Length; //получить длину нашего массива
    int index = 0;
    while (index < length)
    {   /*После этого обратимся к аргументу collection на позицию index 
          и положим туда новое случайное число — целое число из диапазона 1–10.*/
        collection[index] = new Random().Next(1, 10);
        //index = index + 1;
        index++;
    }
}
// метод void - PrintArray, который будет печатать массив
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}
/*
попробуем адаптировать решение предыдущей задачи, в которой находили нужные элементы 
и позицию нужного элемента в массиве.
Для этого потребуется описать метод, отличный от void. 
Он будет возвращать позицию, то есть index. Назовём этот метод IndexOf, 
а в качестве аргумента будет приходить массив collection и какой-то элемент find.
*/
int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
array[4] = 4;
array[6] = 4;

PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 444);
Console.WriteLine(pos);

/*    --- VOID ---
в контексте языка С# есть методы, которые могут возвращать или не возвращать какие-то значения. 
Если метод ничего не возвращает, он называется void-методом. 
в этом случае в коде оператор return,не используется.
*/




