using System;

namespace core.config
{
	// Token: 0x02001E05 RID: 7685
	public class Room : XlsConfigBase<Room, IRoomInfo>
	{
		// Token: 0x1700180F RID: 6159
		// (get) Token: 0x0600E304 RID: 58116 RVA: 0x003DC864 File Offset: 0x003DAA64
		public override string fileName
		{
			get
			{
				return "room";
			}
		}

		// Token: 0x0600E305 RID: 58117 RVA: 0x003DC86C File Offset: 0x003DAA6C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.data = new IRoomInfo[num];
				for (int i = 0; i < num; i++)
				{
					this.data[i] = new IRoomInfo();
					this.data[i].Parse(bytes, ref byteIndex);
				}
			}
		}

		// Token: 0x0600E306 RID: 58118 RVA: 0x003DC8C0 File Offset: 0x003DAAC0
		public override void Parse(byte[] bytes)
		{
			int num = 0;
			this.Parse(bytes, ref num);
		}
	}
}
