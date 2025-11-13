using System;

namespace core.config
{
	// Token: 0x02001CE9 RID: 7401
	public class Chapter : XlsConfigBase<Chapter, IChapterInfo>
	{
		// Token: 0x1700131E RID: 4894
		// (get) Token: 0x0600D6EA RID: 55018 RVA: 0x003CD982 File Offset: 0x003CBB82
		public override string fileName
		{
			get
			{
				return "chapter";
			}
		}

		// Token: 0x0600D6EB RID: 55019 RVA: 0x003CD98C File Offset: 0x003CBB8C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IChapterInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IChapterInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D6EC RID: 55020 RVA: 0x003CD9E0 File Offset: 0x003CBBE0
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
