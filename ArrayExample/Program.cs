using System;

namespace ArrayExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] intarray = new int[,] { { 1, 2 }, { 3, 4},
                                            { 5, 6 }, { 7, 8 }};

            int[] testarray = new int[5];

            testarray = new int[5] { 1, 2, 3, 4, 5 };

            int[,,] intarray3D = new int[2, 2, 3] { { { 1, 2, 3 }, { 4, 5, 6} },
                                                        { {7, 8, 9 }, {10, 11, 12}} };

            int[,,] array3D = new int[1, 3, 2] { { { 1, 2 }, { 3, 4 }, { 5, 6 } } };

            intarray3D[0, 1, 1] = 10;

            Console.WriteLine("2Darr[0][1] : " + intarray[0, 1]);
            Console.WriteLine("3Darr[0][1][1] : " + intarray3D[0, 1, 1]);
        }
    }
}
