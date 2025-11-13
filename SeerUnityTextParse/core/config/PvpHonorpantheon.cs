using System;

namespace core.config
{
	// Token: 0x02001DDF RID: 7647
	public class PvpHonorpantheon : XlsConfigBase<PvpHonorpantheon, IPvpHonorpantheonInfo>
	{
		// Token: 0x17001765 RID: 5989
		// (get) Token: 0x0600E164 RID: 57700 RVA: 0x003DA787 File Offset: 0x003D8987
		public override string fileName
		{
			get
			{
				return "pvp_honorpantheon";
			}
		}

		// Token: 0x0600E165 RID: 57701 RVA: 0x003DA790 File Offset: 0x003D8990
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IPvpHonorpantheonInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IPvpHonorpantheonInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E166 RID: 57702 RVA: 0x003DA7E4 File Offset: 0x003D89E4
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
