using System;

namespace core.config.petbook_temp
{
	// Token: 0x02001F5B RID: 8027
	public class ITypeItem
	{
		// Token: 0x17001C3F RID: 7231
		// (get) Token: 0x0600F0D6 RID: 61654 RVA: 0x003F54E8 File Offset: 0x003F36E8
		// (set) Token: 0x0600F0D7 RID: 61655 RVA: 0x003F54F0 File Offset: 0x003F36F0
		public IBranchItem[] Branch { get; set; }

		// Token: 0x17001C40 RID: 7232
		// (get) Token: 0x0600F0D8 RID: 61656 RVA: 0x003F54F9 File Offset: 0x003F36F9
		// (set) Token: 0x0600F0D9 RID: 61657 RVA: 0x003F5501 File Offset: 0x003F3701
		public int ID { get; set; }

		// Token: 0x0600F0DA RID: 61658 RVA: 0x003F550C File Offset: 0x003F370C
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
