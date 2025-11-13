using System;

namespace core.config.itemsOptimize
{
	// Token: 0x02001ED6 RID: 7894
	public class itemsOptimizeCatItem7Def : ItemData
	{
		// Token: 0x0600EC13 RID: 60435 RVA: 0x003EF9A0 File Offset: 0x003EDBA0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.catID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Max = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Bean = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Hide = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.hideNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.purpose = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.wd = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}

		// Token: 0x0400EF6F RID: 61295
		public int catID;

		// Token: 0x0400EF70 RID: 61296
		public int ID;

		// Token: 0x0400EF71 RID: 61297
		public string Name;

		// Token: 0x0400EF72 RID: 61298
		public int Max;

		// Token: 0x0400EF73 RID: 61299
		public int Bean;

		// Token: 0x0400EF74 RID: 61300
		public int Hide;

		// Token: 0x0400EF75 RID: 61301
		public int hideNum;

		// Token: 0x0400EF76 RID: 61302
		public int purpose;

		// Token: 0x0400EF77 RID: 61303
		public int Sort;

		// Token: 0x0400EF78 RID: 61304
		public int wd;
	}
}
