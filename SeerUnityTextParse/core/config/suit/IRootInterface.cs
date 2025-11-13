using System;

namespace core.config.suit
{
	// Token: 0x02001F14 RID: 7956
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001B3B RID: 6971
		// (get) Token: 0x0600EE40 RID: 60992 RVA: 0x003F233A File Offset: 0x003F053A
		public override string fileName
		{
			get
			{
				return "suit";
			}
		}

		// Token: 0x17001B3C RID: 6972
		// (get) Token: 0x0600EE41 RID: 60993 RVA: 0x003F2341 File Offset: 0x003F0541
		// (set) Token: 0x0600EE42 RID: 60994 RVA: 0x003F2349 File Offset: 0x003F0549
		public IRoot root { get; set; }

		// Token: 0x0600EE43 RID: 60995 RVA: 0x003F2352 File Offset: 0x003F0552
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.root = new IRoot();
				this.root.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600EE44 RID: 60996 RVA: 0x003F2378 File Offset: 0x003F0578
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
