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
        RunJukaBtn.Text = $"Running Code...";
		
		SemanticScreenReader.Announce(RunJukaBtn.Text);

        outputText.Text = new Compiler().Go(codeeditor.Text, isFile: false);
        

        RunJukaBtn.Text = $"Run Juka Code";

    }
}

