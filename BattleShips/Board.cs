using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShips
{
    public  class Board
    {
       
            public int sizeX = 10;
            public int sizeY = 10;

            public int width = 60;
            public int height = 42;

            bool[,] cells;

            public Board()
            {
                cells = new bool[sizeX, sizeY];
            }

            public void Draw(Graphics g)
            {
                for (int i = 0; i <= sizeY; i++)
                { g.DrawLine(Pens.Black, i * width, 0, width * i, height * sizeY); }

                for (int i = 0; i <= sizeX; i++)
                { g.DrawLine(Pens.Black, 0, height * i, width * sizeX, height * i); }




                for (int x = 0; x < sizeX; x++)
                {
                    for (int y = 0; y < sizeY; y++)
                    {
                        if (cells[x, y] == true)
                        {
                            g.FillRectangle(Brushes.Black, width * x, height * y, width, height);
                        }

                    }
                }



            }

            public void Select(int mouseX, int mouseY)
            {
                //int i = mouseX / width;
                //int j = mouseY / height;
                int x = mouseX / width;
                int y = mouseY / height;


                if (cells[x, y] == true)
                {
                    cells[x, y] = false;
                }
                else if (cells[x, y] == false)
                {
                    cells[x, y] = true;
                }

            }

            public void Border()
            {

                for (int x = 0; x < sizeX; x++)
                {
                    for (int y = 0; y < sizeY; y++)
                    {
                        cells[x, y] = true;


                    }
                }


            }
        }
    }

