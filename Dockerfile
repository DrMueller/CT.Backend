FROM microsoft/aspnetcore:2.1
WORKDIR /app
COPY ./DockerContent .
EXPOSE 80
ENTRYPOINT ["dotnet", "MMmu.Ct.Backend.WebApi.dll"]