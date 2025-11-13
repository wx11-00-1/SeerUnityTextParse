using System;

namespace core.config
{
	// Token: 0x02001D98 RID: 7576
	public class IModuleInfo : IConfigItem
	{
		// Token: 0x17001629 RID: 5673
		// (get) Token: 0x0600DE5E RID: 56926 RVA: 0x003D6BC0 File Offset: 0x003D4DC0
		// (set) Token: 0x0600DE5F RID: 56927 RVA: 0x003D6BC8 File Offset: 0x003D4DC8
		public string moduleName { get; set; }

		// Token: 0x1700162A RID: 5674
		// (get) Token: 0x0600DE60 RID: 56928 RVA: 0x003D6BD1 File Offset: 0x003D4DD1
		// (set) Token: 0x0600DE61 RID: 56929 RVA: 0x003D6BD9 File Offset: 0x003D4DD9
		public string[] resConfig { get; set; }

		// Token: 0x1700162B RID: 5675
		// (get) Token: 0x0600DE62 RID: 56930 RVA: 0x003D6BE2 File Offset: 0x003D4DE2
		// (set) Token: 0x0600DE63 RID: 56931 RVA: 0x003D6BEA File Offset: 0x003D4DEA
		public int currAppDo { get; set; }

		// Token: 0x1700162C RID: 5676
		// (get) Token: 0x0600DE64 RID: 56932 RVA: 0x003D6BF3 File Offset: 0x003D4DF3
		// (set) Token: 0x0600DE65 RID: 56933 RVA: 0x003D6BFB File Offset: 0x003D4DFB
		public int id { get; set; }

		// Token: 0x1700162D RID: 5677
		// (get) Token: 0x0600DE66 RID: 56934 RVA: 0x003D6C04 File Offset: 0x003D4E04
		// (set) Token: 0x0600DE67 RID: 56935 RVA: 0x003D6C0C File Offset: 0x003D4E0C
		public int isFullScreen { get; set; }

		// Token: 0x0600DE68 RID: 56936 RVA: 0x003D6C18 File Offset: 0x003D4E18
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.currAppDo = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.isFullScreen = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.moduleName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.resConfig = new string[num];
				for (int i = 0; i < num; i++)
				{
					this.resConfig[i] = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
				}
			}
		}
	}
}
