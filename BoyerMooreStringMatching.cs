namespace BoyerMooreStringAlgorithm
{
    public class BoyerMooreStringMatching
    {
        public static int NO_OF_CHARS = 256;

        public static int Max(int a, int b) { return (a > b) ? a : b; }

        public static void BadCharHeuristic(char[] str, int size, int[] badchar)
        {
            int i;

            for (i = 0; i < NO_OF_CHARS; i++)
                badchar[i] = -1;

            for (i = 0; i < size; i++)
                badchar[(int)str[i]] = i;
        }

        public static void Search(char[] txt, char[] pat)
        {
            int m = pat.Length;
            int n = txt.Length;

            int[] badchar = new int[NO_OF_CHARS];

            BadCharHeuristic(pat, m, badchar);

            int s = 0;
            while (s <= (n - m))
            {
                int j = m - 1;

                while (j >= 0 && pat[j] == txt[s + j])
                    j--;

                if (j < 0)
                {
                    Console.WriteLine("İndeks " + s);
                    s += (s + m < n) ? m - badchar[txt[s + m]] : 1;
                }

                else
                    s += Max(1, j - badchar[txt[s + j]]);
            }
        }
    }
}
