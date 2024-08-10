//問題 5
//次の要件を満たすインターフェースIDriveableとクラスBicycleを定義してください。

//IDriveableインターフェースは、Driveメソッドを持つ。
//BicycleクラスはIDriveableインターフェースを実装し、Driveメソッドを実装する。このメソッドは「Bicycle is being driven」と表示する。

interface IDriveable
{
    void Drive();
}

class Bicycle : IDriveable
{
    public void Drive()
    {
        Console.WriteLine("Bicycle is being driven");
    }
}