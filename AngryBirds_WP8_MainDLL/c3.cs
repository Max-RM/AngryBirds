using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.Xna.Framework;

internal class c3
{
	private string m_a;

	private string[] m_b;

	private Dictionary<string, Dictionary<string, string>> c;

	public c3(string A_0)
	{
		this.m_a = A_0;
		this.m_b = null;
		c = null;
	}

	public Dictionary<string, string> b(string A_0)
	{
		if (Array.IndexOf(this.m_b, A_0) > -1)
		{
			return c[A_0];
		}
		return Enumerable.First<KeyValuePair<string, Dictionary<string, string>>>((IEnumerable<KeyValuePair<string, Dictionary<string, string>>>)c).Value;
	}

	public string[] a()
	{
		return this.m_b;
	}

	public void b()
	{
		using Stream stream = TitleContainer.OpenStream(this.m_a);
		BinaryReader binaryReader = new BinaryReader(stream);
		uint num = (uint)cq.b(binaryReader);
		if (num == di.d('K', 'A', '3', 'D'))
		{
			uint num2 = (uint)cq.b(binaryReader);
			if (num2 > cq.a(stream))
			{
				throw new Exception("Malformed KA3D file: " + this.m_a);
			}
			while (cq.a(stream) > 0)
			{
				num = (uint)cq.b(binaryReader);
				num2 = (uint)cq.b(binaryReader);
				uint num3 = num;
				if (num3 == 1413830740)
				{
					int num4 = cq.a(binaryReader);
					if (num4 != 1)
					{
						continue;
					}
					while (cq.a(stream) > 0)
					{
						uint num5 = (uint)cq.b(binaryReader);
						uint num6 = (uint)cq.b(binaryReader);
						uint num7 = num5;
						if (num7 == 1279541588)
						{
							int num8 = cq.a(binaryReader);
							Dictionary<string, Dictionary<string, string>> dictionary = new Dictionary<string, Dictionary<string, string>>();
							string[] array = new string[num8];
							for (int num9 = 0; num9 < num8; num9++)
							{
								dictionary.Add(array[num9] = cq.c(binaryReader), null);
							}
							this.m_b = array;
							c = dictionary;
						}
						else
						{
							stream.Seek(num6, SeekOrigin.Current);
						}
					}
				}
				else
				{
					stream.Seek(num2, SeekOrigin.Current);
				}
			}
			return;
		}
		try
		{
			stream.Seek(-4L, SeekOrigin.Current);
			binaryReader.ReadByte();
			binaryReader.ReadInt32();
			int num10 = binaryReader.ReadChar();
			Dictionary<string, Dictionary<string, string>> dictionary2 = new Dictionary<string, Dictionary<string, string>>();
			string[] array2 = new string[num10];
			for (int num11 = 0; num11 < num10; num11++)
			{
				dictionary2.Add(array2[num11] = cq.c(binaryReader), null);
			}
			this.m_b = array2;
			c = dictionary2;
		}
		catch (EndOfStreamException ex)
		{
			Console.WriteLine("{0} caught and ignored. Using default values.", ex.GetType().Name);
		}
		finally
		{
			binaryReader.Close();
		}
	}

	public Dictionary<string, string> a(string A_0)
	{
		if (A_0.Equals(dc.c))
		{
			for (int num = 0; num < this.m_b.Length; num++)
			{
				a(this.m_b[num]);
			}
			if (c.Count > 0)
			{
				return Enumerable.First<KeyValuePair<string, Dictionary<string, string>>>((IEnumerable<KeyValuePair<string, Dictionary<string, string>>>)c).Value;
			}
			return null;
		}
		int num2 = Array.IndexOf(this.m_b, A_0);
		using (Stream stream = TitleContainer.OpenStream(this.m_a))
		{
			BinaryReader binaryReader = new BinaryReader(stream);
			uint num3 = (uint)cq.b(binaryReader);
			if (num3 == di.d('K', 'A', '3', 'D'))
			{
				uint num4 = (uint)cq.b(binaryReader);
				if (num4 > cq.a(stream))
				{
					throw new Exception("Malformed KA3D file: " + this.m_a);
				}
				while (cq.a(stream) > 0)
				{
					num3 = (uint)cq.b(binaryReader);
					num4 = (uint)cq.b(binaryReader);
					uint num5 = num3;
					if (num5 == 1413830740)
					{
						int num6 = cq.a(binaryReader);
						if (num6 != 1)
						{
							continue;
						}
						string[] array = null;
						int num7 = 0;
						while (cq.a(stream) > 0)
						{
							uint num8 = (uint)cq.b(binaryReader);
							uint num9 = (uint)cq.b(binaryReader);
							switch (num8)
							{
							case 1279870035u:
							{
								int num11 = cq.a(binaryReader);
								if (array == null)
								{
									array = new string[num11];
								}
								for (int num12 = 0; num12 < num11; num12++)
								{
									array[num12] = cq.c(binaryReader);
								}
								break;
							}
							case 1415071568u:
								if (array.Length == 0)
								{
									throw new Exception("Missing LIDS chunk before TXGP chunk in file " + this.m_a);
								}
								if (num7 == num2)
								{
									Dictionary<string, string> dictionary = new Dictionary<string, string>();
									for (int num10 = 0; num10 < array.Length; num10++)
									{
										dictionary.Add(array[num10], cq.c(binaryReader));
									}
									c[A_0] = dictionary;
									return dictionary;
								}
								stream.Seek(num9, SeekOrigin.Current);
								num7++;
								break;
							default:
								stream.Seek(num9, SeekOrigin.Current);
								break;
							}
						}
					}
					else
					{
						stream.Seek(num4, SeekOrigin.Current);
					}
				}
			}
			else
			{
				try
				{
					stream.Seek(-4L, SeekOrigin.Current);
					binaryReader.ReadByte();
					int count = cq.b(binaryReader);
					binaryReader.ReadBytes(count);
					short num13 = cq.a(binaryReader);
					string[] array2 = new string[num13];
					for (int num14 = 0; num14 < num13; num14++)
					{
						array2[num14] = cq.c(binaryReader);
					}
					binaryReader.ReadBytes(num2 * 4);
					int count2 = cq.b(binaryReader);
					binaryReader.ReadBytes(count2);
					Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
					for (int num15 = 0; num15 < num13; num15++)
					{
						dictionary2.Add(array2[num15], cq.c(binaryReader));
					}
					c[A_0] = dictionary2;
				}
				catch (EndOfStreamException ex)
				{
					Console.WriteLine($"{ex.GetType().Name} caught and ignored. Using default values.");
				}
				finally
				{
					binaryReader.Close();
				}
			}
		}
		return c[A_0];
	}
}
