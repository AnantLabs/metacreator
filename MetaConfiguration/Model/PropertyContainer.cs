using System.ComponentModel;

namespace MetaConfiguration.Model
{
	public class PropertyContainer
	{
		/// <summary>
		/// ��� ��������
		/// </summary>
		private string _name;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		/// <summary>
		/// ��� ��������. �������, ������ ��� �� ������ ���������� ��� �� ����� ����� �������, ������� ������������� � �������.
		/// </summary>
		private string _type;

		public string Type
		{
			get { return _type; }
			set { _type = value; }
		}

		/// <summary>
		/// ����, ������������ ������������� �� ��������
		/// �� ����� ������������� � �������� ������
		/// </summary>
		private bool _isCollection;

		[DefaultValue(false)]
		public bool IsCollection
		{
			get { return _isCollection; }
			set { _isCollection = value; }
		}
	}
}