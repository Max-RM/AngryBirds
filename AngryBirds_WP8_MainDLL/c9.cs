using System;
using System.Runtime.CompilerServices;
using AngryBirds;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input.Touch;

internal class c9 : cd
{
	private Vector2 au = new Vector2(0f);

	private Vector2 av = new Vector2(0f, 0f);

	private Vector2 aw = Vector2.Zero;

	[CompilerGenerated]
	private bool ax;

	[CompilerGenerated]
	private bool ay;

	[CompilerGenerated]
	private bool az;

	[CompilerGenerated]
	private bool a0;

	[CompilerGenerated]
	private Point a1;

	[CompilerGenerated]
	private ck a2;

	[CompilerGenerated]
	private int a3;

	[CompilerGenerated]
	private bool a4;

	[CompilerGenerated]
	private bool a5;

	[CompilerGenerated]
	private float a6;

	[CompilerGenerated]
	private float a7;

	[CompilerGenerated]
	private float a8;

	[CompilerGenerated]
	private bool a9;

	[CompilerGenerated]
	private Vector2 ba;

	[SpecialName]
	[CompilerGenerated]
	public bool br()
	{
		return ax;
	}

	[SpecialName]
	[CompilerGenerated]
	public void ai(bool A_0)
	{
		ax = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public bool bu()
	{
		return ay;
	}

	[SpecialName]
	[CompilerGenerated]
	public void bg(bool A_0)
	{
		ay = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public bool bg()
	{
		return az;
	}

	[SpecialName]
	[CompilerGenerated]
	public void ag(bool A_0)
	{
		az = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public bool bm()
	{
		return a0;
	}

	[SpecialName]
	[CompilerGenerated]
	public void i(bool A_0)
	{
		a0 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public Point bq()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return a1;
	}

	[SpecialName]
	[CompilerGenerated]
	public void i(Point A_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		a1 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public ck bl()
	{
		return a2;
	}

	[SpecialName]
	[CompilerGenerated]
	public void i(ck A_0)
	{
		a2 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public int bh()
	{
		return a3;
	}

	[SpecialName]
	[CompilerGenerated]
	private void i(int A_0)
	{
		a3 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public bool bp()
	{
		return a4;
	}

	[SpecialName]
	[CompilerGenerated]
	public void be(bool A_0)
	{
		a4 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public bool bi()
	{
		return a5;
	}

	[SpecialName]
	[CompilerGenerated]
	public void bh(bool A_0)
	{
		a5 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public float bj()
	{
		return a6;
	}

	[SpecialName]
	[CompilerGenerated]
	public void ai(float A_0)
	{
		a6 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public float be()
	{
		return a7;
	}

	[SpecialName]
	[CompilerGenerated]
	public void ag(float A_0)
	{
		a7 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public float bn()
	{
		return a8;
	}

	[SpecialName]
	[CompilerGenerated]
	public void i(float A_0)
	{
		a8 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public bool bf()
	{
		return a9;
	}

	[SpecialName]
	[CompilerGenerated]
	public void bf(bool A_0)
	{
		a9 = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public Vector2 bk()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return ba;
	}

	[SpecialName]
	[CompilerGenerated]
	public void ag(Vector2 A_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		ba = A_0;
	}

	public c9()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		i(A_0: false);
		bh(A_0: true);
		ai(A_0: true);
		bg(A_0: true);
		ag(A_0: true);
		this.i(new Point(400, 240));
		i((ck)null);
		be(A_0: false);
		i(5f);
		bf(A_0: false);
		ag(new Vector2
		{
			X = 2.1474836E+09f,
			Y = 2.1474836E+09f
		});
		ai(800f);
		ag(480f);
	}

	public void bt()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		if (bw().Count == 0)
		{
			return;
		}
		float num = di.d((float)bq().X - ((ck)this).aj, (float)bq().Y - ((ck)this).ak, bw()[0].af, bw()[0].ah);
		ck a_ = bw()[0];
		int a_2 = 0;
		for (int num2 = 0; num2 < bw().Count; num2++)
		{
			ck ck2 = bw()[num2];
			float num3 = di.d((float)bq().X - ((ck)this).aj, (float)bq().Y - ((ck)this).ak, ck2.af, ck2.ah);
			if (num3 < num)
			{
				num = num3;
				a_ = ck2;
				a_2 = num2;
			}
		}
		i(a_);
		i(a_2);
	}

	public void i(Vector2 A_0)
	{
		if (bw().Count == 0 || bl() == null)
		{
			return;
		}
		ck ck2 = null;
		int a_ = 0;
		if (br() && Math.Abs(A_0.X) > Math.Abs(A_0.Y))
		{
			if (A_0.X < 0f)
			{
				for (int num = 0; num < bw().Count; num++)
				{
					ck ck3 = bw()[num];
					if (ck3.af > bl().af && (ck2 == null || ck3.af < ck2.af))
					{
						ck2 = ck3;
						a_ = num;
					}
				}
			}
			else if (A_0.X > 0f)
			{
				for (int num2 = 0; num2 < bw().Count; num2++)
				{
					ck ck4 = bw()[num2];
					if (ck4.af < bl().af && (ck2 == null || ck4.af > ck2.af))
					{
						ck2 = ck4;
						a_ = num2;
					}
				}
			}
		}
		else if (bu())
		{
			if (A_0.Y < 0f)
			{
				for (int num3 = 0; num3 < bw().Count; num3++)
				{
					ck ck5 = bw()[num3];
					if (ck5.ah > bl().ah && (ck2 == null || ck5.ah < ck2.ah))
					{
						ck2 = ck5;
						a_ = num3;
					}
				}
			}
			else if (A_0.Y > 0f)
			{
				for (int num4 = 0; num4 < bw().Count; num4++)
				{
					ck ck6 = bw()[num4];
					if (ck6.ah < bl().ah && (ck2 == null || ck6.ah > ck2.ah))
					{
						ck2 = ck6;
						a_ = num4;
					}
				}
			}
		}
		if (ck2 != null)
		{
			i(ck2);
			i(a_);
		}
	}

	public void ag(ck A_0)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		if (A_0 != null)
		{
			i(A_0);
			i(bw().IndexOf(bl()));
			((ck)this).aj = (float)bq().X - bl().af;
			((ck)this).ak = (float)bq().Y - bl().ah;
			SyncChildOffsets();
		}
	}

	public void ai(ck A_0)
	{
		i(A_0);
		i(bw().IndexOf(bl()));
		be(A_0: true);
	}

	public override void am(ck A_0, ck A_1)
	{
		base.am(A_0, A_1);
		if (A_0 == bl())
		{
			i(A_1);
			i(bw().IndexOf(A_1));
		}
	}

	public void bo()
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		float num = float.MinValue;
		float num2 = float.MinValue;
		for (int num3 = 0; num3 < bw().Count; num3++)
		{
			num = Math.Max(bw()[num3].af, num);
			num2 = Math.Max(bw()[num3].ah, num2);
		}
		ag(new Vector2(num + 400f, num2 + 240f));
	}

	public void bs()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		if (Controls.GetInstance().IsDragged)
		{
			be(A_0: false);
			for (int num = 0; num < Controls.GetInstance().DragGestures.Count; num++)
			{
				GestureSample val = Controls.GetInstance().DragGestures[num];
				aw = val.Position;
				if (aw.X < base.af || aw.X > base.af + bj() || aw.Y < ((ck)this).ah || aw.Y > ((ck)this).ah + be())
				{
					continue;
				}
				GestureSample val2 = Controls.GetInstance().DragGestures[num];
				Vector2 delta = val2.Delta;
				if (bi())
				{
					float num2 = ((bj() < bk().X) ? bj() : bk().X);
					float num3 = ((be() < bk().Y) ? be() : bk().Y);
					if (((ck)this).aj + delta.X > 0f || ((ck)this).aj + delta.X < 0f - (bk().X - num2 - base.af))
					{
						delta.X *= 0.5f;
					}
					if (((ck)this).ak + delta.Y > 0f || ((ck)this).ak + delta.Y < 0f - (bk().Y - num3 - ((ck)this).ah))
					{
						delta.Y *= 0.5f;
					}
				}
				if (br())
				{
					((ck)this).aj += delta.X * 1f;
				}
				if (bu())
				{
					((ck)this).ak += delta.Y * 1f;
				}
			}
		}
		if (Controls.GetInstance().IsFlicked && !(aw.X < base.af) && !(aw.X > base.af + bj()) && !(aw.Y < ((ck)this).ah) && !(aw.Y > ((ck)this).ah + be()))
		{
			GestureSample val3 = Controls.GetInstance().FlickGestures[0];
			Vector2 delta2 = val3.Delta;
			if (bg())
			{
				i(delta2);
			}
			else
			{
				au = delta2 * 0.1f;
			}
			be(A_0: true);
		}
		else if (Controls.GetInstance().IsDragCompleted)
		{
			bt();
			be(A_0: true);
		}
		SyncChildOffsets();
	}

	public override void d(GameTime A_0)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0483: Unknown result type (might be due to invalid IL or missing references)
		//IL_0489: Unknown result type (might be due to invalid IL or missing references)
		//IL_048f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0499: Unknown result type (might be due to invalid IL or missing references)
		//IL_049e: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0708: Unknown result type (might be due to invalid IL or missing references)
		//IL_072a: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0517: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_056a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0593: Unknown result type (might be due to invalid IL or missing references)
		base.d(A_0);
		float num = (float)A_0.ElapsedGameTime.Milliseconds * 0.001f;
		float num2 = ((bj() < bk().X) ? bj() : bk().X);
		float num3 = ((be() < bk().Y) ? be() : bk().Y);
		bool flag = ((ck)this).aj > 0.01f || ((ck)this).aj + (bk().X - num2 - base.af) < -0.01f;
		bool flag2 = ((ck)this).ak > 0.01f || ((ck)this).ak + (bk().Y - num3 - ((ck)this).ah) < -0.01f;
		if (bp() && bg() && bl() != null)
		{
			Vector2 val = default(Vector2);
			val = new Vector2(bl().aj + bl().af, bl().ak + bl().ah);
			Vector2 val2 = default(Vector2);
			val2 = new Vector2((float)bq().X - val.X, (float)bq().Y - val.Y);
			if (bf())
			{
				if (av.X == 0f && av.Y == 0f)
				{
					av.X = val2.X * (num / 0.75f);
					av.Y = val2.Y * (num / 0.75f);
				}
				((ck)this).aj += av.X;
				((ck)this).ak += av.Y;
				if ((val2.X > 0f && av.X <= 0f) || (val2.Y > 0f && av.Y <= 0f) || (val2.X < 0f && av.X >= 0f) || (val2.Y < 0f && av.Y >= 0f))
				{
					ag(bl());
					be(A_0: false);
					bf(A_0: false);
					av = Vector2.Zero;
				}
			}
			else
			{
				float num4 = (float)bq().X - bl().af;
				float num5 = (float)bq().Y - bl().ah;
				val2.X = (val.X * (bn() - 1f) + (float)bq().X) / bn() - val.X;
				val2.Y = (val.Y * (bn() - 1f) + (float)bq().Y) / bn() - val.Y;
				if (val2.X > 0f)
				{
					val2.X = Math.Max(val2.X, 200f * num);
				}
				else if (val2.X < 0f)
				{
					val2.X = Math.Min(val2.X, -200f * num);
				}
				if (val2.Y > 0f)
				{
					val2.Y = Math.Max(val2.Y, 200f * num);
				}
				else if (val2.Y < 0f)
				{
					val2.Y = Math.Min(val2.Y, -200f * num);
				}
				if (Math.Abs(((ck)this).aj - num4) <= 200f * num && Math.Abs(((ck)this).ak - num5) <= 200f * num)
				{
					((ck)this).aj = num4;
					((ck)this).ak = num5;
					be(A_0: false);
				}
				else
				{
					if (br())
					{
						((ck)this).aj += val2.X;
					}
					if (bu())
					{
						((ck)this).ak += val2.Y;
					}
				}
			}
		}
		else if (bp() && !bg())
		{
			au -= au * num * 10f;
			if (bm() && (flag || flag2))
			{
				if (((ck)this).aj > 0.01f)
				{
					((ck)this).aj -= ((ck)this).aj * num * 10f;
				}
				else if (((ck)this).aj + (bk().X - num2 - base.af) < -0.01f)
				{
					((ck)this).aj -= (((ck)this).aj + (bk().X - num2 - base.af)) * num * 10f;
				}
				if (((ck)this).ak > 0.01f)
				{
					((ck)this).ak -= ((ck)this).ak * num * 10f;
				}
				else if (((ck)this).ak + (bk().Y - num3 - ((ck)this).ah) < -0.01f)
				{
					((ck)this).ak -= (((ck)this).ak + (bk().Y - num3 - ((ck)this).ah)) * num * 10f;
				}
			}
			if (Math.Abs(au.X) < 1f && Math.Abs(au.Y) < 1f)
			{
				au = new Vector2(0f);
				be(bm() && (flag || flag2));
			}
			else
			{
				if (br() && Math.Abs(au.X) >= 1f)
				{
					((ck)this).aj += au.X * num * 10f;
				}
				if (bu() && Math.Abs(au.Y) >= 1f)
				{
					((ck)this).ak += au.Y * num * 10f;
				}
			}
		}
		if (((ck)this).aj > 801f)
		{
			((ck)this).aj = 800f;
		}
		else if (((ck)this).aj + (bk().X - num2 - base.af) < -801f)
		{
			((ck)this).aj = -800f - (bk().X - num2 - base.af);
		}
		if (((ck)this).ak > 481f)
		{
			((ck)this).ak = 480f;
		}
		else if (((ck)this).ak + (bk().Y - num3 - ((ck)this).ah) < -481f)
		{
			((ck)this).ak = -480f - (bk().Y - num3 - ((ck)this).ah);
		}
		SyncChildOffsets();
	}

	private void SyncChildOffsets()
	{
		for (int num = 0; num < bw().Count; num++)
		{
			ck ck2 = bw()[num];
			if (ck2 is cd cd2)
			{
				cd2.SetGroupY(((ck)this).aj);
			}
			else
			{
				ck2.aj = ((ck)this).aj;
			}
			ck2.ak = ((ck)this).ak;
		}
	}
}
