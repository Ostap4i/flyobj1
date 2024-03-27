
using System;
using System.Drawing;
using System.Windows.Forms;
namespace FLY_oBject
{
    public partial class Form1 : Form
    {
        public int count = 0;
        private Point finish;
        private List<PictureBox> pictureBoxes = new List<PictureBox>();

        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1;
            
            timer1.Start();

            // Uncomment the following line if you plan to use timer2
            // timer2.Interval = 100;
            // timer2.Tick += timer2_Tick;
            // timer2.Start();

           
           


            // Initialize the finish point
            finish = new Point(1125, 0);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            count ++;
            textBox1.Text = Convert.ToString(count);
            pictureBox1.Visible = false;

        }

        private void AddNewPictureBox()
        {
            PictureBox newPictureBox = new PictureBox();
            newPictureBox.Size = pictureBox1.Size;
            newPictureBox.Location = pictureBox1.Location;
            newPictureBox.BackColor = pictureBox1.BackColor;

            // Add the new PictureBox to the form and the list
            Controls.Add(newPictureBox);
            pictureBoxes.Add(newPictureBox);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            foreach (PictureBox pictureBox in pictureBoxes)
            {
              
                
                Random rand = new Random();

                int speed = rand.Next(2, 5);
                Point point = Point.Add(pictureBox1.Location, new Size(speed, 0));
                pictureBox1.Location = point;

                int Xy = pictureBox1.Location.X;

                if (pictureBox1.Location.X >= finish.X)
                {
                    timer1.Stop();
                    MessageBox.Show($"Suricken finish {speed}");
                    pictureBox1.Location = point;
                }

            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}