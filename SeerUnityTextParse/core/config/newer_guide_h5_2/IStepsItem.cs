using System;

namespace core.config.newer_guide_h5_2
{
	// Token: 0x02001F96 RID: 8086
	public class IStepsItem : IConfigItem
	{
		// Token: 0x17001CF5 RID: 7413
		// (get) Token: 0x0600F2B8 RID: 62136 RVA: 0x003F7980 File Offset: 0x003F5B80
		// (set) Token: 0x0600F2B9 RID: 62137 RVA: 0x003F7988 File Offset: 0x003F5B88
		public string align { get; set; }

		// Token: 0x17001CF6 RID: 7414
		// (get) Token: 0x0600F2BA RID: 62138 RVA: 0x003F7991 File Offset: 0x003F5B91
		// (set) Token: 0x0600F2BB RID: 62139 RVA: 0x003F7999 File Offset: 0x003F5B99
		public string btnName { get; set; }

		// Token: 0x17001CF7 RID: 7415
		// (get) Token: 0x0600F2BC RID: 62140 RVA: 0x003F79A2 File Offset: 0x003F5BA2
		// (set) Token: 0x0600F2BD RID: 62141 RVA: 0x003F79AA File Offset: 0x003F5BAA
		public string msg { get; set; }

		// Token: 0x17001CF8 RID: 7416
		// (get) Token: 0x0600F2BE RID: 62142 RVA: 0x003F79B3 File Offset: 0x003F5BB3
		// (set) Token: 0x0600F2BF RID: 62143 RVA: 0x003F79BB File Offset: 0x003F5BBB
		public string strokeColor { get; set; }

		// Token: 0x17001CF9 RID: 7417
		// (get) Token: 0x0600F2C0 RID: 62144 RVA: 0x003F79C4 File Offset: 0x003F5BC4
		// (set) Token: 0x0600F2C1 RID: 62145 RVA: 0x003F79CC File Offset: 0x003F5BCC
		public string targetBtn { get; set; }

		// Token: 0x17001CFA RID: 7418
		// (get) Token: 0x0600F2C2 RID: 62146 RVA: 0x003F79D5 File Offset: 0x003F5BD5
		// (set) Token: 0x0600F2C3 RID: 62147 RVA: 0x003F79DD File Offset: 0x003F5BDD
		public int[] position { get; set; }

		// Token: 0x17001CFB RID: 7419
		// (get) Token: 0x0600F2C4 RID: 62148 RVA: 0x003F79E6 File Offset: 0x003F5BE6
		// (set) Token: 0x0600F2C5 RID: 62149 RVA: 0x003F79EE File Offset: 0x003F5BEE
		public int autoX { get; set; }

		// Token: 0x17001CFC RID: 7420
		// (get) Token: 0x0600F2C6 RID: 62150 RVA: 0x003F79F7 File Offset: 0x003F5BF7
		// (set) Token: 0x0600F2C7 RID: 62151 RVA: 0x003F79FF File Offset: 0x003F5BFF
		public int holeType { get; set; }

		// Token: 0x17001CFD RID: 7421
		// (get) Token: 0x0600F2C8 RID: 62152 RVA: 0x003F7A08 File Offset: 0x003F5C08
		// (set) Token: 0x0600F2C9 RID: 62153 RVA: 0x003F7A10 File Offset: 0x003F5C10
		public int id { get; set; }

		// Token: 0x17001CFE RID: 7422
		// (get) Token: 0x0600F2CA RID: 62154 RVA: 0x003F7A19 File Offset: 0x003F5C19
		// (set) Token: 0x0600F2CB RID: 62155 RVA: 0x003F7A21 File Offset: 0x003F5C21
		public int openMenu { get; set; }

		// Token: 0x0600F2CC RID: 62156 RVA: 0x003F7A2C File Offset: 0x003F5C2C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.align = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.autoX = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.btnName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.holeType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.msg = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.openMenu = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.position = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.position[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.strokeColor = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.targetBtn = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
