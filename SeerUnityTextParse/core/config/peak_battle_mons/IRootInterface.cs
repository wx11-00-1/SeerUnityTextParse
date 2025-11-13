using System;

namespace core.config.peak_battle_mons
{
	// Token: 0x02001F73 RID: 8051
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001C8A RID: 7306
		// (get) Token: 0x0600F19C RID: 61852 RVA: 0x003F651E File Offset: 0x003F471E
		public override string fileName
		{
			get
			{
				return "peak_battle_mons";
			}
		}

		// Token: 0x17001C8B RID: 7307
		// (get) Token: 0x0600F19D RID: 61853 RVA: 0x003F6525 File Offset: 0x003F4725
		// (set) Token: 0x0600F19E RID: 61854 RVA: 0x003F652D File Offset: 0x003F472D
		public IVirtualBattle VirtualBattle { get; set; }

		// Token: 0x0600F19F RID: 61855 RVA: 0x003F6536 File Offset: 0x003F4736
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.VirtualBattle = new IVirtualBattle();
				this.VirtualBattle.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600F1A0 RID: 61856 RVA: 0x003F655C File Offset: 0x003F475C
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
