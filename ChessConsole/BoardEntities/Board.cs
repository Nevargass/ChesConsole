namespace ChessConsole.BoardEntities
{
    internal class Board
    {
        public int BoardLines { get; set; }
        public int BoardColumns { get; set; }
        private Piece[,] piece;

        public Board(int boardLines, int boardColumns)
        {
            BoardLines = boardLines;
            BoardColumns = boardColumns;
            piece = new Piece[BoardLines, BoardColumns];
        }
    }
}
