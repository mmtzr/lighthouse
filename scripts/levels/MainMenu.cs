using Godot;
using System;

public partial class MainMenu : Node
{
    [Export] private Button PlayButton;
    [Export] private Button QuitButton;
    private PackedScene MainScene = GD.Load<PackedScene>(GameConstants.MAIN_SCENE);

    public override void _Ready()
    {
        PlayButton.Pressed += OnPlayButtonPressed;
        QuitButton.Pressed += OnQuitButtonPressed;
    }

    private void OnPlayButtonPressed()
    {
        GetTree().ChangeSceneToPacked(MainScene);
    }
    private void OnQuitButtonPressed()
    {
        GetTree().Quit();
    }
}


