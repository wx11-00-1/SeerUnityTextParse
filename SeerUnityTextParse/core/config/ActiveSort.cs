using System;

namespace core.config
{
	// Token: 0x02001C83 RID: 7299
	public class ActiveSort : XlsConfigBase<ActiveSort, IActiveSortInfo>
	{
		// Token: 0x17001164 RID: 4452
		// (get) Token: 0x0600D2AA RID: 53930 RVA: 0x003C87CD File Offset: 0x003C69CD
		public override string fileName
		{
			get
			{
				return "active_sort";
			}
		}

		// Token: 0x0600D2AB RID: 53931 RVA: 0x003C87D4 File Offset: 0x003C69D4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IActiveSortInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IActiveSortInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D2AC RID: 53932 RVA: 0x003C8828 File Offset: 0x003C6A28
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
