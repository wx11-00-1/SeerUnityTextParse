using System;

namespace core.config.PetFightSkinSkillReplace
{
	// Token: 0x02001F4E RID: 8014
	public class IRoot
	{
		// Token: 0x17001C17 RID: 7191
		// (get) Token: 0x0600F06C RID: 61548 RVA: 0x003F4C99 File Offset: 0x003F2E99
		// (set) Token: 0x0600F06D RID: 61549 RVA: 0x003F4CA1 File Offset: 0x003F2EA1
		public IItemItem[] item { get; set; }

		// Token: 0x0600F06E RID: 61550 RVA: 0x003F4CAC File Offset: 0x003F2EAC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
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
	}
}
