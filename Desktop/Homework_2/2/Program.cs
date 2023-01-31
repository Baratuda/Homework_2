// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
int x=0;
//The loop WHILE allows you to re-enter the number if the user entered the number incorrectly.
while(x==0){
  Console.Write("Please input number of the day of the weak: ");
  int dayOfWeak = int.Parse(Console.ReadLine());
  if(dayOfWeak>0 && dayOfWeak<8){
    if(dayOfWeak==6 || dayOfWeak==7){
      Console.Write("-------------------------------------------------------- \n");
      Console.Write($"The day number {dayOfWeak} corresponds to the day off \n");
      Console.Write("-------------------------------------------------------- \n");
      break;
    }
    Console.Write("-------------------------------------------------------- \n");
    Console.Write($"The day number {dayOfWeak} dosen't corresponds to the day off \n");
    Console.Write("-------------------------------------------------------- \n");
    break;
  } else {
    Console.Write("-------------------------------------------------------- \n");
    Console.Write("Inputed number have to less than 8 and more then 0 \n");
    Console.Write("-------------------------------------------------------- \n");
  }
}
