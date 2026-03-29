using System;

namespace core.config
{
	// Token: 0x020022F6 RID: 8950
	public class PremiumPetInfo : XlsConfigBase<PremiumPetInfo, IPremiumPetInfoInfo>
	{
		// Token: 0x17001CE2 RID: 7394
		// (get) Token: 0x06011030 RID: 69680 RVA: 0x00494B3D File Offset: 0x00492D3D
		public override string fileName
		{
			get
			{
				return "PremiumPetInfo";
			}
		}

		// Token: 0x06011031 RID: 69681 RVA: 0x00494B44 File Offset: 0x00492D44
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IPremiumPetInfoInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IPremiumPetInfoInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x06011032 RID: 69682 RVA: 0x00494B98 File Offset: 0x00492D98
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
