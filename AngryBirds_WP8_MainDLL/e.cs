using System;
using System.Runtime.CompilerServices;
using AngryBirds;
using Box2D.XNA;
using Microsoft.Xna.Framework;

internal class e : IContactListener, IContactFilter
{
	private cf a;

	[CompilerGenerated]
	private bool m_b;

	[SpecialName]
	[CompilerGenerated]
	public bool b()
	{
		return this.m_b;
	}

	[SpecialName]
	[CompilerGenerated]
	public void b(bool A_0)
	{
		this.m_b = A_0;
	}

	public e(cf A_0)
	{
		a = A_0;
		b(A_0: false);
	}

	public virtual void BeginContact(Contact contact)
	{
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		if (!b())
		{
			return;
		}
		Body body = contact.i.e;
		Body body2 = contact.j.e;
		cf.d d2 = (cf.d)body.GetUserData();
		cf.d d3 = (cf.d)body2.GetUserData();
		ct ct2 = d2.c;
		ct ct3 = d3.c;
		float num = 10f;
		if (ct2.p.h == BlockGroup.BIRDS && ct3.p.h == BlockGroup.BIRDS)
		{
			float num2 = 0f;
			Vector2 linearVelocity = body.GetLinearVelocity();
			float num3 = linearVelocity.LengthSquared();
			Vector2 linearVelocity2 = body2.GetLinearVelocity();
			if (num3 > linearVelocity2.LengthSquared())
			{
				float mass = body.GetMass();
				Vector2 linearVelocity3 = body.GetLinearVelocity();
				num2 = mass * linearVelocity3.Length() / num;
			}
			else
			{
				float mass2 = body2.GetMass();
				Vector2 linearVelocity4 = body2.GetLinearVelocity();
				num2 = mass2 * linearVelocity4.Length() / num;
			}
			b(ct2, ct3, num2, 0f);
		}
		else if (ct2.p.h == BlockGroup.BIRDS || ct3.p.h == BlockGroup.BIRDS)
		{
			float num4 = 1f;
			float num5 = 1f;
			bool flag = false;
			ct ct4;
			cn cn2;
			Body body3;
			ct ct5;
			cb cb2;
			if (ct2.p.h == BlockGroup.BIRDS)
			{
				ct4 = ct2;
				cn2 = (cn)ct2.p;
				body3 = body;
				ct5 = ct3;
				cb2 = ct3.p;
			}
			else
			{
				ct4 = ct3;
				cn2 = (cn)ct3.p;
				body3 = body2;
				ct5 = ct2;
				cb2 = ct2.p;
			}
			_ = cn2.g;
			cv cv2 = cb2.g;
			a9 a10 = cn2.ao;
			num4 = a10.c(cv2.a);
			num5 = a10.d(cv2.a);
			flag = cn2.aq;
			float mass3 = body3.GetMass();
			Vector2 linearVelocity5 = body3.GetLinearVelocity();
			float num6 = mass3 * linearVelocity5.Length() / num;
			float num7 = 0f;
			num6 *= num4;
			float num8 = cb2.x;
			num7 = num6 - num8;
			if (num7 > 0f)
			{
				float num9 = ct5.f;
				float num10 = (ct5.f = num9 - num7);
				if (num10 < 0f)
				{
					if (flag)
					{
						float num11 = (0f - num10) / body3.GetMass() / num6 * num * 1.75f;
						if (num11 > 1f)
						{
							num11 = 1f;
						}
						Vector2 linearVelocity6 = body3.GetLinearVelocity() * num11;
						body3.SetLinearVelocity(linearVelocity6);
					}
					else
					{
						float num12 = (num6 - num9) / num6;
						num12 *= num5;
						if (num12 > 1f)
						{
							num12 = 1f;
						}
						ct4.i = body3.GetLinearVelocity() * num12;
						ct4.h = true;
					}
					num7 = num9;
					contact.SetEnabled(flag: false);
				}
			}
			b(ct2, ct3, num6, (float)Math.Floor(num7));
		}
		else
		{
			bool flag2 = false;
			Vector2 val = body.GetMass() * body.GetLinearVelocity() - body2.GetMass() * body2.GetLinearVelocity();
			float num13 = val.Length() / 10f;
			float num14 = a.at().b;
			float num15 = 0f;
			bool flag3 = true;
			float num16 = ct2.p.x;
			if (num13 < num16)
			{
				flag3 = false;
			}
			if (flag3)
			{
				float num17 = ct2.f;
				num15 = ((!((ct2.f = num17 - (num13 - num16)) < 0f)) ? (num15 + (num13 - num16)) : (num15 + num17));
			}
			flag2 = flag3;
			flag3 = true;
			num16 = ct3.p.x;
			if (num13 < num16)
			{
				flag3 = false;
			}
			if (flag3)
			{
				float num18 = ct3.f;
				num15 = ((!((ct3.f = num18 - (num13 - num16)) < 0f)) ? (num15 + (num13 - num16)) : (num15 + num18));
			}
			flag2 = flag2 || flag3;
			b(ct2, ct3, num13, flag2);
			if (num15 > 0f)
			{
				a.at().b = (int)((double)num14 + Math.Floor(num15) * 10.0);
			}
		}
	}

	public virtual void EndContact(Contact contact)
	{
		b();
	}

	public void PreSolve(Contact contact, ref Manifold oldManifold)
	{
		b();
	}

	public void PostSolve(Contact contact, ref ContactImpulse impulse)
	{
		b();
	}

	public bool ShouldCollide(Fixture fixtureA, Fixture fixtureB)
	{
		bool flag = true;
		cf.d d2 = (cf.d)fixtureA.e.GetUserData();
		cf.d d3 = (cf.d)fixtureB.e.GetUserData();
		if (d2 != null)
		{
			flag &= d2.b;
		}
		if (d3 != null)
		{
			flag &= d3.b;
		}
		return flag;
	}

	private void b(ct A_0, ct A_1, float A_2, float A_3)
	{
		cy cy2 = null;
		cy cy3 = null;
		if (A_0.p.h == BlockGroup.BIRDS)
		{
			cy2 = (cy)A_0;
		}
		if (A_1.p.h == BlockGroup.BIRDS)
		{
			cy3 = (cy)A_1;
		}
		if (cy2 != null && A_3 > 0f)
		{
			int num = (int)A_3 * 10;
			a.bc().a(cy2.c, cy2.d, num.ToString(), 0f, 0.6f, 0.25f + (float)num / 3000f, 0f);
			a.at().a += num;
		}
		if (cy3 != null && A_3 > 0f)
		{
			int num2 = (int)A_3 * 10;
			a.bc().a(cy3.c, cy3.d, num2.ToString(), 0f, 0.6f, 0.25f + (float)num2 / 3000f, 0f);
			a.at().a += num2;
		}
		if (cy2 != null && !a.v(cy2))
		{
			cy2.k(A_1, A_2, A_3);
		}
		if (cy3 != null && !a.v(cy3))
		{
			cy3.k(A_0, A_2, A_3);
		}
	}

	private void b(ct A_0, ct A_1, float A_2, bool A_3)
	{
		if (A_3)
		{
			A_0.az();
			if (A_0.p.g.j != null)
			{
				A_0.p.g.j.y(0.5f);
				A_0.p.g.j.ac();
			}
			A_1.az();
			if (A_1.p.g.j != null)
			{
				A_1.p.g.j.y(0.5f);
				A_1.p.g.j.ac();
			}
		}
		if (A_2 > 3f)
		{
			if (A_0.p.s != null)
			{
				A_0.p.s.y(0.5f);
				A_0.p.s.ac();
			}
			if (A_1.p.s != null && A_0.p.g.a != A_1.p.g.a)
			{
				A_1.p.s.y(0.5f);
				A_1.p.s.ac();
			}
		}
	}
}
