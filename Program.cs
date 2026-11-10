namespace Week_11_Challange_Labs
{
    internal class Program
    {

        static void PrintArray(int[] nums)
        {
            foreach (int i in nums)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }

        static void Organize(int[] nums)
        {
            int red = 0, white = 1, blue = 2;
            int[] counts = new int[3] { 0 ,0, 0 };

            foreach (int i in nums)
            {
                if (i == red) counts[red]++;
                if (i == white) counts[white]++;
                if (i == blue) counts[blue]++;
            }
            int count = 0;

            while (counts[red] > 0)
            {
                nums[count] = red;
                counts[red]--;
                count++;
            }

            while (counts[white] > 0)
            {
                nums[count] = white;
                counts[white]--;
                count++;
            }

            while (counts[blue] > 0)
            {
                nums[count] = blue;
                counts[blue]--;
                count++;
            }

        }

        static int BalloonChances(string word)
        {
            int[] letters = { 0, 0, 0, 0, 0};
            int b = 0, a = 1, l = 2, o = 3, n = 4;
            int chances = 0;

            for (int i = 0; i < word.Length; i++)
            {
                switch (word[i])
                {
                    case 'a':
                        letters[a]++;
                        break;
                    case 'b':
                        letters[b]++;
                        break;
                    case 'l':
                        letters[l]++;
                        break;
                    case 'o':
                        letters[o]++;
                        break;
                    case 'n':
                        letters[n]++;
                        break;
                }
            }

            while(letters[b] > 0 && letters[a] > 0 && letters[l] > 0 && letters[o] > 0 && letters[n] > 0)
            {
                if (letters[l] > 1 && letters[o] > 1)
                {
                    chances++;
                    letters[l] -= 2;
                    letters[o] -= 2;

                    letters[b]--;
                    letters[a]--;
                    letters[n]--;
                }
                else
                {
                    break;
                }
            }

            return chances;
        }

        static void Print()
        {
            int[] r1 = { 2, 0, 2, 1, 1, 0 };
            int[] r2 = { 2, 0, 1 };

            Console.Write("This Program organizes a array based on its color index.\n\nOriginal: ");
            PrintArray(r1);

            Organize(r1);
            Console.Write("Organized: ");
            PrintArray(r1);

            Console.Write("Original: ");
            PrintArray(r2);
            Organize(r2);
            Console.Write("Organized: ");
            PrintArray(r2);

            string firstText = "nlaebolko";
            string secondText = "loonbalxballpoon";
            string thirdText = "leetcode";

            Console.WriteLine("\nThis Program shows you how many times your word has ballon in it.\n");
            Console.WriteLine($"The word {firstText} has ballon this many times: {BalloonChances(firstText)}");
            Console.WriteLine($"The word {secondText} has ballon this many times: {BalloonChances(secondText)}");
            Console.WriteLine($"The word {thirdText} has ballon this many times: {BalloonChances(thirdText)}");


        }

        static void Main(string[] args)
        {
            Print();
        }
    }
}
