using System;

namespace core.config.elvenkingtrial_exchange
{
	// Token: 0x0200204B RID: 8267
	public class IItemItem : IConfigItem
	{
		// Token: 0x170020A2 RID: 8354
		// (get) Token: 0x0600FC6D RID: 64621 RVA: 0x00401E38 File Offset: 0x00400038
		// (set) Token: 0x0600FC6E RID: 64622 RVA: 0x00401E40 File Offset: 0x00400040
		public string NewStatLog { get; set; }

		// Token: 0x170020A3 RID: 8355
		// (get) Token: 0x0600FC6F RID: 64623 RVA: 0x00401E49 File Offset: 0x00400049
		// (set) Token: 0x0600FC70 RID: 64624 RVA: 0x00401E51 File Offset: 0x00400051
		public int bosslist { get; set; }

		// Token: 0x170020A4 RID: 8356
		// (get) Token: 0x0600FC71 RID: 64625 RVA: 0x00401E5A File Offset: 0x0040005A
		// (set) Token: 0x0600FC72 RID: 64626 RVA: 0x00401E62 File Offset: 0x00400062
		public string bosstitle { get; set; }

		// Token: 0x170020A5 RID: 8357
		// (get) Token: 0x0600FC73 RID: 64627 RVA: 0x00401E6B File Offset: 0x0040006B
		// (set) Token: 0x0600FC74 RID: 64628 RVA: 0x00401E73 File Offset: 0x00400073
		public int bsreward { get; set; }

		// Token: 0x170020A6 RID: 8358
		// (get) Token: 0x0600FC75 RID: 64629 RVA: 0x00401E7C File Offset: 0x0040007C
		// (set) Token: 0x0600FC76 RID: 64630 RVA: 0x00401E84 File Offset: 0x00400084
		public int difficulty { get; set; }

		// Token: 0x170020A7 RID: 8359
		// (get) Token: 0x0600FC77 RID: 64631 RVA: 0x00401E8D File Offset: 0x0040008D
		// (set) Token: 0x0600FC78 RID: 64632 RVA: 0x00401E95 File Offset: 0x00400095
		public int[] exreward { get; set; }

		// Token: 0x170020A8 RID: 8360
		// (get) Token: 0x0600FC79 RID: 64633 RVA: 0x00401E9E File Offset: 0x0040009E
		// (set) Token: 0x0600FC7A RID: 64634 RVA: 0x00401EA6 File Offset: 0x004000A6
		public string exrewardpro { get; set; }

		// Token: 0x170020A9 RID: 8361
		// (get) Token: 0x0600FC7B RID: 64635 RVA: 0x00401EAF File Offset: 0x004000AF
		// (set) Token: 0x0600FC7C RID: 64636 RVA: 0x00401EB7 File Offset: 0x004000B7
		public int id { get; set; }

		// Token: 0x170020AA RID: 8362
		// (get) Token: 0x0600FC7D RID: 64637 RVA: 0x00401EC0 File Offset: 0x004000C0
		// (set) Token: 0x0600FC7E RID: 64638 RVA: 0x00401EC8 File Offset: 0x004000C8
		public int mon { get; set; }

		// Token: 0x170020AB RID: 8363
		// (get) Token: 0x0600FC7F RID: 64639 RVA: 0x00401ED1 File Offset: 0x004000D1
		// (set) Token: 0x0600FC80 RID: 64640 RVA: 0x00401ED9 File Offset: 0x004000D9
		public int sebossid { get; set; }

		// Token: 0x170020AC RID: 8364
		// (get) Token: 0x0600FC81 RID: 64641 RVA: 0x00401EE2 File Offset: 0x004000E2
		// (set) Token: 0x0600FC82 RID: 64642 RVA: 0x00401EEA File Offset: 0x004000EA
		public int unlimite { get; set; }

		// Token: 0x0600FC83 RID: 64643 RVA: 0x00401EF4 File Offset: 0x004000F4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.NewStatLog = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.bosslist = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.bosstitle = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.bsreward = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.difficulty = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.b = ByteUtil.ReadBoolean(bytes, ref byteIndex);
			if (this.b)
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.exreward = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.exreward[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.exrewardpro = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.mon = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.sebossid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.unlimite = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}

		// Token: 0x0400F5F0 RID: 62960
		private bool b;
	}
}
