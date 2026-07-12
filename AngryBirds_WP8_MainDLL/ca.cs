using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

internal class ca
{
	private Texture2D a;

	private Dictionary<string, ae> m_b;

	public ca(Texture2D A_0)
	{
		a = A_0;
		this.m_b = new Dictionary<string, ae>();
	}

	public ca(string A_0)
	{
		b(A_0, A_1: false, A_2: true);
	}

	public ca(string A_0, bool A_1)
	{
		b(A_0, A_1, A_2: false);
	}

	public void b(string A_0, bool A_1, bool A_2)
	{
		this.m_b = new Dictionary<string, ae>();
		Stream stream = TitleContainer.OpenStream(A_0);
		BinaryReader binaryReader = new BinaryReader(stream);
		uint num = (uint)cq.b(binaryReader);
		if (num == di.d('K', 'A', '3', 'D'))
		{
			uint num2 = (uint)cq.b(binaryReader);
			while (cq.a(stream) > 0)
			{
				num = (uint)cq.b(binaryReader);
				num2 = (uint)cq.b(binaryReader);
				if (num2 > cq.a(stream))
				{
					throw new Exception("Malformed KA3D file: " + A_0);
				}
				uint num3 = num;
				if (num3 == 1397772884)
				{
					int num4 = cq.a(binaryReader);
					if (num4 == 1)
					{
						cq.c(binaryReader);
						string directoryName = Path.GetDirectoryName(A_0);
						string a_ = Path.Combine(directoryName, Path.GetFileNameWithoutExtension(A_0));
						if (A_2)
						{
							a = u.a().j(a_);
						}
						else
						{
							a = u.a().b(a_, A_1);
						}
						int num5 = cq.a(binaryReader);
						for (int num6 = 0; num6 < num5; num6++)
						{
							string key = cq.c(binaryReader);
							int a_2 = cq.a(binaryReader);
							int a_3 = cq.a(binaryReader);
							int a_4 = cq.a(binaryReader);
							int a_5 = cq.a(binaryReader);
							int a_6 = cq.a(binaryReader);
							int a_7 = cq.a(binaryReader);
							this.m_b.Add(key, new ae(this, a_2, a_3, a_4, a_5, a_6, a_7));
						}
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
			string a_8 = Path.Combine(directoryName2, Path.GetFileNameWithoutExtension(A_0));
			if (A_2)
			{
				a = u.a().j(a_8);
			}
			else
			{
				a = u.a().b(a_8, A_1);
			}
			int num7 = cq.a(binaryReader);
			for (int num8 = 0; num8 < num7; num8++)
			{
				string key2 = cq.c(binaryReader);
				int a_9 = cq.a(binaryReader);
				int a_10 = cq.a(binaryReader);
				int a_11 = cq.a(binaryReader);
				int a_12 = cq.a(binaryReader);
				int a_13 = cq.a(binaryReader);
				int a_14 = cq.a(binaryReader);
				this.m_b.Add(key2, new ae(this, a_9, a_10, a_11, a_12, a_13, a_14));
			}
			binaryReader.Close();
		}
	}

	[SpecialName]
	public Texture2D b()
	{
		return a;
	}

	public void b(df A_0)
	{
		if (!A_0.a(((GraphicsResource)a).Name))
		{
			((GraphicsResource)a).Dispose();
		}
		a = null;
	}

	public ae b(string A_0, int A_1, int A_2, int A_3, int A_4, int A_5, int A_6)
	{
		ae ae2 = new ae(this, A_1, A_2, A_3, A_4, A_5, A_6);
		this.m_b.Add(A_0, ae2);
		return ae2;
	}

	public ae b(string A_0)
	{
		if (this.m_b.ContainsKey(A_0))
		{
			return this.m_b[A_0];
		}
		return null;
	}
}
