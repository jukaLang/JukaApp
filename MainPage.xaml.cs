using JukaCompiler;
namespace JukaApp;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        Run_Btn.Text = "Running...";

        SemanticScreenReader.Announce(Run_Btn.Text);
        string data = new Compiler().Go(codeeditor.Text, isFile: false);
        outputText.Text = data;
        Run_Btn.Text = "Run Code";

    }

    private void OnEditorTextChanged(object sender, TextChangedEventArgs e)
    {
        //string oldText = e.OldTextValue ?? "";
        //string newText = e.NewTextValue ?? "";

    }
}