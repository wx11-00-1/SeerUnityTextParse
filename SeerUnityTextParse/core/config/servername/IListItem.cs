using System;

namespace core.config.servername
{
	// Token: 0x02001F2A RID: 7978
	public class IListItem : IConfigItem
	{
		// Token: 0x17001BAC RID: 7084
		// (get) Token: 0x0600EF4E RID: 61262 RVA: 0x003F3728 File Offset: 0x003F1928
		// (set) Token: 0x0600EF4F RID: 61263 RVA: 0x003F3730 File Offset: 0x003F1930
		public string name { get; set; }

		// Token: 0x17001BAD RID: 7085
		// (get) Token: 0x0600EF50 RID: 61264 RVA: 0x003F3739 File Offset: 0x003F1939
		// (set) Token: 0x0600EF51 RID: 61265 RVA: 0x003F3741 File Offset: 0x003F1941
		public int id { get; set; }

		// Token: 0x0600EF52 RID: 61266 RVA: 0x003F374A File Offset: 0x003F194A
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
