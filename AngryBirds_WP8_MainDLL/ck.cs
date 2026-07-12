using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

internal class ck
{
	public delegate void ClickHandler(ck A_0);

	protected bool m_visibleFlag;

	protected bool m_enabledFlag = true;

	protected float m_anchorX;

	protected float m_anchorY;

	[CompilerGenerated]
	private ClickHandler m_ac;

	[CompilerGenerated]
	private string m_ad;

	[CompilerGenerated]
	private cw m_ae;

	[CompilerGenerated]
	private r m_af;

	[CompilerGenerated]
	private bool m_ah;

	[CompilerGenerated]
	private a7 m_aj;

	[CompilerGenerated]
	private int m_ak;

	[CompilerGenerated]
	private float m_al;

	[CompilerGenerated]
	private float m_am;

	public ClickHandler y
	{
		[CompilerGenerated]
		get
		{
			return this.m_ac;
		}
		[CompilerGenerated]
		set
		{
			this.m_ac = value;
		}
	}

	public string z
	{
		[CompilerGenerated]
		get
		{
			return this.m_ad;
		}
		[CompilerGenerated]
		set
		{
			this.m_ad = value;
		}
	}

	public cw aa
	{
		[CompilerGenerated]
		get
		{
			return this.m_ae;
		}
		[CompilerGenerated]
		set
		{
			this.m_ae = value;
		}
	}

	public r ab
	{
		[CompilerGenerated]
		get
		{
			return this.m_af;
		}
		[CompilerGenerated]
		set
		{
			this.m_af = value;
		}
	}

	public bool ac
	{
		[CompilerGenerated]
		get
		{
			return this.m_ah;
		}
		[CompilerGenerated]
		set
		{
			this.m_ah = value;
		}
	}

	public a7 ad
	{
		[CompilerGenerated]
		get
		{
			return this.m_aj;
		}
		[CompilerGenerated]
		set
		{
			this.m_aj = value;
		}
	}

	public int ae
	{
		[CompilerGenerated]
		get
		{
			return this.m_ak;
		}
		[CompilerGenerated]
		set
		{
			this.m_ak = value;
		}
	}

	public float af
	{
		[CompilerGenerated]
		get
		{
			return this.m_al;
		}
		[CompilerGenerated]
		set
		{
			this.m_al = value;
		}
	}

	public float ah
	{
		[CompilerGenerated]
		get
		{
			return this.m_am;
		}
		[CompilerGenerated]
		set
		{
			this.m_am = value;
		}
	}

	public virtual float aj
	{
		get
		{
			return this.m_anchorX;
		}
		set
		{
			this.m_anchorX = value;
		}
	}

	public virtual float ak
	{
		get
		{
			return this.m_anchorY;
		}
		set
		{
			this.m_anchorY = value;
		}
	}

	public virtual bool al
	{
		get
		{
			return this.m_visibleFlag;
		}
		set
		{
			this.m_visibleFlag = value;
		}
	}

	public virtual bool am
	{
		get
		{
			return this.m_enabledFlag;
		}
		set
		{
			this.m_enabledFlag = value;
		}
	}

	public void bg(ck A_0)
	{
		if (A_0.aa != null)
		{
			A_0.aa.ac();
		}
		y(A_0);
	}

	public ck()
	{
		af = 0f;
		ah = 0f;
		z = null;
		ab = null;
		ac = true;
		aa = null;
		ad = new a7(bn.b, dh.b);
		y = null;
	}

	public virtual bool Hit(Vector2 A_0)
	{
		return Hit((int)A_0.X, (int)A_0.Y);
	}

	public virtual bool Hit(int A_0, int A_1)
	{
		if (ab != null && A_0 >= ab.f() && A_0 <= ab.h() && A_1 >= ab.g())
		{
			return A_1 <= ab.e();
		}
		return false;
	}

	public virtual void i()
	{
	}

	public virtual void d(GameTime A_0)
	{
	}
}
