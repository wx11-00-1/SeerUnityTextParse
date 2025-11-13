using System;

namespace core.config
{
	// Token: 0x02001DA4 RID: 7588
	public class INewBraveTaskInfo : IConfigItem
	{
		// Token: 0x1700164A RID: 5706
		// (get) Token: 0x0600DEB8 RID: 57016 RVA: 0x003D7320 File Offset: 0x003D5520
		// (set) Token: 0x0600DEB9 RID: 57017 RVA: 0x003D7328 File Offset: 0x003D5528
		public string title { get; set; }

		// Token: 0x1700164B RID: 5707
		// (get) Token: 0x0600DEBA RID: 57018 RVA: 0x003D7331 File Offset: 0x003D5531
		// (set) Token: 0x0600DEBB RID: 57019 RVA: 0x003D7339 File Offset: 0x003D5539
		public int[] jump { get; set; }

		// Token: 0x1700164C RID: 5708
		// (get) Token: 0x0600DEBC RID: 57020 RVA: 0x003D7342 File Offset: 0x003D5542
		// (set) Token: 0x0600DEBD RID: 57021 RVA: 0x003D734A File Offset: 0x003D554A
		public int[] petreward { get; set; }

		// Token: 0x1700164D RID: 5709
		// (get) Token: 0x0600DEBE RID: 57022 RVA: 0x003D7353 File Offset: 0x003D5553
		// (set) Token: 0x0600DEBF RID: 57023 RVA: 0x003D735B File Offset: 0x003D555B
		public int[] rewardinfo { get; set; }

		// Token: 0x1700164E RID: 5710
		// (get) Token: 0x0600DEC0 RID: 57024 RVA: 0x003D7364 File Offset: 0x003D5564
		// (set) Token: 0x0600DEC1 RID: 57025 RVA: 0x003D736C File Offset: 0x003D556C
		public int id { get; set; }

		// Token: 0x1700164F RID: 5711
		// (get) Token: 0x0600DEC2 RID: 57026 RVA: 0x003D7375 File Offset: 0x003D5575
		// (set) Token: 0x0600DEC3 RID: 57027 RVA: 0x003D737D File Offset: 0x003D557D
		public int pethead { get; set; }

		// Token: 0x0600DEC4 RID: 57028 RVA: 0x003D7388 File Offset: 0x003D5588
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.jump = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.jump[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.pethead = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.petreward = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					this.petreward[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.rewardinfo = new int[num3];
				for (int k = 0; k < num3; k++)
				{
					this.rewardinfo[k] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.title = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
