using System;

namespace core.config
{
	// Token: 0x02001C81 RID: 7297
	public class Achievementbonus : XlsConfigBase<Achievementbonus, IAchievementbonusInfo>
	{
		// Token: 0x1700115D RID: 4445
		// (get) Token: 0x0600D298 RID: 53912 RVA: 0x003C8678 File Offset: 0x003C6878
		public override string fileName
		{
			get
			{
				return "achievementbonus";
			}
		}

		// Token: 0x0600D299 RID: 53913 RVA: 0x003C8680 File Offset: 0x003C6880
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IAchievementbonusInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IAchievementbonusInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D29A RID: 53914 RVA: 0x003C86D4 File Offset: 0x003C68D4
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
