using System;

namespace core.config.petbook
{
	// Token: 0x02001F6C RID: 8044
	public class IPetDataItem : IConfigItem
	{
		// Token: 0x17001C73 RID: 7283
		// (get) Token: 0x0600F160 RID: 61792 RVA: 0x003F603E File Offset: 0x003F423E
		// (set) Token: 0x0600F161 RID: 61793 RVA: 0x003F6046 File Offset: 0x003F4246
		public int[] TagB { get; set; }

		// Token: 0x17001C74 RID: 7284
		// (get) Token: 0x0600F162 RID: 61794 RVA: 0x003F604F File Offset: 0x003F424F
		// (set) Token: 0x0600F163 RID: 61795 RVA: 0x003F6057 File Offset: 0x003F4257
		public int id { get; set; }

		// Token: 0x17001C75 RID: 7285
		// (get) Token: 0x0600F164 RID: 61796 RVA: 0x003F6060 File Offset: 0x003F4260
		// (set) Token: 0x0600F165 RID: 61797 RVA: 0x003F6068 File Offset: 0x003F4268
		public int pid { get; set; }

		// Token: 0x17001C76 RID: 7286
		// (get) Token: 0x0600F166 RID: 61798 RVA: 0x003F6071 File Offset: 0x003F4271
		// (set) Token: 0x0600F167 RID: 61799 RVA: 0x003F6079 File Offset: 0x003F4279
		public int TagA { get; set; }

		// Token: 0x0600F168 RID: 61800 RVA: 0x003F6084 File Offset: 0x003F4284
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.TagA = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.TagB = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.TagB[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.pid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
