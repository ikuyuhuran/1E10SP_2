int[] Ary1 = { 1, 2, 3, 4, 5, 6, 7 };
int[] Ary2 = { 0, 0, 0, 0, 0, 0, 0 };

Console.WriteLine("実行前のAry1の内容: " + string.Join("", Ary1));
Console.WriteLine("実行前のAry2の内容: " + string.Join("", Ary2));

for (int i = 0; i < Ary1.Length; i++)
{
    Ary2[i] = Ary1[Ary1.Length - 1 - i];
}

Console.WriteLine("実行後のAry1の内容: " + string.Join("", Ary1));
Console.WriteLine("実行後のAry2の内容: " + string.Join("", Ary2));
    