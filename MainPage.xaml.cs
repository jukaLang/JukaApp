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
		String compiler = new Compiler().Go(codeeditor.Text, isFile: false);
		if(compiler != "Error compiling String reference not set to an instance of a String. (Paramter 's')")
		{
            outputText.Text = new Compiler().Go(codeeditor.Text, isFile: false);
        }
		else
		{
			outputText.Text = "";
		}


        RunJukaBtn.Text = $"Execute";

    }
}

