using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_PuzzleSolver
{
    public  struct State 
    {
        int[] tiles;

        public State(int[] newtile)
        {
            tiles = newtile;
        }



        public int[] GetTiles()
        {
            return tiles;
        }


        public int GetBlankTileIndex()
        {
            int result = 0;
               
            for(int i = 0; i < tiles.Length;i++)
            {
                if(tiles[i] == 0)   //If the value is zero that means this tile is the blank one.
                {
                    result = i;
                    break;
                }
            }

            return result;
        }
    }
}
