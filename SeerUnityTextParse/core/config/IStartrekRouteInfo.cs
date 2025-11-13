using System;

namespace core.config
{
	// Token: 0x02001E42 RID: 7746
	public class IStartrekRouteInfo : IConfigItem
	{
		// Token: 0x17001926 RID: 6438
		// (get) Token: 0x0600E5AC RID: 58796 RVA: 0x003DFF40 File Offset: 0x003DE140
		// (set) Token: 0x0600E5AD RID: 58797 RVA: 0x003DFF48 File Offset: 0x003DE148
		public int[] arrive { get; set; }

		// Token: 0x17001927 RID: 6439
		// (get) Token: 0x0600E5AE RID: 58798 RVA: 0x003DFF51 File Offset: 0x003DE151
		// (set) Token: 0x0600E5AF RID: 58799 RVA: 0x003DFF59 File Offset: 0x003DE159
		public int id { get; set; }

		// Token: 0x0600E5B0 RID: 58800 RVA: 0x003DFF64 File Offset: 0x003DE164
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.arrive = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.arrive[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
