using System;

namespace core.config
{
	// Token: 0x02001CE2 RID: 7394
	public class IBuffInfo : IConfigItem
	{
		// Token: 0x17001304 RID: 4868
		// (get) Token: 0x0600D6A8 RID: 54952 RVA: 0x003CD374 File Offset: 0x003CB574
		// (set) Token: 0x0600D6A9 RID: 54953 RVA: 0x003CD37C File Offset: 0x003CB57C
		public string Desc { get; set; }

		// Token: 0x17001305 RID: 4869
		// (get) Token: 0x0600D6AA RID: 54954 RVA: 0x003CD385 File Offset: 0x003CB585
		// (set) Token: 0x0600D6AB RID: 54955 RVA: 0x003CD38D File Offset: 0x003CB58D
		public string desc_tag { get; set; }

		// Token: 0x17001306 RID: 4870
		// (get) Token: 0x0600D6AC RID: 54956 RVA: 0x003CD396 File Offset: 0x003CB596
		// (set) Token: 0x0600D6AD RID: 54957 RVA: 0x003CD39E File Offset: 0x003CB59E
		public string Tag { get; set; }

		// Token: 0x17001307 RID: 4871
		// (get) Token: 0x0600D6AE RID: 54958 RVA: 0x003CD3A7 File Offset: 0x003CB5A7
		// (set) Token: 0x0600D6AF RID: 54959 RVA: 0x003CD3AF File Offset: 0x003CB5AF
		public int[] icon { get; set; }

		// Token: 0x17001308 RID: 4872
		// (get) Token: 0x0600D6B0 RID: 54960 RVA: 0x003CD3B8 File Offset: 0x003CB5B8
		// (set) Token: 0x0600D6B1 RID: 54961 RVA: 0x003CD3C0 File Offset: 0x003CB5C0
		public int icontype { get; set; }

		// Token: 0x17001309 RID: 4873
		// (get) Token: 0x0600D6B2 RID: 54962 RVA: 0x003CD3C9 File Offset: 0x003CB5C9
		// (set) Token: 0x0600D6B3 RID: 54963 RVA: 0x003CD3D1 File Offset: 0x003CB5D1
		public int id { get; set; }

		// Token: 0x0600D6B4 RID: 54964 RVA: 0x003CD3DC File Offset: 0x003CB5DC
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.Desc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Tag = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.desc_tag = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.icon = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.icon[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.icontype = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
