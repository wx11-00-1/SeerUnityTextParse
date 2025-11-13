using System;

namespace core.config
{
	// Token: 0x02001C92 RID: 7314
	public class IAdastraActivityRewardInfo : IConfigItem
	{
		// Token: 0x170011D3 RID: 4563
		// (get) Token: 0x0600D3A6 RID: 54182 RVA: 0x003C99AC File Offset: 0x003C7BAC
		// (set) Token: 0x0600D3A7 RID: 54183 RVA: 0x003C99B4 File Offset: 0x003C7BB4
		public string reward { get; set; }

		// Token: 0x170011D4 RID: 4564
		// (get) Token: 0x0600D3A8 RID: 54184 RVA: 0x003C99BD File Offset: 0x003C7BBD
		// (set) Token: 0x0600D3A9 RID: 54185 RVA: 0x003C99C5 File Offset: 0x003C7BC5
		public int condition { get; set; }

		// Token: 0x170011D5 RID: 4565
		// (get) Token: 0x0600D3AA RID: 54186 RVA: 0x003C99CE File Offset: 0x003C7BCE
		// (set) Token: 0x0600D3AB RID: 54187 RVA: 0x003C99D6 File Offset: 0x003C7BD6
		public int id { get; set; }

		// Token: 0x170011D6 RID: 4566
		// (get) Token: 0x0600D3AC RID: 54188 RVA: 0x003C99DF File Offset: 0x003C7BDF
		// (set) Token: 0x0600D3AD RID: 54189 RVA: 0x003C99E7 File Offset: 0x003C7BE7
		public int type { get; set; }

		// Token: 0x0600D3AE RID: 54190 RVA: 0x003C99F0 File Offset: 0x003C7BF0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.condition = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.reward = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
