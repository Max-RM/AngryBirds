using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;

internal class da : ck
{
	private bool a8;

	private int a9;

	private int ba;

	private float bb_rawX;

	private float bb_rawY;

	private float bb_shiftX;

	private float bb_shiftY;

	private float bb_lastX;

	private float bb_lastY;

	private int bb_motionFrames;

	private bool bb_hasLast;

	private bool bb_stretch;

	public bool bb_stretchEdges;

	internal static bool bb_inUnit;

	[CompilerGenerated]
	private ae bb;

	[CompilerGenerated]
	private float bc;

	[CompilerGenerated]
	private float bd;

	[CompilerGenerated]
	private float be;

	[SpecialName]
	public int bi()
	{
		return a9;
	}

	[SpecialName]
	public void ag(int A_0)
	{
		a9 = A_0;
		a8 = true;
	}

	[SpecialName]
	public int bk()
	{
		return ba;
	}

	[SpecialName]
	public void ai(int A_0)
	{
		ba = A_0;
		a8 = true;
	}

	[SpecialName]
	[CompilerGenerated]
	public ae bf()
	{
		return bb;
	}

	[SpecialName]
	[CompilerGenerated]
	public void i(ae A_0)
	{
		bb = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public float bj()
	{
		return bc;
	}

	[SpecialName]
	[CompilerGenerated]
	public void i(float A_0)
	{
		bc = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public float bh()
	{
		return bd;
	}

	[SpecialName]
	[CompilerGenerated]
	public void ai(float A_0)
	{
		bd = A_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public float bg()
	{
		return be;
	}

	[SpecialName]
	[CompilerGenerated]
	public void ag(float A_0)
	{
		be = A_0;
	}

	public da()
	{
		i(1f);
		ai(1f);
		ag(0f);
		i(null);
	}

	public override bool Hit(Vector2 A_0)
	{
		return Hit((int)A_0.X, (int)A_0.Y);
	}

	public override bool Hit(int A_0, int A_1)
	{
		if (base.ab != null)
		{
			float num3 = (float)A_0 - this.bb_shiftX;
			float num4 = (float)A_1 - this.bb_shiftY;
			return base.Hit((int)num3, (int)num4);
		}
		if (bf() == null)
		{
			return false;
		}
		int num = bi();
		int num2 = bk();
		if (!a8)
		{
			num = bf().e;
			num2 = bf().f;
		}
		float num5 = (float)A_0 - this.bb_shiftX;
		float num6 = (float)A_1 - this.bb_shiftY;
		float num7 = base.af + aj;
		float num8 = base.ah + ((ck)this).ak;
		if ((float)num5 >= num7 - (float)num * bj() && (float)num5 <= num7 + ((float)bf().c * bj() - (float)num * bj()) && (float)num6 >= num8 - (float)num2 * bh())
		{
			return (float)num6 <= num8 + ((float)bf().d * bh() - (float)num2 * bh());
		}
		return false;
	}

	public override void i()
	{
		if (bf() != null)
		{
			this.bb_rawX = base.af + aj;
			this.bb_rawY = base.ah + ((ck)this).ak;
			if (!a8 && ((ck)this).m_anchorEnabled && !((ck)this).isChild)
			{
				if (this.bb_hasLast)
				{
					float dx = Math.Abs(this.bb_rawX - this.bb_lastX);
					float dy = Math.Abs(this.bb_rawY - this.bb_lastY);
					if (dx > 0.4f || dy > 0.4f)
					{
						this.bb_motionFrames = 3;
					}
					else if (this.bb_motionFrames > 0)
					{
						this.bb_motionFrames--;
					}
				}
				this.bb_lastX = this.bb_rawX;
				this.bb_lastY = this.bb_rawY;
				this.bb_hasLast = true;
				float texW = (float)bf().c * bj();
				float texH = (float)bf().d * bh();
				float orgX = (a8 ? (float)bi() : (float)bf().e) * bj();
				float orgY = (a8 ? (float)bk() : (float)bf().f) * bh();
				if (this.bb_motionFrames == 0)
				{
					float shiftX = bu.AnchorShiftX(this.bb_rawX - orgX, texW);
					float shiftY = bu.AnchorShiftY(this.bb_rawY - orgY, texH);
					this.bb_shiftX = shiftX;
					this.bb_shiftY = shiftY;
					this.bb_stretch = (texW >= 796f && texW <= 804f && Math.Abs(this.bb_rawX - orgX) <= 2f && bu.VisibleWidth > 800.5f);
				}
				else
				{
					this.bb_shiftX = 0f;
					this.bb_shiftY = 0f;
					this.bb_stretch = false;
				}
			}
			else
			{
				this.bb_shiftX = 0f;
				this.bb_shiftY = 0f;
				this.bb_stretch = false;
			}
			float num = base.af + this.bb_shiftX;
			float num2 = base.ah + this.bb_shiftY;
			num += aj;
			num2 += ((ck)this).ak;
			if (a8)
			{
				bu.b().b(bf(), num, num2, bj(), bh(), bg(), a9, ba);
			}
			else if (this.bb_stretch)
			{
				float texH2 = (float)bf().d * bh();
				float orgX2 = (a8 ? (float)bi() : (float)bf().e) * bj();
				float orgY2 = (a8 ? (float)bk() : (float)bf().f) * bh();
				float left = num - orgX2;
				float top = num2 - orgY2;
				float visH;
				if (texH2 < 476f)
				{
					visH = texH2;
				}
				else
				{
					visH = bu.VisibleHeight;
					if (visH < 480.5f)
					{
						visH = 480f;
					}
				}
				bu.b().b(bf(), left + bu.VisibleOffsetX, top + bu.VisibleOffsetY, bu.VisibleWidth / (float)bf().c, visH / (float)bf().d, bg());
			}
			else
			{
				if (this.bb_stretchEdges)
				{
					float barOrgX2 = (a8 ? (float)bi() : (float)bf().e) * bj();
					float leftEdge = this.bb_rawX - barOrgX2;
					bu.b().b(bf(), leftEdge + bu.VisibleOffsetX + (float)bf().e, num2, bu.VisibleWidth / (float)bf().c, bh(), bg());
				}
				else
				{
					bu.b().b(bf(), num, num2, bj(), bh(), bg());
				}
			}
		}
	}
}
