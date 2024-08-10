//問題 6
//次の要件を満たす抽象クラスAnimalと、その派生クラスCatを定義してください。

//AnimalクラスはNameプロパティと、MakeSoundという抽象メソッドを持つ。
//CatクラスはAnimalクラスを継承し、MakeSoundメソッドをオーバーライドして「Cat meows」と表示する。

class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine($"【{Name}】: Cat meows");
    }
}