using System;

namespace core.config
{
	// Token: 0x02001D2D RID: 7469
	public class DeepSeaMap : XlsConfigBase<DeepSeaMap, IDeepSeaMapInfo>
	{
		// Token: 0x1700147E RID: 5246
		// (get) Token: 0x0600DA32 RID: 55858 RVA: 0x003D16CB File Offset: 0x003CF8CB
		public override string fileName
		{
			get
			{
				return "deepSeaMap";
			}
		}

		// Token: 0x0600DA33 RID: 55859 RVA: 0x003D16D4 File Offset: 0x003CF8D4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IDeepSeaMapInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IDeepSeaMapInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DA34 RID: 55860 RVA: 0x003D1728 File Offset: 0x003CF928
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
