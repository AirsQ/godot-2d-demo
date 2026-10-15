using Godot;
using System;

public partial class GameManager : Node
{
    private int score = 0;
    
    private Label scoreLabel;

    public override void _Ready()
    {
        scoreLabel = GetNode<Label>("ScoreLabel");
    }

    public void AddPoint()
    {
        score++;
        scoreLabel.Text = $"Great! \n You get {score} coins!";
        GD.Print(score );
    }
    
    
}
