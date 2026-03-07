using System;

namespace core.config
{
	// Token: 0x02001F60 RID: 8032
	public class ClickfpsGame : XlsConfigBase<ClickfpsGame, IClickfpsGameInfo>
	{
		// Token: 0x17001578 RID: 5496
		// (get) Token: 0x0600EF9C RID: 61340 RVA: 0x00432053 File Offset: 0x00430253
		public override string fileName
		{
			get
			{
				return "clickfps_game";
			}
		}

		// Token: 0x0600EF9D RID: 61341 RVA: 0x0043205C File Offset: 0x0043025C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IClickfpsGameInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IClickfpsGameInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600EF9E RID: 61342 RVA: 0x004320B0 File Offset: 0x004302B0
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
