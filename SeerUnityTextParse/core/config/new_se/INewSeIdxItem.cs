using System;

namespace core.config.new_se
{
	// Token: 0x02001F90 RID: 8080
	public class INewSeIdxItem
	{
		// Token: 0x17001CDC RID: 7388
		// (get) Token: 0x0600F27A RID: 62074 RVA: 0x003F7546 File Offset: 0x003F5746
		// (set) Token: 0x0600F27B RID: 62075 RVA: 0x003F754E File Offset: 0x003F574E
		public string Args { get; set; }

		// Token: 0x17001CDD RID: 7389
		// (get) Token: 0x0600F27C RID: 62076 RVA: 0x003F7557 File Offset: 0x003F5757
		// (set) Token: 0x0600F27D RID: 62077 RVA: 0x003F755F File Offset: 0x003F575F
		public string Des { get; set; }

		// Token: 0x17001CDE RID: 7390
		// (get) Token: 0x0600F27E RID: 62078 RVA: 0x003F7568 File Offset: 0x003F5768
		// (set) Token: 0x0600F27F RID: 62079 RVA: 0x003F7570 File Offset: 0x003F5770
		public string Desc { get; set; }

		// Token: 0x17001CDF RID: 7391
		// (get) Token: 0x0600F280 RID: 62080 RVA: 0x003F7579 File Offset: 0x003F5779
		// (set) Token: 0x0600F281 RID: 62081 RVA: 0x003F7581 File Offset: 0x003F5781
		public string Intro { get; set; }

		// Token: 0x17001CE0 RID: 7392
		// (get) Token: 0x0600F282 RID: 62082 RVA: 0x003F758A File Offset: 0x003F578A
		// (set) Token: 0x0600F283 RID: 62083 RVA: 0x003F7592 File Offset: 0x003F5792
		public int AdditionNum { get; set; }

		// Token: 0x17001CE1 RID: 7393
		// (get) Token: 0x0600F284 RID: 62084 RVA: 0x003F759B File Offset: 0x003F579B
		// (set) Token: 0x0600F285 RID: 62085 RVA: 0x003F75A3 File Offset: 0x003F57A3
		public int AdditionType { get; set; }

		// Token: 0x17001CE2 RID: 7394
		// (get) Token: 0x0600F286 RID: 62086 RVA: 0x003F75AC File Offset: 0x003F57AC
		// (set) Token: 0x0600F287 RID: 62087 RVA: 0x003F75B4 File Offset: 0x003F57B4
		public int Eid { get; set; }

		// Token: 0x17001CE3 RID: 7395
		// (get) Token: 0x0600F288 RID: 62088 RVA: 0x003F75BD File Offset: 0x003F57BD
		// (set) Token: 0x0600F289 RID: 62089 RVA: 0x003F75C5 File Offset: 0x003F57C5
		public int Idx { get; set; }

		// Token: 0x17001CE4 RID: 7396
		// (get) Token: 0x0600F28A RID: 62090 RVA: 0x003F75CE File Offset: 0x003F57CE
		// (set) Token: 0x0600F28B RID: 62091 RVA: 0x003F75D6 File Offset: 0x003F57D6
		public int ItemId { get; set; }

		// Token: 0x17001CE5 RID: 7397
		// (get) Token: 0x0600F28C RID: 62092 RVA: 0x003F75DF File Offset: 0x003F57DF
		// (set) Token: 0x0600F28D RID: 62093 RVA: 0x003F75E7 File Offset: 0x003F57E7
		public int StarLevel { get; set; }

		// Token: 0x17001CE6 RID: 7398
		// (get) Token: 0x0600F28E RID: 62094 RVA: 0x003F75F0 File Offset: 0x003F57F0
		// (set) Token: 0x0600F28F RID: 62095 RVA: 0x003F75F8 File Offset: 0x003F57F8
		public int Stat { get; set; }

		// Token: 0x0600F290 RID: 62096 RVA: 0x003F7604 File Offset: 0x003F5804
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.AdditionNum = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.AdditionType = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Args = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Des = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Desc = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.Eid = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Idx = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Intro = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.ItemId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.StarLevel = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.Stat = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
