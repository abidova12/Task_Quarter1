﻿int n = 10;   //объявляем массив из целых чисел, длина которого 10
int[] arr = new int[n]; 

Random r = new Random(); //объявляем генератор случайных чисел

     
        for (int i = 0; i < n; i++) //цикл заполнения массива
        {
            arr[i] = r.Next(0, 30); // присваиваем случайное число от 0 до 30 и выводим на экран
            Console.Write(arr[i] + " ");     
        }       
            Console.Write(" -> ");

        for (int i = 0; i < n; i++) //цикл заполнения массива
        {
            if(arr[i] % 2 == 0) //если элемент массива четный, то выводим его на экран:
            Console.Write(arr[i] + " ");
        }

