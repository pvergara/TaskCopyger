using System.Diagnostics;
using System.Text.RegularExpressions;

namespace TaskCopyger
{
    public partial class Form1 : Form
    {
        public Process[] threads = Process.GetProcesses();
        const string FORMAT = "{0,20}{1,7}{2,6}";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            String basicText = string.Format(FORMAT, "Name", "PID", "Threads") + Environment.NewLine;
            textBox1.Text = basicText;
            String processInfo;
            foreach (Process p in threads)
            {
                processInfo = string.Format(FORMAT, Regex.Replace(p.ProcessName.ToString(), "(?<=^.{15}).*", "..."), p.Id.ToString(), p.Threads.Count.ToString()) + "\t" + Environment.NewLine;
                textBox1.Text += processInfo;
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            String startingText = textBox2.Text;
            String basicText = string.Format(FORMAT, "Name", "PID", "Threads") + Environment.NewLine;
            
            threads.Where(item => item.ProcessName.StartsWith(startingText)).ToList().ForEach(item =>
            {
                textBox1.Text += string.Format(FORMAT, Regex.Replace(item.ProcessName.ToString(), "(?<=^.{15}).*", "..."),
                    item.Id.ToString(), item.Threads.Count.ToString()) + "\t" + Environment.NewLine;
            });
        }
    }
}