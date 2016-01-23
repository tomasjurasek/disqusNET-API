# disqusNET-API

In your app you need:
 <appSettings>
    <add key="Disqus:AppId" value="KEY" />
    <add key="Disqus:AppSecret"  value="KEY" />
    <add key="Disqus:AccessToken"  value="KEY" />
  </appSettings>
  
  When you want call disqus API:
  
  you need instance of  DisqusApi class. You can call 2 method:
  Disqus<ReturnObject> or Disqus whitch return HttpResponseMessage all methods you need parameters.
  1) Topic
  2) Action
  3) Method (GET, POST)
  4) Dictionary with parameters for API
  
  
