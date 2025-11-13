using System;

namespace core.config
{
	// Token: 0x02001DA1 RID: 7585
	public class NewBraveLv : XlsConfigBase<NewBraveLv, INewBraveLvInfo>
	{
		// Token: 0x17001644 RID: 5700
		// (get) Token: 0x0600DEA6 RID: 56998 RVA: 0x003D715F File Offset: 0x003D535F
		public override string fileName
		{
			get
			{
				return "newBraveLv";
			}
		}

		// Token: 0x0600DEA7 RID: 56999 RVA: 0x003D7168 File Offset: 0x003D5368
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new INewBraveLvInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new INewBraveLvInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DEA8 RID: 57000 RVA: 0x003D71BC File Offset: 0x003D53BC
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
