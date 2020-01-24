# EFHelper version 1.0.0
## Minimum Requirement For Installation  
   1.TargetFramework netcoreapp 2.1
   2.Microsoft.CodeAnalysis 3.4.0
   3.Microsoft.EntityFrameworkCore 2.1.8
## How To Use
   1.Instance your DatabaseContext ,ex: var myUserDBContext = new UserDBContext(). </br>
     if you want specific connection timeout, please set in your DBContext</br>
   2.Create Instance class of RepoWrapper or  RepoWrapperAsync </br>
     var repoWrapper =  new RepoWrapper(myUserDBContext) </br>
     if make call instance new RepoWrapper(), you must call SetConnectionContext(DbContext dbContext) </br>
