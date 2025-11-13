using System;

namespace core.config.new_super_design
{
	// Token: 0x02001F89 RID: 8073
	public class IRoot
	{
		// Token: 0x17001CCA RID: 7370
		// (get) Token: 0x0600F248 RID: 62024 RVA: 0x003F7187 File Offset: 0x003F5387
		// (set) Token: 0x0600F249 RID: 62025 RVA: 0x003F718F File Offset: 0x003F538F
		public IDesignItem[] Design { get; set; }

		// Token: 0x0600F24A RID: 62026 RVA: 0x003F7198 File Offset: 0x003F5398
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.Design = new IDesignItem[num];
				for (int i = 0; i < num; i++)
				{
					this.Design[i] = new IDesignItem();
					this.Design[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
