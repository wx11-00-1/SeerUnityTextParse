using System;
using System.Collections.Generic;
using System.Linq;

namespace core.model
{
	// Token: 0x02001929 RID: 6441
	public class EmailListInfo
	{
		// Token: 0x0600CAD8 RID: 51928 RVA: 0x003B0DE8 File Offset: 0x003AEFE8
		public EmailListInfo(ByteArray data = null)
		{
			this.mId = (int)data.ReadUnsignedInt();
			this.status = (data.ReadUnsignedInt() == 0U);
			this.title = data.ReadUTFByte(64);
			this.hasAttachment = (data.ReadUnsignedInt() > 0U);
			this.attachmentGetFlag = (data.ReadUnsignedInt() > 0U);
			this.date = data.ReadUnsignedInt();
			this.m_SenderTemp = data.ReadUTFByte(64);
			this.parseSenderInfo(this.m_SenderTemp);
		}

		// Token: 0x0600CAD9 RID: 51929 RVA: 0x003B0E74 File Offset: 0x003AF074
		private void parseSenderInfo(string str)
		{
			string[] array = str.Split("&", StringSplitOptions.None);
			int headType = 0;
			int headId = 0;
			if (array.Length > 1)
			{
				string[] array2 = array[1].Split("_", StringSplitOptions.None);
				headType = Convert.ToInt32(array2[0]);
				headId = Convert.ToInt32(array2[1]);
			}
			this.m_HeadType = headType;
			this.m_HeadId = headId;
			this.m_SenderArr = array[0].Split("-", StringSplitOptions.None).ToList<string>();
			this.m_Sender = this.m_SenderArr[0];
			this._star = ((this.m_SenderArr.Count > 1) ? this.m_SenderArr[1] : string.Empty);
		}

		// Token: 0x17001058 RID: 4184
		// (get) Token: 0x0600CADA RID: 51930 RVA: 0x003B0F17 File Offset: 0x003AF117
		public int headType
		{
			get
			{
				return this.m_HeadType;
			}
		}

		// Token: 0x17001059 RID: 4185
		// (get) Token: 0x0600CADB RID: 51931 RVA: 0x003B0F1F File Offset: 0x003AF11F
		public int headId
		{
			get
			{
				return this.m_HeadId;
			}
		}

		// Token: 0x1700105A RID: 4186
		// (get) Token: 0x0600CADC RID: 51932 RVA: 0x003B0F27 File Offset: 0x003AF127
		// (set) Token: 0x0600CADD RID: 51933 RVA: 0x003B0F2F File Offset: 0x003AF12F
		public int mId
		{
			get
			{
				return this.m_MId;
			}
			set
			{
				this.m_MId = value;
			}
		}

		// Token: 0x1700105B RID: 4187
		// (get) Token: 0x0600CADE RID: 51934 RVA: 0x003B0F38 File Offset: 0x003AF138
		// (set) Token: 0x0600CADF RID: 51935 RVA: 0x003B0F40 File Offset: 0x003AF140
		public bool status
		{
			get
			{
				return this.m_Status;
			}
			set
			{
				this.m_Status = value;
			}
		}

		// Token: 0x1700105C RID: 4188
		// (get) Token: 0x0600CAE0 RID: 51936 RVA: 0x003B0F49 File Offset: 0x003AF149
		// (set) Token: 0x0600CAE1 RID: 51937 RVA: 0x003B0F51 File Offset: 0x003AF151
		public string sender
		{
			get
			{
				return this.m_Sender;
			}
			set
			{
				this.m_Sender = value;
			}
		}

		// Token: 0x1700105D RID: 4189
		// (get) Token: 0x0600CAE2 RID: 51938 RVA: 0x003B0F5A File Offset: 0x003AF15A
		// (set) Token: 0x0600CAE3 RID: 51939 RVA: 0x003B0F62 File Offset: 0x003AF162
		public string title
		{
			get
			{
				return this.m_Title;
			}
			set
			{
				this.m_Title = value;
			}
		}

		// Token: 0x1700105E RID: 4190
		// (get) Token: 0x0600CAE4 RID: 51940 RVA: 0x003B0F6B File Offset: 0x003AF16B
		// (set) Token: 0x0600CAE5 RID: 51941 RVA: 0x003B0F73 File Offset: 0x003AF173
		public uint date
		{
			get
			{
				return this.m_Date;
			}
			set
			{
				this.m_Date = value;
			}
		}

		// Token: 0x1700105F RID: 4191
		// (get) Token: 0x0600CAE6 RID: 51942 RVA: 0x003B0F7C File Offset: 0x003AF17C
		// (set) Token: 0x0600CAE7 RID: 51943 RVA: 0x003B0F84 File Offset: 0x003AF184
		public string star
		{
			get
			{
				return this._star;
			}
			set
			{
				this._star = value;
			}
		}

		// Token: 0x17001060 RID: 4192
		// (get) Token: 0x0600CAE8 RID: 51944 RVA: 0x003B0F8D File Offset: 0x003AF18D
		// (set) Token: 0x0600CAE9 RID: 51945 RVA: 0x003B0F95 File Offset: 0x003AF195
		public bool hasAttachment
		{
			get
			{
				return this.m_HasAttachment;
			}
			set
			{
				this.m_HasAttachment = value;
			}
		}

		// Token: 0x17001061 RID: 4193
		// (get) Token: 0x0600CAEA RID: 51946 RVA: 0x003B0F9E File Offset: 0x003AF19E
		// (set) Token: 0x0600CAEB RID: 51947 RVA: 0x003B0FA6 File Offset: 0x003AF1A6
		public bool attachmentGetFlag
		{
			get
			{
				return this.m_AttachmentGetFlag;
			}
			set
			{
				this.m_AttachmentGetFlag = value;
			}
		}

		// Token: 0x0400DF8D RID: 57229
		private int m_MId;

		// Token: 0x0400DF8E RID: 57230
		private bool m_Status;

		// Token: 0x0400DF8F RID: 57231
		private string m_Sender;

		// Token: 0x0400DF90 RID: 57232
		private string m_Title;

		// Token: 0x0400DF91 RID: 57233
		private bool m_HasAttachment;

		// Token: 0x0400DF92 RID: 57234
		private bool m_AttachmentGetFlag;

		// Token: 0x0400DF93 RID: 57235
		private uint m_Date;

		// Token: 0x0400DF94 RID: 57236
		private string m_SenderTemp;

		// Token: 0x0400DF95 RID: 57237
		private List<string> m_SenderArr = new List<string>();

		// Token: 0x0400DF96 RID: 57238
		private string _star;

		// Token: 0x0400DF97 RID: 57239
		private int m_HeadType;

		// Token: 0x0400DF98 RID: 57240
		private int m_HeadId;
	}
}
