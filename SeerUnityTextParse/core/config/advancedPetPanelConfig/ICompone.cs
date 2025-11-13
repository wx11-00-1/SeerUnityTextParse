using System;

namespace core.config.advancedPetPanelConfig
{
	// Token: 0x02002078 RID: 8312
	public class ICompone
	{
		// Token: 0x17002125 RID: 8485
		// (get) Token: 0x0600FDCD RID: 64973 RVA: 0x00403840 File Offset: 0x00401A40
		// (set) Token: 0x0600FDCE RID: 64974 RVA: 0x00403848 File Offset: 0x00401A48
		public string[] Name { get; set; }

		// Token: 0x0600FDCF RID: 64975 RVA: 0x00403854 File Offset: 0x00401A54
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.Name = new string[num];
				for (int i = 0; i < num; i++)
				{
					this.Name[i] = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
				}
			}
		}
	}
}
