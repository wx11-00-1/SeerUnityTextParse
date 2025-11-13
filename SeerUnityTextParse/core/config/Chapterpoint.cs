using System;

namespace core.config
{
	// Token: 0x02001CEB RID: 7403
	public class Chapterpoint : XlsConfigBase<Chapterpoint, IChapterpointInfo>
	{
		// Token: 0x17001332 RID: 4914
		// (get) Token: 0x0600D716 RID: 55062 RVA: 0x003CDC9D File Offset: 0x003CBE9D
		public override string fileName
		{
			get
			{
				return "chapterpoint";
			}
		}

		// Token: 0x0600D717 RID: 55063 RVA: 0x003CDCA4 File Offset: 0x003CBEA4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IChapterpointInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IChapterpointInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D718 RID: 55064 RVA: 0x003CDCF8 File Offset: 0x003CBEF8
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
