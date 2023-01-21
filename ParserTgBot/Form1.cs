using ParserTgBot.Core;
using ParserTgBot.Core.Shedule;

namespace ParserTgBot
{
    public partial class Form1 : Form
    {
        ParcerWorker<string[]> parcer;
        public Form1()
        {
            InitializeComponent();
            parcer = new ParcerWorker<string[]>(
                new SheduleParcer()
                );
            parcer.OnCompleted += Parcer_OnCompleted;
            parcer.OnNewData += Parcer_OnNewData;
        }

        private void Parcer_OnNewData(object arg1, string[] arg2)
        {
            ListTitles.Items.AddRange(arg2);
        }

        private void Parcer_OnCompleted(object obj)
        {
            MessageBox.Show("Completed");
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            parcer.Settings = new SheduleSettings((int)StartNumber.Value, (int)EndNumber.Value);
            parcer.Start();
        }

        private void AbortButton_Click(object sender, EventArgs e)
        {
            parcer.Abort();
        }
    }
}