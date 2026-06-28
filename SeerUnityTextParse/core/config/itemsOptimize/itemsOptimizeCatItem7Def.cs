using System;

namespace core.config.itemsOptimize
{
	// Token: 0x020028D7 RID: 10455
	public class itemsOptimizeCatItem7Def : ItemData
	{
		// Token: 0x0601500D RID: 86029 RVA: 0x0057D818 File Offset: 0x0057BA18
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

		// Token: 0x04013FA0 RID: 81824
		public int catID;

		// Token: 0x04013FA1 RID: 81825
		public int ID;

		// Token: 0x04013FA2 RID: 81826
		public string Name;

		// Token: 0x04013FA3 RID: 81827
		public int Max;

		// Token: 0x04013FA4 RID: 81828
		public int Bean;

		// Token: 0x04013FA5 RID: 81829
		public int Hide;

		// Token: 0x04013FA6 RID: 81830
		public int hideNum;

		// Token: 0x04013FA7 RID: 81831
		public int purpose;

		// Token: 0x04013FA8 RID: 81832
		public int Sort;

		// Token: 0x04013FA9 RID: 81833
		public int wd;
	}
}
