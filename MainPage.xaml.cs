﻿namespace Birulo;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $" Foi Clicado {count} vez";
		else
			CounterBtn.Text = $" Foi Clicado {count} vezes";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

