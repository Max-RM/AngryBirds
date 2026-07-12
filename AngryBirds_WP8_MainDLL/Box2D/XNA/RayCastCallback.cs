using Microsoft.Xna.Framework;

namespace Box2D.XNA;

public delegate float RayCastCallback(Fixture fixture, Vector2 point, Vector2 normal, float fraction);
