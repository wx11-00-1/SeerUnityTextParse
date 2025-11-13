using System;

namespace core.config.titanlode
{
	// Token: 0x02001F0D RID: 7949
	public class IShowItem : IConfigItem
	{
		// Token: 0x17001B20 RID: 6944
		// (get) Token: 0x0600EDFC RID: 60924 RVA: 0x003F1E58 File Offset: 0x003F0058
		// (set) Token: 0x0600EDFD RID: 60925 RVA: 0x003F1E60 File Offset: 0x003F0060
		public int id { get; set; }

		// Token: 0x17001B21 RID: 6945
		// (get) Token: 0x0600EDFE RID: 60926 RVA: 0x003F1E69 File Offset: 0x003F0069
		// (set) Token: 0x0600EDFF RID: 60927 RVA: 0x003F1E71 File Offset: 0x003F0071
		public int randomcnt { get; set; }

		// Token: 0x17001B22 RID: 6946
		// (get) Token: 0x0600EE00 RID: 60928 RVA: 0x003F1E7A File Offset: 0x003F007A
		// (set) Token: 0x0600EE01 RID: 60929 RVA: 0x003F1E82 File Offset: 0x003F0082
		public int rewardid { get; set; }

		// Token: 0x0600EE02 RID: 60930 RVA: 0x003F1E8B File Offset: 0x003F008B
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.randomcnt = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.rewardid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
