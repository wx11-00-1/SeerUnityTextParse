using System;

namespace core.config.Unbindmintinfo
{
	// Token: 0x02001F03 RID: 7939
	public class IUnbindmintinfoItem
	{
		// Token: 0x17001B09 RID: 6921
		// (get) Token: 0x0600EDBA RID: 60858 RVA: 0x003F191E File Offset: 0x003EFB1E
		// (set) Token: 0x0600EDBB RID: 60859 RVA: 0x003F1926 File Offset: 0x003EFB26
		public int MintmarkID { get; set; }

		// Token: 0x17001B0A RID: 6922
		// (get) Token: 0x0600EDBC RID: 60860 RVA: 0x003F192F File Offset: 0x003EFB2F
		// (set) Token: 0x0600EDBD RID: 60861 RVA: 0x003F1937 File Offset: 0x003EFB37
		public int NeedConsumeNum { get; set; }

		// Token: 0x0600EDBE RID: 60862 RVA: 0x003F1940 File Offset: 0x003EFB40
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.MintmarkID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.NeedConsumeNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
