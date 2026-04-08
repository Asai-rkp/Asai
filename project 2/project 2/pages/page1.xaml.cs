namespace project_2.NewFolder;

public partial class page1 : ContentPage
{
	public page1()
	{
		InitializeComponent();
		BindingContext = new SampleViewModel();
	}
}