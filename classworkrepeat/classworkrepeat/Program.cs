

//int n = 18;
//if (n%3==0 && n%7==0)
//{
//    Console.WriteLine("bolunur");
//}
//else
//{
//    Console.WriteLine("bolunmur");
//}


//int n = 10;
//int m = 15;
//int sum = 0;
//if (n%2==0 && m%2==0)
//{
//    sum = n + m;
//}
//Console.WriteLine(sum);





//int n = 10;
//int m = 20;
//int sum = 0;

//for (int i = n; i < m; i++)
//{
//    if (i%2==1)
//    {
//        sum += i;
//    }
//}
//Console.WriteLine(sum);




//int[] nums = { 1, 2, 11, 55, 23, 4, 6 };
//int sum = 0;
//foreach (var num in nums)
//{
//    if (num%2!=0)
//    {
//        sum += num;
//    }
//}
//Console.WriteLine(sum);



//int[] nums = { 1, 3, 5, 6, 9 };
//int count = 0;
//foreach (var item in nums)
//{
//    if (item%2==0)
//    {
//        count++;
//    }
//}
//Console.WriteLine(count);


//static void Sum()
//{
//    int a = 100;
//    int b = 200;
//    int sum = a+b;
//    Console.WriteLine(sum);
//}
//Sum();




//static void ShowDatas()
//{
//    string fullName = "Kubra Memmedova";
//    string emeil = "kubra@code.edu.az";
//    string fullData = $"{fullName}  ---- {emeil}";

//    ShowAge();

//    Console.WriteLine(fullData);

//}
//ShowDatas();



//static void ShowAge()
//{
//    Welcome();
//    int age = 25;
//    Console.WriteLine(age);
//}



//static void Welcome()
//{
//    Console.WriteLine("Welcome Kubra");
//}



//static void SomeItemsOfArray()
//{
//    int[] arr = { 1, 2, 3, 4, 5,};
//    int sum = 0;
//    foreach (var item in arr)
//    {
//        sum += item;
//    }
//    Console.WriteLine(sum);
//}
//SomeItemsOfArray();



//static void SearchByName()
//{
//    string[] people = { "Sharaf","Pervin","Cahangir","Huseyin" };
//    string searchText = "Pervin";
//    foreach (var person in people)
//    {
//        if (person == searchText)
//        {
//            Console.WriteLine(person);
//            break;

//        }


//        if (person == "Cahangir");
//        {
//            Console.WriteLine(person);
//            return;
//        }
//    }
//    Console.WriteLine("Method is working");
//}
//SearchByName();



//static void Sum(int number1, int number2)
//{
//    int sum= number1 + number2;
//    Console.WriteLine(sum);
//}

//Sum(5, 9);



//bool isMarried = false;
//static void Showtext(string text, int num)
//{
//    Console.WriteLine(text + "--" +num);
//}
//if (isMarried)
//{
//    Console.WriteLine("Evlidir");

//}

//string str = "Hello P139";
//int number = 55;

//Showtext(str, number);




//static void Login(string username, string password)
//{
//    if (username == "samir555" && password == "Samir123_")
//    {
//        Console.WriteLine("Login successed");
//    }
//    else
//    {
//        Console.WriteLine("Username or password is wrong");
//    }
//}

//Console.WriteLine("Add your username");
//string username = Console.ReadLine();

//Console.WriteLine("Add your password");
//string password = Console.ReadLine();

//Login(username, password);



//Console.WriteLine("Add your name:");
// string name = Console.ReadLine();

//Console.WriteLine(name);





//Console.WriteLine("Add first number:");
//int number1 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Add second number:");
//int number2 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("___________");
//SumNumbers(number1, number2);



//static void SumNumbers(int a , int b)
//{
//    int sum = a + b;
//    Console.WriteLine(sum);
//}






//static string ShowName()
//{
//    return  "Samir";
//}

//string result = ShowName();
//Console.WriteLine(result);





//static void Sum(int a , int b)
//{
//    Console.WriteLine(a+b);
//}



//static int Sum(int a ,int b)
//{
//    return a + b;
//}

//int a = 5;
//int b =30;

//int result = Sum(a,b);

//Console.WriteLine(result);





//static int GetSumOfNumbersFromArray(int[] array)
//{
//    int sum = 0;

//    foreach (var item in array)
//    {
//        sum += item;
//    }
//    return sum;
//}

//int[] array = { 1, 2, 3, 4, 5, 6 };
//int result = GetSumOfNumbersFromArray(array);
//Console.WriteLine(result);




//static bool CheckWeekDayIfSunday(string weekDay)
//{
//    bool isSunday = false;

//	switch (weekDay)
//	{
//		case "Saturday":
//			isSunday = false;
//			break;
//		case "Monday":
//			isSunday = false;
//			break;
//		case "Tuesday":
//			isSunday = false;
//			break;
//		case "Sunday":
//			isSunday = true;
//			break;
//		case "Thrusday":
//			isSunday = false;
//			break;
//		case "Friday":
//			isSunday = false;
//			break;
//		case "Wednesday":
//			isSunday = false;
//			break;
//	}
//	return isSunday;
//}


//bool result = CheckWeekDayIfSunday("Sunday");
//ShowWeekDay(result);



//static void ShowWeekDay(bool isSunday)
//{

//    if (isSunday)
//    {
//        Console.WriteLine("yes . Today is Sunday");
//    }
//    else
//    {
//        Console.WriteLine("no. Today is not Sunday");
//    }
//}