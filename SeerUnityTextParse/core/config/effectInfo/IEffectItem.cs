using System;

namespace core.config.effectInfo
{
	// Token: 0x02002053 RID: 8275
	public class IEffectItem : IConfigItem
	{
		// Token: 0x170020BA RID: 8378
		// (get) Token: 0x0600FCAD RID: 64685 RVA: 0x00402332 File Offset: 0x00400532
		// (set) Token: 0x0600FCAE RID: 64686 RVA: 0x0040233A File Offset: 0x0040053A
		public string info { get; set; }

		// Token: 0x170020BB RID: 8379
		// (get) Token: 0x0600FCAF RID: 64687 RVA: 0x00402343 File Offset: 0x00400543
		// (set) Token: 0x0600FCB0 RID: 64688 RVA: 0x0040234B File Offset: 0x0040054B
		public int[] param { get; set; }

		// Token: 0x170020BC RID: 8380
		// (get) Token: 0x0600FCB1 RID: 64689 RVA: 0x00402354 File Offset: 0x00400554
		// (set) Token: 0x0600FCB2 RID: 64690 RVA: 0x0040235C File Offset: 0x0040055C
		public int argsNum { get; set; }

		// Token: 0x170020BD RID: 8381
		// (get) Token: 0x0600FCB3 RID: 64691 RVA: 0x00402365 File Offset: 0x00400565
		// (set) Token: 0x0600FCB4 RID: 64692 RVA: 0x0040236D File Offset: 0x0040056D
		public int id { get; set; }

		// Token: 0x0600FCB5 RID: 64693 RVA: 0x00402378 File Offset: 0x00400578
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.argsNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.info = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.param = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.param[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
		}
	}
}
