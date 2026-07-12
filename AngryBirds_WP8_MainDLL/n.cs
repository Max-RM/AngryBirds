using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

internal class n
{
	private double a;

	private double b;

	private double c;

	private double d;

	private double e;

	private double m_f;

	private double m_g;

	private double m_h;

	private double m_i;

	private double m_j;

	private double m_k;

	public double l;

	private double m_m;

	private static int m_n = 200;

	public int o;

	private float p;

	private float q;

	private float r;

	private float s;

	private float t;

	private float u;

	private int v;

	public static float w = 1500f;

	public static float x = 10f;

	public static float y = 15f;

	public static float z = 300f;

	public static double aa = 800f / cf.PhysicsConfig.GetTimestep();

	public static double ab = 480f / cf.PhysicsConfig.GetTimestep();

	public static double ac = 0.0;

	public static double ad = ac + 2.0 * aa;

	public static double ae = ad + 25.0;

	public static double af = ae + 3.0 * aa;

	public static double ag = 0.0 - 5.0 * ab;

	public static int ah = 800;

	public static int ai = 100;

	private float aj;

	private int ak;

	private double al;

	private double am;

	private double an;

	private double ao;

	private double ap;

	private double aq;

	public double ar;

	public double @as;

	private double at;

	private double au;

	private bool av;

	private double aw;

	private double ax;

	private double ay;

	private double az;

	private double a0;

	private double a1;

	private double a2;

	private double a3;

	private double a4;

	private double a5;

	public double a6;

	public bool a7;

	public ct a8;

	public n(bc A_0)
	{
		a = A_0.h.h;
		b = A_0.h.i;
		c = A_0.h.j;
		d = A_0.g.h;
		e = A_0.g.i;
		this.m_f = A_0.g.j;
		am = A_0.j;
		an = A_0.k;
		ap = A_0.l;
		aq = A_0.m;
		al = A_0.h.l;
		ar = (@as = 1.0);
		at = (au = 1.0);
		ao = 0.0 - 480.0 / al;
		this.m_g = a - d;
		this.m_h = b - e;
		this.m_i = c - this.m_f;
		aj = 2000f;
		ak = 1000;
		this.m_m = -1.0;
		this.m_j = a;
		this.m_k = b;
		l = c;
		this.m_m = 10000.0;
		a2 = this.m_j;
		a3 = this.m_k;
		a4 = l;
		a5 = l;
		a7 = true;
		a6 = 20.0;
		o = 1;
	}

	public void f(int A_0)
	{
		i(A_0);
		UpdateCamera();
		k();
		if (@as != ar)
		{
			ar = @as;
		}
		double num = (double)A_0 / 1000.0;
		double num2 = num * 4.5;
		double num3 = this.m_m;
		if (o == 1)
		{
			if (!(Math.Abs(10000.0 - num3) < 10.0))
			{
				num3 = ((!(num3 > 10000.0)) ? (num3 + (double)A_0 * a6) : (10000.0 + (num3 - 10000.0) * (1.0 - num2)));
			}
			else
			{
				num3 = 10000.0;
				h(0);
			}
			this.m_m = num3;
		}
		else if (o == 4)
		{
			a7 = true;
		}
		else if (o == 2)
		{
			if (!(Math.Abs(num3) < 10.0))
			{
				num3 = ((!(num3 < 0.0)) ? (num3 - (double)A_0 * a6) : (num3 * (1.0 - num2)));
			}
			else
			{
				num3 = 0.0;
				h(0);
			}
			this.m_m = num3;
		}
		else if (o == 3)
		{
			j(A_0);
		}
		f(this.m_m, A_0);
	}

	public void UpdateCamera()
	{
		a1 = al + (this.m_f - al) * ar;
		double num = (a1 - al) / (this.m_f - al);
		if (double.IsNaN(num))
		{
			num = 1.0;
		}
		a0 = e * num + b * (1.0 - num);
		double num2 = a0 + 240.0 / a1 / (double)cf.PhysicsConfig.GetTimestep();
		double num3 = 480.0 / (al * 5.0) / (double)cf.PhysicsConfig.GetTimestep();
		if (num2 > num3)
		{
			a0 += num3 - num2;
		}
		az = d;
		double num4 = 400.0 / a1;
		double num5 = az - num4;
		if (num5 < am)
		{
			az = am + num4;
		}
	}

	public void k()
	{
		ay = al + (c - al) * ar;
		ax = b;
		double num = ax + 240.0 / ay / (double)cf.PhysicsConfig.GetTimestep();
		double num2 = 480.0 / (al * 5.0) / (double)cf.PhysicsConfig.GetTimestep();
		if (num > num2)
		{
			ax += num2 - num;
		}
		aw = a;
		double num3 = 400.0 / ay;
		double num4 = aw + num3;
		if (num4 > an)
		{
			aw = an - num3;
		}
	}

