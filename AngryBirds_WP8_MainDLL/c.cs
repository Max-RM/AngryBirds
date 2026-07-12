using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AngryBirds;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input.Touch;

internal class c : m
{
	private new List<KeyValuePair<string, ck>> b = new List<KeyValuePair<string, ck>>();

	[CompilerGenerated]
	private int d;

	[CompilerGenerated]
	private new int m_g;

	[CompilerGenerated]
	private new int h;

	[CompilerGenerated]
	private int i;

	[CompilerGenerated]
	private new y j;

	[SpecialName]
	[CompilerGenerated]
	public int a5()
	{
		return d;
	}

	[SpecialName]
	[CompilerGenerated]
	public void o(int A_0)
	{
		d = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public int a4()
	{
		return this.m_g;
	}

	[SpecialName]
	[CompilerGenerated]
	public void f(int A_0)
	{
		this.m_g = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	private void SetNavIndex(int A_0)
	{
		h = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	private void SetInnerIndex(int A_0)
	{
		i = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public y a3()
	{
		return j;
	}

	[SpecialName]
	[CompilerGenerated]
	public void SetLayout(y A_0)
	{
		j = A_0;
	}

	public c()
	{
		o(0);
		f(0);
		SetNavIndex(800);
		SetInnerIndex(480);
		SetLayout((y)null);
	}

	public override void e()
	{
	}

	public override void f()
	{
		if (a3() != null)
		{
			a3().aq(a5(), a4());
		}
		for (int num = 0; num < b.Count; num++)
		{
			if (b[num].Value.am)
			{
				b[num].Value.i();
			}
		}
		for (int num2 = 0; num2 < base.j.Count; num2++)
		{
			if (base.j[num2].Value.ba())
			{
				base.j[num2].Value.f();
			}
		}
	}

	public override void g(GameTime A_0)
	{
		base.g(A_0);
		if (a3() != null)
		{
			a3().ap(A_0);
		}
	}

	public override void a()
	{
		List<ck> list = a6();
		if (list != null)
		{
			for (int num = 0; num < list.Count; num++)
			{
				if (list[num].y != null)
				{
					list[num].bg(list[num]);
				}
			}
		}
		if (Controls.GetInstance().IsBackPressed)
		{
			c();
		}
	}

	public void p(ck A_0)
	{
		string a_ = $"Unnamed{l++}";
		a(a_, A_0, null);
	}

	public void a(string A_0, ck A_1)
	{
		a(A_0, A_1, null);
	}

	public void a(string A_0, ck A_1, string A_2)
	{
		if (A_2 == null)
		{
			b.Add(new KeyValuePair<string, ck>(A_0, A_1));
			return;
		}
		if (A_2 == "__FIRST__")
		{
			b.Insert(0, new KeyValuePair<string, ck>(A_0, A_1));
			return;
		}
		int num = a(A_2);
		if (num != -1)
		{
			b.Insert(num, new KeyValuePair<string, ck>(A_0, A_1));
		}
	}

	public ck e(string A_0)
	{
		int num = a(A_0);
		if (num == -1)
		{
			return null;
		}
		return b[num].Value;
	}

	public void f(string A_0)
	{
		int num = a(A_0);
		if (num != -1)
		{
			b.RemoveAt(num);
		}
	}

	private int a(string A_0)
	{
		for (int num = 0; num < b.Count; num++)
		{
			if (b[num].Key == A_0)
			{
				return num;
			}
		}
		return -1;
	}

	public List<ck> a6()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		Controls instance = Controls.GetInstance();
		if (instance.IsTapped || instance.IsDoubleTapped)
		{
			List<ck> list = new List<ck>();
			Vector2 position = default(Vector2);
			position = new Vector2(float.MinValue);
			if (instance.IsTapped)
			{
				GestureSample val = instance.TapGestures[0];
				position = val.Position;
			}
			if (instance.IsDoubleTapped)
			{
				GestureSample val2 = instance.DoubleTapGestures[0];
				position = val2.Position;
			}
			for (int num = 0; num < b.Count; num++)
			{
				KeyValuePair<string, ck> keyValuePair = b[num];
				if (keyValuePair.Value.al && keyValuePair.Value.Hit((int)position.X, (int)position.Y) && (keyValuePair.Value.ac || !instance.IsDoubleTapped))
				{
					list.Add(keyValuePair.Value);
				}
			}
			if (list.Count > 0)
			{
				return list;
			}
		}
		return null;
	}
}
