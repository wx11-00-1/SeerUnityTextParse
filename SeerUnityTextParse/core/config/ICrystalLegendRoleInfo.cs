using System;

namespace core.config
{
	// Token: 0x02001D1A RID: 7450
	public class ICrystalLegendRoleInfo : IConfigItem
	{
		// Token: 0x1700143A RID: 5178
		// (get) Token: 0x0600D984 RID: 55684 RVA: 0x003D09E8 File Offset: 0x003CEBE8
		// (set) Token: 0x0600D985 RID: 55685 RVA: 0x003D09F0 File Offset: 0x003CEBF0
		public string des { get; set; }

		// Token: 0x1700143B RID: 5179
		// (get) Token: 0x0600D986 RID: 55686 RVA: 0x003D09F9 File Offset: 0x003CEBF9
		// (set) Token: 0x0600D987 RID: 55687 RVA: 0x003D0A01 File Offset: 0x003CEC01
		public string name { get; set; }

		// Token: 0x1700143C RID: 5180
		// (get) Token: 0x0600D988 RID: 55688 RVA: 0x003D0A0A File Offset: 0x003CEC0A
		// (set) Token: 0x0600D989 RID: 55689 RVA: 0x003D0A12 File Offset: 0x003CEC12
		public string startDice { get; set; }

		// Token: 0x1700143D RID: 5181
		// (get) Token: 0x0600D98A RID: 55690 RVA: 0x003D0A1B File Offset: 0x003CEC1B
		// (set) Token: 0x0600D98B RID: 55691 RVA: 0x003D0A23 File Offset: 0x003CEC23
		public int id { get; set; }

		// Token: 0x0600D98C RID: 55692 RVA: 0x003D0A2C File Offset: 0x003CEC2C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.des = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.startDice = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
