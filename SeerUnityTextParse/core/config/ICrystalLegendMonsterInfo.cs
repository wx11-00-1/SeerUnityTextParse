using System;

namespace core.config
{
	// Token: 0x02001D16 RID: 7446
	public class ICrystalLegendMonsterInfo : IConfigItem
	{
		// Token: 0x17001430 RID: 5168
		// (get) Token: 0x0600D968 RID: 55656 RVA: 0x003D07D4 File Offset: 0x003CE9D4
		// (set) Token: 0x0600D969 RID: 55657 RVA: 0x003D07DC File Offset: 0x003CE9DC
		public string name { get; set; }

		// Token: 0x17001431 RID: 5169
		// (get) Token: 0x0600D96A RID: 55658 RVA: 0x003D07E5 File Offset: 0x003CE9E5
		// (set) Token: 0x0600D96B RID: 55659 RVA: 0x003D07ED File Offset: 0x003CE9ED
		public int artID { get; set; }

		// Token: 0x17001432 RID: 5170
		// (get) Token: 0x0600D96C RID: 55660 RVA: 0x003D07F6 File Offset: 0x003CE9F6
		// (set) Token: 0x0600D96D RID: 55661 RVA: 0x003D07FE File Offset: 0x003CE9FE
		public int id { get; set; }

		// Token: 0x0600D96E RID: 55662 RVA: 0x003D0807 File Offset: 0x003CEA07
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.artID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
