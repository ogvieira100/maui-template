namespace Birulo;

public partial class GridPrincipal : ContentPage
{
	public GridPrincipal()
	{
		InitializeComponent();
	}

    private void CounterBtn_Clicked(object sender, EventArgs e)
    {

    }

    private void FlyoutPageBtn_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new FlyoutPageDemo());
    }

    private void ContentPage_Clicked(object sender, EventArgs e)
    {
        //
        Navigation.PushAsync(new PaginaContent());
    }

    private void TabbletPage_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new TabbletPageDemo());
    }

    private void StackLayoutPage_Clicked(object sender, EventArgs e)
    {
        //
        Navigation.PushAsync(new StackLayoutDemo());
    }

    private void GridPageDemo_Clicked(object sender, EventArgs e)
    {
          Navigation.PushAsync(new GridPageDemonstracao());

    }

    private void AbsolutLayoutDemo_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AbsoluteLayoutDemo());

    }

    private void FlexLayout_Clicked(object sender, EventArgs e)
    {
        //
        Navigation.PushAsync(new FlexLayout());
    }

    private void HorStackLayout_Clicked(object sender, EventArgs e)
    {
        //
        Navigation.PushAsync(new HorizontalStackLayout());
    }

    private void VerStackLayout_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new VerticalStackLayout());
    }

    private void ControlsPresentention_Clicked(object sender, EventArgs e)
    {
        //
        Navigation.PushAsync(new ControlesApresentacao());
    }

    private void CommandsControls_Clicked(object sender, EventArgs e)
    {
        //
        Navigation.PushAsync(new CommandsControlsDemo());
    }

    private void InputControls_Clicked(object sender, EventArgs e)
    {
        //
        Navigation.PushAsync(new InputControlsDemo());
    }

    private void TextControls_Clicked(object sender, EventArgs e)
    {
        //
        Navigation.PushAsync(new TextControlsDemo());
    }

    private void ActivityControls_Clicked(object sender, EventArgs e)
    {
        //
        Navigation.PushAsync(new ActivityControlsDemo());
    }

    private void CollectionsControls_Clicked(object sender, EventArgs e)
    {
        //
        Navigation.PushAsync(new CollectionsControlsDemo());
    }
}