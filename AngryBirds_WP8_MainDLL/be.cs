using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;

internal class be : cw
{
	private Dictionary<string, cw> a;

	private cw b;

	private bool c;

	private float d;

	private float e;

	private float m_f;

	private bool m_g;

	public be(string[] A_0)
	{
		a = new Dictionary<string, cw>();
		for (int num = 0; num < A_0.Length; num++)
		{
			cw value = b0.d().d(A_0[num]);
			a.Add(A_0[num], value);
		}
		this.m_g = false;
		c = false;
		d = 0f;
		e = 0f;
		this.m_f = 1f;
	}

	public string f()
	{
		if (a.Count == 0)
		{
			return "";
		}
		return Enumerable.ElementAt<string>((IEnumerable<string>)a.Keys, b9.a(0, a.Keys.Count - 1));
	}

	public cw g()
	{
		if (a.Count == 0)
		{
			return null;
		}
		string key = f();
		return a[key];
	}

	[SpecialName]
	public bool q()
	{
		if (b != null)
		{
			return b.q();
		}
		return c;
	}

	[SpecialName]
	public void r(bool A_0)
	{
		if (b != null && !this.m_g)
		{
			b.r(A_0);
			c = A_0;
		}
	}

	[SpecialName]
	public float s()
	{
		if (b != null)
		{
			return b.s();
		}
		return d;
	}

	[SpecialName]
	public void t(float A_0)
	{
		if (b != null)
		{
			b.t(A_0);
		}
		d = A_0;
	}

	[SpecialName]
	public float u()
	{
		if (b != null)
		{
			return b.u();
		}
		return e;
	}

	[SpecialName]
	public void v(float A_0)
	{
		if (b != null)
		{
			b.v(A_0);
		}
		e = A_0;
	}

	[SpecialName]
	public SoundState w()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		if (b != null)
		{
			return b.w();
		}
		return (SoundState)2;
	}

	[SpecialName]
	public float x()
	{
		if (b != null)
		{
			return b.x();
		}
		return this.m_f;
	}

	[SpecialName]
	public void y(float A_0)
	{
		if (b != null)
		{
			b.y(MathHelper.Clamp(A_0, 0f, 1f));
		}
		this.m_f = A_0;
	}

	public void z(AudioListener A_0, AudioEmitter A_1)
	{
		b.z(A_0, A_1);
	}

	public void aa(AudioListener[] A_0, AudioEmitter A_1)
	{
		b.aa(A_0, A_1);
	}

	public void ab()
	{
		b.ab();
	}

	public void ac()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Invalid comparison between Unknown and I4
		if (b != null && (int)b.w() != 2)
		{
			b.af(A_0: false);
		}
		b = g();
		b.t(d);
		b.v(e);
		b.y(this.m_f);
		b.ac();
		this.m_g = true;
	}

	public void ad()
	{
		b.ad();
	}

	public void ae()
	{
		b.ae();
	}

	public void af(bool A_0)
	{
		b.af(A_0);
	}
}
