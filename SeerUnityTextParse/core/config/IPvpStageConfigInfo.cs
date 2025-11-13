using System;

namespace core.config
{
	// Token: 0x02001DE8 RID: 7656
	public class IPvpStageConfigInfo : IConfigItem
	{
		// Token: 0x1700178E RID: 6030
		// (get) Token: 0x0600E1C8 RID: 57800 RVA: 0x003DAEA8 File Offset: 0x003D90A8
		// (set) Token: 0x0600E1C9 RID: 57801 RVA: 0x003DAEB0 File Offset: 0x003D90B0
		public string bossIntro { get; set; }

		// Token: 0x1700178F RID: 6031
		// (get) Token: 0x0600E1CA RID: 57802 RVA: 0x003DAEB9 File Offset: 0x003D90B9
		// (set) Token: 0x0600E1CB RID: 57803 RVA: 0x003DAEC1 File Offset: 0x003D90C1
		public string firstReward { get; set; }

		// Token: 0x17001790 RID: 6032
		// (get) Token: 0x0600E1CC RID: 57804 RVA: 0x003DAECA File Offset: 0x003D90CA
		// (set) Token: 0x0600E1CD RID: 57805 RVA: 0x003DAED2 File Offset: 0x003D90D2
		public string monsterName { get; set; }

		// Token: 0x17001791 RID: 6033
		// (get) Token: 0x0600E1CE RID: 57806 RVA: 0x003DAEDB File Offset: 0x003D90DB
		// (set) Token: 0x0600E1CF RID: 57807 RVA: 0x003DAEE3 File Offset: 0x003D90E3
		public int[] fightMonsterIndexs { get; set; }

		// Token: 0x17001792 RID: 6034
		// (get) Token: 0x0600E1D0 RID: 57808 RVA: 0x003DAEEC File Offset: 0x003D90EC
		// (set) Token: 0x0600E1D1 RID: 57809 RVA: 0x003DAEF4 File Offset: 0x003D90F4
		public int id { get; set; }

		// Token: 0x17001793 RID: 6035
		// (get) Token: 0x0600E1D2 RID: 57810 RVA: 0x003DAEFD File Offset: 0x003D90FD
		// (set) Token: 0x0600E1D3 RID: 57811 RVA: 0x003DAF05 File Offset: 0x003D9105
		public int index { get; set; }

		// Token: 0x17001794 RID: 6036
		// (get) Token: 0x0600E1D4 RID: 57812 RVA: 0x003DAF0E File Offset: 0x003D910E
		// (set) Token: 0x0600E1D5 RID: 57813 RVA: 0x003DAF16 File Offset: 0x003D9116
		public int monsterId { get; set; }

		// Token: 0x17001795 RID: 6037
		// (get) Token: 0x0600E1D6 RID: 57814 RVA: 0x003DAF1F File Offset: 0x003D911F
		// (set) Token: 0x0600E1D7 RID: 57815 RVA: 0x003DAF27 File Offset: 0x003D9127
		public int order { get; set; }

		// Token: 0x17001796 RID: 6038
		// (get) Token: 0x0600E1D8 RID: 57816 RVA: 0x003DAF30 File Offset: 0x003D9130
		// (set) Token: 0x0600E1D9 RID: 57817 RVA: 0x003DAF38 File Offset: 0x003D9138
		public int UserInfoID { get; set; }

		// Token: 0x0600E1DA RID: 57818 RVA: 0x003DAF44 File Offset: 0x003D9144
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.UserInfoID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.bossIntro = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.fightMonsterIndexs = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.fightMonsterIndexs[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.firstReward = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.index = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.monsterId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.monsterName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.order = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
