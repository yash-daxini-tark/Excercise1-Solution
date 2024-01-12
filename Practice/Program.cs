using System;
using System.Collections;
using System.Runtime.InteropServices.Marshalling;
using System.Text;

namespace Practice
{
    #region 1. HuffmanDecoding
    class HuffmanDecoding
    {
        public String decode(string archive, string[] dictionary)
        {
            Dictionary<string, int> map = new Dictionary<string, int>();
            for (int i = 0; i < dictionary.Length; i++)
            {
                map.Add(dictionary[i], i + 1);
            }

            StringBuilder cur = new StringBuilder();
            StringBuilder ans = new StringBuilder();

            for (int i = 0; i < archive.Length; i++)
            {
                cur.Append(archive[i]);
                if (map.ContainsKey(cur.ToString()))
                {
                    ans.Append((char)(64 + map[cur.ToString()]));
                    cur = new StringBuilder();
                }
            }

            return ans.ToString();

        }
    }
    #endregion

    #region 2. LexmaxReplace
    class LexmaxReplace
    {
        public string get(string s, string t)
        {
            StringBuilder ans = new StringBuilder("");
            int i = 0;
            char[] c = t.ToCharArray();
            Array.Sort(c);
            int curIndexOfT = c.Length - 1;
            for (; i < s.Length && curIndexOfT >= 0; i++)
            {
                if (s[i] >= c[curIndexOfT])
                {
                    ans.Append(s[i]);
                }
                else ans.Append(c[curIndexOfT--]);
            }
            for (; i < s.Length; i++) ans.Append(s[i]);
            //if( Math.Min(s.Length,t.Length) == s.Length ) { 
            //    ans.Append(t.Substring(i));
            //}
            //else { 
            //    ans.Append(s.Substring(i));
            //}
            return ans.ToString();
        }
    }
    #endregion

