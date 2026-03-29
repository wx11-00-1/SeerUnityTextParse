using System;

namespace core.config.TeamTasks
{
	// Token: 0x02002487 RID: 9351
	public class ITaskItem
	{
		// Token: 0x1700227D RID: 8829
		// (get) Token: 0x06012160 RID: 74080 RVA: 0x004B1EBC File Offset: 0x004B00BC
		// (set) Token: 0x06012161 RID: 74081 RVA: 0x004B1EC4 File Offset: 0x004B00C4
		public string BaseRewards { get; set; }

		// Token: 0x1700227E RID: 8830
		// (get) Token: 0x06012162 RID: 74082 RVA: 0x004B1ECD File Offset: 0x004B00CD
		// (set) Token: 0x06012163 RID: 74083 RVA: 0x004B1ED5 File Offset: 0x004B00D5
		public string ExtrRewards { get; set; }

		// Token: 0x1700227F RID: 8831
		// (get) Token: 0x06012164 RID: 74084 RVA: 0x004B1EDE File Offset: 0x004B00DE
		// (set) Token: 0x06012165 RID: 74085 RVA: 0x004B1EE6 File Offset: 0x004B00E6
		public string TaskDes { get; set; }

		// Token: 0x17002280 RID: 8832
		// (get) Token: 0x06012166 RID: 74086 RVA: 0x004B1EEF File Offset: 0x004B00EF
		// (set) Token: 0x06012167 RID: 74087 RVA: 0x004B1EF7 File Offset: 0x004B00F7
		public string TaskName { get; set; }

		// Token: 0x17002281 RID: 8833
		// (get) Token: 0x06012168 RID: 74088 RVA: 0x004B1F00 File Offset: 0x004B0100
		// (set) Token: 0x06012169 RID: 74089 RVA: 0x004B1F08 File Offset: 0x004B0108
		public int ID { get; set; }

		// Token: 0x0601216A RID: 74090 RVA: 0x004B1F14 File Offset: 0x004B0114
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.BaseRewards = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.ExtrRewards = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.TaskDes = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.TaskName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
