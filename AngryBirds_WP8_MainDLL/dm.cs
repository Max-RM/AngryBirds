using System;
using Box2D.XNA;
using Microsoft.Xna.Framework;

internal struct dm
{
	internal FixedArray3<dk> _simplex;

	internal int _count;

	internal void M_a(ref SimplexCache A_0, ref DistanceProxy A_1, ref Transform A_2, ref DistanceProxy A_3, ref Transform A_4)
	{
		this._count = A_0.count;
		if (this._count > 0)
		{
			M_a(ref this._simplex._value0, A_0.indexA._value0, A_0.indexB._value0, ref A_1, ref A_2, ref A_3, ref A_4);
			if (this._count > 1)
			{
				M_a(ref this._simplex._value1, A_0.indexA._value1, A_0.indexB._value1, ref A_1, ref A_2, ref A_3, ref A_4);
				if (this._count > 2)
				{
					M_a(ref this._simplex._value2, A_0.indexA._value2, A_0.indexB._value2, ref A_1, ref A_2, ref A_3, ref A_4);
				}
			}
		}
		if (this._count > 1)
		{
			float metric = A_0.metric;
			float num = M_a();
			if (num < 0.5f * metric || 2f * metric < num || num < 1.1920929E-07f)
			{
				this._count = 0;
			}
		}
		if (this._count == 0)
		{
			M_a(ref this._simplex._value0, 0, 0, ref A_1, ref A_2, ref A_3, ref A_4);
			this._count = 1;
		}
	}

	private void M_a(ref dk A_0, int A_1, int A_2, ref DistanceProxy A_3, ref Transform A_4, ref DistanceProxy A_5, ref Transform A_6)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		Vector2 vertex = A_3.GetVertex(A_1);
		Vector2 vertex2 = A_5.GetVertex(A_2);
		float num = A_4.Position.X + A_4.R.col1.X * vertex.X + A_4.R.col2.X * vertex.Y;
		vertex.Y = A_4.Position.Y + A_4.R.col1.Y * vertex.X + A_4.R.col2.Y * vertex.Y;
		vertex.X = num;
		num = A_6.Position.X + A_6.R.col1.X * vertex2.X + A_6.R.col2.X * vertex2.Y;
		vertex2.Y = A_6.Position.Y + A_6.R.col1.Y * vertex2.X + A_6.R.col2.Y * vertex2.Y;
		vertex2.X = num;
		A_0.e = A_1;
		A_0.f = A_2;
		A_0.a = vertex;
		A_0.b = vertex2;
		A_0.c.X = vertex2.X - vertex.X;
		A_0.c.Y = vertex2.Y - vertex.Y;
		A_0.d = 0f;
	}

	internal void M_a(ref SimplexCache A_0)
	{
		A_0.metric = M_a();
		A_0.count = (ushort)this._count;
		if (this._count <= 0)
		{
			return;
		}
		A_0.indexA._value0 = (byte)this._simplex._value0.e;
		A_0.indexB._value0 = (byte)this._simplex._value0.f;
		if (this._count > 1)
		{
			A_0.indexA._value1 = (byte)this._simplex._value1.e;
			A_0.indexB._value1 = (byte)this._simplex._value1.f;
			if (this._count > 2)
			{
				A_0.indexA._value2 = (byte)this._simplex._value2.e;
				A_0.indexB._value2 = (byte)this._simplex._value2.f;
			}
		}
	}

	internal Vector2 M_b()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		switch (this._count)
		{
		case 1:
			return -this._simplex._value0.c;
		case 2:
		{
			Vector2 val = this._simplex._value1.c - this._simplex._value0.c;
			float num = MathUtils.Cross(val, -this._simplex._value0.c);
			if (num > 0f)
			{
				return MathUtils.Cross(1f, val);
			}
			return MathUtils.Cross(val, 1f);
		}
		default:
			return Vector2.Zero;
		}
	}

	internal Vector2 M_c()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		return (Vector2)(this._count switch
		{
			0 => Vector2.Zero, 
			1 => this._simplex._value0.c, 
			2 => this._simplex._value0.d * this._simplex._value0.c + this._simplex._value1.d * this._simplex._value1.c, 
			3 => Vector2.Zero, 
			_ => Vector2.Zero, 
		});
	}

	internal void M_a(out Vector2 A_0, out Vector2 A_1)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		switch (this._count)
		{
		case 0:
			A_0 = Vector2.Zero;
			A_1 = Vector2.Zero;
			break;
		case 1:
			A_0 = this._simplex._value0.a;
			A_1 = this._simplex._value0.b;
			break;
		case 2:
			A_0 = this._simplex._value0.d * this._simplex._value0.a + this._simplex._value1.d * this._simplex._value1.a;
			A_1 = this._simplex._value0.d * this._simplex._value0.b + this._simplex._value1.d * this._simplex._value1.b;
			break;
		case 3:
			A_0 = this._simplex._value0.d * this._simplex._value0.a + this._simplex._value1.d * this._simplex._value1.a + this._simplex._value2.d * this._simplex._value2.a;
			A_1 = A_0;
			break;
		default:
			throw new Exception();
		}
	}

	internal float M_a()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		switch (this._count)
		{
		case 0:
			return 0f;
		case 1:
			return 0f;
		case 2:
		{
			Vector2 val = this._simplex._value0.c - this._simplex._value1.c;
			return val.Length();
		}
		case 3:
			return MathUtils.Cross(this._simplex._value1.c - this._simplex._value0.c, this._simplex._value2.c - this._simplex._value0.c);
		default:
			return 0f;
		}
	}

	internal void M_d()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = this._simplex._value0.c;
		Vector2 val2 = this._simplex._value1.c;
		Vector2 val3 = val2 - val;
		float num = 0f - Vector2.Dot(val, val3);
		if (num <= 0f)
		{
			this._simplex._value0.d = 1f;
			this._count = 1;
			return;
		}
		float num2 = Vector2.Dot(val2, val3);
		if (num2 <= 0f)
		{
			this._simplex._value1.d = 1f;
			this._count = 1;
			this._simplex._value0 = this._simplex._value1;
		}
		else
		{
			float num3 = 1f / (num2 + num);
			this._simplex._value0.d = num2 * num3;
			this._simplex._value1.d = num * num3;
			this._count = 2;
		}
	}

	internal void M_e()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = this._simplex._value0.c;
		Vector2 val2 = this._simplex._value1.c;
		Vector2 val3 = this._simplex._value2.c;
		Vector2 val4 = val2 - val;
		Vector2 val5 = val3 - val;
		float num = Vector2.Dot(val, val4);
		float num2 = Vector2.Dot(val2, val4);
		float num3 = Vector2.Dot(val, val5);
		float num4 = num2;
		float num5 = 0f - num;
		float num6 = 0f - num3;
		if (num5 <= 0f && num6 <= 0f)
		{
			this._simplex._value0.d = 1f;
			this._count = 1;
			return;
		}
		float num7 = Vector2.Dot(val3, val5);
		float num8 = num7;
		float num9 = MathUtils.Cross(val4, val5);
		float num10 = num9 * MathUtils.Cross(val, val2);
		if (num4 > 0f && num5 > 0f && num10 <= 0f)
		{
			float num11 = 1f / (num4 + num5);
			this._simplex._value0.d = num4 * num11;
			this._simplex._value1.d = num5 * num11;
			this._count = 2;
			return;
		}
		Vector2 val6 = val3 - val2;
		float num12 = Vector2.Dot(val2, val6);
		float num13 = Vector2.Dot(val3, val6);
		float num14 = num13;
		float num15 = 0f - num12;
		if (num4 <= 0f && num15 <= 0f)
		{
			this._simplex._value1.d = 1f;
			this._simplex._value0 = this._simplex._value1;
			this._count = 1;
			return;
		}
		if (num8 <= 0f && num14 <= 0f)
		{
			this._simplex._value2.d = 1f;
			this._simplex._value0 = this._simplex._value2;
			this._count = 1;
			return;
		}
		float num16 = num9 * MathUtils.Cross(val3, val);
		if (num8 > 0f && num6 > 0f && num16 <= 0f)
		{
			float num17 = 1f / (num8 + num6);
			this._simplex._value0.d = num8 * num17;
			this._simplex._value2.d = num6 * num17;
			this._simplex._value1 = this._simplex._value2;
			this._count = 2;
			return;
		}
		float num18 = num9 * MathUtils.Cross(val2, val3);
		if (num14 > 0f && num15 > 0f && num18 <= 0f)
		{
			float num19 = 1f / (num14 + num15);
			this._simplex._value1.d = num14 * num19;
			this._simplex._value2.d = num15 * num19;
			this._simplex._value0 = this._simplex._value2;
			this._count = 2;
		}
		else
		{
			float num20 = 1f / (num18 + num16 + num10);
			this._simplex._value0.d = num18 * num20;
			this._simplex._value1.d = num16 * num20;
			this._simplex._value2.d = num10 * num20;
			this._count = 3;
		}
	}
}
