using System.Threading;

namespace DzMutexSemaphores
{
    public partial class Form1 : Form
    {
        private Semaphore semaphore = new Semaphore(3, 3);
        private List<ListBox> list;
        public Form1()
        {
            InitializeComponent();
            list = new List<ListBox>()
            {
                listBox1,
                listBox2,
                listBox3,
                listBox4,
                listBox5,
                listBox6,
                listBox7,
                listBox8,
                listBox9,
                listBox10
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void StartThreads(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();
            listBox7.Items.Clear();
            listBox8.Items.Clear();
            listBox9.Items.Clear();
            listBox10.Items.Clear();
            for(int i =0;i<list.Count;i++)
            {
                ThreadPool.QueueUserWorkItem(Thread1, i);
            }
        }
        private void Thread1(object listIndex)
        {
 
            
            semaphore.WaitOne();
            try
            {
                list[(int)listIndex].Items.Add("Поток: "+ (int)listIndex);
                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(100);
                    list[(int)listIndex].Items.Add(new Random().Next(100, 1000));
                }
            }
            finally
            {
                semaphore.Release();
            }
        }
    }
}
