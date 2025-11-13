using System;

namespace core.config
{
	// Token: 0x02001C90 RID: 7312
	public class IActivityTaskConfigInfo : IConfigItem
	{
		// Token: 0x170011C5 RID: 4549
		// (get) Token: 0x0600D386 RID: 54150 RVA: 0x003C9768 File Offset: 0x003C7968
		// (set) Token: 0x0600D387 RID: 54151 RVA: 0x003C9770 File Offset: 0x003C7970
		public string describe { get; set; }

		// Token: 0x170011C6 RID: 4550
		// (get) Token: 0x0600D388 RID: 54152 RVA: 0x003C9779 File Offset: 0x003C7979
		// (set) Token: 0x0600D389 RID: 54153 RVA: 0x003C9781 File Offset: 0x003C7981
		public string rewardinfo { get; set; }

		// Token: 0x170011C7 RID: 4551
		// (get) Token: 0x0600D38A RID: 54154 RVA: 0x003C978A File Offset: 0x003C798A
		// (set) Token: 0x0600D38B RID: 54155 RVA: 0x003C9792 File Offset: 0x003C7992
		public string timeend { get; set; }

		// Token: 0x170011C8 RID: 4552
		// (get) Token: 0x0600D38C RID: 54156 RVA: 0x003C979B File Offset: 0x003C799B
		// (set) Token: 0x0600D38D RID: 54157 RVA: 0x003C97A3 File Offset: 0x003C79A3
		public string timelimit { get; set; }

		// Token: 0x170011C9 RID: 4553
		// (get) Token: 0x0600D38E RID: 54158 RVA: 0x003C97AC File Offset: 0x003C79AC
		// (set) Token: 0x0600D38F RID: 54159 RVA: 0x003C97B4 File Offset: 0x003C79B4
		public string timestart { get; set; }

		// Token: 0x170011CA RID: 4554
		// (get) Token: 0x0600D390 RID: 54160 RVA: 0x003C97BD File Offset: 0x003C79BD
		// (set) Token: 0x0600D391 RID: 54161 RVA: 0x003C97C5 File Offset: 0x003C79C5
		public string title { get; set; }

		// Token: 0x170011CB RID: 4555
		// (get) Token: 0x0600D392 RID: 54162 RVA: 0x003C97CE File Offset: 0x003C79CE
		// (set) Token: 0x0600D393 RID: 54163 RVA: 0x003C97D6 File Offset: 0x003C79D6
		public int activityid { get; set; }

		// Token: 0x170011CC RID: 4556
		// (get) Token: 0x0600D394 RID: 54164 RVA: 0x003C97DF File Offset: 0x003C79DF
		// (set) Token: 0x0600D395 RID: 54165 RVA: 0x003C97E7 File Offset: 0x003C79E7
		public int id { get; set; }

		// Token: 0x170011CD RID: 4557
		// (get) Token: 0x0600D396 RID: 54166 RVA: 0x003C97F0 File Offset: 0x003C79F0
		// (set) Token: 0x0600D397 RID: 54167 RVA: 0x003C97F8 File Offset: 0x003C79F8
		public int tasksubtype { get; set; }

		// Token: 0x170011CE RID: 4558
		// (get) Token: 0x0600D398 RID: 54168 RVA: 0x003C9801 File Offset: 0x003C7A01
		// (set) Token: 0x0600D399 RID: 54169 RVA: 0x003C9809 File Offset: 0x003C7A09
		public int time { get; set; }

		// Token: 0x170011CF RID: 4559
		// (get) Token: 0x0600D39A RID: 54170 RVA: 0x003C9812 File Offset: 0x003C7A12
		// (set) Token: 0x0600D39B RID: 54171 RVA: 0x003C981A File Offset: 0x003C7A1A
		public int userbitbuf { get; set; }

		// Token: 0x170011D0 RID: 4560
		// (get) Token: 0x0600D39C RID: 54172 RVA: 0x003C9823 File Offset: 0x003C7A23
		// (set) Token: 0x0600D39D RID: 54173 RVA: 0x003C982B File Offset: 0x003C7A2B
		public int userinfo { get; set; }

		// Token: 0x170011D1 RID: 4561
		// (get) Token: 0x0600D39E RID: 54174 RVA: 0x003C9834 File Offset: 0x003C7A34
		// (set) Token: 0x0600D39F RID: 54175 RVA: 0x003C983C File Offset: 0x003C7A3C
		public int value { get; set; }

		// Token: 0x0600D3A0 RID: 54176 RVA: 0x003C9848 File Offset: 0x003C7A48
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.activityid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.describe = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.rewardinfo = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.tasksubtype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.time = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.timeend = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.timelimit = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.timestart = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.title = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.userbitbuf = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.userinfo = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.value = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
