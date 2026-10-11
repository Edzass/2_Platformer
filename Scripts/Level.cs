using Godot;

public partial class Level : Node2D
{
	[Export] public string GameTitle = "Skrējies pēc Iphone 18";
	[Export] public string Mission = "Atrodi jauno Iphone 18 un sasniedz zilās durvis. Izvairies no sarkanās bedres!";
	[Export] public string WinText = "Tu esi veiksīmi izkļuvis no spēles ar jaunu telefonu.";
	[Export] public string LoseText = "Tu zaudēji. Mēģini vēlreiz!";
	[Export] public string LockedText = "Vispirms savāci visus punktus, lai varētu piekļūt telefonam.";
	[Export] public string KeyCollectedText = "Telefons ir iegūts! Tagad dodies uz zilajām durvīm.";
	private bool keyShown = false;
	private bool keyMessageShown = false;
	
	private Polygon2D finishVisual;
	private Player player;
	private Area2D key;
	private Label status;
	private Label message;
	public bool GameEnded { get; private set; } = false;

	public override void _Ready()
	{
		player = GetNode<Player>("Player");
		status = GetNode<Label>("HUD/Status");
		message = GetNode<Label>("HUD/Message");
		GetNode<Label>("HUD/Instructions").Text =
			$"{GameTitle} | A/D vai ←/→: kustība | Space: lēciens | R: sākt no jauna";
		
		GetNode<Area2D>("Finish").BodyEntered += OnFinishEntered;
		GetNode<Area2D>("Hazard").BodyEntered += OnHazardEntered;
		UpdateHud();
		
		key = GetNode<Area2D>("Key");
		key.Hide();
		key.Monitoring = false;
		
		message.Text = LockedText;
		
		finishVisual = GetNode<Polygon2D>("Finish/Visual");
		finishVisual.Hide();
	}

	public override void _Process(double delta)
	{
		if (Input.IsActionJustPressed("restart"))
		{
			GetTree().ReloadCurrentScene();
			return;
		}

		if (!GameEnded && player.GlobalPosition.Y > 800)
			EndGame(false);
		
		if (player.Score >= 9 && !player.HasKey && !keyShown)
		{
		key.Show();
		key.Monitoring = true;
		keyShown = true;
		}
		
		if (player.HasKey)
		{
		finishVisual.Show();

			if (!keyMessageShown)
			{
	   		message.Text = KeyCollectedText;
			keyMessageShown = true;
   		 	}
		}
		
		UpdateHud();
	}

	private void UpdateHud()
	{
		string keyStatus = player.HasKey ? "ir" : "nav";
		status.Text = $"Punkti: {player.Score} | Telefons: {keyStatus}";
	}

	private void OnFinishEntered(Node2D body)
	{
		if (body != player || GameEnded) return;

		if (player.HasKey)
			EndGame(true);
		else
			message.Text = LockedText;
	}

	private void OnHazardEntered(Node2D body)
	{
		if (body == player) EndGame(false);
	}

	private void EndGame(bool won)
	{
		if (GameEnded) return;
		GameEnded = true;
		player.IsActive = false;
		player.Velocity = Vector2.Zero;
		message.Text = (won ? WinText : LoseText) + " | Nospied R, lai spēlētu vēlreiz.";
		UpdateHud();
	}
}
