using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

internal class bq : c
{
	private da ap;

	private da aq;

	private da ar;

	private cr @as;

	private cr at;

	private new u m_au;

	private new bool m_av;

	[CompilerGenerated]
	private bool m_aw;

	[CompilerGenerated]
	private string ax;

	[SpecialName]
	[CompilerGenerated]
	public bool av()
	{
		return this.m_aw;
	}

	[SpecialName]
	[CompilerGenerated]
	public void a(bool A_0)
	{
		this.m_aw = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public string au()
	{
		return ax;
	}

	[SpecialName]
	[CompilerGenerated]
	public void a(string A_0)
	{
		ax = A_0;
	}

	public override void e()
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		base.e();
		this.m_au = u.a();
		p("episodeCompletedPage");
		SetMenuState(global::m.MenuState.b);
		f(A_0: false);
		SetLayout(new y());
		a3().an();
		a3().g(dc.j);
		a3().i(A_0: true);
		float num = -16f * di.d().g();
		da da2 = new da();
		da2.i(this.m_au.g("LEVEL_FINISH_BG"));
		da2.af = 400f;
		da2.ah = 240f + num;
		p(da2);
		cr cr2 = new cr();
		cr2.i((string)null);
		cr2.af = 400f - 133f * di.d().e();
		cr2.ah = (float)((480 - this.m_au.g("LEVEL_FINISH_BG").d) / 2 + 14) + num;
		cr2.ad = new a7(bn.a, dh.b);
		p(at = cr2);
		cr cr3 = new cr();
		cr3.i((string)null);
		cr3.i(A_0: true);
		cr3.i(270f * di.d().e());
		cr3.ad = new a7(bn.a, dh.b);
		p(@as = cr3);
		da da3 = new da();
		da3.i(this.m_au.g("MENU_YES"));
		da3.af = 400f + 80f * di.d().e();
		da3.ah = (float)((240 + this.m_au.g("LEVEL_FINISH_BG").d) / 2 + 121) + num;
		da3.y = a;
		((ck)da3).al = true;
		p(aq = da3);
		da da4 = new da();
		da4.i(this.m_au.g("GOLDEN_EGG_STAR_EFFECT"));
		da4.af = 400f + 84f * di.d().e();
		da4.ah = (float)((240 + this.m_au.g("LEVEL_FINISH_BG").d) / 2 - 135) + num;
		p(ap = da4);
		da da5 = new da();
		da5.i(null);
		p(ar = da5);
	}

	public void aw()
	{
		float num = -16f * di.d().g();
		string a_ = null;
		if (av())
		{
			@as.i(this.m_au.e("TEXT_PERFECT"));
			@as.af = 400f - 127f * di.d().e();
			@as.ah = 240f + 5f * di.d().g();
		}
		else
		{
			@as.i(this.m_au.e("TEXT_COMPLETE"));
			@as.af = 400f - 127f * di.d().e();
			@as.ah = 170f;
		}
		switch (au())
		{
		case "pack1":
		case "pack2":
		case "pack3":
			at.i(this.m_au.e("TEXT_LP_NAME_1"));
			ar.i(av() ? this.m_au.g("REWARD_1_STAR") : this.m_au.g("REWARD_1"));
			ar.af = 400f + 99f * di.d().e();
			ar.ah = (float)((240 + this.m_au.g("LEVEL_FINISH_BG").d) / 2 - 135) + num;
			a_ = "Level4";
			break;
		case "pack4":
		case "pack5":
			at.i(this.m_au.e("TEXT_LP_NAME_2"));
			ar.i(av() ? this.m_au.g("REWARD_2_STAR") : this.m_au.g("REWARD_2"));
			ar.af = 400f + 84f * di.d().e();
			ar.ah = (float)((240 + this.m_au.g("LEVEL_FINISH_BG").d) / 2 - 135) + num;
			a_ = "Level7";
			break;
		case "pack6":
		case "pack7":
		case "pack8":
			at.i(this.m_au.e("TEXT_LP_NAME_3"));
			ar.i(av() ? this.m_au.g("REWARD_3_STAR") : this.m_au.g("REWARD_3"));
			ar.af = 400f + 84f * di.d().e();
			ar.ah = (float)((240 + this.m_au.g("LEVEL_FINISH_BG").d) / 2 - 135) + num;
			a_ = "Level12";
			break;
		case "pack9":
		case "pack10":
		case "pack11":
			at.i(this.m_au.e("TEXT_LP_NAME_4"));
			ar.i(av() ? this.m_au.g("REWARD_4_STAR") : this.m_au.g("REWARD_4"));
			ar.af = 400f + 84f * di.d().e();
			ar.ah = (float)((240 + this.m_au.g("LEVEL_FINISH_BG").d) / 2 - 135) + num;
			a_ = "Level17";
			break;
		case "pack12":
		case "pack13":
		case "pack14":
		case "packFacebook1":
			at.i(this.m_au.e("TEXT_LP_NAME_5"));
			ar.i(av() ? this.m_au.g("REWARD_5_STAR") : this.m_au.g("REWARD_5"));
			ar.af = 400f + 84f * di.d().e();
			ar.ah = (float)((240 + this.m_au.g("LEVEL_FINISH_BG").d) / 2 - 135) + num;
			a_ = "Level21";
			break;
		}
		if (av())
		{
			a(a_, A_1: false, A_2: true);
		}
		s.a().a("level_complete", A_1: false);
	}

	public override void h(GameTime A_0)
	{
		if (!this.m_av)
		{
			this.m_av = true;
		}
		if (!a3().o())
		{
			SetMenuState(global::m.MenuState.a);
		}
	}

	public override void b(GameTime A_0)
	{
		this.m_av = false;
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
		float num = (float)A_0.ElapsedGameTime.Milliseconds * 0.001f;
		da obj = ap;
		obj.ag(obj.bg() + num * ((float)Math.PI / 2f));
		if (ap.bg() > (float)Math.PI * 2f)
		{
			da obj2 = ap;
			obj2.ag(obj2.bg() - (float)Math.PI * 2f);
		}
		base.g(A_0);
	}

	public override void c()
	{
	}

	private void a(ck A_0)
	{
		bf();
	}
}
