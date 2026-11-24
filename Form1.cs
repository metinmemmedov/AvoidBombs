using System.Media;

namespace AvoidBombs
{
    public partial class Form1 : Form
    {
        Random rgen = new Random();
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void bomb2_Click(object sender, EventArgs e)
        {

        }
        SoundPlayer sp = new SoundPlayer("D:\\5094a1-Metin\\AvoidBombs\\photos\\explosion.wav");
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && man.Location.X>10)
            {
                man.ImageLocation = "D:\\5094a1-Metin\\AvoidBombs\\photos\\left.png";
                man.Left -= 30;
            }
            if (e.KeyCode == Keys.Right && man.Location.X<ClientSize.Width-50)
            {
                man.ImageLocation = "D:\\5094a1-Metin\\AvoidBombs\\photos\\right.png";
                man.Left += 30;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            bomb1.Location = new Point(rgen.Next(ClientSize.Width/2 - 50), 20);
            bomb2.Location = new Point(rgen.Next(ClientSize.Width/2,ClientSize.Width - 50), 20);
            man.ImageLocation = "D:\\5094a1-Metin\\AvoidBombs\\photos\\standing.jpg";
            score = 0;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (bomb1.Location.Y > ClientSize.Height)
            {
                score++;
                bomb1.Location = new Point(rgen.Next(ClientSize.Width / 2 - 50), 20); ;
            }
                bomb1.ImageLocation = "D:\\5094a1-Metin\\AvoidBombs\\photos\\grenade.png";
            bomb1.Top += 10;
            if (bomb1.Bounds.IntersectsWith(man.Bounds) || bomb2.Bounds.IntersectsWith(man.Bounds))
            {
                sp.Play();
                timer1.Stop();
                timer2.Stop();
                MessageBox.Show($"You couldn't avoid bombs... Your score is {score}", "Defeat", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                DialogResult result = MessageBox.Show("Do you want to play again?", "One more try?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Form1_Load(sender, e);
                }
                else Close();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (bomb2.Location.Y > ClientSize.Height)
            {
                score++;
                bomb2.Location = new Point(rgen.Next(ClientSize.Width / 2, ClientSize.Width - 50), 20);
            }
                bomb2.ImageLocation = "D:\\5094a1-Metin\\AvoidBombs\\photos\\grenade.png";
            bomb2.Top += 10;
        }
    }
}