    #region 3. SortingSubsets
    class SortingSubsets
    {
        public int getMinimalSize(int[] a)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < a.Length; i++)
            {
                list.Add(a[i]);
            }
            Array.Sort(a, 0, a.Length);
            int count = 0;
            for (int i = 0; i < a.Length; ++i)
            {
                if (a[i] != list[i]) { count++; }
            }
            return count;
        }
    }
    #endregion

    #region 4. PalindromeDecoding

    class PalindromeDecoding
    {
        public string decode(string code, int[] position, int[] length)
        {
            StringBuilder ans = new StringBuilder(code);
            for (int i = 0; i < position.Length; i++)
            {
                int positionOfInsertion = position[i] + length[i];
                StringBuilder substringOfCode;
                substringOfCode = new StringBuilder(ans.ToString().Substring(position[i], length[i]));
                string revString = new string(substringOfCode.ToString().Reverse().ToArray());
                ans.Insert(positionOfInsertion, revString);
            }
            return ans.ToString();
        }
    }

    #endregion

    #region 5. MovingAvg

    class MovingAvg
    {
        public double difference(int k, double[] data)
        {
            List<double> list = new List<double>();
            for (int i = 0; i <= data.Length - k; i++)
            {
                double curSum = 0;
                for (int j = i; j < i + k; j++)
                {
                    curSum += data[j];
                }
                curSum /= k;
                list.Add(curSum);
            }
            list.Sort();
            return list[list.Count - 1] - list[0];
        }
    }

    #endregion

    #region 6. WordCompositionGame
    class WordCompositionGame
    {
        public string score(string[] listA, string[] listB, string[] listC)
        {
            Dictionary<string, int> map = new Dictionary<string, int>();
            foreach (string str in listA)
            {
                if (map.ContainsKey(str))
                {
                    int val = map[str];
                    map.Remove(str);
                    map.Add(str, val + 1);
                }
                else map.Add(str, 1);
            }
            foreach (string str in listB)
            {
                if (map.ContainsKey(str))
                {

                    int val = map[str];
                    map.Remove(str);
                    map.Add(str, val + 1);
                }
                else map.Add(str, 1);
            }
            foreach (string str in listC)
            {
                if (map.ContainsKey(str))
                {
                    int val = map[str];
                    map.Remove(str);
                    map.Add(str, val + 1);
                }
                else map.Add(str, 1);
            }
            int a = 0, b = 0, c = 0;

            foreach (string str in listA)
            {
                if (map[str] == 1)
                {
                    a += 3;
                }
                else if (map[str] == 2)
                {
                    a += 2;
                }
                else
                {
                    a += 1;
                }
            }
            foreach (string str in listB)
            {
                if (map[str] == 1)
                {
                    b += 3;
                }
                else if (map[str] == 2)
                {
                    b += 2;
                }
                else
                {
                    b += 1;
                }
            }
            foreach (string str in listC)
            {
                if (map[str] == 1)
                {
                    c += 3;
                }
                else if (map[str] == 2)
                {
                    c += 2;
                }
                else
                {
                    c += 1;
                }
            }
            return a + "/" + b + "/" + c;

        }

    }

    #endregion

    #region 7. LargestSubsequence

    class LargestSubsequence
    {
        public void doRecursion(string s, int i, HashSet<string> set, StringBuilder cur)
        {
            if (i == s.Length)
            {
                set.Add(cur.ToString());
                return;
            }
            cur.Append(s[i]);
            doRecursion(s, i + 1, set, cur);
            cur.Remove(cur.Length - 1, 1);
            doRecursion(s, i + 1, set, cur);
        }
        public string getLargest(String s)
        {
            List<int> inds = new List<int>();
            char max = s[0];
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] > max)
                {
                    max = s[i];
                }
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == max) inds.Add(i);
            }
            HashSet<string> set = new HashSet<string>();
            foreach (int i in inds)
            {
                doRecursion(s, i, set, new StringBuilder(""));
            }
            List<string> list = new List<string>(set);
            list.Sort();
            return list[list.Count - 1];
        }
    }

    #endregion

    #region 8. MaximumBalances

    class MaximumBalances
    {
        public int solve(string s)
        {
            int open = 0, close = 0;
            foreach (char c in s)
            {
                if (c == '(') open++;
                else close++;
            }
            int min = Math.Min(open, close);
            return min * (min + 1) / 2;
        }
    }

    #endregion

    #region 9. DukeOnChessBoard

    class DukeOnChessBoard
    {
        static StringBuilder ans;
        public void doRecursion(int i, int j, int n, HashSet<string> set, Dictionary<int, char> map, bool[,] visited, string cur)
        {
            if (i < 1 || i > n || j < 1 || j > n || visited[i, j])
            {
                set.Add(cur.ToString());
                cur = new string("");
                return;
            }
            visited[i, j] = true;
            cur += map[i] + "" + j + '-';
            doRecursion(i + 1, j, n, set, map, visited, cur);
            doRecursion(i, j + 1, n, set, map, visited, cur);
            doRecursion(i, j - 1, n, set, map, visited, cur);
            doRecursion(i - 1, j, n, set, map, visited, cur);
        }
        public string dukePath(int n, string initPosition)
        {
            int initX = (int)initPosition[0];
            initX -= 96;
            int initY = initPosition[1] - '0';
            Dictionary<int, char> map = new Dictionary<int, char>();
            for (int i = 1; i <= n; i++)
            {
                map.Add(i, (char)(i + 96));
            }
            ans = new StringBuilder();
            bool[,] visited = new bool[n + 1, n + 1];
            for (int i = 0; i <= n; i++)
            {
                visited[0, i] = true;
                visited[i, 0] = true;
            }

            HashSet<string> set = new HashSet<string>();

            doRecursion(initX, initY, n, set, map, visited, new string(""));

            List<string> list = new List<string>(set);

            list.Sort();

            ans = new StringBuilder(list[list.Count - 1]);
            if (ans.Length <= 0) return ans.ToString();
            return ans.ToString().Substring(0, ans.Length - 1);
        }
    }

    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1. HuffmanDecoding
            HuffmanDecoding huffmanDecoding = new HuffmanDecoding();
            string ans = huffmanDecoding.decode("101101", ["00", "10", "01", "11"]);
            //ans = huffmanDecoding.decode("10111010", ["0","111","10"]);
            //ans = huffmanDecoding.decode("0001001100100111001", ["1","0"]);
            //ans = huffmanDecoding.decode("111011011000100110",["010","00","0110","0111","11","100","101"]);
            //ans = huffmanDecoding.decode("001101100101100110111101011001011001010", ["110","011","10","0011","00011","111","00010","0010","010","0000"]);
            //Console.WriteLine(ans);
            #endregion

            #region 2. LexmaxReplace
            LexmaxReplace lexmaxReplace = new LexmaxReplace();
            //ans = lexmaxReplace.get("abb", "c");
            //ans = lexmaxReplace.get("z", "f");
            //ans = lexmaxReplace.get("fedcba", "ee");
            //ans = lexmaxReplace.get("top", "coder");
            //ans = lexmaxReplace.get("xldyzmsrrwzwaofkcxwehgvtrsximxgdqrhjthkgfucrjdvwlr", "xfpidmmilhdfzypbguentqcojivertdhshstkcysydgcwuwhlk");
            //Console.WriteLine(ans);
            #endregion

            #region 3. SortingSubsets

            SortingSubsets sortingSubsets = new SortingSubsets();
            //Console.WriteLine(sortingSubsets.getMinimalSize([3, 2, 1]));
            //Console.WriteLine(sortingSubsets.getMinimalSize([1,2,3,4]));
            //Console.WriteLine(sortingSubsets.getMinimalSize([4, 4, 4, 3, 3, 3]));
            //Console.WriteLine(sortingSubsets.getMinimalSize([11, 11, 49, 7, 11, 11, 7, 7, 11, 49, 11]));


            #endregion

            #region 4. PalindromeDecoding

            PalindromeDecoding palindromeDecoding = new PalindromeDecoding();
            //Console.WriteLine(palindromeDecoding.decode("ab", [0], [2]));
            //Console.WriteLine(palindromeDecoding.decode("XY", [0, 0, 0, 0], [2, 4, 8, 16]));
            //Console.WriteLine(palindromeDecoding.decode("nodecoding", [], []));
            //Console.WriteLine(palindromeDecoding.decode("TC206", [1, 2, 5], [1, 1, 1]));

            #endregion

            #region 5. MovingAvg

            MovingAvg movingAvg = new MovingAvg();
            //Console.WriteLine(movingAvg.difference(2,[3,8,9,15]));
            //Console.WriteLine(movingAvg.difference(3,[17, 6.2, 19, 3.4]));
            //Console.WriteLine(movingAvg.difference(3,[6, 2.5, 3.5]));

            #endregion

            #region 6. WordCompositionGame

            WordCompositionGame wordCompositionGame = new WordCompositionGame();
            //Console.WriteLine(wordCompositionGame.score(["cat", "dog", "pig", "mouse"], ["cat", "pig"], ["dog", "cat"]));
            //Console.WriteLine(wordCompositionGame.score(["mouse"], ["cat", "pig"], ["dog", "cat"]));
            //Console.WriteLine(wordCompositionGame.score(["dog", "mouse"], ["dog", "pig"], ["dog", "cat"]));
            //Console.WriteLine(wordCompositionGame.score(["bcdbb", "aaccd", "dacbc", "bcbda", "cdedc", "bbaaa", "aecae"], ["bcdbb", "ddacb", "aaccd", "adcab", "edbee", "aecae", "bcbda"], ["dcaab",
            //"aadbe",
            //"bbaaa",
            //"ebeec",
            //"eaecb",
            //"bcbba",
            //"aecae",
            //"adcab",
            //"bcbda"]));

            #endregion

            #region 7. LargestSubsequence

            LargestSubsequence largestSubsequence = new LargestSubsequence();
            //Console.WriteLine(largestSubsequence.getLargest("test"));
            //Console.WriteLine(largestSubsequence.getLargest("a"));
            //Console.WriteLine(largestSubsequence.getLargest("example"));
            //Console.WriteLine(largestSubsequence.getLargest("aquickbrownfoxjumpsoverthelazydog"));
            //Console.WriteLine(largestSubsequence.getLargest("gfdcbazyx"));

            #endregion

            #region 8. MaximumBalances

            MaximumBalances maximumBalances = new MaximumBalances();
            //Console.WriteLine(maximumBalances.solve("(((("));
            //Console.WriteLine(maximumBalances.solve("(())"));
            //Console.WriteLine(maximumBalances.solve(")))())"));
            //Console.WriteLine(maximumBalances.solve("))()()))(()"));

            #endregion

            #region 9. DukeOnChessBoard

            DukeOnChessBoard dukeOnChessBoard = new DukeOnChessBoard();
            //Console.WriteLine(dukeOnChessBoard.dukePath(3, "b2"));
            //Console.WriteLine(dukeOnChessBoard.dukePath(4, "d4"));
            //Console.WriteLine(dukeOnChessBoard.dukePath(3, "a2"));
            //Console.WriteLine(dukeOnChessBoard.dukePath(4, "d3"));
            //Console.WriteLine(dukeOnChessBoard.dukePath(8, "a8"));
            #endregion



        }
    }
}