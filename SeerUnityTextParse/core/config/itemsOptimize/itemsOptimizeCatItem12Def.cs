using System;

namespace core.config.itemsOptimize
{
	// Token: 0x020028DA RID: 10458
	public class itemsOptimizeCatItem12Def : ItemData
	{
		// Token: 0x06015029 RID: 86057 RVA: 0x0057DAC4 File Offset: 0x0057BCC4
		public override int GetID()
		{
			return this.ID;
		}

		// Token: 0x0601502A RID: 86058 RVA: 0x0057DACC File Offset: 0x0057BCCC
		public override string GetName()
		{
			return this.Name;
		}

		// Token: 0x0601502B RID: 86059 RVA: 0x0057DAD4 File Offset: 0x0057BCD4
		public override int GetMax()
		{
			return this.Max;
		}

		// Token: 0x0601502C RID: 86060 RVA: 0x0057DADC File Offset: 0x0057BCDC
		public override int GetCatID()
		{
			return this.catID;
		}

		// Token: 0x0601502D RID: 86061 RVA: 0x0057DAE4 File Offset: 0x0057BCE4
		public override int GetBean()
		{
			return 0;
		}

		// Token: 0x0601502E RID: 86062 RVA: 0x0057DAE7 File Offset: 0x0057BCE7
		public override int GetExchangeId()
		{
			return this.ExchangeId;
		}

		// Token: 0x0601502F RID: 86063 RVA: 0x0057DAEF File Offset: 0x0057BCEF
		public override bool IsHide()
		{
			return this.Hide != 0;
		}

		// Token: 0x06015030 RID: 86064 RVA: 0x0057DAFA File Offset: 0x0057BCFA
		public override int Getpurpose()
		{
			return this.purpose;
		}

		// Token: 0x06015031 RID: 86065 RVA: 0x0057DB02 File Offset: 0x0057BD02
		public override int GetTargetId()
		{
			return this.TargetId;
		}

		// Token: 0x06015032 RID: 86066 RVA: 0x0057DB0A File Offset: 0x0057BD0A
		public override int GetRarity()
		{
			return this.Rarity;
		}

		// Token: 0x06015033 RID: 86067 RVA: 0x0057DB12 File Offset: 0x0057BD12
		public override int GetSort()
		{
			return this.Sort;
		}

		// Token: 0x06015034 RID: 86068 RVA: 0x0057DB1A File Offset: 0x0057BD1A
		public override int Getwd()
		{
			return this.wd;
		}

		// Token: 0x06015035 RID: 86069 RVA: 0x0057DB24 File Offset: 0x0057BD24
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.catID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Max = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Bean = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ExchangeId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Hide = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.purpose = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.TargetId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Rarity = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.wd = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}

		// Token: 0x04013FC0 RID: 81856
		public int catID;

		// Token: 0x04013FC1 RID: 81857
		public int ID;

		// Token: 0x04013FC2 RID: 81858
		public string Name;

		// Token: 0x04013FC3 RID: 81859
		public int Max;

		// Token: 0x04013FC4 RID: 81860
		public int Bean;

		// Token: 0x04013FC5 RID: 81861
		public int ExchangeId;

		// Token: 0x04013FC6 RID: 81862
		public int Hide;

		// Token: 0x04013FC7 RID: 81863
		public int purpose;

		// Token: 0x04013FC8 RID: 81864
		public int TargetId;

		// Token: 0x04013FC9 RID: 81865
		public int Rarity;

		// Token: 0x04013FCA RID: 81866
		public int Sort;

		// Token: 0x04013FCB RID: 81867
		public int wd;
	}
}
