using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

internal class ch : cd
{
	private new class ChDotItem : cd
	{
		private ck au;

		private da av;

		private da aw;

		public void i(float A_0, float A_1, string A_2)
		{
			u u2 = u.a();
			base.af = A_0;
			((ck)this).ah = A_1;
			base.ad = new a7(bn.b, dh.b);
			da da2 = new da();
			da2.af = A_0;
			da2.ah = A_1;
			da2.i(u2.g("LS_DOT_BLACK"));
			av = da2;
			da da3 = new da();
			da3.af = A_0;
			da3.ah = A_1;
			da3.i(u2.g("LS_DOT_WHITE"));
			da3.am = false;
			aw = da3;
			cr cr2 = new cr();
			cr2.af = A_0;
			cr2.ah = A_1 - (float)u2.a("FONT_LS_SMALL_N900.dat").a();
			cr2.i(u2.a("FONT_LS_SMALL_N900.dat"));
			cr2.i(A_2);
			cr2.am = false;
			au = cr2;
			be(av);
			be(aw);
			be(au);
		}

		public void i(ck A_0)
		{
			A_0.af = au.af;
			A_0.ah = au.ah;
			bf(au);
			au = A_0;
			be(au);
		}

		public void be()
		{
			aw.am = true;
			au.am = true;
		}

		public void bf()
		{
			aw.am = false;
			au.am = false;
		}
	}

	private int w;

	private List<ChDotItem> x = new List<ChDotItem>();

	[CompilerGenerated]
	private new List<string> y;

	[SpecialName]
	public int be()
	{
		if (x == null)
		{
			return 0;
		}
		return x.Count;
	}

	[SpecialName]
	public int bf()
	{
		return w;
	}

	[SpecialName]
	public void i(int A_0)
	{
		if (w >= 0 && w < x.Count && A_0 >= 0 && A_0 < x.Count)
		{
			x[w].bf();
			x[A_0].be();
			w = A_0;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private void i(List<string> A_0)
	{
		y = A_0;
	}

	public void i(Vector2 A_0, int A_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		i(A_0, null, A_1);
	}

	public void i(Vector2 A_0, List<string> A_1)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		bv();
		w = 0;
		x.Clear();
		i(A_1);
		i(A_0, A_1, 0);
	}

	private void i(Vector2 A_0, List<string> A_1, int A_2)
	{
		u.a();
		base.af = A_0.X;
		((ck)this).ah = A_0.Y;
		base.ad = new a7(bn.b, dh.b);
		int num = 18;
		int num2 = A_2;
		if (A_1 != null)
		{
			num2 = A_1.Count;
		}
		float num3 = 0f;
		num3 = ((num2 % 2 != 0) ? (A_0.X - (float)num * ((float)num2 / 2f)) : (A_0.X - (float)num * ((float)(num2 / 2) - 0.5f)));
		for (int num4 = 0; num4 < num2; num4++)
		{
			ChDotItem a10 = new ChDotItem();
			string a_ = "";
			if (A_1 != null)
			{
				a_ = A_1[num4];
			}
			a10.i(num3 + (float)(num * num4), ((ck)this).ah, a_);
			be(a10);
			x.Add(a10);
		}
		i(0);
	}

	public void i(int A_0, ck A_1)
	{
		if (x.Count > 0 && A_0 >= 0 && A_0 < x.Count)
		{
			x[A_0].i(A_1);
		}
	}
}
