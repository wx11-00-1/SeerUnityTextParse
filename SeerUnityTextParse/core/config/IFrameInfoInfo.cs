using System;

namespace core.config
{
	// Token: 0x0200225B RID: 8795
	public class IFrameInfoInfo : IConfigItem
	{
		// Token: 0x17001A2B RID: 6699
		// (get) Token: 0x0601098C RID: 67980 RVA: 0x0048C7F4 File Offset: 0x0048A9F4
		// (set) Token: 0x0601098D RID: 67981 RVA: 0x0048C7FC File Offset: 0x0048A9FC
		public int DefautlFrameID { get; set; }

		// Token: 0x17001A2C RID: 6700
		// (get) Token: 0x0601098E RID: 67982 RVA: 0x0048C805 File Offset: 0x0048AA05
		// (set) Token: 0x0601098F RID: 67983 RVA: 0x0048C80D File Offset: 0x0048AA0D
		public int FrameType { get; set; }

		// Token: 0x17001A2D RID: 6701
		// (get) Token: 0x06010990 RID: 67984 RVA: 0x0048C816 File Offset: 0x0048AA16
		// (set) Token: 0x06010991 RID: 67985 RVA: 0x0048C81E File Offset: 0x0048AA1E
		public int id { get; set; }

		// Token: 0x17001A2E RID: 6702
		// (get) Token: 0x06010992 RID: 67986 RVA: 0x0048C827 File Offset: 0x0048AA27
		// (set) Token: 0x06010993 RID: 67987 RVA: 0x0048C82F File Offset: 0x0048AA2F
		public int userinfo { get; set; }

		// Token: 0x06010994 RID: 67988 RVA: 0x0048C838 File Offset: 0x0048AA38
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.DefautlFrameID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.FrameType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.userinfo = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
