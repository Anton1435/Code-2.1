// сумма 9ти чисел стихийно

//int a1 = 15;
//int b1 = 21;
//int c1 = 39;
//int a2 = 12;
//int b2 = 23;
//int c2 = 13;
//int a3 = 23;
//int b3 = 53;
//int c3 = 453;

//int max = a1;
//if(b1 > max) max = b1;
//if(c1 > max) max = c1;
//if(a2 > max) max = a2;
//if(b2 > max) max = b2;
//if(c2 > max) max = c2;
//if(a3 > max) max = a3;
//if(b3 > max) max = b3;
//if(b1 > max) max = b1;
//if(c3 > max) max = c3;

//Console.WriteLine(max);


//  Решение функциями.
//int Max(int arg1,int arg2,int arg3)
//{
   // int result = arg1;
   // if(arg2>result) result = arg2;      // НАхождение мах из 3х чисел
   // if(arg3>result) result = arg3;
   // return result;
//}
//int a1 = 15;
//int b1 = 21;
//int c1 = 39;
//int a2 = 12;
//int b2 = 23222;
//int c2 = 13;
//int a3 = 23;
//int b3 = 53;
//int c3 = 453;

//int max1 = Max(a1,b1,c1);
//int max2 = Max(a2,b2,c2);
//int max3 = Max(a3,b3,c3);
//int max = Max(max1,max2,max3);

//int max = Max(Max(a1,b1,c1),Max(a2,b2,c2),Max(a3,b3,c3));  //способ одной строкой
//Console.WriteLine(max);


////////  Массив

//int Max(int arg1,int arg2,int arg3,int arg4,int arg5,int arg6,int arg7,int arg8,int arg9)
//{
   // int result = arg1;
   // if(arg2>result) result = arg2;      // НАхождение мах из 3х чисел
   // if(arg3>result) result = arg3;
   // return result;
//}
//int [] array = {11,42,53,74,54,67,71,8,39};
//array[0] = 12;   // Назначение числа в индекс
//int max = Max(array[0],array[1],array[2],array[3],array[4],array[5],array[6],array[7],array[8]);
//Console.WriteLine(max);


///////// Поиск позиций нужного нам элемента. Имется одномерный массив array из n элементов,требуется 
/////////  наити элемент массива, равный find.

//int[] array = {17,23,35,4,53,26,71,87};
//int n = array.Length;
//int find = 26;
//int index = 0;
//while( index < n)
//{
  //  if(array[index] == find)
    //{
      //  Console.WriteLine(index);
      //  break;
    //}
    //index++;
//}



///////////// рандомные числа.

//void FillArray(int[]collection)         /// метод заполнения масива

//{
   // int length = collection.Length;
    //int index = 0;
    //while(index < length)
    //{
     //   collection[index] = new Random().Next(1,10);
      //  index++;
    //}
//}

//void PrintArray(int[] col)    //// печать массива на экран
//{
  //  int count = col.Length;
  //  int position = 0;
  //  while(position < count)
   // {
     //   Console.WriteLine(col[position]);
       // position++;
    //}
//}

//int IndexOf(int[] collection,int find)
//{
  //  int count = collection.Length;
   // int index = 0;
    //int position = 0;

    //while(index < count)
    //{
      //  if(collection[index]== find)
       // {
        //    position = index;
         //   break;
        //}
        //index++;
    //}
    //return position;
//}

//int[] array = new int [10];

//FillArray(array);
//PrintArray(array);
//Console.WriteLine();

//int pos = IndexOf(array, 4);
//Console.WriteLine(pos);

