using System;

namespace core.config
{
	// Token: 0x02001D95 RID: 7573
	public class MiniGame : XlsConfigBase<MiniGame, IMiniGameInfo>
	{
		// Token: 0x17001621 RID: 5665
		// (get) Token: 0x0600DE48 RID: 56904 RVA: 0x003D69CA File Offset: 0x003D4BCA
		public override string fileName
		{
			get
			{
				return "mini_game";
			}
		}

		// Token: 0x0600DE49 RID: 56905 RVA: 0x003D69D4 File Offset: 0x003D4BD4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IMiniGameInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IMiniGameInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DE4A RID: 56906 RVA: 0x003D6A28 File Offset: 0x003D4C28
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
