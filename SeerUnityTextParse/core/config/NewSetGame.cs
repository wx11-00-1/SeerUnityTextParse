using System;

namespace core.config
{
	// Token: 0x02002044 RID: 8260
	public class NewSetGame : XlsConfigBase<NewSetGame, INewSetGameInfo>
	{
		// Token: 0x17001912 RID: 6418
		// (get) Token: 0x0600F898 RID: 63640 RVA: 0x0043D1DA File Offset: 0x0043B3DA
		public override string fileName
		{
			get
			{
				return "newSetGame";
			}
		}

		// Token: 0x0600F899 RID: 63641 RVA: 0x0043D1E4 File Offset: 0x0043B3E4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new INewSetGameInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new INewSetGameInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600F89A RID: 63642 RVA: 0x0043D238 File Offset: 0x0043B438
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
