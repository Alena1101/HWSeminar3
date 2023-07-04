// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

 bool IsPalindrome( int number );
 {
    if (number < 0)
    {
        return false;
    }

    int RevNumber = 0;
    int TempSourseNumber = number;
    while (TempSourseNumber != 0)
    {
        int temp = TempSourseNumber % 10 ;
        RevNumber = (RevNumber * 10) + temp;
        TempSourseNumber = TempSourseNumber / 10;
    }


    if (RevNumber == number)
       return true;

    return false;
        
}
// ---------------------------------------------
Console.WriteLine(IsPalindrome (number: 12321));