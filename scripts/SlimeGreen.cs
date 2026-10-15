using Godot;
using System;

public partial class SlimeGreen : Node2D
{
	private const int SPEED = 60;

	private int direction = 1;

	private RayCast2D rayCastRight = null;
	private RayCast2D rayCastLeft = null;
	private AnimatedSprite2D animatedSprite = null;
	
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		rayCastRight = GetNode<RayCast2D>("RayCastRight");
		rayCastLeft = GetNode<RayCast2D>("RayCastLeft");
		animatedSprite = GetNode<AnimatedSprite2D>("AnimatedSprite2D");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (rayCastRight.IsColliding())
		{
			direction *= -1;
			animatedSprite.FlipH = true;
		}

		if (rayCastLeft.IsColliding())
		{
			direction *= -1;
			animatedSprite.FlipH = false;
		}
		
		var x = (float)(Position.X + (direction * SPEED * delta));
		Position = new Vector2(x, Position.Y);
	}
}
