using System;

namespace core.config.itemsOptimize
{
	// Token: 0x020028E0 RID: 10464
	public class itemsOptimizeCatItem23Def : ItemData
	{
		// Token: 0x06015082 RID: 86146 RVA: 0x0057E1FA File Offset: 0x0057C3FA
		public override int GetID()
		{
			return this.ID;
		}

		// Token: 0x06015083 RID: 86147 RVA: 0x0057E202 File Offset: 0x0057C402
		public override string GetName()
		{
			return this.Name;
		}

		// Token: 0x06015084 RID: 86148 RVA: 0x0057E20A File Offset: 0x0057C40A
		public override int GetMax()
		{
			return this.Max;
		}

		// Token: 0x06015085 RID: 86149 RVA: 0x0057E212 File Offset: 0x0057C412
		public override int GetCatID()
		{
			return this.catID;
		}

		// Token: 0x06015086 RID: 86150 RVA: 0x0057E21A File Offset: 0x0057C41A
		public override int GetBean()
		{
			return this.Bean;
		}

		// Token: 0x06015087 RID: 86151 RVA: 0x0057E222 File Offset: 0x0057C422
		public override string GetExchangeOutId()
		{
			return this.ExchangeOutId;
		}

		// Token: 0x06015088 RID: 86152 RVA: 0x0057E22A File Offset: 0x0057C42A
		public override string GetExchangeOutCnt()
		{
			return this.ExchangeOutCnt;
		}

		// Token: 0x06015089 RID: 86153 RVA: 0x0057E232 File Offset: 0x0057C432
		public override bool IsHide()
		{
			return this.Hide != 0;
		}

		// Token: 0x0601508A RID: 86154 RVA: 0x0057E23D File Offset: 0x0057C43D
		public override int Geticon()
		{
			return this.icon;
		}

		// Token: 0x0601508B RID: 86155 RVA: 0x0057E245 File Offset: 0x0057C445
		public override int GetLifeTime()
		{
			return this.LifeTime;
		}

		// Token: 0x0601508C RID: 86156 RVA: 0x0057E24D File Offset: 0x0057C44D
		public override int Getpurpose()
		{
			return this.purpose;
		}

		// Token: 0x0601508D RID: 86157 RVA: 0x0057E255 File Offset: 0x0057C455
		public override int GetRarity()
		{
			return this.Rarity;
		}

		// Token: 0x0601508E RID: 86158 RVA: 0x0057E25D File Offset: 0x0057C45D
		public override int GetSort()
		{
			return this.Sort;
		}

		// Token: 0x0601508F RID: 86159 RVA: 0x0057E265 File Offset: 0x0057C465
		public override int Getwd()
		{
			return this.wd;
		}

		// Token: 0x06015090 RID: 86160 RVA: 0x0057E26D File Offset: 0x0057C46D
		public override int GetUseMax()
		{
			return this.UseMax;
		}

		// Token: 0x06015091 RID: 86161 RVA: 0x0057E278 File Offset: 0x0057C478
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.catID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Max = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Bean = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ExchangeOutCnt = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.ExchangeOutId = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Hide = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.icon = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.LifeTime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.purpose = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Rarity = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.wd = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.UseMax = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}

		// Token: 0x0401400D RID: 81933
		public int catID;

		// Token: 0x0401400E RID: 81934
		public int ID;

		// Token: 0x0401400F RID: 81935
		public string Name;

		// Token: 0x04014010 RID: 81936
		public int Max;

		// Token: 0x04014011 RID: 81937
		public int Bean;

		// Token: 0x04014012 RID: 81938
		public string ExchangeOutCnt;

		// Token: 0x04014013 RID: 81939
		public string ExchangeOutId;

		// Token: 0x04014014 RID: 81940
		public int Hide;

		// Token: 0x04014015 RID: 81941
		public int icon;

		// Token: 0x04014016 RID: 81942
		public int LifeTime;

		// Token: 0x04014017 RID: 81943
		public int purpose;

		// Token: 0x04014018 RID: 81944
		public int Rarity;

		// Token: 0x04014019 RID: 81945
		public int Sort;

		// Token: 0x0401401A RID: 81946
		public int wd;

		// Token: 0x0401401B RID: 81947
		public int UseMax;
	}
}
