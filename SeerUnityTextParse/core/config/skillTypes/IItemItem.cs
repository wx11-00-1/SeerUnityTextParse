using System;

namespace core.config.skillTypes
{
	// Token: 0x02001F20 RID: 7968
	public class IItemItem : IConfigItem
	{
		// Token: 0x17001B6F RID: 7023
		// (get) Token: 0x0600EEC0 RID: 61120 RVA: 0x003F2C1E File Offset: 0x003F0E1E
		// (set) Token: 0x0600EEC1 RID: 61121 RVA: 0x003F2C26 File Offset: 0x003F0E26
		public string att { get; set; }

		// Token: 0x17001B70 RID: 7024
		// (get) Token: 0x0600EEC2 RID: 61122 RVA: 0x003F2C2F File Offset: 0x003F0E2F
		// (set) Token: 0x0600EEC3 RID: 61123 RVA: 0x003F2C37 File Offset: 0x003F0E37
		public string cn { get; set; }

		// Token: 0x17001B71 RID: 7025
		// (get) Token: 0x0600EEC4 RID: 61124 RVA: 0x003F2C40 File Offset: 0x003F0E40
		// (set) Token: 0x0600EEC5 RID: 61125 RVA: 0x003F2C48 File Offset: 0x003F0E48
		public string[] en { get; set; }

		// Token: 0x17001B72 RID: 7026
		// (get) Token: 0x0600EEC6 RID: 61126 RVA: 0x003F2C51 File Offset: 0x003F0E51
		// (set) Token: 0x0600EEC7 RID: 61127 RVA: 0x003F2C59 File Offset: 0x003F0E59
		public int id { get; set; }

		// Token: 0x17001B73 RID: 7027
		// (get) Token: 0x0600EEC8 RID: 61128 RVA: 0x003F2C62 File Offset: 0x003F0E62
		// (set) Token: 0x0600EEC9 RID: 61129 RVA: 0x003F2C6A File Offset: 0x003F0E6A
		public int is_dou { get; set; }

		// Token: 0x0600EECA RID: 61130 RVA: 0x003F2C74 File Offset: 0x003F0E74
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.att = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.cn = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.en = new string[num];
				for (int i = 0; i < num; i++)
				{
					this.en[i] = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
				}
			}
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.is_dou = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
