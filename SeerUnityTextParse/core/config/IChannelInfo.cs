using System;

namespace core.config
{
	// Token: 0x02001CE8 RID: 7400
	public class IChannelInfo : IConfigItem
	{
		// Token: 0x1700131B RID: 4891
		// (get) Token: 0x0600D6E2 RID: 55010 RVA: 0x003CD910 File Offset: 0x003CBB10
		// (set) Token: 0x0600D6E3 RID: 55011 RVA: 0x003CD918 File Offset: 0x003CBB18
		public string channel { get; set; }

		// Token: 0x1700131C RID: 4892
		// (get) Token: 0x0600D6E4 RID: 55012 RVA: 0x003CD921 File Offset: 0x003CBB21
		// (set) Token: 0x0600D6E5 RID: 55013 RVA: 0x003CD929 File Offset: 0x003CBB29
		public string maintainPopText { get; set; }

		// Token: 0x1700131D RID: 4893
		// (get) Token: 0x0600D6E6 RID: 55014 RVA: 0x003CD932 File Offset: 0x003CBB32
		// (set) Token: 0x0600D6E7 RID: 55015 RVA: 0x003CD93A File Offset: 0x003CBB3A
		public int id { get; set; }

		// Token: 0x0600D6E8 RID: 55016 RVA: 0x003CD943 File Offset: 0x003CBB43
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.channel = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.maintainPopText = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
