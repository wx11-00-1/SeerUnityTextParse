using System;

namespace core.config
{
	// Token: 0x02002432 RID: 9266
	public class AurumEndgameTutorialConfig : XlsConfigBase<AurumEndgameTutorialConfig, IAurumEndgameTutorialConfigInfo>
	{
		// Token: 0x17001666 RID: 5734
		// (get) Token: 0x06011888 RID: 71816 RVA: 0x00500D2E File Offset: 0x004FEF2E
		public override string fileName
		{
			get
			{
				return "aurumEndgameTutorialConfig";
			}
		}

		// Token: 0x06011889 RID: 71817 RVA: 0x00500D38 File Offset: 0x004FEF38
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IAurumEndgameTutorialConfigInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IAurumEndgameTutorialConfigInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0601188A RID: 71818 RVA: 0x00500D8C File Offset: 0x004FEF8C
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
