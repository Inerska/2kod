using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace _2kod.Views
{
    using _2kod.ViewModels;

    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
