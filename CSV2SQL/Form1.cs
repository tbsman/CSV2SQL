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
    public partial class Form1 : Form
    {
        TaskbarItemInfo info;
        Thread workerThread;
        String filename;
        public Form1()
        {
            InitializeComponent();
            info = new TaskbarItemInfo();
            workerThread = new Thread(work);
        }

        private void work()
        {
            String[] lines = File.ReadAllLines(filename);
            for (int i = 0; i < lines.Length; i++)
            {
                string currentLine = lines[i];
                

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
