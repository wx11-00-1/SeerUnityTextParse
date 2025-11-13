using System;

namespace core.model
{
	// Token: 0x02001936 RID: 6454
	public class GainWayItemInfo
	{
		// Token: 0x170010A8 RID: 4264
		// (get) Token: 0x0600CB75 RID: 52085 RVA: 0x003B1FD8 File Offset: 0x003B01D8
		// (set) Token: 0x0600CB76 RID: 52086 RVA: 0x003B1FE0 File Offset: 0x003B01E0
		public string show
		{
			get
			{
				return this.m_Show;
			}
			set
			{
				this.m_Show = value;
			}
		}

		// Token: 0x170010A9 RID: 4265
		// (get) Token: 0x0600CB77 RID: 52087 RVA: 0x003B1FE9 File Offset: 0x003B01E9
		// (set) Token: 0x0600CB78 RID: 52088 RVA: 0x003B1FF1 File Offset: 0x003B01F1
		public string frontGoto
		{
			get
			{
				return this.m_FrontGoto;
			}
			set
			{
				this.m_FrontGoto = value;
			}
		}

		// Token: 0x170010AA RID: 4266
		// (get) Token: 0x0600CB79 RID: 52089 RVA: 0x003B1FFA File Offset: 0x003B01FA
		// (set) Token: 0x0600CB7A RID: 52090 RVA: 0x003B2002 File Offset: 0x003B0202
		public string gotoDO
		{
			get
			{
				return this.m_Goto;
			}
			set
			{
				this.m_Goto = value;
			}
		}

		// Token: 0x170010AB RID: 4267
		// (get) Token: 0x0600CB7B RID: 52091 RVA: 0x003B200B File Offset: 0x003B020B
		// (set) Token: 0x0600CB7C RID: 52092 RVA: 0x003B2013 File Offset: 0x003B0213
		public string type
		{
			get
			{
				return this.m_Type;
			}
			set
			{
				this.m_Type = value;
			}
		}

		// Token: 0x170010AC RID: 4268
		// (get) Token: 0x0600CB7D RID: 52093 RVA: 0x003B201C File Offset: 0x003B021C
		// (set) Token: 0x0600CB7E RID: 52094 RVA: 0x003B2024 File Offset: 0x003B0224
		public string tab
		{
			get
			{
				return this.m_Tab;
			}
			set
			{
				this.m_Tab = value;
			}
		}

		// Token: 0x170010AD RID: 4269
		// (get) Token: 0x0600CB7F RID: 52095 RVA: 0x003B202D File Offset: 0x003B022D
		// (set) Token: 0x0600CB80 RID: 52096 RVA: 0x003B2035 File Offset: 0x003B0235
		public string text
		{
			get
			{
				return this.m_Text;
			}
			set
			{
				this.m_Text = value;
			}
		}

		// Token: 0x0400DFFA RID: 57338
		private string m_Show;

		// Token: 0x0400DFFB RID: 57339
		private string m_FrontGoto;

		// Token: 0x0400DFFC RID: 57340
		private string m_Goto;

		// Token: 0x0400DFFD RID: 57341
		private string m_Type;

		// Token: 0x0400DFFE RID: 57342
		private string m_Tab;

		// Token: 0x0400DFFF RID: 57343
		private string m_Text;

		// Token: 0x0400E000 RID: 57344
		private object m_OtherData;
	}
}
