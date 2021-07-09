namespace _2kod.ViewModels
{
    using System.Reactive;
    using System.Text;

    using Avalonia.Controls;

    using ReactiveUI;
    using ReactiveUI.Fody.Helpers;

    public class MainWritableControlViewModel : ViewModelBase
    {
        public MainWritableControlViewModel()
        {
            TabulationInFocusCommand = ReactiveCommand.Create(ExecuteTabulationInFocus);

            //TextSource = IsFocused.ToString();
            WaterMark = IsFocused.ToString();
        }

        public ReactiveCommand<Unit, Unit> TabulationInFocusCommand { get; }

        public bool IsFocused { get; }

        [Reactive]
        public string TextSource { get; set; }

        [Reactive]
        public string WaterMark { get; set; }

        [Reactive]
        public int CaretIndex { get; set; }


        private void ExecuteTabulationInFocus()
        {
            //TextSource += '\t';

            //CaretIndex = TextSource.LastIndexOfAny(new[] { '\t' }) + 1;
        }
    }
}