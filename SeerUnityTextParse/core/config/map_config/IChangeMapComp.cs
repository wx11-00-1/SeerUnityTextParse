using System;

namespace core.config.map_config
{
	// Token: 0x02001FD0 RID: 8144
	public class IChangeMapComp
	{
		// Token: 0x17001E1C RID: 7708
		// (get) Token: 0x0600F57F RID: 62847 RVA: 0x003FAF24 File Offset: 0x003F9124
		// (set) Token: 0x0600F580 RID: 62848 RVA: 0x003FAF2C File Offset: 0x003F912C
		public IComponentItem[] component { get; set; }

		// Token: 0x0600F581 RID: 62849 RVA: 0x003FAF38 File Offset: 0x003F9138
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.component = new IComponentItem[num];
				for (int i = 0; i < num; i++)
				{
					this.component[i] = new IComponentItem();
					this.component[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
