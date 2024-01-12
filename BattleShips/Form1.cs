using Microsoft.VisualBasic.ApplicationServices;
using System.Runtime.InteropServices;

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
            int length = random.Next(4) + 1;

            bool isCollision = false;
            
            Ship shipNew = new Ship(length, Color.Red, orientation, x, y);


            foreach (Ship ship in shipList)
            {
                if ((ship.Orientation == shipNew.Orientation) && (shipNew.Orientation == 0))
                {
                    if (shipNew.PosY == ship.PosY)
                    {
                        if (shipNew.PosX <= ship.PosX + ship.Length)
                        {
                            isCollision = true;
                            break;
                        }
                        if (!(shipNew.PosX >= ship.PosX && shipNew.PosX < ship.PosX + ship.Length))
                        {
                            isCollision = true;
                            break;
                        }
                        if (shipNew.PosX + shipNew.Length > ship.PosX)
                        {
                            isCollision = true;
                            break;
                        }
                    }
                }



                else if ((ship.Orientation == shipNew.Orientation) && (shipNew.Orientation == 1))
                {
                    if (shipNew.PosX == ship.PosX)
                    {
                        if (shipNew.PosY >= ship.PosY + ship.Length)
                        {
                            isCollision = true;
                            break;
                        }
                        if (!(shipNew.PosY >= ship.PosY && shipNew.PosY < ship.PosY + ship.Length))
                        {

                            isCollision = true;
                            break;
                        }
                        if (shipNew.PosY + shipNew.Length < ship.PosY)
                        {
                            isCollision = true;
                            break;
                        }
                        shipNew = new Ship(length, Color.Red, orientation, x, y);
                    }
                }
                else if ((ship.Orientation != shipNew.Orientation) && (shipNew.Orientation == 1))
                {
                        if (shipNew.PosX + shipNew.Length == ship.PosX + ship.Length)
                        {
                        isCollision = true;
                        break;
                        }
                        if (shipNew.PosX < ship.PosX + ship.Length)
                        {
                            isCollision = true;
                            break;
                        }

                        if (shipNew.PosX == ship.PosX)
                        {
                            isCollision = true;
                            break;
                        }
                        if(shipNew.PosX + ship.Length > ship.PosX + ship.Length)
                        {
                            isCollision = true;
                            break;
                        }
                        
                    
                }
                else if ((ship.Orientation != shipNew.Orientation) && (shipNew.Orientation == 0))
                {
                        if (shipNew.PosY + shipNew.Length == ship.PosY + ship.Length)
                        {
                            isCollision = true;
                            break;
                        }
                        if (shipNew.PosY < ship.PosY + ship.Length)
                        {
                            isCollision = true;
                            break;
                        }

                        if(shipNew.PosY == ship.PosY)
                        {
                            isCollision = true;
                            break;
                        }
                        if (shipNew.PosY + shipNew.Length > ship.PosY + ship.Length)
                        {

                            isCollision = true;
                            break;
                        }
                

                    
                }

            }

            if (isCollision == false)
            {
                shipList.Add(shipNew);
            }



            //ship.PosX == shipNew.PosX && shipNew.PosY == ship.PosY

            pictureBox1.Invalidate();
        }

    }
}
