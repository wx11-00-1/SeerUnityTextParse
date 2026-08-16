using System;

namespace core.config
{
	// Token: 0x020028BE RID: 10430
	public class FilmgameAction : XlsConfigBase<FilmgameAction, IFilmgameActionInfo>
	{
		// Token: 0x17001E73 RID: 7795
		// (get) Token: 0x06014E3E RID: 85566 RVA: 0x005B6177 File Offset: 0x005B4377
		public override string fileName
		{
			get
			{
				return "filmgameAction";
			}
		}

		// Token: 0x06014E3F RID: 85567 RVA: 0x005B6180 File Offset: 0x005B4380
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IFilmgameActionInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IFilmgameActionInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x06014E40 RID: 85568 RVA: 0x005B61D4 File Offset: 0x005B43D4
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
