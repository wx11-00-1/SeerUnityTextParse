using System;

namespace core.config
{
	// Token: 0x02001CC5 RID: 7365
	public class Battletalkjudge : XlsConfigBase<Battletalkjudge, IBattletalkjudgeInfo>
	{
		// Token: 0x170012AF RID: 4783
		// (get) Token: 0x0600D5C4 RID: 54724 RVA: 0x003CC148 File Offset: 0x003CA348
		public override string fileName
		{
			get
			{
				return "battletalkjudge";
			}
		}

		// Token: 0x0600D5C5 RID: 54725 RVA: 0x003CC150 File Offset: 0x003CA350
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IBattletalkjudgeInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IBattletalkjudgeInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D5C6 RID: 54726 RVA: 0x003CC1A4 File Offset: 0x003CA3A4
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
