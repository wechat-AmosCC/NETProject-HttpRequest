AmosHttpRequest
=========

C# Http����


=========


### API
SerialPortHelp
========================================
Get��ʽ
----------------------------------------
DoWebRequestByGet


Post��ʽ
----------------------------------------
HttpPost


���ʹ��
----------------------------------------
RestClient client = new RestClient("IP");

string result1 = client.HttpPost(ssurl, ssvalue);
Console.WriteLine(result1);