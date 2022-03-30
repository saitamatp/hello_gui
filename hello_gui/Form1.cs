using System.Diagnostics;

namespace hello_gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show($"{execute(2)}");
        }
        public static string execute(int a)
        {
            string temp_load = @"D:\rust_src\csv_mysql\target\debug\csv_mysql.exe";
            string base_load = @"D:\rust_src\load_base\target\debug\load_base.exe";
            string delete = @"D:\rust_src\clear_tmp\target\debug\clear_tmp.exe";


            if (a == 1)
            {
                Process p = new Process();
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.FileName = temp_load;
                p.Start();
                string output = p.StandardOutput.ReadToEnd();
                p.WaitForExit();
                return output;
            }
            else if (a == 2)
            {
                Process p = new Process();
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.FileName = base_load;
                p.Start();
                string output = p.StandardOutput.ReadToEnd();
                p.WaitForExit();
                return output;
            }
            else if (a == 3) 
            {
                Process p = new Process();
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.FileName = delete;
                p.Start();
                string output = p.StandardOutput.ReadToEnd();
                p.WaitForExit();
                return output;

            }
            else
                return "Unable to find/execute rust code";    
        }
        private void button2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Reads data from CSV file and loads them to temp table",button2);
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            toolTip2.Show("Reads data from temp table and loads them to base tables", button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{execute(1)}");
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            toolTip3.Show("Delete data from Temporoary tables", button3);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{execute(3)}");
        }
    }

}