	public void f(double A_0, double A_1)
	{
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		double num = 800.0;
		double num2 = 480.0;
		double num3 = am;
		double num4 = an;
		double num5 = A_1 / 1000.0;
		double num6 = num5 * 3.5;
		double num7 = 1.0;
		double num8 = 0.0;
		double num9 = 0.0;
		double value = aw - az;
		if (Math.Abs(value) < 1.0)
		{
			value = 0.0;
		}
		bool flag = true;
		if (this.m_m < 0.0)
		{
			a6 = 0.0;
		}
		if (this.m_m < -1000.0)
		{
			this.m_m = -1000.0;
		}
		if (this.m_m > 10000.0)
		{
			a6 = 0.0;
		}
		if (this.m_m > 11000.0)
		{
			this.m_m = 11000.0;
		}
		if (o != 4 && this.m_g != 0.0)
		{
			if (!a7)
			{
				num6 = 1.0;
			}
			double num10 = A_0 / 10000.0;
			double num11 = a1 + (ay - a1) * num10;
			double num12 = az + (aw - az) * num10;
			double num13 = a0 + (ax - a0) * num10;
			a2 -= (a2 - num12) * num6;
			a3 -= (a3 - num13) * num6;
			if (flag)
			{
				a4 -= (a4 - num11) * num6;
			}
			this.m_j = a2;
			this.m_k = a3;
			l = a4;
		}
		if (o != 4)
		{
			return;
		}
		if (a8 == null)
		{
			if (this.m_m > 0.0)
			{
				h(1);
				ak = 1000;
			}
			else
			{
				h(0);
			}
			return;
		}
		double num14 = a8.c * cf.PhysicsConfig.GetTimestep();
		double num15 = a8.d * cf.PhysicsConfig.GetTimestep();
		double num16 = a8.o.GetLinearVelocity().X * cf.PhysicsConfig.GetTimestep();
		if (num16 > 0.0 && this.m_g != 0.0)
		{
			A_0 += num5 * num16 * 10.0 / this.m_g * 10000.0;
		}
		if (A_0 >= 10000.0)
		{
			A_0 = 10000.0;
			if (a8 == null)
			{
				h(0);
			}
		}
		this.m_m = A_0;
		double num17 = A_0 / 10000.0;
		double num18 = a1 + (ay - a1) * num17;
		double num19 = az + (aw - az) * num17;
		double num20 = a0 + (ax - a0) * num17;
		a4 -= (a4 - num18) * num6;
		a2 -= (a2 - num19) * num6;
		a3 -= (a3 - num20) * num6;
		double val = a2 - num * 0.5 / a4;
		double val2 = a3 - num2 * 0.5 / a4;
		double val3 = a2 + num * 0.5 / a4;
		double val4 = a3 + num2 * 0.5 / a4;
		double num21 = 50f / cf.PhysicsConfig.GetTimestep();
		double val5 = Math.Min(val, num14 - num21);
		double num22 = Math.Min(val2, num15 - num21);
		double val6 = Math.Max(val3, num14 + num21);
		double num23 = Math.Max(val4, num15 + num21);
		val5 = Math.Max(num3, val5);
		val6 = Math.Min(num4, val6);
		double val7 = Math.Abs(num / (val6 - val5));
		double val8 = Math.Abs(num2 / (num23 - num22));
		double num24 = Math.Min(val7, val8) * num7;
		if (num24 > a4)
		{
			num24 = a4;
		}
		num8 = (val6 + val5) * 0.5;
		num9 = (num23 + num22) * 0.5;
		bool flag2 = false;
		if (num8 + num * 0.5 / num24 > num4)
		{
			val6 = num4;
			val5 = val6 - num / num24;
			flag2 = true;
			if (val5 < num3)
			{
				val5 = num3;
			}
		}
		if (num8 - num * 0.5 / num24 < num3)
		{
			val5 = num3;
			val6 = val5 + num / num24;
			flag2 = true;
			if (val6 > num4)
			{
				val6 = num4;
			}
		}
		if (flag2)
		{
			num8 = (val6 + val5) * 0.5;
			num24 = Math.Abs(num / (val6 - val5)) * num7;
		}
		if (num9 - num2 * 0.5 / num24 < ao)
		{
			num9 = ao + num2 * 0.5 / num24;
		}
		this.m_j -= (this.m_j - num8) * num6;
		a5 -= (a5 - num24) * num6;
		l = a5;
		this.m_k -= (this.m_k - num9) * num6;
		if (num14 >= num4 || num14 <= num3)
		{
			a4 = l;
			a2 = this.m_j;
			a3 = this.m_k;
		}
		num24 = Math.Abs(num / (val6 - val5)) * num7;
		if (num9 - num2 * 0.5 / num24 < ao)
		{
			num9 = ao + num2 * 0.5 / num24;
		}
	}

