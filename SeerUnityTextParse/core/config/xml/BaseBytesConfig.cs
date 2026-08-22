namespace core.config.xml
{
	public interface BaseBytesConfig
	{
		void Parse(byte[] bytes, ref int byteIndex);
	}
}
