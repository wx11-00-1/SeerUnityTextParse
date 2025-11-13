using System;

namespace core.config
{
	// Token: 0x02001CED RID: 7405
	public class ChapterpointTemp : XlsConfigBase<ChapterpointTemp, IChapterpointTempInfo>
	{
		// Token: 0x17001348 RID: 4936
		// (get) Token: 0x0600D746 RID: 55110 RVA: 0x003CDFDE File Offset: 0x003CC1DE
		public override string fileName
		{
			get
			{
				return "chapterpoint_temp";
			}
		}

		// Token: 0x0600D747 RID: 55111 RVA: 0x003CDFE8 File Offset: 0x003CC1E8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IChapterpointTempInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IChapterpointTempInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D748 RID: 55112 RVA: 0x003CE03C File Offset: 0x003CC23C
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
