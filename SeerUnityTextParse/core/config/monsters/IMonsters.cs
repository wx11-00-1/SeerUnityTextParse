using System;

namespace core.config.monsters
{
	// Token: 0x02001FB5 RID: 8117
	public class IMonsters
	{
		// Token: 0x17001DC6 RID: 7622
		// (get) Token: 0x0600F498 RID: 62616 RVA: 0x003F9DC4 File Offset: 0x003F7FC4
		// (set) Token: 0x0600F499 RID: 62617 RVA: 0x003F9DCC File Offset: 0x003F7FCC
		public IMonsterItem[] Monster { get; set; }

		// Token: 0x0600F49A RID: 62618 RVA: 0x003F9DD8 File Offset: 0x003F7FD8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.Monster = new IMonsterItem[num];
				for (int i = 0; i < num; i++)
				{
					this.Monster[i] = new IMonsterItem();
					this.Monster[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
