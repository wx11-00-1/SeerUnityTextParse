using System;

namespace core.config
{
	// Token: 0x02001CE6 RID: 7398
	public class IBuildingWarStageInfo : IConfigItem
	{
		// Token: 0x17001315 RID: 4885
		// (get) Token: 0x0600D6D2 RID: 54994 RVA: 0x003CD728 File Offset: 0x003CB928
		// (set) Token: 0x0600D6D3 RID: 54995 RVA: 0x003CD730 File Offset: 0x003CB930
		public int[] changereward { get; set; }

		// Token: 0x17001316 RID: 4886
		// (get) Token: 0x0600D6D4 RID: 54996 RVA: 0x003CD739 File Offset: 0x003CB939
		// (set) Token: 0x0600D6D5 RID: 54997 RVA: 0x003CD741 File Offset: 0x003CB941
		public int[] judgeitem { get; set; }

		// Token: 0x17001317 RID: 4887
		// (get) Token: 0x0600D6D6 RID: 54998 RVA: 0x003CD74A File Offset: 0x003CB94A
		// (set) Token: 0x0600D6D7 RID: 54999 RVA: 0x003CD752 File Offset: 0x003CB952
		public int[] reward { get; set; }

		// Token: 0x17001318 RID: 4888
		// (get) Token: 0x0600D6D8 RID: 55000 RVA: 0x003CD75B File Offset: 0x003CB95B
		// (set) Token: 0x0600D6D9 RID: 55001 RVA: 0x003CD763 File Offset: 0x003CB963
		public int[] skilllist { get; set; }

		// Token: 0x17001319 RID: 4889
		// (get) Token: 0x0600D6DA RID: 55002 RVA: 0x003CD76C File Offset: 0x003CB96C
		// (set) Token: 0x0600D6DB RID: 55003 RVA: 0x003CD774 File Offset: 0x003CB974
		public int id { get; set; }

		// Token: 0x0600D6DC RID: 55004 RVA: 0x003CD780 File Offset: 0x003CB980
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.changereward = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.changereward[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.judgeitem = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					this.judgeitem[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.reward = new int[num3];
				for (int k = 0; k < num3; k++)
				{
					this.reward[k] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num4 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.skilllist = new int[num4];
				for (int l = 0; l < num4; l++)
				{
					this.skilllist[l] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
		}
	}
}
