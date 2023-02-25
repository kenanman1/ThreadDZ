namespace ThreadDZ
{
    public partial class Fibonaci : Form
    {
        Thread thread;
        int num;
        public Fibonaci(int num)
        {
            InitializeComponent();
            thread = new Thread(Make);
            this.num = num;
            thread.Start(num);
        }
        public void Make(object number)
        {
            int end = (int)number;
            int j = 1;
            for (int i = 1; i <= end; i += j)
            {
                label1.Text = i.ToString();
                j = i - j;
                Thread.Sleep(400);
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
