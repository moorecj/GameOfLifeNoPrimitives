using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLifeCells
{
    public class Cell
    {
        private Cell thisCell;
        private List<Cell> neighbors;

        public Cell()
        {
            neighbors = new List<Cell>();

        }

        public List<Cell> GetNeighbors()
        {
            return neighbors;
        }

        

       

        
    }
}
