using System;

namespace core.config
{
	// Token: 0x02001D37 RID: 7479
	public class Drinkrecipe : XlsConfigBase<Drinkrecipe, IDrinkrecipeInfo>
	{
		// Token: 0x1700149C RID: 5276
		// (get) Token: 0x0600DA82 RID: 55938 RVA: 0x003D1CF3 File Offset: 0x003CFEF3
		public override string fileName
		{
			get
			{
				return "drinkrecipe";
			}
		}

		// Token: 0x0600DA83 RID: 55939 RVA: 0x003D1CFC File Offset: 0x003CFEFC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IDrinkrecipeInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IDrinkrecipeInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DA84 RID: 55940 RVA: 0x003D1D50 File Offset: 0x003CFF50
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
