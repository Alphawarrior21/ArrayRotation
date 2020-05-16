using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayRotationProblem
{
    public class ArrayRotation
    {
        int rotatingPosition;
        int leftArrayIndex;
        int rightArrayIndex;
        int finalArrayIndex;
        int arrayLength;

        public string RotateArray(int[] array)
        {
            arrayLength = array.Length;
            if (arrayLength < 2)
                return string.Empty;
            if (array[0] > arrayLength)
                return string.Empty;

            rotatingPosition = array[0];
            int[] leftArray = ReturnArray(rotatingPosition, array, Direction.Backward);
            int[] rightArray = ReturnArray(rotatingPosition, array, Direction.Forward);

            //Array needs to be merged in the circular fashion//
            int[] finalArray = new int[leftArray.Length + rightArray.Length];
            rightArray.CopyTo(finalArray, 0);
            leftArray.CopyTo(finalArray, rightArray.Length);

            return string.Join("", finalArray);
        }


        public int[] ReturnArray(int rotatingPos, int[] array, Direction direction)
        {
            int[] resultArray;
            switch (direction)
            {
                case Direction.Forward:

                    resultArray = new int[Math.Abs(rotatingPos - array.Length)];
                    for (int i = rotatingPos; i < array.Length; i++)
                    {
                        resultArray[rightArrayIndex] = array[i];
                        rightArrayIndex++;

                    }

                    return resultArray;
                case Direction.Backward:

                    resultArray = new int[rotatingPos];
                    for (int i = 0; i < rotatingPos; i++)
                    {
                        resultArray[leftArrayIndex] = array[i];
                        leftArrayIndex++;

                    }

                    return resultArray;

                default: return null;
            }
        }
    }

    public enum Direction
    {
        Forward = 0,
        Backward = 1
    }
}
