using System;

namespace core.config
{
	// Token: 0x02001E02 RID: 7682
	public class IReturnTaskNewInfo : IConfigItem
	{
		// Token: 0x17001800 RID: 6144
		// (get) Token: 0x0600E2E0 RID: 58080 RVA: 0x003DC5D0 File Offset: 0x003DA7D0
		// (set) Token: 0x0600E2E1 RID: 58081 RVA: 0x003DC5D8 File Offset: 0x003DA7D8
		public int[] reward { get; set; }

		// Token: 0x17001801 RID: 6145
		// (get) Token: 0x0600E2E2 RID: 58082 RVA: 0x003DC5E1 File Offset: 0x003DA7E1
		// (set) Token: 0x0600E2E3 RID: 58083 RVA: 0x003DC5E9 File Offset: 0x003DA7E9
		public int id { get; set; }

		// Token: 0x17001802 RID: 6146
		// (get) Token: 0x0600E2E4 RID: 58084 RVA: 0x003DC5F2 File Offset: 0x003DA7F2
		// (set) Token: 0x0600E2E5 RID: 58085 RVA: 0x003DC5FA File Offset: 0x003DA7FA
		public int progress { get; set; }

		// Token: 0x0600E2E6 RID: 58086 RVA: 0x003DC604 File Offset: 0x003DA804
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.progress = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.reward = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.reward[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
		}
	}
}
