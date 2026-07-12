using Microsoft.Xna.Framework;

internal class cj : c
{
	private int ar;

	private float @as;

	private da at;

	private new da au;

	private new u av;

	public override void e()
	{
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		base.e();
		ar = 0;
		@as = 0f;
		p("splashScreen");
		SetMenuState(global::m.MenuState.a);
		av = u.a();
		SetLayout(new y());
		a3().an();
		a3().g(new Color(255, 255, 255, 255));
		p(new ck
		{
			ab = new r(0, 0, 800, 480),
			am = false,
			al = true,
			y = a
		});
		da da2 = new da();
		da2.i(av.g(dc.d[ar]));
		da2.af = 400f;
		da2.ah = 240f;
		da2.am = true;
		da2.z = "mainMenu";
		at = da2;
		p(at);
		da da3 = new da();
		da3.i(av.i("LOADING"));
		da3.af = 795f;
		da3.ah = 475f;
		da3.am = false;
		p(au = da3);
	}

	public override void f()
	{
		base.f();
	}

	public override void g(GameTime A_0)
	{
		float num = (float)A_0.ElapsedGameTime.Milliseconds * 0.001f;
		@as += num;
		if (ar == dc.d.Length)
		{
			ar = 0;
			@as = 0f;
			a9().c((ck)at);
		}
		else if (@as > (float)ar * 2f)
		{
			@as = 0f;
			at.i(av.g(dc.d[ar]));
			switch (ar)
			{
			case 0:
				a1.d();
				break;
			case 1:
				au.am = true;
				a1.h();
				break;
			}
			ar++;
		}
		base.g(A_0);
	}

	private void a(ck A_0)
	{
		@as += 2f;
	}

	public override void o()
	{
		a1.l();
		base.o();
	}

	public override void p()
	{
		a1.e();
		a1.m();
		base.p();
	}
}
