int[] arr = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
string[] cities = new string[10] { "Barcelona", "Moscow", "Prague", "Paris", "London", "Sochi", "Berlin", "Amsterdam", "Minsk", "Milan"};
//Получить весь масcив целых
//var task1 = from i in arr select i; // LINQ
//var task1 = arr.Select(x => x); // Extention method

//foreach (var i in task1)
//{
//  Console.Write(i + "\t");
//}



// Получить четные целые
//var task2 = from i in arr
//            where i%2==0
//            select i;

//var task2 = arr.Where(i=>i%2==0);

//foreach (var i in task2)
//{
//    Console.Write(i + "\t");
//}


// Получить нечетные целые

// var task3 = from i in arr
// where i % 2 != 0
// select i;

// var task3 = arr.Where(i => i % 2 != 0);

// foreach (var i in task3){
//     Console.Write(i + "\t");
// }



// Получить значения больше заданного
// int num = 6;

// var task4 = from i in arr
// where i > num
// select i;

// var task4 = arr.Where(i => i > num);
// foreach (var i in task4){
//     Console.Write(i + "\t");
// }



// Получить числа в заданном диапазоне
// int min = 0;
// int max = 5;

// var task5 = from i in arr
// where i > min && i < max
// select i;

// var task5 = arr.Where(i => i > min && i < max);
// foreach (var i in task5){
//     Console.Write(i + "\t");
// }

// Получить числа кратные семи. Результат отсортировать по
//возрастанию
// var task6 = from i in arr
// where i % 7 == 0
// orderby i
// select i;

// var task6 = arr.Where(i => i % 7 == 0).OrderBy(i => i);

// foreach (var i in task6){
//     Console.Write(i + "\t");
// }



// Получить числа кратные восьми. Результат отсортировать
//по убыванию

// var task7 = from i in arr
// where i % 8 == 0
// orderby i descending
// select i;

// var task7 = arr.Where(i => i % 8 == 0).OrderByDescending(i => i);

// foreach (var i in task7){
//     Console.Write(i + "\t");
// }


//  Получить весь масcив городов

// var task8 = from c in cities select c;
// var task8 = arr.Select(c => c);


            // foreach (var s in cities)
            // {
              
            //         Console.Write(s + "\t");
            // }



//  Получить города с длиной названия равной заданному
// int length = 8;
// var task9 = from c in cities where c.Length == length select c;
// var task9 = cities.Where(c => c.Length == length);

// foreach(var c in task9){
//       Console.Write(c + "\t");
// }


//  Получить города названия, которых начинается с буквы A

// var task10 = from c in cities where c.ToUpper().StartsWith("А") select c;
// var task10 = cities.Where(c => c.ToUpper().StartsWith("А"));

// foreach(var c in task10){
//       Console.Write(c + "\t");
// }

//  Получить города названия, которых заканчивается на букву M

// var task11 = from c in cities where c.ToUpper().EndsWith("M") select c;
// var task11 = cities.Where(c => c.ToUpper().EndsWith("M"));

// foreach(var c in task11){
//       Console.Write(c + "\t");
// }



//  Получить города названия, которых начинаются на N и
// заканчиваются на букву K

// var task12 = from c in cities where c.ToUpper().StartsWith("N") && c.EndsWith("K") select c;
// var task12 = cities.Where(c => c.ToUpper().StartsWith("А") && c.EndsWith("K"));

// foreach(var c in task12){
//       Console.Write(c + "\t");
// }

//  Получить города названия, которых начинаются на Ne.
// Результат отсортировать по убыванию

// var task13 = from c in cities where c.ToUpper().StartsWith("Ne") orderby c descending select c;
// var task13 = cities.Where(c => c.ToUpper().StartsWith("Ne")).OrderByDescending(c => c);

// foreach(var c in task13){
//       Console.Write(c + "\t");
// }