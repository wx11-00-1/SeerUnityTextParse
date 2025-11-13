using System;

namespace core.config.monsters
{
	// Token: 0x02001FB7 RID: 8119
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001DCB RID: 7627
		// (get) Token: 0x0600F4A6 RID: 62630 RVA: 0x003F9EB4 File Offset: 0x003F80B4
		public override string fileName
		{
			get
			{
				return "monsters";
			}
		}

		// Token: 0x17001DCC RID: 7628
		// (get) Token: 0x0600F4A7 RID: 62631 RVA: 0x003F9EBB File Offset: 0x003F80BB
		// (set) Token: 0x0600F4A8 RID: 62632 RVA: 0x003F9EC3 File Offset: 0x003F80C3
		public IMonsters Monsters { get; set; }

		// Token: 0x0600F4A9 RID: 62633 RVA: 0x003F9ECC File Offset: 0x003F80CC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.Monsters = new IMonsters();
				this.Monsters.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600F4AA RID: 62634 RVA: 0x003F9EF0 File Offset: 0x003F80F0
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
