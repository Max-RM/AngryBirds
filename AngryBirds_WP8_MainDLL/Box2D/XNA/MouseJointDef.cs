using Microsoft.Xna.Framework;

namespace Box2D.XNA;

public class MouseJointDef : JointDef
{
	public Vector2 target;

	public float maxForce;

	public float frequencyHz;

	public float dampingRatio;

	public MouseJointDef()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		a = JointType.Mouse;
		target = new Vector2(0f, 0f);
		maxForce = 0f;
		frequencyHz = 5f;
		dampingRatio = 0.7f;
	}
}
