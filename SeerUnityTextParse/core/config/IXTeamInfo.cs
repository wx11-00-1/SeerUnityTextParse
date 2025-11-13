using System;

namespace core.config
{
	// Token: 0x02001E8A RID: 7818
	public class IXTeamInfo : IConfigItem
	{
		// Token: 0x17001A64 RID: 6756
		// (get) Token: 0x0600E8B8 RID: 59576 RVA: 0x003E3B04 File Offset: 0x003E1D04
		// (set) Token: 0x0600E8B9 RID: 59577 RVA: 0x003E3B0C File Offset: 0x003E1D0C
		public string conditionText { get; set; }

		// Token: 0x17001A65 RID: 6757
		// (get) Token: 0x0600E8BA RID: 59578 RVA: 0x003E3B15 File Offset: 0x003E1D15
		// (set) Token: 0x0600E8BB RID: 59579 RVA: 0x003E3B1D File Offset: 0x003E1D1D
		public string wintext { get; set; }

		// Token: 0x17001A66 RID: 6758
		// (get) Token: 0x0600E8BC RID: 59580 RVA: 0x003E3B26 File Offset: 0x003E1D26
		// (set) Token: 0x0600E8BD RID: 59581 RVA: 0x003E3B2E File Offset: 0x003E1D2E
		public int[] rewardcnt { get; set; }

		// Token: 0x17001A67 RID: 6759
		// (get) Token: 0x0600E8BE RID: 59582 RVA: 0x003E3B37 File Offset: 0x003E1D37
		// (set) Token: 0x0600E8BF RID: 59583 RVA: 0x003E3B3F File Offset: 0x003E1D3F
		public int[] rewardid { get; set; }

		// Token: 0x17001A68 RID: 6760
		// (get) Token: 0x0600E8C0 RID: 59584 RVA: 0x003E3B48 File Offset: 0x003E1D48
		// (set) Token: 0x0600E8C1 RID: 59585 RVA: 0x003E3B50 File Offset: 0x003E1D50
		public int boss { get; set; }

		// Token: 0x17001A69 RID: 6761
		// (get) Token: 0x0600E8C2 RID: 59586 RVA: 0x003E3B59 File Offset: 0x003E1D59
		// (set) Token: 0x0600E8C3 RID: 59587 RVA: 0x003E3B61 File Offset: 0x003E1D61
		public int id { get; set; }

		// Token: 0x17001A6A RID: 6762
		// (get) Token: 0x0600E8C4 RID: 59588 RVA: 0x003E3B6A File Offset: 0x003E1D6A
		// (set) Token: 0x0600E8C5 RID: 59589 RVA: 0x003E3B72 File Offset: 0x003E1D72
		public int indexType { get; set; }

		// Token: 0x0600E8C6 RID: 59590 RVA: 0x003E3B7C File Offset: 0x003E1D7C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.boss = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.conditionText = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.indexType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.rewardcnt = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.rewardcnt[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.rewardid = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					this.rewardid[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.wintext = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
