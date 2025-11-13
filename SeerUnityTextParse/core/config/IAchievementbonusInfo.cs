using System;

namespace core.config
{
	// Token: 0x02001C82 RID: 7298
	public class IAchievementbonusInfo : IConfigItem
	{
		// Token: 0x1700115E RID: 4446
		// (get) Token: 0x0600D29C RID: 53916 RVA: 0x003C86F4 File Offset: 0x003C68F4
		// (set) Token: 0x0600D29D RID: 53917 RVA: 0x003C86FC File Offset: 0x003C68FC
		public string rewardcnt { get; set; }

		// Token: 0x1700115F RID: 4447
		// (get) Token: 0x0600D29E RID: 53918 RVA: 0x003C8705 File Offset: 0x003C6905
		// (set) Token: 0x0600D29F RID: 53919 RVA: 0x003C870D File Offset: 0x003C690D
		public string rewardid { get; set; }

		// Token: 0x17001160 RID: 4448
		// (get) Token: 0x0600D2A0 RID: 53920 RVA: 0x003C8716 File Offset: 0x003C6916
		// (set) Token: 0x0600D2A1 RID: 53921 RVA: 0x003C871E File Offset: 0x003C691E
		public int Branch { get; set; }

		// Token: 0x17001161 RID: 4449
		// (get) Token: 0x0600D2A2 RID: 53922 RVA: 0x003C8727 File Offset: 0x003C6927
		// (set) Token: 0x0600D2A3 RID: 53923 RVA: 0x003C872F File Offset: 0x003C692F
		public int id { get; set; }

		// Token: 0x17001162 RID: 4450
		// (get) Token: 0x0600D2A4 RID: 53924 RVA: 0x003C8738 File Offset: 0x003C6938
		// (set) Token: 0x0600D2A5 RID: 53925 RVA: 0x003C8740 File Offset: 0x003C6940
		public int rewardtype { get; set; }

		// Token: 0x17001163 RID: 4451
		// (get) Token: 0x0600D2A6 RID: 53926 RVA: 0x003C8749 File Offset: 0x003C6949
		// (set) Token: 0x0600D2A7 RID: 53927 RVA: 0x003C8751 File Offset: 0x003C6951
		public int Rule { get; set; }

		// Token: 0x0600D2A8 RID: 53928 RVA: 0x003C875C File Offset: 0x003C695C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.Branch = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Rule = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.rewardcnt = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.rewardid = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.rewardtype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
