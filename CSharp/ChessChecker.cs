using System;
using System.Collections.Generic;

namespace PracticeCode
{
    class ChessChecker
    {
        private List<char> _columns;
        private List<int> _rows;

        public ChessChecker()
        {
            InitiliseChessBoard();
        }

        public List<string> ValidKnightPositions(char startColumn, int startRow)
        {
            if (!ValidateBoardPosition(startColumn, startRow))
                throw new ArgumentOutOfRangeException("board position not valid");

            int startColumnNumber = CharToInt(startColumn);

            bool isStartSquareBlack = IsBlackSquare(startColumnNumber, startRow);

            List<string> validPositions = new List<string>();
            List<int> potentialColumns = new List<int>();
            List<int> potentialRows = new List<int>();

            int potentialColumn;
            int potentialRow;

            for (int i = -2; i <= 2; i++)
            {
                potentialColumn = CharToInt(startColumn) + i;
                potentialRow = startRow + i;

                if (i != 0)
                {
                    potentialColumns.Add(potentialColumn);
                    potentialRows.Add(potentialRow);
                }
            }

            foreach (var column in potentialColumns)
            {
                foreach (var row in potentialRows)
                {
                    if (ValidateBoardPosition(IntToChar(column), row) && isStartSquareBlack != IsBlackSquare(column, row))
                        validPositions.Add(IntToChar(column) + row.ToString());
                }
            }

            return validPositions;
        }

        private bool ValidateBoardPosition(char column, int row) => _columns.Contains(column) && _rows.Contains(row);

        private void InitiliseChessBoard()
        {
            _columns = new List<char>();
            _rows = new List<int>();

            char column = 'a';

            for (int i = 0; i < 8; i++)
            {
                _columns.Add(column);
                _rows.Add(i + 1);
                column++;
            }
        }

        private int CharToInt(char column) => column - 96;
        private char IntToChar(int column) => Convert.ToChar(column + 96);

        // Sum of row and column for black square is always even
        private bool IsBlackSquare(int column, int row) => (column + row) % 2 == 0;
    }
}
