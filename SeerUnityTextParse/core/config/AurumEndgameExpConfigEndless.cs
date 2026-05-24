using System;

namespace core.config
{
	// Token: 0x0200242A RID: 9258
	public class AurumEndgameExpConfigEndless : XlsConfigBase<AurumEndgameExpConfigEndless, IAurumEndgameExpConfigEndlessInfo>
	{
		// Token: 0x1700163C RID: 5692
		// (get) Token: 0x06011824 RID: 71716 RVA: 0x00500567 File Offset: 0x004FE767
		public override string fileName
		{
			get
			{
				return "aurumEndgameExpConfig_endless";
			}
		}

		// Token: 0x06011825 RID: 71717 RVA: 0x00500570 File Offset: 0x004FE770
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IAurumEndgameExpConfigEndlessInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IAurumEndgameExpConfigEndlessInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x06011826 RID: 71718 RVA: 0x005005C4 File Offset: 0x004FE7C4
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
