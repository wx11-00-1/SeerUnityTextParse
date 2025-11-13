using System;

namespace core.config.peakCrusade_levelRules
{
	// Token: 0x02001F77 RID: 8055
	public class IRoot
	{
		// Token: 0x17001C94 RID: 7316
		// (get) Token: 0x0600F1B8 RID: 61880 RVA: 0x003F66B9 File Offset: 0x003F48B9
		// (set) Token: 0x0600F1B9 RID: 61881 RVA: 0x003F66C1 File Offset: 0x003F48C1
		public IItemItem[] item { get; set; }

		// Token: 0x0600F1BA RID: 61882 RVA: 0x003F66CC File Offset: 0x003F48CC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.b = ByteUtil.ReadBoolean(bytes, ref byteIndex);
			if (this.b)
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.item = new IItemItem[num];
				for (int i = 0; i < num; i++)
				{
					this.item[i] = new IItemItem();
					this.item[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0400F1E7 RID: 61927
		private bool b;
	}
}
