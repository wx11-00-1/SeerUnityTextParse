using System;

namespace core.config.itemsOptimize
{
	// Token: 0x02001EE3 RID: 7907
	public class itemsOptimizeCatDef
	{
		// Token: 0x0600ECB9 RID: 60601 RVA: 0x003F076C File Offset: 0x003EE96C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.DbCatID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Max = ByteUtil.ReadLong(bytes, ref byteIndex);
			this.url = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}

		// Token: 0x0400F005 RID: 61445
		public int ID;

		// Token: 0x0400F006 RID: 61446
		public int DbCatID;

		// Token: 0x0400F007 RID: 61447
		public string Name;

		// Token: 0x0400F008 RID: 61448
		public long Max;

		// Token: 0x0400F009 RID: 61449
		public string url;
	}
}
