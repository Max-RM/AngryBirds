namespace Box2D.XNA;

public class GearJointDef : JointDef
{
	public Joint joint1;

	public Joint joint2;

	public float ratio;

	public GearJointDef()
	{
		a = JointType.Gear;
		joint1 = null;
		joint2 = null;
		ratio = 1f;
	}
}
