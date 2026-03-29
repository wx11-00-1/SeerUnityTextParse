using System;

namespace core.config
{
	// Token: 0x0200219C RID: 8604
	public class BraveTower : XlsConfigBase<BraveTower, IBraveTowerInfo>
	{
		// Token: 0x17001695 RID: 5781
		// (get) Token: 0x060100E2 RID: 65762 RVA: 0x00482228 File Offset: 0x00480428
		public override string fileName
		{
			get
			{
				return "brave_tower";
			}
		}

		// Token: 0x060100E3 RID: 65763 RVA: 0x00482230 File Offset: 0x00480430
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IBraveTowerInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IBraveTowerInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x060100E4 RID: 65764 RVA: 0x00482284 File Offset: 0x00480484
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
