using System;

namespace core.config
{
	// Token: 0x02001D70 RID: 7536
	public class ILanguageInfo : IConfigItem
	{
		// Token: 0x17001587 RID: 5511
		// (get) Token: 0x0600DCCA RID: 56522 RVA: 0x003D4C34 File Offset: 0x003D2E34
		// (set) Token: 0x0600DCCB RID: 56523 RVA: 0x003D4C3C File Offset: 0x003D2E3C
		public string content { get; set; }

		// Token: 0x17001588 RID: 5512
		// (get) Token: 0x0600DCCC RID: 56524 RVA: 0x003D4C45 File Offset: 0x003D2E45
		// (set) Token: 0x0600DCCD RID: 56525 RVA: 0x003D4C4D File Offset: 0x003D2E4D
		public string key { get; set; }

		// Token: 0x17001589 RID: 5513
		// (get) Token: 0x0600DCCE RID: 56526 RVA: 0x003D4C56 File Offset: 0x003D2E56
		// (set) Token: 0x0600DCCF RID: 56527 RVA: 0x003D4C5E File Offset: 0x003D2E5E
		public int id { get; set; }

		// Token: 0x0600DCD0 RID: 56528 RVA: 0x003D4C67 File Offset: 0x003D2E67
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.content = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.key = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
