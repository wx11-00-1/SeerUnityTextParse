using System;

namespace core.config.wenjuan
{
	// Token: 0x02001EF4 RID: 7924
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001AD2 RID: 6866
		// (get) Token: 0x0600ED2E RID: 60718 RVA: 0x003F0F37 File Offset: 0x003EF137
		public override string fileName
		{
			get
			{
				return "wenjuan";
			}
		}

		// Token: 0x17001AD3 RID: 6867
		// (get) Token: 0x0600ED2F RID: 60719 RVA: 0x003F0F3E File Offset: 0x003EF13E
		// (set) Token: 0x0600ED30 RID: 60720 RVA: 0x003F0F46 File Offset: 0x003EF146
		public IRoot root { get; set; }

		// Token: 0x0600ED31 RID: 60721 RVA: 0x003F0F4F File Offset: 0x003EF14F
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.root = new IRoot();
				this.root.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600ED32 RID: 60722 RVA: 0x003F0F74 File Offset: 0x003EF174
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
