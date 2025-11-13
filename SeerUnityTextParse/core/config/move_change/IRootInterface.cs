using System;

namespace core.config.move_change
{
	// Token: 0x02001FA4 RID: 8100
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001D45 RID: 7493
		// (get) Token: 0x0600F374 RID: 62324 RVA: 0x003F879F File Offset: 0x003F699F
		public override string fileName
		{
			get
			{
				return "move_change";
			}
		}

		// Token: 0x17001D46 RID: 7494
		// (get) Token: 0x0600F375 RID: 62325 RVA: 0x003F87A6 File Offset: 0x003F69A6
		// (set) Token: 0x0600F376 RID: 62326 RVA: 0x003F87AE File Offset: 0x003F69AE
		public IMove Move { get; set; }

		// Token: 0x0600F377 RID: 62327 RVA: 0x003F87B7 File Offset: 0x003F69B7
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.Move = new IMove();
				this.Move.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600F378 RID: 62328 RVA: 0x003F87DC File Offset: 0x003F69DC
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
