using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;

internal class bg : cw
{
	private static Dictionary<SoundEffect, List<bg>> a = new Dictionary<SoundEffect, List<bg>>(4);

	private SoundEffectInstance b;

	private SoundEffect c;

	private bf d;

	private bool e;

	private bool m_f;

	private float g;

	private float h;

	private float i;

	[SpecialName]
	public bool q()
	{
		if (b != null)
		{
			return b.IsLooped;
		}
		return this.m_f;
	}

	[SpecialName]
	public void r(bool A_0)
	{
		if (b != null && !e)
		{
			b.IsLooped = A_0;
			this.m_f = A_0;
		}
	}

	[SpecialName]
	public float s()
	{
		if (b != null)
		{
			return b.Pan;
		}
		return g;
	}

	[SpecialName]
	public void t(float A_0)
	{
		if (b != null)
		{
			b.Pan = A_0;
		}
		g = A_0;
	}

	[SpecialName]
	public float u()
	{
		if (b != null)
		{
			return b.Pitch;
		}
		return h;
	}

	[SpecialName]
	public void v(float A_0)
	{
		if (b != null)
		{
			b.Pitch = A_0;
		}
		h = A_0;
	}

	[SpecialName]
	public SoundState w()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		if (b != null)
		{
			return b.State;
		}
		return (SoundState)2;
	}

	[SpecialName]
	public float x()
	{
		if (b != null)
		{
			return b.Volume;
		}
		return i;
	}

	[SpecialName]
	public void y(float A_0)
	{
		if (b != null)
		{
			b.Volume = MathHelper.Clamp(A_0, 0f, 1f);
		}
		i = MathHelper.Clamp(A_0, 0f, 1f);
	}

	public bg(SoundEffect A_0, bf A_1)
	{
		if (A_0 == null)
		{
			throw new NullReferenceException("AudioItem: null parameter in ctor");
		}
		if (!a.ContainsKey(A_0))
		{
			a[A_0] = new List<bg>();
		}
		c = A_0;
		d = A_1;
		e = false;
		b = A_0.CreateInstance();
		f();
	}

	public void z(AudioListener A_0, AudioEmitter A_1)
	{
		b.Apply3D(A_0, A_1);
	}

	public void aa(AudioListener[] A_0, AudioEmitter A_1)
	{
		b.Apply3D(A_0, A_1);
	}

	public void ab()
	{
		b.Pause();
	}

	public void ac()
	{
		if ((d == bf.a && b0.d().g()) || (d == bf.b && b0.d().k()))
		{
			return;
		}
		f();
		List<bg> list = a[c];
		if (list.Count < 4)
		{
			if (d == bf.b && !b0.d().h())
			{
				b.Volume = 0f;
				b.Play();
			}
			else
			{
				b.Play();
			}
			list.Add(this);
			e = true;
		}
	}

	public void ad()
	{
		b.Resume();
	}

	public void ae()
	{
		b.Stop();
		a[c].Remove(this);
	}

	public void af(bool A_0)
	{
		b.Stop(A_0);
		a[c].Remove(this);
	}

	public void f()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Invalid comparison between Unknown and I4
		List<bg> list = a[c];
		if (list.Count < 4)
		{
			return;
		}
		for (int num = list.Count - 1; num >= 0; num--)
		{
			bg bg2 = list[num];
			if ((int)bg2.w() == 2)
			{
				list.RemoveAt(num);
				num--;
			}
		}
	}
}
