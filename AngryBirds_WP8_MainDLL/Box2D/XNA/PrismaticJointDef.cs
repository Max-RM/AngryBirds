using Microsoft.Xna.Framework;

namespace Box2D.XNA;

public class PrismaticJointDef : JointDef
{
	public Vector2 localAnchorA;

	public Vector2 localAnchorB;

	public Vector2 localAxis1;

	public float referenceAngle;

	public bool enableLimit;

	public float lowerTranslation;

	public float upperTranslation;

	public bool enableMotor;

	public float maxMotorForce;

	public float motorSpeed;

	public PrismaticJointDef()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		a = JointType.Prismatic;
		localAnchorA = Vector2.Zero;
		localAnchorB = Vector2.Zero;
		localAxis1 = new Vector2(1f, 0f);
		referenceAngle = 0f;
		enableLimit = false;
		lowerTranslation = 0f;
		upperTranslation = 0f;
		enableMotor = false;
		maxMotorForce = 0f;
		motorSpeed = 0f;
	}

	public void Initialize(Body b1, Body b2, Vector2 anchor, Vector2 axis)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		bodyA = b1;
		bodyB = b2;
		localAnchorA = bodyA.GetLocalPoint(anchor);
		localAnchorB = bodyB.GetLocalPoint(anchor);
		localAxis1 = bodyA.GetLocalVector(axis);
		referenceAngle = bodyB.e.a - bodyA.e.a;
	}
}
