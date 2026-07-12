using Innogiant;

internal class a6
{
	public string a;

	public int b;

	public int c;

	public string d;

	public string e;

	public float f;

	public float g;

	public float h;

	public float i;

	public a6(LuaVariable A_0)
	{
		a = A_0["name"];
		b = A_0["type"];
		c = A_0["coordType"];
		d = A_0["end1"];
		e = A_0["end2"];
		f = A_0["x1"];
		g = A_0["x2"];
		h = A_0["y1"];
		i = A_0["y2"];
	}
}
