# MVCDemo+EF
---
һ��MVC����ִ�й���

 1. ��ַ·�ɱȶ�
 2. ��·�ɵ�ַ�ȶԳɹ���ִ����Ӧ��Controller��Action
 3. ִ����Ӧ��View�����ؽ��  
 4.���ݿ������ַ���(localdb)
 <connectionStrings>
    <add name="AccountContext" connectionString="Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MvcDemo2;Integrated Security=True;AttachDBFilename=|DataDirectory|\MvcDemo2.mdf;MultiSubnetFailover=False" providerName="System.Data.SqlClient" />
  </connectionStrings>

 ����˵��  
	1.����VS Browser Link =>��webconfig��appSettings�ڵ�������<add key="vs:EnableBrowserLink" value="false"/>  
	2.[HttpPost]��ʾ���Actionֻ�����http post ����Ӧ�ó������漰����Ҫ���ܿͻ��˴�������ʱ������һ�����ڽ���
		Http Get�����Action ������ʾ���棬�ṩ���û���д���ݣ���һ��ͬ��ActionӦ��Http Post���ԣ����ڽ����û�����
		�����ݣ���ɶ�Ӧ�Ĺ��ܡ�
	3.Models�ļ��������Ŷ�Ӧ�����ݿ���ʵ�塣
	  View����Ҫ��ʾ�����ݺ�Models��ʵ��ģ�Ͳ�һ����Ӧ�ϣ������Ҫר�Ÿ�VIewʹ�õ��Զ�������ģ�ͣ����ǳ�֮ΪViewModel������ViewModels�ļ����С�
	4.DAL �������ݷ�������ࡣ
	5.�����ʹ��ORM��ܣ�����һ��������ʹ��ADO.NET �������ݿ����
		1����ADO.NET�����ݿ�Ĳ�����װ��һ������SqlHelper�С�
		2����DAL�����SQLHelper��
		3�����������ٵ���DAL�������ݿ������
		ʹ��ORM���֮����SysUserΪ����
		O(Object)->�����е���SysUser(����)
		R(Relation)->���ݿ��еı�
		M(Mapping)->O��R��ӳ���ϵ
		ORM�Դ�ͳ��ʽ�ĸĽ���
			�䵱������ʵ���˹�ϵ���ݺͶ������ݵ�ӳ�䣬ͨ��ӳ���Զ�����SQL��䡣�Գ��õĲ�������ʡ��дSQL���Ĳ��衣
	6.EF���ݲ�ѯ��LINQ(Linq to Entities)ͨ���б��ʽ�ͺ���ʽ���ַ�ʽ������ʹ�ú�����ʽ�Ƚϼ򵥡�
	��������ʱ�����������ҵ�����->	���¶�������->�������
	7.HtmlHelper
		DisplayNameFor(model=>model.xxx)->���ɴ��ı�����ʾ����
		DisplauFor(model=>model.xxx)->���ɴ��ı�����ʾ�е�����
		LabelFor->����label��ǩ
		EditFor->����text����input��ǩ
		PasswordFor �� ������EditorFor, �����ı�����
		ActionLink �� ����һ��<a>��ǩ
		BeginForm �� ����һ����
	8.Repository Pattern �ִ�ģʽ
		�ִ�ģʽ�����������ȶ���Interface(�ӿ�)��ͨ������ӿ�ȷ�����ݷ�����Ĺ������󣬽���ʵ�ָýӿڡ�
	9.Html.ActionLink����һ��a��ǩ
		Url.Action ֻ�Ƿ���һ��URL
	10.�ֲ���ͼ
		Partial View ָ��Ӧ����View����ΪView��һ����
		View���������е�Partial ViewĬ������¹���View�е�ViewData��ViewBag
		XXX/RenderXXX���������ڣ�һ��ֱ�ӷ����ַ�������һ��ֱ��д�뵽��Ӧ���������˲���ֱ�ӷ��ڴ����У�������ڴ�����С�RenderXXX����΢���������ơ