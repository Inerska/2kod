using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace _2kod.Views
{
    using ReactiveUI;

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
