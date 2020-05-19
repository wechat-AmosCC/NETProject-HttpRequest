AmosHttpRequest
=========

C# Http请求


=========


### API
SerialPortHelp
========================================
Get方式
----------------------------------------
DoWebRequestByGet


Post方式
----------------------------------------
HttpPost


如何使用
----------------------------------------
RestClient client = new RestClient("IP");

string result1 = client.HttpPost(ssurl, ssvalue);
Console.WriteLine(result1);