using System;

namespace core.config
{
	// Token: 0x02001CA5 RID: 7333
	public class AutoOpenPanel : XlsConfigBase<AutoOpenPanel, IAutoOpenPanelInfo>
	{
		// Token: 0x1700122B RID: 4651
		// (get) Token: 0x0600D47C RID: 54396 RVA: 0x003CA956 File Offset: 0x003C8B56
		public override string fileName
		{
			get
			{
				return "autoOpenPanel";
			}
		}

		// Token: 0x0600D47D RID: 54397 RVA: 0x003CA960 File Offset: 0x003C8B60
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IAutoOpenPanelInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IAutoOpenPanelInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D47E RID: 54398 RVA: 0x003CA9B4 File Offset: 0x003C8BB4
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
