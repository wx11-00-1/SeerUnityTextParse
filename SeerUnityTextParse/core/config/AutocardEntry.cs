using System;

namespace core.config
{
	// Token: 0x02002578 RID: 9592
	public class AutocardEntry : XlsConfigBase<AutocardEntry, IAutocardEntryInfo>
	{
		// Token: 0x170017D6 RID: 6102
		// (get) Token: 0x06012987 RID: 76167 RVA: 0x005466A6 File Offset: 0x005448A6
		public override string fileName
		{
			get
			{
				return "autocardEntry";
			}
		}

		// Token: 0x06012988 RID: 76168 RVA: 0x005466B0 File Offset: 0x005448B0
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IAutocardEntryInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IAutocardEntryInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x06012989 RID: 76169 RVA: 0x00546704 File Offset: 0x00544904
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
