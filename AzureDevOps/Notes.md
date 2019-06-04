DEVOPS WEEK: 

SONAR CLOUD:
sonarcloud.io
General settings-> all  libs and js files
show bugs, code smells
technical debt

Azure DevOps
-> in github, install Azure Pipelines App for ALL REPOSITORIES
-> // Visual Designer for release
-> recommended is yaml for build
root
    - variable(env variable)
    -job
        -pool
            -vmImages 'ubuntu-1804' or
                        'vshosted2017'
            -condition : if()
            -steps
                -scripts: dotnet-test //need to install Coverlet.MsBuild nuget package -> ////test projects
                //MSTest could give some error
                -task
    -trigger
        -branch


Preparation links :
1. Journey articles: https://docs.microsoft.com/en-us/azure/devops/get-started/?view=azure-devops
    - Agile : https://docs.microsoft.com/en-us/azure/devops/learn/agile/what-is-agile?view=azure-devops
    - DevOps : https://docs.microsoft.com/en-us/azure/devops/learn/what-is-devops?view=azure-devops
    - Git : https://docs.microsoft.com/en-us/azure/devops/learn/git/what-is-git?view=azure-devops
2.  

Lesson:

    - Agile-> cowboy coding 



GIT : It is a distributes VCS.
*[git workflow](https://www.atlassian.com/git/tutorials/comparing-workflows)*
    - Designed to be guidelines for team collaboration.
    - Workflow is created as per the teams and culture.
    - The idea is to enhance effectiveness and hence productivity.
    - Some things to consider when evaluating a Git workflow are:
        - Does this workflow scale with team size?
        - Is it easy to undo mistakes and errors with this workflow?
        - Does this workflow impose any new unnecessary cognitive overhead to the team?
*git demo* - individual
- `git config --global user.name "Pushpinder Kaur"`
- `git config --global user.email "pushpinder@revature.com"`
- `git init` -> to initialize the git locally -> this will add a local .git folder
- `cd projectfolder`
- `git status` -> to see tracked or tracked files
- `git add [file1] [file2]`  -> add the respective file to stage (means ready to commit) or     use `git add -A` for adding all the files
- `git commit -m 'message'`
-  `git log`-> to see the commits 
- create a repo on git as repo1
- `git remote add origin 'url for repo1'` -> get url from the repo to connect your local        git system to the git server
- `git remote -v` -> to verify if the local git is connected to the git server
- `git push`or `git push -u origin master`-> to make changes to server or master branch
- `git fetch -u origin master` -> to get changes done from the server
- `git merge origin/master` -> to merge changes in the local
- `git pull origin master` -> to shortcircuit fetch follwed by pull
- create another repo repo2 and lets connect this repo2 to the local copy of repo1 locally    by removing previous repo1 connection
- `git remote origin` - removes the connection of repo1 on the server
- `git remote add origin 'url for repo 2'`
- `git remote -v`-> to verify again where is the repo connected to
- `git push` to push the files commited locally to the server -> this will fail because of Pull required
- `git pull origin master` -> to pull the readMe file this fails to because the commit history locally and on server donot match 
-  `git pull origin master --allowed-unrelated-histories` -> allows the histories to be matched
- *shift + : + q* - to exit the error codes
- `git push -u origin master` or `git push --set-upstream origin master`
 
*git demo 1* - team
- dev 1 - 
    - `git checkout origin master`
    - `git commit -m 'new commit message`
    - `git push origin master`
- dev 2
    - `git checkout -b dev2feature1` 
    - `git commit - m 'added ne w feature1'`
    - `git push origin dev2feature1`
- dev 1 
    - `git pull `
    - `git merge dev2feature1`

*git demo 2* - team
- create a git repo
- clone in local repo
- `git log` - to get all the logs in details
- `git log --oneline` gives all commit messages
- create a new branch in git bash  `git branch branchname`
- `git branch -a` to check what are the other available branches . * points to master at this point which means git points to master.
- `git checkout branchname` will point to the new git branch
- make changes and do `git status`
- `git commit in feature-1`
- `git branch -d feature-1`
- `git branch -D feature-1`
- `git checkout -b feature-a` -> this creates a new branch and also check it out