using Microsoft.Xna.Framework;

namespace Box2D.XNA;

public class BodyDef
{
	public BodyType type;

	public Vector2 position;

	public float angle;

	public Vector2 linearVelocity;

	public float angularVelocity;

	public float linearDamping;

	public float angularDamping;

	public bool allowSleep;

	public bool awake;

	public bool fixedRotation;

	public bool bullet;

	public bool active;

	public object userData;

	public float inertiaScale;

	public BodyDef()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		userData = null;
		position = new Vector2(0f, 0f);
		angle = 0f;
		linearVelocity = new Vector2(0f, 0f);
		angularVelocity = 0f;
		linearDamping = 0f;
		angularDamping = 0f;
		allowSleep = true;
		awake = true;
		fixedRotation = false;
		bullet = false;
		type = BodyType.Static;
		active = true;
		inertiaScale = 1f;
	}
}
