using System;
using System.Collections.Generic;
using System.Text;
using Innogiant;

internal class bo
{
	private static bo m_a;

	private bool m_b;

	private LuaVariable m_c;

	private LuaVariable m_d;

	public static bo a()
	{
		if (bo.m_a == null)
		{
			bo.m_a = new bo();
		}
		return bo.m_a;
	}

	private bo()
	{
		this.m_c = new LuaVariable(new Dictionary<string, LuaVariable>());
		this.m_d = new LuaVariable(new Dictionary<string, LuaVariable>());
		d();
		c();
	}

	public bool d()
	{
		this.m_b = true;
		string text = null;
		LuaParser luaParser = new LuaParser();
		text = al.a(u.a("starLimits.lua", global::h.g));
		if (text != null)
		{
			luaParser = new LuaParser();
			string aString = bs.a(text, "?:a/+6'N", ":4>)9a/{");
			luaParser.Parse(aString);
			this.m_d = luaParser.Value;
			if (this.m_d == null)
			{
				return false;
			}
		}
		return true;
	}

	public bool c()
	{
		this.m_b = true;
		byte[] array = null;
		string text = null;
		LuaParser luaParser = null;
		array = al.b("highscores.lua");
		if (array != null)
		{
			text = Encoding.UTF8.GetString(array, 0, array.Length);
			string aString = bs.a(text, "%pT-5#;g", ",e'=5{Sm");
			luaParser = new LuaParser();
			luaParser.Parse(aString);
			this.m_c = luaParser.Value;
			if (this.m_c == null)
			{
				return false;
			}
		}
		return true;
	}

	public bool b()
	{
		return a(A_0: false);
	}

	public bool a(bool A_0)
	{
		if (this.m_b || A_0)
		{
			string a_ = LuaParser.ReturnString(this.m_c, "");
			string text = bs.b(a_, "%pT-5#;g", ",e'=5{Sm");
			try
			{
				al.a("highscores.lua", Encoding.UTF8.GetBytes(text.ToCharArray()));
			}
			catch
			{
				return false;
			}
			this.m_b = false;
		}
		return true;
	}

	public void a(string A_0, int A_1, int A_2)
	{
		this.m_b = true;
		Dictionary<string, LuaVariable> dictionary = new Dictionary<string, LuaVariable>();
		dictionary.Add("completed", A_1 > 0);
		dictionary.Add("birds", A_2);
		dictionary.Add("score", A_1);
		dictionary.Add("lowScore", A_1);
		if (this.m_c[A_0] == null)
		{
			((Dictionary<string, LuaVariable>)this.m_c.Content).Add(A_0, dictionary);
			if (!dc.IsTrial())
			{
				bw.d().d(0, (long)e(), (c2.LiveCallback)null);
			}
			return;
		}
		Dictionary<string, LuaVariable> array = this.m_c[A_0].GetArray();
		dictionary["lowScore"] = Math.Min(dictionary["lowScore"], array["lowScore"]);
		if ((int)array["score"] > A_1)
		{
			dictionary["score"] = array["score"];
			dictionary["birds"] = array["birds"];
			this.m_c[A_0] = dictionary;
			return;
		}
		this.m_c[A_0] = dictionary;
		if (!dc.IsTrial())
		{
			bw.d().d(0, (long)e(), (c2.LiveCallback)null);
		}
	}

	public bool d(string A_0)
	{
		if (dc.IsTrial() && !di.d().j(A_0))
		{
			return false;
		}
		LuaVariable luaVariable = this.m_c[A_0];
		if (luaVariable != null)
		{
			return luaVariable["completed"];
		}
		return false;
	}

	public bool a(string A_0)
	{
		a8 a10 = di.d().f(A_0);
		if (a10 == null)
		{
			return false;
		}
		bool result = true;
		for (int num = 0; num < a10.b.Count; num++)
		{
			if (!d(a10.b[num]))
			{
				result = false;
				break;
			}
		}
		return result;
	}

	public bool g(string A_0)
	{
		a8 a10 = di.d().f(A_0);
		if (a10 == null)
		{
			return false;
		}
		bool result = true;
		for (int num = 0; num < a10.b.Count; num++)
		{
			l l2 = e(a10.b[num]);
			if (l2.b == 0 || l2.b < l2.c)
			{
				result = false;
				break;
			}
		}
		return result;
	}

	public bool f(string A_0)
	{
		av av2 = di.d().d(A_0);
		if (av2 == null)
		{
			return false;
		}
		bool result = true;
		for (int num = 0; num < av2.b.Count; num++)
		{
			if (!(av2.b[num] == "packFacebook1") && !a(av2.b[num]))
			{
				result = false;
				break;
			}
		}
		return result;
	}

	public bool c(string A_0)
	{
		l l2 = h(A_0);
		return l2.b == l2.c;
	}

	public bool f()
	{
		return a("pack3");
	}

	public int a(string A_0, int A_1)
	{
		if (dc.IsTrial() && !di.d().j(A_0))
		{
			return 0;
		}
		int num = 0;
		LuaVariable luaVariable = this.m_d[A_0];
		LuaVariable luaVariable2 = this.m_c[A_0];
		if (luaVariable != null && luaVariable2 != null)
		{
			if (A_1 >= (int)luaVariable["goldScore"])
			{
				num += 3;
			}
			else if (A_1 >= (int)luaVariable["silverScore"])
			{
				num += 2;
			}
			else if ((bool)luaVariable2["completed"] && A_1 > 0)
			{
				num++;
			}
		}
		return num;
	}

	public l e(string A_0)
	{
		int num = 0;
		int num2 = 0;
		LuaVariable luaVariable = this.m_c[A_0];
		if (luaVariable != null)
		{
			num = luaVariable["score"];
		}
		num2 = a(A_0, num);
		return new l(num, num2, 3);
	}

	public l b(string A_0)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		a8 a10 = di.d().f(A_0);
		for (int num4 = 0; num4 < a10.b.Count; num4++)
		{
			l l2 = e(a10.b[num4]);
			num += l2.a;
			num2 += l2.b;
			num3 += 3;
		}
		return new l(num, num2, num3);
	}

	public l h(string A_0)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 1000;
		av av2 = di.d().d(A_0);
		if (av2 != null)
		{
			num = 0;
			num2 = 0;
			num3 = 0;
			for (int num4 = 0; num4 < av2.b.Count; num4++)
			{
				l l2 = b(av2.b[num4]);
				num += l2.a;
				num2 += l2.b;
				num3 += l2.c;
			}
		}
		return new l(num, num2, num3);
	}

	public int e()
	{
		int num = 0;
		List<string> list = di.d().i();
		foreach (string item in list)
		{
			l l2 = h(item);
			num += l2.a;
		}
		return num;
	}
}
