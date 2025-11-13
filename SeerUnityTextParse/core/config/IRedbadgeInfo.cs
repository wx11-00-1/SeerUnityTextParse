using System;

namespace core.config
{
	// Token: 0x02001DF4 RID: 7668
	public class IRedbadgeInfo : IConfigItem
	{
		// Token: 0x170017CA RID: 6090
		// (get) Token: 0x0600E258 RID: 57944 RVA: 0x003DB920 File Offset: 0x003D9B20
		// (set) Token: 0x0600E259 RID: 57945 RVA: 0x003DB928 File Offset: 0x003D9B28
		public string channel { get; set; }

		// Token: 0x170017CB RID: 6091
		// (get) Token: 0x0600E25A RID: 57946 RVA: 0x003DB931 File Offset: 0x003D9B31
		// (set) Token: 0x0600E25B RID: 57947 RVA: 0x003DB939 File Offset: 0x003D9B39
		public string subset { get; set; }

		// Token: 0x170017CC RID: 6092
		// (get) Token: 0x0600E25C RID: 57948 RVA: 0x003DB942 File Offset: 0x003D9B42
		// (set) Token: 0x0600E25D RID: 57949 RVA: 0x003DB94A File Offset: 0x003D9B4A
		public int endtime { get; set; }

		// Token: 0x170017CD RID: 6093
		// (get) Token: 0x0600E25E RID: 57950 RVA: 0x003DB953 File Offset: 0x003D9B53
		// (set) Token: 0x0600E25F RID: 57951 RVA: 0x003DB95B File Offset: 0x003D9B5B
		public int id { get; set; }

		// Token: 0x170017CE RID: 6094
		// (get) Token: 0x0600E260 RID: 57952 RVA: 0x003DB964 File Offset: 0x003D9B64
		// (set) Token: 0x0600E261 RID: 57953 RVA: 0x003DB96C File Offset: 0x003D9B6C
		public int isshow { get; set; }

		// Token: 0x170017CF RID: 6095
		// (get) Token: 0x0600E262 RID: 57954 RVA: 0x003DB975 File Offset: 0x003D9B75
		// (set) Token: 0x0600E263 RID: 57955 RVA: 0x003DB97D File Offset: 0x003D9B7D
		public int starttime { get; set; }

		// Token: 0x170017D0 RID: 6096
		// (get) Token: 0x0600E264 RID: 57956 RVA: 0x003DB986 File Offset: 0x003D9B86
		// (set) Token: 0x0600E265 RID: 57957 RVA: 0x003DB98E File Offset: 0x003D9B8E
		public int subtype { get; set; }

		// Token: 0x170017D1 RID: 6097
		// (get) Token: 0x0600E266 RID: 57958 RVA: 0x003DB997 File Offset: 0x003D9B97
		// (set) Token: 0x0600E267 RID: 57959 RVA: 0x003DB99F File Offset: 0x003D9B9F
		public int type { get; set; }

		// Token: 0x0600E268 RID: 57960 RVA: 0x003DB9A8 File Offset: 0x003D9BA8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.channel = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.endtime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.isshow = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.starttime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.subset = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.subtype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
