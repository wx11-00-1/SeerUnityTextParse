using System;

namespace core.config
{
	// Token: 0x0200284A RID: 10314
	public class Story1025 : XlsConfigBase<Story1025, IStory1025Info>
	{
		// Token: 0x17002516 RID: 9494
		// (get) Token: 0x060149AB RID: 84395 RVA: 0x0056D54D File Offset: 0x0056B74D
		public override string fileName
		{
			get
			{
				return "story_1025";
			}
		}

		// Token: 0x060149AC RID: 84396 RVA: 0x0056D554 File Offset: 0x0056B754
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IStory1025Info[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IStory1025Info();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x060149AD RID: 84397 RVA: 0x0056D5A8 File Offset: 0x0056B7A8
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
