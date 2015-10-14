using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAllPossibleWordsFromBoardOfCharacters
{
    class FindPossibleWordsFromBoard
    {
        static String[] dictionary = {"GEEKS", "FOR", "QUIZ", "GO"};
        static char[,] board = new char[,]{{'G','I','Z'},
                                    {'U','E','K'},
                                    {'Q','S','E'}};

        static void Main(string[] args)
        {
            FindWords();
        }

        private static void FindWords()
        {
            int M = board.GetLength(0);
            int N = board.GetLength(1);

            String str = "";
            bool[,] visited = new bool[M, N];

            for(int i=0;i<M;++i)
            {
                for(int j=0;j<N;++j)
                {
                    // xxx(board, visited, i,j str);
                    foo(board, visited, i,j str);
                }
            }
        }

        private static void foo(char[,] board1, bool[,] visited, int i, int j, String str)
        {
            throw new NotImplementedException();
        }

        private static void xxx(char[,] board, bool[,] visited, int i, int j, String str)
        { 
            
        }
    }
}
