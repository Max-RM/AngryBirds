using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Media;

internal class b0
{
	private delegate void a(float A_0);

	private static b0 m_a;

	private Dictionary<string, SoundEffect> b;

	private Dictionary<string, SoundEffect> c;

	private Dictionary<SoundEffect, List<cw>> m_d;

	private Dictionary<SoundEffect, List<cw>> m_e;

	private float m_f;

	private float m_g;

	private float m_h;

	private bool m_i;

	private int m_j;

	private int m_k;

	private a m_l;

	private bool m_m;

	private bool m_n;

	[CompilerGenerated]
	private bool m_o;

	[CompilerGenerated]
	private bool m_p;

	[CompilerGenerated]
	private bool m_q;

	[CompilerGenerated]
	private bool m_r;

	[CompilerGenerated]
	private bool s;

	[SpecialName]
	[CompilerGenerated]
	public bool g()
	{
		return this.m_o;
	}

	[SpecialName]
	[CompilerGenerated]
	private void h(bool A_0)
	{
		this.m_o = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public bool k()
	{
		return this.m_p;
	}

	[SpecialName]
	[CompilerGenerated]
	private void g(bool A_0)
	{
		this.m_p = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public bool q()
	{
		return this.m_q;
	}

	[SpecialName]
	[CompilerGenerated]
	private void f(bool A_0)
	{
		this.m_q = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	private void e(bool A_0)
	{
		this.m_r = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	private void d(bool A_0)
	{
		s = A_0;
	}

	public static b0 d()
	{
		if (b0.m_a == null)
		{
			b0.m_a = new b0();
		}
		return b0.m_a;
	}

	private b0()
	{
		b = new Dictionary<string, SoundEffect>();
		c = new Dictionary<string, SoundEffect>();
		this.m_d = new Dictionary<SoundEffect, List<cw>>();
		this.m_e = new Dictionary<SoundEffect, List<cw>>();
		this.m_f = SoundEffect.MasterVolume;
		this.m_h = 1f;
		this.m_g = 1f;
		g(A_0: false);
		h(A_0: false);
		this.m_m = false;
		f(A_0: false);
	}

	public bool h()
	{
		return MediaPlayer.GameHasControl;
	}

	public void d(GameTime A_0, bool A_1)
	{
		bool gameHasControl = MediaPlayer.GameHasControl;
		if (!A_1 && this.m_n != gameHasControl)
		{
			if (gameHasControl)
			{
				i();
				global::s.a().b();
			}
			else
			{
				l();
			}
		}
		this.m_n = gameHasControl;
		if (this.m_i)
		{
			this.m_j += A_0.ElapsedGameTime.Milliseconds / 10;
			if (this.m_j < this.m_k)
			{
				this.m_l((float)this.m_j / (float)this.m_k);
				return;
			}
			this.m_l(1f);
			this.m_i = false;
			this.m_j = 0;
			this.m_k = 0;
		}
	}

	public cw e(string A_0, string A_1)
	{
		if (b.ContainsKey(A_1))
		{
			SoundEffect val = b[A_1];
			cw cw2 = new bg(val, bf.a);
			cw2.y(this.m_g);
			this.m_d[val].Add(cw2);
			return cw2;
		}
		SoundEffect val2 = u.a().d(u.a(A_0, global::h.a));
		val2.Name = A_1;
		cw cw3 = new bg(val2, bf.a);
		cw3.y(this.m_g);
		b.Add(A_1, val2);
		List<cw> list = new List<cw>();
		list.Add(cw3);
		this.m_d[val2] = list;
		return cw3;
	}

	public cw d(string A_0, string A_1)
	{
		if (c.ContainsKey(A_1))
		{
			SoundEffect val = c[A_1];
			cw cw2 = new bg(val, bf.b);
			cw2.y(this.m_h);
			this.m_e[val].Add(cw2);
			return cw2;
		}
		SoundEffect val2 = u.a().d(u.a(A_0, global::h.b));
		val2.Name = A_1;
		cw cw3 = new bg(val2, bf.b);
		cw3.y(this.m_h);
		c.Add(A_1, val2);
		List<cw> list = new List<cw>();
		list.Add(cw3);
		this.m_e[val2] = list;
		return cw3;
	}

	public cw d(string A_0)
	{
		if (A_0 == null)
		{
			return null;
		}
		if (b.ContainsKey(A_0))
		{
			SoundEffect val = b[A_0];
			cw cw2 = new bg(val, bf.a);
			cw2.y(this.m_g);
			this.m_d[val].Add(cw2);
			return cw2;
		}
		return di.d().h(A_0);
	}

	public cw e(string A_0)
	{
		if (A_0 == null)
		{
			return null;
		}
		if (c.ContainsKey(A_0))
		{
			SoundEffect val = c[A_0];
			cw cw2 = new bg(val, bf.b);
			cw2.y(this.m_h);
			this.m_e[val].Add(cw2);
			return cw2;
		}
		return di.d().h(A_0);
	}

	public void d(cw A_0)
	{
		foreach (KeyValuePair<SoundEffect, List<cw>> item in this.m_e)
		{
			item.Value.Remove(A_0);
		}
	}

	public void h(float A_0)
	{
		this.m_h = A_0;
		foreach (KeyValuePair<SoundEffect, List<cw>> item in this.m_e)
		{
			for (int num = 0; num < item.Value.Count; num++)
			{
				item.Value[num].y(this.m_h);
			}
		}
	}

	public bool p()
	{
		return this.m_m;
	}

	public void l()
	{
		foreach (KeyValuePair<SoundEffect, List<cw>> item in this.m_e)
		{
			for (int num = 0; num < item.Value.Count; num++)
			{
				item.Value[num].y(0f);
			}
		}
		g(A_0: true);
	}

	public void e()
	{
		f(0f);
	}

	public void f(float A_0)
	{
		A_0 = 0f;
		if (A_0 <= 0f)
		{
			this.m_f = SoundEffect.MasterVolume;
			SoundEffect.MasterVolume = 0f;
			this.m_m = true;
			this.m_i = false;
		}
		else
		{
			this.m_l = e;
			this.m_k = (int)(A_0 * 100f);
			this.m_j = 0;
			this.m_i = true;
		}
	}

	public void i()
	{
		g(A_0: false);
		h(this.m_h);
	}

	public void g(float A_0)
	{
		A_0 = 0f;
		if (A_0 <= 0f)
		{
			SoundEffect.MasterVolume = this.m_f;
			this.m_m = false;
			this.m_i = false;
		}
		else
		{
			this.m_k = (int)(A_0 * 100f);
			this.m_j = 0;
			this.m_i = true;
			this.m_l = d;
		}
	}

	public void j(bool A_0)
	{
		foreach (KeyValuePair<SoundEffect, List<cw>> item in this.m_d)
		{
			for (int num = 0; num < item.Value.Count; num++)
			{
				item.Value[num].af(A_0);
			}
		}
	}

	public void i(bool A_0)
	{
		global::s.a().c();
		foreach (KeyValuePair<SoundEffect, List<cw>> item in this.m_e)
		{
			for (int num = 0; num < item.Value.Count; num++)
			{
				item.Value[num].af(A_0);
			}
		}
	}

	public void k(bool A_0)
	{
		j(A_0);
		i(A_0);
	}

	public void m()
	{
		if (!q())
		{
			j();
			n();
			f(A_0: true);
		}
	}

	public void o()
	{
		if (q())
		{
			r();
			f();
			f(A_0: false);
		}
	}

	public void j()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		foreach (KeyValuePair<SoundEffect, List<cw>> item in this.m_d)
		{
			for (int num = 0; num < item.Value.Count; num++)
			{
				if ((int)item.Value[num].w() == 0)
				{
					item.Value[num].ab();
				}
			}
		}
		d(A_0: true);
	}

	public void n()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		foreach (KeyValuePair<SoundEffect, List<cw>> item in this.m_e)
		{
			for (int num = 0; num < item.Value.Count; num++)
			{
				if ((int)item.Value[num].w() == 0)
				{
					item.Value[num].ab();
				}
			}
		}
		e(A_0: true);
	}

	public void r()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Invalid comparison between Unknown and I4
		foreach (KeyValuePair<SoundEffect, List<cw>> item in this.m_d)
		{
			for (int num = 0; num < item.Value.Count; num++)
			{
				if ((int)item.Value[num].w() == 1)
				{
					item.Value[num].ad();
				}
			}
		}
		d(A_0: false);
	}

	public void f()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Invalid comparison between Unknown and I4
		foreach (KeyValuePair<SoundEffect, List<cw>> item in this.m_e)
		{
			for (int num = 0; num < item.Value.Count; num++)
			{
				if ((int)item.Value[num].w() == 1)
				{
					item.Value[num].ad();
				}
			}
		}
		e(A_0: false);
	}

	private void e(float A_0)
	{
		SoundEffect.MasterVolume = 1f - A_0;
		if (A_0 == 1f)
		{
			this.m_m = true;
		}
	}

	private void d(float A_0)
	{
		SoundEffect.MasterVolume = A_0;
		if (A_0 == 1f)
		{
			this.m_m = false;
		}
	}
}
