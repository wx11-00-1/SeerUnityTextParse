using System;

namespace core.config
{
	// Token: 0x02001D5E RID: 7518
	public class IGlobalStrInfo : IConfigItem
	{
		// Token: 0x17001547 RID: 5447
		// (get) Token: 0x0600DC26 RID: 56358 RVA: 0x003D3EA4 File Offset: 0x003D20A4
		// (set) Token: 0x0600DC27 RID: 56359 RVA: 0x003D3EAC File Offset: 0x003D20AC
		public string content { get; set; }

		// Token: 0x17001548 RID: 5448
		// (get) Token: 0x0600DC28 RID: 56360 RVA: 0x003D3EB5 File Offset: 0x003D20B5
		// (set) Token: 0x0600DC29 RID: 56361 RVA: 0x003D3EBD File Offset: 0x003D20BD
		public string name { get; set; }

		// Token: 0x17001549 RID: 5449
		// (get) Token: 0x0600DC2A RID: 56362 RVA: 0x003D3EC6 File Offset: 0x003D20C6
		// (set) Token: 0x0600DC2B RID: 56363 RVA: 0x003D3ECE File Offset: 0x003D20CE
		public int id { get; set; }

		// Token: 0x0600DC2C RID: 56364 RVA: 0x003D3ED7 File Offset: 0x003D20D7
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.content = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
