using System;

namespace core.model
{
	// Token: 0x0200191A RID: 6426
	public class AvatarData
	{
		// Token: 0x0600CA38 RID: 51768 RVA: 0x003AF750 File Offset: 0x003AD950
		public AvatarData(ByteArray bytes = null)
		{
			if (bytes != null)
			{
				this.id = bytes.ReadSignedInt();
				this.obtm = bytes.ReadSignedInt();
			}
		}

		// Token: 0x0400DF07 RID: 57095
		public int id;

		// Token: 0x0400DF08 RID: 57096
		public int obtm;
	}
}
