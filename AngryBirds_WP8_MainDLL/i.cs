using System;
using AngryBirds;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input.Touch;

internal class i : c
{
	private new string j;

	private new da k;

	private new ae l;

	private new ae m;

	private new ae n;

	private ae q;

	private ae r;

	private ae s;

	private ae t;

	private ae v;

	private ae w;

	private ae x;

	private ae y;

	private ae z;

	private da[] aa;

	private da[] ab;

	private da[] ac;

	private da ad;

	private da ae;

	private da af;

	private da ag;

	private int ah;

	private int ai;

	private float aj;

	private float ak;

	private float al;

	private bool am;

	private bool an;

	private bool ao;

	private bool ap;

	private bool aq;

	public i()
	{
		j = "Level17";
		ah = 8;
		am = false;
		an = false;
		ao = true;
		ap = false;
		aq = false;
		ai = 0;
		al = 0.25f;
	}

	public override void e()
	{
		base.e();
		p("goldenEggSequencerPage");
		SetMenuState(global::m.MenuState.a);
		au("goldenEggs");
		u u2 = u.a();
		aa = new da[ah];
		ab = new da[ah];
		ac = new da[ah];
		SetLayout(new y());
		a3().an();
		a3().g(u2.g("CONCEPT_ART_BG"));
		da da2 = new da();
		da2.i(u2.g("SOUNDBOARD_4_BG"));
		da2.af = 0f;
		da2.ah = 72f;
		p(da2);
		da da3 = new da();
		da3.i(u2.g("SOUNDBOARD_4_HIGHLIGHT"));
		da3.af = 55f + 100.100006f * (float)ai;
		da3.ah = 72f;
		p(ag = da3);
		int num = u2.g("SOUNDBOARD_4_HIGHLIGHT").d;
		int num2 = u2.g("BIRD_BIG_BROTHER").d;
		int num3 = u2.g("SOUNDBOARD_4_GRASS_TOP").c;
		_ = u2.g("SOUNDBOARD_4_GRASS_TOP").d;
		int num4 = (int)Math.Ceiling(800.0 / (double)num3);
		for (int num5 = 0; num5 < num4; num5++)
		{
			da da4 = new da();
			da4.i(u2.g("SOUNDBOARD_4_GRASS_TOP"));
			da4.af = num5 * num3;
			da4.ah = 72f;
			p(da4);
			da da5 = new da();
			da5.i(u2.g("SOUNDBOARD_4_GRASS_BOTTOM"));
			da5.af = num5 * num3;
			da5.ah = 72f + 166f * (float)num / 166f;
			p(da5);
		}
		l = u2.g("PIGLETTE_BIG_01");
		m = u2.g("SOUNDBOARD_4_PIG_1");
		n = u2.g("PIGLETTE_BIG_01_SMILE");
		q = u2.g("PIGLETTE_BIG_01_BLINK");
		r = u2.g("PIGLETTE_HELMET_01");
		s = u2.g("SOUNDBOARD_4_PIG_2");
		t = u2.g("PIGLETTE_HELMET_01_SMILE");
		v = u2.g("PIGLETTE_HELMET_01_BLINK");
		w = u2.g("PIGLETTE_GRANDPA_01");
		x = u2.g("SOUNDBOARD_4_PIG_3");
		y = u2.g("PIGLETTE_GRANDPA_04_SMILE");
		z = u2.g("PIGLETTE_GRANDPA_01_BLINK");
		for (int num6 = 0; num6 < ah; num6++)
		{
			da[] array = aa;
			int num7 = num6;
			da da6 = new da();
			da6.i(u2.g("SOUNDBOARD_4_PIG_1"));
			da6.af = (float)num6 * 800f / 8f + 38.333332f + 16.666666f;
			da6.ah = 72f + (30f * (float)num / 166f + 0f / 166f);
			da6.ae = 10 + num6;
			((ck)da6).al = true;
			da6.y = c;
			array[num7] = da6;
			p(aa[num6]);
			da[] array2 = ab;
			int num8 = num6;
			da da7 = new da();
			da7.i(u2.g("SOUNDBOARD_4_PIG_2"));
			da7.af = (float)num6 * 800f / 8f + 38.333332f + 16.666666f;
			da7.ah = 72f + (30f * (float)num / 166f + (float)(50 * num) / 166f);
			da7.ae = 20 + num6;
			((ck)da7).al = true;
			da7.y = c;
			array2[num8] = da7;
			p(ab[num6]);
			da[] array3 = ac;
			int num9 = num6;
			da da8 = new da();
			da8.i(u2.g("SOUNDBOARD_4_PIG_3"));
			da8.af = (float)num6 * 800f / 8f + 38.333332f + 16.666666f;
			da8.ah = 72f + (30f * (float)num / 166f + (float)(100 * num) / 166f);
			da8.ae = 30 + num6;
			((ck)da8).al = true;
			da8.y = c;
			array3[num9] = da8;
			p(ac[num6]);
		}
		da da9 = new da();
		da9.i(u2.g("SOUNDBOARD_4_FOOTPRINT"));
		da9.af = 400f;
		da9.ah = 403.2f + (float)num2 / 2.5f;
		p(af = da9);
		da da10 = new da();
		da10.i(u2.g("SOUNDBOARD_4_SHADOW"));
		da10.af = 400f;
		da10.ah = 403.2f + (float)num2 / 2.5f - 15f;
		p(ae = da10);
		da da11 = new da();
		da11.i(u2.g("BIRD_BIG_BROTHER_BLINK"));
		da11.af = 400f;
		da11.ah = 403.2f;
		p(ad = da11);
		da da12 = new da();
		da12.i(u2.g("MENU_SFZ"));
		da12.af = (float)((double)u2.g("MENU_SFZ").c * 0.5);
		da12.ah = (float)((double)u2.g("MENU_SFZ").d * 0.5);
		da12.y = a;
		((ck)da12).al = true;
		a("buttonSfxOn", da12);
		da da13 = new da();
		da13.i(u2.g("BUTTON_OFF"));
		da13.af = (float)((double)u2.g("MENU_SFZ").c * 0.5);
		da13.ah = (float)((double)u2.g("MENU_SFZ").d * 0.5);
		((ck)da13).al = false;
		da13.am = b0.d().p();
		a("buttonSfxOff", k = da13);
		da da14 = new da();
		da14.i(u2.g("LS_BACK_BUTTON"));
		da14.af = 0f;
		da14.ah = 480f;
		da14.am = true;
		((ck)da14).al = true;
		da14.y = a9().c;
		da14.z = "goldenEggs";
		da14.aa = u2.f("menu_back");
		da14.ab = new r(0, 400, 90, 480);
		p(da14);
	}

