using System;

namespace core.config
{
	// Token: 0x02001E27 RID: 7719
	public class SportsMeetingBattle : XlsConfigBase<SportsMeetingBattle, ISportsMeetingBattleInfo>
	{
		// Token: 0x170018B7 RID: 6327
		// (get) Token: 0x0600E498 RID: 58520 RVA: 0x003DE8D8 File Offset: 0x003DCAD8
		public override string fileName
		{
			get
			{
				return "sportsMeetingBattle";
			}
		}

		// Token: 0x0600E499 RID: 58521 RVA: 0x003DE8E0 File Offset: 0x003DCAE0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ISportsMeetingBattleInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ISportsMeetingBattleInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E49A RID: 58522 RVA: 0x003DE934 File Offset: 0x003DCB34
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
