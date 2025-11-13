using System;

namespace core.config
{
	// Token: 0x02001E7C RID: 7804
	public class ITempleHeroesInfo : IConfigItem
	{
		// Token: 0x17001A38 RID: 6712
		// (get) Token: 0x0600E844 RID: 59460 RVA: 0x003E315C File Offset: 0x003E135C
		// (set) Token: 0x0600E845 RID: 59461 RVA: 0x003E3164 File Offset: 0x003E1364
		public string front { get; set; }

		// Token: 0x17001A39 RID: 6713
		// (get) Token: 0x0600E846 RID: 59462 RVA: 0x003E316D File Offset: 0x003E136D
		// (set) Token: 0x0600E847 RID: 59463 RVA: 0x003E3175 File Offset: 0x003E1375
		public string[] realId { get; set; }

		// Token: 0x17001A3A RID: 6714
		// (get) Token: 0x0600E848 RID: 59464 RVA: 0x003E317E File Offset: 0x003E137E
		// (set) Token: 0x0600E849 RID: 59465 RVA: 0x003E3186 File Offset: 0x003E1386
		public int[] price { get; set; }

		// Token: 0x17001A3B RID: 6715
		// (get) Token: 0x0600E84A RID: 59466 RVA: 0x003E318F File Offset: 0x003E138F
		// (set) Token: 0x0600E84B RID: 59467 RVA: 0x003E3197 File Offset: 0x003E1397
		public int id { get; set; }

		// Token: 0x17001A3C RID: 6716
		// (get) Token: 0x0600E84C RID: 59468 RVA: 0x003E31A0 File Offset: 0x003E13A0
		// (set) Token: 0x0600E84D RID: 59469 RVA: 0x003E31A8 File Offset: 0x003E13A8
		public int tab { get; set; }

		// Token: 0x17001A3D RID: 6717
		// (get) Token: 0x0600E84E RID: 59470 RVA: 0x003E31B1 File Offset: 0x003E13B1
		// (set) Token: 0x0600E84F RID: 59471 RVA: 0x003E31B9 File Offset: 0x003E13B9
		public int type { get; set; }

		// Token: 0x0600E850 RID: 59472 RVA: 0x003E31C4 File Offset: 0x003E13C4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.front = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.price = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.price[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.realId = new string[num2];
				for (int j = 0; j < num2; j++)
				{
					this.realId[j] = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
				}
			}
			this.tab = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
