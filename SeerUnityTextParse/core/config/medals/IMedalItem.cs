using System;

namespace core.config.medals
{
	// Token: 0x02001FCD RID: 8141
	public class IMedalItem : IConfigItem
	{
		// Token: 0x17001E14 RID: 7700
		// (get) Token: 0x0600F569 RID: 62825 RVA: 0x003FADA4 File Offset: 0x003F8FA4
		// (set) Token: 0x0600F56A RID: 62826 RVA: 0x003FADAC File Offset: 0x003F8FAC
		public string title { get; set; }

		// Token: 0x17001E15 RID: 7701
		// (get) Token: 0x0600F56B RID: 62827 RVA: 0x003FADB5 File Offset: 0x003F8FB5
		// (set) Token: 0x0600F56C RID: 62828 RVA: 0x003FADBD File Offset: 0x003F8FBD
		public int achievepoint { get; set; }

		// Token: 0x17001E16 RID: 7702
		// (get) Token: 0x0600F56D RID: 62829 RVA: 0x003FADC6 File Offset: 0x003F8FC6
		// (set) Token: 0x0600F56E RID: 62830 RVA: 0x003FADCE File Offset: 0x003F8FCE
		public int award { get; set; }

		// Token: 0x17001E17 RID: 7703
		// (get) Token: 0x0600F56F RID: 62831 RVA: 0x003FADD7 File Offset: 0x003F8FD7
		// (set) Token: 0x0600F570 RID: 62832 RVA: 0x003FADDF File Offset: 0x003F8FDF
		public int hide { get; set; }

		// Token: 0x17001E18 RID: 7704
		// (get) Token: 0x0600F571 RID: 62833 RVA: 0x003FADE8 File Offset: 0x003F8FE8
		// (set) Token: 0x0600F572 RID: 62834 RVA: 0x003FADF0 File Offset: 0x003F8FF0
		public int id { get; set; }

		// Token: 0x0600F573 RID: 62835 RVA: 0x003FADFC File Offset: 0x003F8FFC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.achievepoint = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.award = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.hide = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.title = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
