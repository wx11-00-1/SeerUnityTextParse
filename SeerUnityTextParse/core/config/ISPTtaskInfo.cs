using System;

namespace core.config
{
	// Token: 0x02001E34 RID: 7732
	public class ISPTtaskInfo : IConfigItem
	{
		// Token: 0x170018DE RID: 6366
		// (get) Token: 0x0600E500 RID: 58624 RVA: 0x003DF134 File Offset: 0x003DD334
		// (set) Token: 0x0600E501 RID: 58625 RVA: 0x003DF13C File Offset: 0x003DD33C
		public string otherreward { get; set; }

		// Token: 0x170018DF RID: 6367
		// (get) Token: 0x0600E502 RID: 58626 RVA: 0x003DF145 File Offset: 0x003DD345
		// (set) Token: 0x0600E503 RID: 58627 RVA: 0x003DF14D File Offset: 0x003DD34D
		public int[] btlconid { get; set; }

		// Token: 0x170018E0 RID: 6368
		// (get) Token: 0x0600E504 RID: 58628 RVA: 0x003DF156 File Offset: 0x003DD356
		// (set) Token: 0x0600E505 RID: 58629 RVA: 0x003DF15E File Offset: 0x003DD35E
		public int[] firstreward { get; set; }

		// Token: 0x170018E1 RID: 6369
		// (get) Token: 0x0600E506 RID: 58630 RVA: 0x003DF167 File Offset: 0x003DD367
		// (set) Token: 0x0600E507 RID: 58631 RVA: 0x003DF16F File Offset: 0x003DD36F
		public int[] monsterid { get; set; }

		// Token: 0x170018E2 RID: 6370
		// (get) Token: 0x0600E508 RID: 58632 RVA: 0x003DF178 File Offset: 0x003DD378
		// (set) Token: 0x0600E509 RID: 58633 RVA: 0x003DF180 File Offset: 0x003DD380
		public int[] unlockcond { get; set; }

		// Token: 0x170018E3 RID: 6371
		// (get) Token: 0x0600E50A RID: 58634 RVA: 0x003DF189 File Offset: 0x003DD389
		// (set) Token: 0x0600E50B RID: 58635 RVA: 0x003DF191 File Offset: 0x003DD391
		public int galaxyid { get; set; }

		// Token: 0x170018E4 RID: 6372
		// (get) Token: 0x0600E50C RID: 58636 RVA: 0x003DF19A File Offset: 0x003DD39A
		// (set) Token: 0x0600E50D RID: 58637 RVA: 0x003DF1A2 File Offset: 0x003DD3A2
		public int id { get; set; }

		// Token: 0x170018E5 RID: 6373
		// (get) Token: 0x0600E50E RID: 58638 RVA: 0x003DF1AB File Offset: 0x003DD3AB
		// (set) Token: 0x0600E50F RID: 58639 RVA: 0x003DF1B3 File Offset: 0x003DD3B3
		public int isend { get; set; }

		// Token: 0x170018E6 RID: 6374
		// (get) Token: 0x0600E510 RID: 58640 RVA: 0x003DF1BC File Offset: 0x003DD3BC
		// (set) Token: 0x0600E511 RID: 58641 RVA: 0x003DF1C4 File Offset: 0x003DD3C4
		public int taskmode { get; set; }

		// Token: 0x170018E7 RID: 6375
		// (get) Token: 0x0600E512 RID: 58642 RVA: 0x003DF1CD File Offset: 0x003DD3CD
		// (set) Token: 0x0600E513 RID: 58643 RVA: 0x003DF1D5 File Offset: 0x003DD3D5
		public int taskstep { get; set; }

		// Token: 0x170018E8 RID: 6376
		// (get) Token: 0x0600E514 RID: 58644 RVA: 0x003DF1DE File Offset: 0x003DD3DE
		// (set) Token: 0x0600E515 RID: 58645 RVA: 0x003DF1E6 File Offset: 0x003DD3E6
		public int tasktype { get; set; }

		// Token: 0x170018E9 RID: 6377
		// (get) Token: 0x0600E516 RID: 58646 RVA: 0x003DF1EF File Offset: 0x003DD3EF
		// (set) Token: 0x0600E517 RID: 58647 RVA: 0x003DF1F7 File Offset: 0x003DD3F7
		public int unlockmark { get; set; }

		// Token: 0x0600E518 RID: 58648 RVA: 0x003DF200 File Offset: 0x003DD400
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.btlconid = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.btlconid[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.firstreward = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					this.firstreward[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.galaxyid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.isend = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.monsterid = new int[num3];
				for (int k = 0; k < num3; k++)
				{
					this.monsterid[k] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.otherreward = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.taskmode = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.taskstep = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.tasktype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num4 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.unlockcond = new int[num4];
				for (int l = 0; l < num4; l++)
				{
					this.unlockcond[l] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.unlockmark = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
