using System.Collections.Generic;
using Microsoft.Xna.Framework;

internal class a2
{
	public int a;

	public string b;

	public List<c5> c;

	public List<c5> d;

	public Color e;

	public Color f;

	public a2(int A_0, string A_1, c5[] A_2, c5[] A_3, Color A_4, Color A_5)
	{
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		a = A_0;
		b = A_1;
		c = new List<c5>();
		d = new List<c5>();
		for (int num = 0; num < A_2.Length; num++)
		{
			c.Add(A_2[num]);
		}
		for (int num2 = 0; num2 < A_3.Length; num2++)
		{
			d.Add(A_3[num2]);
		}
		e = A_4;
		f = A_5;
	}

	public void g()
	{
		for (int num = 0; num < d.Count; num++)
		{
			d[num].a = u.a().g(d[num].c);
		}
		for (int num2 = 0; num2 < c.Count; num2++)
		{
			c[num2].a = u.a().g(c[num2].c);
		}
	}
}