	public override void h(GameTime A_0)
	{
		a8().f(A_0: false);
		e("buttonSfxOff").am = b0.d().p();
		b0.d().k(A_0: true);
		SetMenuState(global::m.MenuState.a);
	}

	public override void b(GameTime A_0)
	{
		SetMenuState(global::m.MenuState.b);
		am = false;
		an = false;
		ao = true;
		ap = false;
		aq = false;
		ai = 0;
		ad.i(u.a().g("BIRD_BIG_BROTHER_BLINK"));
		ad.ag(0f);
		ad.af = 400f;
		ae.af = 400f;
		ag.af = 55f + 100.100006f * (float)ai;
		for (int num = 0; num < ah; num++)
		{
			aa[num].i(m);
			ab[num].i(s);
			ac[num].i(x);
			aa[num].i(1f);
			aa[num].ai(1f);
			ab[num].i(1f);
			ab[num].ai(1f);
			ac[num].i(1f);
			ac[num].ai(1f);
		}
		b0.d().k(A_0: true);
	}

	public override void f()
	{
		if (bc() != global::m.MenuState.b)
		{
			base.f();
		}
	}

	public override void g(GameTime A_0)
	{
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		base.g(A_0);
		k.am = b0.d().p();
		float num = (float)A_0.ElapsedGameTime.Milliseconds * 0.001f;
		int num2 = af.bf().c;
		if (Controls.GetInstance().IsDragged)
		{
			for (int num3 = 0; num3 < Controls.GetInstance().DragGestures.Count; num3++)
			{
				da obj = ad;
				GestureSample val = Controls.GetInstance().DragGestures[num3];
				if (obj.Hit(val.Position))
				{
					GestureSample val2 = Controls.GetInstance().DragGestures[num3];
					Vector2 delta = val2.Delta;
					ad.af += delta.X;
					if (ad.af < af.af - (float)(num2 / 2))
					{
						ad.af = af.af - (float)(num2 / 2);
					}
					else if (ad.af > af.af + (float)(num2 / 2))
					{
						ad.af = af.af + (float)(num2 / 2);
					}
				}
			}
		}
		float num4 = (ad.af - (af.af - (float)(num2 / 2))) / (float)num2;
		ae.af = ad.af;
		al = 1f / (2.6666667f + num4 * 5.3333335f);
		ap = ad.af == af.af + (float)(num2 / 2);
		if (Controls.GetInstance().IsTapped)
		{
			da obj2 = ad;
			GestureSample val3 = Controls.GetInstance().TapGestures[0];
			if (obj2.Hit(val3.Position))
			{
				am = !am;
				if (am)
				{
					ad.i(u.a().g("BIRD_BIG_BROTHER_YELL"));
					b0.d().d("big_brother_special_1").ac();
				}
				else
				{
					ad.i(u.a().g("BIRD_BIG_BROTHER_BLINK"));
					ad.ag(0f);
					ak = 0f;
					aj = 0f;
					ai = 0;
					ag.af = 55f + 100.100006f * (float)ai;
					for (int num5 = 0; num5 < ah; num5++)
					{
						if (aa[num5].bf() == l || aa[num5].bf() == n)
						{
							aa[num5].i(q);
						}
						if (ab[num5].bf() == r || ab[num5].bf() == t)
						{
							ab[num5].i(v);
						}
						if (ac[num5].bf() == w || ac[num5].bf() == y)
						{
							ac[num5].i(z);
						}
					}
				}
			}
		}
		if (!am)
		{
			return;
		}
		for (int num6 = 0; num6 < ah; num6++)
		{
			if (aa[num6].bf() == q)
			{
				aa[num6].i(l);
			}
			if (ab[num6].bf() == v)
			{
				ab[num6].i(r);
			}
			if (ac[num6].bf() == z)
			{
				ac[num6].i(w);
			}
		}
		aj += num;
		if (aj < 3f)
		{
			aj += num;
			return;
		}
		ad.i(u.a().g("BIRD_BIG_BROTHER"));
		a(num);
		c(num);
		au();
	}

	public void a(ck A_0)
	{
		if (b0.d().p())
		{
			b0.d().g(0.5f);
			k.am = false;
		}
		else
		{
			b0.d().f(0.5f);
			k.am = true;
		}
	}

	public void c(ck A_0)
	{
		da da2 = (da)A_0;
		int num = da2.ae;
		int num2 = num / 10;
		int num3 = num % 10;
		int num4 = m.c;
		int num5 = m.d;
		switch (num2)
		{
		case 1:
			if (aa[num3].bf() == m && am)
			{
				aa[num3].i(l);
				aa[num3].i(0.45f * (float)num4 / 42f);
				aa[num3].ai(0.45f * (float)num5 / 44f);
			}
			else if (aa[num3].bf() == m && !am)
			{
				aa[num3].i(q);
				aa[num3].i(0.45f * (float)num4 / 42f);
				aa[num3].ai(0.45f * (float)num5 / 44f);
			}
			else
			{
				aa[num3].i(m);
				aa[num3].i(1f);
				aa[num3].ai(1f);
			}
			break;
		case 2:
			if (ab[num3].bf() == s && am)
			{
				ab[num3].i(r);
				ab[num3].i(0.5f * (float)num4 / 46f);
				ab[num3].ai(0.5f * (float)num5 / 44f);
			}
			else if (ab[num3].bf() == s && !am)
			{
				ab[num3].i(v);
				ab[num3].i(0.5f * (float)num4 / 46f);
				ab[num3].ai(0.5f * (float)num5 / 44f);
			}
			else
			{
				ab[num3].i(s);
				ab[num3].i(1f);
				ab[num3].ai(1f);
			}
			break;
		case 3:
			if (ac[num3].bf() == x && am)
			{
				ac[num3].i(w);
				ac[num3].i(0.45f * (float)num4 / 49f);
				ac[num3].ai(0.45f * (float)num5 / 46f);
			}
			else if (ac[num3].bf() == x && !am)
			{
				ac[num3].i(z);
				ac[num3].i(0.45f * (float)num4 / 49f);
				ac[num3].ai(0.45f * (float)num5 / 46f);
			}
			else
			{
				ac[num3].i(x);
				ac[num3].i(1f);
				ac[num3].ai(1f);
			}
			break;
		}
	}

	public void au()
	{
		bool flag = true;
		for (int num = 0; num < ah; num++)
		{
			flag = flag && aa[num].bf() != m && ab[num].bf() != s && ac[num].bf() != x;
		}
		if (flag && !aq && ap)
		{
			am = false;
			aq = true;
			ad.i(u.a().g("BIRD_BIG_BROTHER_BLINK"));
			ad.ag(0f);
			ak = 0f;
			aj = 0f;
			ai = 0;
			ag.af = 55f + 100.100006f * (float)ai;
			for (int num2 = 0; num2 < ah; num2++)
			{
				aa[num2].i(q);
				ab[num2].i(v);
				ac[num2].i(z);
			}
			a(j, A_1: false, A_2: false);
		}
	}

	public void c(float A_0)
	{
		if (ao)
		{
			if (ad.bg() < 0.1f)
			{
				da obj = ad;
				obj.ag(obj.bg() + A_0 / (al * 6f));
			}
			else
			{
				ao = false;
			}
		}
		else if (ad.bg() > -0.1f)
		{
			da obj2 = ad;
			obj2.ag(obj2.bg() - A_0 / (al * 6f));
		}
		else
		{
			ao = true;
		}
	}

	public void a(float A_0)
	{
		an = false;
		if (!an)
		{
			string text = "";
			int num = m.c;
			int num2 = m.d;
			if (aa[ai].bf() == l)
			{
				aa[ai].i(n);
				aa[ai].i(0.45f * (float)num / 42f);
				aa[ai].ai(0.45f * (float)num2 / 44f);
				text = "pig_hi-hat_" + (ai % 2 + 1);
				b0.d().d(text).ac();
			}
			if (ab[ai].bf() == r)
			{
				ab[ai].i(t);
				ab[ai].i(0.5f * (float)num / 46f);
				ab[ai].ai(0.5f * (float)num2 / 44f);
				text = "pig_snare_" + (ai % 4 + 1);
				b0.d().d(text).ac();
			}
			if (ac[ai].bf() == w)
			{
				ac[ai].i(y);
				ac[ai].i(0.45f * (float)num / 49f);
				ac[ai].ai(0.45f * (float)num2 / 46f);
				text = "pig_bd";
				b0.d().d(text).ac();
			}
			an = true;
		}
		ak += A_0;
		if (ak >= al)
		{
			ak = 0f;
			an = false;
			if (aa[ai].bf() == n)
			{
				aa[ai].i(l);
			}
			if (ab[ai].bf() == t)
			{
				ab[ai].i(r);
			}
			if (ac[ai].bf() == y)
			{
				ac[ai].i(w);
			}
			ai++;
			if (ai > 7)
			{
				ai = 0;
			}
			ag.af = 55f + 100.100006f * (float)ai;
		}
	}
}
