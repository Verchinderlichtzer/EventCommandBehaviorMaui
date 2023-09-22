namespace EventCommandBehaviorMaui.Views;

public partial class PersonView : ContentPage
{
	public PersonView(PersonViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}