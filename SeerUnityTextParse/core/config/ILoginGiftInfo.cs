using System;

namespace core.config
{
	// Token: 0x02001D84 RID: 7556
	public class ILoginGiftInfo : IConfigItem
	{
		// Token: 0x170015D5 RID: 5589
		// (get) Token: 0x0600DD8E RID: 56718 RVA: 0x003D5A7C File Offset: 0x003D3C7C
		// (set) Token: 0x0600DD8F RID: 56719 RVA: 0x003D5A84 File Offset: 0x003D3C84
		public string drop_list { get; set; }

		// Token: 0x170015D6 RID: 5590
		// (get) Token: 0x0600DD90 RID: 56720 RVA: 0x003D5A8D File Offset: 0x003D3C8D
		// (set) Token: 0x0600DD91 RID: 56721 RVA: 0x003D5A95 File Offset: 0x003D3C95
		public int id { get; set; }

		// Token: 0x0600DD92 RID: 56722 RVA: 0x003D5A9E File Offset: 0x003D3C9E
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.drop_list = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
