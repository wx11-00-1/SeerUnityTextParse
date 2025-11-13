using System;

namespace core.config
{
	// Token: 0x02001D9A RID: 7578
	public class IMonsterVideosInfo : IConfigItem
	{
		// Token: 0x1700162F RID: 5679
		// (get) Token: 0x0600DE6E RID: 56942 RVA: 0x003D6D24 File Offset: 0x003D4F24
		// (set) Token: 0x0600DE6F RID: 56943 RVA: 0x003D6D2C File Offset: 0x003D4F2C
		public string name { get; set; }

		// Token: 0x17001630 RID: 5680
		// (get) Token: 0x0600DE70 RID: 56944 RVA: 0x003D6D35 File Offset: 0x003D4F35
		// (set) Token: 0x0600DE71 RID: 56945 RVA: 0x003D6D3D File Offset: 0x003D4F3D
		public int id { get; set; }

		// Token: 0x0600DE72 RID: 56946 RVA: 0x003D6D46 File Offset: 0x003D4F46
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
