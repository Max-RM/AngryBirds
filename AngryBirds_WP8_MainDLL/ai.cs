using Microsoft.Xna.Framework;

internal class ai : cm
{
	private new delegate void SceneCallback();

	private float x;

	private float y;

	private int z;

	private int aa;

	private float ab;

	private cd ac;

	private SceneCallback ad;

	private bool ae;

	public override void e()
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		base.e();
		au("episode3");
		SetLayout(new y());
		a3().an();
		a3().i(A_0: false);
		a3().h(A_0: true);
		a3().g(new Color(61, 163, 204, 255));
		o(0);
		f(0);
		ab = global::p.a().a("theme6StartMaxOffset")[0].Y;
		ac = new cd
		{
			af = 0f,
			ah = 0f,
			al = true,
			y = a
		};
		ac.aa = u.a().f("menu_confirm");
		ae ae2 = u.a().g("STORY_BEGIN_BG");
		z = ae2.c;
		aa = ae2.d;
		int num = (480 - aa) / 2;
		cd obj = ac;
		da da2 = new da();
		da2.i(ae2);
		da2.af = 0f;
		da2.ah = num;
		obj.be(da2);
		cd obj2 = ac;
		da da3 = new da();
		da3.i(u.a().g("STORY_HIDE_HOOF_1"));
		da3.af = 0f;
		da3.ah = num;
		((ck)da3).al = false;
		obj2.be(da3);
		cd obj3 = ac;
		da da4 = new da();
		da4.i(u.a().g("STORY_BEGIN_FADE"));
		da4.af = 0f;
		da4.ah = num;
		((ck)da4).al = false;
		obj3.be(da4);
		cd obj4 = ac;
		da da5 = new da();
		da5.i(u.a().g("STORY_CLOUD_4"));
		da5.af = 0f;
		da5.ah = num;
		((ck)da5).al = false;
		obj4.be(da5);
		cd obj5 = ac;
		da da6 = new da();
		da6.i(u.a().g("STORY_CLOUD_3"));
		da6.af = 0f;
		da6.ah = num;
		((ck)da6).al = false;
		obj5.be(da6);
		cd obj6 = ac;
		da da7 = new da();
		da7.i(u.a().g("STORY_CLOUD_2"));
		da7.af = 0f;
		da7.ah = num;
		((ck)da7).al = false;
		obj6.be(da7);
		cd obj7 = ac;
		da da8 = new da();
		da8.i(u.a().g("STORY_CLOUD_1"));
		da8.af = 0f;
		da8.ah = num;
		((ck)da8).al = false;
		obj7.be(da8);
		cd obj8 = ac;
		da da9 = new da();
		da9.i(u.a().g("STORY_ANGRY_YELLOW_BIRD"));
		da9.af = 0f;
		da9.ah = num;
		((ck)da9).al = false;
		obj8.be(da9);
		cd obj9 = ac;
		da da10 = new da();
		da10.i(u.a().g("STORY_FLYING_PIGS_3"));
		da10.af = 0f;
		da10.ah = num;
		((ck)da10).al = false;
		obj9.be(da10);
		cd obj10 = ac;
		da da11 = new da();
		da11.i(u.a().g("STORY_FLYING_PIGS_2"));
		da11.af = 0f;
		da11.ah = num;
		((ck)da11).al = false;
		obj10.be(da11);
		cd obj11 = ac;
		da da12 = new da();
		da12.i(u.a().g("STORY_FLYING_PIGS_1"));
		da12.af = 0f;
		da12.ah = num;
		((ck)da12).al = false;
		obj11.be(da12);
		p(ac);
	}

	public override void f()
	{
		base.f();
		ae = false;
	}

	public override void g(GameTime A_0)
	{
		base.g(A_0);
		if (a8().ba() && ad != null)
		{
			if (!ae)
			{
				ad();
			}
			return;
		}
		ac.d(A_0);
		if (bc() != 0)
		{
			return;
		}
		y -= A_0.ElapsedGameTime.Milliseconds;
		switch (ar)
		{
		case cm.CutScenePhase.b:
			if (y < 0f)
			{
				y = 0f;
				x = ab / 6f;
				ar = cm.CutScenePhase.c;
			}
			break;
		case cm.CutScenePhase.c:
		{
			float num = (float)A_0.ElapsedGameTime.Milliseconds / 1000f;
			((ck)ac).ak = ((ck)ac).ak + num * x;
			if (((ck)ac).ak >= ab)
			{
				((ck)ac).ak = ab;
				ar++;
				y = 5000f;
			}
			break;
		}
		case (cm.CutScenePhase)3:
			if (y < 0f)
			{
				ar = cm.CutScenePhase.d;
				y = 0f;
			}
			break;
		case cm.CutScenePhase.d:
			au();
			break;
		}
	}

	public override void h(GameTime A_0)
	{
		a8().f(A_0: false);
		b0.d().k(A_0: true);
		cw cw2 = b0.d().d("birds_intro");
		cw2.y(1f);
		cw2.ac();
		ar = cm.CutScenePhase.b;
		y = 4500f;
		((ck)ac).aj = 0f;
		((ck)ac).ak = 0f;
		@as = d.p().aa()["episode3"];
		((ck)ac).al = @as;
		SetMenuState(global::m.MenuState.a);
	}

	public override void b(GameTime A_0)
	{
		b0.d().k(A_0: true);
		SetMenuState(global::m.MenuState.b);
	}

	private void a(ck A_0)
	{
		a8().f(A_0: true);
		ae = true;
		ad = au;
		b0.d().k(A_0: true);
	}

	public void au()
	{
		ad = null;
		d.p().aa()["episode3"] = true;
		SetMenuState(global::m.MenuState.d);
		av()();
	}
}
