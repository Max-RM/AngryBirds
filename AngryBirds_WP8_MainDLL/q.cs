using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

internal class q : da
{
	private ae c;

	[CompilerGenerated]
	private new int d;

	[SpecialName]
	[CompilerGenerated]
	public int be()
	{
		return d;
	}

	[SpecialName]
	[CompilerGenerated]
	public void i(int A_0)
	{
		d = A_0;
	}

	public q()
	{
		c = u.a().g("ABOUT_BG");
	}

	public override void i()
	{
		int num = 43;
		float numW = (float)be();
		float visH = bu.VisibleHeight;
		float scaleY = Math.Max(1f, visH / (float)c.d);
		Rectangle a_ = default(Rectangle);
		a_ = new Rectangle(20, 0, 20, c.d);
		float a_2 = numW / 20f;
		bu.b().b(c, base.af + aj, 0f, a_, a_2, scaleY, 0f);
		Rectangle a_3 = default(Rectangle);
		a_3 = new Rectangle(c.c - num, 0, num, c.d);
		bu.b().b(c, base.af + aj + numW, 0f, a_3, 1f, scaleY, 0f);
	}
}
