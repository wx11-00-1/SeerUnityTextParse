using System;

namespace core.config.mintmark_lottery
{
	// Token: 0x02001FC0 RID: 8128
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001DE5 RID: 7653
		// (get) Token: 0x0600F4EC RID: 62700 RVA: 0x003FA38B File Offset: 0x003F858B
		public override string fileName
		{
			get
			{
				return "mintmark_lottery";
			}
		}

		// Token: 0x17001DE6 RID: 7654
		// (get) Token: 0x0600F4ED RID: 62701 RVA: 0x003FA392 File Offset: 0x003F8592
		// (set) Token: 0x0600F4EE RID: 62702 RVA: 0x003FA39A File Offset: 0x003F859A
		public IMintmarks Mintmarks { get; set; }

		// Token: 0x0600F4EF RID: 62703 RVA: 0x003FA3A3 File Offset: 0x003F85A3
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.Mintmarks = new IMintmarks();
				this.Mintmarks.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600F4F0 RID: 62704 RVA: 0x003FA3C8 File Offset: 0x003F85C8
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
