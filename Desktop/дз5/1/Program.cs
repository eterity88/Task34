// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.


            
        int[] arr = new int[5];
        int counter = 0;
       
        Random rnd = new Random();
        
        for (int i = 0; i<5; i++)
        {
            arr[i] = rnd.Next(100,999);
            Console.WriteLine(i + " " + arr[i] + "\n");
           if(arr[i] % 2 == 0){
               counter++;
           }
        }
  Console.WriteLine("количество четных элементов " + counter);
