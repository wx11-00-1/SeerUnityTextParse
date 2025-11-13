using System;

namespace core.config.advancedPetPanelConfig
{
	// Token: 0x0200207D RID: 8317
	public class ITaskItem
	{
		// Token: 0x1700212C RID: 8492
		// (get) Token: 0x0600FDE5 RID: 64997 RVA: 0x00403A14 File Offset: 0x00401C14
		// (set) Token: 0x0600FDE6 RID: 64998 RVA: 0x00403A1C File Offset: 0x00401C1C
		public ICompone Compone { get; set; }

		// Token: 0x1700212D RID: 8493
		// (get) Token: 0x0600FDE7 RID: 64999 RVA: 0x00403A25 File Offset: 0x00401C25
		// (set) Token: 0x0600FDE8 RID: 65000 RVA: 0x00403A2D File Offset: 0x00401C2D
		public string Jump { get; set; }

		// Token: 0x1700212E RID: 8494
		// (get) Token: 0x0600FDE9 RID: 65001 RVA: 0x00403A36 File Offset: 0x00401C36
		// (set) Token: 0x0600FDEA RID: 65002 RVA: 0x00403A3E File Offset: 0x00401C3E
		public string JumpH5 { get; set; }

		// Token: 0x1700212F RID: 8495
		// (get) Token: 0x0600FDEB RID: 65003 RVA: 0x00403A47 File Offset: 0x00401C47
		// (set) Token: 0x0600FDEC RID: 65004 RVA: 0x00403A4F File Offset: 0x00401C4F
		public IMainPanel MainPanel { get; set; }

		// Token: 0x17002130 RID: 8496
		// (get) Token: 0x0600FDED RID: 65005 RVA: 0x00403A58 File Offset: 0x00401C58
		// (set) Token: 0x0600FDEE RID: 65006 RVA: 0x00403A60 File Offset: 0x00401C60
		public int ID { get; set; }

		// Token: 0x0600FDEF RID: 65007 RVA: 0x00403A6C File Offset: 0x00401C6C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.Compone = new ICompone();
				this.Compone.Parse(bytes, ref byteIndex);
			}
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Jump = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.JumpH5 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.MainPanel = new IMainPanel();
				this.MainPanel.Parse(bytes, ref byteIndex);
			}
		}
	}
}
