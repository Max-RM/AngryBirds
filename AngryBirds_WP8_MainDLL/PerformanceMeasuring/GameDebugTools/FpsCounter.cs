using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace PerformanceMeasuring.GameDebugTools;

public class FpsCounter : DrawableGameComponent
{
	private DebugManager m_a;

	private Stopwatch b;

	private int c;

	private StringBuilder d = new StringBuilder(16);

	[CompilerGenerated]
	private float e;

	[CompilerGenerated]
	private TimeSpan f;

	public float Fps
	{
		[CompilerGenerated]
		get
		{
			return e;
		}
		[CompilerGenerated]
		private set
		{
			e = value;
		}
	}

	public TimeSpan SampleSpan
	{
		[CompilerGenerated]
		get
		{
			return f;
		}
		[CompilerGenerated]
		set
		{
			f = value;
		}
	}

	public FpsCounter(Game game)
		: base(game)
	{
		SampleSpan = TimeSpan.FromSeconds(1.0);
	}

	public override void Initialize()
	{
		this.m_a = ((GameComponent)this).Game.Services.GetService(typeof(DebugManager)) as DebugManager;
		if (this.m_a == null)
		{
			throw new InvalidOperationException("DebugManaer is not registered.");
		}
		if (((GameComponent)this).Game.Services.GetService(typeof(IDebugCommandHost)) is IDebugCommandHost debugCommandHost)
		{
			debugCommandHost.RegisterCommand("fps", "FPS Counter", a);
			((DrawableGameComponent)this).Visible = true;
		}
		Fps = 0f;
		c = 0;
		b = Stopwatch.StartNew();
		d.Length = 0;
		((DrawableGameComponent)this).Initialize();
	}

	private void a(IDebugCommandHost A_0, string A_1, IList<string> A_2)
	{
		if (A_2.Count == 0)
		{
			((DrawableGameComponent)this).Visible = !((DrawableGameComponent)this).Visible;
		}
		foreach (string item in A_2)
		{
			switch (item.ToLower())
			{
			case "on":
				((DrawableGameComponent)this).Visible = true;
				break;
			case "off":
				((DrawableGameComponent)this).Visible = false;
				break;
			}
		}
	}

	public override void Update(GameTime gameTime)
	{
		if (b.Elapsed > SampleSpan)
		{
			Fps = (float)c / (float)b.Elapsed.TotalSeconds;
			b.Reset();
			b.Start();
			c = 0;
			d.Length = 0;
			d.Append("FPS: ");
			d.AppendNumber(Fps);
		}
	}

	public override void Draw(GameTime gameTime)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		c++;
		SpriteBatch spriteBatch = this.m_a.SpriteBatch;
		SpriteFont debugFont = this.m_a.DebugFont;
		Vector2 val = debugFont.MeasureString("X");
		Rectangle val2 = default(Rectangle);
		val2 = new Rectangle(0, 0, (int)(val.X * 14f), (int)(val.Y * 1.3f));
		Layout layout = new Layout(((GraphicsResource)spriteBatch).GraphicsDevice.Viewport);
		val2 = layout.Place(val2, 0.01f, 0.01f, Alignment.TopLeft);
		val = debugFont.MeasureString(d);
		layout.ClientArea = val2;
		Vector2 val3 = layout.Place(val, 0f, 0.1f, Alignment.Center);
		spriteBatch.Begin();
		spriteBatch.Draw(this.m_a.WhiteTexture, val2, new Color(0, 0, 0, 128));
		spriteBatch.DrawString(debugFont, d, val3, Color.White);
		spriteBatch.End();
		((DrawableGameComponent)this).Draw(gameTime);
	}
}
