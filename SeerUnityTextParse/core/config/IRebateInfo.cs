using System;

namespace core.config
{
	// Token: 0x02001DF0 RID: 7664
	public class IRebateInfo : IConfigItem
	{
		// Token: 0x170017BC RID: 6076
		// (get) Token: 0x0600E234 RID: 57908 RVA: 0x003DB65C File Offset: 0x003D985C
		// (set) Token: 0x0600E235 RID: 57909 RVA: 0x003DB664 File Offset: 0x003D9864
		public int[] rewardinfo { get; set; }

		// Token: 0x170017BD RID: 6077
		// (get) Token: 0x0600E236 RID: 57910 RVA: 0x003DB66D File Offset: 0x003D986D
		// (set) Token: 0x0600E237 RID: 57911 RVA: 0x003DB675 File Offset: 0x003D9875
		public int id { get; set; }

		// Token: 0x170017BE RID: 6078
		// (get) Token: 0x0600E238 RID: 57912 RVA: 0x003DB67E File Offset: 0x003D987E
		// (set) Token: 0x0600E239 RID: 57913 RVA: 0x003DB686 File Offset: 0x003D9886
		public int title { get; set; }

		// Token: 0x170017BF RID: 6079
		// (get) Token: 0x0600E23A RID: 57914 RVA: 0x003DB68F File Offset: 0x003D988F
		// (set) Token: 0x0600E23B RID: 57915 RVA: 0x003DB697 File Offset: 0x003D9897
		public int type { get; set; }

		// Token: 0x0600E23C RID: 57916 RVA: 0x003DB6A0 File Offset: 0x003D98A0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.rewardinfo = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.rewardinfo[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.title = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
