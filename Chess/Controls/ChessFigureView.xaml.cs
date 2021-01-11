namespace Chess.Controls
{
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Input;

    using Chess.Models;

    /// <summary>
    /// Interaction logic for ChessFigureView.xaml
    /// </summary>
    public partial class ChessFigureView : UserControl
    {
        public static readonly DependencyProperty FigureProperty =
                   DependencyProperty.Register(
                         "Figure",
                          typeof(ChessFigure),
                          typeof(ChessFigureView));

        public static readonly DependencyProperty DragInitCommandProperty =
                   DependencyProperty.Register(
                         "DragInitCommand",
                          typeof(ICommand),
                          typeof(ChessFigureView));

        public static readonly DependencyProperty DragOverCommandProperty =
                   DependencyProperty.Register(
                         "DragOverCommand",
                          typeof(ICommand),
                          typeof(ChessFigureView));

        public ChessFigureView()
        {
            InitializeComponent();
        }

        public ChessFigure Figure
        {
            get
            {
                return (ChessFigure)GetValue(FigureProperty);
            }
            set
            {
                SetValue(FigureProperty, value);
            }
        }

        public ICommand DragInitCommand
        {
            get
            {
                return (ICommand)GetValue(DragInitCommandProperty);
            }
            set
            {
                SetValue(DragInitCommandProperty, value);
            }
        }

        public ICommand DragOverCommand
        {
            get
            {
                return (ICommand)GetValue(DragOverCommandProperty);
            }
            set
            {
                SetValue(DragOverCommandProperty, value);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Figure.ToString());
        }

        private void DragInitHandler(object sender, MouseButtonEventArgs e)
        {
            DragInitCommand.Execute(Figure);
        }

        private void DragOverHandler(object sender, MouseButtonEventArgs e)
        {
            DragOverCommand.Execute(Figure);
        }
    }
}
