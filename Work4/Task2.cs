namespace System
{
    public class Task2
    {
        private char[,] board = new char[3, 3];
        private char currentPlayer;

        public Task2()
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    board[i, j] = ' ';

            currentPlayer = 'X';
            Console.WriteLine($"First move: {currentPlayer}");
        }

        public void Start()
        {
            while (true)
            {
                PrintBoard();
                MakeMove();

                if (CheckWin())
                {
                    PrintBoard();
                    Console.WriteLine($"Player {currentPlayer} wins!");
                    break;
                }

                if (IsDraw())
                {
                    PrintBoard();
                    Console.WriteLine("Draw!");
                    break;
                }

                currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
            }
        }

        private void PrintBoard()
        {
            Console.WriteLine("\n-------------");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("| ");
                for (int j = 0; j < 3; j++)
                    Console.Write(board[i, j] + " | ");
                Console.WriteLine("\n-------------");
            }
        }

        private void MakeMove()
        {
            int row, col;

            while (true)
            {
                Console.Write($"Player {currentPlayer}, enter row (0-2): ");
                row = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter column (0-2): ");
                col = Convert.ToInt32(Console.ReadLine());

                if (row >= 0 && col >= 0 && row < 3 && col < 3 && board[row, col] == ' ')
                {
                    board[row, col] = currentPlayer;
                    break;
                }

                Console.WriteLine("Invalid move, try again.");
            }
        }

        private bool CheckWin()
        {
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == currentPlayer && board[i, 1] == currentPlayer && board[i, 2] == currentPlayer)
                    return true;

                if (board[0, i] == currentPlayer && board[1, i] == currentPlayer && board[2, i] == currentPlayer)
                    return true;
            }

            if (board[0, 0] == currentPlayer && board[1, 1] == currentPlayer && board[2, 2] == currentPlayer)
                return true;

            if (board[0, 2] == currentPlayer && board[1, 1] == currentPlayer && board[2, 0] == currentPlayer)
                return true;

            return false;
        }

        private bool IsDraw()
        {
            foreach (char c in board)
                if (c == ' ') return false;
            return true;
        }
    }
}
