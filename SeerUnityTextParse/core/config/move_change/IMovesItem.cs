using System;

namespace core.config.move_change
{
	// Token: 0x02001FA3 RID: 8099
	public class IMovesItem
	{
		// Token: 0x17001D40 RID: 7488
		// (get) Token: 0x0600F368 RID: 62312 RVA: 0x003F86DE File Offset: 0x003F68DE
		// (set) Token: 0x0600F369 RID: 62313 RVA: 0x003F86E6 File Offset: 0x003F68E6
		public string moveName1 { get; set; }

		// Token: 0x17001D41 RID: 7489
		// (get) Token: 0x0600F36A RID: 62314 RVA: 0x003F86EF File Offset: 0x003F68EF
		// (set) Token: 0x0600F36B RID: 62315 RVA: 0x003F86F7 File Offset: 0x003F68F7
		public string moveName2 { get; set; }

		// Token: 0x17001D42 RID: 7490
		// (get) Token: 0x0600F36C RID: 62316 RVA: 0x003F8700 File Offset: 0x003F6900
		// (set) Token: 0x0600F36D RID: 62317 RVA: 0x003F8708 File Offset: 0x003F6908
		public string NewName { get; set; }

		// Token: 0x17001D43 RID: 7491
		// (get) Token: 0x0600F36E RID: 62318 RVA: 0x003F8711 File Offset: 0x003F6911
		// (set) Token: 0x0600F36F RID: 62319 RVA: 0x003F8719 File Offset: 0x003F6919
		public int MoveID { get; set; }

		// Token: 0x17001D44 RID: 7492
		// (get) Token: 0x0600F370 RID: 62320 RVA: 0x003F8722 File Offset: 0x003F6922
		// (set) Token: 0x0600F371 RID: 62321 RVA: 0x003F872A File Offset: 0x003F692A
		public int SkinID { get; set; }

		// Token: 0x0600F372 RID: 62322 RVA: 0x003F8734 File Offset: 0x003F6934
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.MoveID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.NewName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.SkinID = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.moveName1 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.moveName2 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
