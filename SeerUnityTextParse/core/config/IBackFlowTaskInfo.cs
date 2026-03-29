using System;

namespace core.config
{
	// Token: 0x02002157 RID: 8535
	public class IBackFlowTaskInfo : IConfigItem
	{
		// Token: 0x1700155F RID: 5471
		// (get) Token: 0x0600FDEC RID: 65004 RVA: 0x0047E9E0 File Offset: 0x0047CBE0
		// (set) Token: 0x0600FDED RID: 65005 RVA: 0x0047E9E8 File Offset: 0x0047CBE8
		public string describe { get; set; }

		// Token: 0x17001560 RID: 5472
		// (get) Token: 0x0600FDEE RID: 65006 RVA: 0x0047E9F1 File Offset: 0x0047CBF1
		// (set) Token: 0x0600FDEF RID: 65007 RVA: 0x0047E9F9 File Offset: 0x0047CBF9
		public string[] H5addition { get; set; }

		// Token: 0x17001561 RID: 5473
		// (get) Token: 0x0600FDF0 RID: 65008 RVA: 0x0047EA02 File Offset: 0x0047CC02
		// (set) Token: 0x0600FDF1 RID: 65009 RVA: 0x0047EA0A File Offset: 0x0047CC0A
		public string NewMsglogId { get; set; }

		// Token: 0x17001562 RID: 5474
		// (get) Token: 0x0600FDF2 RID: 65010 RVA: 0x0047EA13 File Offset: 0x0047CC13
		// (set) Token: 0x0600FDF3 RID: 65011 RVA: 0x0047EA1B File Offset: 0x0047CC1B
		public string taskparam { get; set; }

		// Token: 0x17001563 RID: 5475
		// (get) Token: 0x0600FDF4 RID: 65012 RVA: 0x0047EA24 File Offset: 0x0047CC24
		// (set) Token: 0x0600FDF5 RID: 65013 RVA: 0x0047EA2C File Offset: 0x0047CC2C
		public string time2 { get; set; }

		// Token: 0x17001564 RID: 5476
		// (get) Token: 0x0600FDF6 RID: 65014 RVA: 0x0047EA35 File Offset: 0x0047CC35
		// (set) Token: 0x0600FDF7 RID: 65015 RVA: 0x0047EA3D File Offset: 0x0047CC3D
		public string title { get; set; }

		// Token: 0x17001565 RID: 5477
		// (get) Token: 0x0600FDF8 RID: 65016 RVA: 0x0047EA46 File Offset: 0x0047CC46
		// (set) Token: 0x0600FDF9 RID: 65017 RVA: 0x0047EA4E File Offset: 0x0047CC4E
		public string value { get; set; }

		// Token: 0x17001566 RID: 5478
		// (get) Token: 0x0600FDFA RID: 65018 RVA: 0x0047EA57 File Offset: 0x0047CC57
		// (set) Token: 0x0600FDFB RID: 65019 RVA: 0x0047EA5F File Offset: 0x0047CC5F
		public int[] H5jump { get; set; }

		// Token: 0x17001567 RID: 5479
		// (get) Token: 0x0600FDFC RID: 65020 RVA: 0x0047EA68 File Offset: 0x0047CC68
		// (set) Token: 0x0600FDFD RID: 65021 RVA: 0x0047EA70 File Offset: 0x0047CC70
		public int[] rewardinfo { get; set; }

		// Token: 0x17001568 RID: 5480
		// (get) Token: 0x0600FDFE RID: 65022 RVA: 0x0047EA79 File Offset: 0x0047CC79
		// (set) Token: 0x0600FDFF RID: 65023 RVA: 0x0047EA81 File Offset: 0x0047CC81
		public int id { get; set; }

		// Token: 0x17001569 RID: 5481
		// (get) Token: 0x0600FE00 RID: 65024 RVA: 0x0047EA8A File Offset: 0x0047CC8A
		// (set) Token: 0x0600FE01 RID: 65025 RVA: 0x0047EA92 File Offset: 0x0047CC92
		public int init { get; set; }

		// Token: 0x1700156A RID: 5482
		// (get) Token: 0x0600FE02 RID: 65026 RVA: 0x0047EA9B File Offset: 0x0047CC9B
		// (set) Token: 0x0600FE03 RID: 65027 RVA: 0x0047EAA3 File Offset: 0x0047CCA3
		public int num { get; set; }

		// Token: 0x1700156B RID: 5483
		// (get) Token: 0x0600FE04 RID: 65028 RVA: 0x0047EAAC File Offset: 0x0047CCAC
		// (set) Token: 0x0600FE05 RID: 65029 RVA: 0x0047EAB4 File Offset: 0x0047CCB4
		public int tasktype { get; set; }

		// Token: 0x1700156C RID: 5484
		// (get) Token: 0x0600FE06 RID: 65030 RVA: 0x0047EABD File Offset: 0x0047CCBD
		// (set) Token: 0x0600FE07 RID: 65031 RVA: 0x0047EAC5 File Offset: 0x0047CCC5
		public int time { get; set; }

		// Token: 0x0600FE08 RID: 65032 RVA: 0x0047EAD0 File Offset: 0x0047CCD0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.H5addition = new string[num];
				for (int i = 0; i < num; i++)
				{
					this.H5addition[i] = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.H5jump = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					this.H5jump[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.NewMsglogId = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.describe = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.init = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.rewardinfo = new int[num3];
				for (int k = 0; k < num3; k++)
				{
					this.rewardinfo[k] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.taskparam = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.tasktype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.time = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.time2 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.title = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.value = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
