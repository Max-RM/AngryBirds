using System;

namespace Box2D.XNA;

[Flags]
public enum WorldFlags
{
	NewFixture = 1,
	Locked = 2,
	ClearForces = 4
}
