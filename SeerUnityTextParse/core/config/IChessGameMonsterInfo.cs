using System;

namespace core.config
{
	// Token: 0x02001D00 RID: 7424
	public class IChessGameMonsterInfo : IConfigItem
	{
		// Token: 0x170013BE RID: 5054
		// (get) Token: 0x0600D858 RID: 55384 RVA: 0x003CF37C File Offset: 0x003CD57C
		// (set) Token: 0x0600D859 RID: 55385 RVA: 0x003CF384 File Offset: 0x003CD584
		public string acknum { get; set; }

		// Token: 0x170013BF RID: 5055
		// (get) Token: 0x0600D85A RID: 55386 RVA: 0x003CF38D File Offset: 0x003CD58D
		// (set) Token: 0x0600D85B RID: 55387 RVA: 0x003CF395 File Offset: 0x003CD595
		public string acktime { get; set; }

		// Token: 0x170013C0 RID: 5056
		// (get) Token: 0x0600D85C RID: 55388 RVA: 0x003CF39E File Offset: 0x003CD59E
		// (set) Token: 0x0600D85D RID: 55389 RVA: 0x003CF3A6 File Offset: 0x003CD5A6
		public string bpoint { get; set; }

		// Token: 0x170013C1 RID: 5057
		// (get) Token: 0x0600D85E RID: 55390 RVA: 0x003CF3AF File Offset: 0x003CD5AF
		// (set) Token: 0x0600D85F RID: 55391 RVA: 0x003CF3B7 File Offset: 0x003CD5B7
		public string buff { get; set; }

		// Token: 0x170013C2 RID: 5058
		// (get) Token: 0x0600D860 RID: 55392 RVA: 0x003CF3C0 File Offset: 0x003CD5C0
		// (set) Token: 0x0600D861 RID: 55393 RVA: 0x003CF3C8 File Offset: 0x003CD5C8
		public string def { get; set; }

		// Token: 0x170013C3 RID: 5059
		// (get) Token: 0x0600D862 RID: 55394 RVA: 0x003CF3D1 File Offset: 0x003CD5D1
		// (set) Token: 0x0600D863 RID: 55395 RVA: 0x003CF3D9 File Offset: 0x003CD5D9
		public string hp { get; set; }

		// Token: 0x170013C4 RID: 5060
		// (get) Token: 0x0600D864 RID: 55396 RVA: 0x003CF3E2 File Offset: 0x003CD5E2
		// (set) Token: 0x0600D865 RID: 55397 RVA: 0x003CF3EA File Offset: 0x003CD5EA
		public string image { get; set; }

		// Token: 0x170013C5 RID: 5061
		// (get) Token: 0x0600D866 RID: 55398 RVA: 0x003CF3F3 File Offset: 0x003CD5F3
		// (set) Token: 0x0600D867 RID: 55399 RVA: 0x003CF3FB File Offset: 0x003CD5FB
		public string name { get; set; }

		// Token: 0x170013C6 RID: 5062
		// (get) Token: 0x0600D868 RID: 55400 RVA: 0x003CF404 File Offset: 0x003CD604
		// (set) Token: 0x0600D869 RID: 55401 RVA: 0x003CF40C File Offset: 0x003CD60C
		public string skill { get; set; }

		// Token: 0x170013C7 RID: 5063
		// (get) Token: 0x0600D86A RID: 55402 RVA: 0x003CF415 File Offset: 0x003CD615
		// (set) Token: 0x0600D86B RID: 55403 RVA: 0x003CF41D File Offset: 0x003CD61D
		public int ackrange { get; set; }

		// Token: 0x170013C8 RID: 5064
		// (get) Token: 0x0600D86C RID: 55404 RVA: 0x003CF426 File Offset: 0x003CD626
		// (set) Token: 0x0600D86D RID: 55405 RVA: 0x003CF42E File Offset: 0x003CD62E
		public int id { get; set; }

		// Token: 0x170013C9 RID: 5065
		// (get) Token: 0x0600D86E RID: 55406 RVA: 0x003CF437 File Offset: 0x003CD637
		// (set) Token: 0x0600D86F RID: 55407 RVA: 0x003CF43F File Offset: 0x003CD63F
		public int move { get; set; }

		// Token: 0x170013CA RID: 5066
		// (get) Token: 0x0600D870 RID: 55408 RVA: 0x003CF448 File Offset: 0x003CD648
		// (set) Token: 0x0600D871 RID: 55409 RVA: 0x003CF450 File Offset: 0x003CD650
		public int previewarea { get; set; }

		// Token: 0x0600D872 RID: 55410 RVA: 0x003CF45C File Offset: 0x003CD65C
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.acknum = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.ackrange = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.acktime = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.bpoint = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.buff = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.def = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.hp = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.image = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.move = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.name = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.previewarea = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.skill = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
		}
	}
}
