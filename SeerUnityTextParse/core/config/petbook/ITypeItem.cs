using System;

namespace core.config.petbook
{
	// Token: 0x02001F71 RID: 8049
	public class ITypeItem
	{
		// Token: 0x17001C87 RID: 7303
		// (get) Token: 0x0600F192 RID: 61842 RVA: 0x003F6428 File Offset: 0x003F4628
		// (set) Token: 0x0600F193 RID: 61843 RVA: 0x003F6430 File Offset: 0x003F4630
		public IBranchItem[] Branch { get; set; }

		// Token: 0x17001C88 RID: 7304
		// (get) Token: 0x0600F194 RID: 61844 RVA: 0x003F6439 File Offset: 0x003F4639
		// (set) Token: 0x0600F195 RID: 61845 RVA: 0x003F6441 File Offset: 0x003F4641
		public int ID { get; set; }

		// Token: 0x0600F196 RID: 61846 RVA: 0x003F644C File Offset: 0x003F464C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.Branch = new IBranchItem[num];
				for (int i = 0; i < num; i++)
				{
					this.Branch[i] = new IBranchItem();
					this.Branch[i].Parse(bytes, ref byteIndex);
				}
			}
			this.ID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
