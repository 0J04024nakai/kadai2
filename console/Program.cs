// 最上位レベルのステートメントとなるらしく
// Mainメソッドが使用できなくそのため
// Console.ReadKey();等が使用出来ない
using System.Text;

//StringBuilder builder = new();
//テスト用の文章
// builder.AppendLine("Hello");
// builder.AppendLine("World!");
int i = 0;
// 1.2にはArgument=Program.cs   Argument=aaaが格納されている
//配列でコンソールの入力を受け取り表示する
if (args.Length > 0)
{
    foreach (var arg in args)
    {
        //Console.WriteLine(i);
        //1.2は要らないので3番目の値以降をとる
        if (i == 2)
        {
            Console.WriteLine($"{arg}さんこんにちは");
        }
        i++;
    }
    //int変換 名前の後に数字を2つ入れると足し算が行える
    // int x = int.Parse(args[3]);
    // int y = int.Parse(args[4]);
    // int a = x + y;
    // Console.WriteLine(a);
}
else
{
    Console.WriteLine("No arguments");
}