using System;

namespace core.config
{
	// Token: 0x02001CBF RID: 7359
	public class BattlepassTask : XlsConfigBase<BattlepassTask, IBattlepassTaskInfo>
	{
		// Token: 0x17001292 RID: 4754
		// (get) Token: 0x0600D57E RID: 54654 RVA: 0x003CBC49 File Offset: 0x003C9E49
		public override string fileName
		{
			get
			{
				return "battlepass_task";
			}
		}

		// Token: 0x0600D57F RID: 54655 RVA: 0x003CBC50 File Offset: 0x003C9E50
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IBattlepassTaskInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IBattlepassTaskInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D580 RID: 54656 RVA: 0x003CBCA4 File Offset: 0x003C9EA4
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
