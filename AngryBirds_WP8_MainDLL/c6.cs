using Microsoft.Xna.Framework;

internal class c6 : ck
{
	private ae au;

	private ae av;

	public c6()
	{
		au = u.a().g("PLAY_BUTTON_BG");
		av = u.a().i("MENU_PLAY");
	}

	public override void i()
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		Rectangle a_ = default(Rectangle);
		a_ = new Rectangle(0, 0, 20, au.d);
		bu.b().b(au, (int)((double)(800 - av.c) * 0.5) - 20, (int)(240.0 + (double)(17f * di.d().g())), a_, 1f, 1f, 0f);
		Rectangle a_2 = default(Rectangle);
		a_2 = new Rectangle(20, 0, au.c - 40, au.d);
		float num = au.c - 40;
		float a_3 = (float)av.c / num;
		bu.b().b(au, (int)((double)(800 - av.c) * 0.5), (int)(240.0 + (double)(17f * di.d().g())), a_2, a_3, 1f, 0f);
		Rectangle a_4 = default(Rectangle);
		a_4 = new Rectangle(au.c - 20, 0, 20, au.d);
		bu.b().b(au, (int)((double)(800 + av.c) * 0.5), (int)(240.0 + (double)(17f * di.d().g())), a_4, 1f, 1f, 0f);
	}
}
