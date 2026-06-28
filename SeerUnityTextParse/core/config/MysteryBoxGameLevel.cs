using System;

namespace core.config
{
	// Token: 0x0200271C RID: 10012
	public class MysteryBoxGameLevel : XlsConfigBase<MysteryBoxGameLevel, IMysteryBoxGameLevelInfo>
	{
		// Token: 0x17001F6E RID: 8046
		// (get) Token: 0x06013BFF RID: 80895 RVA: 0x0055C972 File Offset: 0x0055AB72
		public override string fileName
		{
			get
			{
				return "mysteryBoxGameLevel";
			}
		}

		// Token: 0x06013C00 RID: 80896 RVA: 0x0055C97C File Offset: 0x0055AB7C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IMysteryBoxGameLevelInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IMysteryBoxGameLevelInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x06013C01 RID: 80897 RVA: 0x0055C9D0 File Offset: 0x0055ABD0
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
