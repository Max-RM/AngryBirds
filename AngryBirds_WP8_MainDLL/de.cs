using Microsoft.Xna.Framework;

internal class de : c
{
	private new int au;

	public de(int A_0)
	{
		au = A_0;
	}

	public override void e()
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		base.e();
		if (au < dc.h.Length)
		{
			u u2 = u.a();
			p(dc.h[au]);
			SetMenuState(global::m.MenuState.b);
			f(A_0: false);
			au("goldenEggs");
			SetLayout(new y());
			a3().an();
			a3().g(dc.j);
			a3().i(A_0: true);
			p(new ck
			{
				ab = new r(0, 0, 800, 480),
				al = true,
				am = false,
				y = base.av
			});
			ae ae2 = u2.g("GOLDEN_EGG_PUZZLED_BIRD");
			if (ae2 != null)
			{
				ae b1 = u2.g("GOLDEN_EGG_BUBBLE_1");
				if (b1 != null)
				{
					da da2 = new da();
					da2.i(b1);
					da2.af = (int)(800f - 3.5f * (float)ae2.c) + b1.c / 2 - 35;
					da2.ah = (int)(480f - 1.5f * (float)ae2.d);
					da2.am = true;
					p(da2);
				}
				ae b2 = u2.g("GOLDEN_EGG_BUBBLE_2");
				if (b2 != null)
				{
					da da3 = new da();
					da3.i(b2);
					da3.af = (int)(800f - 2f * (float)ae2.c);
					da3.ah = (int)(480f - 1f * (float)ae2.d);
					da3.am = true;
					p(da3);
				}
				ae b3 = u2.g("GOLDEN_EGG_BUBBLE_3");
				if (b3 != null)
				{
					da da4 = new da();
					da4.i(b3);
					da4.af = (int)(800f - 1.5f * (float)ae2.c);
					da4.ah = (int)(480f - 0.75f * (float)ae2.d);
					da4.am = true;
					p(da4);
				}
				ae b4 = u2.g(bd());
				if (b4 != null)
				{
					da da5 = new da();
					da5.i(b4);
					da5.af = (int)(800f - 3.5f * (float)ae2.c);
					da5.ah = (int)(480f - 1.5f * (float)ae2.d);
					da5.am = true;
					p(da5);
				}
			}
			da da6 = new da();
			da6.i(u2.g("LS_BACK_BUTTON"));
			da6.af = 0f;
			da6.ah = 480f;
			da6.am = true;
			((ck)da6).al = true;
			da6.y = a9().c;
			da6.z = "episodeSelectionPage";
			da6.aa = u2.f("menu_back");
			p(da6);
		}
	}

	public override void h(GameTime A_0)
	{
		if (!a3().o())
		{
			SetMenuState(global::m.MenuState.a);
		}
	}

	public override void b(GameTime A_0)
	{
		if (!a3().m())
		{
			SetMenuState(global::m.MenuState.b);
		}
	}

	public override void f()
	{
		base.f();
	}

	public override void g(GameTime A_0)
	{
		base.g(A_0);
	}
}
