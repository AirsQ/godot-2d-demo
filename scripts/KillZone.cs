using Godot;
using System;

public partial class KillZone : Area2D
{
    private Timer timer = null; 
    public override void _Ready()
    {
        timer = GetNode<Timer>("Timer"); 
    }

    void _on_body_entered(Node2D body)
    {
        GD.Print("you die");
        Engine.TimeScale = 0.5f;
        body.GetNode<CollisionShape2D>("CollisionShape2D").QueueFree();
        timer.Start();
    }

    void _on_timer_timeout()
    {
        Engine.TimeScale = 1; 
        GetTree().ReloadCurrentScene();
    }
}
