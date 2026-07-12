internal class s
{
	private static s m_a;

	private cw m_b;

	private string m_c;

	private u d;

	public static s a()
	{
		if (s.m_a == null)
		{
			s.m_a = new s();
		}
		return s.m_a;
	}

	private s()
	{
		d = u.a();
	}

	public void a(string A_0)
	{
		a(A_0, A_1: true);
	}

	public void a(string A_0, bool A_1)
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		if (this.m_b == null || (this.m_c != A_0 && A_0 != null))
		{
			cw cw2 = d.b(A_0);
			if (cw2 != null)
			{
				if (this.m_b != null)
				{
					this.m_b.ae();
				}
				this.m_b = cw2;
				this.m_b.r(A_1);
				this.m_c = A_0;
			}
		}
		if (this.m_b != null && (int)this.m_b.w() != 0)
		{
			this.m_b.ac();
		}
	}

	public void b()
	{
		if (this.m_b != null)
		{
			this.m_b.ac();
		}
	}

	public void c()
	{
		if (this.m_b != null)
		{
			this.m_b.ae();
		}
		this.m_b = null;
	}
}
