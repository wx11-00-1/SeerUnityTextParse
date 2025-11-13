using System;

namespace core.model
{
	// Token: 0x0200197C RID: 6524
	public class TeamLogoInfo
	{
		// Token: 0x0600CCC0 RID: 52416 RVA: 0x003B63B8 File Offset: 0x003B45B8
		public TeamLogoInfo(ByteArray data = null)
		{
			if (data == null)
			{
				return;
			}
			this.m_Id = (int)data.ReadUnsignedInt();
			this.m_LogoBg = (int)data.ReadSignedShort();
			this.m_LogoIcon = (int)data.ReadSignedShort();
			this.m_LogoColor = (int)data.ReadSignedShort();
			this.m_TxtColor = (int)data.ReadSignedShort();
			this.m_LogoWord = data.ReadUTFByte(4);
		}

		// Token: 0x1700112C RID: 4396
		// (get) Token: 0x0600CCC1 RID: 52417 RVA: 0x003B6418 File Offset: 0x003B4618
		public int teamID
		{
			get
			{
				return this.m_Id;
			}
		}

		// Token: 0x1700112D RID: 4397
		// (get) Token: 0x0600CCC2 RID: 52418 RVA: 0x003B6420 File Offset: 0x003B4620
		// (set) Token: 0x0600CCC3 RID: 52419 RVA: 0x003B6428 File Offset: 0x003B4628
		public int logoBg
		{
			get
			{
				return this.m_LogoBg;
			}
			set
			{
				this.m_LogoBg = value;
			}
		}

		// Token: 0x1700112E RID: 4398
		// (get) Token: 0x0600CCC4 RID: 52420 RVA: 0x003B6431 File Offset: 0x003B4631
		// (set) Token: 0x0600CCC5 RID: 52421 RVA: 0x003B6439 File Offset: 0x003B4639
		public int logoIcon
		{
			get
			{
				return this.m_LogoIcon;
			}
			set
			{
				this.m_LogoIcon = value;
			}
		}

		// Token: 0x1700112F RID: 4399
		// (get) Token: 0x0600CCC6 RID: 52422 RVA: 0x003B6442 File Offset: 0x003B4642
		// (set) Token: 0x0600CCC7 RID: 52423 RVA: 0x003B644A File Offset: 0x003B464A
		public int logoColor
		{
			get
			{
				return this.m_LogoColor;
			}
			set
			{
				this.m_LogoColor = value;
			}
		}

		// Token: 0x17001130 RID: 4400
		// (get) Token: 0x0600CCC8 RID: 52424 RVA: 0x003B6453 File Offset: 0x003B4653
		// (set) Token: 0x0600CCC9 RID: 52425 RVA: 0x003B645B File Offset: 0x003B465B
		public int txtColor
		{
			get
			{
				return this.m_TxtColor;
			}
			set
			{
				this.m_TxtColor = value;
			}
		}

		// Token: 0x17001131 RID: 4401
		// (get) Token: 0x0600CCCA RID: 52426 RVA: 0x003B6464 File Offset: 0x003B4664
		// (set) Token: 0x0600CCCB RID: 52427 RVA: 0x003B646C File Offset: 0x003B466C
		public string logoWord
		{
			get
			{
				return this.m_LogoWord;
			}
			set
			{
				this.m_LogoWord = value;
			}
		}

		// Token: 0x0400E318 RID: 58136
		private int m_Id;

		// Token: 0x0400E319 RID: 58137
		private int m_LogoBg;

		// Token: 0x0400E31A RID: 58138
		private int m_LogoIcon;

		// Token: 0x0400E31B RID: 58139
		private int m_LogoColor;

		// Token: 0x0400E31C RID: 58140
		private int m_TxtColor;

		// Token: 0x0400E31D RID: 58141
		private string m_LogoWord;
	}
}
