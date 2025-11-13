using System;

namespace core.config.open_bonus
{
	// Token: 0x02001F81 RID: 8065
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001CA4 RID: 7332
		// (get) Token: 0x0600F1EC RID: 61932 RVA: 0x003F6ABA File Offset: 0x003F4CBA
		public override string fileName
		{
			get
			{
				return "open_bonus";
			}
		}

		// Token: 0x17001CA5 RID: 7333
		// (get) Token: 0x0600F1ED RID: 61933 RVA: 0x003F6AC1 File Offset: 0x003F4CC1
		// (set) Token: 0x0600F1EE RID: 61934 RVA: 0x003F6AC9 File Offset: 0x003F4CC9
		public IRoot Root { get; set; }

		// Token: 0x0600F1EF RID: 61935 RVA: 0x003F6AD2 File Offset: 0x003F4CD2
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.Root = new IRoot();
				this.Root.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600F1F0 RID: 61936 RVA: 0x003F6AF8 File Offset: 0x003F4CF8
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
