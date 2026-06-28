using System;

namespace core.config.itemsOptimize
{
	// Token: 0x020028E1 RID: 10465
	public class itemsOptimizeCatItem24Def : ItemData
	{
		// Token: 0x06015093 RID: 86163 RVA: 0x0057E365 File Offset: 0x0057C565
		public override int GetID()
		{
			return this.ID;
		}

		// Token: 0x06015094 RID: 86164 RVA: 0x0057E36D File Offset: 0x0057C56D
		public override string GetName()
		{
			return this.Name;
		}

		// Token: 0x06015095 RID: 86165 RVA: 0x0057E375 File Offset: 0x0057C575
		public override int GetMax()
		{
			return this.Max;
		}

		// Token: 0x06015096 RID: 86166 RVA: 0x0057E37D File Offset: 0x0057C57D
		public override int GetCatID()
		{
			return this.catID;
		}

		// Token: 0x06015097 RID: 86167 RVA: 0x0057E385 File Offset: 0x0057C585
		public override bool IsHide()
		{
			return this.Hide != 0;
		}

		// Token: 0x06015098 RID: 86168 RVA: 0x0057E390 File Offset: 0x0057C590
		public override int Getpurpose()
		{
			return this.purpose;
		}

		// Token: 0x06015099 RID: 86169 RVA: 0x0057E398 File Offset: 0x0057C598
		public override int Getwd()
		{
			return this.wd;
		}

		// Token: 0x0601509A RID: 86170 RVA: 0x0057E3A0 File Offset: 0x0057C5A0
		public override int GetSort()
		{
			return this.Sort;
		}

		// Token: 0x0601509B RID: 86171 RVA: 0x0057E3A8 File Offset: 0x0057C5A8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.catID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Max = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Hide = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.purpose = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.wd = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}

		// Token: 0x0401401C RID: 81948
		public int catID;

		// Token: 0x0401401D RID: 81949
		public int ID;

		// Token: 0x0401401E RID: 81950
		public string Name;

		// Token: 0x0401401F RID: 81951
		public int Max;

		// Token: 0x04014020 RID: 81952
		public int Hide;

		// Token: 0x04014021 RID: 81953
		public int purpose;

		// Token: 0x04014022 RID: 81954
		public int wd;

		// Token: 0x04014023 RID: 81955
		public int Sort;
	}
}
