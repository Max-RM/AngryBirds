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
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		Rectangle a_ = default(Rectangle);
		a_ = new Rectangle(20, 0, 20, c.d);
		int num = 43;
		float num2 = 20f;
		float a_2 = (float)be() / num2;
		bu.b().b(c, base.af + aj, 0f, a_, a_2, 1f, 0f);
		Rectangle a_3 = default(Rectangle);
		a_3 = new Rectangle(c.c - num, 0, num, c.d);
		bu.b().b(c, base.af + aj + (float)be(), 0f, a_3, 1f, 1f, 0f);
	}
}
