using Innogiant;

internal class c0
{
	public float a = float.NaN;

	public float b;

	public float c;

	public float d;

	public float e;

	public int f;

	public int g;

	public float h;

	public float i;

	public float j;

	public float k;

	public float l;

	public float m = -1000000f;

	public float n = 1000000f;

	public c0(LuaVariable A_0, string A_1)
	{
		string text = A_0["version"];
		float.TryParse(text, out a);
		LuaVariable luaVariable = A_0[A_1];
		b = luaVariable["left"];
		c = luaVariable["right"];
		d = luaVariable["top"];
		e = luaVariable["bottom"];
		f = luaVariable["screenWidth"];
		g = luaVariable["screenHeight"];
		h = luaVariable["px"];
		i = luaVariable["py"];
		j = luaVariable["sx"];
		k = luaVariable["sy"];
		j = j * 480f / (float)g;
		k = k * 480f / (float)g;
		if (float.IsNaN(a))
		{
			b = h - 400f;
			d = i - 240f;
			c = b + 800f / j;
			e = d + 480f / k;
			h = (c + b) / 2f;
			i = (e + d) / 2f;
		}
		else
		{
			float num = j;
			b = h - 400f / num;
			d = i - 240f / num;
			c = h + 400f / num;
			e = i + 240f / num;
		}
	}
}
