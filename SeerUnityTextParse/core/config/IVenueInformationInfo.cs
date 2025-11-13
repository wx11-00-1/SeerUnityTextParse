using System;

namespace core.config
{
	// Token: 0x02001E84 RID: 7812
	public class IVenueInformationInfo : IConfigItem
	{
		// Token: 0x17001A55 RID: 6741
		// (get) Token: 0x0600E88E RID: 59534 RVA: 0x003E3784 File Offset: 0x003E1984
		// (set) Token: 0x0600E88F RID: 59535 RVA: 0x003E378C File Offset: 0x003E198C
		public string venueEffect { get; set; }

		// Token: 0x17001A56 RID: 6742
		// (get) Token: 0x0600E890 RID: 59536 RVA: 0x003E3795 File Offset: 0x003E1995
		// (set) Token: 0x0600E891 RID: 59537 RVA: 0x003E379D File Offset: 0x003E199D
		public string venueName { get; set; }

		// Token: 0x17001A57 RID: 6743
		// (get) Token: 0x0600E892 RID: 59538 RVA: 0x003E37A6 File Offset: 0x003E19A6
		// (set) Token: 0x0600E893 RID: 59539 RVA: 0x003E37AE File Offset: 0x003E19AE
		public int id { get; set; }

		// Token: 0x0600E894 RID: 59540 RVA: 0x003E37B7 File Offset: 0x003E19B7
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.venueEffect = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.venueName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
