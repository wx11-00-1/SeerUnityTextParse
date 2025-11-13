using System;

namespace core.config.monsters_bisaifu
{
	// Token: 0x02001FAF RID: 8111
	public class IMonsters
	{
		// Token: 0x17001D9D RID: 7581
		// (get) Token: 0x0600F43A RID: 62522 RVA: 0x003F9710 File Offset: 0x003F7910
		// (set) Token: 0x0600F43B RID: 62523 RVA: 0x003F9718 File Offset: 0x003F7918
		public IMonsterItem[] Monster { get; set; }

		// Token: 0x0600F43C RID: 62524 RVA: 0x003F9724 File Offset: 0x003F7924
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.b = ByteUtil.ReadBoolean(bytes, ref byteIndex);
			if (this.b)
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

		// Token: 0x0400F2FA RID: 62202
		private bool b;
	}
}
