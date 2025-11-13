using System;

namespace core.config.MoveFgtvDes
{
	// Token: 0x02001FAC RID: 8108
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001D60 RID: 7520
		// (get) Token: 0x0600F3BA RID: 62394 RVA: 0x003F8DEA File Offset: 0x003F6FEA
		public override string fileName
		{
			get
			{
				return "MoveFgtvDes";
			}
		}

		// Token: 0x17001D61 RID: 7521
		// (get) Token: 0x0600F3BB RID: 62395 RVA: 0x003F8DF1 File Offset: 0x003F6FF1
		// (set) Token: 0x0600F3BC RID: 62396 RVA: 0x003F8DF9 File Offset: 0x003F6FF9
		public IRoot root { get; set; }

		// Token: 0x0600F3BD RID: 62397 RVA: 0x003F8E02 File Offset: 0x003F7002
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.root = new IRoot();
				this.root.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600F3BE RID: 62398 RVA: 0x003F8E28 File Offset: 0x003F7028
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
