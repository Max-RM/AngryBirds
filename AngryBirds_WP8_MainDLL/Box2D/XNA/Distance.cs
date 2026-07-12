using Microsoft.Xna.Framework;

namespace Box2D.XNA;

public static class Distance
{
	public static int b2_gjkCalls;

	public static int b2_gjkIters;

	public static int b2_gjkMaxIters;

	public static void ComputeDistance(out DistanceOutput output, out SimplexCache cache, ref DistanceInput input)
	{
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_0385: Unknown result type (might be due to invalid IL or missing references)
		//IL_038a: Unknown result type (might be due to invalid IL or missing references)
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_038f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0395: Unknown result type (might be due to invalid IL or missing references)
		//IL_0397: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0364: Unknown result type (might be due to invalid IL or missing references)
		//IL_0369: Unknown result type (might be due to invalid IL or missing references)
		cache = default(SimplexCache);
		b2_gjkCalls++;
		dm dm = default(dm);
		dm.M_a(ref cache, ref input.proxyA, ref input.transformA, ref input.proxyB, ref input.transformB);
		int num = 20;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		int num7 = 0;
		int num8 = 0;
		int num9 = 0;
		while (num9 < num)
		{
			num8 = dm._count;
			if (num8 > 0)
			{
				num2 = dm._simplex._value0.e;
				num5 = dm._simplex._value0.f;
				if (num8 > 1)
				{
					num3 = dm._simplex._value1.e;
					num6 = dm._simplex._value1.f;
					if (num8 > 2)
					{
						num4 = dm._simplex._value2.e;
						num7 = dm._simplex._value2.f;
					}
				}
			}
			switch (dm._count)
			{
			case 2:
				dm.M_d();
				break;
			case 3:
				dm.M_e();
				break;
			}
			if (dm._count == 3)
			{
				break;
			}
			Vector2 val = dm.M_b();
			float num10 = val.X * val.X + val.Y * val.Y;
			if (num10 < 1.4210855E-14f)
			{
				break;
			}
			dk value = default(dk);
			value.e = input.proxyA.GetSupportSpecial(MathUtils.MultiplyT(ref input.transformA.R, -val), out var best);
			value.a = MathUtils.Multiply(ref input.transformA, best);
			value.f = input.proxyB.GetSupportSpecial(MathUtils.MultiplyT(ref input.transformB.R, val), out best);
			value.b = MathUtils.Multiply(ref input.transformB, best);
			value.c = value.b - value.a;
			dm._simplex[dm._count] = value;
			num9++;
			b2_gjkIters++;
			if (num8 > 0 && ((value.e == num2 && value.f == num5) || (num8 > 1 && ((value.e == num3 && value.f == num6) || (num8 > 2 && value.e == num4 && value.f == num7)))))
			{
				break;
			}
			dm._count++;
		}
		if (b2_gjkMaxIters < num9)
		{
			b2_gjkMaxIters = num9;
		}
		dm.M_a(out output.pointA, out output.pointB);
		Vector2 val2 = output.pointA - output.pointB;
		output.distance = val2.Length();
		output.iterations = num9;
		dm.M_a(ref cache);
		if (input.useRadii)
		{
			float d = input.proxyA.d;
			float d2 = input.proxyB.d;
			if (output.distance > d + d2 && output.distance > 1.1920929E-07f)
			{
				output.distance -= d + d2;
				Vector2 val3 = output.pointB - output.pointA;
				val3.Normalize();
				output.pointA += d * val3;
				output.pointB -= d2 * val3;
			}
			else
			{
				output.pointB = (output.pointA = 0.5f * (output.pointA + output.pointB));
				output.distance = 0f;
			}
		}
	}
}
