using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.Xna.Framework;

internal class cr : ck
{
	private co an;

	private string ao;

	private string[] ap;

	private string[][] aq;

	private string[] ar;

	private bool @as;

	private float at;

	private StringBuilder au = new StringBuilder();

	private bool av = true;

	[CompilerGenerated]
	private int aw;

	[CompilerGenerated]
	private int ax;

	[CompilerGenerated]
	private Color ay;

	[SpecialName]
	public co bl()
	{
		return an;
	}

	[SpecialName]
	public void i(co A_0)
	{
		an = A_0;
		be();
	}

	[SpecialName]
	public string bj()
	{
		return ao;
	}

	[SpecialName]
	public void i(string A_0)
	{
		ao = A_0;
		if (A_0 != null)
		{
			ap = ao.Split('\n');
			aq = new string[ap.Length][];
			for (int num = 0; num < ap.Length; num++)
			{
				aq[num] = ap[num].Split(' ');
			}
		}
		else
		{
			ap = null;
			aq = null;
		}
		be();
	}

	[SpecialName]
	public float bk()
	{
		return at;
	}

	[SpecialName]
	public void i(float A_0)
	{
		at = A_0;
		av = true;
		be();
	}

	[SpecialName]
	public bool bm()
	{
		return @as;
	}

	[SpecialName]
	public void i(bool A_0)
	{
		@as = A_0;
		be();
	}

	[SpecialName]
	[CompilerGenerated]
	public int bh()
	{
		return aw;
	}

	[SpecialName]
	[CompilerGenerated]
	private void ag(int A_0)
	{
		aw = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public int bi()
	{
		return ax;
	}

	[SpecialName]
	[CompilerGenerated]
	private void i(int A_0)
	{
		ax = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public Color bg()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return ay;
	}

	[SpecialName]
	[CompilerGenerated]
	public void i(Color A_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		ay = A_0;
	}

	public cr()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		i(Color.White);
		i(A_0: false);
		i(0f);
		i((string)null);
		i(u.a().a("FONT_BASIC_WP7.dat"));
	}

	private void bf()
	{
		if (bj() == null || bl() == null)
		{
			return;
		}
		av = false;
		List<string> list = new List<string>();
		int num = bl().a(" ");
		for (int num2 = 0; num2 < ap.Length; num2++)
		{
			if (!(bk() > 0f))
			{
				continue;
			}
			int num3 = 0;
			au.Length = 0;
			for (int num4 = 0; num4 < aq[num2].Length; num4++)
			{
				num3 += bl().a(aq[num2][num4]);
				if ((float)num3 > bk())
				{
					list.Add(au.ToString());
					au.Length = 0;
					num3 = 0;
				}
				au.Append(aq[num2][num4]);
				au.Append(' ');
				num3 += num;
			}
			list.Add(au.ToString());
		}
		ar = list.ToArray();
	}

	public override void i()
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		if (bj() == null || bl() == null)
		{
			return;
		}
		if (av)
		{
			bf();
		}
		int num = bl().a();
		float num2 = 0f;
		float num3 = 0f;
		Vector2 zero = Vector2.Zero;
		if (bm())
		{
			for (int num4 = 0; num4 < ar.Length; num4++)
			{
				num2 = base.af + aj;
				num3 = base.ah + ((ck)this).ak + (float)(num4 * num);
				if (!(ar[num4] == "") && !(num3 < (float)(-num)) && !(num3 > (float)(480 + num)))
				{
					zero.X = num2;
					zero.Y = num3;
					bl().a(ar[num4], zero, base.ad, bg());
				}
			}
			return;
		}
		for (int num5 = 0; num5 < ap.Length; num5++)
		{
			num2 = base.af + aj;
			num3 = base.ah + ((ck)this).ak + (float)(num5 * num);
			if (!(ap[num5] == "") && !(num3 < (float)(-num)) && !(num3 > (float)(480 + num)))
			{
				zero.X = num2;
				zero.Y = num3;
				bl().a(ap[num5], zero, base.ad, bg());
			}
		}
	}

	private void be()
	{
		if (ap != null && an != null)
		{
			av = true;
			int num = 0;
			for (int num2 = 0; num2 < ap.Length; num2++)
			{
				num = Math.Max(num, bl().a(ap[num2]));
			}
			ag(num);
			if (bm() && bk() > 0f)
			{
				int num3 = bl().a(" ");
				int num4 = 0;
				for (int num5 = 0; num5 < ap.Length; num5++)
				{
					string[] array = ap[num5].Split(' ');
					int num6 = 0;
					for (int num7 = 0; num7 < array.Length; num7++)
					{
						num6 += bl().a(array[num7]);
						if ((float)num6 > bk())
						{
							num6 = 0;
							num4++;
						}
						num6 += num3;
					}
					num4++;
				}
				i(bl().a() * (ap.Length + num4));
			}
			else
			{
				i(bl().a() * ap.Length);
			}
		}
		else
		{
			ag(0);
			i(0);
		}
	}
}
