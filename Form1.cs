using System.IO;
using System.Threading;

namespace DzMutexSemaphores
{
    public partial class Form1 : Form
    {
        private Mutex mutex1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void StartThreads(object sender, EventArgs e)
        {
            Thread thread1 = new Thread(GenerateRandomNumbers);
            Thread thread2 = new Thread(ProcessNumbers);
            Thread thread3 = new Thread(ProcessNumbersEndingWith7);
            mutex1 = new Mutex();
            thread1.Start();
            thread2.Start();
            thread3.Start();
        }
        private void GenerateRandomNumbers()
        {
            try
            {
                string path = "randomNumbers.txt";
                List<int> numbers = new List<int>();
                for (int i = 0; i < 100; i++)
                {
                    numbers.Add(new Random().Next(1, 1000));
                }
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                Thread.Sleep(1000);

                using (FileStream fs = new FileStream(path, FileMode.CreateNew,FileAccess.Write))
                {
                    using(StreamWriter sw = new StreamWriter(fs))
                    {
                        foreach(var i in numbers)
                        {
                            sw.WriteLine(i);
                        }
                    }
                }
            }
            catch(Exception e) { MessageBox.Show(e.Message, "", MessageBoxButtons.OK,MessageBoxIcon.Error); }
            finally { mutex1.ReleaseMutex(); }
        }
        private void ProcessNumbers()
        {
            mutex1.WaitOne();
            try
            {
                string path = "easyNumbers.txt";

                List<int> numbers = File.ReadAllLines("randomNumbers.txt").Select(int.Parse).ToList();
                List<int> easyNumbers = numbers.Where(x=>IsEasyNumber(x)).ToList();

                if(File.Exists(path))
                {
                    File.Delete(path);
                }
                Thread.Sleep(1000);

                using (FileStream fs = new FileStream(path, FileMode.CreateNew, FileAccess.Write))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        foreach (var i in easyNumbers)
                        {
                            sw.WriteLine(i);
                        }
                    }
                }
            }
            catch(Exception e) { MessageBox.Show(e.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { mutex1.ReleaseMutex(); }
        }
        private void ProcessNumbersEndingWith7()
        {
            mutex1.WaitOne();
            try
            {
                string path = "easyNumbers.txt";
                string path2 = "easyNumbersWithSeven.txt";
                List<int> easyNumbers = File.ReadAllLines(path).Select(int.Parse).ToList();
                List<int> numbersEndingWithSeven = easyNumbers.Where(n => n % 10 == 7).ToList();
                if (File.Exists(path2))
                {
                    File.Delete(path2);
                }
                Thread.Sleep(1000);

                using (FileStream fs = new FileStream(path2, FileMode.CreateNew, FileAccess.Write))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        foreach (var i in numbersEndingWithSeven)
                        {
                            sw.WriteLine(i);
                        }
                    }
                }
            }
            catch (Exception e) { MessageBox.Show(e.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { mutex1.ReleaseMutex(); }
        }
        private bool IsEasyNumber(int number)
        {
            if (number <= 1) return false;
            else return true;
        }
    }
}
