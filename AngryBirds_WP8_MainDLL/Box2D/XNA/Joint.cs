using Microsoft.Xna.Framework;

namespace Box2D.XNA;

public abstract class Joint
{
	internal JointType a;

	internal Joint b;

	internal Joint c;

	internal JointEdge d;

	internal JointEdge e;

	internal Body f;

	internal Body g;

	internal bool h;

	internal bool i;

	internal object j;

	internal Vector2 k;

	internal Vector2 l;

	internal float m;

	internal float n;

	internal float o;

	internal float p;

	public JointType JointType => this.a;

	public Body GetBodyA()
	{
		return f;
	}

	public Body GetBodyB()
	{
		return g;
	}

	public abstract Vector2 GetAnchorA();

	public abstract Vector2 GetAnchorB();

	public abstract Vector2 GetReactionForce(float inv_dt);

	public abstract float GetReactionTorque(float inv_dt);

	public Joint GetNext()
	{
		return c;
	}

	public object GetUserData()
	{
		return j;
	}

	public void SetUserData(object data)
	{
		j = data;
	}

	public bool IsActive()
	{
		if (f.IsActive())
		{
			return g.IsActive();
		}
		return false;
	}

	internal static Joint M_a(JointDef A_0)
	{
		Joint result = null;
		switch (A_0.a)
		{
		case JointType.Distance:
			result = new DistanceJoint((DistanceJointDef)A_0);
			break;
		case JointType.Mouse:
			result = new MouseJoint((MouseJointDef)A_0);
			break;
		case JointType.Prismatic:
			result = new PrismaticJoint((PrismaticJointDef)A_0);
			break;
		case JointType.Revolute:
			result = new RevoluteJoint((RevoluteJointDef)A_0);
			break;
		case JointType.Pulley:
			result = new PulleyJoint((PulleyJointDef)A_0);
			break;
		case JointType.Gear:
			result = new GearJoint((GearJointDef)A_0);
			break;
		case JointType.Line:
			result = new LineJoint((LineJointDef)A_0);
			break;
		case JointType.Weld:
			result = new WeldJoint((WeldJointDef)A_0);
			break;
		case JointType.Friction:
			result = new FrictionJoint((FrictionJointDef)A_0);
			break;
		case JointType.MaxDistance:
			result = new MaxDistanceJoint((MaxDistanceJointDef)A_0);
			break;
		}
		return result;
	}

	protected Joint(JointDef def)
	{
		this.a = def.a;
		f = def.bodyA;
		g = def.bodyB;
		i = def.collideConnected;
		j = def.userData;
		d = new JointEdge();
		e = new JointEdge();
	}

	internal abstract void InitVelocityConstraints(ref TimeStep step);

	internal abstract void SolveVelocityConstraints(ref TimeStep step);

	internal abstract bool SolvePositionConstraints(float baumgarte);
}
