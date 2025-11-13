using System;

namespace core.config
{
	// Token: 0x02001CB3 RID: 7347
	public class BadgeBattlePassTask : XlsConfigBase<BadgeBattlePassTask, IBadgeBattlePassTaskInfo>
	{
		// Token: 0x1700125F RID: 4703
		// (get) Token: 0x0600D500 RID: 54528 RVA: 0x003CB328 File Offset: 0x003C9528
		public override string fileName
		{
			get
			{
				return "badgeBattlePass_task";
			}
		}

		// Token: 0x0600D501 RID: 54529 RVA: 0x003CB330 File Offset: 0x003C9530
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IBadgeBattlePassTaskInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IBadgeBattlePassTaskInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D502 RID: 54530 RVA: 0x003CB384 File Offset: 0x003C9584
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
