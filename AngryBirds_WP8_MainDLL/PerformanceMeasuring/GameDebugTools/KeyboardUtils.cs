using System.Collections.Generic;
using Microsoft.Xna.Framework.Input;

namespace PerformanceMeasuring.GameDebugTools;

public static class KeyboardUtils
{
	private class NestedClassA
	{
		public char a;

		public char? b;

		public NestedClassA(char A_0, char? A_1)
		{
			a = A_0;
			b = A_1;
		}
	}

	private static Dictionary<Keys, NestedClassA> m_a;

	public static bool KeyToString(Keys key, bool shitKeyPressed, out char character)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between I4 and Unknown
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Invalid comparison between Unknown and I4
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Invalid comparison between Unknown and I4
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		bool result = false;
		character = ' ';
		NestedClassA value;
		if ((65 <= (int)key && (int)key <= 90) || (int)key == 32)
		{
			character = (shitKeyPressed ? ((char)key) : char.ToLower((char)key));
			result = true;
		}
		else if (KeyboardUtils.m_a.TryGetValue(key, out value))
		{
			if (!shitKeyPressed)
			{
				character = value.a;
				result = true;
			}
			else if (value.b.HasValue)
			{
				character = value.b.Value;
				result = true;
			}
		}
		return result;
	}

	static KeyboardUtils()
	{
		KeyboardUtils.m_a = new Dictionary<Keys, NestedClassA>();
		a();
	}

	private static void a()
	{
		a((Keys)192, "`~");
		a((Keys)49, "1!");
		a((Keys)50, "2@");
		a((Keys)51, "3#");
		a((Keys)52, "4$");
		a((Keys)53, "5%");
		a((Keys)54, "6^");
		a((Keys)55, "7&");
		a((Keys)56, "8*");
		a((Keys)57, "9(");
		a((Keys)48, "0)");
		a((Keys)189, "-_");
		a((Keys)187, "=+");
		a((Keys)219, "[{");
		a((Keys)221, "]}");
		a((Keys)220, "\\|");
		a((Keys)186, ";:");
		a((Keys)222, "'\"");
		a((Keys)188, ",<");
		a((Keys)190, ".>");
		a((Keys)191, "/?");
		a((Keys)97, "1");
		a((Keys)98, "2");
		a((Keys)99, "3");
		a((Keys)100, "4");
		a((Keys)101, "5");
		a((Keys)102, "6");
		a((Keys)103, "7");
		a((Keys)104, "8");
		a((Keys)105, "9");
		a((Keys)96, "0");
		a((Keys)107, "+");
		a((Keys)111, "/");
		a((Keys)106, "*");
		a((Keys)109, "-");
		a((Keys)110, ".");
	}

	private static void a(Keys A_0, string A_1)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		char a_ = A_1[0];
		char? a_2 = null;
		if (A_1.Length > 1)
		{
			a_2 = A_1[1];
		}
		KeyboardUtils.m_a.Add(A_0, new NestedClassA(a_, a_2));
	}
}
