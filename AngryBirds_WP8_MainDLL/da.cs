using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

internal class da : ck
{
	private bool a8;

	private int a9;

	private int ba;

	[CompilerGenerated]
	private ae bb;

	[CompilerGenerated]
	private float bc;

	[CompilerGenerated]
	private float bd;

	[CompilerGenerated]
	private float be;

	[SpecialName]
	public int bi()
	{
		return a9;
	}

	[SpecialName]
	public void ag(int A_0)
	{
		a9 = A_0;
		a8 = true;
	}

	[SpecialName]
	public int bk()
	{
		return ba;
	}

	[SpecialName]
	public void ai(int A_0)
	{
		ba = A_0;
		a8 = true;
	}

	[SpecialName]
	[CompilerGenerated]
	public ae bf()
	{
		return bb;
	}

	[SpecialName]
	[CompilerGenerated]
	public void i(ae A_0)
	{
		bb = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public float bj()
	{
		return bc;
	}

	[SpecialName]
	[CompilerGenerated]
	public void i(float A_0)
	{
		bc = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public float bh()
	{
		return bd;
	}

	[SpecialName]
	[CompilerGenerated]
	public void ai(float A_0)
	{
		bd = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public float bg()
	{
		return be;
	}

	[SpecialName]
	[CompilerGenerated]
	public void ag(float A_0)
	{
		be = A_0;
	}

	public da()
	{
		i(1f);
		ai(1f);
		ag(0f);
		i(null);
	}

	public override bool Hit(Vector2 A_0)
	{
		return Hit((int)A_0.X, (int)A_0.Y);
	}

	public override bool Hit(int A_0, int A_1)
	{
		if (base.ab != null)
		{
			return base.Hit(A_0, A_1);
		}
		if (bf() == null)
		{
			return false;
		}
		int num = bi();
		int num2 = bk();
		if (!a8)
		{
			num = bf().e;
			num2 = bf().f;
		}
		if ((float)A_0 >= base.af + aj - (float)num * bj() && (float)A_0 <= base.af + aj + ((float)bf().c * bj() - (float)num * bj()) && (float)A_1 >= base.ah + ((ck)this).ak - (float)num2 * bh())
		{
			return (float)A_1 <= base.ah + ((ck)this).ak + ((float)bf().d * bh() - (float)num2 * bh());
		}
		return false;
	}

	public override void i()
	{
		if (bf() != null)
		{
			float num = base.af;
			float num2 = base.ah;
			num += aj;
			num2 += ((ck)this).ak;
			if (a8)
			{
				bu.b().b(bf(), num, num2, bj(), bh(), bg(), a9, ba);
			}
			else
			{
				bu.b().b(bf(), num, num2, bj(), bh(), bg());
			}
		}
	}
}
