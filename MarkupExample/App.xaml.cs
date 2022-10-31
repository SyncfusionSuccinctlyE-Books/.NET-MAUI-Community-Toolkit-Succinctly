namespace MarkupExample;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new SampleContentPage(); // new AppShell();
	}
}
