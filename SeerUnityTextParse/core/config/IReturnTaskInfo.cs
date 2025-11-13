using System;

namespace core.config
{
	// Token: 0x02001E00 RID: 7680
	public class IReturnTaskInfo : IConfigItem
	{
		// Token: 0x170017FC RID: 6140
		// (get) Token: 0x0600E2D4 RID: 58068 RVA: 0x003DC4B8 File Offset: 0x003DA6B8
		// (set) Token: 0x0600E2D5 RID: 58069 RVA: 0x003DC4C0 File Offset: 0x003DA6C0
		public int[] reward { get; set; }

		// Token: 0x170017FD RID: 6141
		// (get) Token: 0x0600E2D6 RID: 58070 RVA: 0x003DC4C9 File Offset: 0x003DA6C9
		// (set) Token: 0x0600E2D7 RID: 58071 RVA: 0x003DC4D1 File Offset: 0x003DA6D1
		public int id { get; set; }

		// Token: 0x170017FE RID: 6142
		// (get) Token: 0x0600E2D8 RID: 58072 RVA: 0x003DC4DA File Offset: 0x003DA6DA
		// (set) Token: 0x0600E2D9 RID: 58073 RVA: 0x003DC4E2 File Offset: 0x003DA6E2
		public int times { get; set; }

		// Token: 0x0600E2DA RID: 58074 RVA: 0x003DC4EC File Offset: 0x003DA6EC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.reward = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.reward[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.times = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
