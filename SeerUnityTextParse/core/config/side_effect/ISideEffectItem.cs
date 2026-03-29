using System;

namespace core.config.side_effect
{
	// Token: 0x020024A0 RID: 9376
	public class ISideEffectItem
	{
		// Token: 0x170022D9 RID: 8921
		// (get) Token: 0x0601224A RID: 74314 RVA: 0x004B3038 File Offset: 0x004B1238
		// (set) Token: 0x0601224B RID: 74315 RVA: 0x004B3040 File Offset: 0x004B1240
		public string SideEffectArg { get; set; }

		// Token: 0x170022DA RID: 8922
		// (get) Token: 0x0601224C RID: 74316 RVA: 0x004B3049 File Offset: 0x004B1249
		// (set) Token: 0x0601224D RID: 74317 RVA: 0x004B3051 File Offset: 0x004B1251
		public int ID { get; set; }

		// Token: 0x170022DB RID: 8923
		// (get) Token: 0x0601224E RID: 74318 RVA: 0x004B305A File Offset: 0x004B125A
		// (set) Token: 0x0601224F RID: 74319 RVA: 0x004B3062 File Offset: 0x004B1262
		public int SideEffectArgcount { get; set; }

		// Token: 0x06012250 RID: 74320 RVA: 0x004B306B File Offset: 0x004B126B
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.SideEffectArg = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.SideEffectArgcount = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
