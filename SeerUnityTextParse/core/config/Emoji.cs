using System;

namespace core.config
{
	// Token: 0x02001D3D RID: 7485
	public class Emoji : XlsConfigBase<Emoji, IEmojiInfo>
	{
		// Token: 0x170014B8 RID: 5304
		// (get) Token: 0x0600DAC6 RID: 56006 RVA: 0x003D221D File Offset: 0x003D041D
		public override string fileName
		{
			get
			{
				return "emoji";
			}
		}

		// Token: 0x0600DAC7 RID: 56007 RVA: 0x003D2224 File Offset: 0x003D0424
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IEmojiInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IEmojiInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DAC8 RID: 56008 RVA: 0x003D2278 File Offset: 0x003D0478
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
