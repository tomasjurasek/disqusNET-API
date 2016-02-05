# disqusNET-API

This is C# library for disqus API (https://disqus.com/api/docs/)
### In your app you need in config:
```cs
<appSettings>
    <add key="Disqus:AppId" value="KEY" />
    <add key="Disqus:AppSecret"  value="KEY" />
    <add key="Disqus:AccessToken"  value="KEY" />
</appSettings>
 ```
  

  
### You can call 2 methods:
  - Disqus<'ReturnObject'> (objects are defined in DTO folder)
  - Disqus whitch returns HttpResponseMessage
  
### Parameters:
  - 1) Topic
  - 2) Action
  - 3) Method (GET, POST)
  - 4) Dictionary with parameters for API
  
Valid Topics and Actions you can find on https://disqus.com/api/docs/.
If you want use some Topics and Actions, first check if they are in interface.json file in project.
  

### Example

  ```cs
   var parameters = new Dictionary<string, string>
            {

                {"short_name","unique_name" },
                {"name","Name" },
                {"website", "http://website.cz"}
            };
            
   DisqusApi disqusApi = new DisqusApi();
   var result = disqusApi.Disqus<ForumCreate>("forums", "create", disqusNETAPI.Enums.Method.POST, parameters);
   ```

For now we support only this action:

- Forums
    - Create
    - Update
    - ListThreads
- Posts
    - Remove
    - Spam
- Threads
    - Create
    - ListPosts
