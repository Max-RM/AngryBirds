#define TRACE
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace PerformanceMeasuring.GameDebugTools;

public class TimeRuler : DrawableGameComponent
{
	private struct NestedStructA
	{
		public int a;

		public float b;

		public float c;

		public Color d;
	}

	private class c
	{
		public a[] a = new a[256];

		public int b;

		public int[] c = new int[32];

		public int d;
	}

	private class e
	{
		public c[] a;

		public e()
		{
			a = new c[8];
			for (int i = 0; i < 8; i++)
			{
				a[i] = new c();
			}
		}
	}

	private class d
	{
		public string a;

		public b[] b = new b[8];

		public d(string A_0)
		{
			a = A_0;
		}
	}

	private struct b
	{
		public float a;

		public float b;

		public float c;

		public float d;

		public float e;

		public float f;

		public int g;

		public Color h;

		public bool i;
	}

	private DebugManager m_a;

	private e[] m_b;

	private e m_c;

	private e m_d;

	private int m_e;

	private Stopwatch f = new Stopwatch();

	private List<d> g = new List<d>();

	private Dictionary<string, int> h = new Dictionary<string, int>();

	private int i;

	private int j;

	private StringBuilder k = new StringBuilder(512);

	private int l;

	private Vector2 m;

	[CompilerGenerated]
	private bool n;

	[CompilerGenerated]
	private int o;

	[CompilerGenerated]
	private int p;

	public bool ShowLog
	{
		[CompilerGenerated]
		get
		{
			return n;
		}
		[CompilerGenerated]
		set
		{
			n = value;
		}
	}

	public int TargetSampleFrames
	{
		[CompilerGenerated]
		get
		{
			return o;
		}
		[CompilerGenerated]
		set
		{
			o = value;
		}
	}

	public Vector2 Position
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return m;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			m = value;
		}
	}

	public int Width
	{
		[CompilerGenerated]
		get
		{
			return p;
		}
		[CompilerGenerated]
		set
		{
			p = value;
		}
	}

	public TimeRuler(Game game)
		: base(game)
	{
		((GameComponent)this).Game.Services.AddService(typeof(TimeRuler), (object)this);
	}

	public override void Initialize()
	{
		this.m_a = ((GameComponent)this).Game.Services.GetService(typeof(DebugManager)) as DebugManager;
		if (this.m_a == null)
		{
			throw new InvalidOperationException("DebugManager is not registered.");
		}
		if (((GameComponent)this).Game.Services.GetService(typeof(IDebugCommandHost)) is IDebugCommandHost debugCommandHost)
		{
			debugCommandHost.RegisterCommand("tr", "TimeRuler", a);
			((DrawableGameComponent)this).Visible = true;
		}
		this.m_b = new e[2];
		for (int i = 0; i < this.m_b.Length; i++)
		{
			this.m_b[i] = new e();
		}
		int num2 = (TargetSampleFrames = 1);
		j = num2;
		((GameComponent)this).Enabled = false;
		((DrawableGameComponent)this).Initialize();
	}

	protected override void LoadContent()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		Viewport viewport = ((DrawableGameComponent)this).GraphicsDevice.Viewport;
		Width = (int)((float)viewport.Width * 0.8f);
		m = new Layout(((DrawableGameComponent)this).GraphicsDevice.Viewport).Place(new Vector2((float)Width, 8f), 0f, 0.01f, Alignment.BottomCenter);
		((DrawableGameComponent)this).LoadContent();
	}

	private void a(IDebugCommandHost A_0, string A_1, IList<string> A_2)
	{
		bool visible = ((DrawableGameComponent)this).Visible;
		if (A_2.Count == 0)
		{
			((DrawableGameComponent)this).Visible = !((DrawableGameComponent)this).Visible;
		}
		char[] separator = new char[1] { ':' };
		foreach (string item in A_2)
		{
			string text = item.ToLower();
			string[] array = text.Split(separator);
			switch (array[0])
			{
			case "on":
				((DrawableGameComponent)this).Visible = true;
				break;
			case "off":
				((DrawableGameComponent)this).Visible = false;
				break;
			case "reset":
				ResetLog();
				break;
			case "log":
				if (array.Length > 1)
				{
					if (string.Compare(array[1], "on") == 0)
					{
						ShowLog = true;
					}
					if (string.Compare(array[1], "off") == 0)
					{
						ShowLog = false;
					}
				}
				else
				{
					ShowLog = !ShowLog;
				}
				break;
			case "frame":
			{
				int val = int.Parse(array[1]);
				val = Math.Max(val, 1);
				val = Math.Min(val, 4);
				TargetSampleFrames = val;
				break;
			}
			case "/?":
			case "--help":
				A_0.Echo("tr [log|on|off|reset|frame]");
				A_0.Echo("Options:");
				A_0.Echo("       on     Display TimeRuler.");
				A_0.Echo("       off    Hide TimeRuler.");
				A_0.Echo("       log    Show/Hide marker log.");
				A_0.Echo("       reset  Reset marker log.");
				A_0.Echo("       frame:sampleFrames");
				A_0.Echo("              Change target sample frame count");
				break;
			}
		}
		if (((DrawableGameComponent)this).Visible != visible)
		{
			Interlocked.Exchange(ref l, 0);
		}
	}

	[Conditional("TRACE")]
	public void StartFrame()
	{
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		lock (this)
		{
			int num = Interlocked.Increment(ref l);
			if (((DrawableGameComponent)this).Visible && 1 < num && num < 4)
			{
				return;
			}
			this.m_c = this.m_b[this.m_e++ & 1];
			this.m_d = this.m_b[this.m_e & 1];
			float num2 = (float)f.Elapsed.TotalMilliseconds;
			for (int i = 0; i < this.m_c.a.Length; i++)
			{
				c c = this.m_c.a[i];
				c c2 = this.m_d.a[i];
				for (int j = 0; j < c.d; j++)
				{
					int num3 = c.c[j];
					c.a[num3].c = num2;
					c2.c[j] = j;
					c2.a[j].a = c.a[num3].a;
					c2.a[j].b = 0f;
					c2.a[j].c = -1f;
					c2.a[j].d = c.a[num3].d;
				}
				for (int k = 0; k < c.b; k++)
				{
					float num4 = c.a[k].c - c.a[k].b;
					int index = c.a[k].a;
					d d = g[index];
					d.b[i].h = c.a[k].d;
					if (!d.b[i].i)
					{
						d.b[i].d = num4;
						d.b[i].e = num4;
						d.b[i].f = num4;
						d.b[i].i = true;
						continue;
					}
					d.b[i].d = Math.Min(d.b[i].d, num4);
					d.b[i].e = Math.Min(d.b[i].e, num4);
					d.b[i].f += num4;
					d.b[i].f *= 0.5f;
					if (d.b[i].g++ >= 120)
					{
						d.b[i].a = d.b[i].d;
						d.b[i].b = d.b[i].e;
						d.b[i].c = d.b[i].f;
						d.b[i].g = 0;
					}
				}
				c2.b = c.d;
				c2.d = c.d;
			}
			f.Reset();
			f.Start();
		}
	}

	[Conditional("TRACE")]
	public void BeginMark(string markerName, Color color)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		BeginMark(0, markerName, color);
	}

	[Conditional("TRACE")]
	public void BeginMark(int barIndex, string markerName, Color color)
	{
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		lock (this)
		{
			if (barIndex < 0 || barIndex >= 8)
			{
				throw new ArgumentOutOfRangeException("barIndex");
			}
			c c = this.m_d.a[barIndex];
			if (c.b >= 256)
			{
				throw new OverflowException("Exceeded sample count.\nEither set larger number to TimeRuler.MaxSmpale orlower sample count.");
			}
			if (c.d >= 32)
			{
				throw new OverflowException("Exceeded nest count.\nEither set larget number to TimeRuler.MaxNestCall orlower nest calls.");
			}
			if (!h.TryGetValue(markerName, out var value))
			{
				value = g.Count;
				h.Add(markerName, value);
				g.Add(new d(markerName));
			}
			c.c[c.d++] = c.b;
			c.a[c.b].a = value;
			c.a[c.b].d = color;
			c.a[c.b].b = (float)f.Elapsed.TotalMilliseconds;
			c.a[c.b].c = -1f;
			c.b++;
		}
	}

	[Conditional("TRACE")]
	public void EndMark(string markerName)
	{
		EndMark(0, markerName);
	}

	[Conditional("TRACE")]
	public void EndMark(int barIndex, string markerName)
	{
		lock (this)
		{
			if (barIndex < 0 || barIndex >= 8)
			{
				throw new ArgumentOutOfRangeException("barIndex");
			}
			c c = this.m_d.a[barIndex];
			if (c.d <= 0)
			{
				throw new InvalidOperationException("Call BeingMark method before call EndMark method.");
			}
			if (!h.TryGetValue(markerName, out var value))
			{
				throw new InvalidOperationException($"Maker '{markerName}' is not registered.Make sure you specifed same name as you used for BeginMark method.");
			}
			int num = c.c[--c.d];
			if (c.a[num].a != value)
			{
				throw new InvalidOperationException("Incorrect call order of BeginMark/EndMark method.You call it like BeginMark(A), BeginMark(B), EndMark(B), EndMark(A) But you can't call it like BeginMark(A), BeginMark(B), EndMark(A), EndMark(B).");
			}
			c.a[num].c = (float)f.Elapsed.TotalMilliseconds;
		}
	}

	public float GetAverageTime(int barIndex, string markerName)
	{
		if (barIndex < 0 || barIndex >= 8)
		{
			throw new ArgumentOutOfRangeException("barIndex");
		}
		float result = 0f;
		if (h.TryGetValue(markerName, out var value))
		{
			result = g[value].b[barIndex].f;
		}
		return result;
	}

	[Conditional("TRACE")]
	public void ResetLog()
	{
		lock (this)
		{
			foreach (d item in g)
			{
				for (int i = 0; i < item.b.Length; i++)
				{
					item.b[i].i = false;
					item.b[i].a = 0f;
					item.b[i].b = 0f;
					item.b[i].c = 0f;
					item.b[i].d = 0f;
					item.b[i].e = 0f;
					item.b[i].f = 0f;
					item.b[i].g = 0;
				}
			}
		}
	}

	public override void Draw(GameTime gameTime)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		Draw(m, Width);
		((DrawableGameComponent)this).Draw(gameTime);
	}

	[Conditional("TRACE")]
	public void Draw(Vector2 position, int width)
	{
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0417: Unknown result type (might be due to invalid IL or missing references)
		//IL_041c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0444: Unknown result type (might be due to invalid IL or missing references)
		//IL_044e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0470: Unknown result type (might be due to invalid IL or missing references)
		//IL_0475: Unknown result type (might be due to invalid IL or missing references)
		//IL_0508: Unknown result type (might be due to invalid IL or missing references)
		//IL_050a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0516: Unknown result type (might be due to invalid IL or missing references)
		//IL_0526: Unknown result type (might be due to invalid IL or missing references)
		Interlocked.Exchange(ref this.l, 0);
		SpriteBatch spriteBatch = this.m_a.SpriteBatch;
		SpriteFont debugFont = this.m_a.DebugFont;
		Texture2D whiteTexture = this.m_a.WhiteTexture;
		int num = 0;
		float num2 = 0f;
		c[] array = this.m_c.a;
		foreach (c c in array)
		{
			if (c.b > 0)
			{
				num += 12;
				num2 = Math.Max(num2, c.a[c.b - 1].c);
			}
		}
		float num3 = (float)this.j * 16.666666f;
		if (num2 > num3)
		{
			this.i = Math.Max(0, this.i) + 1;
		}
		else
		{
			this.i = Math.Min(0, this.i) - 1;
		}
		if (Math.Abs(this.i) > 30)
		{
			this.j = Math.Min(4, this.j);
			this.j = Math.Max(TargetSampleFrames, (int)(num2 / 16.666666f) + 1);
			this.i = 0;
		}
		float num4 = (float)width / num3;
		int num5 = (int)position.Y - (num - 8);
		int num6 = num5;
		spriteBatch.Begin();
		Rectangle val = default(Rectangle);
		val = new Rectangle((int)position.X, num6, width, num);
		spriteBatch.Draw(whiteTexture, val, new Color(0, 0, 0, 128));
		val.Height = 8;
		c[] array2 = this.m_c.a;
		foreach (c c2 in array2)
		{
			val.Y = num6 + 2;
			if (c2.b > 0)
			{
				for (int k = 0; k < c2.b; k++)
				{
					float num7 = c2.a[k].b;
					float num8 = c2.a[k].c;
					int num9 = (int)(position.X + num7 * num4);
					int num10 = (int)(position.X + num8 * num4);
					val.X = num9;
					val.Width = Math.Max(num10 - num9, 1);
					spriteBatch.Draw(whiteTexture, val, c2.a[k].d);
				}
			}
			num6 += 10;
		}
		val = new Rectangle((int)position.X, num5, 1, num);
		for (float num11 = 1f; num11 < num3; num11 += 1f)
		{
			val.X = (int)(position.X + num11 * num4);
			spriteBatch.Draw(whiteTexture, val, Color.Gray);
		}
		for (int l = 0; l <= this.j; l++)
		{
			val.X = (int)(position.X + 16.666666f * (float)l * num4);
			spriteBatch.Draw(whiteTexture, val, Color.White);
		}
		if (ShowLog)
		{
			num6 = num5 - debugFont.LineSpacing;
			this.k.Length = 0;
			foreach (d item in g)
			{
				for (int m = 0; m < 8; m++)
				{
					if (item.b[m].i)
					{
						if (this.k.Length > 0)
						{
							this.k.Append("\n");
						}
						this.k.Append(" Bar ");
						this.k.AppendNumber(m);
						this.k.Append(" ");
						this.k.Append(item.a);
						this.k.Append(" Avg.:");
						this.k.AppendNumber(item.b[m].c);
						this.k.Append("ms ");
						num6 -= debugFont.LineSpacing;
					}
				}
			}
			Vector2 val2 = debugFont.MeasureString(this.k);
			val = new Rectangle((int)position.X, num6, (int)val2.X + 12, (int)val2.Y);
			spriteBatch.Draw(whiteTexture, val, new Color(0, 0, 0, 128));
			spriteBatch.DrawString(debugFont, this.k, new Vector2(position.X + 12f, (float)num6), Color.White);
			num6 += (int)((float)debugFont.LineSpacing * 0.3f);
			val = new Rectangle((int)position.X + 4, num6, 10, 10);
			Rectangle val3 = default(Rectangle);
			val3 = new Rectangle((int)position.X + 5, num6 + 1, 8, 8);
			foreach (d item2 in g)
			{
				for (int n = 0; n < 8; n++)
				{
					if (item2.b[n].i)
					{
						val.Y = num6;
						val3.Y = num6 + 1;
						spriteBatch.Draw(whiteTexture, val, Color.White);
						spriteBatch.Draw(whiteTexture, val3, item2.b[n].h);
						num6 += debugFont.LineSpacing;
					}
				}
			}
		}
		spriteBatch.End();
	}
}
