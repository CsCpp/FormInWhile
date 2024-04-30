using System.Threading;
namespace FormInWhile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int i = 0;
            while(true)
            {
                i++;
                ThreadPool.QueueUserWorkItem(state =>
                {
                    MessageForm msf = new MessageForm($"Форма №: {i}",$"Вот и создалась форма №  {i}");
                    Application.Run(msf);
                   
                });
               
                Thread.Sleep(5000);
            }
        }
    }
}
