using Microsoft.Xna.Framework;

namespace Box2D.XNA;

public class PulleyJointDef : JointDef
{
	public Vector2 groundAnchorA;

	public Vector2 groundAnchorB;

	public Vector2 localAnchorA;

	public Vector2 localAnchorB;

	public float lengthA;

	public float maxLengthA;

	public float lengthB;

	public float maxLengthB;

	public float ratio;

	public PulleyJointDef()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		a = JointType.Pulley;
		groundAnchorA = new Vector2(-1f, 1f);
		groundAnchorB = new Vector2(1f, 1f);
		localAnchorA = new Vector2(-1f, 0f);
		localAnchorB = new Vector2(1f, 0f);
		lengthA = 0f;
		maxLengthA = 0f;
		lengthB = 0f;
		maxLengthB = 0f;
		ratio = 1f;
		collideConnected = true;
	}

	public void Initialize(Body b1, Body b2, Vector2 ga1, Vector2 ga2, Vector2 anchor1, Vector2 anchor2, float r)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		bodyA = b1;
		bodyB = b2;
		groundAnchorA = ga1;
		groundAnchorB = ga2;
		localAnchorA = bodyA.GetLocalPoint(anchor1);
		localAnchorB = bodyB.GetLocalPoint(anchor2);
		Vector2 val = anchor1 - ga1;
		lengthA = val.Length();
		Vector2 val2 = anchor2 - ga2;
		lengthB = val2.Length();
		ratio = r;
		float num = lengthA + ratio * lengthB;
		maxLengthA = num - ratio * 2f;
		maxLengthB = (num - 2f) / ratio;
	}
}
