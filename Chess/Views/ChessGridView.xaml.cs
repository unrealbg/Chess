namespace Chess.Views
{
    using System.Windows.Controls;

    using Autofac;

    using Chess.ViewModels;

    /// <summary>
    /// Interaction logic for ChessGridView.xaml
    /// </summary>
    public partial class ChessGridView : Page
    {
        public ChessGridView()
        {
            InitializeComponent();
            this.DataContext = Bootstrapper.Container.Resolve<ChessGridViewModel>();
        }
    }
}
