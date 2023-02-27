using System.Diagnostics;

namespace Instalator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        
        public void instal_init_checkbox(dynamic name)
        {
            foreach (Control c in name.Controls)
            {
                //Function if/ Check if checkbox is checked
                if (((CheckBox)c).Checked == true)
                {
                    //Define new process
                    Process myProcess = new Process();

                    try
                    {
                        //Try to open new process with URL adress 
                        myProcess.StartInfo.UseShellExecute = true;
                        myProcess.StartInfo.FileName = c.Tag.ToString();
                        myProcess.Start();
                    }
                    catch
                    {
                        //If process can't start program show messagebox with erorr
                        MessageBox.Show("Can't start download! Try again");
                    }

                }

            }
            
        }
        public void instal_init_radiobutton(dynamic name)
        {
            foreach (Control c in name.Controls)
            {
                //Function if/ Check if radiobutton is checked
                if (((RadioButton)c).Checked == true)
                {
                    //Define new process
                    Process myProcess = new Process();

                    try
                    {
                        //Try to open new process with URL adress 
                        myProcess.StartInfo.UseShellExecute = true;
                        myProcess.StartInfo.FileName = c.Tag.ToString();
                        myProcess.Start();
                    }
                    catch
                    {
                        //If process can't start program show messagebox with erorr
                        MessageBox.Show("Can't start download! Try again");
                    }

                }

            }
        }

        //Programs to show system info
        public void system_infos()
        {     
            instal_init_checkbox(systeminfo);
        }
        
        //Programs for games
        public void games_checked()
        {
            instal_init_checkbox(gamesapps);
        }

        //Basic apps for new system
        public void applications()
        {
            instal_init_checkbox(apps);
        }

        //Drivers for GPU
        public void gpu_drivers()
        {
           instal_init_radiobutton(gpudrivers);
        }

        //Browsers
        public void browsersapps()
        {
            instal_init_radiobutton(browsers);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Call of all defined methods
            
            system_infos();
            games_checked();
            applications();
            gpu_drivers();
            browsersapps();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //"Exit" button to exit program
            if (MessageBox.Show("Are you sure to exit ?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
