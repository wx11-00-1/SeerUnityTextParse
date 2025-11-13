using System;

namespace core.config
{
	// Token: 0x02001CA6 RID: 7334
	public class IAutoOpenPanelInfo : IConfigItem
	{
		// Token: 0x1700122C RID: 4652
		// (get) Token: 0x0600D480 RID: 54400 RVA: 0x003CA9D4 File Offset: 0x003C8BD4
		// (set) Token: 0x0600D481 RID: 54401 RVA: 0x003CA9DC File Offset: 0x003C8BDC
		public string actionName { get; set; }

		// Token: 0x1700122D RID: 4653
		// (get) Token: 0x0600D482 RID: 54402 RVA: 0x003CA9E5 File Offset: 0x003C8BE5
		// (set) Token: 0x0600D483 RID: 54403 RVA: 0x003CA9ED File Offset: 0x003C8BED
		public string controller { get; set; }

		// Token: 0x1700122E RID: 4654
		// (get) Token: 0x0600D484 RID: 54404 RVA: 0x003CA9F6 File Offset: 0x003C8BF6
		// (set) Token: 0x0600D485 RID: 54405 RVA: 0x003CA9FE File Offset: 0x003C8BFE
		public string endTime { get; set; }

		// Token: 0x1700122F RID: 4655
		// (get) Token: 0x0600D486 RID: 54406 RVA: 0x003CAA07 File Offset: 0x003C8C07
		// (set) Token: 0x0600D487 RID: 54407 RVA: 0x003CAA0F File Offset: 0x003C8C0F
		public string param1 { get; set; }

		// Token: 0x17001230 RID: 4656
		// (get) Token: 0x0600D488 RID: 54408 RVA: 0x003CAA18 File Offset: 0x003C8C18
		// (set) Token: 0x0600D489 RID: 54409 RVA: 0x003CAA20 File Offset: 0x003C8C20
		public string param2 { get; set; }

		// Token: 0x17001231 RID: 4657
		// (get) Token: 0x0600D48A RID: 54410 RVA: 0x003CAA29 File Offset: 0x003C8C29
		// (set) Token: 0x0600D48B RID: 54411 RVA: 0x003CAA31 File Offset: 0x003C8C31
		public string param3 { get; set; }

		// Token: 0x17001232 RID: 4658
		// (get) Token: 0x0600D48C RID: 54412 RVA: 0x003CAA3A File Offset: 0x003C8C3A
		// (set) Token: 0x0600D48D RID: 54413 RVA: 0x003CAA42 File Offset: 0x003C8C42
		public string startTime { get; set; }

		// Token: 0x17001233 RID: 4659
		// (get) Token: 0x0600D48E RID: 54414 RVA: 0x003CAA4B File Offset: 0x003C8C4B
		// (set) Token: 0x0600D48F RID: 54415 RVA: 0x003CAA53 File Offset: 0x003C8C53
		public int id { get; set; }

		// Token: 0x17001234 RID: 4660
		// (get) Token: 0x0600D490 RID: 54416 RVA: 0x003CAA5C File Offset: 0x003C8C5C
		// (set) Token: 0x0600D491 RID: 54417 RVA: 0x003CAA64 File Offset: 0x003C8C64
		public int moduleId { get; set; }

		// Token: 0x17001235 RID: 4661
		// (get) Token: 0x0600D492 RID: 54418 RVA: 0x003CAA6D File Offset: 0x003C8C6D
		// (set) Token: 0x0600D493 RID: 54419 RVA: 0x003CAA75 File Offset: 0x003C8C75
		public int state { get; set; }

		// Token: 0x0600D494 RID: 54420 RVA: 0x003CAA80 File Offset: 0x003C8C80
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.actionName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.controller = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.endTime = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.id = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.moduleId = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.param1 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.param2 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.param3 = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.startTime = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.state = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
		}
	}
}
