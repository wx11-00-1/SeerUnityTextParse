using System;

namespace core.config
{
	// Token: 0x0200242C RID: 9260
	public class AurumEndgameOptionsConfig : XlsConfigBase<AurumEndgameOptionsConfig, IAurumEndgameOptionsConfigInfo>
	{
		// Token: 0x17001640 RID: 5696
		// (get) Token: 0x06011830 RID: 71728 RVA: 0x0050064F File Offset: 0x004FE84F
		public override string fileName
		{
			get
			{
				return "aurumEndgameOptionsConfig";
			}
		}

		// Token: 0x06011831 RID: 71729 RVA: 0x00500658 File Offset: 0x004FE858
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IAurumEndgameOptionsConfigInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IAurumEndgameOptionsConfigInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x06011832 RID: 71730 RVA: 0x005006AC File Offset: 0x004FE8AC
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
