using UnityEngine;

namespace Assignment
{
    public class StudentSolution : IAssignment
    {
        #region Lecture

        public int[] LCT01_SelectionSortAscending(int[] numbers)
        {
            int[] result = (int[])numbers.Clone();

            for (int i = 0; i < result.Length - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < result.Length; j++)
                {
                    if (result[j] < result[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int temp = result[i];
                result[i] = result[minIndex];
                result[minIndex] = temp;
            }

            foreach (int number in result)
            {
                Debug.Log(number);
            }

            return result;
        }


        public int[] LCT02_BubbleSortAscending(int[] numbers)
        {
            int[] result = (int[])numbers.Clone();

            for (int i = 0; i < result.Length - 1; i++)
            {
                for (int j = 0; j < result.Length - i - 1; j++)
                {
                    if (result[j] > result[j + 1])
                    {
                        int temp = result[j];
                        result[j] = result[j + 1];
                        result[j + 1] = temp;
                    }
                }
            }

            foreach (int number in result)
            {
                Debug.Log(number);
            }

            return result;
        }


        public int[] LCT03_InsertionSortAscending(int[] numbers)
        {
            int[] result = (int[])numbers.Clone();

            for (int i = 1; i < result.Length; i++)
            {
                int key = result[i];
                int j = i - 1;

                while (j >= 0 && result[j] > key)
                {
                    result[j + 1] = result[j];
                    j--;
                }

                result[j + 1] = key;
            }

            foreach (int number in result)
            {
                Debug.Log(number);
            }

            return result;
        }

        #endregion


        #region Assignment

        public int[] AS01_SelectionSortDescending(int[] numbers)
        {
            int[] result = (int[])numbers.Clone();

            for (int i = 0; i < result.Length - 1; i++)
            {
                int maxIndex = i;

                for (int j = i + 1; j < result.Length; j++)
                {
                    if (result[j] > result[maxIndex])
                    {
                        maxIndex = j;
                    }
                }

                int temp = result[i];
                result[i] = result[maxIndex];
                result[maxIndex] = temp;
            }

            foreach (int number in result)
            {
                Debug.Log(number);
            }

            return result;
        }


        public int[] AS02_BubbleSortDescending(int[] numbers)
        {
            int[] result = (int[])numbers.Clone();

            for (int i = 0; i < result.Length - 1; i++)
            {
                for (int j = 0; j < result.Length - i - 1; j++)
                {
                    if (result[j] < result[j + 1])
                    {
                        int temp = result[j];
                        result[j] = result[j + 1];
                        result[j + 1] = temp;
                    }
                }
            }

            foreach (int number in result)
            {
                Debug.Log(number);
            }

            return result;
        }


        public int[] AS03_InsertionSortDescending(int[] numbers)
        {
            int[] result = (int[])numbers.Clone();

            for (int i = 1; i < result.Length; i++)
            {
                int key = result[i];
                int j = i - 1;

                while (j >= 0 && result[j] < key)
                {
                    result[j + 1] = result[j];
                    j--;
                }

                result[j + 1] = key;
            }

            foreach (int number in result)
            {
                Debug.Log(number);
            }

            return result;
        }


        public int AS04_FindTheSecondLargestNumber(int[] numbers)
        {
            int[] result = (int[])numbers.Clone();

            // Selection Sort จากน้อยไปมาก
            for (int i = 0; i < result.Length - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < result.Length; j++)
                {
                    if (result[j] < result[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int temp = result[i];
                result[i] = result[minIndex];
                result[minIndex] = temp;
            }

            // ค่าสูงสุด
            int largest = result[result.Length - 1];

            // หาอันดับสอง โดยข้ามค่าที่ซ้ำกับค่าสูงสุด
            for (int i = result.Length - 2; i >= 0; i--)
            {
                if (result[i] < largest)
                {
                    return result[i];
                }
            }

            return largest;
        }

        #endregion


        #region Extra

        public int EX01_FindLongestConsecutiveSequence(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                Debug.Log(
                    "The longest consecutive sequence is: 0"
                );

                return 0;
            }

            int[] result = (int[])numbers.Clone();

            // Selection Sort จากน้อยไปมาก
            for (int i = 0; i < result.Length - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < result.Length; j++)
                {
                    if (result[j] < result[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int temp = result[i];
                result[i] = result[minIndex];
                result[minIndex] = temp;
            }

            int currentStreak = 1;
            int longestStreak = 1;

            for (int i = 1; i < result.Length; i++)
            {
                // ถ้าค่าซ้ำ ให้ข้าม
                if (result[i] == result[i - 1])
                {
                    continue;
                }

                // ถ้าตัวเลขต่อเนื่องกัน
                if ((long)result[i] - result[i - 1] == 1)
                {
                    currentStreak++;
                }
                else
                {
                    currentStreak = 1;
                }

                // เก็บค่าที่ยาวที่สุด
                if (currentStreak > longestStreak)
                {
                    longestStreak = currentStreak;
                }
            }

            Debug.Log(
                "The longest consecutive sequence is: "
                + longestStreak
            );

            return longestStreak;
        }

        #endregion
    }
}