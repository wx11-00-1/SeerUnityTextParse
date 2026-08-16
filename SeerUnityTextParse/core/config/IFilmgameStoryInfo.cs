using System;

namespace core.config
{
	// Token: 0x020028C9 RID: 10441
	public class IFilmgameStoryInfo : IConfigItem
	{
		// Token: 0x17001E90 RID: 7824
		// (get) Token: 0x06014E8E RID: 85646 RVA: 0x005B67B0 File Offset: 0x005B49B0
		// (set) Token: 0x06014E8F RID: 85647 RVA: 0x005B67B8 File Offset: 0x005B49B8
		public string actlist { get; set; }

		// Token: 0x17001E91 RID: 7825
		// (get) Token: 0x06014E90 RID: 85648 RVA: 0x005B67C1 File Offset: 0x005B49C1
		// (set) Token: 0x06014E91 RID: 85649 RVA: 0x005B67C9 File Offset: 0x005B49C9
		public string acttype { get; set; }

		// Token: 0x17001E92 RID: 7826
		// (get) Token: 0x06014E92 RID: 85650 RVA: 0x005B67D2 File Offset: 0x005B49D2
		// (set) Token: 0x06014E93 RID: 85651 RVA: 0x005B67DA File Offset: 0x005B49DA
		public string bglist { get; set; }

		// Token: 0x17001E93 RID: 7827
		// (get) Token: 0x06014E94 RID: 85652 RVA: 0x005B67E3 File Offset: 0x005B49E3
		// (set) Token: 0x06014E95 RID: 85653 RVA: 0x005B67EB File Offset: 0x005B49EB
		public string name { get; set; }

		// Token: 0x17001E94 RID: 7828
		// (get) Token: 0x06014E96 RID: 85654 RVA: 0x005B67F4 File Offset: 0x005B49F4
		// (set) Token: 0x06014E97 RID: 85655 RVA: 0x005B67FC File Offset: 0x005B49FC
		public string recstyle { get; set; }

		// Token: 0x17001E95 RID: 7829
		// (get) Token: 0x06014E98 RID: 85656 RVA: 0x005B6805 File Offset: 0x005B4A05
		// (set) Token: 0x06014E99 RID: 85657 RVA: 0x005B680D File Offset: 0x005B4A0D
		public string trueactor { get; set; }

		// Token: 0x17001E96 RID: 7830
		// (get) Token: 0x06014E9A RID: 85658 RVA: 0x005B6816 File Offset: 0x005B4A16
		// (set) Token: 0x06014E9B RID: 85659 RVA: 0x005B681E File Offset: 0x005B4A1E
		public string truebg { get; set; }

		// Token: 0x17001E97 RID: 7831
		// (get) Token: 0x06014E9C RID: 85660 RVA: 0x005B6827 File Offset: 0x005B4A27
		// (set) Token: 0x06014E9D RID: 85661 RVA: 0x005B682F File Offset: 0x005B4A2F
		public int actnum { get; set; }

		// Token: 0x17001E98 RID: 7832
		// (get) Token: 0x06014E9E RID: 85662 RVA: 0x005B6838 File Offset: 0x005B4A38
		// (set) Token: 0x06014E9F RID: 85663 RVA: 0x005B6840 File Offset: 0x005B4A40
		public int id { get; set; }

		// Token: 0x17001E99 RID: 7833
		// (get) Token: 0x06014EA0 RID: 85664 RVA: 0x005B6849 File Offset: 0x005B4A49
		// (set) Token: 0x06014EA1 RID: 85665 RVA: 0x005B6851 File Offset: 0x005B4A51
		public int wordnum { get; set; }

		// Token: 0x06014EA2 RID: 85666 RVA: 0x005B685C File Offset: 0x005B4A5C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.actlist = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.actnum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.acttype = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.bglist = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.recstyle = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.trueactor = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.truebg = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.wordnum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
