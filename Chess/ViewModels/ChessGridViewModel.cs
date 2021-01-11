namespace Chess.ViewModels
{
    using System.Collections.ObjectModel;
    using System.Windows.Input;

    using Chess.Models;
    using Chess.Services.Contracts;

    public class ChessGridViewModel
    {
        private readonly IBoardGeneratorService generatorService;
        private readonly IChessRulesService rulesService;
        private ICommand initCommand;
        private ICommand dragInitCommand;
        private ICommand dravOverCommand;
        private ChessFigure selectedFigure;
        private Square[,] board;

        public ChessGridViewModel(IBoardGeneratorService generator, IChessRulesService rulesService)
        {
            this.generatorService = generator;
            this.rulesService = rulesService;
            this.ChessGrid = new ObservableCollection<Square>();
        }

        public ObservableCollection<Square> ChessGrid { get; set; }

        public ICommand InitCommand
        {
            get
            {
                if (initCommand == null)
                {
                    initCommand = new RelayCommand<object>(Init);
                }
                return initCommand;
            }
        }

        public ICommand DragInitCommand
        {
            get
            {
                if (dragInitCommand == null)
                {
                    dragInitCommand = new RelayCommand<ChessFigure>(DragInit);
                }
                return dragInitCommand;
            }
        }

        public ICommand DragOverCommand
        {
            get
            {
                if (dravOverCommand == null)
                {
                    dravOverCommand = new RelayCommand<ChessFigure>(DragOver);
                }
                return dravOverCommand;
            }
        }

        public void Init(object data)
        {
            this.board = generatorService.Generate();

            foreach (var square in board)
            {
                ChessGrid.Add(square);
            }
        }

        public void DragInit(ChessFigure figure)
        {
            selectedFigure = figure;
        }

        public void DragOver(ChessFigure figure)
        {

            dynamic tempFigure = selectedFigure;

            if (!rulesService.Check(board, tempFigure, figure))
            {
                return;
            }

            var selectedSquare = board[selectedFigure.Row, selectedFigure.Col];
            var destinationSquare = board[figure.Row, figure.Col];

            var selectedSquareIndex = ChessGrid.IndexOf(selectedSquare);
            var destinationSquareIndex = ChessGrid.IndexOf(destinationSquare);

            var newSelectedSquare = new Square(selectedSquare.Row, selectedSquare.Col, selectedSquare.Color,
                new Empty(selectedSquare.Row, selectedSquare.Col));

            ChessGrid[selectedSquareIndex] = newSelectedSquare;

            selectedFigure.Row = destinationSquare.Row;
            selectedFigure.Col = destinationSquare.Col;

            var newDestinationSquare = new Square(destinationSquare.Row, destinationSquare.Col, destinationSquare.Color,
                selectedFigure);

            ChessGrid[destinationSquareIndex] = newDestinationSquare;

            board[selectedSquare.Row, selectedSquare.Col] = newSelectedSquare;
            board[destinationSquare.Row, destinationSquare.Col] = newDestinationSquare;
        }
    }
}
