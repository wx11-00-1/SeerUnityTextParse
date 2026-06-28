using System;

namespace core.config.itemsOptimize
{
	// Token: 0x020028DB RID: 10459
	public class itemsOptimizeCatItem13Def : ItemData
	{
		// Token: 0x06015037 RID: 86071 RVA: 0x0057DBDC File Offset: 0x0057BDDC
		public override int GetID()
		{
			return this.ID;
		}

		// Token: 0x06015038 RID: 86072 RVA: 0x0057DBE4 File Offset: 0x0057BDE4
		public override string GetName()
		{
			return this.Name;
		}

		// Token: 0x06015039 RID: 86073 RVA: 0x0057DBEC File Offset: 0x0057BDEC
		public override int GetMax()
		{
			return this.Max;
		}

		// Token: 0x0601503A RID: 86074 RVA: 0x0057DBF4 File Offset: 0x0057BDF4
		public override int GetCatID()
		{
			return this.catID;
		}

		// Token: 0x0601503B RID: 86075 RVA: 0x0057DBFC File Offset: 0x0057BDFC
		public override int GetBean()
		{
			return this.Bean;
		}

		// Token: 0x0601503C RID: 86076 RVA: 0x0057DC04 File Offset: 0x0057BE04
		public override bool IsHide()
		{
			return this.Hide != 0;
		}

		// Token: 0x0601503D RID: 86077 RVA: 0x0057DC0F File Offset: 0x0057BE0F
		public override bool IsSpecial()
		{
			return this.isSpecial != 0;
		}

		// Token: 0x0601503E RID: 86078 RVA: 0x0057DC1A File Offset: 0x0057BE1A
		public override int Getpurpose()
		{
			return this.purpose;
		}

		// Token: 0x0601503F RID: 86079 RVA: 0x0057DC22 File Offset: 0x0057BE22
		public override int GetSort()
		{
			return this.Sort;
		}

		// Token: 0x06015040 RID: 86080 RVA: 0x0057DC2A File Offset: 0x0057BE2A
		public override float Getspeed()
		{
			return this.speed;
		}

		// Token: 0x06015041 RID: 86081 RVA: 0x0057DC32 File Offset: 0x0057BE32
		public override string Gettype()
		{
			return this.type;
		}

		// Token: 0x06015042 RID: 86082 RVA: 0x0057DC3A File Offset: 0x0057BE3A
		public override int GetUseMax()
		{
			return this.UseMax;
		}

		// Token: 0x06015043 RID: 86083 RVA: 0x0057DC42 File Offset: 0x0057BE42
		public override bool IsSuper()
		{
			return this.VipOnly != 0;
		}

		// Token: 0x06015044 RID: 86084 RVA: 0x0057DC4D File Offset: 0x0057BE4D
		public override int Getwd()
		{
			return this.wd;
		}

		// Token: 0x06015045 RID: 86085 RVA: 0x0057DC58 File Offset: 0x0057BE58
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.catID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Max = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Bean = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Hide = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.isSpecial = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.purpose = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.speed = ByteUtil.ReadFloat(bytes, ref byteIndex);
			this.type = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.UseMax = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.VipOnly = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.wd = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}

		// Token: 0x04013FCC RID: 81868
		public int catID;

		// Token: 0x04013FCD RID: 81869
		public int ID;

		// Token: 0x04013FCE RID: 81870
		public string Name;

		// Token: 0x04013FCF RID: 81871
		public int Max;

		// Token: 0x04013FD0 RID: 81872
		public int Bean;

		// Token: 0x04013FD1 RID: 81873
		public int Hide;

		// Token: 0x04013FD2 RID: 81874
		public int isSpecial;

		// Token: 0x04013FD3 RID: 81875
		public int purpose;

		// Token: 0x04013FD4 RID: 81876
		public int Sort;

		// Token: 0x04013FD5 RID: 81877
		public float speed;

		// Token: 0x04013FD6 RID: 81878
		public string type;

		// Token: 0x04013FD7 RID: 81879
		public int UseMax;

		// Token: 0x04013FD8 RID: 81880
		public int VipOnly;

		// Token: 0x04013FD9 RID: 81881
		public int wd;
	}
}
