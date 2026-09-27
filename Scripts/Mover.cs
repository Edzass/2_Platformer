using Godot;

public partial class Mover : Node2D
{
	
	[Export] public float Speed = 200.0f;

	public override void _PhysicsProcess(double delta)
	{
		GD.Print($"Physics: {delta:F4}");
		Position += new Vector2(Speed, 0) * (float)delta;
		if (Position.X > 1200)
			Position = new Vector2(80, Position.Y);
	}
}
