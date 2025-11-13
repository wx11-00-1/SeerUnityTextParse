using System;

namespace core.config.wenjuan
{
	// Token: 0x02001EF6 RID: 7926
	public class IWjmain
	{
		// Token: 0x17001ADA RID: 6874
		// (get) Token: 0x0600ED42 RID: 60738 RVA: 0x003F10A5 File Offset: 0x003EF2A5
		// (set) Token: 0x0600ED43 RID: 60739 RVA: 0x003F10AD File Offset: 0x003EF2AD
		public IWjItem[] wj { get; set; }

		// Token: 0x0600ED44 RID: 60740 RVA: 0x003F10B8 File Offset: 0x003EF2B8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.wj = new IWjItem[num];
				for (int i = 0; i < num; i++)
				{
					this.wj[i] = new IWjItem();
					this.wj[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
