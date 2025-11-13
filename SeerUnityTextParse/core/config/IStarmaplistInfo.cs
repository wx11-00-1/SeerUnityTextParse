using System;

namespace core.config
{
	// Token: 0x02001E3A RID: 7738
	public class IStarmaplistInfo : IConfigItem
	{
		// Token: 0x17001901 RID: 6401
		// (get) Token: 0x0600E552 RID: 58706 RVA: 0x003DF7E4 File Offset: 0x003DD9E4
		// (set) Token: 0x0600E553 RID: 58707 RVA: 0x003DF7EC File Offset: 0x003DD9EC
		public string name { get; set; }

		// Token: 0x17001902 RID: 6402
		// (get) Token: 0x0600E554 RID: 58708 RVA: 0x003DF7F5 File Offset: 0x003DD9F5
		// (set) Token: 0x0600E555 RID: 58709 RVA: 0x003DF7FD File Offset: 0x003DD9FD
		public string pic { get; set; }

		// Token: 0x17001903 RID: 6403
		// (get) Token: 0x0600E556 RID: 58710 RVA: 0x003DF806 File Offset: 0x003DDA06
		// (set) Token: 0x0600E557 RID: 58711 RVA: 0x003DF80E File Offset: 0x003DDA0E
		public int[] StarID { get; set; }

		// Token: 0x17001904 RID: 6404
		// (get) Token: 0x0600E558 RID: 58712 RVA: 0x003DF817 File Offset: 0x003DDA17
		// (set) Token: 0x0600E559 RID: 58713 RVA: 0x003DF81F File Offset: 0x003DDA1F
		public int id { get; set; }

		// Token: 0x17001905 RID: 6405
		// (get) Token: 0x0600E55A RID: 58714 RVA: 0x003DF828 File Offset: 0x003DDA28
		// (set) Token: 0x0600E55B RID: 58715 RVA: 0x003DF830 File Offset: 0x003DDA30
		public int isopen { get; set; }

		// Token: 0x0600E55C RID: 58716 RVA: 0x003DF83C File Offset: 0x003DDA3C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.StarID = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.StarID[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.isopen = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.pic = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
