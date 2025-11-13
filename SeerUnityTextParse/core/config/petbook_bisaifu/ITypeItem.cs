using System;

namespace core.config.petbook_bisaifu
{
	// Token: 0x02001F66 RID: 8038
	public class ITypeItem
	{
		// Token: 0x17001C63 RID: 7267
		// (get) Token: 0x0600F134 RID: 61748 RVA: 0x003F5C84 File Offset: 0x003F3E84
		// (set) Token: 0x0600F135 RID: 61749 RVA: 0x003F5C8C File Offset: 0x003F3E8C
		public IBranchItem[] Branch { get; set; }

		// Token: 0x17001C64 RID: 7268
		// (get) Token: 0x0600F136 RID: 61750 RVA: 0x003F5C95 File Offset: 0x003F3E95
		// (set) Token: 0x0600F137 RID: 61751 RVA: 0x003F5C9D File Offset: 0x003F3E9D
		public int ID { get; set; }

		// Token: 0x0600F138 RID: 61752 RVA: 0x003F5CA8 File Offset: 0x003F3EA8
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
