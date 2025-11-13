using System;

namespace core.config
{
	// Token: 0x02001CB8 RID: 7352
	public class IBannerBisaifuInfo : IConfigItem
	{
		// Token: 0x17001273 RID: 4723
		// (get) Token: 0x0600D532 RID: 54578 RVA: 0x003CB6F8 File Offset: 0x003C98F8
		// (set) Token: 0x0600D533 RID: 54579 RVA: 0x003CB700 File Offset: 0x003C9900
		public string finishtime { get; set; }

		// Token: 0x17001274 RID: 4724
		// (get) Token: 0x0600D534 RID: 54580 RVA: 0x003CB709 File Offset: 0x003C9909
		// (set) Token: 0x0600D535 RID: 54581 RVA: 0x003CB711 File Offset: 0x003C9911
		public string image { get; set; }

		// Token: 0x17001275 RID: 4725
		// (get) Token: 0x0600D536 RID: 54582 RVA: 0x003CB71A File Offset: 0x003C991A
		// (set) Token: 0x0600D537 RID: 54583 RVA: 0x003CB722 File Offset: 0x003C9922
		public string starttime { get; set; }

		// Token: 0x17001276 RID: 4726
		// (get) Token: 0x0600D538 RID: 54584 RVA: 0x003CB72B File Offset: 0x003C992B
		// (set) Token: 0x0600D539 RID: 54585 RVA: 0x003CB733 File Offset: 0x003C9933
		public int id { get; set; }

		// Token: 0x17001277 RID: 4727
		// (get) Token: 0x0600D53A RID: 54586 RVA: 0x003CB73C File Offset: 0x003C993C
		// (set) Token: 0x0600D53B RID: 54587 RVA: 0x003CB744 File Offset: 0x003C9944
		public int isshow { get; set; }

		// Token: 0x17001278 RID: 4728
		// (get) Token: 0x0600D53C RID: 54588 RVA: 0x003CB74D File Offset: 0x003C994D
		// (set) Token: 0x0600D53D RID: 54589 RVA: 0x003CB755 File Offset: 0x003C9955
		public int sort { get; set; }

		// Token: 0x17001279 RID: 4729
		// (get) Token: 0x0600D53E RID: 54590 RVA: 0x003CB75E File Offset: 0x003C995E
		// (set) Token: 0x0600D53F RID: 54591 RVA: 0x003CB766 File Offset: 0x003C9966
		public int target { get; set; }

		// Token: 0x0600D540 RID: 54592 RVA: 0x003CB770 File Offset: 0x003C9970
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.finishtime = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.image = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.isshow = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.sort = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.starttime = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.target = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
