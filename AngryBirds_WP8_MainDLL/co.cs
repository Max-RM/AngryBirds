using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

internal class co
{
	private KeyValuePair<char, ae>[] m_a;

	private ca b;

	private int c;

	private int d;

	private int e;

	private int f;

	private int g;

	public co(string A_0)
	{
		d = 0;
		e = 0;
		g = 0;
		Stream stream = TitleContainer.OpenStream(A_0);
		BinaryReader binaryReader = new BinaryReader(stream);
		uint num = (uint)cq.b(binaryReader);
		if (num == di.d('K', 'A', '3', 'D'))
		{
			uint num2 = (uint)cq.b(binaryReader);
			if (num2 > cq.a(stream))
			{
				throw new Exception("Malformed KA3D file: " + A_0);
			}
			while (cq.a(stream) > 0)
			{
				num = (uint)cq.b(binaryReader);
				num2 = (uint)cq.b(binaryReader);
				uint num3 = num;
				if (num3 == 1179602516)
				{
					int num4 = cq.a(binaryReader);
					if (num4 != 1)
					{
						continue;
					}
					cq.c(binaryReader);
					string directoryName = Path.GetDirectoryName(A_0);
					string a_ = Path.Combine(directoryName, Path.GetFileNameWithoutExtension(A_0));
					Texture2D a_2 = u.a().j(a_);
					b = new ca(a_2);
					f = cq.a(binaryReader);
					c = cq.a(binaryReader);
					int num5 = cq.a(binaryReader);
					this.m_a = new KeyValuePair<char, ae>[256];
					for (int num6 = 0; num6 < num5; num6++)
					{
						char c10 = (char)cq.a(binaryReader);
						int a_3 = cq.a(binaryReader);
						int a_4 = cq.a(binaryReader);
						int a_5 = cq.a(binaryReader);
						int num7 = cq.a(binaryReader);
						int num8 = cq.a(binaryReader);
						d = Math.Max(d, num8);
						e = Math.Max(e, num7 - num8);
						g = Math.Max(g, num7);
						if (c10 >= this.m_a.Length)
						{
							KeyValuePair<char, ae>[] array = new KeyValuePair<char, ae>[c10 + 100];
							this.m_a.CopyTo(array, 0);
							this.m_a = array;
						}
						ref KeyValuePair<char, ae> reference = ref this.m_a[(uint)c10];
						reference = new KeyValuePair<char, ae>(c10, b.b(c10.ToString(), a_3, a_4, a_5, num7, 0, num8));
					}
				}
				else
				{
					stream.Seek(num2, SeekOrigin.Current);
				}
			}
		}
		else
		{
			stream.Seek(-4L, SeekOrigin.Current);
			cq.c(binaryReader);
			string directoryName2 = Path.GetDirectoryName(A_0);
			string a_6 = Path.Combine(directoryName2, Path.GetFileNameWithoutExtension(A_0));
			Texture2D a_7 = u.a().j(a_6);
			b = new ca(a_7);
			f = cq.a(binaryReader);
			c = cq.a(binaryReader);
			int num9 = cq.a(binaryReader);
			this.m_a = new KeyValuePair<char, ae>[256];
			for (int num10 = 0; num10 < num9; num10++)
			{
				char c11 = (char)cq.a(binaryReader);
				int a_8 = cq.a(binaryReader);
				int a_9 = cq.a(binaryReader);
				int a_10 = cq.a(binaryReader);
				int num11 = cq.a(binaryReader);
				int num12 = cq.a(binaryReader);
				d = Math.Max(d, num12);
				e = Math.Max(e, num11 - num12);
				g = Math.Max(g, num11);
				if (c11 >= this.m_a.Length)
				{
					KeyValuePair<char, ae>[] array2 = new KeyValuePair<char, ae>[c11 + 100];
					this.m_a.CopyTo(array2, 0);
					this.m_a = array2;
				}
				ref KeyValuePair<char, ae> reference2 = ref this.m_a[(uint)c11];
				reference2 = new KeyValuePair<char, ae>(c11, b.b(c11.ToString(), a_8, a_9, a_10, num11, 0, num12));
			}
		}
		binaryReader.Close();
	}

	public void a(string A_0, Vector2 A_1, a7 A_2, float A_3, float A_4, Color A_5)
	{
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		if (A_2.c() == dh.a)
		{
			A_1.Y += (float)d * A_4;
		}
		if (A_2.c() == dh.b)
		{
			A_1.Y += (float)(d - (d + e) / 2) * A_4;
		}
		else if (A_2.c() == dh.c)
		{
			A_1.Y -= (float)e * A_4;
		}
		if (A_2.d() == bn.b)
		{
			A_1.X -= (float)(a(A_0) / 2) * A_3;
		}
		else if (A_2.d() == bn.c)
		{
			A_1.X -= (float)a(A_0) * A_3;
		}
		Color val = bu.b().f();
		if (!A_5.Equals(val))
		{
			bu.b().b(A_5);
		}
		Vector2 val2 = A_1;
		for (int num = 0; num < A_0.Length; num++)
		{
			char c10 = A_0[num];
			switch (c10)
			{
			case '\n':
				val2.Y += (float)g * A_4;
				val2.X = A_1.X;
				continue;
			case '\u00a0':
				c10 = ' ';
				break;
			}
			ae value = this.m_a[(uint)c10].Value;
			if (value != null)
			{
				bu.b().b(value, val2.X, val2.Y, A_3, A_4);
			}
			val2.X += (float)(value.c + c) * A_3;
		}
		if (!A_5.Equals(val))
		{
			bu.b().b(val);
		}
	}

	public void a(string A_0, Vector2 A_1, a7 A_2, float A_3, float A_4)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		a(A_0, A_1, A_2, A_3, A_4, Color.White);
	}

	public void a(string A_0, Vector2 A_1, a7 A_2)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		a(A_0, A_1, A_2, 1f, 1f, Color.White);
	}

	public void a(string A_0, Vector2 A_1, a7 A_2, Color A_3)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		a(A_0, A_1, A_2, 1f, 1f, A_3);
	}

	public int a(string A_0)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		for (int num4 = 0; num4 < A_0.Length; num4++)
		{
			char c10 = A_0[num4];
			switch (c10)
			{
			case '\n':
				num2 = 0;
				num3 = 0;
				continue;
			case '\u00a0':
				c10 = ' ';
				break;
			}
			num3++;
			ae value = this.m_a[(uint)c10].Value;
			if (value != null)
			{
				num2 += value.c;
			}
			if (num2 > num)
			{
				num = num2;
			}
		}
		return num + (num3 - 1) * c;
	}

	public int a()
	{
		return g;
	}
}
