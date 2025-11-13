using System;

namespace core.config
{
	// Token: 0x02001E7E RID: 7806
	public class ITempleHeroesMainInfo : IConfigItem
	{
		// Token: 0x17001A3F RID: 6719
		// (get) Token: 0x0600E856 RID: 59478 RVA: 0x003E3308 File Offset: 0x003E1508
		// (set) Token: 0x0600E857 RID: 59479 RVA: 0x003E3310 File Offset: 0x003E1510
		public string endTime { get; set; }

		// Token: 0x17001A40 RID: 6720
		// (get) Token: 0x0600E858 RID: 59480 RVA: 0x003E3319 File Offset: 0x003E1519
		// (set) Token: 0x0600E859 RID: 59481 RVA: 0x003E3321 File Offset: 0x003E1521
		public string price { get; set; }

		// Token: 0x17001A41 RID: 6721
		// (get) Token: 0x0600E85A RID: 59482 RVA: 0x003E332A File Offset: 0x003E152A
		// (set) Token: 0x0600E85B RID: 59483 RVA: 0x003E3332 File Offset: 0x003E1532
		public string startTime { get; set; }

		// Token: 0x17001A42 RID: 6722
		// (get) Token: 0x0600E85C RID: 59484 RVA: 0x003E333B File Offset: 0x003E153B
		// (set) Token: 0x0600E85D RID: 59485 RVA: 0x003E3343 File Offset: 0x003E1543
		public int[] monAppend { get; set; }

		// Token: 0x17001A43 RID: 6723
		// (get) Token: 0x0600E85E RID: 59486 RVA: 0x003E334C File Offset: 0x003E154C
		// (set) Token: 0x0600E85F RID: 59487 RVA: 0x003E3354 File Offset: 0x003E1554
		public int id { get; set; }

		// Token: 0x17001A44 RID: 6724
		// (get) Token: 0x0600E860 RID: 59488 RVA: 0x003E335D File Offset: 0x003E155D
		// (set) Token: 0x0600E861 RID: 59489 RVA: 0x003E3365 File Offset: 0x003E1565
		public int isOn { get; set; }

		// Token: 0x17001A45 RID: 6725
		// (get) Token: 0x0600E862 RID: 59490 RVA: 0x003E336E File Offset: 0x003E156E
		// (set) Token: 0x0600E863 RID: 59491 RVA: 0x003E3376 File Offset: 0x003E1576
		public int monsterId { get; set; }

		// Token: 0x17001A46 RID: 6726
		// (get) Token: 0x0600E864 RID: 59492 RVA: 0x003E337F File Offset: 0x003E157F
		// (set) Token: 0x0600E865 RID: 59493 RVA: 0x003E3387 File Offset: 0x003E1587
		public int type { get; set; }

		// Token: 0x0600E866 RID: 59494 RVA: 0x003E3390 File Offset: 0x003E1590
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.endTime = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.isOn = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.monAppend = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.monAppend[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.monsterId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.price = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.startTime = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
