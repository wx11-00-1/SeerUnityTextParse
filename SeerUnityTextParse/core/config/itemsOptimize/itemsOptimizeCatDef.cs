using System;

namespace core.config.itemsOptimize
{
	// Token: 0x020028E4 RID: 10468
	public class itemsOptimizeCatDef
	{
		// Token: 0x060150B3 RID: 86195 RVA: 0x0057E5E4 File Offset: 0x0057C7E4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.DbCatID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Max = ByteUtil.ReadLong(bytes, ref byteIndex);
			this.url = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}

		// Token: 0x04014036 RID: 81974
		public int ID;

		// Token: 0x04014037 RID: 81975
		public int DbCatID;

		// Token: 0x04014038 RID: 81976
		public string Name;

		// Token: 0x04014039 RID: 81977
		public long Max;

		// Token: 0x0401403A RID: 81978
		public string url;
	}
}
