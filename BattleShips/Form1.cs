namespace BattleShips
{
    public partial class Form1 : Form
    {
        Board board = new Board();
        List<Ship> shipList = new List<Ship>();
        Random random = new Random();
       
        
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            board.Draw(g);

            foreach (Ship ship in shipList)
            {
                ship.Draw(g, board);
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            board.Select(e.X, e.Y);
            pictureBox1.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = random.Next(10);
            int y = random.Next(10);
            int orientation = random.Next(2);
            int length = random.Next(5);
            
            
            Ship shipNew = new Ship(length, Color.Red, orientation, x, y);

            foreach (Ship ship in shipList)
            {
                if (ship.PosX == shipNew.PosX && shipNew.PosY == ship.PosY)
                {
                    
                }
                else
                {

                }
            }
            shipList.Add(shipNew);




            pictureBox1.Invalidate();
        }
    }
}