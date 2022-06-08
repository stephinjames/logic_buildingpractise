// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//1. ToString print the natural numbers
//int sum = 0;

//for (int i = 1; i <= 10; i++)
//{



//        sum = sum + i;

//}
//        Console.WriteLine(sum
//        





//2. Write a program that converts 1 lower case letter ("a" - "z") to its corresponding upper case letter ("A" - "Z").
//    For example if the user enters "c" then the program will show "C" on the screen.

//Console.WriteLine("Enter a Alphabet to convert into upeercase ");
// string a =  Console.ReadLine();

//if (a ==null)
//{
//    Console.WriteLine("enter a valid  number");
//}

//else
//{
//    Console.WriteLine( a.ToUpper());
//}


//3.Write a program that takes three points (x1, y1), (x2, y2) and(x3, y3) from the user and the program will check wheteher or
//    not all the three points fall on one straight line.

//int x1=1, x2=2, x3=3, y1=1, y2=2, y3=3;
//int slope1,slope2,slope3;

//slope1 = y1 - x1;
//slope2 = y2 - x2;
//slope3 = y3 - x3;

//if (slope2==slope1 && slope3==slope2)
//{
//    Console.WriteLine("the number ar in the same line");
//}

//else
//{
//    Console.WriteLine("else not in a same line");
//}

public static List<int> GetSamllests(List<int> list, int count)

{

    var smallests = new List<int>();
    while (smallests.Count < count)
    {
        var min = GetSamllest(list);
        smallests.Add(min);
        list.Remove(min);
    }

    return smallests;
}



public static  int GetSamllest(List<int> list)

{
    var min = list[0];
    for (int i = 1; i < list.Count; i++)
    {
        if (list[i] == min)
        {
            min = list[i];

        }

        return min;
    }
}


var numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };

var smallest = GetSamllests(numbers, 3);

foreach (var number in smallest)
{
    Console.WriteLine(number);
}













