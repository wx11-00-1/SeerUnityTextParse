using System;

namespace core.config.vip_month_monster
{
	// Token: 0x02001EFC RID: 7932
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001AF4 RID: 6900
		// (get) Token: 0x0600ED82 RID: 60802 RVA: 0x003F1572 File Offset: 0x003EF772
		public override string fileName
		{
			get
			{
				return "vip_month_monster";
			}
		}

		// Token: 0x17001AF5 RID: 6901
		// (get) Token: 0x0600ED83 RID: 60803 RVA: 0x003F1579 File Offset: 0x003EF779
		// (set) Token: 0x0600ED84 RID: 60804 RVA: 0x003F1581 File Offset: 0x003EF781
		public IRoot Root { get; set; }

		// Token: 0x0600ED85 RID: 60805 RVA: 0x003F158A File Offset: 0x003EF78A
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.Root = new IRoot();
				this.Root.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600ED86 RID: 60806 RVA: 0x003F15B0 File Offset: 0x003EF7B0
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
