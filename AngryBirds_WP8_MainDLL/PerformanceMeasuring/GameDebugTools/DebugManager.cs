using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace PerformanceMeasuring.GameDebugTools;

public class DebugManager : DrawableGameComponent
{
	private string a;

	[CompilerGenerated]
	private SpriteBatch b;

	[CompilerGenerated]
	private Texture2D c;

	[CompilerGenerated]
	private SpriteFont d;

	public SpriteBatch SpriteBatch
	{
		[CompilerGenerated]
		get
		{
			return b;
		}
		[CompilerGenerated]
		private set
		{
			b = value;
		}
	}

	public Texture2D WhiteTexture
	{
		[CompilerGenerated]
		get
		{
			return c;
		}
		[CompilerGenerated]
		private set
		{
			c = value;
		}
	}

	public SpriteFont DebugFont
	{
		[CompilerGenerated]
		get
		{
			return d;
		}
		[CompilerGenerated]
		private set
		{
			d = value;
		}
	}

	public DebugManager(Game game, string debugFont)
		: base(game)
	{
		((GameComponent)this).Game.Services.AddService(typeof(DebugManager), (object)this);
		a = debugFont;
		((GameComponent)this).Enabled = false;
		((DrawableGameComponent)this).Visible = false;
	}

	protected override void LoadContent()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		SpriteBatch = new SpriteBatch(((DrawableGameComponent)this).GraphicsDevice);
		DebugFont = ((GameComponent)this).Game.Content.Load<SpriteFont>(a);
		WhiteTexture = new Texture2D(((DrawableGameComponent)this).GraphicsDevice, 1, 1);
		Color[] data = (Color[])(object)new Color[1] { Color.White };
		WhiteTexture.SetData<Color>(data);
		((DrawableGameComponent)this).LoadContent();
	}
}
