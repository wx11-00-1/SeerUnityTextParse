using System;

namespace core.config.itemsOptimize
{
	// Token: 0x020028E3 RID: 10467
	public class itemsOptimizeCatItem26Def : ItemData
	{
		// Token: 0x060150A9 RID: 86185 RVA: 0x0057E51E File Offset: 0x0057C71E
		public override int GetID()
		{
			return this.ID;
		}

		// Token: 0x060150AA RID: 86186 RVA: 0x0057E526 File Offset: 0x0057C726
		public override string GetName()
		{
			return this.Name;
		}

		// Token: 0x060150AB RID: 86187 RVA: 0x0057E52E File Offset: 0x0057C72E
		public override int GetMax()
		{
			return this.Max;
		}

		// Token: 0x060150AC RID: 86188 RVA: 0x0057E536 File Offset: 0x0057C736
		public override int GetCatID()
		{
			return this.catID;
		}

		// Token: 0x060150AD RID: 86189 RVA: 0x0057E53E File Offset: 0x0057C73E
		public override int Getpurpose()
		{
			return this.purpose;
		}

		// Token: 0x060150AE RID: 86190 RVA: 0x0057E546 File Offset: 0x0057C746
		public override int Getwd()
		{
			return this.wd;
		}

		// Token: 0x060150AF RID: 86191 RVA: 0x0057E54E File Offset: 0x0057C74E
		public override int GetSort()
		{
			return this.Sort;
		}

		// Token: 0x060150B0 RID: 86192 RVA: 0x0057E556 File Offset: 0x0057C756
		public override int GetUseMax()
		{
			return this.UseMax;
		}

		// Token: 0x060150B1 RID: 86193 RVA: 0x0057E560 File Offset: 0x0057C760
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.catID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Max = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.purpose = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.wd = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.UseMax = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}

		// Token: 0x0401402E RID: 81966
		public int catID;

		// Token: 0x0401402F RID: 81967
		public int ID;

		// Token: 0x04014030 RID: 81968
		public string Name;

		// Token: 0x04014031 RID: 81969
		public int Max;

		// Token: 0x04014032 RID: 81970
		public int purpose;

		// Token: 0x04014033 RID: 81971
		public int wd;

		// Token: 0x04014034 RID: 81972
		public int Sort;

		// Token: 0x04014035 RID: 81973
		public int UseMax;
	}
}
