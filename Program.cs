using System;

namespace ArrayRotationProblem
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = new int[7] { 3, 4, 5, 6, 7, 1, 2 };
            Console.WriteLine("Input Array : " + string.Join("", array));
            ArrayRotation arrayRotation = new ArrayRotation();
            string rotatingArray = arrayRotation.RotateArray(array);
            Console.WriteLine("Rotating array : " + rotatingArray);
            //Console.ReadLine();
        }
    }
}
