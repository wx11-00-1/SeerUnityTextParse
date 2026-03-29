using System;

namespace core.config
{
	// Token: 0x020023EE RID: 9198
	public class TutorialRecruitlevel : XlsConfigBase<TutorialRecruitlevel, ITutorialRecruitlevelInfo>
	{
		// Token: 0x1700216D RID: 8557
		// (get) Token: 0x06011B36 RID: 72502 RVA: 0x004A2494 File Offset: 0x004A0694
		public override string fileName
		{
			get
			{
				return "tutorial_recruitlevel";
			}
		}

		// Token: 0x06011B37 RID: 72503 RVA: 0x004A249C File Offset: 0x004A069C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ITutorialRecruitlevelInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ITutorialRecruitlevelInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x06011B38 RID: 72504 RVA: 0x004A24F0 File Offset: 0x004A06F0
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
