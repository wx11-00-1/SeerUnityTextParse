using System;

namespace core.config.pet_skin
{
	// Token: 0x02001F3A RID: 7994
	public class IPetSkins
	{
		// Token: 0x17001BD6 RID: 7126
		// (get) Token: 0x0600EFC2 RID: 61378 RVA: 0x003F3FE0 File Offset: 0x003F21E0
		// (set) Token: 0x0600EFC3 RID: 61379 RVA: 0x003F3FE8 File Offset: 0x003F21E8
		public ISkinItem[] Skin { get; set; }

		// Token: 0x0600EFC4 RID: 61380 RVA: 0x003F3FF4 File Offset: 0x003F21F4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.Skin = new ISkinItem[num];
				for (int i = 0; i < num; i++)
				{
					this.Skin[i] = new ISkinItem();
					this.Skin[i].Parse(bytes, ref byteIndex);
				}
			}
		}
	}
}
