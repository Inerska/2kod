using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace _2kod.Views
{
    /// <summary>
    /// The main writable content control.
    /// </summary>
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
