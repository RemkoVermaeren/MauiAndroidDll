using MauiAndroidDll.Proxy;

namespace MauiAndroidDll.App;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnCounterClicked(object sender, EventArgs e)
	{
		var client = new CalculatorClient();

		var result = await client.AddAsync(1, 9);

		CounterBtn.Text = $"Service result : {result}";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}