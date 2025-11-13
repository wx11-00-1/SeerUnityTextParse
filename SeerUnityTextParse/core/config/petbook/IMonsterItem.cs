using System;

namespace core.config.petbook
{
	// Token: 0x02001F6B RID: 8043
	public class IMonsterItem
	{
		// Token: 0x17001C6E RID: 7278
		// (get) Token: 0x0600F154 RID: 61780 RVA: 0x003F5F76 File Offset: 0x003F4176
		// (set) Token: 0x0600F155 RID: 61781 RVA: 0x003F5F7E File Offset: 0x003F417E
		public string DefName { get; set; }

		// Token: 0x17001C6F RID: 7279
		// (get) Token: 0x0600F156 RID: 61782 RVA: 0x003F5F87 File Offset: 0x003F4187
		// (set) Token: 0x0600F157 RID: 61783 RVA: 0x003F5F8F File Offset: 0x003F418F
		public string Features { get; set; }

		// Token: 0x17001C70 RID: 7280
		// (get) Token: 0x0600F158 RID: 61784 RVA: 0x003F5F98 File Offset: 0x003F4198
		// (set) Token: 0x0600F159 RID: 61785 RVA: 0x003F5FA0 File Offset: 0x003F41A0
		public string Target { get; set; }

		// Token: 0x17001C71 RID: 7281
		// (get) Token: 0x0600F15A RID: 61786 RVA: 0x003F5FA9 File Offset: 0x003F41A9
		// (set) Token: 0x0600F15B RID: 61787 RVA: 0x003F5FB1 File Offset: 0x003F41B1
		public string Tyjumptargetpe { get; set; }

		// Token: 0x17001C72 RID: 7282
		// (get) Token: 0x0600F15C RID: 61788 RVA: 0x003F5FBA File Offset: 0x003F41BA
		// (set) Token: 0x0600F15D RID: 61789 RVA: 0x003F5FC2 File Offset: 0x003F41C2
		public int ID { get; set; }

		// Token: 0x0600F15E RID: 61790 RVA: 0x003F5FCC File Offset: 0x003F41CC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.DefName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Features = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Target = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Tyjumptargetpe = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
