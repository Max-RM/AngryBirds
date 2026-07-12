using System;
using System.Runtime.CompilerServices;
using AngryBirds;
using Innogiant;
using Microsoft.Xna.Framework;

internal class cy : ct
{
	protected cf v;

	protected cc w;

	private cw x;

	private cw y;

	protected aw z;

	private aw aa;

	private aw ab;

	private aw ac;

	private float ad;

	private float ae;

	private float af;

	private bool ag;

	private int m_ah;

	private float m_ai;

	private float m_aj;

	private bool m_ak = true;

	public bool al;

	private Vector2 m_am;

	private bool m_an;

	[CompilerGenerated]
	private bool m_ao;

	[CompilerGenerated]
	private bool m_ap;

	[CompilerGenerated]
	private bool m_aq;

	[CompilerGenerated]
	private int m_ar;

	[CompilerGenerated]
	private bool m_as;

	[CompilerGenerated]
	private ae m_at;

	[CompilerGenerated]
	private ae m_au;

	[CompilerGenerated]
	private ae m_av;

	[CompilerGenerated]
	private ae m_aw;

	[CompilerGenerated]
	private ae m_ax;

	[SpecialName]
	[CompilerGenerated]
	public bool at()
	{
		return this.m_ao;
	}

	[SpecialName]
	[CompilerGenerated]
	public void ai(bool A_0)
	{
		this.m_ao = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public bool au()
	{
		return this.m_ap;
	}

	[SpecialName]
	[CompilerGenerated]
	public void j(bool A_0)
	{
		this.m_ap = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public bool ap()
	{
		return this.m_aq;
	}

	[SpecialName]
	[CompilerGenerated]
	public void l(bool A_0)
	{
		this.m_aq = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public int av()
	{
		return this.m_ar;
	}

	[SpecialName]
	[CompilerGenerated]
	private void j(int A_0)
	{
		this.m_ar = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public bool an()
	{
		return this.m_as;
	}

	[SpecialName]
	[CompilerGenerated]
	public void ah(bool A_0)
	{
		this.m_as = A_0;
	}

	[SpecialName]
	public bool aq()
	{
		return this.m_an;
	}

	[SpecialName]
	[CompilerGenerated]
	public ae ao()
	{
		return this.m_at;
	}

	[SpecialName]
	[CompilerGenerated]
	private void ai(ae A_0)
	{
		this.m_at = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public ae ay()
	{
		return this.m_au;
	}

	[SpecialName]
	[CompilerGenerated]
	private void ah(ae A_0)
	{
		this.m_au = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public ae am()
	{
		return this.m_av;
	}

	[SpecialName]
	[CompilerGenerated]
	private void n(ae A_0)
	{
		this.m_av = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public ae ar()
	{
		return this.m_aw;
	}

	[SpecialName]
	[CompilerGenerated]
	private void l(ae A_0)
	{
		this.m_aw = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public ae ax()
	{
		return this.m_ax;
	}

	[SpecialName]
	[CompilerGenerated]
	private void j(ae A_0)
	{
		this.m_ax = A_0;
	}

	[SpecialName]
	public cn @as()
	{
		return (cn)p;
	}

	public override object j()
	{
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		cy cy2 = (cy)base.j();
		cy2.ai(at());
		cy2.j(au());
		cy2.l(ap());
		cy2.j(av());
		cy2.ah(an());
		cy2.v = v;
		cy2.w = w;
		cy2.x = x;
		cy2.y = y;
		if (z != null)
		{
			cy2.z = (aw)z.j();
			cy2.z.g(cy2.ak);
		}
		if (aa != null)
		{
			cy2.aa = (aw)aa.j();
			cy2.aa.g(cy2.aj);
		}
		if (ab != null)
		{
			cy2.ab = (aw)ab.j();
			cy2.ab.g(cy2.ai);
		}
		if (ac != null)
		{
			cy2.ac = (aw)ac.j();
			cy2.ac.g(cy2.ah);
		}
		cy2.r = r;
		cy2.ai(ao());
		cy2.ah(ay());
		cy2.n(am());
		cy2.l(ar());
		cy2.j(ax());
		cy2.s = s;
		cy2.ad = ad;
		cy2.ae = ae;
		cy2.af = af;
		cy2.ag = ag;
		cy2.m_ah = this.m_ah;
		cy2.m_ai = this.m_ai;
		cy2.m_aj = this.m_aj;
		cy2.m_ak = this.m_ak;
		cy2.al = al;
		cy2.m_am = this.m_am;
		cy2.m_an = this.m_an;
		return cy2;
	}

	public cy(string A_0, cb A_1, cf A_2)
		: base(A_0, A_1)
	{
		v = A_2;
		w = v.ag().c();
		r = ((@as().z != null) ? global::u.a().g(@as().z) : null);
		ai((@as().aa != null) ? global::u.a().g(@as().aa) : null);
		ah((@as().ab != null) ? global::u.a().g(@as().ab) : null);
		n((@as().ac != null) ? global::u.a().g(@as().ac) : null);
		l((@as().ad != null) ? global::u.a().g(@as().ad) : null);
		j((@as().ae != null) ? global::u.a().g(@as().ae) : null);
		s = ((@as().af != null) ? global::u.a().g(@as().af) : null);
	}

	public cy(LuaVariable A_0, cf A_1)
		: base(A_0)
	{
		r = ((@as().z != null) ? global::u.a().g(@as().z) : null);
		ai((@as().aa != null) ? global::u.a().g(@as().aa) : null);
		ah((@as().ab != null) ? global::u.a().g(@as().ab) : null);
		n((@as().ac != null) ? global::u.a().g(@as().ac) : null);
		l((@as().ad != null) ? global::u.a().g(@as().ad) : null);
		j((@as().ae != null) ? global::u.a().g(@as().ae) : null);
		s = ((@as().af != null) ? global::u.a().g(@as().af) : null);
		ai(A_0: false);
		j(A_0: true);
		l(A_0: false);
		j((int)A_0["startNumber"]);
		ah(A_0: true);
		v = A_1;
		w = v.ag().c();
		x = global::u.a().f("bird_misc");
		y = global::u.a().f("bird_destroyed");
		aw aw2 = new aw();
		aw2.g(ak);
		aw2.i(1f);
		z = aw2;
		aw aw3 = new aw();
		aw3.g(aj);
		aw3.i((float)b9.a(1, 15) / 10f);
		aw3.g(A_0: true);
		aw3.h(A_0: true);
		aa = aw3;
		aw aw4 = new aw();
		aw4.g(ai);
		aw4.i((float)b9.a(10, 60) / 10f);
		aw4.g(A_0: true);
		aw4.h(A_0: true);
		ab = aw4;
		aw aw5 = new aw();
		aw5.g(ah);
		aw5.i((float)b9.a(10, 60) / 10f);
		aw5.g(A_0: true);
		aw5.h(A_0: true);
		ac = aw5;
	}

	public new virtual void k(ct A_0, float A_1, float A_2)
	{
		if (z != null && z.i())
		{
			z.g();
			z.g(A_0: true);
		}
		if (A_0.p.h != BlockGroup.BIRDS)
		{
			aw();
			if (!this.m_an && v.an().a8 == this)
			{
				v.an().a8 = null;
				this.m_an = true;
			}
		}
		if (ay() != null)
		{
			base.m = ay();
		}
		int a_ = b9.a(12, 20);
		float num = 0f;
		if (A_0.p.g.a == MaterialType.IMMOVABLE || A_0.p.g.a == MaterialType.STATIC_GROUND)
		{
			num = o.f.Length() * o.q / 10f;
		}
		int num2 = 10;
		if (!(A_1 > (float)num2) && !(num > (float)num2))
		{
			return;
		}
		if (A_0.p.g != null)
		{
			if (A_2 > 10f)
			{
				if (A_0.p.g.j != null)
				{
					A_0.p.g.j.y(0.7f);
					A_0.p.g.j.ac();
				}
			}
			else if (A_0.p.s != null)
			{
				A_0.p.s.y(0.7f);
				A_0.p.s.ac();
			}
		}
		v.u(this, @as().ak, a_);
		float num3 = 0.7f;
		float num4 = 60f * o.q / 10f;
		float num5 = @as().ao.c(A_0.p.g.a);
		if (num5 > 1f)
		{
			num4 *= num5;
		}
		num3 = Math.Max(Math.Max(A_1, num) / num4, 0.2f);
		if (p.s != null)
		{
			p.s.y(num3);
			p.s.ac();
		}
	}

	public virtual void l()
	{
	}

	public new virtual void m(float A_0)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		if (ap())
		{
			Vector2 val = di.d(c, d, cf.PhysicsConfig.GetTimestep());
			Vector2 val2 = val - this.m_am;
			if (val2.Length() > 20f)
			{
				w.b(new Vector2(c, d));
				this.m_am.X = val.X;
				this.m_am.Y = val.Y;
			}
		}
		if (g && z != null)
		{
			Vector2 linearVelocity = o.GetLinearVelocity();
			if (linearVelocity.Length() < 0.05f)
			{
				z.g(A_0: true);
				z.h(A_0);
			}
			else
			{
				z.g();
				z.g(A_0: true);
			}
		}
	}

	public void n(bool A_0)
	{
		if (ap() || A_0)
		{
			l(A_0: false);
			if (!(this is ah))
			{
				v.av();
			}
			if (!(this is ah) || ((ah)this).GetChildCount() != 0)
			{
				v.av();
				v.w(this);
			}
		}
	}

	protected void aw()
	{
		n(A_0: false);
	}

	public virtual void n()
	{
		v.ag().b(w);
	}

	public void j(float A_0, bool A_1)
	{
		if (!an())
		{
			return;
		}
		aa.h(A_0);
		ab.h(A_0);
		if (!A_1)
		{
			return;
		}
		if (al)
		{
			af += A_0 * ae;
			d = this.m_ai - (float)Math.Sin(af) * ad;
			if ((this.m_ah == -1 || this.m_ah == 1) && !ag)
			{
				e = af * 2f * (float)this.m_ah;
			}
			if (af > (float)Math.PI)
			{
				if (ag)
				{
					al = false;
					d = this.m_ai;
					e = this.m_aj;
				}
				else
				{
					ag = true;
					af = 0f;
					ad *= 0.3f;
					ae *= 2f;
				}
			}
		}
		else
		{
			ac.h(A_0);
		}
	}

	public void j(float A_0)
	{
		ac.i(A_0);
	}

	private void ak()
	{
		v.u(this, @as().ak, 10);
		v.v((ct)this);
		y.y(1f);
		y.ac();
	}

	private void aj()
	{
		if (this.m_ak)
		{
			aa.i((float)b9.a(1, 15) / 10f);
			base.m = s;
			this.m_ak = false;
		}
		else
		{
			aa.i((float)b9.a(1, 2) / 10f);
			base.m = r;
			this.m_ak = true;
		}
	}

	private void ai()
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		base.m = ax();
		ab.i((float)b9.a(10, 60) / 10f);
		Vector2 val = di.d(c, d, cf.PhysicsConfig.GetTimestep());
		Vector2 val2 = default(Vector2);
		val2 = new Vector2(v.an().g() - val.X, v.an().f() - val.Y);
		float num = 1f - val2.Length() / 1000f;
		if (num > 0f)
		{
			x.y(num);
			x.ac();
		}
	}

	private void ah()
	{
		al = true;
		ac.i((float)b9.a(0, 35) / 10f);
		ad = (float)b9.a(5, 15) / 10f;
		ae = 7f / ad * 1.2f;
		af = 0f;
		ag = false;
		this.m_ah = 0;
		if (v.bd())
		{
			ac.i(0f);
			ad = (float)b9.a(25, 35) / 10f;
			ae = 7f / ad * 1.6f;
		}
		if (@as().ap && ad > 0.9f)
		{
			this.m_ah = b9.a(0, 4) - 1;
		}
		this.m_ai = d;
		this.m_aj = e;
	}
}
