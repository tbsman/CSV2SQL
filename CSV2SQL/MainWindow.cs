using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CSV2SQL
{
    public partial class MainWindow : Form
    {
        
        Thread workerThread;
        String filename;
        public MainWindow()
        {
            InitializeComponent();
            
            workerThread = new Thread(work);
            sqlSystemBox.Items.AddRange(new SQLSystem[] { new MySQL() });

        }
        private void reportProgress(double value)
        {
            Debug.WriteLine(value);
            if (this.InvokeRequired)
            {
                this.BeginInvoke((Action)(() =>
                {
                    
                    progressBar.Value = (int)value;
                }));
            }
            else
            {
                
                progressBar.Value = (int)value;
            }
        }
        private void work(object param)
        {
            Object[] parameters = (Object[])param;
            char seperator = (char)parameters[0];
            SQLSystem sqlsys = (SQLSystem)parameters[1];

            String[] lines = File.ReadAllLines(filename);
            String Statement = "";
            for (int i = 0; i < lines.Length; i++)
            {
                string currentLine = lines[i];
                if (i == 0)
                {
                    String[] fields = currentLine.Split(seperator);

                    Statement += sqlsys.Create(Path.GetFileNameWithoutExtension(filename), fields);
                    
                }
                else
                {
                    String[] values = currentLine.Split(seperator);
                    Statement += sqlsys.Insert(Path.GetFileNameWithoutExtension(filename), values);
                }
                
                double progress = (double)(i + 1) / (double)lines.Length;
                reportProgress(progress * 100);
            }

        }

        private void startButton_Click(object sender, EventArgs e)
        {

            workerThread.Start(new object[] { csvSeperatorBox.Text[0], (SQLSystem)sqlSystemBox.SelectedItem });
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
