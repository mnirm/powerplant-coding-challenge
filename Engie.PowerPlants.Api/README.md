# Solution

## Build & Launch api

Go to the Engie.PowerPlants.Api directory you can use the following command when you opend the git repository in your terminal from root folder.

```
cd Engie.PowerPlants.Api/
```

When you are in the folder you can build the project by running following command.

```
dotnet build .
```

To run the project and expose port 8888 you run following command
```
dotnet run --project Engie.PowerPlants.Api --urls=http://localhost:8888/
```

When you have done these steps you should be able to access swagger through https://localhost:8888/swagger/index.html.
> It's also possbile to run this project locally on port 8888 through your IDE just run a startup profile from launchsettings.