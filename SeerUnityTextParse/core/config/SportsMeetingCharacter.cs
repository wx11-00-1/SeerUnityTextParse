using System;

namespace core.config
{
	// Token: 0x02001E29 RID: 7721
	public class SportsMeetingCharacter : XlsConfigBase<SportsMeetingCharacter, ISportsMeetingCharacterInfo>
	{
		// Token: 0x170018BF RID: 6335
		// (get) Token: 0x0600E4AC RID: 58540 RVA: 0x003DEA58 File Offset: 0x003DCC58
		public override string fileName
		{
			get
			{
				return "sportsMeetingCharacter";
			}
		}

		// Token: 0x0600E4AD RID: 58541 RVA: 0x003DEA60 File Offset: 0x003DCC60
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new ISportsMeetingCharacterInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new ISportsMeetingCharacterInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E4AE RID: 58542 RVA: 0x003DEAB4 File Offset: 0x003DCCB4
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
