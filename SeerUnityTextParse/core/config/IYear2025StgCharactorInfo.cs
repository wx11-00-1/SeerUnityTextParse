using System;

namespace core.config
{
	// Token: 0x02001E92 RID: 7826
	public class IYear2025StgCharactorInfo : IConfigItem
	{
		// Token: 0x17001A82 RID: 6786
		// (get) Token: 0x0600E904 RID: 59652 RVA: 0x003E4144 File Offset: 0x003E2344
		// (set) Token: 0x0600E905 RID: 59653 RVA: 0x003E414C File Offset: 0x003E234C
		public string prefabPath { get; set; }

		// Token: 0x17001A83 RID: 6787
		// (get) Token: 0x0600E906 RID: 59654 RVA: 0x003E4155 File Offset: 0x003E2355
		// (set) Token: 0x0600E907 RID: 59655 RVA: 0x003E415D File Offset: 0x003E235D
		public int[] skills { get; set; }

		// Token: 0x17001A84 RID: 6788
		// (get) Token: 0x0600E908 RID: 59656 RVA: 0x003E4166 File Offset: 0x003E2366
		// (set) Token: 0x0600E909 RID: 59657 RVA: 0x003E416E File Offset: 0x003E236E
		public int atk { get; set; }

		// Token: 0x17001A85 RID: 6789
		// (get) Token: 0x0600E90A RID: 59658 RVA: 0x003E4177 File Offset: 0x003E2377
		// (set) Token: 0x0600E90B RID: 59659 RVA: 0x003E417F File Offset: 0x003E237F
		public int def { get; set; }

		// Token: 0x17001A86 RID: 6790
		// (get) Token: 0x0600E90C RID: 59660 RVA: 0x003E4188 File Offset: 0x003E2388
		// (set) Token: 0x0600E90D RID: 59661 RVA: 0x003E4190 File Offset: 0x003E2390
		public int hp { get; set; }

		// Token: 0x17001A87 RID: 6791
		// (get) Token: 0x0600E90E RID: 59662 RVA: 0x003E4199 File Offset: 0x003E2399
		// (set) Token: 0x0600E90F RID: 59663 RVA: 0x003E41A1 File Offset: 0x003E23A1
		public int id { get; set; }

		// Token: 0x17001A88 RID: 6792
		// (get) Token: 0x0600E910 RID: 59664 RVA: 0x003E41AA File Offset: 0x003E23AA
		// (set) Token: 0x0600E911 RID: 59665 RVA: 0x003E41B2 File Offset: 0x003E23B2
		public int speed { get; set; }

		// Token: 0x17001A89 RID: 6793
		// (get) Token: 0x0600E912 RID: 59666 RVA: 0x003E41BB File Offset: 0x003E23BB
		// (set) Token: 0x0600E913 RID: 59667 RVA: 0x003E41C3 File Offset: 0x003E23C3
		public int type { get; set; }

		// Token: 0x0600E914 RID: 59668 RVA: 0x003E41CC File Offset: 0x003E23CC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.atk = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.def = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.hp = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.prefabPath = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.skills = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.skills[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.speed = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.type = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
