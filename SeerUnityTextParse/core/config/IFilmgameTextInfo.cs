using System;

namespace core.config
{
	// Token: 0x020028CB RID: 10443
	public class IFilmgameTextInfo : IConfigItem
	{
		// Token: 0x17001E9B RID: 7835
		// (get) Token: 0x06014EA8 RID: 85672 RVA: 0x005B69A0 File Offset: 0x005B4BA0
		// (set) Token: 0x06014EA9 RID: 85673 RVA: 0x005B69A8 File Offset: 0x005B4BA8
		public string text { get; set; }

		// Token: 0x17001E9C RID: 7836
		// (get) Token: 0x06014EAA RID: 85674 RVA: 0x005B69B1 File Offset: 0x005B4BB1
		// (set) Token: 0x06014EAB RID: 85675 RVA: 0x005B69B9 File Offset: 0x005B4BB9
		public int id { get; set; }

		// Token: 0x17001E9D RID: 7837
		// (get) Token: 0x06014EAC RID: 85676 RVA: 0x005B69C2 File Offset: 0x005B4BC2
		// (set) Token: 0x06014EAD RID: 85677 RVA: 0x005B69CA File Offset: 0x005B4BCA
		public int texttype { get; set; }

		// Token: 0x06014EAE RID: 85678 RVA: 0x005B69D3 File Offset: 0x005B4BD3
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.text = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.texttype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
