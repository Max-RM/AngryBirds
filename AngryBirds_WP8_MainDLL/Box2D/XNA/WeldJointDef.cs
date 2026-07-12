using Microsoft.Xna.Framework;

namespace Box2D.XNA;

public class WeldJointDef : JointDef
{
	public Vector2 localAnchorA;

	public Vector2 localAnchorB;

	public float referenceAngle;

	public WeldJointDef()
	{
		a = JointType.Weld;
	}

	public void Initialize(Body b1, Body b2, Vector2 anchor)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		bodyA = b1;
		bodyB = b2;
		localAnchorA = bodyA.GetLocalPoint(anchor);
		localAnchorB = bodyB.GetLocalPoint(anchor);
		referenceAngle = bodyB.e.a - bodyA.e.a;
	}
}
