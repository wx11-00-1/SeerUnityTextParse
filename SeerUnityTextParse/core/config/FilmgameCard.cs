using System;

namespace core.config
{
	// Token: 0x020028C4 RID: 10436
	public class FilmgameCard : XlsConfigBase<FilmgameCard, IFilmgameCardInfo>
	{
		// Token: 0x17001E85 RID: 7813
		// (get) Token: 0x06014E6E RID: 85614 RVA: 0x005B6512 File Offset: 0x005B4712
		public override string fileName
		{
			get
			{
				return "filmgameCard";
			}
		}

		// Token: 0x06014E6F RID: 85615 RVA: 0x005B651C File Offset: 0x005B471C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IFilmgameCardInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IFilmgameCardInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x06014E70 RID: 85616 RVA: 0x005B6570 File Offset: 0x005B4770
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
