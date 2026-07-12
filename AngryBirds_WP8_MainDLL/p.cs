using System.Collections.Generic;
using Innogiant;
using Microsoft.Xna.Framework;

internal class p
{
	private static p m_a;

	private bool m_b;

	private int c;

	private Dictionary<string, List<Vector2>> d;

	public static p a()
	{
		if (p.m_a == null)
		{
			p.m_a = new p();
		}
		return p.m_a;
	}

	private p()
	{
		this.m_b = false;
		c = 3;
		d = new Dictionary<string, List<Vector2>>();
	}

	public void b(string A_0)
	{
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		d = new Dictionary<string, List<Vector2>>();
		switch (A_0)
		{
		case "RESO_480":
			c = 1;
			break;
		case "RESO_640":
			c = 2;
			break;
		case "RESO_800":
			c = 3;
			break;
		case "RESO_1024":
			c = 4;
			break;
		default:
			c = 3;
			break;
		}
		string text = "";
		string text2 = "";
		LuaParser luaParser = new LuaParser();
		text = u.a("positions.lua", h.g);
		text2 = al.a(text, "?:a/+6'N", ":4>)9a/{");
		luaParser.Parse(text2);
		Vector2 item = default(Vector2);
		foreach (KeyValuePair<string, LuaVariable> item2 in luaParser.Value.GetArray())
		{
			List<Vector2> list = new List<Vector2>();
			foreach (KeyValuePair<string, LuaVariable> item3 in item2.Value[A_0].GetArray())
			{
				item = new Vector2((float)item3.Value["x"], (float)item3.Value["y"]);
				list.Add(item);
			}
			d.Add(item2.Key, list);
		}
	}

	public List<Vector2> a(string A_0)
	{
		if (!d.ContainsKey(A_0))
		{
			return null;
		}
		return d[A_0];
	}
}
