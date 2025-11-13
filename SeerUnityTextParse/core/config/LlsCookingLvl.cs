using System;

namespace core.config
{
	// Token: 0x02001D81 RID: 7553
	public class LlsCookingLvl : XlsConfigBase<LlsCookingLvl, ILlsCookingLvlInfo>
	{
		// Token: 0x170015C6 RID: 5574
		// (get) Token: 0x0600DD6A RID: 56682 RVA: 0x003D57B5 File Offset: 0x003D39B5
		public override string fileName
		{
			get
			{
				return "lls_cooking_lvl";
			}
		}

		// Token: 0x0600DD6B RID: 56683 RVA: 0x003D57BC File Offset: 0x003D39BC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ILlsCookingLvlInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ILlsCookingLvlInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DD6C RID: 56684 RVA: 0x003D5810 File Offset: 0x003D3A10
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
