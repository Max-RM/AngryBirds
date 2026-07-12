using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

internal class u
{
	private static df m_a;

	private static u m_b;

	private Dictionary<string, ca> m_c;

	private Dictionary<string, co> m_d;

	private Dictionary<string, c3> m_e;

	private string m_f;

	private static GraphicsDevice m_g;

	public static void a(df A_0, GraphicsDevice A_1)
	{
		if (A_0 == null)
		{
			throw new Exception("Error: Content manager is invalid.");
		}
		u.m_a = A_0;
		u.m_g = A_1;
	}

	public static u a()
	{
		if (u.m_b == null)
		{
			if (u.m_a == null)
			{
				throw new Exception("Error: Resource manager needs to be initialized.");
			}
			u.m_b = new u();
		}
		return u.m_b;
	}

	private u()
	{
		this.m_c = new Dictionary<string, ca>();
		this.m_d = new Dictionary<string, co>();
		this.m_e = new Dictionary<string, c3>();
		this.m_f = dc.b;
	}

	public static string a(string A_0, h A_1)
	{
		if (u.m_a == null)
		{
			throw new Exception("Error: Resource manager needs to be initialized.");
		}
		string path = "data";
		switch (A_1)
		{
		case global::h.a:
			path = Path.Combine(path, "audio");
			path = Path.Combine(path, "sfx");
			break;
		case global::h.b:
			path = Path.Combine(path, "audio");
			path = Path.Combine(path, "music");
			break;
		case global::h.c:
			path = Path.Combine(path, "fonts/800x480");
			break;
		case global::h.d:
			path = Path.Combine(path, "images/800x480");
			break;
		case global::h.e:
			path = Path.Combine(path, "levels");
			break;
		case global::h.f:
			path = Path.Combine(path, "localization");
			break;
		case global::h.g:
			path = Path.Combine(path, "scripts");
			break;
		}
		return Path.Combine(((ContentManager)u.m_a).RootDirectory, Path.Combine(path, A_0));
	}

	public ca a(string A_0, bool A_1)
	{
		if (this.m_c.ContainsKey(A_0))
		{
			return this.m_c[A_0];
		}
		ca ca2 = new ca(a(A_0, global::h.d), A_1);
		this.m_c.Add(A_0, ca2);
		return ca2;
	}

	public ca c(string A_0)
	{
		if (this.m_c.ContainsKey(A_0))
		{
			return this.m_c[A_0];
		}
		ca ca2 = new ca(a(A_0, global::h.d));
		this.m_c.Add(A_0, ca2);
		return ca2;
	}

	public co h(string A_0)
	{
		if (this.m_d.ContainsKey(A_0))
		{
			return this.m_d[A_0];
		}
		co co2 = new co(a(A_0, global::h.c));
		this.m_d.Add(A_0, co2);
		return co2;
	}

	public cw b(string A_0, string A_1)
	{
		return b0.d().e(A_0, A_1);
	}

	public cw a(string A_0, string A_1)
	{
		return b0.d().d(A_0, A_1);
	}

	public void a(cw A_0)
	{
		b0.d().d(A_0);
	}

	public c3 k(string A_0)
	{
		if (this.m_e != null && this.m_e.ContainsKey(A_0))
		{
			return this.m_e[A_0];
		}
		c3 c10 = new c3(a(A_0, global::h.f));
		c10.b();
		string text = dc.a();
		string[] array = c10.a();
		for (int num = 0; num < array.Length; num++)
		{
			if (array[num].Substring(0, 3) == text.Substring(0, 3))
			{
				this.m_f = array[num];
				break;
			}
		}
		c10.a(this.m_f);
		this.m_e.Add(A_0, c10);
		return c10;
	}

	public ae i(string A_0)
	{
		string text = A_0;
		text += this.m_f.Substring(2);
		return g(text);
	}

	public ae g(string A_0)
	{
		if (A_0 == null || A_0.Length == 0)
		{
			return null;
		}
		ae ae2 = null;
		foreach (KeyValuePair<string, ca> item in this.m_c)
		{
			ae2 = item.Value.b(A_0);
			if (ae2 != null)
			{
				return ae2;
			}
		}
		return null;
	}

	public ca l(string A_0)
	{
		if (A_0 == null)
		{
			return null;
		}
		if (!this.m_c.ContainsKey(A_0))
		{
			return null;
		}
		return this.m_c[A_0];
	}

	public co a(string A_0)
	{
		if (A_0 == null)
		{
			return null;
		}
		if (!this.m_d.ContainsKey(A_0))
		{
			return null;
		}
		return this.m_d[A_0];
	}

	public cw f(string A_0)
	{
		if (A_0 == null)
		{
			return null;
		}
		return b0.d().d(A_0);
	}

	public cw b(string A_0)
	{
		if (A_0 == null)
		{
			return null;
		}
		return b0.d().e(A_0);
	}

	public void b(string A_0, h A_1)
	{
		switch (A_1)
		{
		case global::h.d:
			l(A_0)?.b(u.m_a);
			this.m_c.Remove(A_0);
			break;
		case global::h.a:
		case global::h.b:
		case global::h.c:
		case global::h.e:
		case global::h.f:
			break;
		}
	}

	public Texture2D j(string A_0)
	{
		try
		{
			using Stream stream = TitleContainer.OpenStream(A_0 + ".png");
			Texture2D val = Texture2D.FromStream(u.m_g, stream);
			((GraphicsResource)val).Name = A_0;
			return val;
		}
		catch (Exception)
		{
			string text = A_0.Replace(((ContentManager)u.m_a).RootDirectory + "\\", "");
			Texture2D val2 = ((ContentManager)u.m_a).Load<Texture2D>(text);
			((GraphicsResource)val2).Name = A_0;
			return val2;
		}
	}

	public Texture2D b(string A_0, bool A_1)
	{
		string extension = Path.GetExtension(A_0);
		bool flag = false;
		bool flag2 = false;
		if (extension.Equals(".igi") || flag || flag2)
		{
			return null;
		}
		if (!A_1)
		{
			using (Stream stream = TitleContainer.OpenStream(A_0 + ".png"))
			{
				Texture2D val = Texture2D.FromStream(u.m_g, stream);
				((GraphicsResource)val).Name = A_0;
				stream.Close();
				return val;
			}
		}
		string text = A_0.Replace(((ContentManager)u.m_a).RootDirectory + "\\", "");
		Texture2D val2 = ((ContentManager)u.m_a).Load<Texture2D>(text);
		((GraphicsResource)val2).Name = A_0;
		return val2;
	}

	public SoundEffect d(string A_0)
	{
		string directoryName = Path.GetDirectoryName(A_0);
		string text = Path.Combine(directoryName, Path.GetFileNameWithoutExtension(A_0));
		return ((ContentManager)u.m_a).Load<SoundEffect>(text.Replace(((ContentManager)u.m_a).RootDirectory + "\\", ""));
	}

	public string e(string A_0)
	{
		c3 c10 = this.m_e["TEXTS_BASIC.dat"];
		Dictionary<string, string> dictionary = c10.b(this.m_f);
		return dictionary[A_0];
	}
}
