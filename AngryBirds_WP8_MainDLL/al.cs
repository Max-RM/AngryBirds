using System;
using System.IO;
using System.Runtime.CompilerServices;
using AngryBirds.Port;
using Microsoft.Xna.Framework;

internal class al
{
	private static IServiceProvider m_a;

	[SpecialName]
	public static void a(IServiceProvider A_0)
	{
		al.m_a = A_0;
	}

	public static byte[] b(string A_0)
	{
		try
		{
			return DesktopStorage.ReadAllBytes(A_0);
		}
		catch (Exception ex)
		{
			_ = $"Error: {ex.Message}";
			return null;
		}
	}

	public static void a(string A_0, byte[] A_1)
	{
		try
		{
			DesktopStorage.WriteAllBytes(A_0, A_1);
		}
		catch (Exception ex)
		{
			_ = $"Error: {ex.Message}";
		}
	}

	public static string a(string A_0)
	{
		Stream stream = TitleContainer.OpenStream(A_0);
		StreamReader streamReader = new StreamReader(stream);
		string result = streamReader.ReadToEnd();
		streamReader.Close();
		stream.Close();
		return result;
	}

	public static bool a(string A_0, string A_1)
	{
		StringReader stringReader = new StringReader(A_0);
		string text = stringReader.ReadLine();
		text = text.Replace("-- ", "");
		text = text.Replace(" --", "");
		if (text == A_1)
		{
			return true;
		}
		return false;
	}

	public static string a(string A_0, string A_1, string A_2)
	{
		string a_ = a(A_0);
		string text = bs.a(a_, A_1, A_2);
		if (!a(text, Path.GetFileName(A_0)))
		{
			throw new Exception("Invalid data: Files tampered!");
		}
		return text;
	}
}
