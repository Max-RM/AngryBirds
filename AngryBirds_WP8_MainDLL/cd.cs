using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AngryBirds;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input.Touch;

internal class cd : ck
{
	private List<ck> t = new List<ck>();

	[SpecialName]
	public List<ck> bw()
	{
		return t;
	}

	public override float aj
	{
		get
		{
			return base.aj;
		}
		set
		{
			base.aj = value;
			PropagateXToChildren(value);
		}
	}

	public override float ak
	{
		get
		{
			return base.ak;
		}
		set
		{
			base.ak = value;
			for (int num = 0; num < t.Count; num++)
			{
				t[num].ak = value;
			}
		}
	}

	private void PropagateXToChildren(float value)
	{
		for (int num = 0; num < t.Count; num++)
		{
			if (t[num] is cd cd2)
			{
				cd2.PropagateXToChildren(value);
			}
			else
			{
				t[num].aj = value;
			}
		}
	}

	[SpecialName]
	public virtual float ag()
	{
		return base.aj;
	}

	[SpecialName]
	public virtual void SetGroupY(float A_0)
	{
		base.aj = A_0;
		PropagateXToChildren(A_0);
	}

	[SpecialName]
	public virtual float ai()
	{
		return base.ak;
	}

	[SpecialName]
	public virtual void SetGroupY2(float A_0)
	{
		ak = A_0;
	}

	public cd()
	{
		base.y = i;
		((ck)this).al = true;
	}

	private void i(ck A_0)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		Vector2 position = default(Vector2);
		position = new Vector2(float.MinValue);
		Controls instance = Controls.GetInstance();
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
		for (int num = 0; num < t.Count; num++)
		{
			ck ck2 = t[num];
			if (ck2.al && ck2.Hit((int)position.X, (int)position.Y) && (ck2.ac || !instance.IsDoubleTapped))
			{
				ck2.bg(ck2);
				break;
			}
		}
	}

	public virtual void be(ck A_0)
	{
		t.Add(A_0);
		A_0.aj = base.aj;
		A_0.ak = ak;
	}

	public virtual void bf(ck A_0)
	{
		t.Remove(A_0);
	}

	public new virtual void am(ck A_0, ck A_1)
	{
		t.Insert(t.IndexOf(A_0), A_1);
		bf(A_0);
	}

	public virtual void bv()
	{
		t.Clear();
	}

	public override bool Hit(Vector2 A_0)
	{
		return Hit((int)A_0.X, (int)A_0.Y);
	}

	public override bool Hit(int A_0, int A_1)
	{
		int count = t.Count;
		for (int num = 0; num < count; num++)
		{
			if (t[num].Hit(A_0, A_1))
			{
				return true;
			}
		}
		return false;
	}

	public override void i()
	{
		int count = t.Count;
		for (int num = 0; num < count; num++)
		{
			if (t[num].am)
			{
				t[num].i();
			}
		}
	}

	public override void d(GameTime A_0)
	{
		int count = t.Count;
		for (int num = 0; num < count; num++)
		{
			t[num].d(A_0);
		}
	}
}
