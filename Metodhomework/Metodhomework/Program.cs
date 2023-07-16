

//2--(Verilmiş n - ədədinin 3 - ə və 7 - ə bölünüb - bölünməməsini tapın.)


//static void Devide()
//{
//    int n = 30;
//    if (n % 3 == 0 && n % 7 == 0)
//    {
//        Console.WriteLine("bolunur");
//    }
//    else
//    {
//        Console.WriteLine("bolunmur");
//    }
//}
//Devide();




//3---- (n və m ədədləri verilir.Əgər n və m ədədləri hər ikisi cütdürsə n və m ədədlərinin cəmini hesablayın.)


//static void Sum()
//{
//    int n = 6;
//    int m = 12;
//    int sum;
//    if (n % 2 == 0 && m % 2 == 0)
//    {
//        Console.WriteLine(sum = n + m);
//    }

//}

//Sum();




//4----(Verilmis n ve m(n < m) ededleri arasindaki tek ededlerin cemini tapin.)

//static void Sum()
//{
//    int n = 3;
//    int m = 12;
//    int sum = 0;
//    for (int i = n; i < m; i++)
//    {
//        if (i % 2 == 1)
//        {
//            sum += i;
//        }
//    }
//    Console.WriteLine(sum);
//}

//Sum();




//5----(Verilmish arrayin icindeki tek ededlerin cemini tapin.)

//static void Number()
//{
//    int[] nums = { 1, 3, 6, 9, 12, 14 };
//    int sum = 0;
//    foreach (var num in nums)
//    {
//        if (num % 2 == 1)
//        {
//            sum += num;
//        }
//    }
//    Console.WriteLine(sum);
//}

//Number();



//6-------- (Verilmish arrayin icindeki cut ededlerin sayini tapin.)

//static void Number()
//{
//    int[] nums = { 1, 3, 6, 9, 12, 14 };
//    int count = 0;
//    foreach (var num in nums)
//    {
//        if (num % 2 == 0)
//        {
//            count++;
//        }
//    }
//    Console.WriteLine(count);
//}

//Number();





//7------(Verilmis n ve m(n < m) ededleri arasindaki tek ededlerin sayini tapin.)


//static void Count()
//{
//    int n = 4;
//    int m = 16;
//    int count = 0;
//    for (int i = n; i < m; i++)
//    {
//        if (i % 2 == 1)
//        {
//            count++;
//        }
//    }
//    Console.WriteLine(count);
//}

//Count();




//8-----(Verilmis n ve m (n<m) ededleri arasindaki cut ededlerin cemini tapin.)

//static void Sum()
//{
//    int n = 3;
//    int m = 14;
//    int sum = 0;
//    for (int i = n; i < m; i++)
//    {
//        if (i%2==0)
//        {
//            sum += i;
//        }
//    }
//    Console.WriteLine(sum);

//}

//Sum();




//9-------(Verilmis n ve m (n<m) ededleri arasindaki cut ededlerin sayini tapin.)


//static void Sum()
//{
//    int n = 8;
//    int m = 26;
//    int count = 0;
//    for (int i = n; i < m; i++)
//    {
//        if (i%2==0)
//        {
//            count++;
//        }
//    }
//    Console.WriteLine(count);
//}

//Sum();



//10------(Verilmis n tam ededinin sade ve ya murekkeb oldugunu tapin.)

////static void Single()
////{
////    int n = 11;
////    int i;
////    int count = 0;
//    if (n<=0)
//    {
//        Console.WriteLine("duzgun eded daxil edin");

//    }
//    else
//    {
//        if (n==1)
//        {
//            Console.WriteLine("ne sadedir ne murekkeb");
//        }
//        else
//        {
//            for (i = 0; i < n; i++) ;
//            if (n %i == 0) 
//             count++;
//            else
//            {
//                if (count >= 2)
//                {
//                    Console.WriteLine("muekkebdir");
//                }
//                else 
//                {
//                    Console.WriteLine("sadedir");
//                }
//            }
//        }
//    }
//}
//Single();




//11------(n ededinin faktorialini hesablamaq.)

//static void Fact()
//{
//    int n = 6;
//    int multiply = 1;
//    for (int i = 1; i < n; i++)
//    {
//        multiply *= i;
//    }
//    Console.WriteLine(multiply);
//}

//Fact();