
using BoyerMooreStringAlgorithm;

char[] txt = "ABAAABCD".ToCharArray();
char[] pat = "ABC".ToCharArray();
BoyerMooreStringMatching.Search(txt, pat);

Console.ReadLine();
