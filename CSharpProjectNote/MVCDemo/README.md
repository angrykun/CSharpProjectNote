һ��MVC����ִ�й���

��ַ·�ɱȶ�
��·�ɵ�ַ�ȶԳɹ���ִ����Ӧ��Controller��Action
ִ����Ӧ��View�����ؽ��
���ݿ������ַ���(localdb) 
<connectionStrings> 
<add name="AccountContext" connectionString="Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MvcDemo2;Integrated Security=True;AttachDBFilename=|DataDirectory|\MvcDemo2.mdf;MultiSubnetFailover=False" providerName="System.Data.SqlClient" /> 
</connectionStrings>

����˵�� 
1.����VS Browser Link =>��webconfig��appSettings�ڵ�������<add key="vs:EnableBrowserLink" value="false"/> 
2.[HttpPost]��ʾ���Actionֻ�����http post ����Ӧ�ó������漰����Ҫ���ܿͻ��˴�������ʱ������һ�����ڽ��ա� 
Http Get�����Action������ʾ���棬�ṩ���û���д���ݣ���һ��ͬ��ActionӦ��Http Post���ԣ����ڽ����û����������ݣ���ɶ�Ӧ�Ĺ��ܡ� 
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
��������ʱ�����������ҵ�����-> ���¶�������->������� 
7.HtmlHelper 
DisplayNameFor(model=>model.xxx)->���ɴ��ı�����ʾ���� 
DisplauFor(model=>model.xxx)->���ɴ��ı�����ʾ�е����� 
LabelFor->����label��ǩ 
EditFor->����text����input��ǩ 
PasswordFor->������EditorFor, �����ı����� 
ActionLink ->����һ����ǩ 
BeginForm-> ����һ����

8.Repository Pattern �ִ�ģʽ 
�ִ�ģʽ�����������ȶ���Interface(�ӿ�)��ͨ������ӿ�ȷ�����ݷ�����Ĺ������󣬽���ʵ�ָýӿڡ� 
9.Html.ActionLink����һ��a��ǩ 
Url.Action ֻ�Ƿ���һ��URL 
10.�ֲ���ͼ 
Partial View ָ��Ӧ����View����ΪView��һ���� 
View���������е�Partial ViewĬ������¹���View�е�ViewData��ViewBag 
XXX/RenderXXX���������ڣ�һ��ֱ�ӷ����ַ�������һ��ֱ��д�뵽��Ӧ���������˲���ֱ�ӷ��ڴ����У�������ڴ�����С�RenderXXX����΢���������ơ� 
11.�������ݿ��Զ�Ǩ�� 
Enable-Migrations������Ŀ��Ŀ¼�´�����һ��Migrations�ļ��У���Migrations�ļ����´���һ��Configuration.cs�ļ� 
add-migration InitialCreate�� 
update-databse���������ݿ� 
13.DataType��������ָ�����Ӿ�����������ͣ�DataTypeö��ֵ�ṩ��һЩ���������ͣ�����DateTime,Email,Address�ȡ�����DataType����ָ���������͵���ʾ��ʽ��ʹ��DisplayFormate����ָ����ʾ�ĸ�ʽ�� 
14.StringLength�������������ݿ�洢�ֶε���󳤶ȣ�Ϊ�����ṩ�ͻ��˺ͷ���������֤�� 
15.Column���ԣ���Model���ֶ������ݿ��б���ֶβ�ͬʱʹ�ã�Column�������ݿ��е��ֶΡ� 
1�����Խ��������д��һ���ö��Ÿ��������� 
[Column("FirstName"),Display(Name = "First Name"),StringLength(50, MinimumLength=1)] 
2)����ĳһЩ������˵������Ҫʹ��Required,����DateTime��int��float��Ϊ��Щ���Ͳ��ܱ���ֵ��ֵ�� 
3)ָ��Column��TypeName���Ըı�SQL Data Type��[Colum(TypeName="money")]  

16��ϸ˵�ִ�ģʽ��Ӧ��
	��ҵ���߼���������ݲ�������ݣ������̫�ߣ����⣬ҵ���߼�ֱ�ӷ������ݴ洢��ᵼ��һЩ���⣺�ظ����롢������
	����ʹ��������ز��ԣ����绺�棬����ά�����޸������¹��ܲ����㡣
	����ʹ��Repository����ҵ��������ʵ���ֿ�����ҵ���߼���Ӧ���������Դ���������Ͳ���֪����������Դ���������ݿ�
	������web service �������ݲ��ҵ�������һ��Repository�����Э�������������ã�1��������Դ�в����ݣ�2��ӳ�����ݵ�ҵ��ʵ��
	3����ҵ��ʵ�����ݵ��޸ı��浽����Դ��
	���ݺ�ҵ��ָ��ŵ㣺
	1�����й���ͬ�ײ�����Դ�߼���
	2������Ԫ�����ṩ����㡣
	3���ṩ���Լܹ���������ƿ���Ӧ����Ĳ��Ͻ�����