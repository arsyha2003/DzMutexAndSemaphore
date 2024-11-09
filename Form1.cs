namespace DzMutexSemaphores
{
    public partial class Form1 : Form
    {
        private Semaphore semaphore = new Semaphore(3, 3);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Thread1()
        {
            semaphore.WaitOne();
            for (int i = 0; i < 10; i++)
            {

            }
        }

    }
}
