using System;

namespace core.config.item_user_info
{
	// Token: 0x02001FDD RID: 8157
	public class IRootInterface : ConfigBase<IRootInterface>
	{
		// Token: 0x17001E3D RID: 7741
		// (get) Token: 0x0600F5DB RID: 62939 RVA: 0x003FB5AA File Offset: 0x003F97AA
		public override string fileName
		{
			get
			{
				return "item_user_info";
			}
		}

		// Token: 0x17001E3E RID: 7742
		// (get) Token: 0x0600F5DC RID: 62940 RVA: 0x003FB5B1 File Offset: 0x003F97B1
		// (set) Token: 0x0600F5DD RID: 62941 RVA: 0x003FB5B9 File Offset: 0x003F97B9
		public IRoot root { get; set; }

		// Token: 0x0600F5DE RID: 62942 RVA: 0x003FB5C2 File Offset: 0x003F97C2
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.root = new IRoot();
				this.root.Parse(bytes, ref byteIndex);
			}
		}

		// Token: 0x0600F5DF RID: 62943 RVA: 0x003FB5E8 File Offset: 0x003F97E8
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
