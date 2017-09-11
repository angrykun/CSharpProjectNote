一、MVC典型执行过程

网址路由比对
如路由地址比对成功，执行相应的Controller与Action
执行相应的View并返回结果
数据库连接字符串(localdb) 
<connectionStrings> 
<add name="AccountContext" connectionString="Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MvcDemo2;Integrated Security=True;AttachDBFilename=|DataDirectory|\MvcDemo2.mdf;MultiSubnetFailover=False" providerName="System.Data.SqlClient" /> 
</connectionStrings>

二、说明 
1.禁用VS Browser Link =>在webconfig的appSettings节点中新增<add key="vs:EnableBrowserLink" value="false"/> 
2.[HttpPost]表示这个Action只会结束http post 请求。应用场景：涉及到需要接受客户端窗口数据时，创建一个用于接收。 
Http Get请求的Action用于显示界面，提供给用户填写数据；另一个同名Action应用Http Post属性，用于接收用户发来的数据，完成对应的功能。 
3.Models文件夹里面存放对应于数据库表的实体。 
View中需要显示的数据和Models中实体模型不一定对应上，因此需要专门给VIew使用的自定义数据模型，我们称之为ViewModel，放在ViewModels文件夹中。 
4.DAL 放置数据访问相关类。 
5.如果不使用ORM框架，我们一般这样来使用ADO.NET 进行数据库操作 
1）将ADO.NET对数据库的操作封装到一个类里SqlHelper中。 
2）在DAL层调用SQLHelper。 
3）在其他层再调用DAL进行数据库操作。 
使用ORM框架之后，以SysUser为例： 
O(Object)->程序中的类SysUser(对象) 
R(Relation)->数据库中的表 
M(Mapping)->O和R的映射关系 
ORM对传统方式的改进： 
充当桥梁，实现了关系数据和对象数据的映射，通过映射自动产生SQL语句。对常用的操作，节省了写SQL语句的步骤。 
6.EF数据查询用LINQ(Linq to Entities)通常有表达式和函数式两种方式，建议使用函数方式比较简单。 
更新数据时，分三步：找到对象-> 更新对象数据->保存更改 
7.HtmlHelper 
DisplayNameFor(model=>model.xxx)->生成纯文本，显示列名 
DisplauFor(model=>model.xxx)->生成纯文本，显示列的内容 
LabelFor->生成label标签 
EditFor->生成text类型input标签 
PasswordFor->类似于EditorFor, 隐藏文本内容 
ActionLink ->生成一个标签 
BeginForm-> 生成一个表单

8.Repository Pattern 仓储模式 
仓储模式具体做法：先定义Interface(接口)，通过定义接口确定数据访问类的功能需求，接着实现该接口。 
9.Html.ActionLink生成一个a标签 
Url.Action 只是返回一个URL 
10.分部试图 
Partial View 指可应用于View中作为View的一部分 
View及其中所有的Partial View默认情况下共享View中的ViewData，ViewBag 
XXX/RenderXXX的区别在于：一个直接返回字符串，另一个直接写入到相应输出流，因此不能直接放在代码中，必须放在代码块中。RenderXXX有轻微的性能优势。 
11.启用数据库自动迁移 
Enable-Migrations：在项目根目录下创建了一个Migrations文件夹，在Migrations文件夹下创建一个Configuration.cs文件 
add-migration InitialCreate： 
update-databse：更新数据库 
13.DataType属性用来指定更加具体的数据类型，DataType枚举值提供了一些常见的类型，比如DateTime,Email,Address等。但是DataType不能指定数据类型的显示格式。使用DisplayFormate属性指定显示的格式。 
14.StringLength属性设置了数据库存储字段的最大长度，为程序提供客户端和服务器端验证。 
15.Column属性，当Model中字段与数据库中表的字段不同时使用，Column代表数据库中的字段。 
1）可以将多个属性写在一块用逗号隔开，例如 
[Column("FirstName"),Display(Name = "First Name"),StringLength(50, MinimumLength=1)] 
2)对于某一些类型来说，不需要使用Required,例如DateTime，int，float因为这些类型不能被赋值空值。 
3)指定Column的TypeName可以改变SQL Data Type，[Colum(TypeName="money")]  

16、细说仓储模式的应用
	在业务逻辑层调用数据层操作数据，耦合性太高，另外，业务逻辑直接访问数据存储层会导致一些问题：重复代码、不容易
	集中使用数据相关策略，例如缓存，后续维护，修改增加新功能不方便。
	我们使用Repository来将业务层和数据实体层分开来，业务逻辑层应对组成数据源的数据类型不可知，比如数据源可能是数据库
	或者是web service 。在数据层和业务层增加一个Repository层进行协调，有如下作用：1）从数据源中查数据，2）映射数据到业务实体
	3）将业务实体数据的修改保存到数据源。
	数据和业务分隔优点：
	1）集中管理不同底层数据源逻辑。
	2）给单元测试提供分离点。
	3）提供弹性架构，整体设计可适应程序的不断进化。