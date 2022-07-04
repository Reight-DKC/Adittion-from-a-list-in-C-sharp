Console.WriteLine("Array Loop!");

Console.Write("Ingrese la cantidad de números: ");
string amount = Console.ReadLine() ?? "0";
int size = Int32.Parse(amount);
int [] numbers = new int [size];
//int[] numbers = new int[Int32.Parse(Console.ReadLine() ?? "0")];

for (int i = 0; i < size; i++)
{ 
 Console.Write("Ingrese un nuúmero: ");
 string input = Console.ReadLine() ?? "0";
 numbers[i] = Int32.Parse(input);
}

int total = 0;
for (int i = 0; i < size; i++)
{ 
  total = total + numbers[i];
}


for (int i = 0; i < size; i++)
{ 
Console.WriteLine(numbers[i]);
}

Console.WriteLine("Total: " + total);