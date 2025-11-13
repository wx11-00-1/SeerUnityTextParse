using System;

namespace core.config
{
	// Token: 0x02001DD1 RID: 7633
	public class PveBossBraveTower : XlsConfigBase<PveBossBraveTower, IPveBossBraveTowerInfo>
	{
		// Token: 0x1700172D RID: 5933
		// (get) Token: 0x0600E0D8 RID: 57560 RVA: 0x003D9BB7 File Offset: 0x003D7DB7
		public override string fileName
		{
			get
			{
				return "PveBossBraveTower";
			}
		}

		// Token: 0x0600E0D9 RID: 57561 RVA: 0x003D9BC0 File Offset: 0x003D7DC0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IPveBossBraveTowerInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IPveBossBraveTowerInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E0DA RID: 57562 RVA: 0x003D9C14 File Offset: 0x003D7E14
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
