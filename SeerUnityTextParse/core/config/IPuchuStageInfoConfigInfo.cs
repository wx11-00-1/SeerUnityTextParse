using System;

namespace core.config
{
	// Token: 0x0200261F RID: 9759
	public class IPuchuStageInfoConfigInfo : IConfigItem
	{
		// Token: 0x17001F1E RID: 7966
		// (get) Token: 0x06012DD2 RID: 77266 RVA: 0x0051A7D0 File Offset: 0x005189D0
		// (set) Token: 0x06012DD3 RID: 77267 RVA: 0x0051A7D8 File Offset: 0x005189D8
		public string stageName { get; set; }

		// Token: 0x17001F1F RID: 7967
		// (get) Token: 0x06012DD4 RID: 77268 RVA: 0x0051A7E1 File Offset: 0x005189E1
		// (set) Token: 0x06012DD5 RID: 77269 RVA: 0x0051A7E9 File Offset: 0x005189E9
		public string stageTutorial { get; set; }

		// Token: 0x17001F20 RID: 7968
		// (get) Token: 0x06012DD6 RID: 77270 RVA: 0x0051A7F2 File Offset: 0x005189F2
		// (set) Token: 0x06012DD7 RID: 77271 RVA: 0x0051A7FA File Offset: 0x005189FA
		public int[] stageMainMap { get; set; }

		// Token: 0x17001F21 RID: 7969
		// (get) Token: 0x06012DD8 RID: 77272 RVA: 0x0051A803 File Offset: 0x00518A03
		// (set) Token: 0x06012DD9 RID: 77273 RVA: 0x0051A80B File Offset: 0x00518A0B
		public int id { get; set; }

		// Token: 0x17001F22 RID: 7970
		// (get) Token: 0x06012DDA RID: 77274 RVA: 0x0051A814 File Offset: 0x00518A14
		// (set) Token: 0x06012DDB RID: 77275 RVA: 0x0051A81C File Offset: 0x00518A1C
		public int stageInitialStep { get; set; }

		// Token: 0x17001F23 RID: 7971
		// (get) Token: 0x06012DDC RID: 77276 RVA: 0x0051A825 File Offset: 0x00518A25
		// (set) Token: 0x06012DDD RID: 77277 RVA: 0x0051A82D File Offset: 0x00518A2D
		public int stagePrice { get; set; }

		// Token: 0x17001F24 RID: 7972
		// (get) Token: 0x06012DDE RID: 77278 RVA: 0x0051A836 File Offset: 0x00518A36
		// (set) Token: 0x06012DDF RID: 77279 RVA: 0x0051A83E File Offset: 0x00518A3E
		public int stageType { get; set; }

		// Token: 0x17001F25 RID: 7973
		// (get) Token: 0x06012DE0 RID: 77280 RVA: 0x0051A847 File Offset: 0x00518A47
		// (set) Token: 0x06012DE1 RID: 77281 RVA: 0x0051A84F File Offset: 0x00518A4F
		public int stageUnlock { get; set; }

		// Token: 0x06012DE2 RID: 77282 RVA: 0x0051A858 File Offset: 0x00518A58
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.stageInitialStep = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.stageMainMap = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.stageMainMap[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.stageName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.stagePrice = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.stageTutorial = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.stageType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.stageUnlock = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
