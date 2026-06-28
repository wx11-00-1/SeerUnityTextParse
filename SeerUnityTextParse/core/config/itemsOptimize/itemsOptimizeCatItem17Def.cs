using System;

namespace core.config.itemsOptimize
{
	// Token: 0x020028DE RID: 10462
	public class itemsOptimizeCatItem17Def : ItemData
	{
		// Token: 0x0601505F RID: 86111 RVA: 0x0057DF16 File Offset: 0x0057C116
		public override int GetID()
		{
			return this.ID;
		}

		// Token: 0x06015060 RID: 86112 RVA: 0x0057DF1E File Offset: 0x0057C11E
		public override string GetName()
		{
			return this.Name;
		}

		// Token: 0x06015061 RID: 86113 RVA: 0x0057DF26 File Offset: 0x0057C126
		public override int GetMax()
		{
			return this.Max;
		}

		// Token: 0x06015062 RID: 86114 RVA: 0x0057DF2E File Offset: 0x0057C12E
		public override int GetCatID()
		{
			return this.catID;
		}

		// Token: 0x06015063 RID: 86115 RVA: 0x0057DF36 File Offset: 0x0057C136
		public override int GetBean()
		{
			return this.Bean;
		}

		// Token: 0x06015064 RID: 86116 RVA: 0x0057DF3E File Offset: 0x0057C13E
		public override string GetExchangeOutId()
		{
			return this.ExchangeOutId;
		}

		// Token: 0x06015065 RID: 86117 RVA: 0x0057DF46 File Offset: 0x0057C146
		public override string GetExchangeOutCnt()
		{
			return this.ExchangeOutCnt;
		}

		// Token: 0x06015066 RID: 86118 RVA: 0x0057DF4E File Offset: 0x0057C14E
		public override int GetExchangeId()
		{
			return this.ExchangeId;
		}

		// Token: 0x06015067 RID: 86119 RVA: 0x0057DF56 File Offset: 0x0057C156
		public override int GetExchangeType()
		{
			return this.ExchangeType;
		}

		// Token: 0x06015068 RID: 86120 RVA: 0x0057DF5E File Offset: 0x0057C15E
		public override bool IsHide()
		{
			return this.Hide != 0;
		}

		// Token: 0x06015069 RID: 86121 RVA: 0x0057DF69 File Offset: 0x0057C169
		public override int GethideNum()
		{
			return this.hideNum;
		}

		// Token: 0x0601506A RID: 86122 RVA: 0x0057DF71 File Offset: 0x0057C171
		public override int GetItemType()
		{
			return this.ItemType;
		}

		// Token: 0x0601506B RID: 86123 RVA: 0x0057DF79 File Offset: 0x0057C179
		public override int GetLifeTime()
		{
			return this.LifeTime;
		}

		// Token: 0x0601506C RID: 86124 RVA: 0x0057DF81 File Offset: 0x0057C181
		public override int GetPrice()
		{
			return this.Price;
		}

		// Token: 0x0601506D RID: 86125 RVA: 0x0057DF89 File Offset: 0x0057C189
		public override int Getpurpose()
		{
			return this.purpose;
		}

		// Token: 0x0601506E RID: 86126 RVA: 0x0057DF91 File Offset: 0x0057C191
		public override int GetTargetId()
		{
			return this.TargetId;
		}

		// Token: 0x0601506F RID: 86127 RVA: 0x0057DF99 File Offset: 0x0057C199
		public override int GetRarity()
		{
			return this.Rarity;
		}

		// Token: 0x06015070 RID: 86128 RVA: 0x0057DFA1 File Offset: 0x0057C1A1
		public override int GetSort()
		{
			return this.Sort;
		}

		// Token: 0x06015071 RID: 86129 RVA: 0x0057DFA9 File Offset: 0x0057C1A9
		public override int Getwd()
		{
			return this.wd;
		}

		// Token: 0x06015072 RID: 86130 RVA: 0x0057DFB1 File Offset: 0x0057C1B1
		public override string GetUseEnd()
		{
			return this.UseEnd;
		}

		// Token: 0x06015073 RID: 86131 RVA: 0x0057DFB9 File Offset: 0x0057C1B9
		public override int GetSkinId()
		{
			return this.SkinId;
		}

		// Token: 0x06015074 RID: 86132 RVA: 0x0057DFC4 File Offset: 0x0057C1C4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.catID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Max = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Bean = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ExchangeOutCnt = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.ExchangeOutId = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.ExchangeId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ExchangeType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Hide = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.hideNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ItemType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.LifeTime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Price = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.purpose = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.TargetId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Rarity = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.wd = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.UseEnd = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.SkinId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}

		// Token: 0x04013FEE RID: 81902
		public int catID;

		// Token: 0x04013FEF RID: 81903
		public int ID;

		// Token: 0x04013FF0 RID: 81904
		public string Name;

		// Token: 0x04013FF1 RID: 81905
		public int Max;

		// Token: 0x04013FF2 RID: 81906
		public int Bean;

		// Token: 0x04013FF3 RID: 81907
		public string ExchangeOutCnt;

		// Token: 0x04013FF4 RID: 81908
		public string ExchangeOutId;

		// Token: 0x04013FF5 RID: 81909
		public int ExchangeId;

		// Token: 0x04013FF6 RID: 81910
		public int ExchangeType;

		// Token: 0x04013FF7 RID: 81911
		public int Hide;

		// Token: 0x04013FF8 RID: 81912
		public int hideNum;

		// Token: 0x04013FF9 RID: 81913
		public int ItemType;

		// Token: 0x04013FFA RID: 81914
		public int LifeTime;

		// Token: 0x04013FFB RID: 81915
		public int Price;

		// Token: 0x04013FFC RID: 81916
		public int purpose;

		// Token: 0x04013FFD RID: 81917
		public int TargetId;

		// Token: 0x04013FFE RID: 81918
		public int Rarity;

		// Token: 0x04013FFF RID: 81919
		public int Sort;

		// Token: 0x04014000 RID: 81920
		public int wd;

		// Token: 0x04014001 RID: 81921
		public string UseEnd;

		// Token: 0x04014002 RID: 81922
		public int SkinId;
	}
}
