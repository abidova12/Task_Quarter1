# Решение итогового задания

## 1. Объявляем массив из целых чисел, размер которого составляет 10 значений:
int n = 10;  
int[] arr = new int[n]; 

## 2. Объявляем генератор случайных чисел:
Random r = new Random(); 

## 3. Составляем цикл заполнения массива:
        for (int i = 0; i < n; i++)
        
## 4. Присваиваем случайное число от 0 до 30 и выводим результат на экран:
        {
            arr[i] = r.Next(0, 30); // 
            Console.Write(arr[i] + " ");     
        }       
            Console.Write(" -> ");

## 5. Снова указываем цикл заполнения массива:
        for (int i = 0; i < n; i++) 
            
## 6. Вводим дополнительное условие - если элемент массива четный, то выводим его на экран:
        {
            if(arr[i] % 2 == 0) //:
            Console.Write(arr[i] + " ");
        }
