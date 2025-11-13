using System;

namespace core.config
{
	// Token: 0x02001DC0 RID: 7616
	public class IPetItemInfo : IConfigItem
	{
		// Token: 0x170016E4 RID: 5860
		// (get) Token: 0x0600E024 RID: 57380 RVA: 0x003D8EC0 File Offset: 0x003D70C0
		// (set) Token: 0x0600E025 RID: 57381 RVA: 0x003D8EC8 File Offset: 0x003D70C8
		public string param { get; set; }

		// Token: 0x170016E5 RID: 5861
		// (get) Token: 0x0600E026 RID: 57382 RVA: 0x003D8ED1 File Offset: 0x003D70D1
		// (set) Token: 0x0600E027 RID: 57383 RVA: 0x003D8ED9 File Offset: 0x003D70D9
		public int id { get; set; }

		// Token: 0x170016E6 RID: 5862
		// (get) Token: 0x0600E028 RID: 57384 RVA: 0x003D8EE2 File Offset: 0x003D70E2
		// (set) Token: 0x0600E029 RID: 57385 RVA: 0x003D8EEA File Offset: 0x003D70EA
		public int type { get; set; }

		// Token: 0x0600E02A RID: 57386 RVA: 0x003D8EF3 File Offset: 0x003D70F3
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.param = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
