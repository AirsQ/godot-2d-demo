using Godot;
using System;

public partial class Coin : Area2D
{
	
	GameManager _gamemanager;
	AnimationPlayer animationPlayer;

	public override void _Ready()
	{
		_gamemanager = GetNodeOrNull<GameManager>("%GameManager");
		animationPlayer = GetNodeOrNull<AnimationPlayer>("AnimationPlayer");
	}

	void _on_body_entered(Node2D body)
	{
		GD.Print("add coin!");
		_gamemanager.AddPoint();
		animationPlayer.Play("pickup");
		
		// QueueFree();
	}
}
