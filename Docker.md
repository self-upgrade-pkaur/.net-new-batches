# Docker 
**Virtual Machine**
-  
**Containers**
- 
## Why Docker?
- Deployment stage is where we look a multi-architecture app to be deployed easily and efficiently.
## What is Docker?
- It is a software container program that contains software to be deployed with its dependencies, libraries etc. This package will be shipped in a container (like container of a ship) and deployed to platform (windows, macOS, linux etc).


## Install Docker 
- check the verions of the OS. If you have linux, macOs or windows pro its good.
- If you are having windows 10 pro or linux install real docker - > docker windows desktop 
  - client(docker quickstart terminal) and server (docker daemon) will be on Windows
- In most of the cases you have windows 10 Home which donot let you run docker truely but don't worry  so its better to download docker toolbox from (here)[https://docs.docker.com/toolbox/toolbox_install_windows/]
  - It will have client on windows and Server(daemon) in Virtual box (by oracle provided with Docker Toolbox)
  - open the *Docker Quick Start Terminal* to see the blue whale symbol which tells its running good.
  - *docker --version* will give you the curret version of docker
  - *docker run hello-world*
  - create a new dotnet console app and lets deploy in docker env by containerising it.
  -  create a docker file using terminal *touch dockerfile* (make sure you see the blue whale on VSCode Explorer). 
  -  find the docker image [here](https://github.com/200106-UTA-PRS-NET/training-code/tree/master/04DevOps)
  -  We need the runtime int the container to run our console app. We should:
     -  `docker pull mcr.microsoft.com/dotnet/core/runtime:3.1` will let you pull the image from the docker hub (registry). So we can use this every time by using docker instruction in dockerfile `FROM mcr.microsoft.com/dotnet/core/runtime:3.1`
  -  The runtime now needs to make a build to get the assembly (exe/dll). Also it is case sensitive.




## docker with MVC Appp
- when you do `docker run` here it will run mvc app in the container but it will not let you access the localhost:5000 outside the container
- use multi-stage 
- connection strings are added as command line check mvc docker file on repo
- add docker ignore to avoid bin and obj file going to the docker on build
- inspect container - to see the logs
- upload the images to docker hub 
- trying merge conflict with git



