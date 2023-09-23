namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void MsgTxt_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void OnEntryTextChanged(object sender, TextChangedEventArgs e)
        {
            
            string newText = e.NewTextValue;
            DisplayLbl.Text = newText;
        }
    }
}