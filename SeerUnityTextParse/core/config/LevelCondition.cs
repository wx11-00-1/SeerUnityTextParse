using System;

namespace core.config
{
	// Token: 0x02001D73 RID: 7539
	public class LevelCondition : XlsConfigBase<LevelCondition, ILevelConditionInfo>
	{
		// Token: 0x17001593 RID: 5523
		// (get) Token: 0x0600DCE8 RID: 56552 RVA: 0x003D4E69 File Offset: 0x003D3069
		public override string fileName
		{
			get
			{
				return "LevelCondition";
			}
		}

		// Token: 0x0600DCE9 RID: 56553 RVA: 0x003D4E70 File Offset: 0x003D3070
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ILevelConditionInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ILevelConditionInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DCEA RID: 56554 RVA: 0x003D4EC4 File Offset: 0x003D30C4
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
