Console.WriteLine("Введите трехзначное число");
String number = Console.ReadLine();
int a = Convert.ToInt32(number);
if(a>99 && a<1000)
{
    int thirdDigit = a%10;
    a = a - thirdDigit;
    a = a/10;
    a = a%10; 
    Console.WriteLine($"Вторая цифра {a}");    
}
else
{
    Console.WriteLine("Вы ввели нетрехзначное Число");
}