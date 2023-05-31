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
/*
 *Ary1 を {1, 2, 3, 4, 5, 6, 7} で初期化する
Ary2 を {0, 0, 0, 0, 0, 0, 0} で初期化する
表示 "実行前のAry1の内容: " と Ary1 を連結して表示する
表示 "実行前のAry2の内容: " と Ary2 を連結して表示する

i を 0 から Ary1 の長さ -1 まで繰り返す {
Ary2[i] を Ary1[Ary1 の長さ -1 - i] にする
}

表示 "実行後のAry1の内容: " と Ary1 を連結して表示する
表示 "実行後のAry2の内容: " と Ary2 を連結して表示する
