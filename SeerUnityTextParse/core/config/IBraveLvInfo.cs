using System;

namespace core.config
{
	// Token: 0x02001CDC RID: 7388
	public class IBraveLvInfo : IConfigItem
	{
		// Token: 0x170012F2 RID: 4850
		// (get) Token: 0x0600D678 RID: 54904 RVA: 0x003CCF14 File Offset: 0x003CB114
		// (set) Token: 0x0600D679 RID: 54905 RVA: 0x003CCF1C File Offset: 0x003CB11C
		public string[] upreward { get; set; }

		// Token: 0x170012F3 RID: 4851
		// (get) Token: 0x0600D67A RID: 54906 RVA: 0x003CCF25 File Offset: 0x003CB125
		// (set) Token: 0x0600D67B RID: 54907 RVA: 0x003CCF2D File Offset: 0x003CB12D
		public int[] petid_newseid_5thmoveid { get; set; }

		// Token: 0x170012F4 RID: 4852
		// (get) Token: 0x0600D67C RID: 54908 RVA: 0x003CCF36 File Offset: 0x003CB136
		// (set) Token: 0x0600D67D RID: 54909 RVA: 0x003CCF3E File Offset: 0x003CB13E
		public int id { get; set; }

		// Token: 0x170012F5 RID: 4853
		// (get) Token: 0x0600D67E RID: 54910 RVA: 0x003CCF47 File Offset: 0x003CB147
		// (set) Token: 0x0600D67F RID: 54911 RVA: 0x003CCF4F File Offset: 0x003CB14F
		public int storehouse { get; set; }

		// Token: 0x0600D680 RID: 54912 RVA: 0x003CCF58 File Offset: 0x003CB158
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.petid_newseid_5thmoveid = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.petid_newseid_5thmoveid[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.storehouse = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.upreward = new string[num2];
				for (int j = 0; j < num2; j++)
				{
					this.upreward[j] = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
				}
			}
		}
	}
}
