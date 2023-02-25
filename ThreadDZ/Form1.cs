namespace ThreadDZ
{
    public partial class Form1 : Form
    {
        Simple simple;
        Fibonaci fibonaci;
        private Thread thread, thread1, thread2;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxSimple.Text))
            {
                int num = int.Parse(textBoxSimple.Text);
                simple = new Simple(num);
                simple.Show();
            }
            else
            {
                simple = new Simple(0);
                simple.Show();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBoxFibonaci.Text);
            fibonaci = new Fibonaci(num);
            fibonaci.Show();
        }

        private void buttonStopFibonaci_Click(object sender, EventArgs e)
        {
            fibonaci.Stop();
        }

        private void buttonPauseFibonaci_Click(object sender, EventArgs e)
        {
            fibonaci.Pause();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            simple.Stop();
        }

        private void buttonPausesimple_Click(object sender, EventArgs e)
        {
            simple.Pause();
        }
    }
}