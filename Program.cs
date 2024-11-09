namespace DzMutexSemaphores
{
    internal static class Program
    {
        static Mutex[] mutexes = new Mutex[3];
        [STAThread]
        static void Main()
        {
            for (int i = 0; i < mutexes.Length; i++)
            {
                mutexes[i] = new Mutex(true, $"LimitMutex1{i}");
                if (mutexes[i].WaitOne(0)) break;
                if (i == mutexes.Length - 1)
                {
                    MessageBox.Show("Приложение уже запущено в трех экземплярах.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            foreach (var mutex in mutexes)
                mutex.ReleaseMutex();
        }
    }
}