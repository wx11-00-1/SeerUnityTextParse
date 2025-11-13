using System;

namespace core.config
{
	// Token: 0x02001CA7 RID: 7335
	public class Awakenbossbuff : XlsConfigBase<Awakenbossbuff, IAwakenbossbuffInfo>
	{
		// Token: 0x17001236 RID: 4662
		// (get) Token: 0x0600D496 RID: 54422 RVA: 0x003CAB48 File Offset: 0x003C8D48
		public override string fileName
		{
			get
			{
				return "awakenbossbuff";
			}
		}

		// Token: 0x0600D497 RID: 54423 RVA: 0x003CAB50 File Offset: 0x003C8D50
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IAwakenbossbuffInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IAwakenbossbuffInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600D498 RID: 54424 RVA: 0x003CABA4 File Offset: 0x003C8DA4
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
