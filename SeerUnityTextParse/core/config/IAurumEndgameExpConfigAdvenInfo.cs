using System;

namespace core.config
{
	// Token: 0x02002429 RID: 9257
	public class IAurumEndgameExpConfigAdvenInfo : IConfigItem
	{
		// Token: 0x17001639 RID: 5689
		// (get) Token: 0x0601181C RID: 71708 RVA: 0x005004FC File Offset: 0x004FE6FC
		// (set) Token: 0x0601181D RID: 71709 RVA: 0x00500504 File Offset: 0x004FE704
		public string @event { get; set; }

		// Token: 0x1700163A RID: 5690
		// (get) Token: 0x0601181E RID: 71710 RVA: 0x0050050D File Offset: 0x004FE70D
		// (set) Token: 0x0601181F RID: 71711 RVA: 0x00500515 File Offset: 0x004FE715
		public int exp { get; set; }

		// Token: 0x1700163B RID: 5691
		// (get) Token: 0x06011820 RID: 71712 RVA: 0x0050051E File Offset: 0x004FE71E
		// (set) Token: 0x06011821 RID: 71713 RVA: 0x00500526 File Offset: 0x004FE726
		public int id { get; set; }

		// Token: 0x06011822 RID: 71714 RVA: 0x0050052F File Offset: 0x004FE72F
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.@event = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.exp = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
