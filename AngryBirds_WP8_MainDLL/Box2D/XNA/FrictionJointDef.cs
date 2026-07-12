using Microsoft.Xna.Framework;

namespace Box2D.XNA;

public class FrictionJointDef : JointDef
{
	public Vector2 localAnchorA;

	public Vector2 localAnchorB;

	public float maxForce;

	public float maxTorque;

	public FrictionJointDef()
	{
		a = JointType.Friction;
	}

	public void Initialize(Body b1, Body b2, Vector2 anchor1, Vector2 anchor2)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		bodyA = b1;
		bodyB = b2;
		localAnchorA = bodyA.GetLocalPoint(anchor1);
		localAnchorB = bodyB.GetLocalPoint(anchor2);
	}
}
