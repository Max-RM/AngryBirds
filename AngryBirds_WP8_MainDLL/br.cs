using System.Collections.Generic;
using System.Linq;
using System.Text;
using AngryBirds;
using AngryBirds.Menus;
using Microsoft.Xna.Framework;

internal class br : c
{
	private new class LevelPackWidget : cd
	{
		public new enum PackKind
		{
			a,
			b
		}

		public new da d;

		public da e;

		public cr f;

		public cr g;

		public cr h;

		public da j;

		public da k;

		public bool l;

		private PackKind m;

		public LevelPackWidget(PackKind A_0)
		{
			m = A_0;
		}

		public void i(l A_0)
		{
			StringBuilder stringBuilder = new StringBuilder(10);
			stringBuilder.AppendFormat("{0}/{1}", new object[2] { A_0.b, A_0.c });
			g.i(A_0.a.ToString());
			h.i(stringBuilder.ToString());
		}

		public void i(int A_0)
		{
			u u2 = u.a();
			int num = (int)(400f * (float)A_0);
			int num2 = 240;
			base.af = num;
			((ck)this).ah = num2;
			base.ad = new a7(bn.b, dh.b);
			base.aa = u2.f("menu_confirm");
			int num3 = 0;
			int num4 = -100;
			int num5 = -57;
			int num6 = 89;
			int num7 = -57;
			int num8 = 67;
			int num9 = 57;
			int num10 = 89;
			int num11 = 88;
			d = new da
			{
				af = num,
				ah = num2
			};
			e = new da
			{
				af = num,
				ah = num2
			};
			cr cr2 = new cr();
			cr2.i(u2.a("FONT_BASIC_WP7.dat"));
			cr2.af = num + num3;
			cr2.ah = num2 + num4;
			f = cr2;
			cr cr3 = new cr();
			cr3.i("");
			cr3.i(u2.a("FONT_LS_SMALL_N900.dat"));
			cr3.af = num + num5;
			cr3.ah = num2 + num6;
			g = cr3;
			if (m == LevelPackWidget.PackKind.a)
			{
				cr cr4 = new cr();
				cr4.i("");
				cr4.i(u2.a("FONT_LS_SMALL_N900.dat"));
				cr4.af = num + num9;
				cr4.ah = num2 + num10;
				h = cr4;
			}
			else
			{
				cr cr5 = new cr();
				cr5.i("");
				cr5.i(u2.a("FONT_LS_SMALL_N900.dat"));
				cr5.af = num;
				cr5.ah = num2 + num11;
				h = cr5;
			}
			da da2 = new da();
			da2.i(u2.g("LS_LEVEL_PACK_LOCK"));
			da2.af = num;
			da2.ah = num2;
			j = da2;
			be(d);
			be(e);
			be(f);
			be(g);
			be(h);
			if (m == LevelPackWidget.PackKind.a)
			{
				da da3 = new da();
				da3.i(u2.i("SCORE_TEXT"));
				da3.af = num + num7;
				da3.ah = num2 + num8;
				k = da3;
				be(k);
			}
			be(j);
			be();
		}

		public void bf()
		{
			j.am = false;
			((ck)this).al = true;
			l = false;
		}

		public void be()
		{
			j.am = true;
			((ck)this).al = true;
			l = true;
		}
	}

	private c9 ar;

	private List<LevelPackWidget> @as = new List<LevelPackWidget>();

	private ch at;

	private new LevelPackWidget au;

