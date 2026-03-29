using System;

namespace core.config
{
	// Token: 0x020023EA RID: 9194
	public class Toolbar : XlsConfigBase<Toolbar, IToolbarInfo>
	{
		// Token: 0x1700215D RID: 8541
		// (get) Token: 0x06011B0E RID: 72462 RVA: 0x004A2167 File Offset: 0x004A0367
		public override string fileName
		{
			get
			{
				return "toolbar";
			}
		}

		// Token: 0x06011B0F RID: 72463 RVA: 0x004A2170 File Offset: 0x004A0370
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IToolbarInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IToolbarInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x06011B10 RID: 72464 RVA: 0x004A21C4 File Offset: 0x004A03C4
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
