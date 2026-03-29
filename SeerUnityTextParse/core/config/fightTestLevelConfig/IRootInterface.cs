using System;

namespace core.config.fightTestLevelConfig
{
	// Token: 0x020025F4 RID: 9716
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x170028C4 RID: 10436
		// (get) Token: 0x060131B9 RID: 78265 RVA: 0x004C5096 File Offset: 0x004C3296
		public override string fileName
		{
			get
			{
				return "fightTestLevelConfig";
			}
		}

		// Token: 0x170028C5 RID: 10437
		// (get) Token: 0x060131BA RID: 78266 RVA: 0x004C509D File Offset: 0x004C329D
		// (set) Token: 0x060131BB RID: 78267 RVA: 0x004C50A5 File Offset: 0x004C32A5
		public IRoot root { get; set; }

		// Token: 0x060131BC RID: 78268 RVA: 0x004C50AE File Offset: 0x004C32AE
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.root = new IRoot();
				this.root.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x060131BD RID: 78269 RVA: 0x004C50D4 File Offset: 0x004C32D4
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
