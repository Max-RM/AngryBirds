using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Innogiant;

internal class cs
{
	private List<ce> a;

	private Dictionary<string, ce> m_b;

	private string m_c;

	private b9 m_d;

	[CompilerGenerated]
	private n e;

	[SpecialName]
	[CompilerGenerated]
	public n c()
	{
		return e;
	}

	[SpecialName]
	[CompilerGenerated]
	public void b(n A_0)
	{
		e = A_0;
	}

	public cs(string A_0)
	{
		this.m_c = A_0;
		a = new List<ce>();
		this.m_d = new b9();
		this.m_b = new Dictionary<string, ce>();
		string text = "";
		string text2 = "";
		LuaParser luaParser = new LuaParser();
		text = this.m_c;
		text2 = al.a(text, "?:a/+6'N", ":4>)9a/{");
		luaParser.Parse(text2);
		LuaVariable luaVariable = luaParser.Value["particles"];
		if (luaVariable == null)
		{
			throw new Exception("Error: Expecting array value.");
		}
		foreach (KeyValuePair<string, LuaVariable> item in luaVariable.GetArray())
		{
			ce ce2 = new ce();
			LuaVariable luaVariable2 = item.Value["sprites"];
			string a_ = string.Concat(item.Value["sheet"], ".dat");
			ca ca2 = u.a().c(a_);
			ce2.b = new List<ae>();
			foreach (KeyValuePair<string, LuaVariable> item2 in luaVariable2.GetArray())
			{
				ce2.b.Add(ca2.b(item2.Value));
			}
			ce2.d = item.Value["minVel"];
			ce2.e = item.Value["maxVel"];
			ce2.f = item.Value["minAngleVel"];
			ce2.g = item.Value["maxAngleVel"];
			ce2.h = item.Value["minScaleBegin"];
			ce2.i = item.Value["maxScaleBegin"];
			ce2.j = item.Value["minScaleEnd"];
			ce2.k = item.Value["maxScaleEnd"];
			ce2.l.X = item.Value["gravityX"];
			ce2.l.Y = item.Value["gravityY"];
			ce2.m = item.Value["lifeTime"];
			if (item.Value.ContainsKey("animation"))
			{
				string text3 = item.Value["animation"];
				ce2.n = text3 == "lifeTime";
			}
			else
			{
				ce2.n = false;
			}
			ce2.a = null;
			this.m_b.Add(item.Key, ce2);
		}
	}

	public void b(string A_0, int A_1, float A_2, float A_3, float A_4, float A_5, float A_6)
	{
		if (A_0 == null || A_0 == "")
		{
			return;
		}
		ce ce2 = this.m_b[A_0];
		ce ce3 = new ce();
		ce3.c.X = A_2;
		ce3.c.Y = A_3;
		ce3.b = ce2.b;
		ce3.d = ce2.d;
		ce3.e = ce2.e;
		ce3.f = ce2.f;
		ce3.g = ce2.g;
		ce3.h = ce2.h;
		ce3.i = ce2.i;
		ce3.j = ce2.j;
		ce3.k = ce2.k;
		ce3.l.X = 0f;
		ce3.l.Y = ce2.l.Y;
		ce3.m = ce2.m;
		ce3.n = ce2.n;
		ce3.a = new List<bi>();
		int num = A_1;
		if (ce3.a.Count + A_1 > 75)
		{
			num = (int)((float)num * 0.5f);
		}
		if (ce3.a.Count + A_1 > 150)
		{
			num = 150 - ce3.a.Count;
		}
		if (num <= 0)
		{
			return;
		}
		for (int num2 = 0; num2 < num; num2++)
		{
			bi bi2 = new bi();
			float num3 = (b9.a() - 0.5f) * A_4;
			float num4 = (b9.a() - 0.5f) * A_5;
			bi2.a.X = num3 * (float)Math.Cos(A_6) - num4 * (float)Math.Sin(A_6);
			bi2.a.Y = num3 * (float)Math.Sin(A_6) + num4 * (float)Math.Cos(A_6);
			bi2.b.X = ce3.d + (ce3.e - ce3.d) * b9.a();
			bi2.b.Y = ce3.d + (ce3.e - ce3.d) * b9.a();
			bi2.c = b9.a() * (float)Math.PI * 2f;
			bi2.d = ce3.f + (ce3.g - ce3.f) * b9.a();
			bi2.e = ce3.h + (ce3.i - ce3.h) * b9.a();
			bi2.f = ce3.j + (ce3.k - ce3.j) * b9.a();
			bi2.g = bi2.e;
			bi2.h = 0f;
			bi2.i = ce3.m;
			bi2.j = ce3.n;
			bi2.k = 0;
			if (bi2.j)
			{
				bi2.k = 0;
			}
			else
			{
				bi2.k = b9.a(0, ce3.b.Count - 1);
			}
			ce3.a.Add(bi2);
		}
		a.Add(ce3);
	}

	public void d()
	{
		for (int num = a.Count - 1; num >= 0; num--)
		{
			a.RemoveAt(num);
		}
	}

	public void b()
	{
		for (int num = 0; num < a.Count; num++)
		{
			b(a[num]);
		}
	}

	public void b(float A_0)
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		for (int num = a.Count - 1; num >= 0; num--)
		{
			ce ce2 = a[num];
			if (ce2.a.Count == 0)
			{
				a.RemoveAt(num);
			}
			else
			{
				for (int num2 = 0; num2 < ce2.a.Count; num2++)
				{
					bi bi2 = ce2.a[num2];
					bi2.h += A_0;
					if (bi2.h > bi2.i || bi2.a.Y > 800f)
					{
						ce2.a.RemoveAt(num2);
						num2--;
						continue;
					}
					bi2.b += ce2.l * A_0;
					bi2.a += bi2.b * A_0;
					bi2.c += bi2.d * A_0;
					bi2.g = bi2.e + (bi2.f - bi2.e) * (bi2.h / bi2.i);
					if (bi2.j)
					{
						int num3 = (int)Math.Ceiling((float)ce2.b.Count * (bi2.h / bi2.i));
						if (num3 < 0)
						{
							num3 = 0;
						}
						if (num3 >= ce2.b.Count)
						{
							num3 = ce2.b.Count - 1;
						}
						if (num3 != bi2.k)
						{
							bi2.k = num3;
						}
					}
				}
			}
		}
	}

	private void b(ce A_0)
	{
		for (int num = 0; num < A_0.a.Count; num++)
		{
			bi bi2 = A_0.a[num];
			ae ae2 = A_0.b[bi2.k];
			float A_ = A_0.c.X;
			float A_2 = A_0.c.Y;
			c().f(ref A_, ref A_2);
			float num2 = bi2.a.X * c().m();
			float num3 = bi2.a.Y * c().m();
			bu.b().b(ae2, (int)(A_ + num2), (int)(A_2 + num3), bi2.g * c().m(), bi2.g * c().m(), bi2.c, ae2.e, ae2.f);
		}
	}
}
