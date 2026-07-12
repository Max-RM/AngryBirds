using System;

namespace Box2D.XNA;

[Flags]
public enum DebugDrawFlags
{
	Shape = 1,
	Joint = 2,
	AABB = 4,
	Pair = 8,
	CenterOfMass = 0x10
}
