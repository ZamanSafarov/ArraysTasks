

#region Task1
//Array'dəki ən kiçik elementi tapıb ekrana yazdırın.
//int[] arr = { 154, 78, 3, 55, 90 };

//int lowestNum = arr[0];

//Console.WriteLine(arr.Min()); //qısa yol

//for (int i = 0; i < arr.Length; i++)
//{

//    if (arr[i] < lowestNum)
//    {
//        lowestNum = arr[i];
//    }
//}

//Console.WriteLine(lowestNum);



#endregion


#region Task2
//Array'in içərisindəki sözləri tərsinə çevirən bir alqoritm yazın.

//string[] arr = ["salam", "sagol", "necesen", "yaxsiyam"];


//for (int i = 0; i < arr.Length; i++)
//{
//    for (int j = arr[i].Length; j > 0; j--)
//    {
//        Console.Write($"{arr[i][j - 1]}");
//    }
//    Console.WriteLine();
//}


#endregion

#region Task3
//3.Array'in içərisindəki sözlərin sırasını tərsinə çevirən bir alqoritm yazın.

//string[] arr = ["salam", "sagol", "necesen", "yaxsiyam"];

//for (int i = arr.Length; i > 0; i--)
//{
//    Console.Write($"{arr[i - 1]},");
//}
#endregion

#region Task4
//4. Verilmiş integer array-in  bütün elementlərini müsbətə çevirib yeni bir array'ə tərsinə yığın və ekrana çap edin.
//Məsələn, {-2,3,4,-5} verilibsə, {5,4,3,2} almalıyıq cavab olaraq.

//int[] arr = { -2, 3, 4, -5 };

//int[] newArr = new int [4];


//for (int i = 0; i < arr.Length; i++)
//{
//   // Math.Abs(arr[i]);// qisa yol
//    if (arr[i] < 0)
//    {
//        arr[i] *= -1;
//    }
//}
//for (int i = 0; i < arr.Length; i++)
//{
//    newArr[i]= arr[i];

//}
//for (int i = newArr.Length; i >0 ; i--)
//    Console.Write($"{newArr[i - 1]} ");


#endregion

#region Task5
//5. Verilmiş integer array-in  bütün elementlərini stringə çevirib ekrana çap edin.
//Məsələn, {-2,3,4,-5} verilibsə, "-2 3 4 -5" çapa verilməlidir. (optional)

//int[] arr = { -2, 3, 4, -5 };

//for (int i = 0; i < arr.Length; i++)
//{
//    Console.Write(arr[i].ToString());
//}

#endregion