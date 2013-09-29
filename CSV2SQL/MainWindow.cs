using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Shell;

namespace CSV2SQL
{
    public partial class MainWindow : Form
    {
        TaskbarItemInfo info;
        Thread workerThread;
        String filename;
        public MainWindow()
        {
            InitializeComponent();
            info = new TaskbarItemInfo();
            workerThread = new Thread(work);
        }

        private void work()
        {
            String[] lines = File.ReadAllLines(filename);
            String Statement = "";
            for (int i = 0; i < lines.Length; i++)
            {
                string currentLine = lines[i];
                if (i == 0)
                {
                    String[] fields = currentLine.Split(Program.Seperator);

                    Statement += Program.CurrentSystem.Create(Path.GetFileNameWithoutExtension(filename), fields);

                }
                else
                {
                    String[] values = currentLine.Split(Program.Seperator);
                    Statement += Program.CurrentSystem.Insert(Path.GetFileNameWithoutExtension(filename), values);
                }
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {

            workerThread.Start();
        }

        private void browseFileButton_Click(object sender, EventArgs e)
        {
            fileBrowser.Filter = "Comma Seperated Values (CSV)|*.CSV";


            if (fileBrowser.ShowDialog() == DialogResult.OK)
            {

                startButton.Enabled = true;
                filename = fileBrowser.FileName;


            }
        }

    }
}
