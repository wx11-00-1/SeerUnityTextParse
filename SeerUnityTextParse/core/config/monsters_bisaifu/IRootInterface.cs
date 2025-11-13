using System;

namespace core.config.monsters_bisaifu
{
	// Token: 0x02001FB1 RID: 8113
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001DA2 RID: 7586
		// (get) Token: 0x0600F448 RID: 62536 RVA: 0x003F980C File Offset: 0x003F7A0C
		public override string fileName
		{
			get
			{
				return "monsters_bisaifu";
			}
		}

		// Token: 0x17001DA3 RID: 7587
		// (get) Token: 0x0600F449 RID: 62537 RVA: 0x003F9813 File Offset: 0x003F7A13
		// (set) Token: 0x0600F44A RID: 62538 RVA: 0x003F981B File Offset: 0x003F7A1B
		public IMonsters Monsters { get; set; }

		// Token: 0x0600F44B RID: 62539 RVA: 0x003F9824 File Offset: 0x003F7A24
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.b = ByteUtil.ReadBoolean(bytes, ref byteIndex);
			if (this.b)
			{
				this.Monsters = new IMonsters();
				this.Monsters.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600F44C RID: 62540 RVA: 0x003F9854 File Offset: 0x003F7A54
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}

		// Token: 0x0400F300 RID: 62208
		private bool b;
	}
}
