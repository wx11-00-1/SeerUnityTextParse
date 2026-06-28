using System;

namespace core.config
{
	// Token: 0x02002579 RID: 9593
	public class IAutocardEntryInfo : IConfigItem
	{
		// Token: 0x170017D7 RID: 6103
		// (get) Token: 0x0601298B RID: 76171 RVA: 0x00546724 File Offset: 0x00544924
		// (set) Token: 0x0601298C RID: 76172 RVA: 0x0054672C File Offset: 0x0054492C
		public string entrycontent { get; set; }

		// Token: 0x170017D8 RID: 6104
		// (get) Token: 0x0601298D RID: 76173 RVA: 0x00546735 File Offset: 0x00544935
		// (set) Token: 0x0601298E RID: 76174 RVA: 0x0054673D File Offset: 0x0054493D
		public string type { get; set; }

		// Token: 0x170017D9 RID: 6105
		// (get) Token: 0x0601298F RID: 76175 RVA: 0x00546746 File Offset: 0x00544946
		// (set) Token: 0x06012990 RID: 76176 RVA: 0x0054674E File Offset: 0x0054494E
		public int id { get; set; }

		// Token: 0x06012991 RID: 76177 RVA: 0x00546757 File Offset: 0x00544957
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.entrycontent = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.type = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
