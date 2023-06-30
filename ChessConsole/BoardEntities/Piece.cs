using ChessConsole.Entities.Enums;

namespace ChessConsole.BoardEntities
{
    internal class Piece
    {
        public Position position { get; set; }
        public Color color { get; protected set; }
        public int MovQuantity { get; protected set; }
        public Board board { get; set; }

        public Piece(Position position, Color color, Board board)
        {
            this.position = position;
            this.color = color;
            this.board = board;
            MovQuantity = 0;
        }
    }
}
