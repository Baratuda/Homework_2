// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6



Console.Clear();
int x=0;
int thirdNumber=0;
int intNum=0;

//The loop WHILE allows you to re-enter the number if the user entered the number incorrectly.
while(x==0){
   Console.Write("Please input number: ");
   int number = int.Parse(Console.ReadLine());
   if(number!=0){
      if(number>99){
         for(int i=10; number/i>=10; i*=10)
         intNum = i;
         thirdNumber = ((number % intNum) - (number % (intNum/10)))/(intNum/10);
      } else if(number>99){
         Console.Write("-------------------------------------------------------- \n");
         Console.Write("The inputed number haven't to be less than 100 \n");
         Console.Write("-------------------------------------------------------- \n");
      }
      if(number<-99){
         for(int i=10; number/i<=-10; i*=10)
         intNum = i;
         thirdNumber = ((number % intNum) - (number % (intNum/10)))/(-intNum/10);
      } else if(number<-99){ 
         Console.Write("-------------------------------------------------------- \n");
         Console.Write("The inputed number haven't to be more than -100 \n");
         Console.Write("-------------------------------------------------------- \n");
      }
      Console.Write("-------------------------------------------------------- \n");
      Console.Write($"Third number of the number {number} is {thirdNumber} \n");
      Console.Write("-------------------------------------------------------- \n");
      break;
   } else {
      Console.Write("-------------------------------------------------------- \n");
      Console.Write("The inputed number haven't to be zero \n");
      Console.Write("-------------------------------------------------------- \n");
   }
}

