using System;
using System.Collections.Generic;
using AngryBirds;
using Innogiant;
using Microsoft.Xna.Framework;

internal class bc
{
	public List<ct> a;

	public List<a6> b;

	public float c;

	public bool d;

	public string e;

	private string[] m_f = new string[11]
	{
		"ambient_theme1", "ambient_theme2", "ambient_theme3", "ambient_theme1", "ambient_theme3", "ambient_theme3", "ambient_theme7", "ambient_theme2", "construction_theme1", "construction_theme1",
		"construction_theme1"
	};

	public c0 g;

	public c0 h;

	private LuaVariable m_i;

	public float j;

	public float k;

	public float l = 100000f;

	public float m = -100000f;

	private cf m_n;

	public bc(cf A_0)
	{
		this.m_n = A_0;
	}

	public string n()
	{
		if (di.d().f().b != null)
		{
			return di.d().f().b;
		}
		return this.m_f[di.d().f().a - 1];
	}

	public string f(a2 A_0)
	{
		if (A_0.b != null)
		{
			return A_0.b;
		}
		return this.m_f[A_0.a - 1];
	}

	public bool f(string A_0, string A_1)
	{
		string a_ = u.a(A_0 + "/" + A_1 + ".lua", global::h.e);
		string aString = al.a(a_, "?:a/+6'N", ":4>)9a/{");
		LuaParser luaParser = new LuaParser();
		luaParser.Parse(aString);
		this.m_i = luaParser.Value;
		if (this.m_i == null)
		{
			return false;
		}
		return true;
	}

	public a2 f()
	{
		return di.d().i(this.m_i["theme"]);
	}

	public void i()
	{
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		a = new List<ct>();
		b = new List<a6>();
		c = this.m_i["physicsToWorld"];
		e = this.m_i["theme"];
		d = this.m_i["doNotWaitForMovingObjects"];
		g = new c0(this.m_i["birdCameraData"], "iphone");
		h = new c0(this.m_i["castleCameraData"], "iphone");
		j = g.b;
		k = h.c;
		g.m = j;
		g.n = k;
		h.m = j;
		h.n = k;
		Vector2 val = di.e(j, k, c);
		float val2 = val.X;
		float val3 = val.Y;
		l = Math.Min(l, val2);
		m = Math.Max(m, val3);
		float num = 1f / c;
		l -= 600f * num;
		m += 600f * num;
		float num2 = k - j;
		g.l = 800f / num2;
		h.l = 800f / num2;
		ct item = null;
		foreach (KeyValuePair<string, LuaVariable> item2 in this.m_i["world"].GetArray())
		{
			cb cb2 = di.d().q(item2.Value["definition"]);
			switch (cb2.h)
			{
			case BlockGroup.BIRDS:
				switch ((string)item2.Value["definition"])
				{
				case "SmallBlueBird":
					item = new ah(item2.Value, this.m_n, null);
					break;
				case "RedBird":
					item = new x(item2.Value, this.m_n);
					break;
				case "YellowBird":
					item = new b1(item2.Value, this.m_n);
					break;
				case "BlackBird":
					item = new dn(item2.Value, this.m_n);
					break;
				case "BasicBird2":
					item = new bt(item2.Value, this.m_n);
					break;
				case "RedBigBird":
					item = new ar(item2.Value, this.m_n);
					break;
				case "BoomerangBird":
					item = new bh(item2.Value, this.m_n);
					break;
				case "MightyEagleBird":
					item = new cg(item2.Value, this.m_n);
					break;
				case "BaitMouse":
					item = new b8(item2.Value, this.m_n);
					break;
				}
				break;
			case BlockGroup.PIGLETTES:
				item = new t(item2.Value, this.m_n);
				break;
			default:
				item = new ct(item2.Value);
				break;
			}
			a.Add(item);
		}
		a6 a10 = null;
		foreach (KeyValuePair<string, LuaVariable> item3 in this.m_i["joints"].GetArray())
		{
			a10 = new a6(item3.Value);
			a10.a = item3.Key;
			b.Add(a10);
		}
	}
}
