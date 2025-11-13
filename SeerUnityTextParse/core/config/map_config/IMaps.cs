using System;

namespace core.config.map_config
{
	// Token: 0x02001FD5 RID: 8149
	public class IMaps
	{
		// Token: 0x17001E25 RID: 7717
		// (get) Token: 0x0600F59B RID: 62875 RVA: 0x003FB124 File Offset: 0x003F9324
		// (set) Token: 0x0600F59C RID: 62876 RVA: 0x003FB12C File Offset: 0x003F932C
		public IMapItem[] map { get; set; }

		// Token: 0x0600F59D RID: 62877 RVA: 0x003FB138 File Offset: 0x003F9338
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.map = new IMapItem[num];
				for (int i = 0; i < num; i++)
				{
					this.map[i] = new IMapItem();
					this.map[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
