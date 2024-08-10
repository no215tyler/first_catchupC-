//問題 7
//次のコードを作成し、指定の例外が発生した場合に適切なエラーメッセージを表示するようにしてください。

//ユーザーに2つの数値を入力させ、それを整数に変換します。
//最初の数値を2番目の数値で割り、その結果を表示します。
//例外が発生する可能性のあるケース:
//数値以外を入力した場合(FormatException)
//0で割ろうとした場合(DivideByZeroException)
using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("1つ目の整数を入力してください");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("2つ目の整数を入力してください");
            int num2 = int.Parse(Console.ReadLine());
            int result = num1 / num2;
            Console.WriteLine($"結果: {result}");
        }
        catch(FormatException error)
        {
            Console.WriteLine($"数値を入力してください: {error.Message}");
        }
        catch(DivideByZeroException error)
        {
            Console.WriteLine($"0で割ることはできません: {error.Message}");
        }
        finally
        {
            Console.WriteLine("処理が終了しました");
        }
    }
}