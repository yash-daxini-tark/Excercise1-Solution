using Practice;
using static System.Net.Mime.MediaTypeNames;

namespace Exercise1_UnitTest
{
    [TestClass]
    public class HuffmanDecodingUnitTest
    {
        [TestMethod]
        public void HuffmanDecoding_decode_validateDecoding_returnString()
        {
            var huffmanDecoding = new HuffmanDecoding();
            Assert.AreEqual(huffmanDecoding.decode("101101", ["00", "10", "01", "11"]), "BDC");
            Assert.AreEqual(huffmanDecoding.decode("10111010", ["0", "111", "10"]), "CBAC");
            Assert.AreEqual(huffmanDecoding.decode("0001001100100111001", ["1", "0"]), "BBBABBAABBABBAAABBA");
            Assert.AreEqual(huffmanDecoding.decode("111011011000100110", ["010", "00", "0110", "0111", "11", "100", "101"]), "EGGFAC");
            Assert.AreEqual(huffmanDecoding.decode("001101100101100110111101011001011001010", ["110", "011", "10", "0011", "00011", "111", "00010", "0010", "010", "0000"]), "DBHABBACAIAIC");

        }
    }
    [TestClass]
    public class LexmaxReplaceUnitTest
    {
        [TestMethod]
        public void LexmaxReplace_get_validateAns_returnString()
        {
            var lexmaxReplace = new LexmaxReplace();
            Assert.AreEqual(lexmaxReplace.get("abb", "c"), "cbb");
            Assert.AreEqual(lexmaxReplace.get("z", "f"), "z");
            Assert.AreEqual(lexmaxReplace.get("fedcba", "ee"), "feeeba");
            Assert.AreEqual(lexmaxReplace.get("top", "coder"), "trp");
            Assert.AreEqual(lexmaxReplace.get("xldyzmsrrwzwaofkcxwehgvtrsximxgdqrhjthkgfucrjdvwlr", "xfpidmmilhdfzypbguentqcojivertdhshstkcysydgcwuwhlk"), "zyyyzyxwwwzwvuuttxwtssvtssxrqxppqrontmmllukrkjvwlr");
        }
    }
    [TestClass]
    public class SortingSubsetsUnitTest
    {
        [TestMethod]
        public void SortingSubsets_getMinimalSize_validateAns_returnInt()
        {
            var sortingSubsets = new SortingSubsets();
            Assert.AreEqual(sortingSubsets.getMinimalSize([3, 2, 1]), 2);
            Assert.AreEqual(sortingSubsets.getMinimalSize([1, 2, 3, 4]), 0);
            Assert.AreEqual(sortingSubsets.getMinimalSize([4, 4, 4, 3, 3, 3]), 6);
            Assert.AreEqual(sortingSubsets.getMinimalSize([11, 11, 49, 7, 11, 11, 7, 7, 11, 49, 11]), 7);
        }
    }
    [TestClass]
    public class PalindromeDecodingUnitTest
    {
        [TestMethod]
        public void PalindromeDecoding_decode_validateAns_returnString()
        {
            var palindromeDecoding = new PalindromeDecoding();
            Assert.AreEqual(palindromeDecoding.decode("ab", [0], [2]), "abba");
            Assert.AreEqual(palindromeDecoding.decode("Misip", [2, 3, 1, 7], [1, 1, 2, 2]), "Mississippi");
            Assert.AreEqual(palindromeDecoding.decode("XY", [0, 0, 0, 0], [2, 4, 8, 16]), "XYYXXYYXXYYXXYYXXYYXXYYXXYYXXYYX");
            Assert.AreEqual(palindromeDecoding.decode("TC206", [1, 2, 5], [1, 1, 1]), "TCCC2006");
            Assert.AreEqual(palindromeDecoding.decode("nodecoding", [], []), "nodecoding");
        }
    }
    [TestClass]
    public class MovingAvgUnitTest
    {
        [TestMethod]
        public void MovingAvg_difference_validateAns_returnDouble()
        {
            var movingAvg = new MovingAvg();
            Assert.AreEqual(movingAvg.difference(2, [3, 8, 9, 15]), 6.5);
            Assert.AreEqual(movingAvg.difference(3, [17, 6.2, 19, 3.4]), 4.533333333333335);
            Assert.AreEqual(movingAvg.difference(3, [6, 2.5, 3.5]), 0.0);
        }
    }
    [TestClass]
    public class WordCompositionGameUnitTest
    {
        [TestMethod]
        public void WordCompositionGame_score_validateAns_returnString()
        {
            var wordCompositionGame = new WordCompositionGame();
            Assert.AreEqual(wordCompositionGame.score(["cat", "dog", "pig", "mouse"], ["cat", "pig"], ["dog", "cat"]), "8/3/3");
            Assert.AreEqual(wordCompositionGame.score(["mouse"], ["cat", "pig"], ["dog", "cat"]), "3/5/5");
            Assert.AreEqual(wordCompositionGame.score(["dog", "mouse"], ["dog", "pig"], ["dog", "cat"]), "4/4/4");
            Assert.AreEqual(wordCompositionGame.score(["bcdbb", "aaccd", "dacbc", "bcbda", "cdedc", "bbaaa", "aecae"], ["bcdbb", "ddacb", "aaccd", "adcab", "edbee", "aecae", "bcbda"],
                ["dcaab", "aadbe", "bbaaa", "ebeec", "eaecb", "bcbba", "aecae", "adcab", "bcbda"]), "14/14/21");
        }
    }
    [TestClass]
    public class LargestSubsequenceUnitTest
    {
        [TestMethod]
        public void LargestSubsequence_getLargest_validateAns_returnString()
        {
            var largestSubsequence = new LargestSubsequence();
            Assert.AreEqual(largestSubsequence.getLargest("test"), "tt");
            Assert.AreEqual(largestSubsequence.getLargest("a"), "a");
            Assert.AreEqual(largestSubsequence.getLargest("example"), "xple");
            Assert.AreEqual(largestSubsequence.getLargest("aquickbrownfoxjumpsoverthelazydog"), "zyog");
        }
    }
    [TestClass]
    public class MaximumBalancesUnitTest
    {
        [TestMethod]
        public void MaximumBalances_solve_validateAns_returnInt()
        {
            var maximumBalances = new MaximumBalances();
            Assert.AreEqual(maximumBalances.solve("(((("), 0);
            Assert.AreEqual(maximumBalances.solve("(())"), 3);
            Assert.AreEqual(maximumBalances.solve(")))())"), 1);
            Assert.AreEqual(maximumBalances.solve("))()()))(()"), 10);
        }
    }
    [TestClass]
    public class DukeOnChessBoardUnitTest
    {
        [TestMethod]
        public void DukeOnChessBoard_dukePath_validateAns_returnString()
        {
            var dukeOnChessBoard = new DukeOnChessBoard();
            Assert.AreEqual(dukeOnChessBoard.dukePath(3, "b2"), "b2-c2-c3-b3-a3-a2-a1-b1-c1");
            Assert.AreEqual(dukeOnChessBoard.dukePath(4, "d4"), "d4-d3-d2-d1-c1-c2-c3...b3-b2-b1-a1-a2-a3-a4");
            Assert.AreEqual(dukeOnChessBoard.dukePath(3, "a2"), "a2-b2-c2-c3-b3-a3");
            Assert.AreEqual(dukeOnChessBoard.dukePath(4, "d3"), "d3-d4-c4-c3-c2-d2-d1...b2-b3-b4-a4-a3-a2-a1");
            Assert.AreEqual(dukeOnChessBoard.dukePath(8, "a8"), "a8-b8-c8-d8-e8-f8-g8...a1-a2-a3-a4-a5-a6-a7");
        }
    }
    [TestClass]
    public class IslandsUnitTest
    {
        [TestMethod]
        public void Islands_beachLength_validateAns_returnInt()
        {
            var islands = new Islands();
            Assert.AreEqual(islands.beachLength([".#...#.."]), 4);
            Assert.AreEqual(islands.beachLength(["..#.##", ".##.#.", "#.#..."]), 19);
            Assert.AreEqual(islands.beachLength(["#...#.....", "##..#...#."]), 15);
            Assert.AreEqual(islands.beachLength(["....#.", ".#....", "..#..#", "####.."]), 24);
        }
    }
    [TestClass]
    public class MailboxUnitTest
    {
        [TestMethod]
        public void Mailbox_impossible_validateAns_returnInt()
        {
            var mailbox = new Mailbox();
            Assert.AreEqual(mailbox.impossible("AAAAAAABBCCCCCDDDEEE123456789", ["123C", "123A", "123 ADA"]), 0);
            Assert.AreEqual(mailbox.impossible("ABCDEFGHIJKLMNOPRSTUVWXYZ1234567890", ["2 FIRST ST", " 31 QUINCE ST", "606 BAKER"]), 3);
            Assert.AreEqual(mailbox.impossible("ABCDAAST", ["111 A ST", "A BAD ST", "B BAD ST"]), 2);
        }
    }
    [TestClass]
    public class MysticAndCandiesEasyUnitTest
    {
        [TestMethod]
        public void MysticAndCandiesEasy_minBoxes_validateAns_returnInt()
        {
            var mysticAndCandiesEasy = new MysticAndCandiesEasy();
            Assert.AreEqual(mysticAndCandiesEasy.minBoxes(10, 10, [20]), 1);
            Assert.AreEqual(mysticAndCandiesEasy.minBoxes(10, 7, [3, 3, 3, 3, 3]), 4);
            Assert.AreEqual(mysticAndCandiesEasy.minBoxes(100, 63, [12, 34, 23, 45, 34]), 3);
            Assert.AreEqual(mysticAndCandiesEasy.minBoxes(19, 12, [12, 9, 15, 1, 6, 4, 9, 10, 10, 10, 14, 14, 1, 1, 12, 10, 9, 2, 3, 6, 1, 7, 3, 4, 10, 3, 14]), 22);
            Assert.AreEqual(mysticAndCandiesEasy.minBoxes(326, 109, [9,13,6,6,6,16,16,16,10,16,4,3,10,8,11,17,12,5,7,8,7,4,15,7,14,2,2,1,17,1,7,7,12,17,2,9,7,1,8,16,7,4,
                16,2,13,3,13,1,17,6]), 15);
        }
    }
    [TestClass]
    public class PrintSchedulerUnitTest
    {
        [TestMethod]
        public void PrintScheduler_getOutput_validateAns_returnString()
        {
            var printScheduler = new PrintScheduler();
            Assert.AreEqual(printScheduler.getOutput(["AB", "CD"], ["0 1", "1 1", "0 1", "1 2"]), "ACBDC");
            Assert.AreEqual(printScheduler.getOutput(["ABCDE"], ["0 20", "0 21"]), "ABCDEABCDEABCDEABCDEABCDEABCDEABCDEABCDEA");
            Assert.AreEqual(printScheduler.getOutput(["A", "B"], ["1 10", "0 1", "1 10", "0 2"]), "BBBBBBBBBBABBBBBBBBBBAA");
            Assert.AreEqual(printScheduler.getOutput(["A"], ["0 1"]), "A");
        }
    }
    [TestClass]
    public class TurningLightOnUnitTest
    {
        [TestMethod]
        public void TurningLightOn_minFlips_validateAns_returnInt()
        {
            var turningLightOn = new TurningLightOn();
            Assert.AreEqual(turningLightOn.minFlips(["0001111", "0001111", "1111111"]), 1);
            Assert.AreEqual(turningLightOn.minFlips(["1111111", "1111111", "1111111"]), 0);
            Assert.AreEqual(turningLightOn.minFlips(["01001"]), 3);
            Assert.AreEqual(turningLightOn.minFlips(["0101", "1010", "0101", "1010"]), 7);
        }
    }
}