using System;

namespace core.config
{
	// Token: 0x02002433 RID: 9267
	public class IAurumEndgameTutorialConfigInfo : IConfigItem
	{
		// Token: 0x17001667 RID: 5735
		// (get) Token: 0x0601188C RID: 71820 RVA: 0x00500DAC File Offset: 0x004FEFAC
		// (set) Token: 0x0601188D RID: 71821 RVA: 0x00500DB4 File Offset: 0x004FEFB4
		public string tagname { get; set; }

		// Token: 0x17001668 RID: 5736
		// (get) Token: 0x0601188E RID: 71822 RVA: 0x00500DBD File Offset: 0x004FEFBD
		// (set) Token: 0x0601188F RID: 71823 RVA: 0x00500DC5 File Offset: 0x004FEFC5
		public int[] tutorialid { get; set; }

		// Token: 0x17001669 RID: 5737
		// (get) Token: 0x06011890 RID: 71824 RVA: 0x00500DCE File Offset: 0x004FEFCE
		// (set) Token: 0x06011891 RID: 71825 RVA: 0x00500DD6 File Offset: 0x004FEFD6
		public int id { get; set; }

		// Token: 0x06011892 RID: 71826 RVA: 0x00500DE0 File Offset: 0x004FEFE0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.tagname = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.tutorialid = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.tutorialid[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
		}
	}
}
