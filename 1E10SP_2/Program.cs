
Console.WriteLine("Hello, World!");
int[] Ary1 = { 1, 2, 3, 4, 5, 6, 7 };
int[] Ary2 = { 0, 0, 0, 0, 0, 0, 0 };

Console.WriteLine("初期値:");
Console.WriteLine("Ary1: " + string.Join(", ", Ary1));
Console.WriteLine("Ary2: " + string.Join(", ", Ary2));

for (int i = 0; i < Ary1.Length; i++)
{
    Ary2[i] = Ary1[Ary1.Length - 1 - i];
}

Console.WriteLine("Ary1: " + string.Join(", ", Ary1));
Console.WriteLine("Ary2: " + string.Join(", ", Ary2));
    