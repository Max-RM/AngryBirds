using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Box2D.XNA;
using Innogiant;
using Microsoft.Xna.Framework;

internal class ah : cy
{
	private int a;

	private new int b;

	private new cy c;

	private new List<ah> d;

	[SpecialName]
	public int GetChildCount()
	{
		return a;
	}

	public override object j()
	{
		ah ah2 = (ah)base.j();
		ah2.a = a;
		ah2.b = b;
		ah2.c = c;
		ah2.d = new List<ah>(a);
		for (int num = 0; num < a; num++)
		{
			ah2.d.Add((ah)d[num].j());
		}
		return ah2;
	}

	public ah(LuaVariable A_0, cf A_1, cy A_2)
		: base(A_0, A_1)
	{
		b = 0;
		if (A_2 == null)
		{
			a = 2;
			d = new List<ah>(a);
			for (int num = 0; num < a; num++)
			{
				d.Add(new ah(A_0, A_1, this));
				d[num].q = q + num;
			}
			b = 2;
		}
		if (A_2 != null)
		{
			c = A_2;
			ai(A_0: false);
			j(A_0: false);
			l(A_0: true);
			b = 1;
		}
	}

	public override void k(ct A_0, float A_1, float A_2)
	{
		bool flag = false;
		if (A_0 is ah)
		{
			if ((d == null || !j((ah)A_0)) && A_0 != c)
			{
				flag = true;
			}
			else
			{
				if (b <= 0)
				{
					flag = true;
				}
				b--;
			}
		}
		else
		{
			flag = true;
		}
		if (flag)
		{
			base.k(A_0, A_1, A_2);
			ai(A_0: false);
			j(A_0: false);
		}
	}

	public override void l()
	{
		if (au())
		{
			if (@as().ah != null)
			{
				@as().ah.ac();
			}
			ai(A_0: true);
		}
	}

	public override void m(float A_0)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		base.m(A_0);
		if (at() && !ai())
		{
			w.a(new Vector2(base.c, base.d));
			for (int num = 0; num < a; num++)
			{
				j(num);
				v.w((ct)d[num]);
				v.aj().Add(d[num]);
			}
			ai(A_0: false);
			j(A_0: false);
		}
	}

	public override void n()
	{
		base.n();
		if (d != null)
		{
			for (int num = 0; num < d.Count; num++)
			{
				d[num].n();
			}
		}
	}

	private void j(int A_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		Vector2 linearVelocity = o.GetLinearVelocity();
		Vector2 val = default(Vector2);
		val = new Vector2(linearVelocity.Y, 0f - linearVelocity.X);
		val.Normalize();
		BodyDef bodyDef = new BodyDef();
		switch (A_0)
		{
		case 0:
			bodyDef.position = o.d.Position - val;
			break;
		case 1:
			bodyDef.position = o.d.Position + val;
			break;
		}
		bodyDef.angle = o.e.a;
		bodyDef.type = BodyType.Dynamic;
		bodyDef.angularDamping = o.GetAngularDamping();
		bodyDef.bullet = true;
		bodyDef.awake = true;
		Body body = o.GetWorld().CreateBody(bodyDef);
		d[A_0].o = body;
		CircleShape circleShape = new CircleShape();
		circleShape._radius = base.b;
		FixtureDef fixtureDef = new FixtureDef();
		fixtureDef.density = @as().t;
		fixtureDef.friction = @as().u;
		fixtureDef.restitution = @as().v;
		fixtureDef.shape = circleShape;
		body.CreateFixture(fixtureDef);
		cf.d d2 = new cf.d();
		d2.a = d[A_0].q;
		d2.b = @as().k;
		d2.c = d[A_0];
		d[A_0].o.SetUserData(d2);
		switch (A_0)
		{
		case 0:
			body.SetLinearVelocity(linearVelocity - val * 7f);
			break;
		case 1:
			body.SetLinearVelocity(linearVelocity + val * 7f);
			break;
		}
		d[A_0].az();
		d[A_0].j(A_0: false);
		d[A_0].ai(A_0: false);
	}

	public bool ai()
	{
		if (a != 0)
		{
			return false;
		}
		return true;
	}

	public bool j(ah A_0)
	{
		for (int num = 0; num < d.Count; num++)
		{
			if (d[num] == A_0)
			{
				return true;
			}
		}
		return false;
	}
}
