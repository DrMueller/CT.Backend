FROM microsoft/dotnet:2.1-aspnetcore-runtime
WORKDIR /app
COPY ./DockerContent .
EXPOSE 80
ENTRYPOINT ["dotnet", "MMmu.Ct.Backend.WebApi.dll"]