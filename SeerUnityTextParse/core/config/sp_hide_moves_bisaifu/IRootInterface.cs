using System;

namespace core.config.sp_hide_moves_bisaifu
{
	// Token: 0x02001F16 RID: 7958
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001B3F RID: 6975
		// (get) Token: 0x0600EE4C RID: 61004 RVA: 0x003F245B File Offset: 0x003F065B
		public override string fileName
		{
			get
			{
				return "sp_hide_moves_bisaifu";
			}
		}

		// Token: 0x17001B40 RID: 6976
		// (get) Token: 0x0600EE4D RID: 61005 RVA: 0x003F2462 File Offset: 0x003F0662
		// (set) Token: 0x0600EE4E RID: 61006 RVA: 0x003F246A File Offset: 0x003F066A
		public IConfig config { get; set; }

		// Token: 0x0600EE4F RID: 61007 RVA: 0x003F2473 File Offset: 0x003F0673
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.config = new IConfig();
				this.config.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600EE50 RID: 61008 RVA: 0x003F2498 File Offset: 0x003F0698
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
