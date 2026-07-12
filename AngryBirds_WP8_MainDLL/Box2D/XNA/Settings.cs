using System;

namespace Box2D.XNA;

public static class Settings
{
	public const float b2_maxFloat = float.MaxValue;

	public const float b2_epsilon = 1.1920929E-07f;

	public const float b2_epsilonSq = 1.4210855E-14f;

	public const float b2_pi = (float)Math.PI;

	public const int b2_maxManifoldPoints = 2;

	public const int b2_maxPolygonVertices = 8;

	public const float b2_aabbExtension = 0.1f;

	public const float b2_aabbMultiplier = 2f;

	public const float b2_linearSlop = 0.05f;

	public const float b2_angularSlop = (float)Math.PI / 90f;

	public const float b2_polygonRadius = 0.1f;

	public const int b2_maxTOIContacts = 32;

	public const float b2_velocityThreshold = 1f;

	public const float b2_maxLinearCorrection = 0.2f;

	public const float b2_maxAngularCorrection = (float)Math.PI * 2f / 45f;

	public const float b2_contactBaumgarte = 0.2f;

	public const float b2_timeToSleep = 0.25f;

	public const float b2_linearSleepTolerance = 0.1f;

	public const float b2_angularSleepTolerance = (float)Math.PI / 90f;

	public static float b2_maxTranslation = 2f;

	public static float b2_maxTranslationSquared = b2_maxTranslation * b2_maxTranslation;

	public static float b2_maxRotation = (float)Math.PI / 2f;

	public static float b2_maxRotationSquared = b2_maxRotation * b2_maxRotation;

	public static float b2MixFriction(float friction1, float friction2)
	{
		return (float)Math.Sqrt(friction1 * friction2);
	}

	public static float b2MixRestitution(float restitution1, float restitution2)
	{
		if (!(restitution1 > restitution2))
		{
			return restitution2;
		}
		return restitution1;
	}
}
