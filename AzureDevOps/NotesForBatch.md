## [SDLC](https://www.tutorialspoint.com/sdlc/sdlc_overview.htm):
*Phases*
    - Requirement Analysis - SRS
    - Design of the Product - DDS
    - Development - build product
    - Testing - manual, automation
    - Deployment - on various environment
    - Maintainence - bug fixes, enhancements, new features
*Models*
    - Waterfall Model : linear-sequential life cycle model
    - Big-Bang 
    - Iterative Model
        - Spiral Model
        - Agile Model
            - Scrum : Scrum master, Stakeholder, Dev-team
                - sprint review : look at the process (user story assignation, estimation)
                - sprint retrospection : a demo to stakeholder to check the product match the requirement
            - Kanban : watching tape recordings to strategise the game
            - CMMI : NCAA (football associations)

## Deployment of Application:
### 1. [Host on Windows with IIS](https://docs.microsoft.com/en-us/aspnet/core/host-and-deploy/iis/?view=aspnetcore-2.2#iis-configuration)
- Install IIS on your machine
- Add this code to disable automatic authentication
 ```
services.Configure<IISServerOptions>(options => 
{
    options.AutomaticAuthentication = false;
});
```
- [Install the .NET Core Hosting Bundle](https://dotnet.microsoft.com/download/thank-you/dotnet-runtime-2.2.5-windows-hosting-bundle-installer) - this bundle installs the .NET Core Runtime, .NET Core Library, and the ASP.NET Core Module.
- execute following commands on VS developer Command prompt witt admin rights to restart IIS: 
    - `net stop was /y`
    - `net start w3svc`
- or execute `iisreset`
(Restarting IIS picks up a change to the system PATH, which is an environment variable, made by the installer.)
- Create folder for the app in C:/inetpub/wwwroot/[appfoldername]
- use VS2019 Web Deploy to package and publish your app into a Folder 

### 2. Host on Azure App Service

### 3. Make Azure Pipeline for CI/CD

### 4. Vocab:
    - [Code Coverage](https://confluence.atlassian.com/clover/about-code-coverage-71599496.html)

