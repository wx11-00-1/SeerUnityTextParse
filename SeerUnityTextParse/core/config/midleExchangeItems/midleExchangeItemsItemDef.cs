using System;

namespace core.config.midleExchangeItems
{
	// Token: 0x02001FCC RID: 8140
	public class midleExchangeItemsItemDef
	{
		// Token: 0x0600F567 RID: 62823 RVA: 0x003FACF8 File Offset: 0x003F8EF8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Max = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.catID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.TargetId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ExchangeId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ExchangeOutId = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.ExchangeOutCnt = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.SkinId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ExchangeType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}

		// Token: 0x0400F375 RID: 62325
		public int ID;

		// Token: 0x0400F376 RID: 62326
		public string Name;

		// Token: 0x0400F377 RID: 62327
		public int Max;

		// Token: 0x0400F378 RID: 62328
		public int catID;

		// Token: 0x0400F379 RID: 62329
		public int TargetId;

		// Token: 0x0400F37A RID: 62330
		public int ExchangeId;

		// Token: 0x0400F37B RID: 62331
		public string ExchangeOutId;

		// Token: 0x0400F37C RID: 62332
		public string ExchangeOutCnt;

		// Token: 0x0400F37D RID: 62333
		public int SkinId;

		// Token: 0x0400F37E RID: 62334
		public int ExchangeType;
	}
}
