using System;

namespace core.config.AdventureStory
{
	// Token: 0x02002631 RID: 9777
	public class IDialogItem
	{
		// Token: 0x1700297C RID: 10620
		// (get) Token: 0x060133A3 RID: 78755 RVA: 0x004C73C6 File Offset: 0x004C55C6
		// (set) Token: 0x060133A4 RID: 78756 RVA: 0x004C73CE File Offset: 0x004C55CE
		public string aniArg { get; set; }

		// Token: 0x1700297D RID: 10621
		// (get) Token: 0x060133A5 RID: 78757 RVA: 0x004C73D7 File Offset: 0x004C55D7
		// (set) Token: 0x060133A6 RID: 78758 RVA: 0x004C73DF File Offset: 0x004C55DF
		public string changeBGM { get; set; }

		// Token: 0x1700297E RID: 10622
		// (get) Token: 0x060133A7 RID: 78759 RVA: 0x004C73E8 File Offset: 0x004C55E8
		// (set) Token: 0x060133A8 RID: 78760 RVA: 0x004C73F0 File Offset: 0x004C55F0
		public string dialogArr { get; set; }

		// Token: 0x1700297F RID: 10623
		// (get) Token: 0x060133A9 RID: 78761 RVA: 0x004C73F9 File Offset: 0x004C55F9
		// (set) Token: 0x060133AA RID: 78762 RVA: 0x004C7401 File Offset: 0x004C5601
		public string npcName { get; set; }

		// Token: 0x17002980 RID: 10624
		// (get) Token: 0x060133AB RID: 78763 RVA: 0x004C740A File Offset: 0x004C560A
		// (set) Token: 0x060133AC RID: 78764 RVA: 0x004C7412 File Offset: 0x004C5612
		public string[] param { get; set; }

		// Token: 0x17002981 RID: 10625
		// (get) Token: 0x060133AD RID: 78765 RVA: 0x004C741B File Offset: 0x004C561B
		// (set) Token: 0x060133AE RID: 78766 RVA: 0x004C7423 File Offset: 0x004C5623
		public string[] questionArr { get; set; }

		// Token: 0x17002982 RID: 10626
		// (get) Token: 0x060133AF RID: 78767 RVA: 0x004C742C File Offset: 0x004C562C
		// (set) Token: 0x060133B0 RID: 78768 RVA: 0x004C7434 File Offset: 0x004C5634
		public int[] jumpTo { get; set; }

		// Token: 0x17002983 RID: 10627
		// (get) Token: 0x060133B1 RID: 78769 RVA: 0x004C743D File Offset: 0x004C563D
		// (set) Token: 0x060133B2 RID: 78770 RVA: 0x004C7445 File Offset: 0x004C5645
		public int ani { get; set; }

		// Token: 0x060133B3 RID: 78771 RVA: 0x004C7450 File Offset: 0x004C5650
		public void Parse(byte[] bytes, ref int byteIndex)
		{
			this.ani = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
			this.aniArg = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.changeBGM = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			this.dialogArr = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.jumpTo = new int[num];
				for (int i = 0; i < num; i++)
				{
					this.jumpTo[i] = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				}
			}
			this.npcName = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num2 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.param = new string[num2];
				for (int j = 0; j < num2; j++)
				{
					this.param[j] = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
				}
			}
			if (ByteUtil.ReadBoolean(bytes, ref byteIndex))
			{
				int num3 = ByteUtil.ReadSignedInt(bytes, ref byteIndex);
				this.questionArr = new string[num3];
				for (int k = 0; k < num3; k++)
				{
					this.questionArr[k] = ByteUtil.ReadUTFByte(bytes, (int)ByteUtil.ReadUnsignedShort(bytes, ref byteIndex), ref byteIndex);
				}
			}
		}
	}
}
