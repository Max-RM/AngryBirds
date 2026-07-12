using Microsoft.Xna.Framework;

internal class cp : c
{
	private new cr au;

	public override void e()
	{
		base.e();
		u u2 = u.a();
		p("loading");
		SetMenuState(global::m.MenuState.a);
		f(A_0: false);
		cr cr2 = new cr();
		cr2.i(u2.e("MI_LOADING"));
		cr2.af = 400f;
		cr2.ah = 240f;
		((ck)cr2).al = false;
		au = cr2;
		p(au);
	}

	public override void h(GameTime A_0)
	{
		f(A_0: true);
		base.h(A_0);
	}

	public override void b(GameTime A_0)
	{
		f(A_0: false);
		base.b(A_0);
	}

	public override void f()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		bu bu2 = bu.b();
		bu2.b(dc.j);
		bu2.b(0f, 0f, 800f, 480f);
		bu2.b(Color.White);
		base.f();
	}

	public override void g(GameTime A_0)
	{
		base.g(A_0);
	}
}
