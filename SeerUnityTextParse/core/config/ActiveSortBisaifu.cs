using System;

namespace core.config
{
	// Token: 0x02001C85 RID: 7301
	public class ActiveSortBisaifu : XlsConfigBase<ActiveSortBisaifu, IActiveSortBisaifuInfo>
	{
		// Token: 0x17001173 RID: 4467
		// (get) Token: 0x0600D2CC RID: 53964 RVA: 0x003C8A51 File Offset: 0x003C6C51
		public override string fileName
		{
			get
			{
				return "active_sort_bisaifu";
			}
		}

		// Token: 0x0600D2CD RID: 53965 RVA: 0x003C8A58 File Offset: 0x003C6C58
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IActiveSortBisaifuInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IActiveSortBisaifuInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D2CE RID: 53966 RVA: 0x003C8AAC File Offset: 0x003C6CAC
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
