
namespace ThreadDZ
{
    public partial class Simple : Form
    {
        Thread thread;
        int num;
        public Simple(int num)
        {
            InitializeComponent();
            thread = new Thread(SimpleNumbers);
            this.num = num;
            thread.Start(num);
        }
        public void SimpleNumbers(object num)
        {
            int number = 2;
            if ((int)num != 0)
            {
                while (number < (int)num)
                {
                    if (number % 2 != 0 && number % 3 != 0)
                    {
                        SimpleLabel.Text = number.ToString();
                        Thread.Sleep(100);
                    }
                    number++;
                }
            }
            else
            {
                while (number > 0)
                {
                    if (number % 2 != 0 && number % 3 != 0)
                    {
                        SimpleLabel.Text = number.ToString();
                        Thread.Sleep(100);
                    }
                    number++;
                }
            }
        }
        public void Stop()
        {
            thread.Abort();
        }
        public void Pause()
        {
            while (true)
            {
                Thread.Sleep(100);
            }
        }
    }
}