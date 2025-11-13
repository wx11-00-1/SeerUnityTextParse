using System;

namespace core.config
{
	// Token: 0x02001DA0 RID: 7584
	public class INewBraveChallengeInfo : IConfigItem
	{
		// Token: 0x17001640 RID: 5696
		// (get) Token: 0x0600DE9C RID: 56988 RVA: 0x003D70A0 File Offset: 0x003D52A0
		// (set) Token: 0x0600DE9D RID: 56989 RVA: 0x003D70A8 File Offset: 0x003D52A8
		public string title { get; set; }

		// Token: 0x17001641 RID: 5697
		// (get) Token: 0x0600DE9E RID: 56990 RVA: 0x003D70B1 File Offset: 0x003D52B1
		// (set) Token: 0x0600DE9F RID: 56991 RVA: 0x003D70B9 File Offset: 0x003D52B9
		public int[] rewardinfo { get; set; }

		// Token: 0x17001642 RID: 5698
		// (get) Token: 0x0600DEA0 RID: 56992 RVA: 0x003D70C2 File Offset: 0x003D52C2
		// (set) Token: 0x0600DEA1 RID: 56993 RVA: 0x003D70CA File Offset: 0x003D52CA
		public int id { get; set; }

		// Token: 0x17001643 RID: 5699
		// (get) Token: 0x0600DEA2 RID: 56994 RVA: 0x003D70D3 File Offset: 0x003D52D3
		// (set) Token: 0x0600DEA3 RID: 56995 RVA: 0x003D70DB File Offset: 0x003D52DB
		public int jump { get; set; }

		// Token: 0x0600DEA4 RID: 56996 RVA: 0x003D70E4 File Offset: 0x003D52E4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.jump = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.rewardinfo = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.rewardinfo[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.title = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
