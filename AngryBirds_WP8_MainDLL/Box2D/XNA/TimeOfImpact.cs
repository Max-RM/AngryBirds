using System;

namespace Box2D.XNA;

public static class TimeOfImpact
{
	public static int b2_toiCalls;

	public static int b2_toiIters;

	public static int b2_toiMaxIters;

	public static int b2_toiRootIters;

	public static int b2_toiMaxRootIters;

	public static int b2_toiMaxOptIters;

	public static void CalculateTimeOfImpact(out TOIOutput output, ref TOIInput input)
	{
		b2_toiCalls++;
		output = default(TOIOutput);
		output.State = TOIOutputState.Unknown;
		output.t = input.tMax;
		Sweep sweepA = input.sweepA;
		Sweep sweepB = input.sweepB;
		sweepA.Normalize();
		sweepB.Normalize();
		float tMax = input.tMax;
		float num = input.proxyA.d + input.proxyB.d;
		float num2 = Math.Max(0.05f, num - 0.15f);
		float num3 = 0.0125f;
		float num4 = 0f;
		int num5 = 20;
		int num6 = 0;
		DistanceInput input2 = default(DistanceInput);
		input2.proxyA = input.proxyA;
		input2.proxyB = input.proxyB;
		input2.useRadii = false;
		while (true)
		{
			sweepA.GetTransform(out var xf, num4);
			sweepB.GetTransform(out var xf2, num4);
			input2.transformA = xf;
			input2.transformB = xf2;
			Distance.ComputeDistance(out var output2, out var cache, ref input2);
			if (output2.distance <= 0f)
			{
				output.State = TOIOutputState.Overlapped;
				output.t = 0f;
				break;
			}
			if (output2.distance < num2 + num3)
			{
				output.State = TOIOutputState.Touching;
				output.t = num4;
				break;
			}
			SeparationFunction separationFunction = new SeparationFunction(ref cache, ref input.proxyA, ref sweepA, ref input.proxyB, ref sweepB, num4);
			bool flag = false;
			float num7 = tMax;
			int num8 = 0;
			do
			{
				int indexA;
				int indexB;
				float num9 = separationFunction.FindMinSeparation(out indexA, out indexB, num7);
				if (num9 > num2 + num3)
				{
					output.State = TOIOutputState.Seperated;
					output.t = tMax;
					flag = true;
					break;
				}
				if (num9 > num2 - num3)
				{
					num4 = num7;
					break;
				}
				float num10 = separationFunction.Evaluate(indexA, indexB, num4);
				if (num10 < num2 - num3)
				{
					output.State = TOIOutputState.Failed;
					output.t = num4;
					flag = true;
					break;
				}
				if (num10 <= num2 + num3)
				{
					output.State = TOIOutputState.Touching;
					output.t = num4;
					flag = true;
					break;
				}
				int num11 = 0;
				float num12 = num4;
				float num13 = num7;
				do
				{
					float num14 = (((num11 & 1) == 0) ? (0.5f * (num12 + num13)) : (num12 + (num2 - num10) * (num13 - num12) / (num9 - num10)));
					float num15 = separationFunction.Evaluate(indexA, indexB, num14);
					if (Math.Abs(num15 - num2) < num3)
					{
						num7 = num14;
						break;
					}
					if (num15 > num2)
					{
						num12 = num14;
						num10 = num15;
					}
					else
					{
						num13 = num14;
						num9 = num15;
					}
					num11++;
					b2_toiRootIters++;
				}
				while (num11 != 50);
				b2_toiMaxRootIters = Math.Max(b2_toiMaxRootIters, num11);
				num8++;
			}
			while (num8 != 8);
			num6++;
			b2_toiIters++;
			if (flag)
			{
				break;
			}
			if (num6 == num5)
			{
				output.State = TOIOutputState.Failed;
				output.t = num4;
				break;
			}
		}
		b2_toiMaxIters = Math.Max(b2_toiMaxIters, num6);
	}
}
