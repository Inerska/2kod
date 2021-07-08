namespace _2kod.ViewModels
{
    using System.Reactive;

    using Avalonia;
    using Avalonia.Controls.ApplicationLifetimes;

    using ReactiveUI;

    public sealed class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            CloseWindowContextCommand = ReactiveCommand.Create(ExecuteCloseWindowContext);
        }

        public ReactiveCommand<Unit, Unit> CloseWindowContextCommand { get; }

        private static void ExecuteCloseWindowContext()
        {
            if (Application.Current.ApplicationLifetime is IClassicDesktopStyleApplicationLifetime applicationLifetime)
            {
                applicationLifetime.Shutdown();
            }
        }
    }
}