	public override void e()
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0586: Unknown result type (might be due to invalid IL or missing references)
		//IL_0593: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ad: Unknown result type (might be due to invalid IL or missing references)
		base.e();
		u u2 = u.a();
		p("episodeSelectionPage");
		SetMenuState(global::m.MenuState.a);
		SetLayout(new y());
		a3().an();
		a3().g(u2.g("LS_BACKGROUND"));
		a3().g(new Color(11, 101, 76));
		@as.Add(new LevelPackWidget(LevelPackWidget.PackKind.a));
		@as.Add(new LevelPackWidget(LevelPackWidget.PackKind.a));
		@as.Add(new LevelPackWidget(LevelPackWidget.PackKind.a));
		@as.Add(new LevelPackWidget(LevelPackWidget.PackKind.a));
		@as.Add(new LevelPackWidget(LevelPackWidget.PackKind.a));
		@as.Add(new LevelPackWidget(LevelPackWidget.PackKind.b));
		au = Enumerable.Last<LevelPackWidget>((IEnumerable<LevelPackWidget>)@as);
		c9 c10 = new c9();
		c10.ag(A_0: true);
		c10.ai(A_0: true);
		c10.bg(A_0: false);
		c10.i(2.5f);
		p(ar = c10);
		for (int num = 0; num < @as.Count; num++)
		{
			@as[num].y = c;
			@as[num].i(num + 1);
			@as[num].ae = num;
			ar.be(@as[num]);
		}
		ar.bo();
		@as[0].d.i(u2.g("LS_LEVEL_PACK1_BG_OPEN"));
		@as[0].e.i(u2.g("LS_PACK_THUMB_01"));
		@as[0].f.i(u2.e("TEXT_LP_NAME_1"));
		@as[0].j.am = false;
		@as[0].z = "episode1";
		@as[0].bf();
		@as[1].d.i(u2.g("LS_LEVEL_PACK2_BG_OPEN"));
		@as[1].e.i(u2.g("LS_PACK_THUMB_02"));
		@as[1].f.i(u2.e("TEXT_LP_NAME_2"));
		@as[1].z = "episode2";
		@as[2].d.i(u2.g("LS_LEVEL_PACK3_BG_OPEN"));
		@as[2].f.i(u2.e("TEXT_LP_NAME_3"));
		@as[2].z = "episode3";
		@as[3].d.i(u2.g("LS_LEVEL_PACK4_BG_OPEN"));
		@as[3].e.i(u2.g("LS_PACK_THUMB_04"));
		@as[3].f.i(u2.e("TEXT_LP_NAME_4"));
		@as[3].z = "episode4";
		@as[4].d.i(u2.g("LS_LEVEL_PACK5_BG_OPEN"));
		@as[4].e.i(u2.g("LS_PACK_THUMB_05"));
		@as[4].f.i(u2.e("TEXT_LP_NAME_5"));
		@as[4].z = "episode5";
		au.d.i(u2.g("LS_GOLDEN_EGGS_BG_OPEN"));
		au.z = "goldenEggs";
		au.bf();
		ar.i((ck)@as[0]);
		ar.bt();
		p(at = new ch());
		at.i(new Vector2(400f, 473f), @as.Count);
		da da2 = new da();
		da2.i(u2.g("LS_MAIN_LEFT"));
		da2.af = 0f;
		da2.ah = 480f;
		p(da2);
		da da3 = new da();
		da3.i(u2.g("LS_MAIN_RIGHT"));
		da3.af = 800f;
		da3.ah = 480f;
		p(da3);
		da da4 = new da();
		da4.i(u2.g("LS_BACK_BUTTON"));
		da4.af = 0f;
		da4.ah = 480f;
		da4.y = a9().c;
		da4.z = "mainMenu";
		((ck)da4).al = true;
		da4.aa = u2.f("menu_back");
		p(da4);
		List<Vector2> list = global::p.a().a("goldenEggHitBox");
		p(new ck
		{
			ab = new r((int)list[0].X, (int)list[0].Y, (int)list[1].X, (int)list[1].Y),
			al = true,
			am = false,
			y = a
		});
	}

	public override void f()
	{
		base.f();
	}

	public override void h(GameTime A_0)
	{
		s.a().a("title_theme");
		@as[0].i(bo.a().h("episode1"));
		@as[1].i(bo.a().h("episode2"));
		@as[2].i(bo.a().h("episode3"));
		@as[3].i(bo.a().h("episode4"));
		@as[4].i(bo.a().h("episode5"));
		au.h.i(d.p().ad().ToString());
		if (!dc.IsTrial() && bo.a().f())
		{
			for (int num = 0; num < @as.Count; num++)
			{
				@as[num].bf();
			}
		}
		ar.ag((ck)@as[d.p().t() - 1]);
		SetMenuState(global::m.MenuState.a);
	}

	public override void b(GameTime A_0)
	{
		d.p().p(ar.bh() + 1);
		SetMenuState(global::m.MenuState.b);
	}

	public override void g(GameTime A_0)
	{
		base.g(A_0);
		ar.d(A_0);
		int num = ar.bh();
		if (num != at.bf())
		{
			at.i(num);
		}
	}

	public override void a()
	{
		base.a();
		ar.bs();
	}

	public void c(ck A_0)
	{
		if (ar.bh() != A_0.ae)
		{
			ar.ai(@as[A_0.ae]);
		}
		else if (!@as[A_0.ae].l)
		{
			a9().c(A_0.z);
		}
	}

	public void a(ck A_0)
	{
		if (Controls.GetInstance().IsDoubleTapped)
		{
			string a_ = "Level8";
			if (d.p().s(a_) == GoldenEggType.Locked)
			{
				a(a_, A_1: false, A_2: true);
			}
		}
	}
}
