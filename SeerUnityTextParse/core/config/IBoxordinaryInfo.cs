using System;

namespace core.config
{
	// Token: 0x02001CCE RID: 7374
	public class IBoxordinaryInfo : IConfigItem
	{
		// Token: 0x170012CD RID: 4813
		// (get) Token: 0x0600D612 RID: 54802 RVA: 0x003CC75C File Offset: 0x003CA95C
		// (set) Token: 0x0600D613 RID: 54803 RVA: 0x003CC764 File Offset: 0x003CA964
		public string tips { get; set; }

		// Token: 0x170012CE RID: 4814
		// (get) Token: 0x0600D614 RID: 54804 RVA: 0x003CC76D File Offset: 0x003CA96D
		// (set) Token: 0x0600D615 RID: 54805 RVA: 0x003CC775 File Offset: 0x003CA975
		public int id { get; set; }

		// Token: 0x170012CF RID: 4815
		// (get) Token: 0x0600D616 RID: 54806 RVA: 0x003CC77E File Offset: 0x003CA97E
		// (set) Token: 0x0600D617 RID: 54807 RVA: 0x003CC786 File Offset: 0x003CA986
		public int itemid { get; set; }

		// Token: 0x0600D618 RID: 54808 RVA: 0x003CC78F File Offset: 0x003CA98F
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.itemid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.tips = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
