using System;

namespace core.config
{
	// Token: 0x02001E06 RID: 7686
	public class IRoomInfo : IConfigItem
	{
		// Token: 0x17001810 RID: 6160
		// (get) Token: 0x0600E308 RID: 58120 RVA: 0x003DC8E0 File Offset: 0x003DAAE0
		// (set) Token: 0x0600E309 RID: 58121 RVA: 0x003DC8E8 File Offset: 0x003DAAE8
		public string name { get; set; }

		// Token: 0x17001811 RID: 6161
		// (get) Token: 0x0600E30A RID: 58122 RVA: 0x003DC8F1 File Offset: 0x003DAAF1
		// (set) Token: 0x0600E30B RID: 58123 RVA: 0x003DC8F9 File Offset: 0x003DAAF9
		public int[] floorPutDefaultPos { get; set; }

		// Token: 0x17001812 RID: 6162
		// (get) Token: 0x0600E30C RID: 58124 RVA: 0x003DC902 File Offset: 0x003DAB02
		// (set) Token: 0x0600E30D RID: 58125 RVA: 0x003DC90A File Offset: 0x003DAB0A
		public int[] playerPos { get; set; }

		// Token: 0x17001813 RID: 6163
		// (get) Token: 0x0600E30E RID: 58126 RVA: 0x003DC913 File Offset: 0x003DAB13
		// (set) Token: 0x0600E30F RID: 58127 RVA: 0x003DC91B File Offset: 0x003DAB1B
		public int[] wallPutDefaultPos { get; set; }

		// Token: 0x17001814 RID: 6164
		// (get) Token: 0x0600E310 RID: 58128 RVA: 0x003DC924 File Offset: 0x003DAB24
		// (set) Token: 0x0600E311 RID: 58129 RVA: 0x003DC92C File Offset: 0x003DAB2C
		public int id { get; set; }

		// Token: 0x17001815 RID: 6165
		// (get) Token: 0x0600E312 RID: 58130 RVA: 0x003DC935 File Offset: 0x003DAB35
		// (set) Token: 0x0600E313 RID: 58131 RVA: 0x003DC93D File Offset: 0x003DAB3D
		public int vipOnly { get; set; }

		// Token: 0x0600E314 RID: 58132 RVA: 0x003DC948 File Offset: 0x003DAB48
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.floorPutDefaultPos = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.floorPutDefaultPos[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.playerPos = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					this.playerPos[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.vipOnly = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.wallPutDefaultPos = new int[num3];
				for (int k = 0; k < num3; k++)
				{
					this.wallPutDefaultPos[k] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
		}
	}
}
