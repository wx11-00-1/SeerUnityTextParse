using System;

namespace core.config
{
	// Token: 0x02001DBD RID: 7613
	public class PetEffectIcon : XlsConfigBase<PetEffectIcon, IPetEffectIconInfo>
	{
		// Token: 0x170016DC RID: 5852
		// (get) Token: 0x0600E00E RID: 57358 RVA: 0x003D8CF5 File Offset: 0x003D6EF5
		public override string fileName
		{
			get
			{
				return "petEffectIcon";
			}
		}

		// Token: 0x0600E00F RID: 57359 RVA: 0x003D8CFC File Offset: 0x003D6EFC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IPetEffectIconInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IPetEffectIconInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E010 RID: 57360 RVA: 0x003D8D50 File Offset: 0x003D6F50
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
