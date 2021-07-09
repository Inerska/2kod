using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace _2kod.Views
{
    public partial class MainWritableContentControl : UserControl
    {
        public MainWritableContentControl()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
