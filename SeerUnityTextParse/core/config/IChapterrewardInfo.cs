using System;

namespace core.config
{
	// Token: 0x02001CF0 RID: 7408
	public class IChapterrewardInfo : IConfigItem
	{
		// Token: 0x1700135F RID: 4959
		// (get) Token: 0x0600D77A RID: 55162 RVA: 0x003CE3A0 File Offset: 0x003CC5A0
		// (set) Token: 0x0600D77B RID: 55163 RVA: 0x003CE3A8 File Offset: 0x003CC5A8
		public string item { get; set; }

		// Token: 0x17001360 RID: 4960
		// (get) Token: 0x0600D77C RID: 55164 RVA: 0x003CE3B1 File Offset: 0x003CC5B1
		// (set) Token: 0x0600D77D RID: 55165 RVA: 0x003CE3B9 File Offset: 0x003CC5B9
		public int chapterid { get; set; }

		// Token: 0x17001361 RID: 4961
		// (get) Token: 0x0600D77E RID: 55166 RVA: 0x003CE3C2 File Offset: 0x003CC5C2
		// (set) Token: 0x0600D77F RID: 55167 RVA: 0x003CE3CA File Offset: 0x003CC5CA
		public int id { get; set; }

		// Token: 0x17001362 RID: 4962
		// (get) Token: 0x0600D780 RID: 55168 RVA: 0x003CE3D3 File Offset: 0x003CC5D3
		// (set) Token: 0x0600D781 RID: 55169 RVA: 0x003CE3DB File Offset: 0x003CC5DB
		public int open { get; set; }

		// Token: 0x17001363 RID: 4963
		// (get) Token: 0x0600D782 RID: 55170 RVA: 0x003CE3E4 File Offset: 0x003CC5E4
		// (set) Token: 0x0600D783 RID: 55171 RVA: 0x003CE3EC File Offset: 0x003CC5EC
		public int order { get; set; }

		// Token: 0x17001364 RID: 4964
		// (get) Token: 0x0600D784 RID: 55172 RVA: 0x003CE3F5 File Offset: 0x003CC5F5
		// (set) Token: 0x0600D785 RID: 55173 RVA: 0x003CE3FD File Offset: 0x003CC5FD
		public int param { get; set; }

		// Token: 0x0600D786 RID: 55174 RVA: 0x003CE408 File Offset: 0x003CC608
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.chapterid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.item = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.open = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.order = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.param = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
