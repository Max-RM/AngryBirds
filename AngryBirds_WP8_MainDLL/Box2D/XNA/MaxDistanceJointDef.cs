using Microsoft.Xna.Framework;

namespace Box2D.XNA;

public class MaxDistanceJointDef : JointDef
{
	public Vector2 localAnchorA;

	public Vector2 localAnchorB;

	public float length;

	public float frequencyHz;

	public float dampingRatio;

	public MaxDistanceJointDef()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		a = JointType.MaxDistance;
		localAnchorA = new Vector2(0f, 0f);
		localAnchorB = new Vector2(0f, 0f);
		length = 1f;
		frequencyHz = 0f;
		dampingRatio = 0f;
	}

	public void Initialize(Body b1, Body b2, Vector2 anchor1, Vector2 anchor2, float maxlength)
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
		length = maxlength;
	}
}
