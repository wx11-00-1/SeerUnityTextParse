using System;

namespace core.config
{
	// Token: 0x02001CD3 RID: 7379
	public class BraveTowerReverseDefenseStrengthen : XlsConfigBase<BraveTowerReverseDefenseStrengthen, IBraveTowerReverseDefenseStrengthenInfo>
	{
		// Token: 0x170012DF RID: 4831
		// (get) Token: 0x0600D640 RID: 54848 RVA: 0x003CCA75 File Offset: 0x003CAC75
		public override string fileName
		{
			get
			{
				return "BraveTowerReverseDefense_strengthen";
			}
		}

		// Token: 0x0600D641 RID: 54849 RVA: 0x003CCA7C File Offset: 0x003CAC7C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IBraveTowerReverseDefenseStrengthenInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IBraveTowerReverseDefenseStrengthenInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D642 RID: 54850 RVA: 0x003CCAD0 File Offset: 0x003CACD0
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
