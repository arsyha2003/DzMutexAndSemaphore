using System;
using System.Drawing.Drawing2D;
using System.Numerics;
using System.Threading;

public class CasinoTable
{
    private Semaphore semaphore = new Semaphore(5,5);
    private bool isGameDisposed = false;
    private Player[] players = new Player[5];
    private Thread[] threads = new Thread[5];
    private int counter = 5;
    private List<string> pls = new List<string>();
    public void StartGame()
    {
        new Thread(() => AwaitLog()).Start();
        for (int i = 0; i < 5; i++)
        {
            Player player = new Player($"Player {i + 1}", new Random().Next(100, 500));
            semaphore.WaitOne();
            players[i] = player;
            threads[i] = new Thread(()=>RunPlayerGame(player));
            Thread.Sleep(300);
        }
        foreach(var thread in threads)
        {
            thread.Start();
        }
    }
    public void RunPlayerGame(Player tmp)
    {
        pls = new List<string>();
        Player player = tmp;
        while (counter < 21)
        {
            Random rand = new Random();
            int betAmount = rand.Next(10, 50);
            int numberToBetOn = rand.Next(1, 37); 
            counter++;
            if (player.MakeBet(betAmount, numberToBetOn))
            {
                player.DoubleMoney();
            }
            else
            {
                player.LoseMoney();
                pls.Add($"{player.name} {player.archiveMoney} {player.money}");
                player = new Player($"Player {counter}", new Random().Next(100, 500));
            }
            Thread.Sleep(1000);
        }
        DisposeGame();
        Thread.CurrentThread.Join();
    }
    public void AwaitLog()
    {
        while (isGameDisposed == false)
        {
            continue;
        }
        if (File.Exists("LogFile.txt"))
        {
            File.Delete("LogFile.txt");
        }
        using (FileStream fs = new FileStream("LogFile.txt", FileMode.CreateNew, FileAccess.Write))
        {
            using (StreamWriter sw = new StreamWriter(fs))
            {
                foreach (var i in pls)
                {
                    sw.WriteLine(i);
                }
            }
        }

    }
    public void DisposeGame()
    {
        semaphore.Dispose();
        isGameDisposed = true;
    }
}
