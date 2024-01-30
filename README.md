# ITS Messe Project

## Prerequisites: Libraries and Components

First, clone the GitHub repository from: [ITS Messe Project Repository](https://github.com/fehart20/its-messe-project)

The project works with the .NET Framework 6 (REST API server) and 8 (Messe Client).
Additionally, the following NuGet packages must be installed (usually included in the Git repository):
- Microsoft.EntityFrameworkCore.Sqlite
- Microsoft.EntityFrameworkCore.Tools
- Newtonsoft.Json

## On-site Deployment

To start the project, you need to initialize the local database first. This can be done by executing the following command in the "Package Manager Console" (under Tools > NuGet Package Manager): `Update-Database`

The database is stored at the following path:
```
C:\Users\<User>\AppData\Local\messe.db
```

After that, you can simply start the project by clicking on "Start". Several projects will be opened: the API server (for testing purposes only; in real deployment, it resides in the company headquarters) and the Messe Client.
