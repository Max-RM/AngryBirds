using Microsoft.Xna.Framework;

namespace Box2D.XNA;

public struct SeparationFunction
{
	private DistanceProxy a;

	private DistanceProxy b;

	private Sweep c;

	private Sweep d;

	private SeparationFunctionType e;

	private Vector2 f;

	private Vector2 g;

	public SeparationFunction(ref SimplexCache cache, ref DistanceProxy proxyA, ref Sweep sweepA, ref DistanceProxy proxyB, ref Sweep sweepB, float t1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Unknown result type (might be due to invalid IL or missing references)
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		f = Vector2.Zero;
		a = proxyA;
		b = proxyB;
		int count = cache.count;
		c = sweepA;
		d = sweepB;
		c.GetTransform(out var xf, t1);
		d.GetTransform(out var xf2, t1);
		if (count == 1)
		{
			e = SeparationFunctionType.Points;
			Vector2 vertex = a.GetVertex(cache.indexA[0]);
			Vector2 vertex2 = b.GetVertex(cache.indexB[0]);
			Vector2 val = MathUtils.Multiply(ref xf, vertex);
			Vector2 val2 = MathUtils.Multiply(ref xf2, vertex2);
			g = new Vector2
			{
				X = val2.X - val.X,
				Y = val2.Y - val.Y
			};
			g.Normalize();
		}
		else if (cache.indexA[0] == cache.indexA[1])
		{
			e = SeparationFunctionType.FaceB;
			Vector2 vertex3 = proxyB.GetVertex(cache.indexB[0]);
			Vector2 vertex4 = proxyB.GetVertex(cache.indexB[1]);
			g = MathUtils.Cross(vertex4 - vertex3, 1f);
			g.Normalize();
			Vector2 val3 = MathUtils.Multiply(ref xf2.R, g);
			f.X = 0.5f * (vertex3.X + vertex4.X);
			f.Y = 0.5f * (vertex3.Y + vertex4.Y);
			Vector2 val4 = MathUtils.Multiply(ref xf2, f);
			Vector2 vertex5 = proxyA.GetVertex(cache.indexA[0]);
			Vector2 val5 = MathUtils.Multiply(ref xf, vertex5);
			float num = val5.X - val4.X;
			float num2 = val5.Y - val4.Y;
			float num3 = num * val3.X + num2 * val3.Y;
			if (num3 < 0f)
			{
				g = -g;
				num3 = 0f - num3;
			}
		}
		else
		{
			e = SeparationFunctionType.FaceA;
			Vector2 vertex6 = a.GetVertex(cache.indexA[0]);
			Vector2 vertex7 = a.GetVertex(cache.indexA[1]);
			g = MathUtils.Cross(vertex7 - vertex6, 1f);
			g.Normalize();
			Vector2 val6 = MathUtils.Multiply(ref xf.R, g);
			f.X = 0.5f * (vertex6.X + vertex7.X);
			f.Y = 0.5f * (vertex6.Y + vertex7.Y);
			Vector2 val7 = MathUtils.Multiply(ref xf, f);
			Vector2 vertex8 = b.GetVertex(cache.indexB[0]);
			Vector2 val8 = MathUtils.Multiply(ref xf2, vertex8);
			float num4 = val8.X - val7.X;
			float num5 = val8.Y - val7.Y;
			float num6 = num4 * val6.X + num5 * val6.Y;
			if (num6 < 0f)
			{
				g = -g;
				num6 = 0f - num6;
			}
		}
	}

	public float FindMinSeparation(out int indexA, out int indexB, float t)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		c.GetTransform(out var xf, t);
		d.GetTransform(out var xf2, t);
		switch (e)
		{
		case SeparationFunctionType.Points:
		{
			Vector2 val9 = MathUtils.MultiplyT(ref xf.R, g);
			Vector2 val10 = MathUtils.MultiplyT(ref xf2.R, -g);
			indexA = a.GetSupport(val9);
			indexB = b.GetSupport(val10);
			Vector2 vertex3 = a.GetVertex(indexA);
			Vector2 vertex4 = b.GetVertex(indexB);
			Vector2 val11 = MathUtils.Multiply(ref xf, vertex3);
			Vector2 val12 = MathUtils.Multiply(ref xf2, vertex4);
			return Vector2.Dot(val12 - val11, g);
		}
		case SeparationFunctionType.FaceA:
		{
			Vector2 val5 = MathUtils.Multiply(ref xf.R, g);
			Vector2 val6 = MathUtils.Multiply(ref xf, f);
			Vector2 val7 = MathUtils.MultiplyT(ref xf2.R, -val5);
			indexA = -1;
			indexB = b.GetSupport(val7);
			Vector2 vertex2 = b.GetVertex(indexB);
			Vector2 val8 = MathUtils.Multiply(ref xf2, vertex2);
			return Vector2.Dot(val8 - val6, val5);
		}
		case SeparationFunctionType.FaceB:
		{
			Vector2 val = MathUtils.Multiply(ref xf2.R, g);
			Vector2 val2 = MathUtils.Multiply(ref xf2, f);
			Vector2 val3 = MathUtils.MultiplyT(ref xf.R, -val);
			indexB = -1;
			indexA = a.GetSupport(val3);
			Vector2 vertex = a.GetVertex(indexA);
			Vector2 val4 = MathUtils.Multiply(ref xf, vertex);
			return Vector2.Dot(val4 - val2, val);
		}
		default:
			indexA = -1;
			indexB = -1;
			return 0f;
		}
	}

	public float Evaluate(int indexA, int indexB, float t)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		c.GetTransform(out var xf, t);
		d.GetTransform(out var xf2, t);
		switch (e)
		{
		case SeparationFunctionType.Points:
		{
			MathUtils.MultiplyT(ref xf.R, g);
			MathUtils.MultiplyT(ref xf2.R, -g);
			Vector2 vertex3 = a.GetVertex(indexA);
			Vector2 vertex4 = b.GetVertex(indexB);
			Vector2 val7 = MathUtils.Multiply(ref xf, vertex3);
			Vector2 val8 = MathUtils.Multiply(ref xf2, vertex4);
			return Vector2.Dot(val8 - val7, g);
		}
		case SeparationFunctionType.FaceA:
		{
			Vector2 val4 = MathUtils.Multiply(ref xf.R, g);
			Vector2 val5 = MathUtils.Multiply(ref xf, f);
			MathUtils.MultiplyT(ref xf2.R, -val4);
			Vector2 vertex2 = b.GetVertex(indexB);
			Vector2 val6 = MathUtils.Multiply(ref xf2, vertex2);
			return Vector2.Dot(val6 - val5, val4);
		}
		case SeparationFunctionType.FaceB:
		{
			Vector2 val = MathUtils.Multiply(ref xf2.R, g);
			Vector2 val2 = MathUtils.Multiply(ref xf2, f);
			MathUtils.MultiplyT(ref xf.R, -val);
			Vector2 vertex = a.GetVertex(indexA);
			Vector2 val3 = MathUtils.Multiply(ref xf, vertex);
			return Vector2.Dot(val3 - val2, val);
		}
		default:
			return 0f;
		}
	}
}
