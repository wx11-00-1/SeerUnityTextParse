using System;

namespace core.config
{
	// Token: 0x02001D42 RID: 7490
	public class IExchangeRestrictInfo : IConfigItem
	{
		// Token: 0x170014C6 RID: 5318
		// (get) Token: 0x0600DAEC RID: 56044 RVA: 0x003D2510 File Offset: 0x003D0710
		// (set) Token: 0x0600DAED RID: 56045 RVA: 0x003D2518 File Offset: 0x003D0718
		public int id { get; set; }

		// Token: 0x170014C7 RID: 5319
		// (get) Token: 0x0600DAEE RID: 56046 RVA: 0x003D2521 File Offset: 0x003D0721
		// (set) Token: 0x0600DAEF RID: 56047 RVA: 0x003D2529 File Offset: 0x003D0729
		public string key { get; set; }

		// Token: 0x0600DAF0 RID: 56048 RVA: 0x003D2532 File Offset: 0x003D0732
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.key = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
