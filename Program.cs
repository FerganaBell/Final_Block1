 void Main()
{ 
// Вводим исходный массив строк с клавиатуры 
        Console.WriteLine("Введите элементы массива через пробел:");
        string input = Console.ReadLine();
        string[] InitialArray = input.Split(' ');

  // Считаем количество строк, длина которых меньше или равна 3 символам
        int count = 0;
        for (int i = 0; i < InitialArray.Length; i++)
        {
            if (InitialArray[i].Length <= 3)
            {
                count++;
            }
        }
 // Создаем новый массив c определенной длиной
        string[] ResultArray = new string[count];

        // Заполняем новый массив
        int index = 0;
        for (int i = 0; i < InitialArray.Length; i++)
        {
            if (InitialArray[i].Length <= 3)
            {
                ResultArray[index] = InitialArray[i];
                index++;
            }
        }

       
}

Main();
