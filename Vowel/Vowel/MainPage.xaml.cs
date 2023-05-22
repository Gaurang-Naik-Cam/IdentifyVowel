namespace Vowel;

public partial class MainPage : ContentPage
{
	string[] vowels = { "a", "e", "i", "o", "u" };

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnClicked(object sender, EventArgs e)
	{
		string input = txtbxAlphabet.Text;
		if (!string.IsNullOrEmpty(input))
		{
			if (vowels.Contains<string>(input.ToLower()))
			{
				lblOutput.Text = "This is a Vowel.";
            }
			else
			{
                lblOutput.Text = "This is not a Vowel.";
            }
		}
		

	}
}

