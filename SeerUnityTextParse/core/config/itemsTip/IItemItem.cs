using System;

namespace core.config.itemsTip
{
	// Token: 0x02001FE2 RID: 8162
	public class IItemItem : IConfigItem
	{
		// Token: 0x17001E45 RID: 7749
		// (get) Token: 0x0600F5F5 RID: 62965 RVA: 0x003FB784 File Offset: 0x003F9984
		// (set) Token: 0x0600F5F6 RID: 62966 RVA: 0x003FB78C File Offset: 0x003F998C
		public string des { get; set; }

		// Token: 0x17001E46 RID: 7750
		// (get) Token: 0x0600F5F7 RID: 62967 RVA: 0x003FB795 File Offset: 0x003F9995
		// (set) Token: 0x0600F5F8 RID: 62968 RVA: 0x003FB79D File Offset: 0x003F999D
		public int id { get; set; }

		// Token: 0x0600F5F9 RID: 62969 RVA: 0x003FB7A6 File Offset: 0x003F99A6
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.des = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
