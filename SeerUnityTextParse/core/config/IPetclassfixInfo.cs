using System;

namespace core.config
{
	// Token: 0x020022E9 RID: 8937
	public class IPetclassfixInfo : IConfigItem
	{
		// Token: 0x17001CB0 RID: 7344
		// (get) Token: 0x06010FB2 RID: 69554 RVA: 0x00494240 File Offset: 0x00492440
		// (set) Token: 0x06010FB3 RID: 69555 RVA: 0x00494248 File Offset: 0x00492448
		public string des { get; set; }

		// Token: 0x17001CB1 RID: 7345
		// (get) Token: 0x06010FB4 RID: 69556 RVA: 0x00494251 File Offset: 0x00492451
		// (set) Token: 0x06010FB5 RID: 69557 RVA: 0x00494259 File Offset: 0x00492459
		public int fixtype { get; set; }

		// Token: 0x17001CB2 RID: 7346
		// (get) Token: 0x06010FB6 RID: 69558 RVA: 0x00494262 File Offset: 0x00492462
		// (set) Token: 0x06010FB7 RID: 69559 RVA: 0x0049426A File Offset: 0x0049246A
		public int id { get; set; }

		// Token: 0x17001CB3 RID: 7347
		// (get) Token: 0x06010FB8 RID: 69560 RVA: 0x00494273 File Offset: 0x00492473
		// (set) Token: 0x06010FB9 RID: 69561 RVA: 0x0049427B File Offset: 0x0049247B
		public int petclass { get; set; }

		// Token: 0x17001CB4 RID: 7348
		// (get) Token: 0x06010FBA RID: 69562 RVA: 0x00494284 File Offset: 0x00492484
		// (set) Token: 0x06010FBB RID: 69563 RVA: 0x0049428C File Offset: 0x0049248C
		public int userinfo { get; set; }

		// Token: 0x06010FBC RID: 69564 RVA: 0x00494298 File Offset: 0x00492498
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.des = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.fixtype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.petclass = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.userinfo = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
