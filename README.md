# ShelfLayout

## Prerequisites

Before you begin, ensure you have met the following requirements:
* You have installed the latest version of [Visual Studio](https://visualstudio.microsoft.com/).
* You have a Windows machine with Docker installed and configured.
* You have cloned the repository to your local machine.

## Setting up Docker Compose for Debugging in Visual Studio

To set up Docker Compose for debugging in Visual Studio, follow these steps:

1. Open the solution in Visual Studio.
2. Right-click on the docker-compose project in Solution Explorer and select 'Set StartUp Projects'.
3. Right-click on the docker-compose project in Solution Explorer and select 'Build'.
4. Right-click on the docker-compose project in Solution Explorer and select 'Compose Up'.
5. Ensure the Docker Desktop is running.
6. Execute 'docker exec sqlserver /opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P saPassword1234 -i /initdb/init-db.sql'.

## Debugging with Docker Compose

To debug your application using Docker Compose in Visual Studio, follow these steps:

1. Press F5 or click 'Start Debugging' from the Debug menu.
2. Visual Studio will build the images, start the containers, and attach the debugger to the services specified in the `docker-compose.yml` and `docker-compose.override.yml` files.
