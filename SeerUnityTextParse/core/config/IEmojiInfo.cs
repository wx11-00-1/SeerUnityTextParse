using System;

namespace core.config
{
	// Token: 0x02001D3E RID: 7486
	public class IEmojiInfo : IConfigItem
	{
		// Token: 0x170014B9 RID: 5305
		// (get) Token: 0x0600DACA RID: 56010 RVA: 0x003D2298 File Offset: 0x003D0498
		// (set) Token: 0x0600DACB RID: 56011 RVA: 0x003D22A0 File Offset: 0x003D04A0
		public string icon { get; set; }

		// Token: 0x170014BA RID: 5306
		// (get) Token: 0x0600DACC RID: 56012 RVA: 0x003D22A9 File Offset: 0x003D04A9
		// (set) Token: 0x0600DACD RID: 56013 RVA: 0x003D22B1 File Offset: 0x003D04B1
		public int id { get; set; }

		// Token: 0x0600DACE RID: 56014 RVA: 0x003D22BA File Offset: 0x003D04BA
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.icon = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
