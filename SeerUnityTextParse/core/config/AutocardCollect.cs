using System;

namespace core.config
{
	// Token: 0x02002566 RID: 9574
	public class AutocardCollect : XlsConfigBase<AutocardCollect, IAutocardCollectInfo>
	{
		// Token: 0x1700178A RID: 6026
		// (get) Token: 0x060128CB RID: 75979 RVA: 0x00545916 File Offset: 0x00543B16
		public override string fileName
		{
			get
			{
				return "autocardCollect";
			}
		}

		// Token: 0x060128CC RID: 75980 RVA: 0x00545920 File Offset: 0x00543B20
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IAutocardCollectInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IAutocardCollectInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x060128CD RID: 75981 RVA: 0x00545974 File Offset: 0x00543B74
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
