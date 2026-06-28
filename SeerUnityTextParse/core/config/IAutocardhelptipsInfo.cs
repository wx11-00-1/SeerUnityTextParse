using System;

namespace core.config
{
	// Token: 0x0200257B RID: 9595
	public class IAutocardhelptipsInfo : IConfigItem
	{
		// Token: 0x170017DB RID: 6107
		// (get) Token: 0x06012997 RID: 76183 RVA: 0x00546814 File Offset: 0x00544A14
		// (set) Token: 0x06012998 RID: 76184 RVA: 0x0054681C File Offset: 0x00544A1C
		public string explain { get; set; }

		// Token: 0x170017DC RID: 6108
		// (get) Token: 0x06012999 RID: 76185 RVA: 0x00546825 File Offset: 0x00544A25
		// (set) Token: 0x0601299A RID: 76186 RVA: 0x0054682D File Offset: 0x00544A2D
		public string main { get; set; }

		// Token: 0x170017DD RID: 6109
		// (get) Token: 0x0601299B RID: 76187 RVA: 0x00546836 File Offset: 0x00544A36
		// (set) Token: 0x0601299C RID: 76188 RVA: 0x0054683E File Offset: 0x00544A3E
		public int id { get; set; }

		// Token: 0x0601299D RID: 76189 RVA: 0x00546847 File Offset: 0x00544A47
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.explain = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.main = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
