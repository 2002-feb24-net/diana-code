using System;

namespace MultiArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // you can make an array that contains any type
            // you can make an array of arrays

            // for example, for two dimensional image data
            string[][] image = new string[4][];
            image[0] = new string[] {"black", "black", "black", "black"};
            image[1] = new string[] {"black", "red", "red", "black"};
            image[2] = new string[] {"black", "red", "red", "black"};
            image[3] = new string[] {"black", "black", "black", "black"};
            string topRightCorner = image[0][3] // the 4th item in the 1st array

            // 4x3 image 
            string[][] secondImage = new string[4][];
            image[0] = new string[3]; 
            image[1] = new string[3];
            image[2] = new string[3]; 
            image[3] = new string[3]; 

            //this is a rectangular multi-dimensional array.
            string[,] image3 = new string[4, 4]
            {
                {"black", "black", "black", "black"}
                {"black", "red", "red", "black"}
                {"black", "red", "red", "black"}
                {"black", "black", "black", black"}
            };
            string topRightCorners = image3[0, 3];
        }
    }
}
