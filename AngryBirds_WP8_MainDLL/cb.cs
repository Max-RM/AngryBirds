using AngryBirds;
using Microsoft.Xna.Framework;

internal class cb
{
	public BlockBasicType b;

	public Vector2[] c;

	public string d;

	public string e;

	public bl[] f;

	public cv g;

	public BlockGroup h;

	public float i;

	public int j;

	public bool k;

	public int l;

	public float m;

	public float n;

	public float o;

	public float p;

	public bool q;

	public int r;

	public cw s;

	public float t;

	public float u;

	public float v;

	public float w;

	public float x;

	public bool y;

	public cb()
	{
	}

	public cb(BlockBasicType A_0, Vector2[] A_1, string A_2, string A_3, string A_4, BlockGroup A_5, float A_6, int A_7, bool A_8, int A_9, bl[] A_10, float A_11, float A_12, float A_13, float A_14, bool A_15, int A_16, string A_17, float A_18, float A_19, float A_20, float A_21, float A_22, bool A_23)
	{
		b = A_0;
		c = A_1;
		d = A_2;
		e = A_3;
		g = di.d().p(A_4);
		h = A_5;
		i = A_6;
		j = A_7;
		k = A_8;
		l = A_9;
		f = A_10;
		m = A_11;
		n = A_12;
		o = A_13;
		p = A_14;
		q = A_15;
		r = A_16;
		if (h == BlockGroup.BIRDS)
		{
			q = false;
		}
		if (g == null)
		{
			g = new cv();
		}
		s = global::u.a().f(A_17);
		if (s == null)
		{
			s = ((g != null) ? g.i : null);
		}
		t = A_18;
		u = A_19;
		v = A_20;
		w = A_21;
		x = A_22;
		y = A_23;
	}
}
