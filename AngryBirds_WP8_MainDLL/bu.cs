using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

internal class bu
{
	private struct NestedStructA
	{
		public Vector2 a;

		public Color b;

		public Vector2 c;

		public Vector2 d;
	}

	public static GraphicsDevice a;

	private static bu m_b;

	private SpriteBatch m_c;

	private SpriteSortMode m_d;

	private BlendState m_e;

	private SpriteEffects m_f;

	private Color g;

	private Texture2D h;

	private SamplerState i;

	private DualTextureEffect j;

	private DynamicVertexBuffer k;

	private IndexBuffer l;

	private VertexDeclaration m;

	private static int n = 1024;

	private NestedStructA[] o = new NestedStructA[n * 4];

	private int p;

	private int q;

	private static int r = 28;

	private static Vector2 s;

	private int m_backBufferWidth = 800;

	private int m_backBufferHeight = 480;

	private int m_viewportX;

	private int m_viewportY;

	private int m_drawWidth = 800;

	private int m_drawHeight = 480;

	private Matrix m_spriteTransform = Matrix.Identity;

	private const float LOGICAL_WIDTH = 800f;

	private const float LOGICAL_HEIGHT = 480f;

	private float m_contentScale = 1f;

	private float m_visibleWidth = 800f;

	private float m_visibleHeight = 480f;

	private float m_visibleOffsetX;

	private float m_visibleOffsetY;

	public static float ContentScale
	{
		get
		{
			if (bu.m_b != null)
			{
				return bu.m_b.m_contentScale;
			}
			return 1f;
		}
	}

	public static float VisibleWidth
	{
		get
		{
			if (bu.m_b != null)
			{
				return bu.m_b.m_visibleWidth;
			}
			return 800f;
		}
	}

	public static float VisibleHeight
	{
		get
		{
			if (bu.m_b != null)
			{
				return bu.m_b.m_visibleHeight;
			}
			return 480f;
		}
	}

	public static float VisibleOffsetX
	{
		get
		{
			if (bu.m_b != null)
			{
				return bu.m_b.m_visibleOffsetX;
			}
			return 0f;
		}
	}

	public static float VisibleOffsetY
	{
		get
		{
			if (bu.m_b != null)
			{
				return bu.m_b.m_visibleOffsetY;
			}
			return 0f;
		}
	}

	private static Vector2 t;

	private static Vector2 u;

	private static Rectangle v;

	private Texture2D w;

	private Texture2D x;

	private float y;

	private float z;

	private float aa = 1f;

	private float ab = 1f;

	private float ac = 1f;

	private float ad = 1f;

	private float ae = 1f;

	public static void b(GraphicsDevice A_0)
	{
		if (A_0 == null)
		{
			throw new Exception("Error: Game content root path needs to be initialized.");
		}
		bu.a = A_0;
	}

	public static bool IsInitialized()
	{
		return bu.a != null;
	}

	public static bu b()
	{
		if (bu.m_b == null)
		{
			if (bu.a == null)
			{
				throw new Exception("Error: Game content root path needs to be initialized.");
			}
			bu.m_b = new bu();
		}
		return bu.m_b;
	}

	private bu()
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected O, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected O, but got Unknown
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Expected O, but got Unknown
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Expected O, but got Unknown
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Expected O, but got Unknown
		this.m_c = new SpriteBatch(bu.a);
		this.m_d = (SpriteSortMode)0;
		this.m_e = BlendState.AlphaBlend;
		this.m_f = (SpriteEffects)0;
		g = Color.White;
		h = new Texture2D(bu.a, 1, 1);
		h.SetData<Color>((Color[])(object)new Color[1] { Color.White });
		Matrix val = Matrix.CreateOrthographicOffCenter(0f, 800f, 480f, 0f, 0f, 1f);
		Matrix val2 = Matrix.CreateTranslation(-0.5f, -0.5f, 0f);
		i = new SamplerState();
		i = SamplerState.LinearClamp;
		j = new DualTextureEffect(bu.a);
		j.DiffuseColor = new Vector3(1f, 1f, 1f);
		j.VertexColorEnabled = false;
		j.Alpha = 1f;
		j.Projection = val2 * val;
		j.View = Matrix.Identity;
		j.World = Matrix.Identity;
		VertexElement[] array = (VertexElement[])(object)new VertexElement[4]
		{
			new VertexElement(0, (VertexElementFormat)1, (VertexElementUsage)0, 0),
			new VertexElement(8, (VertexElementFormat)4, (VertexElementUsage)1, 0),
			new VertexElement(12, (VertexElementFormat)1, (VertexElementUsage)2, 0),
			new VertexElement(20, (VertexElementFormat)1, (VertexElementUsage)2, 1)
		};
		m = new VertexDeclaration(array);
		k = new DynamicVertexBuffer(bu.a, m, n * 4, (BufferUsage)1);
		short[] array2 = new short[6 * n];
		for (int num = 0; num < n; num++)
		{
			array2[6 * num] = (short)(num * 4);
			array2[6 * num + 1] = (short)(num * 4 + 1);
			array2[6 * num + 2] = (short)(num * 4 + 2);
			array2[6 * num + 3] = (short)(num * 4);
			array2[6 * num + 4] = (short)(num * 4 + 2);
			array2[6 * num + 5] = (short)(num * 4 + 3);
		}
		l = new IndexBuffer(bu.a, (IndexElementSize)0, n * 6, (BufferUsage)1);
		l.SetData<short>(array2);
	}

	[SpecialName]
	public Color f()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return g;
	}

	[SpecialName]
	public void b(Color A_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		g = A_0;
	}

	public void d()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		if (bu.a != null)
		{
			bu.a.Viewport = new Viewport(m_viewportX, m_viewportY, m_drawWidth, m_drawHeight);
		}
		this.m_c.Begin(this.m_d, this.m_e, i, (DepthStencilState)null, (RasterizerState)null, (Effect)null, (Matrix?)m_spriteTransform);
	}

	public void e()
	{
		this.m_c.End();
	}

	public void b(Vector2 A_0, Vector2 A_1, float A_2)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		Vector2 val = default(Vector2);
		val = new Vector2(0.5f, 0f);
		Vector2 val2 = A_1 - A_0;
		Vector2 val3 = default(Vector2);
		val3 = new Vector2(A_2, val2.Length() / (float)h.Height);
		float num = (float)Math.Atan2(val2.Y, val2.X) - (float)Math.PI / 2f;
		this.m_c.Draw(h, A_0, (Rectangle?)null, g, num, val, val3, (SpriteEffects)0, 1f);
	}

	public void b(float A_0, float A_1, float A_2, float A_3)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		this.b(new Rectangle((int)A_0, (int)A_1, (int)A_2, (int)A_3));
	}

	public void b(Rectangle A_0)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		if (A_0.X <= 0 && A_0.X + A_0.Width >= 800 && VisibleOffsetX < -0.01f)
		{
			A_0.X = (int)VisibleOffsetX;
			A_0.Width = (int)VisibleWidth;
		}
		if (A_0.Y <= 0 && A_0.Y + A_0.Height >= 480 && VisibleHeight > 480.5f)
		{
			A_0.Y = (int)VisibleOffsetY;
			A_0.Height = (int)VisibleHeight;
		}
		this.m_c.Draw(h, A_0, g);
	}

	public void b(ae A_0, float A_1, float A_2)
	{
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		s.X = A_1;
		s.Y = A_2;
		t.X = A_0.e;
		t.Y = A_0.f;
		u.X = 1f;
		u.Y = 1f;
		v.X = A_0.a;
		v.Y = A_0.b;
		v.Width = A_0.c;
		v.Height = A_0.d;
		this.m_c.Draw(A_0.g.b(), s, (Rectangle?)v, g, 0f, t, u, this.m_f, 0f);
	}

	public void b(ae A_0, float A_1, float A_2, float A_3, float A_4)
	{
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		s.X = A_1;
		s.Y = A_2;
		t.X = A_0.e;
		t.Y = A_0.f;
		u.X = A_3;
		u.Y = A_4;
		v.X = A_0.a;
		v.Y = A_0.b;
		v.Width = A_0.c;
		v.Height = A_0.d;
		if (Math.Abs(A_1) <= 0.5f && Math.Abs(A_2) <= 0.5f && Math.Abs(A_3 - 1f) <= 0.01f && Math.Abs(A_4 - 1f) <= 0.01f && A_0.c >= 796 && A_0.c <= 804 && A_0.d >= 476 && A_0.d <= 484)
		{
			float ox = VisibleOffsetX;
			float oy = VisibleOffsetY;
			if (ox < -0.01f || VisibleHeight > 480.5f)
			{
				s.X = ox;
				s.Y = oy;
				u.X = VisibleWidth / (float)A_0.c;
				u.Y = VisibleHeight / (float)A_0.d;
			}
		}
		this.m_c.Draw(A_0.g.b(), s, (Rectangle?)v, g, 0f, t, u, this.m_f, 0f);
	}

	public void b(ae A_0, float A_1, float A_2, float A_3, float A_4, float A_5)
	{
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		s.X = A_1;
		s.Y = A_2;
		t.X = A_0.e;
		t.Y = A_0.f;
		u.X = A_3;
		u.Y = A_4;
		v.X = A_0.a;
		v.Y = A_0.b;
		v.Width = A_0.c;
		v.Height = A_0.d;
		this.m_c.Draw(A_0.g.b(), s, (Rectangle?)v, g, A_5, t, u, this.m_f, 0f);
	}

	public void b(ae A_0, float A_1, float A_2, Rectangle A_3, float A_4, float A_5, float A_6)
	{
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		s.X = A_1;
		s.Y = A_2;
		t.X = A_0.e;
		t.Y = A_0.f;
		u.X = A_4;
		u.Y = A_5;
		A_3.X += A_0.a;
		A_3.Y += A_0.b;
		this.m_c.Draw(A_0.g.b(), s, (Rectangle?)A_3, g, A_6, t, u, this.m_f, 0f);
	}

	public void b(ae A_0, float A_1, float A_2, float A_3, float A_4, float A_5, int A_6, int A_7)
	{
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		s.X = A_1;
		s.Y = A_2;
		t.X = A_6;
		t.Y = A_7;
		u.X = A_3;
		u.Y = A_4;
		v.X = A_0.a;
		v.Y = A_0.b;
		v.Width = A_0.c;
		v.Height = A_0.d;
		this.m_c.Draw(A_0.g.b(), s, (Rectangle?)v, g, A_5, t, u, this.m_f, 0f);
	}

	internal void b(ae A_0, float A_1, float A_2, float A_3)
	{
		c();
		x = A_0.g.b();
		aa = A_1;
		ab = 1f / (aa * (float)x.Width);
		ac = 1f / (aa * (float)x.Height);
		y = A_2 / (float)x.Width;
		z = A_3 / (float)x.Height;
		bu.a.BlendState = this.m_e;
	}

	internal void c(ae A_0, float A_1, float A_2, float A_3)
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0549: Unknown result type (might be due to invalid IL or missing references)
		//IL_054e: Unknown result type (might be due to invalid IL or missing references)
		//IL_05da: Unknown result type (might be due to invalid IL or missing references)
		//IL_05df: Unknown result type (might be due to invalid IL or missing references)
		//IL_066e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0673: Unknown result type (might be due to invalid IL or missing references)
		//IL_0705: Unknown result type (might be due to invalid IL or missing references)
		//IL_070a: Unknown result type (might be due to invalid IL or missing references)
		if (w != A_0.g.b())
		{
			c();
			w = A_0.g.b();
			ad = 1f / (float)w.Width;
			ae = 1f / (float)w.Height;
		}
		Vector2 val = default(Vector2);
		val.X = 0f;
		val.Y = 0f;
		Vector2 val2 = val;
		Vector2 val3 = default(Vector2);
		val3.X = A_0.c;
		val3.Y = 0f;
		Vector2 val4 = val3;
		Vector2 val5 = default(Vector2);
		val5.X = A_0.c;
		val5.Y = A_0.d;
		Vector2 val6 = val5;
		Vector2 val7 = default(Vector2);
		val7.X = 0f;
		val7.Y = A_0.d;
		Vector2 val8 = val7;
		float num = A_0.e;
		float num2 = A_0.f;
		val2.X -= num;
		val2.Y -= num2;
		val4.X -= num;
		val4.Y -= num2;
		val6.X -= num;
		val6.Y -= num2;
		val8.X -= num;
		val8.Y -= num2;
		val2.X *= aa;
		val2.Y *= aa;
		val4.X *= aa;
		val4.Y *= aa;
		val6.X *= aa;
		val6.Y *= aa;
		val8.X *= aa;
		val8.Y *= aa;
		float num3;
		for (num3 = A_3; (double)num3 < -3.14159265; num3 += (float)Math.PI * 2f)
		{
		}
		while ((double)num3 > 3.14159265)
		{
			num3 -= (float)Math.PI * 2f;
		}
		float num4;
		if (num3 < 0f)
		{
			num4 = 4f / (float)Math.PI * num3 + 0.40528473f * num3 * num3;
			num4 = ((!(num4 < 0f)) ? (0.225f * (num4 * num4 - num4) + num4) : (0.225f * (num4 * (0f - num4) - num4) + num4));
		}
		else
		{
			num4 = 4f / (float)Math.PI * num3 - 0.40528473f * num3 * num3;
			num4 = ((!(num4 < 0f)) ? (0.225f * (num4 * num4 - num4) + num4) : (0.225f * (num4 * (0f - num4) - num4) + num4));
		}
		num3 += (float)Math.PI / 2f;
		if ((double)num3 > 3.14159265)
		{
			num3 -= (float)Math.PI * 2f;
		}
		float num5;
		if (num3 < 0f)
		{
			num5 = 4f / (float)Math.PI * num3 + 0.40528473f * num3 * num3;
			num5 = ((!(num5 < 0f)) ? (0.225f * (num5 * num5 - num5) + num5) : (0.225f * (num5 * (0f - num5) - num5) + num5));
		}
		else
		{
			num5 = 4f / (float)Math.PI * num3 - 0.40528473f * num3 * num3;
			num5 = ((!(num5 < 0f)) ? (0.225f * (num5 * num5 - num5) + num5) : (0.225f * (num5 * (0f - num5) - num5) + num5));
		}
		float num6 = val2.X * num5 - val2.Y * num4 + A_1;
		float num7 = val2.X * num4 + val2.Y * num5 + A_2;
		val2.X = num6;
		val2.Y = num7;
		num6 = val4.X * num5 - val4.Y * num4 + A_1;
		num7 = val4.X * num4 + val4.Y * num5 + A_2;
		val4.X = num6;
		val4.Y = num7;
		num6 = val6.X * num5 - val6.Y * num4 + A_1;
		num7 = val6.X * num4 + val6.Y * num5 + A_2;
		val6.X = num6;
		val6.Y = num7;
		num6 = val8.X * num5 - val8.Y * num4 + A_1;
		num7 = val8.X * num4 + val8.Y * num5 + A_2;
		val8.X = num6;
		val8.Y = num7;
		NestedStructA a10 = default(NestedStructA);
		NestedStructA a11 = default(NestedStructA);
		NestedStructA a12 = default(NestedStructA);
		NestedStructA a13 = default(NestedStructA);
		float num8 = (float)A_0.a * ad;
		float num9 = (float)A_0.b * ad;
		float num10 = (float)A_0.c * ad;
		float num11 = (float)A_0.d * ad;
		a10.a.X = val2.X;
		a10.a.Y = val2.Y;
		a10.b = g;
		a10.c.X = num8;
		a10.c.Y = num9;
		a10.d.X = y + val2.X * ab;
		a10.d.Y = z + val2.Y * ac;
		a11.a.X = val4.X;
		a11.a.Y = val4.Y;
		a11.b = g;
		a11.c.X = num8 + num10;
		a11.c.Y = num9;
		a11.d.X = y + val4.X * ab;
		a11.d.Y = z + val4.Y * ac;
		a12.a.X = val6.X;
		a12.a.Y = val6.Y;
		a12.b = g;
		a12.c.X = num8 + num10;
		a12.c.Y = num9 + num11;
		a12.d.X = y + val6.X * ab;
		a12.d.Y = z + val6.Y * ac;
		a13.a.X = val8.X;
		a13.a.Y = val8.Y;
		a13.b = g;
		a13.c.X = num8;
		a13.c.Y = num9 + num11;
		a13.d.X = y + val8.X * ab;
		a13.d.Y = z + val8.Y * ac;
		o[p * 4] = a10;
		o[p * 4 + 1] = a11;
		o[p * 4 + 2] = a12;
		o[p * 4 + 3] = a13;
		p++;
	}

	internal void c()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (p != 0)
		{
			SetDataOptions val = (SetDataOptions)2;
			if (q + p > n)
			{
				q = 0;
				val = (SetDataOptions)1;
			}
			k.SetData<NestedStructA>(q * 4 * r, o, 0, 4 * p, r, val);
			j.Texture2 = x;
			j.Texture = w;
			if (bu.a != null)
			{
				bu.a.Viewport = new Viewport(m_viewportX, m_viewportY, m_drawWidth, m_drawHeight);
			}
			bu.a.SetVertexBuffer((VertexBuffer)(object)k);
			bu.a.Indices = l;
			foreach (EffectPass pass in ((Effect)j).CurrentTechnique.Passes)
			{
				pass.Apply();
				bu.a.DrawIndexedPrimitives((PrimitiveType)0, 4 * q, 0, 4 * p, 0, 2 * p);
			}
			q += p;
		}
		p = 0;
	}

	public void UpdateViewport(int backBufferWidth, int backBufferHeight, int windowWidth, int windowHeight)
	{
		m_backBufferWidth = Math.Max(1, backBufferWidth);
		m_backBufferHeight = Math.Max(1, backBufferHeight);
		float winW = Math.Max(1f, (float)windowWidth);
		float winH = Math.Max(1f, (float)windowHeight);

		float scale = MathHelper.Max(0.001f, Math.Min(winW / 800f, winH / 480f));
		m_contentScale = scale;
		m_visibleWidth = winW / scale;
		m_visibleHeight = winH / scale;
		m_visibleOffsetX = (800f - m_visibleWidth) / 2f;
		m_visibleOffsetY = 0f;
		m_drawWidth = m_backBufferWidth;
		m_drawHeight = m_backBufferHeight;
		m_viewportX = 0;
		m_viewportY = 0;

		float compX = (float)m_backBufferWidth / winW;
		float compY = (float)m_backBufferHeight / winH;
		float sx = scale * compX;
		float sy = scale * compY;
		m_spriteTransform = Matrix.CreateScale(sx, sy, 1f) * Matrix.CreateTranslation(0f - m_visibleOffsetX * sx, 0f - m_visibleOffsetY * sy, 0f);

		Matrix projection = Matrix.CreateOrthographicOffCenter(m_visibleOffsetX, m_visibleOffsetX + m_visibleWidth, m_visibleOffsetY + m_visibleHeight, m_visibleOffsetY, 0f, 1f);
		Matrix halfPixel = Matrix.CreateTranslation(-0.5f, -0.5f, 0f);
		if (j != null)
		{
			j.Projection = halfPixel * projection;
		}

		if (bu.a != null)
		{
			bu.a.Viewport = new Viewport(m_viewportX, m_viewportY, m_drawWidth, m_drawHeight);
		}
	}

	public void ClearBackBuffer(Color color)
	{
		if (bu.a == null)
		{
			return;
		}

		bu.a.SetRenderTarget(null);
		bu.a.Viewport = new Viewport(m_viewportX, m_viewportY, m_drawWidth, m_drawHeight);
		bu.a.Clear(color);
	}

	public void EndFrame()
	{
	}

	public static float AnchorShiftX(float x, float width)
	{
		float ox = VisibleOffsetX;
		if (ox >= -0.01f)
		{
			return 0f;
		}
		if (Math.Abs(x) <= 44f)
		{
			return ox;
		}
		if (Math.Abs(x + width - 800f) <= 44f)
		{
			return 0f - ox;
		}
		if (Math.Abs(x - 800f) <= 44f)
		{
			return 0f - ox;
		}
		return 0f;
	}

	public static float AnchorShiftY(float y, float height)
	{
		float extra = VisibleOffsetY + VisibleHeight - 480f;
		if (extra <= 0.01f)
		{
			return 0f;
		}
		if (Math.Abs(y) <= 44f)
		{
			return VisibleOffsetY;
		}
		if (Math.Abs(y + height - 480f) <= 44f)
		{
			return extra;
		}
		if (Math.Abs(y - 480f) <= 44f)
		{
			return extra;
		}
		return 0f;
	}

	public static float CanvasRight
	{
		get
		{
			return VisibleOffsetX + VisibleWidth;
		}
	}

	internal static bool AllowStretch;
}
