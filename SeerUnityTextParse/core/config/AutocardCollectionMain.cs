using System;

namespace core.config
{
	// Token: 0x02002568 RID: 9576
	public class AutocardCollectionMain : XlsConfigBase<AutocardCollectionMain, IAutocardCollectionMainInfo>
	{
		// Token: 0x17001797 RID: 6039
		// (get) Token: 0x060128E9 RID: 76009 RVA: 0x00545B42 File Offset: 0x00543D42
		public override string fileName
		{
			get
			{
				return "autocardCollectionMain";
			}
		}

		// Token: 0x060128EA RID: 76010 RVA: 0x00545B4C File Offset: 0x00543D4C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IAutocardCollectionMainInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IAutocardCollectionMainInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x060128EB RID: 76011 RVA: 0x00545BA0 File Offset: 0x00543DA0
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
