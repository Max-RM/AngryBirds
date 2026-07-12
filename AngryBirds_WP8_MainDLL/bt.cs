using Box2D.XNA;
using Innogiant;
using Microsoft.Xna.Framework;

internal class bt : cy
{
	private new b7 b;

	private new ae c;

	private new bool d;

	private new BodyDef e = new BodyDef();

	private new CircleShape f = new CircleShape();

	private new FixtureDef g = new FixtureDef();

	private new cf.d h = new cf.d();

	public override object j()
	{
		bt bt2 = (bt)base.j();
		bt2.b = (b7)b.j();
		bt2.c = c;
		bt2.d = d;
		bt2.e = e;
		bt2.f = f;
		bt2.g = g;
		bt2.h = new cf.d();
		bt2.h.a = b.q;
		bt2.h.b = @as().k;
		bt2.h.c = b;
		return bt2;
	}

	public bt(LuaVariable A_0, cf A_1)
		: base(A_0, A_1)
	{
		cb a_ = di.d().q("EggGranade");
		b = new b7(q + "_egg", a_, A_1);
		c = global::u.a().g("BIRD_GREEN_SPECIAL");
		d = false;
	}

	public override void k(ct A_0, float A_1, float A_2)
	{
		base.k(A_0, A_1, A_2);
		ai(A_0: false);
		j(A_0: false);
	}

	public override void l()
	{
		if (au())
		{
			j(A_0: false);
			ai(A_0: true);
		}
	}

	public override void m(float A_0)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		base.m(A_0);
		if (at())
		{
			w.a(new Vector2(base.c, base.d));
			ah();
			v.w((ct)b);
			v.an().a8 = b;
			v.u((cy)b);
			Vector2 impulse = default(Vector2);
			impulse = new Vector2(-925f * o.GetMass());
			impulse.X *= -0.04f;
			impulse.Y *= 0.08f;
			Vector2 position = o.d.Position;
			position.X -= 0.5f;
			if (@as().ah != null)
			{
				@as().ah.ac();
			}
			o.ApplyLinearImpulse(impulse, position);
			d = true;
			ai(A_0: false);
		}
		if (d)
		{
			((ct)this).m = c;
		}
		else if (au())
		{
			((ct)this).m = ao();
		}
		else
		{
			((ct)this).m = ay();
		}
	}

	private void ah()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		e.position = o.d.Position;
		e.angle = o.e.a;
		e.type = BodyType.Dynamic;
		e.angularDamping = o.GetAngularDamping();
		e.bullet = true;
		e.awake = true;
		Body body = o.GetWorld().CreateBody(e);
		b.o = body;
		f._radius = base.b;
		g.density = @as().t;
		g.friction = @as().u;
		g.restitution = @as().v;
		g.shape = f;
		body.CreateFixture(g);
		h.a = b.q;
		h.b = @as().k;
		h.c = b;
		b.o.SetUserData(h);
		Vector2 position = o.d.Position;
		position.Y += base.b * 2f + 0.1f;
		b.c = position.X;
		b.d = position.Y;
		b.o.SetTransform(position, o.e.a);
		b.o.SetLinearVelocity(new Vector2(0f, 100f));
		b.j(A_0: false);
		b.ai(A_0: true);
	}
}
