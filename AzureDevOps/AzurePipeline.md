- create a new project on Azure devops pipeline
- Tell where your code is : Github
- Select Repo 
- Add Azure pipelines in Github repos on git hub
- Project Settings-> Service Connections-> User Service Principle to validate credentials of your Azure with Azure DevOps


### Glosaary
- What is DevOps? [Concepts](https://docs.microsoft.com/en-us/azure/devops/learn/what-is-devops)
- What is Docker? [Concepts and Vocab](https://docs.microsoft.com/en-us/dotnet/architecture/microservices/container-docker-introduction/)
- Continuous integration (CI) is the process of automating the build and testing of code every time a team member commits changes to version control.
    - CI encourages developers to share their code and unit tests by merging their changes into a shared version control repository after every small task completion. 
    - Committing code triggers an automated build system to grab the latest code from the shared repository and to build, test, and validate the full master branch (also known as the trunk or main)
    - 
- Azure Pipelines - It is a cloud service that you can use to automatically build, test, and deploy your code project. You can also make it available to other users. And it works with just about any language or project type.
- Build Server : build server has problems. Even keeping it up-to-date is hard. Because Azure Pipelines provides build servers that Microsoft hosts and maintains, it always has the latest patches and security updates. 
- Task- A task is a packaged script or procedure that's been abstracted with a set of inputs