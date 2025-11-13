using System;

namespace core.config
{
	// Token: 0x02001DA5 RID: 7589
	public class NewSeer7Sign : XlsConfigBase<NewSeer7Sign, INewSeer7SignInfo>
	{
		// Token: 0x17001650 RID: 5712
		// (get) Token: 0x0600DEC6 RID: 57030 RVA: 0x003D747B File Offset: 0x003D567B
		public override string fileName
		{
			get
			{
				return "newSeer7Sign";
			}
		}

		// Token: 0x0600DEC7 RID: 57031 RVA: 0x003D7484 File Offset: 0x003D5684
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new INewSeer7SignInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new INewSeer7SignInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600DEC8 RID: 57032 RVA: 0x003D74D8 File Offset: 0x003D56D8
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
