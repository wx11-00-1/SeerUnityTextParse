using System;

namespace core.config
{
	// Token: 0x02001D5A RID: 7514
	public class IFurnitureInfo : IConfigItem
	{
		// Token: 0x1700153B RID: 5435
		// (get) Token: 0x0600DC06 RID: 56326 RVA: 0x003D3C48 File Offset: 0x003D1E48
		// (set) Token: 0x0600DC07 RID: 56327 RVA: 0x003D3C50 File Offset: 0x003D1E50
		public string funcParam { get; set; }

		// Token: 0x1700153C RID: 5436
		// (get) Token: 0x0600DC08 RID: 56328 RVA: 0x003D3C59 File Offset: 0x003D1E59
		// (set) Token: 0x0600DC09 RID: 56329 RVA: 0x003D3C61 File Offset: 0x003D1E61
		public string name { get; set; }

		// Token: 0x1700153D RID: 5437
		// (get) Token: 0x0600DC0A RID: 56330 RVA: 0x003D3C6A File Offset: 0x003D1E6A
		// (set) Token: 0x0600DC0B RID: 56331 RVA: 0x003D3C72 File Offset: 0x003D1E72
		public int func { get; set; }

		// Token: 0x1700153E RID: 5438
		// (get) Token: 0x0600DC0C RID: 56332 RVA: 0x003D3C7B File Offset: 0x003D1E7B
		// (set) Token: 0x0600DC0D RID: 56333 RVA: 0x003D3C83 File Offset: 0x003D1E83
		public int funcIdentity { get; set; }

		// Token: 0x1700153F RID: 5439
		// (get) Token: 0x0600DC0E RID: 56334 RVA: 0x003D3C8C File Offset: 0x003D1E8C
		// (set) Token: 0x0600DC0F RID: 56335 RVA: 0x003D3C94 File Offset: 0x003D1E94
		public int id { get; set; }

		// Token: 0x17001540 RID: 5440
		// (get) Token: 0x0600DC10 RID: 56336 RVA: 0x003D3C9D File Offset: 0x003D1E9D
		// (set) Token: 0x0600DC11 RID: 56337 RVA: 0x003D3CA5 File Offset: 0x003D1EA5
		public int type { get; set; }

		// Token: 0x17001541 RID: 5441
		// (get) Token: 0x0600DC12 RID: 56338 RVA: 0x003D3CAE File Offset: 0x003D1EAE
		// (set) Token: 0x0600DC13 RID: 56339 RVA: 0x003D3CB6 File Offset: 0x003D1EB6
		public int vipOnly { get; set; }

		// Token: 0x0600DC14 RID: 56340 RVA: 0x003D3CC0 File Offset: 0x003D1EC0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.func = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.funcIdentity = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.funcParam = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.vipOnly = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
