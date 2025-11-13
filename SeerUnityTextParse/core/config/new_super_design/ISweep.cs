using System;

namespace core.config.new_super_design
{
	// Token: 0x02001F8D RID: 8077
	public class ISweep
	{
		// Token: 0x17001CD5 RID: 7381
		// (get) Token: 0x0600F266 RID: 62054 RVA: 0x003F73C6 File Offset: 0x003F55C6
		// (set) Token: 0x0600F267 RID: 62055 RVA: 0x003F73CE File Offset: 0x003F55CE
		public int[] ProductID { get; set; }

		// Token: 0x0600F268 RID: 62056 RVA: 0x003F73D8 File Offset: 0x003F55D8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.ProductID = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.ProductID[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
		}
	}
}
