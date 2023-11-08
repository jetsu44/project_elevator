using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
namespace project_elevator
{
    public partial class Form1 : Form

    {


        public Form1()
        {
            InitializeComponent();
        }
        insert Ev = new insert(); // creating new object
        private void panel()
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void open_timer_Tick(object sender, EventArgs e) // method to open the door
        {
            close_timer.Stop();
            if (pictureBox5.Top == 61)
            {
                if (pictureBox1.Left > 34)
                {
                    pictureBox1.Left -= 1;
                    pictureBox2.Left += 1;
                    fifth_timer.Start();
                }
                else
                {
                   
                    Ev.Insert("First floor door is opening"); // inserting the data 
                    LoadData(); // showing data in table
                    open_timer.Stop();

                }
            }
            else if (pictureBox5.Top == 364)
            {
                if (pictureBox3.Left > 34)
                {
                    pictureBox3.Left -= 1;
                    pictureBox4.Left += 1;
                }
                else
                {                   
                    Ev.Insert("Ground floor door is opening"); // inserting the data
                    LoadData(); // showing data in table
                    open_timer.Stop();
                }
            }
        }

        private void btn1_Click(object sender, EventArgs e) // open button method
        {
            open_timer.Start();
            close_timer.Stop();
        }

        private void close_timer_Tick(object sender, EventArgs e) // close method to close the door
        {
            open_timer.Stop();
            if (pictureBox5.Top == 61)
            {
                if (pictureBox1.Left < 94)
                {
                    pictureBox1.Left += 1;
                    pictureBox2.Left -= 1;
                    fifth_timer.Start();
                }
                else
                {                   
                    Ev.Insert("First floor door is closing"); // inseerting data in database
                    LoadData(); // showing data in table
                    close_timer.Stop();
                }
            }
            else if (pictureBox5.Top == 364)
            {
                if (pictureBox3.Left < 94)
                {
                    pictureBox3.Left += 1;
                    pictureBox4.Left -= 1;
                    fifth_timer.Start();
                }
                else
                {                    
                    Ev.Insert("Ground floor door is closing"); // inseerting data in database
                    LoadData(); // showing data in table
                    close_timer.Stop();
                }
            }
        }

        private void btn2_Click(object sender, EventArgs e) // method to close the door using button
        {
            close_timer.Start();
            open_timer.Stop();
        }

        private void up_timer_Tick(object sender, EventArgs e) // using timer method to move elevator upward
        {
            pictureBox8.Image = Properties.Resources.up1;
            if (pictureBox5.Top > 61)
            {
                down_timer.Stop();
                if (pictureBox3.Left < 94)
                {
                    pictureBox3.Left += 1;
                    pictureBox4.Left -= 1;
                }
                else
                {
                    pictureBox5.Top -= 1;
                }
            }
            else
            {                
                down_timer.Stop();
                up_timer.Stop();
                Ev.Insert("Elevator is in first floor"); // inserting data in the database
                LoadData();               // showing data in table
                open_timer.Start();
                fifth_timer.Start();                
            }            
            pictureBox8.Image = Properties.Resources._12; // display the picture after moving upward
        }

        private void btn3_Click(object sender, EventArgs e) // button to call the elevator upward
        {
            down_timer.Stop();
            up_timer.Start();

        }

        private void down_timer_Tick(object sender, EventArgs e) // method to call the elevator downward
        {
            pictureBox8.Image = Properties.Resources.down2; // display image in picturebox 
            if (pictureBox5.Top < 364)
            {
                up_timer.Stop();
                if (pictureBox1.Left < 94)
                {
                    pictureBox1.Left += 1;
                    pictureBox2.Left -= 1;

                }
                else
                {
                    pictureBox5.Top += 1;
                }
            }
            else
            {
                down_timer.Stop();
                up_timer.Stop();
                open_timer.Start();
                fifth_timer.Start();
                Ev.Insert("Elevator is in Ground floor"); // inserting the data in database
                LoadData();                   // showing data in table
            }
            pictureBox8.Image = Properties.Resources.G1; // displaying the image after reaching to ground floor
        }

        private void btn4_Click(object sender, EventArgs e) // button to request the elevator to ground floor
        {
            up_timer.Stop();
            down_timer.Start();
        }

        private void fifth_timer_Tick(object sender, EventArgs e) // method to close the door automatic
        {
            close_timer.Start();
        }

        private void sixth_timer_Tick(object sender, EventArgs e)
        {

        }

        private void btn7_Click(object sender, EventArgs e) // method to request the elevator in first floor
        {
            down_timer.Start();
        }

        private void btn8_Click(object sender, EventArgs e) // method to request the elevator in ground floor
        {
            up_timer.Start();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void LoadData() // displaying the data in table
        {
            try
            {
                insert Ev = new insert();
                DataTable dt = Ev.ViewData(); 
                dataGridView1.DataSource = dt; // displaying the data in dataGridView
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btn5_Click(object sender, EventArgs e) // clear method to remove the data
        {
            dataGridView1.DataSource = null;
            Ev.remover(); // calling the remover method
        }
    }
}