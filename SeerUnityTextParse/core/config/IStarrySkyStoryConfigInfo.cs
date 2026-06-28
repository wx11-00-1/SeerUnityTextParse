using System;

namespace core.config
{
	// Token: 0x020027F9 RID: 10233
	public class IStarrySkyStoryConfigInfo : IConfigItem
	{
		// Token: 0x1700238E RID: 9102
		// (get) Token: 0x060145F9 RID: 83449 RVA: 0x00568EAC File Offset: 0x005670AC
		// (set) Token: 0x060145FA RID: 83450 RVA: 0x00568EB4 File Offset: 0x005670B4
		public string desc { get; set; }

		// Token: 0x1700238F RID: 9103
		// (get) Token: 0x060145FB RID: 83451 RVA: 0x00568EBD File Offset: 0x005670BD
		// (set) Token: 0x060145FC RID: 83452 RVA: 0x00568EC5 File Offset: 0x005670C5
		public string image { get; set; }

		// Token: 0x17002390 RID: 9104
		// (get) Token: 0x060145FD RID: 83453 RVA: 0x00568ECE File Offset: 0x005670CE
		// (set) Token: 0x060145FE RID: 83454 RVA: 0x00568ED6 File Offset: 0x005670D6
		public string name { get; set; }

		// Token: 0x17002391 RID: 9105
		// (get) Token: 0x060145FF RID: 83455 RVA: 0x00568EDF File Offset: 0x005670DF
		// (set) Token: 0x06014600 RID: 83456 RVA: 0x00568EE7 File Offset: 0x005670E7
		public int id { get; set; }

		// Token: 0x17002392 RID: 9106
		// (get) Token: 0x06014601 RID: 83457 RVA: 0x00568EF0 File Offset: 0x005670F0
		// (set) Token: 0x06014602 RID: 83458 RVA: 0x00568EF8 File Offset: 0x005670F8
		public int unlock { get; set; }

		// Token: 0x06014603 RID: 83459 RVA: 0x00568F04 File Offset: 0x00567104
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.desc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.image = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.unlock = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
