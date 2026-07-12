using Microsoft.Xna.Framework;

namespace Box2D.XNA;

public class RevoluteJointDef : JointDef
{
	public Vector2 localAnchorA;

	public Vector2 localAnchorB;

	public float referenceAngle;

	public bool enableLimit;

	public float lowerAngle;

	public float upperAngle;

	public bool enableMotor;

	public float motorSpeed;

	public float maxMotorTorque;

	public RevoluteJointDef()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		a = JointType.Revolute;
		localAnchorA = new Vector2(0f, 0f);
		localAnchorB = new Vector2(0f, 0f);
		referenceAngle = 0f;
		lowerAngle = 0f;
		upperAngle = 0f;
		maxMotorTorque = 0f;
		motorSpeed = 0f;
		enableLimit = false;
		enableMotor = false;
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
