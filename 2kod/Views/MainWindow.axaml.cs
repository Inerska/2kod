namespace _2kod.Views
{
    using Avalonia;
    using Avalonia.Controls;
    using Avalonia.Markup.Xaml;

    /// <summary>
    /// The main window.
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            this.AttachDevTools();

            /*TextBox leftMwc = this.Get<TextEditor>("LeftMainWritableContent");
            DispatcherTimer.RunOnce(() => leftMwc.Focus(), TimeSpan.FromMilliseconds(1));*/

        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