	public void f(float A_0)
	{
		@as = Math.Max(0.0, Math.Min(1.0, @as + (double)A_0));
	}

	public void i(int A_0)
	{
	}

	public void h(int A_0)
	{
		a2 = this.m_j;
		a3 = this.m_k;
		a4 = l;
		a5 = l;
		o = A_0;
		switch (A_0)
		{
		case 2:
			if (a6 == 0.0)
			{
				a6 = 20.0;
			}
			break;
		case 1:
			if (a6 == 0.0)
			{
				a6 = 20.0;
			}
			break;
		case 4:
			av = true;
			at = (au = l);
			break;
		}
	}

	public void g(float A_0, float A_1)
	{
		ak = -1;
		h(3);
		v = 0;
		p = A_0;
		q = A_1;
		r = (t = A_0);
		s = (u = A_1);
		a2 = this.m_j;
		a3 = this.m_k;
		a4 = l;
		a5 = l;
		if (Math.Abs(aw - az) > 0.001)
		{
			this.m_m = (this.m_j - az) / (aw - az) * 10000.0;
		}
	}

	public void j(int A_0)
	{
		double num = this.m_m;
		v += A_0;
		double num2 = r - t;
		if (this.m_g > 0.0)
		{
			num -= num2 / (this.m_g * (double)cf.PhysicsConfig.GetTimestep() * l) * 10000.0;
			a7 = false;
			if (num < 0.0)
			{
				num -= num * 0.3;
				a7 = true;
			}
			if (num > 10000.0)
			{
				num += (10000.0 - num) * 0.3;
				a7 = true;
			}
			this.m_m = num;
		}
		t = r;
	}

	public void h(float A_0, float A_1)
	{
		if (o == 3)
		{
			r = A_0;
		}
	}

	public void f(float A_0, float A_1)
	{
		if (o != 3)
		{
			return;
		}
		h(0);
		r = A_0;
		float num = Math.Abs(r - p) * cf.PhysicsConfig.GetInvTimestep();
		if ((float)v < w && num >= x && num >= y * (float)v / 1000f)
		{
			a6 = (double)num / l / (double)(float)v * 10.0;
			if (r < p)
			{
				h(1);
			}
			else
			{
				h(2);
			}
			a7 = false;
			if (this.m_m < 0.0)
			{
				a7 = true;
			}
			if (this.m_m > 10000.0)
			{
				a7 = true;
			}
		}
		else if ((float)v < z)
		{
			h();
			a6 = 500.0;
			a7 = true;
		}
		else
		{
			j(0);
			g(0);
			a6 = 500.0;
			a7 = true;
		}
	}

	public void h()
	{
		if (o == 1)
		{
			h(2);
		}
		else if (o == 2)
		{
			h(1);
		}
		else if (this.m_m >= 5000.0)
		{
			h(2);
		}
		else if (this.m_m <= 5000.0)
		{
			h(1);
		}
	}

	public void g(int A_0)
	{
		ak = A_0;
		if (this.m_m < 5000.0)
		{
			h(2);
		}
		else
		{
			h(1);
		}
	}

	public void f(double A_0)
	{
		@as = A_0;
	}

	public void g(ref Vector2 A_0)
	{
		A_0.X = (A_0.X * cf.PhysicsConfig.GetTimestep() - i()) * m();
		A_0.Y = (A_0.Y * cf.PhysicsConfig.GetTimestep() - j()) * m();
	}

	public void f(ref float A_0, ref float A_1)
	{
		A_0 = (A_0 * cf.PhysicsConfig.GetTimestep() - i()) * m();
		A_1 = (A_1 * cf.PhysicsConfig.GetTimestep() - j()) * m();
	}

	public void f(ref Vector2 A_0)
	{
		A_0.X = (A_0.X / m() + i()) * cf.PhysicsConfig.GetInvTimestep();
		A_0.Y = (A_0.Y / m() + j()) * cf.PhysicsConfig.GetInvTimestep();
	}

	[SpecialName]
	public float i()
	{
		float num = 400f / m();
		return (float)this.m_j - num;
	}

	[SpecialName]
	public float j()
	{
		float num = 240f / m();
		return (float)this.m_k - num;
	}

	[SpecialName]
	public float m()
	{
		return (float)l;
	}

	[SpecialName]
	public float g()
	{
		return (float)this.m_j;
	}

	[SpecialName]
	public float f()
	{
		return (float)this.m_k;
	}
}
