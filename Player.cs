using System;

public class Player
{
    public string name;
    public decimal money;
    public decimal archiveMoney;
    public bool IsPlayerDisposed = false;
    private Random rand = new Random();

    public Player(string name, int money)
    {
        this.name = name;
        this.money = money;
        archiveMoney = money;
        Console.WriteLine($"Игрок {name} в игре!");
    }
    public bool MakeBet(int betAmount, int numberToBetOn)
    {
        if (betAmount > 0 && betAmount <= money)
        {
            money -= betAmount;
            Console.WriteLine($"Ставка игрока {name} сделана, размер ставки: {betAmount}, текущий баланс: {money}");
            Thread.Sleep(1000);
            if (rand.NextDouble() < 0.5) { return true; }
            else
            {
                Console.WriteLine($"Ставка {name} к сожалению не сыграла");
            }
        }
        else
        {
            Console.WriteLine("Недостаточно средств для ставки");
        }
        return false;
    }
    public void DoubleMoney()
    {
        money *= 2;
        Console.WriteLine($"Ставка: {name} сыграла. Новый баланс: {money}");
        Thread.Sleep(1000);
    }
    public void LoseMoney()
    {
        money = 0;
        Console.WriteLine($"{name} вылетает из игры!");
        Thread.Sleep(1000);
    }
}