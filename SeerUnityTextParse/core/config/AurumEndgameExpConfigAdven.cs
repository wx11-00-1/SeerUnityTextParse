using System;

namespace core.config
{
	// Token: 0x02002428 RID: 9256
	public class AurumEndgameExpConfigAdven : XlsConfigBase<AurumEndgameExpConfigAdven, IAurumEndgameExpConfigAdvenInfo>
	{
		// Token: 0x17001638 RID: 5688
		// (get) Token: 0x06011818 RID: 71704 RVA: 0x0050047E File Offset: 0x004FE67E
		public override string fileName
		{
			get
			{
				return "aurumEndgameExpConfig_adven";
			}
		}

		// Token: 0x06011819 RID: 71705 RVA: 0x00500488 File Offset: 0x004FE688
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IAurumEndgameExpConfigAdvenInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IAurumEndgameExpConfigAdvenInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0601181A RID: 71706 RVA: 0x005004DC File Offset: 0x004FE6DC
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
