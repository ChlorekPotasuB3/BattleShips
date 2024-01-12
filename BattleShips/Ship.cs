using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;


namespace BattleShips
{
    public class Ship
    {
        public int Length;
        public Color Color;
        public int Orientation;
        public int PosX;
        public int PosY;
   
        public Ship(int length, Color color, int orientation, int posX, int posY)
        {
            Length = length;
            Color = color;
            Orientation = orientation;
            PosX = posX;
            PosY = posY;
            
        }
        public void Draw(Graphics g,Board board)
        {

            if (Orientation == 0)
                g.DrawRectangle(Pens.Azure, PosX*board.width, PosY * board.height, Length* board.width, board.height);
            else
                g.DrawRectangle(Pens.Azure, PosX*board.width, PosY * board.height, board.height, board.height*Length);
        }

        public void LengthRand()
        {

        }
        
    }




}            

