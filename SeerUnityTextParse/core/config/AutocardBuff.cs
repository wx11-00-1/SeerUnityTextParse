using System;

namespace core.config
{
	// Token: 0x02002126 RID: 8486
	public class AutocardBuff : XlsConfigBase<AutocardBuff, IAutocardBuffInfo>
	{
		// Token: 0x17001498 RID: 5272
		// (get) Token: 0x0600FBFC RID: 64508 RVA: 0x0047C563 File Offset: 0x0047A763
		public override string fileName
		{
			get
			{
				return "autocardBuff";
			}
		}

		// Token: 0x0600FBFD RID: 64509 RVA: 0x0047C56C File Offset: 0x0047A76C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IAutocardBuffInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IAutocardBuffInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600FBFE RID: 64510 RVA: 0x0047C5C0 File Offset: 0x0047A7C0
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
