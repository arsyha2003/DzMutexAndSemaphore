using System.Xml;

namespace DzMutexSemaphores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CasinoTable gameTable = new CasinoTable();
            gameTable.StartGame();//не стал создавать новое консольное приложение
        }
    }
}
