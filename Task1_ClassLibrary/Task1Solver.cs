using System;
using System.Linq;

namespace Task1_ClassLibrary
{
    public class Task1Solver
    {
        private int[][] array;

        public Task1Solver(int[][] array)
        {
            this.array = array;
        }
        public int[][] DoSolve()
        {
            return array.Select((x, i) => x.Select((y, j) => this.CheckNeighbors(i, j) ? 1 : 0).ToArray()).ToArray();
        }

        private bool CheckNeighbors(int ii, int jj)
        {
            return array.SelectMany((x, i) => x.Select((y, j) => new { i, j, y })).Where(
                a => Math.Abs(a.i - ii) <= 1 && Math.Abs(a.j - jj) <= 1 && array[a.i][a.j] == array[ii][jj]).Count() >= 2 + 1;
        }
    }
}
