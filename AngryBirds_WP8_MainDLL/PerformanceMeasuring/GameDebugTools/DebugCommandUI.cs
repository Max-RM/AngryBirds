using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace PerformanceMeasuring.GameDebugTools;

public class DebugCommandUI : DrawableGameComponent, IDebugCommandHost
{
	private enum b
	{
		a,
		b,
		c,
		d
	}

	private class NestedClassA
	{
		public string a;

		public string b;

		public DebugCommandExecute c;

		public NestedClassA(string A_0, string A_1, DebugCommandExecute A_2)
		{
			a = A_0;
			b = A_1;
			c = A_2;
		}
	}

	public const string DefaultPrompt = "CMD>";

	private DebugManager m_a;

	private b m_b;

	private float m_c;

	private List<IDebugEchoListner> d = new List<IDebugEchoListner>();

	private Stack<IDebugCommandExecutioner> e = new Stack<IDebugCommandExecutioner>();

	private Dictionary<string, NestedClassA> f = new Dictionary<string, NestedClassA>();

	private string g = string.Empty;

	private int h;

	private Queue<string> i = new Queue<string>();

	private List<string> j = new List<string>();

	private int k;

	private KeyboardState l;

	private Keys m;

	private float n;

	private float o = 0.3f;

	private float p = 0.03f;

	[CompilerGenerated]
	private string q;

	public string Prompt
	{
		[CompilerGenerated]
		get
		{
			return q;
		}
		[CompilerGenerated]
		set
		{
			q = value;
		}
	}

	public bool Focused => this.m_b != DebugCommandUI.b.a;

	public DebugCommandUI(Game game)
		: base(game)
	{
		Prompt = "CMD>";
		((GameComponent)this).Game.Services.AddService(typeof(IDebugCommandHost), (object)this);
		((DrawableGameComponent)this).DrawOrder = int.MaxValue;
		DebugCommandExecute callback = delegate
		{
			int num = 0;
			foreach (a value in f.Values)
			{
				num = Math.Max(num, value.a.Length);
			}
			string format = $"{{0,-{num}}}    {{1}}";
			foreach (a value2 in f.Values)
			{
				Echo(string.Format(format, value2.a, value2.b));
			}
		};
		RegisterCommand("help", "Show Command helps", callback);
		RegisterCommand("cls", "Clear Screen", delegate
		{
			i.Clear();
		});
		RegisterCommand("echo", "Display Messages", delegate(IDebugCommandHost A_0, string A_1, IList<string> A_2)
		{
			Echo(A_1.Substring(5));
		});
	}

	public override void Initialize()
	{
		this.m_a = ((GameComponent)this).Game.Services.GetService(typeof(DebugManager)) as DebugManager;
		if (this.m_a == null)
		{
			throw new InvalidOperationException("Coudn't find DebugManager.");
		}
		((DrawableGameComponent)this).Initialize();
	}

	public void RegisterCommand(string command, string description, DebugCommandExecute callback)
	{
		string key = command.ToLower();
		if (f.ContainsKey(key))
		{
			throw new InvalidOperationException($"Command \"{command}\" is already registered.");
		}
		f.Add(key, new NestedClassA(command, description, callback));
	}

	public void UnregisterCommand(string command)
	{
		string key = command.ToLower();
		if (!f.ContainsKey(key))
		{
			throw new InvalidOperationException($"Command \"{command}\" is not registered.");
		}
		f.Remove(command);
	}

	public void ExecuteCommand(string command)
	{
		if (e.Count != 0)
		{
			e.Peek().ExecuteCommand(command);
			return;
		}
		char[] array = new char[1] { ' ' };
		Echo(Prompt + command);
		command = command.TrimStart(array);
		List<string> list = new List<string>(command.Split(array));
		string text = list[0];
		list.RemoveAt(0);
		if (f.TryGetValue(text.ToLower(), out var value))
		{
			try
			{
				value.c(this, command, list);
			}
			catch (Exception ex)
			{
				EchoError("Unhandled Exception occurred");
				string[] array2 = ex.Message.Split('\n');
				string[] array3 = array2;
				foreach (string text2 in array3)
				{
					EchoError(text2);
				}
			}
		}
		else
		{
			Echo("Unknown Command");
		}
		j.Add(command);
		while (j.Count > 32)
		{
			j.RemoveAt(0);
		}
		k = j.Count;
	}

	public void RegisterEchoListner(IDebugEchoListner listner)
	{
		d.Add(listner);
	}

	public void UnregisterEchoListner(IDebugEchoListner listner)
	{
		d.Remove(listner);
	}

	public void Echo(DebugCommandMessage messageType, string text)
	{
		i.Enqueue(text);
		while (i.Count >= 20)
		{
			i.Dequeue();
		}
		foreach (IDebugEchoListner item in d)
		{
			item.Echo(messageType, text);
		}
	}

	public void Echo(string text)
	{
		Echo(DebugCommandMessage.Standard, text);
	}

	public void EchoWarning(string text)
	{
		Echo(DebugCommandMessage.Warning, text);
	}

	public void EchoError(string text)
	{
		Echo(DebugCommandMessage.Error, text);
	}

	public void PushExecutioner(IDebugCommandExecutioner executioner)
	{
		e.Push(executioner);
	}

	public void PopExecutioner()
	{
		e.Pop();
	}

	public void Show()
	{
		if (this.m_b == DebugCommandUI.b.a)
		{
			this.m_c = 0f;
			this.m_b = DebugCommandUI.b.b;
		}
	}

	public void Hide()
	{
		if (this.m_b == DebugCommandUI.b.c)
		{
			this.m_c = 1f;
			this.m_b = DebugCommandUI.b.d;
		}
	}

	public override void Update(GameTime gameTime)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		KeyboardState state = Keyboard.GetState();
		float num = (float)gameTime.ElapsedGameTime.TotalSeconds;
		switch (this.m_b)
		{
		case DebugCommandUI.b.a:
			if (state.IsKeyDown((Keys)9))
			{
				Show();
			}
			break;
		case DebugCommandUI.b.b:
			this.m_c += num * 8f;
			if (this.m_c > 1f)
			{
				this.m_c = 1f;
				this.m_b = DebugCommandUI.b.c;
			}
			break;
		case DebugCommandUI.b.c:
			ProcessKeyInputs(num);
			break;
		case DebugCommandUI.b.d:
			this.m_c -= num * 8f;
			if (this.m_c < 0f)
			{
				this.m_c = 0f;
				this.m_b = DebugCommandUI.b.a;
			}
			break;
		}
		l = state;
		((GameComponent)this).Update(gameTime);
	}

	public void ProcessKeyInputs(float dt)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Invalid comparison between Unknown and I4
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected I4, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected I4, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Invalid comparison between Unknown and I4
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Invalid comparison between Unknown and I4
		KeyboardState state = Keyboard.GetState();
		Keys[] pressedKeys = state.GetPressedKeys();
		bool shitKeyPressed = state.IsKeyDown((Keys)160) || state.IsKeyDown((Keys)161);
		Keys[] array = pressedKeys;
		foreach (Keys val in array)
		{
			if (!a(val, dt))
			{
				continue;
			}
			if (KeyboardUtils.KeyToString(val, shitKeyPressed, out var character))
			{
				g = g.Insert(h, new string(character, 1));
				h++;
				continue;
			}
			Keys val2 = val;
			if ((int)val2 <= 13)
			{
				switch (val2 - 8)
				{
				case 0:
					if (h > 0)
					{
						g = g.Remove(--h, 1);
					}
					continue;
				case 1:
					Hide();
					continue;
				}
				if ((int)val2 == 13)
				{
					ExecuteCommand(g);
					g = string.Empty;
					h = 0;
				}
				continue;
			}
			switch (val2 - 37)
			{
			default:
				if ((int)val2 == 46 && h < g.Length)
				{
					g = g.Remove(h, 1);
				}
				break;
			case 0:
				if (h > 0)
				{
					h--;
				}
				break;
			case 2:
				if (h < g.Length)
				{
					h++;
				}
				break;
			case 1:
				if (j.Count > 0)
				{
					k = Math.Max(0, k - 1);
					g = j[k];
					h = g.Length;
				}
				break;
			case 3:
				if (j.Count > 0)
				{
					k = Math.Min(j.Count - 1, k + 1);
					g = j[k];
					h = g.Length;
				}
				break;
			}
		}
	}

	private bool a(Keys A_0, float A_1)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		if (l.IsKeyUp(A_0))
		{
			n = o;
			m = A_0;
			return true;
		}
		if (A_0 == m)
		{
			n -= A_1;
			if (n <= 0f)
			{
				n += p;
				return true;
			}
		}
		return false;
	}

	public override void Draw(GameTime gameTime)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		if (this.m_b == DebugCommandUI.b.a)
		{
			return;
		}
		SpriteFont debugFont = this.m_a.DebugFont;
		SpriteBatch spriteBatch = this.m_a.SpriteBatch;
		Texture2D whiteTexture = this.m_a.WhiteTexture;
		Viewport viewport = ((DrawableGameComponent)this).GraphicsDevice.Viewport;
		float num = viewport.Width;
		Viewport viewport2 = ((DrawableGameComponent)this).GraphicsDevice.Viewport;
		float num2 = viewport2.Height;
		float num3 = num2 * 0.1f;
		float num4 = num * 0.1f;
		Rectangle val = default(Rectangle);
		val.X = (int)num4;
		val.Y = (int)num3;
		val.Width = (int)(num * 0.8f);
		val.Height = 20 * debugFont.LineSpacing;
		Matrix val2 = Matrix.CreateTranslation(new Vector3(0f, (float)(-val.Height) * (1f - this.m_c), 0f));
		spriteBatch.Begin((SpriteSortMode)0, (BlendState)null, (SamplerState)null, (DepthStencilState)null, (RasterizerState)null, (Effect)null, val2);
		spriteBatch.Draw(whiteTexture, val, new Color(0, 0, 0, 200));
		Vector2 val3 = default(Vector2);
		val3 = new Vector2(num4, num3);
		foreach (string item in i)
		{
			spriteBatch.DrawString(debugFont, item, val3, Color.White);
			val3.Y += (float)debugFont.LineSpacing;
		}
		string text = Prompt + g.Substring(0, h);
		Vector2 val4 = val3 + debugFont.MeasureString(text);
		val4.Y = val3.Y;
		spriteBatch.DrawString(debugFont, $"{Prompt}{g}", val3, Color.White);
		spriteBatch.DrawString(debugFont, "_", val4, Color.White);
		spriteBatch.End();
	}

	[CompilerGenerated]
	private void c(IDebugCommandHost A_0, string A_1, IList<string> A_2)
	{
		int num = 0;
		foreach (a value in f.Values)
		{
			num = Math.Max(num, value.a.Length);
		}
		string format = $"{{0,-{num}}}    {{1}}";
		foreach (a value2 in f.Values)
		{
			Echo(string.Format(format, value2.a, value2.b));
		}
	}

	[CompilerGenerated]
	private void b(IDebugCommandHost A_0, string A_1, IList<string> A_2)
	{
		i.Clear();
	}

	[CompilerGenerated]
	private void a(IDebugCommandHost A_0, string A_1, IList<string> A_2)
	{
		Echo(A_1.Substring(5));
	}
}
