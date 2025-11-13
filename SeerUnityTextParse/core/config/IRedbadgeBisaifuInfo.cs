using System;

namespace core.config
{
	// Token: 0x02001DF6 RID: 7670
	public class IRedbadgeBisaifuInfo : IConfigItem
	{
		// Token: 0x170017D3 RID: 6099
		// (get) Token: 0x0600E26E RID: 57966 RVA: 0x003DBAB0 File Offset: 0x003D9CB0
		// (set) Token: 0x0600E26F RID: 57967 RVA: 0x003DBAB8 File Offset: 0x003D9CB8
		public string subset { get; set; }

		// Token: 0x170017D4 RID: 6100
		// (get) Token: 0x0600E270 RID: 57968 RVA: 0x003DBAC1 File Offset: 0x003D9CC1
		// (set) Token: 0x0600E271 RID: 57969 RVA: 0x003DBAC9 File Offset: 0x003D9CC9
		public int endtime { get; set; }

		// Token: 0x170017D5 RID: 6101
		// (get) Token: 0x0600E272 RID: 57970 RVA: 0x003DBAD2 File Offset: 0x003D9CD2
		// (set) Token: 0x0600E273 RID: 57971 RVA: 0x003DBADA File Offset: 0x003D9CDA
		public int id { get; set; }

		// Token: 0x170017D6 RID: 6102
		// (get) Token: 0x0600E274 RID: 57972 RVA: 0x003DBAE3 File Offset: 0x003D9CE3
		// (set) Token: 0x0600E275 RID: 57973 RVA: 0x003DBAEB File Offset: 0x003D9CEB
		public int isshow { get; set; }

		// Token: 0x170017D7 RID: 6103
		// (get) Token: 0x0600E276 RID: 57974 RVA: 0x003DBAF4 File Offset: 0x003D9CF4
		// (set) Token: 0x0600E277 RID: 57975 RVA: 0x003DBAFC File Offset: 0x003D9CFC
		public int subtype { get; set; }

		// Token: 0x170017D8 RID: 6104
		// (get) Token: 0x0600E278 RID: 57976 RVA: 0x003DBB05 File Offset: 0x003D9D05
		// (set) Token: 0x0600E279 RID: 57977 RVA: 0x003DBB0D File Offset: 0x003D9D0D
		public int type { get; set; }

		// Token: 0x0600E27A RID: 57978 RVA: 0x003DBB18 File Offset: 0x003D9D18
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.endtime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.isshow = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.subset = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.subtype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
