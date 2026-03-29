using System;

namespace core.config
{
	// Token: 0x0200212C RID: 8492
	public class AutocardCondition : XlsConfigBase<AutocardCondition, IAutocardConditionInfo>
	{
		// Token: 0x170014A7 RID: 5287
		// (get) Token: 0x0600FC26 RID: 64550 RVA: 0x0047C89A File Offset: 0x0047AA9A
		public override string fileName
		{
			get
			{
				return "autocardCondition";
			}
		}

		// Token: 0x0600FC27 RID: 64551 RVA: 0x0047C8A4 File Offset: 0x0047AAA4
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IAutocardConditionInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IAutocardConditionInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600FC28 RID: 64552 RVA: 0x0047C8F8 File Offset: 0x0047AAF8
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
