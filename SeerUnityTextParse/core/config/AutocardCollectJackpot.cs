using System;

namespace core.config
{
	// Token: 0x0200256A RID: 9578
	public class AutocardCollectJackpot : XlsConfigBase<AutocardCollectJackpot, IAutocardCollectJackpotInfo>
	{
		// Token: 0x1700179F RID: 6047
		// (get) Token: 0x060128FD RID: 76029 RVA: 0x00545CAF File Offset: 0x00543EAF
		public override string fileName
		{
			get
			{
				return "autocardCollectJackpot";
			}
		}

		// Token: 0x060128FE RID: 76030 RVA: 0x00545CB8 File Offset: 0x00543EB8
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IAutocardCollectJackpotInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IAutocardCollectJackpotInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x060128FF RID: 76031 RVA: 0x00545D0C File Offset: 0x00543F0C
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
