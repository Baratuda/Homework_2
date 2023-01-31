// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
int x=0;
//The loop WHILE allows you to re-enter the number if the user entered the number incorrectly.
while(x==0){
Console.Write("Please input number: ");
int number = int.Parse(Console.ReadLine());
if(number>99 && number<1000){
   int secondNumber = (number/10)%10;
   Console.Write("-------------------------------------------------------- \n");
   Console.Write($"Second number of the number {number} is {secondNumber} \n");
   Console.Write("-------------------------------------------------------- \n");
   break;
} else {
   Console.Write("-------------------------------------------------------- \n");
   Console.Write("Inputed number isn't three-digit, please try again \n");
   Console.Write("-------------------------------------------------------- \n");
   
}
}

