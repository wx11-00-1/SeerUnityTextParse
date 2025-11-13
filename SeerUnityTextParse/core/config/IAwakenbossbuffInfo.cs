using System;

namespace core.config
{
	// Token: 0x02001CA8 RID: 7336
	public class IAwakenbossbuffInfo : IConfigItem
	{
		// Token: 0x17001237 RID: 4663
		// (get) Token: 0x0600D49A RID: 54426 RVA: 0x003CABC4 File Offset: 0x003C8DC4
		// (set) Token: 0x0600D49B RID: 54427 RVA: 0x003CABCC File Offset: 0x003C8DCC
		public string des { get; set; }

		// Token: 0x17001238 RID: 4664
		// (get) Token: 0x0600D49C RID: 54428 RVA: 0x003CABD5 File Offset: 0x003C8DD5
		// (set) Token: 0x0600D49D RID: 54429 RVA: 0x003CABDD File Offset: 0x003C8DDD
		public string extranum { get; set; }

		// Token: 0x17001239 RID: 4665
		// (get) Token: 0x0600D49E RID: 54430 RVA: 0x003CABE6 File Offset: 0x003C8DE6
		// (set) Token: 0x0600D49F RID: 54431 RVA: 0x003CABEE File Offset: 0x003C8DEE
		public int bufftype { get; set; }

		// Token: 0x1700123A RID: 4666
		// (get) Token: 0x0600D4A0 RID: 54432 RVA: 0x003CABF7 File Offset: 0x003C8DF7
		// (set) Token: 0x0600D4A1 RID: 54433 RVA: 0x003CABFF File Offset: 0x003C8DFF
		public int id { get; set; }

		// Token: 0x0600D4A2 RID: 54434 RVA: 0x003CAC08 File Offset: 0x003C8E08
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.bufftype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.des = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.extranum = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
