-.csProj
    - dependencies
    - Servers 

- launchSettings.json
    - show Servers

- appSettings.json

-Environment variable : https://www.youtube.com/redirect?redir_token=AowgEdtJqN4pKKNa8XpywjdX3j18MTU1ODcyMjEwN0AxNTU4NjM1NzA3&q=https%3A%2F%2Fcsharp-video-tutorials.blogspot.com%2F2019%2F02%2Faspnet-core-environment-variables.html&v=x8jNX1nb_og&event=video_description
    env.Environment in Run
    change Env var in launchSettings
    Add Env var in OS (restart VS2019 or system as well or by default it shows Prod)

-MVC :https://www.youtube.com/redirect?q=https%3A%2F%2Fcsharp-video-tutorials.blogspot.com%2F2019%2F02%2Faspnet-core-mvc-tutorial.html&event=video_description&v=f72ookCWhsQ&redir_token=ReEWOQIaRN9ctzQt4Ibq517K3-h8MTU1ODcyMzAwM0AxNTU4NjM2NjAz

## Configure ASP NET Core request processing pipeline
 - [Reference](https://csharp-video-tutorials.blogspot.com/2019/01/aspnet-core-appsettingsjson-file.html)
 - Revise basic middle ware 
    -> Show demo again 
    -> Run() vs Use() middle ware
 - Show ILogger as dependency added in the middle ware and its usage
 - Explain DI with Ex :
    - try  -> throws Divide By Zero Execption
    - catch () -> Logs in text file
    - TextLogger -> logs in text

    - try  -> throws another Exception
    - catch () -> Logs in DB
    - DbLogger -> Logs in DB

    - instead of creating many instances of Object we can inject the object type as dependency through contructors
    - ILogger implemented by TextLogger and DbLogger
    - LogManager.cs have ConstructorDependency
    ```
    class LogManager
    {
        private ILogger _logger;
        public LogManager(ILogger logger)
        {
            _logger = logger;
        }

        public void Log(String message)
        {
            _logger.Log(message);
        }
    }
    ```

## ASP NET Core appsettings json file
- [Reference](https://csharp-video-tutorials.blogspot.com/2019/01/aspnet-core-appsettingsjson-file.html)
- In ASP.NET Core application configuration settings can come from the following different configurations sources. 
    - Files (appsettings.json, appsettings.{Environment}.json, where {Environment} is the - app's current hosting environment)
    - User secrets
    - Environment variables
    - Command-line arguments
- Upon inspecting the file, you will see, the following is the default order in which the various configuration sources are read 
    - appsettings.json, 
    - appsettings.{Environment}.json
    - User secrets
    - Environment variables - > launchSettings.json
    - Command-line arguments - using .net CLI commands 
        `dotnet run MyOwnKey=CMD`

### SetUp MVC in Asp.Net Core
    - Add a static file home.html in  wwwroot and also an image
    -  show use of app.UseStaticFiles();
    -show default file load option here
    `UseDefaultFiles(defaultFilesOptions)`
    ```
    DefaultFilesOptions defaultFilesOptions = new DefaultFilesOptions();
    defaultFilesOptions.DefaultFileNames.Clear();
    defaultFilesOptions.DefaultFileNames.Add("foo.html");
    ```
    - Add Service in ConfigureServices()
        - `Services.AddMvc();`
    - Add middleware 
        - comment the UseDefaultFile()
        - `app.UseMvcWithDefaultRoute();`//show defeinition of the 
    
    - Run to see `Hello MVC` from app.UseMvcWithDefaultRoute Middleware
    - type home/index -> refresh page after save
    - type about/index and see the process name from app.Run middleware
    - Now comment the app.Run and refresh the page to see 404 error 
    - now comment AddMvc service and refresh to see error (make sure the env variable is development)
    - Clean Up:
        uncomment required middleware

## Model in ASP NET Core MVC
    - inherit the HomeContoller class with Controller base class 
    - show we can return many other Results
    - Create a Model Folder : restaurant
    - Pass it to Controller and return JsonResult and run 

## Controller in ASP NET Core MVC
    - Controller handles the user request
    - Controller has Action Methods
    - ActionMethods can return string or ActionResult - JsonResult, Objectresult, ViewResult

    IActionResult ->ActionResult-> ContentResult
                                -> EmptyResult
                                -> FileResult
                                -> JsonResult
                                -> ObjectResult
                                -> PartialViewResult
                                -> RedirectResult
                                -> ViewResult
    - Show how a View is returned as a by default behaviour and also then how we can customize it.
        - Create another MyViews Folder and add a Test.cshtnl and point the View to the new view
            - return View("MyViews/Test.cshtml");
            - return View("/MyViews/Test.cshtml");
            - return View("~/MyViews/Test.cshtml");
            - return View("../Test/Update");
            - return View("../../MyViews/Details");

## Passing data to view in ASP NET Core MVC
    - ViewData[] with value and also with model
    - ViewBag
        - @ViewData["key"]
        - Show the issue of ViewData with model
        - show ViewBag
        - Show Strongly Typed View with model
        - 
## ViewModel in ASP NET Core MVC
    - VieeModel - class where we keep multiple model classes required for a view
    - we also call them DTOs

## Layouts
- Shared folder 
        - _layout.cshtml from template as razor Page
        - Explain @RenderBody
        - Bind view with @layout ="path"
        - _ViewStart - use template Razor view Start
        - @renderSection : [ref](https://csharp-video-tutorials.blogspot.com/2019/03/sections-in-layout-page-in-aspnet-core.html)
    _Layout.cshtml
        @RenderSection("Scripts", required: false)
            or 
        @if (IsSectionDefined("Scripts"))
        {
            @RenderSection("Scripts", required: false)
        }

- View 
    @section Scripts {
        <script src="~/js/CustomScript.js"></script>
        }

## Client Side Library:
    - use bower, NPM, Webpack or *LibMan* to install jQuery or bootstrap like files
    - *LibMan* is client-side Acquisition tool used to install client side libraries and framework from CDN/file systems.
    - To use LibMan you need to have 15.8 or above version on VS
    - Search for cdnjs -> twitter-bootstraop@version
    - See libman.json folder under the root of the solution/project. This is the manifest file to keep track of all client-side lib.
    - you can still remove all client side Libraries by RC on liman.json and Clean option. This still preserves the reference which can be used to restore the client -side lib

## Helpers
- Server side components to generate to create and render HTML elements
- Types:
    - Tag Helpers: 
        add `@addTagHelper *, Microsoft.AspNetCore.Mvc.TagHelpers` to your `.cshtml` file
    - Html Helpers
