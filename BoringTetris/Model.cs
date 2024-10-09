namespace BoringTetris
{
    internal class Model
    {
        // antal rader
        private int numRows;

        // antal kolumner
        private int numCols;

        private int score;

        // matris som innehåller alla blockens tillstånd
        // false betyder att de är tomma, true att de blivit klickade
        private bool[,] matrix;

        public Model(int numRows, int numCols)
        {
            this.numRows = numRows;
            this.numCols = numCols;
            matrix = new bool[numRows, numCols];
        }

        /// <summary>
        /// Hämta ett blocks tillstånd. Returnerar false om blocket är tomt.
        /// </summary>
        public bool Get(int row, int col)
        {
            return matrix[row, col];
        }

        /// <summary>
        /// Sätt ett blocks tillstånd. Om en hel rad blir full tas den bort.
        /// </summary>
        public void Set(int row, int col)
        {
            matrix[row, col] = true;
            clearAnyCompleteRows();
        }

        /// <summary>
        /// Töm alla block från innehåll. D.v.s. starta om spelet.
        /// </summary>
        public void Clear()
        {
            score = 0;

            for (int row = 0; row < numRows; row++)
            {
                clearRow(row);
            }
        }

        /// <summary>
        /// Hämta totala antalet rader.
        /// </summary>
        public int NumRows()
        {
            return numRows;
        }

        /// <summary>
        /// Hämta totala antalet kolumner.
        /// </summary>
        public int NumCols()
        {
            return numCols;
        }

        /// <summary>
        /// Tabort alla rader som blivit klickade.
        /// </summary>
        private void clearAnyCompleteRows()
        {
            // för varje rad
            for (int row = 0; row < numRows; row++)
            {
                // om alla block i raden blivit klickade
                if (isRowComplete(row))
                {
                    // återställ raden och ökar med 
                    score++;
                    clearRow(row);
                }
            }
        }

        // hämta score
        public int GetScore() 
        { 
            return score; 
        }

        /// <summary>
        /// Returnerar true om raden är helt iklickad.
        /// </summary>
        private bool isRowComplete(int row)
        {
            // för varje block i raden
            for (int col = 0; col < numCols; col++)
            {
                // om någon inte är klickad, returnerar false
                if (matrix[row, col] == false)
                {
                    return false;
                }
            }
            // annars returnera true
            return true;
        }

        /// <summary>
        /// Återställ en rad.
        /// </summary>
        private void clearRow(int row)
        {
            for (int col = 0; col < numCols; col++)
            {
                matrix[row, col] = false;
            }
        }
    }
}
