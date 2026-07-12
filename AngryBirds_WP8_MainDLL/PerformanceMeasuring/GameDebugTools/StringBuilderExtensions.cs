using System;
using System.Globalization;
using System.Text;

namespace PerformanceMeasuring.GameDebugTools;

public static class StringBuilderExtensions
{
	private static int[] m_a = CultureInfo.CurrentCulture.NumberFormat.NumberGroupSizes;

	private static char[] b = new char[32];

	public static void AppendNumber(this StringBuilder builder, int number)
	{
		a(builder, number, 0, AppendNumberOptions.None);
	}

	public static void AppendNumber(this StringBuilder builder, int number, AppendNumberOptions options)
	{
		a(builder, number, 0, options);
	}

	public static void AppendNumber(this StringBuilder builder, float number)
	{
		builder.AppendNumber(number, 2, AppendNumberOptions.None);
	}

	public static void AppendNumber(this StringBuilder builder, float number, AppendNumberOptions options)
	{
		builder.AppendNumber(number, 2, options);
	}

	public static void AppendNumber(this StringBuilder builder, float number, int decimalCount, AppendNumberOptions options)
	{
		if (float.IsNaN(number))
		{
			builder.Append("NaN");
			return;
		}
		if (float.IsNegativeInfinity(number))
		{
			builder.Append("-Infinity");
			return;
		}
		if (float.IsPositiveInfinity(number))
		{
			builder.Append("+Infinity");
			return;
		}
		int a_ = (int)(number * (float)Math.Pow(10.0, decimalCount) + 0.5f);
		a(builder, a_, decimalCount, options);
	}

	private static void a(StringBuilder A_0, int A_1, int A_2, AppendNumberOptions A_3)
	{
		NumberFormatInfo numberFormat = CultureInfo.CurrentCulture.NumberFormat;
		int num = b.Length;
		int num2 = num - A_2;
		if (num2 == num)
		{
			num2 = num + 1;
		}
		int num3 = 0;
		int num4 = StringBuilderExtensions.m_a[num3] + A_2;
		bool flag = (A_3 & AppendNumberOptions.NumberGroup) != 0;
		bool flag2 = (A_3 & AppendNumberOptions.PositiveSign) != 0;
		bool flag3 = A_1 < 0;
		A_1 = Math.Abs(A_1);
		do
		{
			if (num == num2)
			{
				b[--num] = numberFormat.NumberDecimalSeparator[0];
			}
			if (--num4 < 0 && flag)
			{
				b[--num] = numberFormat.NumberGroupSeparator[0];
				if (num3 < StringBuilderExtensions.m_a.Length - 1)
				{
					num3++;
				}
				num4 = StringBuilderExtensions.m_a[num3] - 1;
			}
			b[--num] = (char)(48 + A_1 % 10);
			A_1 /= 10;
		}
		while (A_1 > 0 || num2 <= num);
		if (flag3)
		{
			b[--num] = numberFormat.NegativeSign[0];
		}
		else if (flag2)
		{
			b[--num] = numberFormat.PositiveSign[0];
		}
		A_0.Append(b, num, b.Length - num);
	}
}
