namespace BindableLayoutTest;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

        var items = Enumerable.Range(1, 200)
            .Select(_ => $"Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's...: {_}")
            .ToList();

		BindableLayout.SetItemsSource(InnerVerticalStackLayout, items);
    }
}

