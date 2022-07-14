Console.WriteLine("Введите числа через запятую: ");
string originString = Convert.ToString(Console.ReadLine());

int count = 0;
 
int size = 0;

for(int i = 0; i < originString.Length; i++)
{
         if(originString[i] == ',')
         {
           size++;
           
         }
}
            
int j = 0;

string tempString = "";

int[] array = new int[size+1];

for(int i = 0; i < originString.Length; i++)
{
        if(originString[i] != ',')
         {
           tempString += originString[i];
         }
         else
         {
            array[j] = Convert.ToInt32(tempString);
            tempString = "";
            j++;
         }
          if(i == originString.Length-1)
         {
            
            array[j] = Convert.ToInt32(tempString);
         }
}


for(int i = 0; i < array.Length; i++)
{
    if(array[i] > 0)
    {
       count++;
    }
}



Console.WriteLine("Колличество чисел больше нуля равно " + count);






