# MVCDemo+EF
---
一、MVC典型执行过程

 1. 网址路由比对
 2. 如路由地址比对成功，执行相应的Controller与Action
 3. 执行相应的View并返回结果  

 二、
	1.禁用VS Browser Link =>在webconfig的appSettings节点中新增<add key="vs:EnableBrowserLink" value="false"/>  
	2.[HttpPost]表示这个Action只会结束http post 请求。应用场景：涉及到需要接受客户端窗口数据时，创建一个用于接收
		Http Get请求的Action 用于显示界面，提供给用户填写数据；另一个同名Action应用Http Post属性，用于接收用户发来
		的数据，完成对应的功能。