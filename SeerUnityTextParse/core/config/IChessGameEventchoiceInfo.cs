using System;

namespace core.config
{
	// Token: 0x02001CFC RID: 7420
	public class IChessGameEventchoiceInfo : IConfigItem
	{
		// Token: 0x170013B1 RID: 5041
		// (get) Token: 0x0600D836 RID: 55350 RVA: 0x003CF0D8 File Offset: 0x003CD2D8
		// (set) Token: 0x0600D837 RID: 55351 RVA: 0x003CF0E0 File Offset: 0x003CD2E0
		public string desc { get; set; }

		// Token: 0x170013B2 RID: 5042
		// (get) Token: 0x0600D838 RID: 55352 RVA: 0x003CF0E9 File Offset: 0x003CD2E9
		// (set) Token: 0x0600D839 RID: 55353 RVA: 0x003CF0F1 File Offset: 0x003CD2F1
		public string get { get; set; }

		// Token: 0x170013B3 RID: 5043
		// (get) Token: 0x0600D83A RID: 55354 RVA: 0x003CF0FA File Offset: 0x003CD2FA
		// (set) Token: 0x0600D83B RID: 55355 RVA: 0x003CF102 File Offset: 0x003CD302
		public string group { get; set; }

		// Token: 0x170013B4 RID: 5044
		// (get) Token: 0x0600D83C RID: 55356 RVA: 0x003CF10B File Offset: 0x003CD30B
		// (set) Token: 0x0600D83D RID: 55357 RVA: 0x003CF113 File Offset: 0x003CD313
		public string pay { get; set; }

		// Token: 0x170013B5 RID: 5045
		// (get) Token: 0x0600D83E RID: 55358 RVA: 0x003CF11C File Offset: 0x003CD31C
		// (set) Token: 0x0600D83F RID: 55359 RVA: 0x003CF124 File Offset: 0x003CD324
		public int id { get; set; }

		// Token: 0x0600D840 RID: 55360 RVA: 0x003CF130 File Offset: 0x003CD330
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.desc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.get = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.group = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.pay = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
