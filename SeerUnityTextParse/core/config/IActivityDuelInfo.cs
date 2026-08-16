using System;

namespace core.config
{
	// Token: 0x0200275B RID: 10075
	public class IActivityDuelInfo : IConfigItem
	{
		// Token: 0x17001803 RID: 6147
		// (get) Token: 0x06013E98 RID: 81560 RVA: 0x005A38F4 File Offset: 0x005A1AF4
		// (set) Token: 0x06013E99 RID: 81561 RVA: 0x005A38FC File Offset: 0x005A1AFC
		public string chart { get; set; }

		// Token: 0x17001804 RID: 6148
		// (get) Token: 0x06013E9A RID: 81562 RVA: 0x005A3905 File Offset: 0x005A1B05
		// (set) Token: 0x06013E9B RID: 81563 RVA: 0x005A390D File Offset: 0x005A1B0D
		public string describe { get; set; }

		// Token: 0x17001805 RID: 6149
		// (get) Token: 0x06013E9C RID: 81564 RVA: 0x005A3916 File Offset: 0x005A1B16
		// (set) Token: 0x06013E9D RID: 81565 RVA: 0x005A391E File Offset: 0x005A1B1E
		public string name { get; set; }

		// Token: 0x17001806 RID: 6150
		// (get) Token: 0x06013E9E RID: 81566 RVA: 0x005A3927 File Offset: 0x005A1B27
		// (set) Token: 0x06013E9F RID: 81567 RVA: 0x005A392F File Offset: 0x005A1B2F
		public string rewardinfo { get; set; }

		// Token: 0x17001807 RID: 6151
		// (get) Token: 0x06013EA0 RID: 81568 RVA: 0x005A3938 File Offset: 0x005A1B38
		// (set) Token: 0x06013EA1 RID: 81569 RVA: 0x005A3940 File Offset: 0x005A1B40
		public string song { get; set; }

		// Token: 0x17001808 RID: 6152
		// (get) Token: 0x06013EA2 RID: 81570 RVA: 0x005A3949 File Offset: 0x005A1B49
		// (set) Token: 0x06013EA3 RID: 81571 RVA: 0x005A3951 File Offset: 0x005A1B51
		public string songRes { get; set; }

		// Token: 0x17001809 RID: 6153
		// (get) Token: 0x06013EA4 RID: 81572 RVA: 0x005A395A File Offset: 0x005A1B5A
		// (set) Token: 0x06013EA5 RID: 81573 RVA: 0x005A3962 File Offset: 0x005A1B62
		public int blood { get; set; }

		// Token: 0x1700180A RID: 6154
		// (get) Token: 0x06013EA6 RID: 81574 RVA: 0x005A396B File Offset: 0x005A1B6B
		// (set) Token: 0x06013EA7 RID: 81575 RVA: 0x005A3973 File Offset: 0x005A1B73
		public int difficulty { get; set; }

		// Token: 0x1700180B RID: 6155
		// (get) Token: 0x06013EA8 RID: 81576 RVA: 0x005A397C File Offset: 0x005A1B7C
		// (set) Token: 0x06013EA9 RID: 81577 RVA: 0x005A3984 File Offset: 0x005A1B84
		public int gametime { get; set; }

		// Token: 0x1700180C RID: 6156
		// (get) Token: 0x06013EAA RID: 81578 RVA: 0x005A398D File Offset: 0x005A1B8D
		// (set) Token: 0x06013EAB RID: 81579 RVA: 0x005A3995 File Offset: 0x005A1B95
		public int id { get; set; }

		// Token: 0x1700180D RID: 6157
		// (get) Token: 0x06013EAC RID: 81580 RVA: 0x005A399E File Offset: 0x005A1B9E
		// (set) Token: 0x06013EAD RID: 81581 RVA: 0x005A39A6 File Offset: 0x005A1BA6
		public int timeend { get; set; }

		// Token: 0x1700180E RID: 6158
		// (get) Token: 0x06013EAE RID: 81582 RVA: 0x005A39AF File Offset: 0x005A1BAF
		// (set) Token: 0x06013EAF RID: 81583 RVA: 0x005A39B7 File Offset: 0x005A1BB7
		public int timestart { get; set; }

		// Token: 0x1700180F RID: 6159
		// (get) Token: 0x06013EB0 RID: 81584 RVA: 0x005A39C0 File Offset: 0x005A1BC0
		// (set) Token: 0x06013EB1 RID: 81585 RVA: 0x005A39C8 File Offset: 0x005A1BC8
		public int type { get; set; }

		// Token: 0x06013EB2 RID: 81586 RVA: 0x005A39D4 File Offset: 0x005A1BD4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.blood = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.chart = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.describe = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.difficulty = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.gametime = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.rewardinfo = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.song = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.songRes = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.timeend = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.timestart = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
