/*
Deoxyribonucleic acid (DNA) is a chemical found in the nucleus of cells and carries the "instructions" for the development and functioning of living organisms.
If you want to know more: http://en.wikipedia.org/wiki/DNA

In DNA strings, symbols "A" and "T" are complements of each other, as "C" and "G".
Your function receives one side of the DNA (string, except for Haskell); you need to return the other complementary side.
DNA strand is never empty or there is no DNA at all (again, except for Haskell).
More similar exercise are found here: http://rosalind.info/problems/list-view/ (source)

Example: (input --> output)

"ATTGC" --> "TAACG"
"GTAT" --> "CATA"
dnaStrand []        `shouldBe` []
dnaStrand [A,T,G,C] `shouldBe` [T,A,C,G]
dnaStrand [G,T,A,T] `shouldBe` [C,A,T,A]
dnaStrand [A,A,A,A] `shouldBe` [T,T,T,T]
*/

using System.Text;

namespace CodeWars_Playground.Kata
{
    public static class DNA
    {
        public static string MakeComplement(string dna)
        {
            string dna1 = "ATCG";
            string dna2 = "TAGC";
            StringBuilder sb = new StringBuilder();

            foreach(char c in dna)
            {
                sb.Append(dna2[dna1.IndexOf(c)]);
            }

            return sb.ToString();
        }
    }
}

