# MVCDemo+EF
---
一、MVC典型执行过程

 1. 网址路由比对
 2. 如路由地址比对成功，执行相应的Controller与Action
 3. 执行相应的View并返回结果  
 4.数据库连接字符串(localdb)
 <connectionStrings>
    <add name="AccountContext" connectionString="Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MvcDemo2;Integrated Security=True;AttachDBFilename=|DataDirectory|\MvcDemo2.mdf;MultiSubnetFailover=False" providerName="System.Data.SqlClient" />
  </connectionStrings>

 二、说明  
	1.禁用VS Browser Link =>在webconfig的appSettings节点中新增<add key="vs:EnableBrowserLink" value="false"/>  
	2.[HttpPost]表示这个Action只会结束http post 请求。应用场景：涉及到需要接受客户端窗口数据时，创建一个用于接收
		Http Get请求的Action 用于显示界面，提供给用户填写数据；另一个同名Action应用Http Post属性，用于接收用户发来
		的数据，完成对应的功能。
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
	更新数据时，分三步：找到对象->	更新对象数据->保存更改
	7.HtmlHelper
		DisplayNameFor(model=>model.xxx)->生成纯文本，显示列名
		DisplauFor(model=>model.xxx)->生成纯文本，显示列的内容
		LabelFor->生成label标签
		EditFor->生成text类型input标签
		PasswordFor à 类似于EditorFor, 隐藏文本内容
		ActionLink à 生成一个<a>标签
		BeginForm à 生成一个表单
	8.Repository Pattern 仓储模式
		仓储模式具体做法：先定义Interface(接口)，通过定义接口确定数据访问类的功能需求，接着实现该接口。
	9.Html.ActionLink生成一个a标签
		Url.Action 只是返回一个URL
	10.分部试图
		Partial View 指可应用于View中作为View的一部分
		View及其中所有的Partial View默认情况下共享View中的ViewData，ViewBag
		XXX/RenderXXX的区别在于：一个直接返回字符串，另一个直接写入到相应输出流，因此不能直接放在代码中，必须放在代码块中。RenderXXX有轻微的性能优势。