using System;

namespace core.config.skin_shop
{
	// Token: 0x02001F1C RID: 7964
	public class IRoot
	{
		// Token: 0x17001B60 RID: 7008
		// (get) Token: 0x0600EE9A RID: 61082 RVA: 0x003F2987 File Offset: 0x003F0B87
		// (set) Token: 0x0600EE9B RID: 61083 RVA: 0x003F298F File Offset: 0x003F0B8F
		public ISkins Skins { get; set; }

		// Token: 0x0600EE9C RID: 61084 RVA: 0x003F2998 File Offset: 0x003F0B98
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				this.Skins = new ISkins();
				this.Skins.Parse(bytes, ref byteIndex);
			}
		}
	}
}
