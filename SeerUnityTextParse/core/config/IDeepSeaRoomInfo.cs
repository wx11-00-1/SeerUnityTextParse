using System;

namespace core.config
{
	// Token: 0x02001D30 RID: 7472
	public class IDeepSeaRoomInfo : IConfigItem
	{
		// Token: 0x17001489 RID: 5257
		// (get) Token: 0x0600DA4E RID: 55886 RVA: 0x003D1924 File Offset: 0x003CFB24
		// (set) Token: 0x0600DA4F RID: 55887 RVA: 0x003D192C File Offset: 0x003CFB2C
		public string bgPic { get; set; }

		// Token: 0x1700148A RID: 5258
		// (get) Token: 0x0600DA50 RID: 55888 RVA: 0x003D1935 File Offset: 0x003CFB35
		// (set) Token: 0x0600DA51 RID: 55889 RVA: 0x003D193D File Offset: 0x003CFB3D
		public string item { get; set; }

		// Token: 0x1700148B RID: 5259
		// (get) Token: 0x0600DA52 RID: 55890 RVA: 0x003D1946 File Offset: 0x003CFB46
		// (set) Token: 0x0600DA53 RID: 55891 RVA: 0x003D194E File Offset: 0x003CFB4E
		public int id { get; set; }

		// Token: 0x1700148C RID: 5260
		// (get) Token: 0x0600DA54 RID: 55892 RVA: 0x003D1957 File Offset: 0x003CFB57
		// (set) Token: 0x0600DA55 RID: 55893 RVA: 0x003D195F File Offset: 0x003CFB5F
		public int mapid { get; set; }

		// Token: 0x0600DA56 RID: 55894 RVA: 0x003D1968 File Offset: 0x003CFB68
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.bgPic = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.item = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.mapid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
