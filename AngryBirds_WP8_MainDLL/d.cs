using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using AngryBirds.Menus;
using Innogiant;

internal class d
{
	public int a;

	public int b;

	public int c;

	public int d_value;

	public int e;

	private Dictionary<string, Dictionary<string, string>> f;

	private static d g;

	private bool h;

	private string i;

	[CompilerGenerated]
	private bool j;

	[CompilerGenerated]
	private string k;

	[CompilerGenerated]
	private int l;

	[CompilerGenerated]
	private string m;

	[CompilerGenerated]
	private bool n;

	[CompilerGenerated]
	private bool o;

	[CompilerGenerated]
	private Dictionary<string, int> m_p;

	[CompilerGenerated]
	private Dictionary<string, int> m_q;

	[CompilerGenerated]
	private Dictionary<string, bool> m_r;

	[CompilerGenerated]
	private Dictionary<string, bool> m_s;

	[SpecialName]
	[CompilerGenerated]
	public bool ab()
	{
		return j;
	}

	[SpecialName]
	[CompilerGenerated]
	public void s(bool A_0)
	{
		j = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public string u()
	{
		return k;
	}

	[SpecialName]
	[CompilerGenerated]
	public void r(string A_0)
	{
		k = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public int t()
	{
		return l;
	}

	[SpecialName]
	[CompilerGenerated]
	public void p(int A_0)
	{
		l = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public string ac()
	{
		return m;
	}

	[SpecialName]
	[CompilerGenerated]
	public void v(string A_0)
	{
		m = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public bool z()
	{
		return n;
	}

	[SpecialName]
	[CompilerGenerated]
	public void r(bool A_0)
	{
		n = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public bool s()
	{
		return o;
	}

	[SpecialName]
	[CompilerGenerated]
	public void q(bool A_0)
	{
		o = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public Dictionary<string, int> w()
	{
		return this.m_p;
	}

	[SpecialName]
	[CompilerGenerated]
	private void q(Dictionary<string, int> A_0)
	{
		this.m_p = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public Dictionary<string, int> y()
	{
		return this.m_q;
	}

	[SpecialName]
	[CompilerGenerated]
	private void p(Dictionary<string, int> A_0)
	{
		this.m_q = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public Dictionary<string, bool> aa()
	{
		return this.m_r;
	}

	[SpecialName]
	[CompilerGenerated]
	private void q(Dictionary<string, bool> A_0)
	{
		this.m_r = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public Dictionary<string, bool> q()
	{
		return this.m_s;
	}

	[SpecialName]
	[CompilerGenerated]
	private void p(Dictionary<string, bool> A_0)
	{
		this.m_s = A_0;
	}

	public static d p()
	{
		if (g == null)
		{
			g = new d();
		}
		return g;
	}

	private d()
	{
		i = "settings.lua";
		s(A_0: true);
		r(dc.b);
		p(1);
		v("theme1");
		r(A_0: false);
		q(A_0: false);
		a = 0;
		b = 0;
		c = 0;
		d_value = 0;
		e = 0;
		f = new Dictionary<string, Dictionary<string, string>>();
		q(new Dictionary<string, int>());
		p(new Dictionary<string, int>());
		q(new Dictionary<string, bool>());
		p(new Dictionary<string, bool>());
		y().Add("episode1", 1);
		y().Add("episode2", 1);
		y().Add("episode3", 1);
		y().Add("episode4", 1);
		y().Add("episode5", 1);
		y().Add("goldenEggs", 1);
		aa().Add("episode1", value: false);
		aa().Add("episode2", value: false);
		aa().Add("episode3", value: false);
		aa().Add("episode4", value: false);
		aa().Add("episode5", value: false);
		q().Add("Split it", value: false);
		q().Add("Speed is the Essence", value: false);
		q().Add("Woodpecker", value: false);
		q().Add("Stonecutter", value: false);
		q().Add("Icepicker", value: false);
		q().Add("Pig Popper", value: false);
		q().Add("Block Smasher", value: false);
		q().Add("Smash Maniac", value: false);
		q().Add("Just Getting Started", value: false);
		v();
	}

	public bool v()
	{
		h = true;
		byte[] array = null;
		string text = null;
		LuaParser luaParser = null;
		array = al.b(i);
		if (array != null)
		{
			text = Encoding.UTF8.GetString(array, 0, array.Length);
			string aString = bs.a(text, "!i6G:-#g", ".4>)9n=T");
			luaParser = new LuaParser();
			luaParser.Parse(aString);
			if (luaParser.Value == null)
			{
				return false;
			}
			p(luaParser.Value);
		}
		if (!ab())
		{
			b0.d().e();
		}
		return true;
	}

	public bool r()
	{
		return p(A_0: false);
	}

	public bool p(bool A_0)
	{
		if (h || A_0)
		{
			string a_ = x();
			string text = bs.b(a_, "!i6G:-#g", ".4>)9n=T");
			try
			{
				al.a(i, Encoding.UTF8.GetBytes(text.ToCharArray()));
			}
			catch
			{
				return false;
			}
			h = false;
		}
		return true;
	}

	public void p(LuaVariable A_0, string A_1, string A_2, string A_3, object A_4)
	{
		h = true;
		if (A_0[A_1] == null)
		{
			Dictionary<string, LuaVariable> dictionary = new Dictionary<string, LuaVariable>();
			((Dictionary<string, LuaVariable>)A_0.Content).Add(A_1, dictionary);
		}
		if (A_0[A_1][A_2] == null)
		{
			Dictionary<string, LuaVariable> dictionary2 = new Dictionary<string, LuaVariable>();
			((Dictionary<string, LuaVariable>)A_0[A_1].Content).Add(A_2, dictionary2);
		}
		if (A_0[A_1][A_2][A_3] == null)
		{
			((Dictionary<string, LuaVariable>)A_0[A_1][A_2].Content).Add(A_3, new LuaVariable(A_4));
		}
		else
		{
			A_0[A_1][A_2][A_3] = new LuaVariable(A_4);
		}
	}

	public void p(LuaVariable A_0, string A_1, string A_2, object A_3)
	{
		h = true;
		if (A_0[A_1] == null)
		{
			Dictionary<string, LuaVariable> dictionary = new Dictionary<string, LuaVariable>();
			((Dictionary<string, LuaVariable>)A_0.Content).Add(A_1, dictionary);
		}
		if (A_0[A_1][A_2] == null)
		{
			((Dictionary<string, LuaVariable>)A_0[A_1].Content).Add(A_2, new LuaVariable(A_3));
		}
		else
		{
			A_0[A_1][A_2] = new LuaVariable(A_3);
		}
	}

	public bool p(LuaVariable A_0)
	{
		h = true;
		if (A_0["userSettings"] != null)
		{
			if (A_0["userSettings"]["audioEnabled"] != null)
			{
				s(A_0["userSettings"]["audioEnabled"].GetBool());
			}
			if (A_0["userSettings"]["selectedEpisode"] != null)
			{
				p(A_0["userSettings"]["selectedEpisode"].GetInteger());
			}
			if (A_0["userSettings"]["selectedTheme"] != null)
			{
				v(A_0["userSettings"]["selectedTheme"].GetString());
			}
			if (A_0["userSettings"]["currentLanguage"] != null)
			{
				r(A_0["userSettings"]["currentLanguage"].GetString());
			}
			if (A_0["userSettings"]["gameStarted"] != null)
			{
				r(A_0["userSettings"]["gameStarted"].GetBool());
			}
			if (A_0["userSettings"]["facebookLiked"] != null)
			{
				q(A_0["userSettings"]["facebookLiked"].GetBool());
			}
		}
		if (A_0["statistics"] != null)
		{
			if (A_0["statistics"]["woodBlocksDestroyed"] != null)
			{
				b = A_0["statistics"]["woodBlocksDestroyed"].GetInteger();
			}
			if (A_0["statistics"]["rockBlocksDestroyed"] != null)
			{
				d_value = A_0["statistics"]["rockBlocksDestroyed"].GetInteger();
			}
			if (A_0["statistics"]["iceBlocksDestroyed"] != null)
			{
				c = A_0["statistics"]["iceBlocksDestroyed"].GetInteger();
			}
			if (A_0["statistics"]["pigsDestroyed"] != null)
			{
				e = A_0["statistics"]["pigsDestroyed"].GetInteger();
			}
		}
		if (A_0["tutorials"] != null)
		{
			for (int num = 0; num < dc.e.Length; num++)
			{
				string text = dc.e[num];
				Dictionary<string, string> dictionary = new Dictionary<string, string>();
				if (A_0["tutorials"].ContainsKey(text))
				{
					dictionary.Add("sprite", A_0["tutorials"][text]["sprite"].GetString());
				}
				if (dictionary.Count > 0)
				{
					if (f.ContainsKey(text))
					{
						f[text] = dictionary;
					}
					else
					{
						f.Add(text, dictionary);
					}
				}
			}
		}
		if (A_0["openGoldenEggLevels"] != null)
		{
			LuaVariable luaVariable = A_0["openGoldenEggLevels"];
			foreach (KeyValuePair<string, LuaVariable> item in luaVariable)
			{
				if (w().ContainsKey(item.Key))
				{
					w()[item.Key] = item.Value.GetInteger();
				}
				else
				{
					w().Add(item.Key, item.Value.GetInteger());
				}
			}
		}
		if (A_0["currentLevelSelectionPages"] != null)
		{
			LuaVariable luaVariable2 = A_0["currentLevelSelectionPages"];
			foreach (KeyValuePair<string, LuaVariable> item2 in luaVariable2)
			{
				if (y().ContainsKey(item2.Key))
				{
					y()[item2.Key] = item2.Value.GetInteger();
				}
				else
				{
					y().Add(item2.Key, item2.Value.GetInteger());
				}
			}
		}
		if (A_0["LPStarted"] != null)
		{
			LuaVariable luaVariable3 = A_0["LPStarted"];
			foreach (KeyValuePair<string, LuaVariable> item3 in luaVariable3)
			{
				if (aa().ContainsKey(item3.Key))
				{
					aa()[item3.Key] = item3.Value.GetBool();
				}
				else
				{
					aa().Add(item3.Key, item3.Value.GetBool());
				}
			}
		}
		if (A_0["trialModeAchievements"] != null)
		{
			LuaVariable luaVariable4 = A_0["trialModeAchievements"];
			foreach (KeyValuePair<string, LuaVariable> item4 in luaVariable4)
			{
				if (q().ContainsKey(item4.Key))
				{
					q()[item4.Key] = item4.Value.GetBool();
				}
				else
				{
					q().Add(item4.Key, item4.Value.GetBool());
				}
			}
		}
		return true;
	}

	public string x()
	{
		h = true;
		LuaVariable luaVariable = new LuaVariable(new Dictionary<string, LuaVariable>());
		s(!b0.d().p());
		p(luaVariable, "userSettings", "audioEnabled", ab());
		p(luaVariable, "userSettings", "selectedEpisode", t());
		p(luaVariable, "userSettings", "selectedTheme", ac());
		p(luaVariable, "userSettings", "currentLanguage", u());
		p(luaVariable, "userSettings", "gameStarted", z());
		p(luaVariable, "userSettings", "facebookLiked", s());
		p(luaVariable, "statistics", "backwardsBirdCount", a);
		p(luaVariable, "statistics", "woodBlocksDestroyed", b);
		p(luaVariable, "statistics", "pigsDestroyed", e);
		p(luaVariable, "statistics", "rockBlocksDestroyed", d_value);
		p(luaVariable, "statistics", "iceBlocksDestroyed", c);
		foreach (KeyValuePair<string, Dictionary<string, string>> item in f)
		{
			p(luaVariable, "tutorials", item.Key, "sprite", item.Value["sprite"]);
		}
		foreach (KeyValuePair<string, int> item2 in w())
		{
			p(luaVariable, "openGoldenEggLevels", item2.Key, item2.Value);
		}
		foreach (KeyValuePair<string, int> item3 in y())
		{
			p(luaVariable, "currentLevelSelectionPages", item3.Key, item3.Value);
		}
		foreach (KeyValuePair<string, bool> item4 in aa())
		{
			p(luaVariable, "LPStarted", item4.Key, item4.Value);
		}
		foreach (KeyValuePair<string, bool> item5 in q())
		{
			p(luaVariable, "trialModeAchievements", item5.Key, item5.Value);
		}
		return LuaParser.ReturnString(luaVariable, "");
	}

	public GoldenEggType s(string A_0)
	{
		if (w().ContainsKey(A_0))
		{
			return (GoldenEggType)w()[A_0];
		}
		return GoldenEggType.Locked;
	}

	public int ae()
	{
		int num = 0;
		foreach (KeyValuePair<string, int> item in w())
		{
			if (item.Value != -1)
			{
				num++;
			}
		}
		return num;
	}

	public int ad()
	{
		int num = 0;
		foreach (KeyValuePair<string, int> item in w())
		{
			if (item.Value == 2)
			{
				num++;
			}
		}
		return num;
	}

	public void p(string A_0, GoldenEggType A_1)
	{
		h = true;
		if (w().ContainsKey(A_0))
		{
			w()[A_0] = (int)A_1;
		}
		else
		{
			w().Add(A_0, (int)A_1);
		}
		bw.d().f(p);
	}

	public bool t(string A_0)
	{
		if (q().ContainsKey(A_0))
		{
			foreach (KeyValuePair<string, bool> item in q())
			{
				if (item.Key == A_0)
				{
					return item.Value;
				}
			}
		}
		return false;
	}

	public void q(string A_0)
	{
		if (q().ContainsKey(A_0))
		{
			q()[A_0] = true;
		}
		else
		{
			q().Add(A_0, value: true);
		}
	}

	public bool p(string A_0)
	{
		return f.ContainsKey(A_0);
	}

	public void u(string A_0)
	{
		h = true;
		if (f.ContainsKey(A_0))
		{
			return;
		}
		for (int num = 0; num < dc.e.Length; num++)
		{
			if (dc.e[num] == A_0)
			{
				Dictionary<string, string> dictionary = new Dictionary<string, string>();
				dictionary.Add("sprite", "TUTORIAL_" + num);
				f.Add(A_0, dictionary);
				break;
			}
		}
	}

	private void p(object A_0)
	{
	}
}
