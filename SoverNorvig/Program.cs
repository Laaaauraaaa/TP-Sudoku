﻿using System;

namespace SoverNorvig
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] initial_grid = new int[] { 9, 0, 0, 5, 0, 0, 0, 0, 8,

                                             0, 0, 1, 8, 0, 0, 4, 0, 3,

                                             0, 0, 8, 0, 9, 0, 5, 0, 0,

                                             8, 1, 0, 0, 0, 4, 0, 0, 5,

                                             7, 0, 0, 1, 0, 3, 0, 0, 6,

                                             2, 0, 0, 9, 0, 0, 0, 3, 0,

                                             0, 0, 4, 0, 1, 0, 3, 0, 0,

                                             3, 0, 5, 0, 8, 7, 1, 0, 0,

                                             0, 0, 0, 0, 0, 5, 0, 0, 4 };


            Noyau.Sudoku s = new Noyau.Sudoku(initial_grid);
            Console.WriteLine(s.ToString());
            

            SoverNorvig SN = new SoverNorvig();
            DateTime start = DateTime.Now;
            s = SN.Solve(s);
            Console.WriteLine("Solving sodoku took " + (DateTime.Now - start).TotalSeconds+"seconds");



            Console.WriteLine(s.ToString());
            Console.WriteLine();
        }
    }
}
