using System;

namespace core.config
{
	// Token: 0x02001D94 RID: 7572
	public class IMedaltaskInfo : IConfigItem
	{
		// Token: 0x1700161B RID: 5659
		// (get) Token: 0x0600DE3A RID: 56890 RVA: 0x003D6894 File Offset: 0x003D4A94
		// (set) Token: 0x0600DE3B RID: 56891 RVA: 0x003D689C File Offset: 0x003D4A9C
		public string describe { get; set; }

		// Token: 0x1700161C RID: 5660
		// (get) Token: 0x0600DE3C RID: 56892 RVA: 0x003D68A5 File Offset: 0x003D4AA5
		// (set) Token: 0x0600DE3D RID: 56893 RVA: 0x003D68AD File Offset: 0x003D4AAD
		public string[] jump { get; set; }

		// Token: 0x1700161D RID: 5661
		// (get) Token: 0x0600DE3E RID: 56894 RVA: 0x003D68B6 File Offset: 0x003D4AB6
		// (set) Token: 0x0600DE3F RID: 56895 RVA: 0x003D68BE File Offset: 0x003D4ABE
		public string value { get; set; }

		// Token: 0x1700161E RID: 5662
		// (get) Token: 0x0600DE40 RID: 56896 RVA: 0x003D68C7 File Offset: 0x003D4AC7
		// (set) Token: 0x0600DE41 RID: 56897 RVA: 0x003D68CF File Offset: 0x003D4ACF
		public int[] rewardinfo { get; set; }

		// Token: 0x1700161F RID: 5663
		// (get) Token: 0x0600DE42 RID: 56898 RVA: 0x003D68D8 File Offset: 0x003D4AD8
		// (set) Token: 0x0600DE43 RID: 56899 RVA: 0x003D68E0 File Offset: 0x003D4AE0
		public int id { get; set; }

		// Token: 0x17001620 RID: 5664
		// (get) Token: 0x0600DE44 RID: 56900 RVA: 0x003D68E9 File Offset: 0x003D4AE9
		// (set) Token: 0x0600DE45 RID: 56901 RVA: 0x003D68F1 File Offset: 0x003D4AF1
		public int target { get; set; }

		// Token: 0x0600DE46 RID: 56902 RVA: 0x003D68FC File Offset: 0x003D4AFC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.describe = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.jump = new string[num];
				for (int i = 0; i < num; i++)
				{
					this.jump[i] = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.rewardinfo = new int[num2];
				for (int j = 0; j < num2; j++)
				{
					this.rewardinfo[j] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.target = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.value = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
