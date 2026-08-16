using System;

namespace core.config
{
	// Token: 0x020028C0 RID: 10432
	public class FilmgameActor : XlsConfigBase<FilmgameActor, IFilmgameActorInfo>
	{
		// Token: 0x17001E7B RID: 7803
		// (get) Token: 0x06014E52 RID: 85586 RVA: 0x005B62E3 File Offset: 0x005B44E3
		public override string fileName
		{
			get
			{
				return "filmgameActor";
			}
		}

		// Token: 0x06014E53 RID: 85587 RVA: 0x005B62EC File Offset: 0x005B44EC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IFilmgameActorInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IFilmgameActorInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x06014E54 RID: 85588 RVA: 0x005B6340 File Offset: 0x005B4540
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
