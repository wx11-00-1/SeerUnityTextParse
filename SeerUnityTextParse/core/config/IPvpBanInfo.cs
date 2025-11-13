using System;

namespace core.config
{
	// Token: 0x02001DDA RID: 7642
	public class IPvpBanInfo : IConfigItem
	{
		// Token: 0x1700174B RID: 5963
		// (get) Token: 0x0600E126 RID: 57638 RVA: 0x003DA33C File Offset: 0x003D853C
		// (set) Token: 0x0600E127 RID: 57639 RVA: 0x003DA344 File Offset: 0x003D8544
		public int[] name { get; set; }

		// Token: 0x1700174C RID: 5964
		// (get) Token: 0x0600E128 RID: 57640 RVA: 0x003DA34D File Offset: 0x003D854D
		// (set) Token: 0x0600E129 RID: 57641 RVA: 0x003DA355 File Offset: 0x003D8555
		public int id { get; set; }

		// Token: 0x1700174D RID: 5965
		// (get) Token: 0x0600E12A RID: 57642 RVA: 0x003DA35E File Offset: 0x003D855E
		// (set) Token: 0x0600E12B RID: 57643 RVA: 0x003DA366 File Offset: 0x003D8566
		public int quantity { get; set; }

		// Token: 0x1700174E RID: 5966
		// (get) Token: 0x0600E12C RID: 57644 RVA: 0x003DA36F File Offset: 0x003D856F
		// (set) Token: 0x0600E12D RID: 57645 RVA: 0x003DA377 File Offset: 0x003D8577
		public int subkey { get; set; }

		// Token: 0x1700174F RID: 5967
		// (get) Token: 0x0600E12E RID: 57646 RVA: 0x003DA380 File Offset: 0x003D8580
		// (set) Token: 0x0600E12F RID: 57647 RVA: 0x003DA388 File Offset: 0x003D8588
		public int type { get; set; }

		// Token: 0x0600E130 RID: 57648 RVA: 0x003DA394 File Offset: 0x003D8594
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.name = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.name[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.quantity = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.subkey = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
